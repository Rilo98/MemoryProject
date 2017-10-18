using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int[,,] array = new int[2, 8, 3];

        Image[,] arrayimage = new Image[2,8];
        Button firstButton = null, secondButton = null;
        int arrayid1, arrayid2;
        public Form1()
        {
            InitializeComponent();
            fillarray();
            defaulttheme();
        }

        private void defaulttheme()
        {                             
            button1.BackgroundImage = Properties.Resources.defaultpic;
            button2.BackgroundImage = Properties.Resources.defaultpic;
            button3.BackgroundImage = Properties.Resources.defaultpic;
            button4.BackgroundImage = Properties.Resources.defaultpic;
            button5.BackgroundImage = Properties.Resources.defaultpic;
            button6.BackgroundImage = Properties.Resources.defaultpic;
            button7.BackgroundImage = Properties.Resources.defaultpic;
            button8.BackgroundImage = Properties.Resources.defaultpic;
            button9.BackgroundImage = Properties.Resources.defaultpic;
            button10.BackgroundImage =Properties.Resources.defaultpic;
            button11.BackgroundImage =Properties.Resources.defaultpic;
            button12.BackgroundImage =Properties.Resources.defaultpic;
            button13.BackgroundImage =Properties.Resources.defaultpic;
            button14.BackgroundImage =Properties.Resources.defaultpic;
            button15.BackgroundImage =Properties.Resources.defaultpic;
            button16.BackgroundImage = Properties.Resources.defaultpic;

            //fill colors
            arrayimage[0, 0] = Properties.Resources.Picture_0;
            arrayimage[0, 1] = Properties.Resources.Picture_2;
            arrayimage[0, 2] = Properties.Resources.Picture_4;
            arrayimage[0, 3] = Properties.Resources.Picture_6;

            arrayimage[0, 4] = Properties.Resources.Picture_8;
            arrayimage[0, 5] = Properties.Resources.Picture_10;
            arrayimage[0, 6] = Properties.Resources.Picture_12;
            arrayimage[0, 7] = Properties.Resources.Picture_14;

            arrayimage[1, 0] = Properties.Resources.Picture_1;
            arrayimage[1, 1] = Properties.Resources.Picture_3;
            arrayimage[1, 2] = Properties.Resources.Picture_5;
            arrayimage[1, 3] = Properties.Resources.Picture_7;

            arrayimage[1, 4] = Properties.Resources.Picture_9;
            arrayimage[1, 5] = Properties.Resources.Picture_11;
            arrayimage[1, 6] = Properties.Resources.Picture_13;
            arrayimage[1, 7] = Properties.Resources.Picture_15;

        }

        private void fillarray()                                            //fills the array with numbers & colors & ID's
        {
            //fill id's
                for (int e = 0; e < array.GetLength(1); e++)
                {
                int a = e +1;
                array[0, e, 2] = a;
                int h = e + 9;
                array[1, e, 2] = h;
                }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int e = 0; e < array.GetLength(1); e++)
                {
                    array[i, e, 0] = checkarray(array);
                }
            }
        }

        private int checkarray(int[,,] array)                               //Checks if the Array conains a certain number - if the rng'ed number isnt in the array yet then it will return a new number for the array
        {
            Random rng = new Random();

            bool done = false;
            int tmpnumber = 0;
            while (done == false)
            {
                done = true;
                tmpnumber = rng.Next(1, 17);
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int e = 0; e < array.GetLength(1); e++)
                    {
                        if (tmpnumber == array[i, e, 0])
                        {
                            done = false;
                        }
                    }
                }
            }
            return tmpnumber;
        }

        private void checkpairs()
        {
            if ((arrayid1 == arrayid2 - 8) || (arrayid1 == arrayid2 + 8))
            {
                firstButton.Visible = false;
                secondButton.Visible = false;
                firstButton = null;
                secondButton = null;
            }
            else
            {

                firstButton.BackgroundImage = Properties.Resources.defaultpic;
                secondButton.BackgroundImage = Properties.Resources.defaultpic;
                firstButton = null;
                secondButton = null;
            }
        }

        private void rotatebutton(object sender)                            //changes color based on button number
        {
            Button button = (Button)sender;
            string buttontext = button.Text;

            if (firstButton == null)
            {
                
                int buttonlenght = Convert.ToString(buttontext).Length;
                if (buttonlenght == 7)
                {
                    firstButton = button;
                    buttonlenght = buttonlenght - 1;
                    int number = Convert.ToInt32(buttontext.Substring(buttonlenght, 1));
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (array[i, j, 0] == number)
                            {
                                arrayid1 = array[i, j, 2];
                                button.BackgroundImage = (arrayimage[i, j]);
                            }
                        }
                    }
                }

                else
                {
                    firstButton = button;
                    buttonlenght = buttonlenght - 2;
                    int number = Convert.ToInt32(buttontext.Substring(buttonlenght, 2));
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (array[i, j, 0] == number)
                            {
                                arrayid1 = array[i, j, 2];
                                button.BackgroundImage = (arrayimage[i, j]);
                            }
                        }
                    }
                }
            }
            else if (secondButton == null)
            {
                int buttonlenght = Convert.ToString(buttontext).Length;
                if (button == firstButton)
                {
                    return;
                }
                if (buttonlenght == 7)
                {
                    secondButton = button;
                    buttonlenght = buttonlenght - 1;
                    int number = Convert.ToInt32(buttontext.Substring(buttonlenght, 1));
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (array[i, j, 0] == number)
                            {
                                arrayid2 = array[i, j, 2];
                                button.BackgroundImage = (arrayimage[i, j]);
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                                timer1.Start();
                            }
                        }
                    }
                }

                else
                {
                    secondButton = button;
                    buttonlenght = buttonlenght - 2;
                    int number = Convert.ToInt32(buttontext.Substring(buttonlenght, 2));
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (array[i, j, 0] == number)
                            {
                                arrayid2 = array[i, j, 2];
                                button.BackgroundImage = (arrayimage[i, j]);
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                                timer1.Start();
                            }
                        }
                    }
                }
            }
        }



        //buttons --------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            rotatebutton(sender);
        }
        //buttons --------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if ((arrayid1 == arrayid2 - 8) || (arrayid1 == arrayid2 + 8))
            {
                firstButton.Visible = false;
                secondButton.Visible = false;
                firstButton = null;
                secondButton = null;
            }
            else
            {

                firstButton.BackgroundImage = Properties.Resources.defaultpic;
                secondButton.BackgroundImage = Properties.Resources.defaultpic;
                firstButton = null;
                secondButton = null;
            }
        }
    }
}
