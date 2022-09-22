using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework3
{
    public class FuncUtils
    {
        private const string pattern = @"\,|\.|\ |_|\n|\r|\?|\;|\:|\!|\042|/|\{|\}|\(|\)|\[|\]|[\u4e00-\u9fa5]|[0-9]";
        public static void BaseCount(string filePath, out int wordCount, out int lineCount)
        {
            wordCount = lineCount = 0;
            StringBuilder sb = new StringBuilder();
            string line = string.Empty;
            Regex regex = new Regex(pattern);            
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != string.Empty && line.Trim() != string.Empty)
                        {
                            lineCount++;
                            sb.AppendLine(line.ToLower());
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            string[] words = regex.Replace(sb.ToString(), " ").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            wordCount = words.Length;
        }
        
        public static Hashtable AdvancedCount(string filePath, out int wordCount, out int lineCount)
        {
            wordCount = lineCount = 0;
            StringBuilder sb = new StringBuilder();
            string line = string.Empty;
            Regex regex = new Regex(pattern);
            Hashtable hashtable = new Hashtable();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {                
                    while((line = sr.ReadLine()) != null)
                    {
                        if(line != string.Empty && line.Trim() != string.Empty)
                        {
                            lineCount++;
                            sb.AppendLine(line.ToLower());
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            string[] words = regex.Replace(sb.ToString(), " ").Split(' ',StringSplitOptions.RemoveEmptyEntries);
            wordCount = words.Length;
            foreach(string word in words)
            {
                if(word != null && word != string.Empty)
                {
                    if (hashtable.Contains(word))
                    {
                        int.TryParse(hashtable[word].ToString(), out int result);
                        hashtable[word] = result + 1;
                    }
                    else
                    {
                        hashtable.Add(word, 1);
                    }
                }
            }
            return hashtable;
        }

        public static string FormatText(string filePath)
        {
            string pattern = @"//.*";
            string line = string.Empty;
            Regex regex = new Regex(pattern);
            StringBuilder sb = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = regex.Replace(line, string.Empty);
                        if (line != string.Empty && line.Trim() != string.Empty)
                        {
                            sb.AppendLine(line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
            }
            string newFilePath = filePath.Replace(".cs", "_new.cs");
            try
            {
                using (StreamWriter sw = new StreamWriter(newFilePath, false, Encoding.UTF8))
                {
                    sw.Write(sb);
                    sw.Flush();
                }
            }
            catch (Exception e)
            {

            }
            return newFilePath;
        }
    }
}
