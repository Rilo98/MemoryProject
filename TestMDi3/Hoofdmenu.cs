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
    public partial class Hoofdmenu : Form
    {
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
                if (File.Exists("settings.sav"))
                {
                    XmlDocument settings = new XmlDocument();
                    settings.Load("settings.sav");
                    Spel.selectedtheme = Convert.ToString(settings.SelectSingleNode("settings/theme").InnerText);
                }
            }
        }
            
        

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

        private void Afsluiten_Click(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).afsluiten();
        }

        private void Opties_Click(object sender, EventArgs e)
        {
            Opties opties = new Opties();
            opties.MdiParent = this.ParentForm;
            
            opties.Show();
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Spel.helpmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Highscore HS = new Highscore();
            HS.MdiParent = this.MdiParent;
            HS.Show();
            Close();
        }
    }
}
