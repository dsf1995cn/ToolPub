using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileGatherTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTarget_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            ChooseFolder(tbSource);
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            ChooseFolder(tbTarget);
        }

        private void ChooseFolder(object sender)
        {
            TextBox tb0 = sender as TextBox;
            var folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "Choose a folder";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (tb0.Text?.Length > 0) folderBrowserDialog1.SelectedPath = tb0.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb0.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ceMusic_CheckedChanged(object sender, EventArgs e)
        {
            SetChooseEnable();
        }

        private void ceVideo_CheckedChanged(object sender, EventArgs e)
        {
            SetChooseEnable();
        }

        public void SetChooseEnable()
        {
            if (ceMusic.Checked || ceMusic.Checked)
            {
                ceChooseExt.Enabled = rbRich.Enabled = false;
            }
            else
            {
                ceChooseExt.Enabled = rbRich.Enabled = true;
            }
        }

        private void ceChooseExt_CheckedChanged(object sender, EventArgs e)
        {
            if (ceChooseExt.Checked)
            {
                ceMusic.Enabled = ceVideo.Enabled = !ceChooseExt.Checked;
                ceMusic.Checked = ceVideo.Checked = !ceChooseExt.Checked;
            }
            else
            {
                ceMusic.Enabled = ceVideo.Enabled = !ceChooseExt.Checked;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var sourcePath = tbSource.Text.Trim();
            var targetPath = tbTarget.Text.Trim();

          

            if (string.IsNullOrEmpty(tbSource.Text.Trim())|| string.IsNullOrEmpty(tbTarget.Text.Trim()))
            {
                return;
            }

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Source path error！");
                return;
            }

            if (!Directory.Exists(targetPath))
            {
                MessageBox.Show("Target path error！");
                return;
            }

            if (!targetPath.EndsWith("\\"))
            {
                targetPath =targetPath+"\\";
            }

           
            List<string> extRang = new List<string>();
            if (ceMusic.Checked)
            {
                extRang.AddRange("MP3，WMA，WAV，APE，FLAC，OGG，AAC".Split(','));
            }

            if (ceVideo.Checked)
            {
                extRang.AddRange("AVI, MP4, DAT, DVR,VCD, MOV, SVCD, VOB, DVD, DVTR, DVR, BBC, EVD, FLV, RMVB, WMV, MKV, 3GP".Split(','));
            }

            if (ceChooseExt.Checked)
            {
                if(string.IsNullOrEmpty(rbRich.Text.Trim()))
                {
                    MessageBox.Show("Input ext name error!");
                    return;
                }
                else
                {
                    extRang.AddRange(rbRich.Text.Trim()?.Split(','));
                }
            }

            List<string> extList = new List<string>();
            foreach (var item in extRang)
            {
                if (!string.IsNullOrEmpty((item)))
                {
                    var ss = "." + item.Trim();
                    extList.Add(ss);
                }
            }


            if (!extList.Any())
            {
                MessageBox.Show("No valid ext name error!");
                return;
            }

            var lst = new List<string>();
            var dict = new Dictionary<string, string>();
            this.Director(sourcePath, lst, dict, extList);
            foreach (var info in lst)
            {
                DirectoryInfo d = new DirectoryInfo(targetPath);
                FileInfo[] files = d.GetFiles();
                if (!files.Any(t => (t.Name == dict[info])))
                    try
                    {
                        if (rbMove.Checked)
                        {
                            File.Delete(targetPath + dict[info]);
                            File.Move(info, targetPath + dict[info]);
                        }
                        if (rbCopy.Checked)
                        {
                            File.Copy(info, targetPath + dict[info]);
                        }
                    }
                    catch (Exception exception)
                    {

                    }
            }

            MessageBox.Show("Finished！");
        }

        public void Director(string dir, List<string> list, Dictionary<string, string> dict,List<string> extList)
        {
            //dict = new Dictionary<string, string>();
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] files = d.GetFiles();
            DirectoryInfo[] directs = d.GetDirectories();
            foreach (FileInfo f in files)
            {
                if (extList.Contains(f.Extension?.ToUpper()) )
                {
                    if (!dict.ContainsKey(f.Name))
                    {
                        dict.Add(f.FullName, f.Name);
                    }
                    list.Add(f.FullName);
                }
            }
          
            foreach (DirectoryInfo dd in directs)
            {
                Director(dd.FullName, list, dict, extList);
            }
        }
    }
}
