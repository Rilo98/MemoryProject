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
using System.Xml;

namespace TestMDi3
{
    /// <summary>class Opties</summary>
    /// <para>in this class you can change the settings of the game</para>
    /// <para>Creator: Kevin</para>
    public partial class Opties : Form
    {
        /// <summary>these are the initial values of the settings</summary>
        /// <para>public static bool mute: this is the public bool to turn of the sound at the winscreen</para>
        public static bool mute = false;
        /// <para>bool applied: when the settings are changed the bool goes to false, so you need to apply before you exit</para>
        bool applied = true;
        /// <para>int standaartcount: when the default theme is selected the counter goes to 1 so when the settings are changed the count goes to 1, so you need to apply before you exit </para>
        int standaartcount;

        /// <summary>method options</summary>
        /// <para>this value loads the default values and fills the dropdown menu</para>
        /// <para>Creator: Kevin</para>
        public Opties()
        {
            InitializeComponent();
            Volume.BackgroundImage = Properties.Resources.Volume_max;

            //load all themes
            if (!Directory.Exists(@"Themes\" + themename.Text))
            {
                Directory.CreateDirectory(@"Themes\");
                string[] files = Directory.GetDirectories(@"Themes\");
                dropdown.Items.AddRange(files);
                if (Spel.taalEngels == false)
                {
                    dropdown.Items.Add("Standaard");
                    dropdown.SelectedItem = "Standaard";
                }
                if (Spel.taalEngels == true)
                {
                    dropdown.Items.Add("Default");
                    dropdown.SelectedItem = "Default";
                }
                StartPosition = FormStartPosition.Manual;
                Location = new Point(0, 0);
            }

            else
            {
                string[] files = Directory.GetDirectories(@"Themes\");
                dropdown.Items.AddRange(files);
                if (Spel.taalEngels == false)
                {
                    dropdown.Items.Add("Standaard");
                    dropdown.SelectedItem = "Standaard";
                }
                if (Spel.taalEngels == true)
                {
                    dropdown.Items.Add("Default");
                    dropdown.SelectedItem = "Default";
                }
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
                    if (label.Text == "Spel volume")
                    {
                        label.Text = "Game volume:";
                    }
                    if (label.Text == "Thema's")
                    {
                        label.Text = "Themes";
                    }
                    if (label.Text == "Selecteer een taal")
                    {
                        label.Text = "Select a language";
                    }
                }
            }
        }

        /// <summary>mehtod upload_Click</summary>
        /// <para>this method opens the filebrowser dialog and it will then copy files and check the images</para>
        /// <para>Creator: Kevin</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        if(Spel.taalEngels == false)
                        {
                            MessageBox.Show("Deze map bevat te weinig/te veel foto's");
                        }
                        if (Spel.taalEngels == true)
                        {
                            MessageBox.Show("Pictures quantity out of range");
                        }

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
                        if (Spel.taalEngels == false)
                        {
                            MessageBox.Show("Selecteer een foto voor de achterkant van de kaartjes");
                        }
                        if (Spel.taalEngels == true)
                        {
                            MessageBox.Show("Select a picture for the backside of the cards");
                        }


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

        /// <summary>method applysettings</summary>
        /// <para>this method applies the settings and calls the settings mehtod</para>
        /// <para>Creator: Kevin</para>
        public void applysettings()
        {
            applied = true;
            Spel.selectedtheme = dropdown.Text;
            settings();
        }

        /// <summary>method Apply_Click</summary>
        /// <para>this mehtod calls the apply settings method and changes the settings</para>
        /// <para>Creator: Kevin</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            applysettings();
            if(Spel.taalEngels == false)
            {
               
            }
            if(Spel.taalEngels == true)
            {
                MessageBox.Show("Settings are saved", "Saved");
            }
        }

        /// <summary>method settings</summary>
        /// <para>this writes the settings to a save file</para>
        /// <para>Creator: Andries </para>
        public void settings()                         
        {
            XmlTextWriter writer = new XmlTextWriter("settings.sav", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("settings");
            writer.WriteElementString("theme", Convert.ToString(Spel.selectedtheme));
            writer.Close();
        }

        /// <summary>method Terug_Click</summary>
        /// <para>this method is made to go back to the main menu and checks if you have saved your settings if not you will be prompted to save the settings</para>
        /// <para>Creator: Kevin </para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Terug_Click(object sender, EventArgs e)
        {
            if (applied == false)
            {
                if(Spel.taalEngels == false)
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
                if (Spel.taalEngels == true)
                {
                    DialogResult dialogResult = MessageBox.Show("You did not save your changes, do you want to save now?", "Save", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        applysettings();
                        MessageBox.Show("Settings are saved", "Saved");
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

            }
            else
            {
                Hoofdmenu f2 = new Hoofdmenu();
                f2.MdiParent = this.ParentForm;
                f2.Show();
                Close();
            }
        }

        /// <summary>method dropdown_SelectedIndexChanged</summary>
        /// <para>when the dropdown value is changed it will give you a prompt that the settings have been changed</para>
        /// <para>Creator: Kevin</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (Spel.taalEngels == false)
                {
                    MessageBox.Show(dropdown.Text + " is geselecteerd!");
                }
                if (Spel.taalEngels == true)
                {
                    MessageBox.Show(dropdown.Text + " is selected!");
                }
            }
        }

        /// <summary>method Volume_Click</summary>
        /// <para>when the button is clicked the image will change based on the bool value</para>
        /// <para>Creator: Kevin</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>method taalNederlands_Click</summary>
        /// <para>when the language is selected the language of all text and buttons will change to the selected language</para>
        /// <para>Creator: Hidzer</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (label.Text == "Game volume:")
                {
                    label.Text = "Spel volume";
                }
                if (label.Text == "Themes")
                {
                    label.Text = "Thema's";
                }
                if (label.Text == "Select a language")
                {
                    label.Text = "Selecteer een taal";
                }
            }
            if (Spel.taalEngels == false)
            {
                dropdown.Items.Remove("Default");
                dropdown.Items.Add("Standaard");
                dropdown.SelectedItem = "Default";
            }
        }

        /// <summary>method taalEngels_Click</summary>
        /// <para>when the language is selected the language of all text and buttons will change to the selected language</para>
        /// <para>Creator: Hidzer</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (label.Text == "Spel volume")
                {
                    label.Text = "Game volume:";
                }
                if (label.Text == "Thema's")
                {
                    label.Text = "Themes";
                }
                if (label.Text == "Selecteer een taal")
                {
                    label.Text = "Select a language";
                }
            }
            if (Spel.taalEngels == true)
            {
                dropdown.Items.Remove("Standaard");
                dropdown.Items.Add("Default");
                dropdown.SelectedItem = "Default";
            }
        }
        }
    }
