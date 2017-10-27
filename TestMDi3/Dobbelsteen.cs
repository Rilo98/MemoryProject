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
    public partial class Dobbelsteen : Form
    {
        int dice_1, dice_2;

        public static string multispeler1, multispeler2;
        public static int length, width;
        public static bool spelmultiplayer;

        public Dobbelsteen()                                            //Main
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            afterlb.Text = "";

            Speler1.Text = Spel.multinaam1;
            Speler2.Text = Spel.multinaam2;
        }

        private void Gooi_1_Click(object sender, EventArgs e)           //Gooi button
        {
            dobbelsteen();
            after();
        }

        private void dobbelsteen()                                     //Dobbelsteen code
        {
            Random rnd = new Random();

            dice_1 = rnd.Next(1, 7);
            dice_2 = rnd.Next(1, 7);

            ///Dice_1

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
                                                           
            ///Dice_2                                      
                                                           
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

        private void Terug_Click(object sender, EventArgs e)
        {
            MultiNameninvoeren f5 = new MultiNameninvoeren();
            f5.MdiParent = this.ParentForm;
            f5.Show();
            Close();
        }

        private void volgende_Click(object sender, EventArgs e)
        {
            spelmultiplayer = true;
            Spel spel = new Spel();
            spel.MdiParent = this.ParentForm;
            spel.Show();
            Close();
        }

        private void after()                    //Geeft aan wie gewonnen heeft
        {
            dobbelsteen();

            string tekst = "";

            if (dice_1 > dice_2)
            {
                tekst = tekst +  Spel.multinaam1+" mag als eerste beginnen.";
                afterlb.Text = Convert.ToString(tekst);
                Gooi_1.Enabled = false;
                volgende.Enabled = true;
                Spel.Player1_beurt = true;
                Spel.Player2_beurt = false;
            }

            if (dice_1 < dice_2)
            {
                tekst = tekst + Spel.multinaam2+" mag als eerste beginnen.";
                afterlb.Text = Convert.ToString(tekst);
                Gooi_1.Enabled = false;
                volgende.Enabled = true;
                Spel.Player1_beurt = false;
                Spel.Player2_beurt = true;
            }

            if (dice_1 == dice_2)
            {
                tekst = tekst + "Gooi opnieuw!";
                afterlb.Text = Convert.ToString(tekst);
            }

        }
    }
}