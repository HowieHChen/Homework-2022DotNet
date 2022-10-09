using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework5
{
    public class Crawler
    {
        private readonly static int THREAD_COUNT = 4;
        private readonly static int RETRY_TIMES = 10;
        private readonly static int RETRY_SPAN = 1000;

        public delegate void PrintLog(string log);
        public delegate void OutputPhone(string phone, string url);
        public delegate void AccessControl(bool enabled);
        public event PrintLog PrintLogDelegate;
        public event OutputPhone OutputPhoneDelegate;
        public event AccessControl AccessControlDelegate;

        private int targetCount = 0;
        private Queue urlQueue = Queue.Synchronized(new Queue());
        private Hashtable urls = Hashtable.Synchronized(new Hashtable());
        private Hashtable phones = Hashtable.Synchronized(new Hashtable());

        private readonly static object _lockerQueue = new object();
        private readonly static object _lockerPhoneHash = new object();

        private readonly static string urlBaidu = "https://www.baidu.com/s?wd=";
        private readonly static string urlBing = "https://cn.bing.com/search?q=";

        private readonly static string httpUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36 Edg/106.0.1370.37";

        private readonly static string urlHostParseRegex = @"https?://(?:[-\w.]|(?:%[\da-fA-F]{2}))+";
        private readonly static string httpParseRegex = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
        private readonly static string hrefParseRegex = @"(?i)<a\s[^>]*?href=(['""]?)(?!javascript|__doPostBack)(?<url>[^'""\s*#<>]+)[^>]*>";
        private readonly static string phoneNumberParseRegex = @"((13[0-9])|(14(0|[5-7]|9))|(15([0-3]|[5-9]))|(16(2|[5-7]))|(17[0-8])|(18[0-9])|(19([0-3]|[5-9])))\d{8}";

        public Crawler(string keyword, bool isBaidu, bool isBing, int targetCount)
        {         
            if ((!isBaidu && !isBing) || targetCount <= 0) return;
            this.targetCount = targetCount;
            string urlBaseBaidu = urlBaidu + System.Web.HttpUtility.UrlEncode(keyword);
            string urlBaseBing = urlBing + System.Web.HttpUtility.UrlEncode(keyword);
            urls.Clear();
            urlQueue.Clear();
            if (isBaidu)
            {
                urls.Add(urlBaseBaidu, false);
                urlQueue.Enqueue(urlBaseBaidu);
            }
            if (isBing)
            {
                urls.Add(urlBaseBing, false);
                urlQueue.Enqueue(urlBaseBing);
            }            
        }


        public void Start()
        {
            phones.Clear();
            AccessControlDelegate(false);
            //Thread[] threads = new Thread[10];
            Task[] tasks = new Task[THREAD_COUNT];
            for (int i = 0; i < THREAD_COUNT; i++)
            {
                tasks[i] = Task.Factory.StartNew(() => Crawl());
            }
            Task.WaitAll(tasks);
            PrintLogDelegate($"线程已全部退出，已爬取{phones.Count.ToString()}个号码");
            AccessControlDelegate(true);
        }

        public void Crawl()
        {
            PrintLogDelegate($"线程{Thread.CurrentThread.ManagedThreadId} 开始爬行");
            int count = RETRY_TIMES;
            while (phones.Count < targetCount)
            {
                string url = string.Empty;
                //lock (_locker)
                {
                    if (urlQueue.Count > 0)
                    {
                        url = (string)urlQueue.Dequeue();
                        if ((bool)urls[url]) continue;
                        PrintLogDelegate($"线程{Thread.CurrentThread.ManagedThreadId} 爬行{url}");
                    }
                }
                if (url != null && url!= string.Empty)
                {
                    count = RETRY_TIMES;
                    try
                    {
                        string html = Download(url).Result;
                        Regex ishtml = new Regex(@"^<!DOCTYPE html>");
                        if (ishtml.IsMatch(html))
                        {
                            PrintLogDelegate($"线程{Thread.CurrentThread.ManagedThreadId} {url}是HTML");
                            Parse(html, url);
                        }
                        else
                        {
                            //PrintErrorDelegate(current);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                else
                {
                    if(count > 0)
                    {
                        count--;
                        PrintLogDelegate($"线程{Thread.CurrentThread.ManagedThreadId} 等待重试，还剩{count}次");
                        Thread.Sleep(RETRY_SPAN);
                        continue;
                    }
                    else
                    {
                        PrintLogDelegate($"线程{Thread.CurrentThread.ManagedThreadId} 已退出, URL队列已空");
                        return;
                    }                    
                }
            }
            PrintLogDelegate($"线程{Thread.CurrentThread.ManagedThreadId} 已退出, 已达到目标个数");
        }

        private async Task<string> Download(string url)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = new TimeSpan(0, 0, 5);
                httpClient.DefaultRequestHeaders.Add("User-Agent", httpUserAgent);
                return await httpClient.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string currentUrl)
        {
            //HTML预处理
            html = Regex.Replace(html, @"\r", string.Empty, RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"\n", string.Empty, RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<script[^>]*?>.*?</script>", string.Empty, RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<title[^>]*?>.*?</title>", string.Empty, RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<head[^>]*?>.*?</head>", string.Empty, RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<img(.[^>]*)>", string.Empty, RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<video[^>]*?>.*?</video>", string.Empty, RegexOptions.IgnoreCase);

            MatchCollection matchHttp = new Regex(httpParseRegex, RegexOptions.IgnoreCase).Matches(html);
            MatchCollection matchHref = new Regex(hrefParseRegex, RegexOptions.IgnoreCase).Matches(html);
            MatchCollection matchPhone = new Regex(phoneNumberParseRegex).Matches(html);
            lock (_lockerQueue)
            {
                foreach (Match match in matchHttp)
                {
                    string url = match.Value;
                    if (url == null || url == "") continue;
                    url = Regex.Replace(url, "&amp;", "&", RegexOptions.IgnoreCase);
                    if (urls[url] == null)
                    {
                        urls[url] = false;
                        urlQueue.Enqueue(url);
                    }
                }
                foreach (Match match in matchHref)
                {
                    string url = match.Groups["url"].Value;
                    if (url == null || url == "") continue;
                    url = Regex.Replace(url, "&amp;", "&", RegexOptions.IgnoreCase);
                    if (Regex.IsMatch(url, @"^/")) url = Regex.Match(currentUrl, urlHostParseRegex).Value + url;
                    if (urls[url] == null)
                    {
                        urls[url] = false;
                        urlQueue.Enqueue(url);
                    }
                }
            }            
            lock (_lockerPhoneHash)
            {
                foreach (Match match in matchPhone)
                {
                    if (Regex.IsMatch(match.Value, @$"^{DateTimeOffset.Now.ToUnixTimeSeconds().ToString().Substring(0, 7)}")) continue;
                    if (phones[match.Value] == null)
                    {
                        OutputPhoneDelegate(match.Value.ToString(), currentUrl);
                        phones[match.Value] = currentUrl;
                    }
                }
            }
        }
    }
}
