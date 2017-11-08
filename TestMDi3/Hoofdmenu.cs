using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace TestMDi3
{
    /// <summary>class Hoofdmenu:Form</summary>
    /// <para>This is the main class for the main menun in the main menu you can go to diffrent submenus like options and play game</para>
    public partial class Hoofdmenu : Form
    {

        /// <summary> method Hoofdmenu()</summary>
        /// <para>this is the main method and loads the default values and changes the language based on language, and if settings excist then it will be loaded in</para>
        public Hoofdmenu()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            if (Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Speel")
                    {
                        button.Text = "Play";
                    }
                    if (button.Text == "Ranglijst")
                    {
                        button.Text = "Highscores";
                    }
                    if (button.Text == "Opties")
                    {
                        button.Text = "Settings";
                    }
                    if (button.Text == "Afsluiten")
                    {
                        button.Text = "Quit";
                    }
                }
            }
                if (File.Exists("settings.sav"))
                {
                    XmlDocument settings = new XmlDocument();
                    settings.Load("settings.sav");
                    Spel.selectedtheme = Convert.ToString(settings.SelectSingleNode("settings/theme").InnerText);
                }
        }


        /// <summary>Method Speel_Click</summary>
        /// <para>This is the method for button speel, when you click on this button the select a gamemode screen will show up, if you control click, the winscreen will show up for testing and closes this current form</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Speel_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                Winscherm winscherm = new Winscherm();
                winscherm.Show();
            }
            else
            {
                Spelers f3 = new Spelers();
                f3.MdiParent = this.ParentForm;
                f3.Show();
                Close();
            }
        }

        /// <summary>method Afsluiten_Click</summary>
        /// <para>this method closes the whole form including the mdi parent</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Afsluiten_Click(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).afsluiten();
        }

        /// <summary>method Opties_Click</summary>
        /// <para>this method loads the options form and closes this current form</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Opties_Click(object sender, EventArgs e)
        {
            Opties opties = new Opties();
            opties.MdiParent = this.ParentForm;
            opties.Show();
            Close();
        }

        /// <summary>method button1_Click</summary>
        /// <para>this method loads the method helpmenu from the spel.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Spel.helpmenu();
        }

        /// <summary>method button2_Click</summary>
        /// <para>this method loads the highscore menu and closes this current form</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Highscore HS = new Highscore();
            HS.MdiParent = this.MdiParent;
            HS.Show();
            Close();
        }
    }
}
