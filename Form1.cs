using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagetextRenamer
{
    public partial class Form1 : Form
    {
        string[] ValidImageExtensions = new string[] { ".jpg", ".jpeg", ".png", ".tif" };

        public int MaxImageIndex { get; set; }
        public int CurrentImageIndex { get; set; }
        public List<KeyValuePair<int, string>> ImageFullNames { get; set; }
        public int specifyPagenumber { get; set; }

        public Form1()
        {
            InitializeComponent();

            ImageFullNames = new List<KeyValuePair<int, string>>();

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;

            cov_button.Enabled = false;
            bok_button.Enabled = false;
            leg_button.Enabled = false;
            fow_button.Enabled = false;
            con_button.Enabled = false;
            txt_button.Enabled = false;
            txtreset_button.Enabled = false;
            ins_button.Enabled = false;
            att_button.Enabled = false;
            bac_button.Enabled = false;

            sort_button.Enabled = false;
            close_button.Enabled = false;
            rename_button.Enabled = false;
            CurrentImageIndex = 0;

        }
        public void ListFiles(FileSystemInfo info)
        {
            if (!info.Exists) return;

            DirectoryInfo dir = info as DirectoryInfo;
            //不是目录
            if (dir == null) return;

            FileSystemInfo[] files = dir.GetFileSystemInfos();
            foreach (FileSystemInfo fileSystemInfo in files)
            {
                if (fileSystemInfo is FileInfo)
                {
                    string fileName = fileSystemInfo.Name.Substring(0, fileSystemInfo.Name.LastIndexOf('.'));
                    string fileExtension = fileSystemInfo.Extension.ToLower();

                    if (ValidImageExtensions.Contains(fileExtension))
                    {
                        //panImage.BackgroundImage = System.Drawing.Image.FromFile(fileSystemInfo.FullName);
                        KeyValuePair<int, string> name = new KeyValuePair<int, string>(ImageFullNames.Count, fileSystemInfo.FullName);
                        ImageFullNames.Add(name);
                    }
                }
                else
                {
                    ListFiles(fileSystemInfo);

                }
            }
        }
        private void SetImage(int imageIndex)
        {
            string path = ImageFullNames.Where(a => a.Key == imageIndex).FirstOrDefault().Value;
            if (String.IsNullOrEmpty(path))
            {
                panImage.BackgroundImage = null;
            }
            else
            {

                System.Drawing.Image image = System.Drawing.Image.FromFile(path);
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(image);
                panImage.BackgroundImage = bmp;
                image.Dispose();
                //panImage.BackgroundImage = System.Drawing.Image.FromFile(path);

            }
            //panImage.BackgroundImage.
        }
        private string number2three(int i)
        {
            string Filename = "";
            if (i > 9)
            {
                Filename = "0" + i.ToString();
            }
            else
            {
                Filename = "00" + i.ToString();
            }
            return Filename;

        }

        private string number2six(int i)
        {
            string Filename="";
            if (i > 9999)
            {
                Filename = "0" + i.ToString();
            }
            else if (i > 999)
            {
                Filename = "00" + i.ToString();
            }
            else if (i > 99)
            {
                Filename = "000" + i.ToString();
            }
            else if (i > 9)
            {
                Filename = "0000" + i.ToString();
            }
            else
            {
                Filename = "00000" + i.ToString();
            }
            return Filename;

        }

        private void loadList(string path)
        {
            ListFiles(new DirectoryInfo(path));

            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            for (int index = 0; index < ImageFullNames.Count; index++)
            {

                ListViewItem lvi = new ListViewItem();

                lvi.Text = Path.GetFileNameWithoutExtension(ImageFullNames[index].Value);
                lvi.SubItems.Add(Path.GetExtension(ImageFullNames[index].Value));
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                this.listView1.Items.Add(lvi);

            }
            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
            SetImage(0);

            listView1.Items[0].Selected = true;//设定选中            
            listView1.Items[0].EnsureVisible();//保证可见
            listView1.Items[0].Focused = true;
            listView1.Select();

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnFirst.Enabled = false;
            btnLast.Enabled = true;

            cov_button.Enabled = true;
            bok_button.Enabled = true;
            leg_button.Enabled = true;
            fow_button.Enabled = true;
            con_button.Enabled = true;
            txt_button.Enabled = true;
            txtreset_button.Enabled = true;
            ins_button.Enabled = true;
            att_button.Enabled = true;
            bac_button.Enabled = true;

            Image img = Image.FromFile(ImageFullNames[CurrentImageIndex].Value);
            textBox2.Text = img.PhysicalDimension.Width.ToString() + " x " + img.PhysicalDimension.Height.ToString();
            img.Dispose();

            close_button.Enabled = true;
            sort_button.Enabled = true;
        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {

            Array paths = ((System.Array)e.Data.GetData(DataFormats.FileDrop));       //获得路径
            String path0 = paths.GetValue(0) as String;
            String path1 = Path.GetDirectoryName(path0);


            if (!String.IsNullOrWhiteSpace(path0))
            {
                if (Directory.Exists(path0))
                {
                    textBox1.Text = path0;
                    loadList(path0);
                }
                else
                if (Directory.Exists(path1))
                {
                    loadList(path1);
                }


                }


            }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }

        }


        private void openFolder_button_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    textBox1.Text = folderBrowserDialog1.DirectoryPath;
                    loadList(folderBrowserDialog1.DirectoryPath);
                }
                catch (Exception exception)
                {
                    //MessageBox.Show("保存失败!");
                    throw exception;
                }
                //MessageBox.Show("保存files_count.xlsx成功!");
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            listView1.Items[CurrentImageIndex].Focused = false;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;

            CurrentImageIndex = 0;
            SetImage(CurrentImageIndex);

            btnPrevious.Enabled = false;

            listView1.SelectedItems.Clear();
            listView1.Items[CurrentImageIndex].Selected = true;//设定选中            
            listView1.Items[CurrentImageIndex].EnsureVisible();//保证可见
            listView1.Items[CurrentImageIndex].Focused = true;
            listView1.Select();
        }



        private void btnLast_Click(object sender, EventArgs e)
        {
            listView1.Items[CurrentImageIndex].Focused = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;

            CurrentImageIndex = ImageFullNames.Count - 1;
            SetImage(CurrentImageIndex);

            btnNext.Enabled = false;

            listView1.SelectedItems.Clear();
            listView1.Items[CurrentImageIndex].Selected = true;//设定选中            
            listView1.Items[CurrentImageIndex].EnsureVisible();//保证可见
            listView1.Items[CurrentImageIndex].Focused = true;
            listView1.Select();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            listView1.Items[CurrentImageIndex].Focused = false;
            
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;

            if (CurrentImageIndex < ImageFullNames.Count - 1)
            {
                CurrentImageIndex++;
                SetImage(CurrentImageIndex);

                if (CurrentImageIndex == ImageFullNames.Count - 1)
                    btnNext.Enabled = false;
            }
            listView1.SelectedItems.Clear();
            listView1.Items[CurrentImageIndex].Selected = true;//设定选中            
            listView1.Items[CurrentImageIndex].EnsureVisible();//保证可见
            listView1.Items[CurrentImageIndex].Focused = true;
            listView1.Select();


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            listView1.Items[CurrentImageIndex].Focused = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;

            if (CurrentImageIndex > 0)
            {
                CurrentImageIndex--;
                SetImage(CurrentImageIndex);

                if (CurrentImageIndex == 0)
                    btnPrevious.Enabled = false;
            }

            listView1.SelectedItems.Clear();
            listView1.Items[CurrentImageIndex].Selected = true;//设定选中            
            listView1.Items[CurrentImageIndex].EnsureVisible();//保证可见
            listView1.Items[CurrentImageIndex].Focused = true;
            listView1.Select();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            SetImage(listView1.FocusedItem.Index);
            CurrentImageIndex= listView1.FocusedItem.Index;

            Image img = Image.FromFile(ImageFullNames[CurrentImageIndex].Value);
            textBox2.Text = img.PhysicalDimension.Width.ToString() + " x " + img.PhysicalDimension.Height.ToString();
            img.Dispose();

        }
        private void listViewNextLine()
        {
            if (listView1.FocusedItem.Index + 1 < listView1.Items.Count)
            { 
            listView1.SelectedItems.Clear();
            listView1.Items[listView1.FocusedItem.Index + 1].Selected = true;//设定选中            
            listView1.Items[listView1.FocusedItem.Index + 1].EnsureVisible();//保证可见
            listView1.Items[listView1.FocusedItem.Index + 1].Focused = true;
            listView1.Select();

            SetImage(listView1.FocusedItem.Index);
            Image img = Image.FromFile(ImageFullNames[CurrentImageIndex].Value);
            textBox2.Text = img.PhysicalDimension.Width.ToString() + " x " + img.PhysicalDimension.Height.ToString();
            img.Dispose();
            }
        }
        private void cov_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "cov";
            listViewNextLine();

        }

        private void leg_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "leg";

            listViewNextLine();

        }

        private void bok_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "bok";

            listViewNextLine();

        }

        private void con_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "!";

            listViewNextLine();

        }

        private void ins_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "ins";

            listViewNextLine();

        }

        private void att_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "att";

            listViewNextLine();

        }

        private void fow_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "fow";

            listViewNextLine();

        }

        private void bac_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "bac";

            listViewNextLine();

        }

        private void txt_button_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = "00";

            listViewNextLine();

        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            int cov=1;
            int bok=1;
            int leg=1;
            int fow=1;
            int con=1;
            int txt=1;
            int ins=1;
            int att=1;
            int bac=1;



            foreach (ListViewItem item in this.listView1.Items)
            {
                //处理行
                if (item.SubItems[2].Text.Equals("cov"))
                {
                    item.SubItems[3].Text = "cov" + number2three(cov) + item.SubItems[1].Text;
                    cov++;
                }
                else
                if (item.SubItems[2].Text.Equals("bok"))
                {
                    item.SubItems[3].Text = "bok" + number2three(bok) + item.SubItems[1].Text;
                    bok++;
                }
                else
                if (item.SubItems[2].Text.Equals("leg"))
                {
                    item.SubItems[3].Text = "leg" + number2three(leg) + item.SubItems[1].Text;
                    leg++;
                }
                else
                if (item.SubItems[2].Text.Equals("fow"))
                {
                    item.SubItems[3].Text = "fow" + number2three(fow) + item.SubItems[1].Text;
                    fow++;
                }
                else
                if (item.SubItems[2].Text.Equals("!"))
                {
                    item.SubItems[3].Text = "!00" + number2three(con) + item.SubItems[1].Text;
                    con++;
                }
                else
                if (item.SubItems[2].Text.Equals("00") | item.SubItems[2].Text.Equals(""))
                {
                    item.SubItems[3].Text = number2six(txt) + item.SubItems[1].Text;
                    txt++;
                }
                else
                if (item.SubItems[2].Text.Equals("ins"))
                {
                    item.SubItems[3].Text = "ins" + number2three(ins) + item.SubItems[1].Text;
                    ins++;
                }
                else
                if (item.SubItems[2].Text.Equals("att"))
                {
                    item.SubItems[3].Text = "att" + number2three(att) + item.SubItems[1].Text;
                    att++;
                }
                else
                if (item.SubItems[2].Text.Equals("bac"))
                {
                    item.SubItems[3].Text = "bac" + number2three(bac) + item.SubItems[1].Text;
                    bac++;
                }
                else
                {
                    item.SubItems[3].Text = item.SubItems[2].Text + item.SubItems[1].Text;
                    txt = Convert.ToInt32(item.SubItems[2].Text)+1;
                }


             }
            rename_button.Enabled = true;
            this.Text += "*";
        }
        private void reFilename(string currPath,string oldName, string newName)
        {

            string sourceFileName = "";
            if (!string.IsNullOrEmpty(newName))
            {
                string currFilePath = Path.Combine(currPath, oldName);
                sourceFileName = currFilePath;
                if (File.Exists(Path.Combine(currPath, newName)))
                {
                    MessageBox.Show(newName+"，文件夹中存在此名称文件，请更改文件名。");
                }
                else
                {
                    currFilePath = Path.Combine(currPath, newName);
                    FileInfo fileInfo = new FileInfo(sourceFileName);
                    fileInfo.MoveTo(currFilePath);
                }
            }

        }
        private void rename_button_Click(object sender, EventArgs e)
        {   
            if (panImage.BackgroundImage != null)
            {
                panImage.BackgroundImage.Dispose();
            }
            panImage.BackgroundImage = null;

            string filePath = textBox1.Text;

            foreach (ListViewItem item in this.listView1.Items)
            {
                //处理行
                string sourceName = item.SubItems[0].Text + item.SubItems[1].Text;
                string newName = item.SubItems[3].Text;
                reFilename(filePath, sourceName, newName);
                //改名图片
                string sourceFile= Path.Combine(filePath, sourceName);
                string newFile= Path.Combine(filePath, newName);

                string txtFullNameWithoutExt = sourceFile.Substring(0, sourceFile.LastIndexOf('.'));
                string newtxtFullNameWithoutExt = newFile.Substring(0, newFile.LastIndexOf('.'));
                string txtFullName = String.Empty;
                if (File.Exists(txtFullNameWithoutExt + ".txt"))
                {
                    txtFullName = txtFullNameWithoutExt + ".txt";
                }
                else if (File.Exists(txtFullNameWithoutExt + ".xml"))
                {
                    txtFullName = txtFullNameWithoutExt + ".xml";
                }
                else if (File.Exists(txtFullNameWithoutExt + ".html"))
                { txtFullName = txtFullNameWithoutExt + ".html"; }
                else if (File.Exists(txtFullNameWithoutExt + ".htm"))
                { txtFullName = txtFullNameWithoutExt + ".htm"; }

                if (File.Exists(txtFullName))
                {
                    reFilename(filePath,Path.GetFileName(txtFullName), newtxtFullNameWithoutExt+ Path.GetExtension(txtFullName));


                }
                close();
            }
            this.Text = this.Text.TrimEnd('*');

        }


        private void close()
        {
            if (panImage.BackgroundImage != null)
            {
                panImage.BackgroundImage.Dispose();
            }
            panImage.BackgroundImage = null;
            listView1.Items.Clear();

            ImageFullNames = new List<KeyValuePair<int, string>>();

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;

            cov_button.Enabled = false;
            bok_button.Enabled = false;
            leg_button.Enabled = false;
            fow_button.Enabled = false;
            con_button.Enabled = false;
            txt_button.Enabled = false;
            txtreset_button.Enabled = false;
            ins_button.Enabled = false;
            att_button.Enabled = false;
            bac_button.Enabled = false;

            sort_button.Enabled = false;
            close_button.Enabled = false;
            rename_button.Enabled = false;
            CurrentImageIndex = 0;



        }
        private void close_button_Click(object sender, EventArgs e)
        {
            close();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            SetImage(listView1.FocusedItem.Index);
            CurrentImageIndex = listView1.FocusedItem.Index;

            Image img = Image.FromFile(ImageFullNames[CurrentImageIndex].Value);
            textBox2.Text = img.PhysicalDimension.Width.ToString() + " x " + img.PhysicalDimension.Height.ToString();
            img.Dispose();

        }

        private void txtreset_button_Click(object sender, EventArgs e)
        {

            if (listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text == "")
            {
                specifyPagenumber=Convert.ToInt32(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text);
            }
            else
            {
                specifyPagenumber = Convert.ToInt32(listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text.Substring(0, listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text.IndexOf('.')));
            }

            pageNumber window = new pageNumber(this);
            window.ShowDialog();
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text= number2six(specifyPagenumber).ToString();

        }


        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.UseFading = true;
            this.toolTip1.Show("关闭当前文件夹", this.close_button);
        }
        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(close_button);     //隐藏提示窗口
        }

        private void sort_button_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.UseFading = true;
            this.toolTip1.Show("重新编号", this.sort_button);

        }

        private void sort_button_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(sort_button);     //隐藏提示窗口

        }

        private void rename_button_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.UseFading = true;
            this.toolTip1.Show("改名", this.rename_button);

        }

        private void rename_button_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(rename_button);     //隐藏提示窗口

        }
    }
    }


