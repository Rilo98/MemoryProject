using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            randombuttons();
            
        }

        private void randombuttons()
        {
            int[,,] array = new int[4, 4, 2];

            array[0, 0, 1] = Color.Black.ToArgb();
            array[0, 1, 1] = Color.White.ToArgb();
            array[0, 2, 1] = Color.Red.ToArgb();
            array[0, 3, 1] = Color.Green.ToArgb();
                      
            array[1, 0, 1] = Color.Blue.ToArgb();
            array[1, 1, 1] = Color.Purple.ToArgb();
            array[1, 2, 1] = Color.Orange.ToArgb();
            array[1, 3, 1] = Color.Yellow.ToArgb();
                      
            array[2, 0, 1] = Color.Black.ToArgb();
            array[2, 1, 1] = Color.White.ToArgb();
            array[2, 2, 1] = Color.Red.ToArgb();
            array[2, 3, 1] = Color.Green.ToArgb();
                      
            array[3, 0, 1] = Color.Blue.ToArgb();
            array[3, 1, 1] = Color.Purple.ToArgb();
            array[3, 2, 1] = Color.Orange.ToArgb();
            array[3, 3, 1] = Color.Yellow.ToArgb();

            label1.Text = null;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int e = 0; e < array.GetLength(1); e++)
                {
                    array[i, e, 0] = checkarray(array);

                    
                    label1.Text = label1.Text +" "+ array[i, e, 0] ;
                    
                    //buttons
                    //-----------------------------------------------------
                    if (array[i, e, 0] == 1)
                    {
                        button1.BackColor = Color.FromArgb(array[i, e, 1]);

                    }
                    if (array[i, e, 0] == 2)
                    {
                        button2.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 3)
                    {
                        button3.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 4)
                    {
                        button4.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 5)
                    {
                        button5.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 6)
                    {
                        button6.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 7)
                    {
                        button7.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 8)
                    {
                        button8.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 9)
                    {
                        button9.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 10)
                    {
                        button10.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 11)
                    {
                        button11.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 12)
                    {
                        button12.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 13)
                    {
                        button13.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 14)
                    {
                        button14.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 15)
                    {
                        button15.BackColor = Color.FromArgb(array[i, e, 1]);
                    }

                    if (array[i, e, 0] == 16)
                    {
                        button16.BackColor = Color.FromArgb(array[i, e, 1]);
                    }
                    //-----------------------------------------------------
                }
            }
        }


        private int checkarray(int[,,] array)
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

        private void button1_Click(object sender, EventArgs e)
        {
            randombuttons();
        }
    }
}
