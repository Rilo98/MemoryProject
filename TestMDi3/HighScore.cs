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
    /// <summary>Class Highscore.cs form</summary>
    /// <para>This class is the main class for the Highscore.cs form. </para>
    public partial class Highscore : Form
    {
<<<<<<< HEAD
        ///<summary>Method to start the form and clears the form of unnecessary text</summary>   
=======
       
>>>>>>> 13acc273b62a93550a188d3fe1d67deb7b71778d
        public Highscore()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            HighscoreName.Text = "";
            Highscorecombo.Text = "";
            Highscorescore.Text = "";
            resultaat.Text = "";
            Size.Text = "";
        }

        /// <summary>Method for going to the highscore from "winscherm" and then loads the scores for the gamemode you've played</summary>
        
        private void Highscore_Load(object sender, EventArgs e)  
        {
            if (Spel.multiplayer == true)
            {
                comboBox1.SelectedItem = "Multiplayer";
                LoadCombobox();
            }
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
        

            else if (Spel.multiplayer == false)
            {
                comboBox1.SelectedItem = "Singleplayer";
                LoadCombobox();
            }
        }

        private void button1_Click(object sender, EventArgs e) //deze knop navigeerd naar het hoofdmenu
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //hier wordt het dropdownmenu geladen
        {
            LoadCombobox();
        }

        private void LoadCombobox()                 //hier wordt in de dropdownmenu in het highscoremenu aangegeven wat moet worden weergegeven
        {
            if (comboBox1.Text == "Singleplayer")
            {
                label7.Text = "";
                resultaat.Text = "";

                if (File.Exists("HighscoreSP.sav")) //hier kijkt het programma of de desbetreffende savefile bestaat
                {
                    HighscoreName.Text = "";
                    Highscorecombo.Text = "";
                    Highscorescore.Text = "";
                    Size.Text = "";

                    XmlDocument xml = new XmlDocument();    //hier wordt de informatie vanuit de file geladen
                    xml.Load("HighscoreSP.sav");
                    var name = "highscore/name";
                    var combo = "highscore/combo";
                    var score = "highscore/score";
                    var size = "highscore/game";
                    var i = 0;
                    var j = 0;
                    var k = 0;
                    var m = 0;
                    XmlNodeList names = xml.DocumentElement.SelectNodes(name);
                    foreach (XmlNode node in names)         //voor elke node in de file met de naam name wordt die waarde geladen
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

                    XmlNodeList sizes = xml.DocumentElement.SelectNodes(size);
                    foreach (XmlNode node in sizes)
                    {
                        Size.Text += node.InnerXml + Environment.NewLine;
                        j++;
                        if (m >= 10) break;
                    }

                    XmlNodeList scores = xml.DocumentElement.SelectNodes(score);
                    foreach (XmlNode node in scores)
                    {
                        Highscorescore.Text += node.InnerXml + Environment.NewLine;
                        k++;
                        if (k >= 10) break;
                    }
                }

            }
            else if (comboBox1.Text == "Multiplayer")
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
                    var size = "highscore/game";
                    var result = "highscore/result";
                    var i = 0;
                    var j = 0;
                    var k = 0;
                    var m = 0;
                    var n = 0;

                    XmlNodeList names = xml.DocumentElement.SelectNodes(name);
                    foreach (XmlNode node in names)
                    {
                        HighscoreName.Text += node.InnerXml + Environment.NewLine;
                        i++;
                        if (i >= 10) break;
                    }

                    XmlNodeList results = xml.DocumentElement.SelectNodes(result);
                    foreach (XmlNode node in results)
                    {
                        resultaat.Text += node.InnerXml + Environment.NewLine;
                        n++;
                        if (n >= 10) break;
                    }

                    XmlNodeList sizes = xml.DocumentElement.SelectNodes(size);
                    foreach (XmlNode node in sizes)
                    {
                        Size.Text += node.InnerXml + Environment.NewLine;
                        j++;
                        if (m >= 10) break;
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
        }
    }
}
