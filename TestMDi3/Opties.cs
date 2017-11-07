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
            if (Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Terug")
                    {
                        button.Text = "Back";
                    }
                    if (button.Text == "Engels")
                    {
                        button.Text = "English";
                    }
                    if (button.Text == "Nederlands")
                    {
                        button.Text = "Dutch";
                    }
                    if (button.Text == "Uploaden")
                    {
                        button.Text = "Upload";
                    }
                    if (button.Text == "Toepassen")
                    {
                        button.Text = "Commit";
                    }
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    if (label.Text == "Nieuw thema")
                    {
                        label.Text = "New theme";
                    }
                    if (label.Text == "Selecteer een thema")
                    {
                        label.Text = "Select a theme";
                    }
                    if (label.Text == "Thema naam:")
                    {
                        label.Text = "Theme name:";
                    }
                }
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
            MessageBox.Show(dropdown.Text + " is geselecteerd!");
        }

        private void taalNederlands_Click(object sender, EventArgs e)
        {
            Spel.taalNederlands = true;
            Spel.taalEngels = false;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button.Text == "Back")
                {
                    button.Text = "Terug";
                }
                if (button.Text == "English")
                {
                    button.Text = "Engels";
                }
                if (button.Text == "Dutch")
                {
                    button.Text = "Nederlands";
                }
                if (button.Text == "Upload")
                {
                    button.Text = "Uploaden";
                }
                if (button.Text == "Commit")
                {
                    button.Text = "Toepassen";
                }
            }
            foreach (Label label in this.Controls.OfType<Label>())
            {
                if (label.Text == "New theme")
                {
                    label.Text = "Nieuw thema";
                }
                if (label.Text == "Select a theme")
                {
                    label.Text = "Selecteer een thema";
                }
                if (label.Text == "Theme name:")
                {
                    label.Text = "Thema naam:";
                }
            }
        }

        private void taalEngels_Click(object sender, EventArgs e)
        {
            Spel.taalEngels = true;
            Spel.taalNederlands = false;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button.Text == "Terug")
                {
                    button.Text = "Back";
                }
                if (button.Text == "Engels")
                {
                    button.Text = "English";
                }
                if (button.Text == "Nederlands")
                {
                    button.Text = "Dutch";
                }
                if (button.Text == "Uploaden")
                {
                    button.Text = "Upload";
                }
                if (button.Text == "Toepassen")
                {
                    button.Text = "Commit";
                }
            }
            foreach (Label label in this.Controls.OfType<Label>())
            {
                if (label.Text == "Nieuw thema")
                {
                    label.Text = "New theme";
                }
                if (label.Text == "Selecteer een thema")
                {
                    label.Text = "Select a theme";
                }
                if (label.Text == "Thema naam:")
                {
                    label.Text = "Theme name:";
                }
            }
        }
        }
    }
