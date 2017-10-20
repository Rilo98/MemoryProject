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
        int arrayid1, arrayid2, textboxint1, textboxint2, textboxint3, textboxint4, textboxint5, picturenumber1 = 0,picturenumber2 = 1;
        Button firstButton = null, secondButton = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void defaulttheme(Image[,] arrayimage)
        {
            var rm = new System.Resources.ResourceManager(((System.Reflection.Assembly)System.Reflection.Assembly.GetExecutingAssembly()).GetName().Name + ".Properties.Resources", ((System.Reflection.Assembly)System.Reflection.Assembly.GetExecutingAssembly()));
            for (int i = 0; i < textboxint5/2; i++)
            {
                picturenumber1 = picturenumber1 + 2;
                arrayimage[0, i] = (Bitmap)rm.GetObject("Picture_" + Convert.ToInt32(picturenumber1));
            }
            
            for (int e = 0; e < textboxint5/2; e++)
            {
                picturenumber2 = picturenumber2 + 2;
                arrayimage[1, e] = (Bitmap)rm.GetObject("Picture_" + Convert.ToInt32(picturenumber2));
            }

        }

        private void createbuttons(int[,,] array, Image[,] arrayimage)
        {
            var columnCount = Convert.ToInt32(textBox2.Text);
            var rowCount = Convert.ToInt32(textBox1.Text);
            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount * columnCount; i++)
            {
                var button = new Button();
                button.Font = new Font(button.Font.FontFamily, 1);
                button.Name = "button" + (i + 1).ToString();
                button.Dock = DockStyle.Fill;
                this.tableLayoutPanel1.Controls.Add(button);
                button.BackgroundImage = Properties.Resources.defaultpic;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Click += delegate (object sender, EventArgs e)
                { ButtonClickHandler(sender, e, array, arrayimage); };
            }
        }

        private void fillarray(int[,,] array)                                            //fills the array with numbers & colors & ID's
        {
            //fill id's
                for (int e = 0; e < array.GetLength(1); e++)
                {
                int a = e +1;
                array[0, e, 2] = a;
                int h = e + array.GetLength(1) + 1;
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
                tmpnumber = rng.Next(1, textboxint4);
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

        private void rotatebutton(object sender, int[,,] array, Image[,] arrayimage)                            //changes color based on button number
        {
            Button button = (Button)sender;
            string buttontext = button.Name;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if ((arrayid1 == arrayid2 - textboxint3) || (arrayid1 == arrayid2 + textboxint3))
            {
                firstButton.Enabled = false;
                firstButton.BackgroundImage = null;
                firstButton.BackColor = Color.Transparent;
                secondButton.Enabled = false;
                secondButton.BackgroundImage = null;
                secondButton.BackColor = Color.Transparent;
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

        //buttons ---------------------------------------------
        private void Apply_Click(object sender, EventArgs e)
        {
            textboxint1 = Convert.ToInt32(textBox1.Text);
            textboxint2 = Convert.ToInt32(textBox2.Text);
            textboxint3 = (textboxint1 * textboxint2) / 2;
            textboxint4 = (textboxint1 * textboxint2) + 1;
            textboxint5 = (textboxint1 * textboxint2);
            int[,,] array = new int[2, textboxint3, 3];
            Image[,] arrayimage = new Image[2, textboxint3];

            if ((textboxint1 > 8 || textboxint1 < 4) || (textboxint2 > 8 || textboxint2 < 4))
            {
                label1.Text = "Please provide a number between 4 and 6.";
                label1.ForeColor = Color.Red;
                return;
            }
            else if ((textboxint1 == 7 && textboxint2 == 7) || (textboxint1 == 5 && textboxint2 == 5))
            {
                label1.Text = "Please provide 2 even numbers, or an even and an odd number";
                label1.ForeColor = Color.Red;
                return;
            }
            else
            {
                defaulttheme(arrayimage);
                fillarray(array);
                label1.Text = "";
                createbuttons(array, arrayimage);
                textBox1.Visible = false;
                textBox2.Visible = false;
                Apply.Visible = false;
            }
        }

        private void ButtonClickHandler(object sender, EventArgs e, int[,,] array, Image[,] arrayimage)
        {
            rotatebutton(sender,array,arrayimage);
        }
    }
}
