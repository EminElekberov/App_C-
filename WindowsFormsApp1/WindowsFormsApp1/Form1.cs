using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Filename> _file;
        public Form1()
        {
            _file = new List<Filename>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SelectFolder.Text = openFileDialog1.FileName;
            }
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            #region
            //DialogResult dialogResult = openFileDialog2.ShowDialog();
            //FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //if (dialogResult == DialogResult.OK)
            //{
            //    FileInfo file = new FileInfo(SelectFolder.Text);
            //    CopyTxt.Text = Path.Combine(folderBrowser.SelectedPath);
            //    File.Copy(SelectFolder.Text, CopyTxt.Text);
            //}
            #endregion
            try
            {
                string btext = CopyTxt.Text.Trim();
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(btext);
                    CopyTxt.Text = Path.Combine(folderBrowser.SelectedPath, file.Name);
                    File.Copy(SelectFolder.Text, CopyTxt.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("xais olunur xanani doldurun ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            #region
            //string Btex = CopyTxt.Text.Trim();
            //try
            //{
            //    FolderBrowserDialog b1 = new FolderBrowserDialog();
            //    if (b1.ShowDialog() == DialogResult.OK)
            //    {
            //        string PasteTo = b1.SelectedPath + "//" + Path.GetDirectoryName(openFileDialog2.FileName);

            //        MessageBox.Show(b1.SelectedPath);

            //        string path = PasteTo;
            //        if (File.Exists(path))
            //        {
            //            MessageBox.Show("file already exisit");
            //        }
            //        else
            //        {
            //            File.Copy(SelectFolder.Text, PasteTo);
            //            MessageBox.Show("File Copied to New Folder");
            //            return;
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //    //MessageBox.Show("xanani dolfurun");
            //}
            //https://foxlearn.com/windows-forms/copy-file-to-another-directory-in-csharp-385.html
            #endregion
        }
    }
}

