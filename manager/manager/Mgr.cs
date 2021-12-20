using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace manager
{
    public partial class Mgr : System.Windows.Forms.Form
    {
        private string filePath = @"C:\";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        private string tmpName = "";
        public Mgr()
        {
            InitializeComponent();
        }
        private void Mgr_Load_1(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); 
                    DirectoryInfo[] dirs = fileList.GetDirectories(); 
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 38);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 44);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 56);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 26);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 12);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 42);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 24);
                                break;
                        }
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 28);
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {            
            removeBackSlash();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            FileAttributes attr = File.GetAttributes(filePath + "\\" + listView1.SelectedItems[0].Text);

            if (attr.HasFlag(FileAttributes.Directory))
            {
                Directory.Delete(filePath + "\\" + listView1.SelectedItems[0].Text, true);
                filePathTextBox.Text = filePath;
            }
            else
                File.Delete(filePath + "\\" + listView1.SelectedItems[0].Text);
            // Удаляем из ListView
            loadButtonAction();
            loadButtonAction();
            fileNameLabel.Text = "";
            fileTypeLabel.Text = "";
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            tmpName = "";
            Clipboard.SetText(filePath + "/" + this.currentlySelectedItemName);
            tmpName = this.currentlySelectedItemName;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            filePath = filePathTextBox.Text;
            if (filePath.LastIndexOf("/") == filePath.Length - 1 || filePath.LastIndexOf(@"\") == filePath.Length - 1)
                File.Copy(Clipboard.GetText(), filePath + tmpName);
            else
                File.Copy(Clipboard.GetText(), filePath + "/" + tmpName);
            loadButtonAction();
        }

        private void DirectoryCopy(string v1, string v2, bool v3)
        {
            throw new NotImplementedException();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            filePath = filePathTextBox.Text;
            if (filePath.LastIndexOf("/") == filePath.Length - 1 || filePath.LastIndexOf(@"\") == filePath.Length - 1)
                File.Copy(Clipboard.GetText(), filePath + tmpName);
            else
                File.Copy(Clipboard.GetText(), filePath + "/" + tmpName);
            File.Delete(Clipboard.GetText());
            // Удаляем из ListView
            loadButtonAction();
            loadButtonAction();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                string someText = Clipboard.GetText();
                MessageBox.Show(this, someText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            { 
                MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
