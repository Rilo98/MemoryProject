using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMDi3
{
    /// <summary>Class Dobbelsteen:From</summary>
    /// <para>This Class is the main class for the Dobbelsteen.cs form. </para>
    public partial class Dobbelsteen : Form
    {
        /// <summary>Variables in Class Dobbelsteen</summary>
        /// <para>int dice_1: this is the value for the first dice when rolling for who may start</para>
        /// <para>int dice_2: this is the value for the second dice when rolling for who may start</para>
        /// <para>These dices determine who start</para>
        int dice_1, dice_2;

        /// <para>public static string multispeler1: Multispeler1 is the first player, this name is assigned to a dice</para>
        /// <para>public static string multispeler2: Multispeler2 is the second players' name</para>
        public static string multispeler1, multispeler2;
        /// <para>public static int length: Divines the size of the lenght of the game between 4 and 8, needs to be 2 even or an even or an odd number</para>
        /// <para>public static int width: Divines the size of the width of the game between 4 and 8, needs to be 2 even or an even or an odd number</para>
        public static int length, width;
        /// <para>public static bool spelmultiplayer: Spelmultiplayer is either true or false; this tells the spel.cs form if the game is multiplayer or singleplayer</para>
        public static bool spelmultiplayer;

        /// <summary>Method Dobbelsteen</summary>
        /// <para>This method loads the names from other forms and initializes the default values</para>
        public Dobbelsteen()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            afterlb.Text = "";

            Speler1.Text = Spel.multinaam1;
            Speler2.Text = Spel.multinaam2;

            if (Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Gooi")
                    {
                        button.Text = "Throw";
                    }
                    if (button.Text == "Volgende")
                    {
                        button.Text = "Next";
                    }
                    if (button.Text == "Terug")
                    {
                        button.Text = "Back";
                    }
                    if (button.Text == "Gooi!")
                    {
                        button.Text = "Throw!";
                    }
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    if (label.Text == "Gooi om te bepalen wie begint!")
                    {
                        label.Text = "Throw a dice to determine who plays first!";
                    }
                    if (label.Text == "Speler 1")
                    {
                        label.Text = "Player 1";
                    }
                    if (label.Text == "Speler 2")
                    {
                        label.Text = "Player 2";
                    }
                    
                    if (label.Text == "" + Spel.multinaam2 + " mag als eerste beginnen.")
                    {
                        label.Text = "" + Spel.multinaam2 + " draws first card.";
                    }
                    if (label.Text == "Lengte")
                    {
                        label.Text = "Length";
                    }
                    if (label.Text == "Breedte")
                    {
                        label.Text = "Width";
                    }
                }
            }
        }

        /// <summary>Method Gooi_1_Click</summary>
        /// <para>This method calls the methods: dobbelsteen and after</para>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void Gooi_1_Click(object sender, EventArgs e)          
        {
            dobbelsteen();
            after();
        }

        /// <summary>Method Gooi_1_Click</summary>
        /// <para>This method random genarates numbers between 1 and 6 for the dice, based on that it will display a dice on the screen</para>
        private void dobbelsteen()                         
        {
            Random rnd = new Random();

            dice_1 = rnd.Next(1, 7);
            dice_2 = rnd.Next(1, 7);

            if (dice_1 == 1)                                            
            {
                pictureBox1.Image = Properties.Resources._1c;
            }                                              
                                                           
            if (dice_1 == 2)                               
            {                                              
                pictureBox1.Image = Properties.Resources._2c;
            }                                              
                                                           
            if (dice_1 == 3)                               
            {                                              
                pictureBox1.Image = Properties.Resources._3c;
            }                                              
                                                           
            if (dice_1 == 4)                               
            {                                              
                pictureBox1.Image = Properties.Resources._4c;
            }                                              
                                                           
            if (dice_1 == 5)                               
            {                                              
                pictureBox1.Image = Properties.Resources._5c;
            }                                             
                                                          
            if (dice_1 == 6)                              
            {                                             
                pictureBox1.Image = Properties.Resources._6c;
            }                                              

                                           
            if (dice_2 == 1)                                            
            {                                              
                pictureBox2.Image = Properties.Resources._1c;
            }                                             
                                                          
            if (dice_2 == 2)                              
            {                                             
                pictureBox2.Image = Properties.Resources._2c;
            }                                              
                                                           
            if (dice_2 == 3)                               
            {                                              
                pictureBox2.Image = Properties.Resources._3c;
            }                                              
                                                           
            if (dice_2 == 4)                               
            {                                              
                pictureBox2.Image = Properties.Resources._4c;
            }                                              
                                                           
            if (dice_2 == 5)                               
            {                                              
                pictureBox2.Image = Properties.Resources._5c;
            }                                             
                                                          
            if (dice_2 == 6)                              
            {                                             
                pictureBox2.Image = Properties.Resources._6c;
            }

        }

        /// <summary>Method Terug_Click</summary>
        /// <para>This method will retrun you to the screen where you can fill in your name</para>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void Terug_Click(object sender, EventArgs e)
        {
            MultiNameninvoeren f5 = new MultiNameninvoeren();
            f5.MdiParent = this.ParentForm;
            f5.Show();
            Close();
        }

        /// <summary>Method volgende_Click</summary>
        /// <para>This method will bring you to the game from called spel.cs</para>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void volgende_Click(object sender, EventArgs e)
        {
            spelmultiplayer = true;
            Spel spel = new Spel();
            spel.MdiParent = this.ParentForm;
            spel.Show();
            Close();
        }

        /// <summary>Method after</summary>
        /// <para>This method will check wich dice is the highest dice, based on that it will determine who is allowed to start</para>
        private void after() 
        {
            dobbelsteen();

            string tekst = "";

            if (dice_1 > dice_2)
            {
                if(Spel.taalEngels != true)
                {
                    tekst = tekst + Spel.multinaam1 + " mag als eerste beginnen.";
                    afterlb.Text = Convert.ToString(tekst);
                }

                if (Spel.taalEngels == true)
                {
                    tekst = tekst + Spel.multinaam1 + " draws first card.";
                    afterlb.Text = Convert.ToString(tekst);
                }
                Gooi_1.Enabled = false;
                volgende.Enabled = true;
                Spel.Player1_beurt = true;
                Spel.Player2_beurt = false;
            }

            if (dice_1 < dice_2)
            {
                if (Spel.taalEngels != true)
                {
                    tekst = tekst + Spel.multinaam2 + " mag als eerste beginnen.";
                    afterlb.Text = Convert.ToString(tekst);
                }
               
                if (Spel.taalEngels == true)
                {
                    tekst = tekst + Spel.multinaam2 + " draws first card.";
                    afterlb.Text = Convert.ToString(tekst);
                }
                Gooi_1.Enabled = false;
                volgende.Enabled = true;
                Spel.Player1_beurt = false;
                Spel.Player2_beurt = true;
            }

            if (dice_1 == dice_2)
            {
                if(Spel.taalEngels != true)
                {
                    tekst = tekst + "Gooi opnieuw!";
                    afterlb.Text = Convert.ToString(tekst);
                }

                if(Spel.taalEngels == true)
                {
                    tekst = tekst + "Throw again!";
                    afterlb.Text = Convert.ToString(tekst);
                }
            }
        }
    }
}