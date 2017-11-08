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
    /// <summary>class Winscherm : Form</summary>
    /// <para>This class is the main class for the winscherm.cs form. </para>
    public partial class Winscherm : Form
    {
        /// <summary>private Point pt | this brings the form in the right location within the main form</summary>
        private Point pt;
        /// <summary>Method winscherm</summary>
        /// <para>This method loads the form and deletes savefiles when that gamemode has finished</para>
        /// <para>Creator: Hidzer en Andries</para>
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

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
            if (Spel.multiplayer == true)
            {
                WriteNewEntryMP1();
                WriteNewEntryMP2();
                File.Delete("MPSave.sav");
            }
            else
            {
                WriteNewEntrySP();
                File.Delete("SPSave.sav");
            }
            if (Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Hoofdmenu")
                    {
                        button.Text = "Main Menu";
                    }
                    if (button.Text == "Ranglijst")
                    {
                        button.Text = "Highscores";
                    }
                    if (button.Text == "Nieuw spel")
                    {
                        button.Text = "New game";
                    }
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    if (label.Text == "Gefeliciteerd!")
                    {
                        label.Text = "Congratulations";
                    }
                    if (label.Text == "NIEUWE HIGHSCORE")
                    {
                        label.Text = "NEW HIGHSCORE";
                    }

                }
            }
            if(Opties.mute == false)
            {
                player0.Play();
            }
        }
        /// <summary>private int timertick sets the timer on 0</summary>
        private int timertick = 0;
        /// <summary>private Image loads a specific image</summary>
        private Image win1 = Properties.Resources.achtergrondentrofee0;
        private Image win2 = Properties.Resources.achtergrondentrofee1;
        private Image win3 = Properties.Resources.achtergrondentrofee2;
        private Image win4 = Properties.Resources.achtergrondentrofee3;

        /// <summary>Method WriteNewEntrySP</summary>
        /// <para>This method will send the values to the savefile for the highscores and arranges them om score</para>
        /// <para>Creator: Andries</para>
        public void WriteNewEntrySP()
        {
            if (File.Exists("HighscoreSP.sav"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("HighscoreSP.sav");
                XmlElement parentelement = doc.CreateElement("highscore");

                XmlElement name = doc.CreateElement("name");
                name.InnerText = Convert.ToString(Spel.winnaar);
                XmlElement score = doc.CreateElement("score");
                score.InnerText = Convert.ToString(Spel.winnaar_score);
                XmlElement combo = doc.CreateElement("combo");
                combo.InnerText = Convert.ToString(Spel.winnaar_combo);
                XmlElement game = doc.CreateElement("game");
                game.InnerText = Convert.ToString(Spel.length + "X" + Spel.width);

                parentelement.AppendChild(name);
                parentelement.AppendChild(score);
                parentelement.AppendChild(combo);
                parentelement.AppendChild(game);
                doc.DocumentElement.AppendChild(parentelement);
                doc.Save("HighscoreSP.sav");

                XElement root = XElement.Load("HighscoreSP.sav");
                var orderedtabs = root.Elements("highscore")
                .OrderByDescending(xtab => (int)xtab.Element("score"))
                .ToArray();
                root.RemoveAll();
                foreach (XElement tab in orderedtabs)
                    root.Add(tab);
                root.Save("HighscoreSP.sav");
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter("HighscoreSP.sav", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("scorelist");
                writer.WriteStartElement("highscore");
                writer.WriteElementString("name", Convert.ToString(label_winnaarnaam.Text));
                writer.WriteElementString("score", Convert.ToString(label_score.Text));
                writer.WriteElementString("combo", Convert.ToString(label_combo.Text));
                writer.WriteElementString("game", Convert.ToString(Spel.length + "X" + Spel.width));
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
            }
        }

        /// <summary>Method WriteNewEntryMP1</summary>
        /// <para>This method will send the values to the savefile for the highscores and arranges them om score</para>
        /// <para>Creator: Andries</para>
        public void WriteNewEntryMP1()
        {
            if (File.Exists("HighscoreMP.sav"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("HighscoreMP.sav");
                XmlElement parentelement = doc.CreateElement("highscore");

                XmlElement name = doc.CreateElement("name");
                XmlElement score = doc.CreateElement("score");
                XmlElement combo = doc.CreateElement("combo");
                XmlElement game = doc.CreateElement("game");
                XmlElement result = doc.CreateElement("result");
                if (Spel.multinaam1 == Spel.winnaar)
                {
                    result.InnerText = "gewonnen";
                }
                else
                {
                    result.InnerText = "verloren";
                }
                game.InnerText = Convert.ToString(Spel.length + "X" + Spel.width);
                name.InnerText = Convert.ToString(Spel.multinaam1);
                score.InnerText = Convert.ToString(Spel.Player1_score);
                combo.InnerText = Convert.ToString(Spel.HighCombo_Player1);

                parentelement.AppendChild(name);
                parentelement.AppendChild(score);
                parentelement.AppendChild(combo);
                parentelement.AppendChild(game);
                parentelement.AppendChild(result);
                doc.DocumentElement.AppendChild(parentelement);

               

                doc.Save("HighscoreMP.sav");

                XElement root = XElement.Load("HighscoreMP.sav");
                var orderedtabs = root.Elements("highscore")
                .OrderByDescending(xtab => (int)xtab.Element("score"))
                .ToArray();
                root.RemoveAll();
                foreach (XElement tab in orderedtabs)
                root.Add(tab);
                root.Save("HighscoreMP.sav");
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter("HighscoreMP.sav", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("scorelist");
                writer.WriteStartElement("highscore");
                writer.WriteElementString("name", Convert.ToString(Spel.multinaam1));
                writer.WriteElementString("score", Convert.ToString(Spel.Player1_score));
                writer.WriteElementString("combo", Convert.ToString(Spel.HighCombo_Player1));
                writer.WriteElementString("game", Convert.ToString(Spel.length + "X" + Spel.width));
                if (Spel.multinaam1 == Spel.winnaar)
                {
                    writer.WriteElementString("result", ("gewonnen"));
                }
                else
                {
                    writer.WriteElementString("result", ("verloren"));
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
            }
        }

        /// <summary>Method WriteNewEntryMP2</summary>
        /// <para>This method will send the values to the savefile for the highscores and arranges them om score</para>
        /// <para>Creator: Andries</para>
        public void WriteNewEntryMP2()
        { 
         if (File.Exists("HighscoreMP.sav"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("HighscoreMP.sav");
                XmlElement parentelement = doc.CreateElement("highscore");

                XmlElement name = doc.CreateElement("name");
                XmlElement score = doc.CreateElement("score");
                XmlElement combo = doc.CreateElement("combo");
                XmlElement game = doc.CreateElement("game");
                XmlElement result = doc.CreateElement("result");
                if (Spel.multinaam2 == Spel.winnaar)
                {
                    result.InnerText = "gewonnen";
                }
                else
                {
                    result.InnerText = "verloren";
                }
                game.InnerText = Convert.ToString(Spel.length + "X" + Spel.width);
                name.InnerText = Convert.ToString(Spel.multinaam2);
                score.InnerText = Convert.ToString(Spel.Player2_score);
                combo.InnerText = Convert.ToString(Spel.HighCombo_Player2);

                parentelement.AppendChild(name);
                parentelement.AppendChild(score);
                parentelement.AppendChild(combo);
                parentelement.AppendChild(game);
                parentelement.AppendChild(result);
                doc.DocumentElement.AppendChild(parentelement);


                doc.Save("HighscoreMP.sav");

                XElement root = XElement.Load("HighscoreMP.sav");
                var orderedtabs = root.Elements("highscore")
                .OrderByDescending(xtab => (int)xtab.Element("score"))
                .ToArray();
                root.RemoveAll();
                foreach (XElement tab in orderedtabs)
                root.Add(tab);
                root.Save("HighscoreMP.sav");
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter("HighscoreMP.sav", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("scorelist");
                writer.WriteStartElement("highscore");
                writer.WriteElementString("name", Convert.ToString(Spel.multinaam2));
                writer.WriteElementString("score", Convert.ToString(Spel.Player2_score));
                writer.WriteElementString("combo", Convert.ToString(Spel.HighCombo_Player2));
                writer.WriteElementString("game", Convert.ToString(Spel.length + "X" + Spel.width));
                if (Spel.multinaam2 == Spel.winnaar)
                {
                    writer.WriteElementString("result", ("gewonnen"));
                }
                else
                {
                    writer.WriteElementString("result", ("verloren"));
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
            }
        }

        /// <summary>Method FireTimer_Tick</summary>
        /// <param>This method loops through images and shows fireworks in the form "winscherm"</param>
        /// <para>Creator: Hidzer</para>
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


        /// <summary>Method button2_Click</summary>
        /// <param>This method loads Hoofdmenu.cs form</param>
        /// <para>Creator: Richard</para>
        private void button2_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            Close();
        }
        /// <summary>Method button3_Click</summary>
        /// <param>This method loads spelers.cs form</param>
        /// <para>Creator: Richard</para>
        private void button3_Click(object sender, EventArgs e)
        {
            Spelers f3 = new Spelers();
            f3.MdiParent = this.ParentForm;
            f3.Show();
            Close();
        }
        /// <summary>Method Form1_Move</summary>
        /// <param>This method moves the loaded form to the zero location</param>
        /// <para>Creator: Richard</para>
        private void Form1_Move(object sender, EventArgs e)
        {
            this.Location = pt;
        }
        /// <summary>Method button1_Click</summary>
        /// <param>This method loads Highscore.cs form</param>
        /// <para>Creator: Richard</para>
        private void button1_Click(object sender, EventArgs e)
        {
            Highscore HS = new Highscore();
            HS.MdiParent = this.MdiParent;
            HS.Show();
            Close();
        }
    }
}
