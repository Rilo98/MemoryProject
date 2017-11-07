﻿using System;
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
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            if(Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Hoofdmenu")
                    {
                        button.Text = "Main menu:";
                    }
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    if (label.Text == "Naam:")
                    {
                        label.Text = "Name:";
                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Singleplayer")
            {
                if (File.Exists("HighscoreSP.sav"))
                {
                    HighscoreName.Text = "";
                    Highscorecombo.Text = "";
                    Highscorescore.Text = "";

                    XmlDocument xml = new XmlDocument();
                    xml.Load("HighscoreSP.sav");
                    var name = "highscore/name";
                    var combo = "highscore/combo";
                    var score = "highscore/score";
                    var i = 0;
                    var j = 0;
                    var k = 0;
                    XmlNodeList names = xml.DocumentElement.SelectNodes(name);
                    foreach (XmlNode node in names)
                    {
                        HighscoreName.Text += node.InnerXml + Environment.NewLine;
                        i++;
                        if (i >= 10) break;
                    }

                    XmlNodeList combos = xml.DocumentElement.SelectNodes(combo);
                    foreach (XmlNode node in combos)
                    {
                        Highscorecombo.Text += node.InnerXml + Environment.NewLine;
                        j++;
                        if (j >= 10) break;
                    }

                    XmlNodeList scores = xml.DocumentElement.SelectNodes(score);
                    foreach (XmlNode node in scores)
                    {
                        Highscorescore.Text += node.InnerXml + Environment.NewLine;
                        k++;
                        if (k >= 10) break;
                    }
                }
                else
                {
                    HighscoreName.Text = "";
                    Highscorecombo.Text = "";
                    Highscorescore.Text = "";
                }
            }
            if (comboBox1.Text == "Multiplayer")
            {
                if (File.Exists("HighscoreMP.sav"))
                {
                    HighscoreName.Text = "";
                    Highscorecombo.Text = "";
                    Highscorescore.Text = "";

                    XmlDocument xml = new XmlDocument();
                    xml.Load("HighscoreMP.sav");
                    var name = "highscore/name";
                    var combo = "highscore/combo";
                    var score = "highscore/score";
                    var i = 0;
                    var j = 0;
                    var k = 0;
                    XmlNodeList names = xml.DocumentElement.SelectNodes(name);
                    foreach (XmlNode node in names)
                    {
                        HighscoreName.Text += node.InnerXml + Environment.NewLine;
                        i++;
                        if (i >= 10) break;
                    }

                    XmlNodeList combos = xml.DocumentElement.SelectNodes(combo);
                    foreach (XmlNode node in combos)
                    {
                        Highscorecombo.Text += node.InnerXml + Environment.NewLine;
                        j++;
                        if (j >= 10) break;
                    }

                    XmlNodeList scores = xml.DocumentElement.SelectNodes(score);
                    foreach (XmlNode node in scores)
                    {
                        Highscorescore.Text += node.InnerXml + Environment.NewLine;
                        k++;
                        if (k >= 10) break;
                    }
                }
                else
                {
                    HighscoreName.Text = "";
                    Highscorecombo.Text = "";
                    Highscorescore.Text = "";
                }
            }
            else
            {
                HighscoreName.Text = "";
                Highscorecombo.Text = "";
                Highscorescore.Text = "";
            }
        }
    }
}
