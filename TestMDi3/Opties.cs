﻿using System;
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
using System.Xml;

namespace TestMDi3
{
    public partial class Opties : Form
    {
        public static bool mute = false;

        bool applied = true;
        int standaartcount;
        public Opties()
        {
            InitializeComponent();
            //load all themes
            if (!Directory.Exists(@"Themes\" + themename.Text))
            {
                Directory.CreateDirectory(@"Themes\");
                string[] files = Directory.GetDirectories(@"Themes\");
                dropdown.Items.AddRange(files);
                dropdown.Items.Add("Standaard");
                dropdown.SelectedItem = "Standaard";
                StartPosition = FormStartPosition.Manual;
                Location = new Point(0, 0);
            }

            else
            {
                string[] files = Directory.GetDirectories(@"Themes\");
                dropdown.Items.AddRange(files);
                dropdown.Items.Add("Standaard");
                dropdown.SelectedItem = "Standaard";
                StartPosition = FormStartPosition.Manual;
                Location = new Point(0, 0);
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


        /*private void Terug_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.ParentForm;
            f2.Show();
            Close();
        }*/


            /*if (mute == false)
            {
                Volume.BackgroundImage = Properties.Resources.Volume_max;
                Volume.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                Volume.BackgroundImage = Properties.Resources.Volume_Mute;
                Volume.BackgroundImageLayout = ImageLayout.Stretch;
            }*/
        

        private void upload_Click(object sender, EventArgs e)
        {
            //upload een folder voor de themes 
            string targetPath = @"Themes\" + themename.Text + @"\";
            int i=0;

            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo source = new DirectoryInfo(dialog.SelectedPath);
                    if (Directory.GetFiles(Convert.ToString(source)).Length != 32)
                    {
                        MessageBox.Show("Deze map bevat te weinig/te veel foto's");
                        return;
                    }

                    else
                    {
                        Directory.CreateDirectory(targetPath);
                        foreach (var file in source.GetFiles())
                        {
                            File.Copy(file.FullName, targetPath + "picture " + i.ToString() + ".png");
                            i++;
                            File.Copy(file.FullName, targetPath + "picture " + i.ToString() + ".png");
                            i++;
                        }
                        string[] files = Directory.GetDirectories(@"Themes\");

                        MessageBox.Show("Selecteer een foto voor de achterkant van de kaartjes");


                        OpenFileDialog fileDialog = new OpenFileDialog();
                        if (fileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.Copy(fileDialog.FileName, targetPath + @"\defaultpic" + ".png");
                        }
                        dropdown.Items.AddRange(files);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void applysettings()
        {
            applied = true;
            Spel.selectedtheme = dropdown.Text;
            settings();
        }


        //buttons

        private void Apply_Click(object sender, EventArgs e)
        {
            applysettings();
            MessageBox.Show("Instellingen zijn opgeslagen", "Opgeslagen");
        }

        public void settings()
        {
            XmlTextWriter writer = new XmlTextWriter("settings.sav", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("settings");
            writer.WriteElementString("theme", Convert.ToString(Spel.selectedtheme));
            writer.Close();
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            if (applied == false)
            {
                DialogResult dialogResult = MessageBox.Show("U heeft nog niet opgeslagen, Wilt u opslaan?", "Opslaan", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    applysettings();
                    MessageBox.Show("Instellingen zijn opgeslagen", "Opgeslagen");
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

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown.Text == "Standaard" && standaartcount == 0)
            {
                standaartcount++;
                return;
            }
            else
            {
                applied = false;
                MessageBox.Show(dropdown.Text + " is geselecteerd!");
            }
        }

        private void Volume_Click(object sender, EventArgs e)
        {
            applied = false;
            if (mute == false)
            {
                Volume.BackgroundImage = Properties.Resources.Volume_Mute;
                Volume.BackgroundImageLayout = ImageLayout.Stretch;
                mute = true;
            }

            else if (mute == true)
            {
                Volume.BackgroundImage = Properties.Resources.Volume_max;
                Volume.BackgroundImageLayout = ImageLayout.Stretch;
                mute = false;
            }
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
