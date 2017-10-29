using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestMDi3
{
    public partial class Opties : Form
    {

        public Opties()
        {
            InitializeComponent();
            if (!Directory.Exists(@"Themes\" + themename.Text))
            {
                Directory.CreateDirectory(@"Themes\");
                string[] files = Directory.GetDirectories(@"Themes\");
                this.dropdown.Items.AddRange(files);
                this.dropdown.Items.Add("Default");
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(0, 0);
            }

            else
            {
                string[] files = Directory.GetDirectories(@"Themes\");
                this.dropdown.Items.AddRange(files);
                this.dropdown.Items.Add("Default");
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(0, 0);
            }


        }

        private void Terug_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.ParentForm;
            f2.Show();
            Close();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            //upload een folder voor de themes 
            string targetPath = @"Themes\" + themename.Text;
            string source = "";
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    source = dialog.SelectedPath;
                    DirectoryCopy(source, targetPath);
                    string[] files = Directory.GetDirectories(@"Themes\");
                    this.dropdown.Items.AddRange(files);
                    this.dropdown.Items.Add("Default");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            // Haalt de mapjes op.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("De geselecteerde map kon niet worden gevonden: " + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Spel.selectedtheme = dropdown.Text;
        }
    }
}
