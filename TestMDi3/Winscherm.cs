using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace TestMDi3
{
    public partial class Winscherm : Form
    {
        private Point pt;
        public Winscherm()
        {
            InitializeComponent();
            this.BackgroundImage = win1;
            System.Media.SoundPlayer player0 = new System.Media.SoundPlayer(Properties.Resources.celebrate);
            player0.Play();
            FireTimer.Start();
            label_winnaarnaam.Text = Spel.winnaar;
            label_score.Text = Spel.winnaar_score;
            label_combo.Text = Convert.ToString(Spel.winnaar_combo);
            pt = this.Location;
            WriteNewEntry();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
            

        }
        
        private int timertick = 0;
        private Image win1 = Properties.Resources.achtergrondentrofee0;
        private Image win2 = Properties.Resources.achtergrondentrofee1;
        private Image win3 = Properties.Resources.achtergrondentrofee2;
        private Image win4 = Properties.Resources.achtergrondentrofee3;

        public void WriteNewEntry()
        {
            if (File.Exists("Highscore.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Highscore.xml");
                XmlElement parentelement = doc.CreateElement("highscore");

                XmlElement name = doc.CreateElement("name");
                name.InnerText = Convert.ToString(Spel.winnaar);
                XmlElement score = doc.CreateElement("score");
                score.InnerText = Convert.ToString(Spel.winnaar_score);
                XmlElement combo = doc.CreateElement("combo");
                combo.InnerText = Convert.ToString(Spel.winnaar_combo);

                parentelement.AppendChild(name);
                parentelement.AppendChild(score);
                parentelement.AppendChild(combo);
                doc.DocumentElement.AppendChild(parentelement);
                doc.Save("Highscore.xml");

                XElement root = XElement.Load("Highscore.xml");
                var orderedtabs = root.Elements("highscore")
                .OrderByDescending(xtab => (int)xtab.Element("score"))
                .ToArray();
                root.RemoveAll();
                foreach (XElement tab in orderedtabs)
                    root.Add(tab);
                root.Save("Highscore.xml");
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter("Highscore.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("scorelist");
                writer.WriteStartElement("highscore");
                writer.WriteElementString("name", Convert.ToString(label_winnaarnaam.Text));
                writer.WriteElementString("score", Convert.ToString(label_score.Text));
                writer.WriteElementString("combo", Convert.ToString(label_combo.Text));
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
            }
        }

        private void FireTimer_Tick(object sender, EventArgs e)
        {
            timertick += 1;
            if (timertick == 1)
            {
                this.BackgroundImage = win2;
                label1.ForeColor = Color.Green;
                button3.BackColor = DefaultBackColor;
            }
            if (timertick == 2)
            {
                this.BackgroundImage = win3;

            }
            if (timertick == 3)
            {
                this.BackgroundImage = win4;
                label1.ForeColor = Color.DarkOrange;
            }
            if (timertick == 4)
            {
                this.BackgroundImage = win1;
                timertick = 0;
                label1.ForeColor = Color.Green;
                button3.BackColor = Color.GreenYellow;

            }
        }
        

        //menu knop
        private void button2_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            Close();
        }

        //new game knop
        private void button3_Click(object sender, EventArgs e)
        {
            Spelers f3 = new Spelers();
            f3.MdiParent = this.ParentForm;
            f3.Show();
            Close();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Location = pt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Highscore HS = new Highscore();
            HS.MdiParent = this.MdiParent;
            HS.Show();
            Close();
        }
    }
}
