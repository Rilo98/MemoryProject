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
        ///<summary>Method to start the form and clears the form of unnecessary text</summary>
        ///<para>Creator: Andries</para>
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
        /// <para>Creator:Andries en Hidzer</para>
        private void Highscore_Load(object sender, EventArgs e)  
        {
            if (Spel.multiplayer == true)
            {
                comboBox1.SelectedItem = "Multiplayer";
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
            }
        }

        /// <summary>Method button1_Click</summary>
        /// <para>If this button is clicked it will show the "hoofdmenu" form</para>
        /// <para>Creator: Andries</para>
        private void button1_Click(object sender, EventArgs e) 
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            Close();
        }
        /// <summary>
        /// comboBox1_SelectedIndexChanged
        /// </summary>
        /// <para>This method loads the LoadCombobox method</para>
        /// <para>Creator: Kevin</para>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            LoadCombobox();
        }
        /// <summary>
        /// Method LoadCombobox
        /// </summary>
        /// <para>When the dropdownbox gets a predefined value it will load the defined savefile and puts it in the labels or leaves them empty</para>
        /// <para>Creator: Andries</para>
        private void LoadCombobox()                 
        {

            if (comboBox1.Text == "Singleplayer")
            {
                HighscoreName.Text = "";
                Highscorecombo.Text = "";
                Highscorescore.Text = "";
                resultaat.Text = "";
                Size.Text = "";
                label7.Text = "";

                if (File.Exists("HighscoreSP.sav"))
                {


                    XmlDocument xml = new XmlDocument();  
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
                    resultaat.Text = "";
                    Size.Text = "";
                    label7.Text = "Resultaat:";



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
                        m++;
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
