using System.Diagnostics;
using System.Management;
using System.Xml.Linq;

namespace Homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            //string[] drives = Environment.GetLogicalDrives();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Fixed)
                {
                    //���ص�ǰĿ¼
                    TreeNode rootNode = new TreeNode()
                    {
                        Name = drive.Name,
                        Tag = drive.Name,
                        Text = drive.Name,
                        ImageIndex = 1,
                        SelectedImageIndex = 2
                    };
                    //treeView1.Nodes.Add(drive.Name, drive.Name);
                    treeView1.Nodes.Add(rootNode);
                    foreach (var dir in Directory.GetDirectories(drive.Name))
                    {
                        TreeNode node = new TreeNode()
                        {
                            Name = dir,
                            Tag = dir,
                            Text = Path.GetFileName(dir),
                            ImageIndex = 1,
                            SelectedImageIndex = 2
                        };
                        node.Nodes.Add(""); //�ļ��п���չ
                        //node = ListDirectories(node);
                        treeView1.Nodes[drive.Name].Nodes.Add(node);
                    }

                    //���ص�ǰĿ¼�ļ�
                    /*
                    string[] files = Directory.GetFiles(drive.Name, "*.*", SearchOption.TopDirectoryOnly);
                    foreach (var file in files)
                    {
                        TreeNode node = new TreeNode()
                        {
                            Tag = file,
                            Text = Path.GetFileName(file),
                            ImageIndex = 0,
                            SelectedImageIndex = 0
                        };
                        treeView1.Nodes[drive.Name].Nodes.Add(node);
                    }
                    */
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                if (Directory.Exists(e.Node.Tag != null ? e.Node.Tag.ToString() : ""))
                {
                    e.Node.Nodes.Clear();
                    foreach (var dir in Directory.GetDirectories(e.Node.Tag.ToString()))
                    {
                        TreeNode node = new TreeNode()
                        {
                            Name= dir,
                            Tag = dir,
                            Text = Path.GetFileName(dir),
                            ImageIndex = 1,
                            SelectedImageIndex = 2
                        };
                        node.Nodes.Add("");
                        e.Node.Nodes.Add(node);
                    }
                    /*
                    foreach (var file in Directory.GetFiles(e.Node.Tag.ToString(), "*.*", SearchOption.TopDirectoryOnly))
                    {
                        TreeNode node = new TreeNode()
                        {
                            Tag = file,
                            Text = Path.GetFileName(file),
                            ImageIndex = 0,
                            SelectedImageIndex = 0
                        };
                        e.Node.Nodes.Add(node);
                    }
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                e.Node.Expand();
                listView1.Items.Clear();
                if (Directory.Exists(e.Node.Tag != null ? e.Node.Tag.ToString() : ""))
                {
                    e.Node.Nodes.Clear();
                    foreach (var dir in Directory.GetDirectories(e.Node.Tag.ToString()))
                    {
                        TreeNode node = new TreeNode()
                        {
                            Name = dir,
                            Tag = dir,
                            Text = Path.GetFileName(dir),
                            ImageIndex = 1,
                            SelectedImageIndex = 2
                        };
                        node.Nodes.Add("");
                        e.Node.Nodes.Add(node);
                        DirectoryInfo dirInfo = new DirectoryInfo(dir);
                        ListViewItem item = new ListViewItem(new string[] {
                            dirInfo.Name,
                            "",
                            dirInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")
                        })
                        { Tag = dirInfo.FullName, ImageIndex = 1 };
                        listView1.Items.Add(item);
                    }

                    foreach (var file in Directory.GetFiles(e.Node.Tag.ToString(), "*.*", SearchOption.TopDirectoryOnly))
                    {
                        /*
                        TreeNode node = new TreeNode()
                        {
                            Tag = file,
                            Text = Path.GetFileName(file),
                            ImageIndex = 0,
                            SelectedImageIndex = 0
                        };
                        e.Node.Nodes.Add(node);
                        */
                        FileInfo fileInfo = new FileInfo(file);
                        ListViewItem item = new ListViewItem(new string[] {
                            fileInfo.Name,
                            (fileInfo.Length / 1024) + "kb",
                            fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")
                        })
                        { Tag = fileInfo.FullName, ImageIndex = 0 };
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 || listView1.SelectedItems[0].Tag.ToString() == null) return;
            string filePath = listView1.SelectedItems[0].Tag.ToString();
            if (listView1.SelectedItems[0].ImageIndex == 0)  // ѡ�е����ļ�
            {                
                if (filePath.EndsWith(".txt"))
                {
                    Process.Start("notepad.exe", filePath);
                }
                else if (filePath.EndsWith(".exe"))
                {
                    Process.Start(filePath);
                }
                else
                {
                    Process.Start("explorer.exe", filePath);
                }
            }
            else // ѡ�е����ļ���
            {
                var nodes = treeView1.SelectedNode.Nodes.Find(filePath, true);
                if (nodes != null || nodes.Length > 0) treeView1.SelectedNode = nodes[0];
            }
        }

        private void ����Դ�������д�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            if (listView1.SelectedItems.Count <= 0) 
            {
                filePath = treeView1.SelectedNode.Tag.ToString();                
            }
            else
            {
                filePath = listView1.SelectedItems[0].Tag.ToString();
            }
            if(filePath != string.Empty) Process.Start("explorer.exe", filePath);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("��δѡ���κ��ļ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string filePath = listView1.SelectedItems[0].Tag.ToString();
                string fileName = listView1.SelectedItems[0].Text.ToString();
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
                {
                    InitialDirectory = filePath
                };
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = folderBrowserDialog.SelectedPath + "\\" + fileName;
                    if (File.Exists(savePath))
                    {
                        MessageBox.Show("�ļ��Ѵ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    try
                    {
                        File.Copy(filePath, savePath, false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ɾ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 || listView1.SelectedItems[0].ImageIndex != 0)
            {
                MessageBox.Show("��δѡ���κ��ļ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string filePath = listView1.SelectedItems[0].Tag.ToString();
                string fileName = listView1.SelectedItems[0].Text.ToString();
                DialogResult dialogResult = MessageBox.Show("��ȷ��Ҫɾ�� " + filePath + " ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(filePath);
                        listView1.Items.Remove(listView1.Items.OfType<ListViewItem>().FirstOrDefault(x => x.Text == fileName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            listView1_DoubleClick(listView1, new EventArgs());
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            ɾ��ToolStripMenuItem_Click(ɾ��ToolStripMenuItem, new EventArgs());
        }
    }
}