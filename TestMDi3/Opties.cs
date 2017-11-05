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
using System.Runtime.InteropServices;
using AudioSwitcher.AudioApi.CoreAudio;

namespace TestMDi3
{
    public partial class Opties : Form
    {
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        bool applied = true;

        public Opties()
        {
            InitializeComponent();
            //set volume values

            trackBar1.Value = Convert.ToInt32(defaultPlaybackDevice.Volume);
            checkVolume();

            //load all themes
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

        public void checkVolume()
        {
            if (trackBar1.Value > 101 || trackBar1.Value < 50)
            {
                pictureBox.Image = Properties.Resources.Volume_2;
            }

            if ((trackBar1.Value > 49 || trackBar1.Value < 1))
            {
                pictureBox.Image = Properties.Resources.Volume_max;
            }

            if (trackBar1.Value == 0)
            {
                pictureBox.Image = Properties.Resources.Volume_Mute;
            }
        }

        public void applysettings()
        {
            applied = true;
            Spel.selectedtheme = dropdown.Text;
            MessageBox.Show("Instellingen zijn opsgeslagen", "Opgeslagen");

        }


        //buttons

        private void Apply_Click(object sender, EventArgs e)
        {
            applysettings();
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            if (applied == false)
            {
                DialogResult dialogResult = MessageBox.Show("U heeft nog niet opgeslagen; Wilt u opslaan?", "Opslaan", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    applysettings();
                    Hoofdmenu f2 = new Hoofdmenu();
                    f2.MdiParent = this.ParentForm;
                    f2.Show();
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Hoofdmenu f2 = new Hoofdmenu();
                    f2.MdiParent = this.ParentForm;
                    f2.Show();
                    Close();
                }
            }
            else
            {
                Hoofdmenu f2 = new Hoofdmenu();
                f2.MdiParent = this.ParentForm;
                f2.Show();
                Close();
            }
        }

        //Controls the Volume
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = trackBar1.Value;
            checkVolume();
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            applied = false;
            MessageBox.Show(dropdown.Text + " is geselecteerd!");
        }
    }
}
