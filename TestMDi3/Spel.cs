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
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace TestMDi3
{
    public partial class Spel : Form
    {
        public static int length, width;
        public static bool multiplayer, Player1_beurt, Player2_beurt, Doorgaan1Speler;
        public static string singlenaam, multinaam1, multinaam2, selectedtheme = "Default";

        SingleNameninvoeren singlenameninvoeren = new SingleNameninvoeren();
        int arrayid1, arrayid2, textboxint3, textboxint4, textboxint5, picturenumber1 = 0, picturenumber2 = 1, Player1_score, Player2_score, counterint = (length * width / 2);
        Button firstButton = null, secondButton = null;

        public void Spel_Load(object sender, EventArgs e)
        {
            SingleNameninvoeren singlenameninvoeren = new SingleNameninvoeren();
            SwitchTurn();
            if (multiplayer == true)
            {
                label2.Text = multinaam1;
                label3.Text = multinaam2;
            }

            else
            {
                label2.Text = singlenaam;
                Stopwatch.Text = Convert.ToString(counterint);
            }
        }

        public Spel()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);


            if (multiplayer == true)
            {
                label2.Text = multinaam1;
                label3.Text = multinaam2;
                BeurtIndicator1.Visible = Enabled;
                BeurtIndicator2.Visible = Enabled;
                label2.Visible = Enabled;
                label3.Visible = Enabled;
                Label_Player1score.Visible = Enabled;
                Label_Player2Score.Visible = Enabled;
                textboxint3 = (length * width) / 2;
                textboxint4 = (length * width) + 1;
                textboxint5 = (length * width);
                int[,,] array = new int[2, textboxint3, 3];
                Image[,] arrayimage = new Image[2, textboxint3];
                reset.Visible = Enabled;
                theme(arrayimage);
                fillarray(array);
                createbuttons(array, arrayimage, length, width);

            }

            else
            {
                if (Doorgaan1Speler == true)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("SPSave.xml");
                    length = length = Convert.ToInt32(doc.SelectSingleNode("values/ints/length").InnerText);
                    width = width = Convert.ToInt32(doc.SelectSingleNode("values/ints/width").InnerText);

                    label2.Text = multinaam1;
                    label3.Text = multinaam2;

                    BeurtIndicator1.Visible = Enabled;
                    BeurtIndicator2.Visible = Enabled;
                    label2.Visible = Enabled;
                    label3.Visible = Enabled;
                    Label_Player1score.Visible = Enabled;
                    Label_Player2Score.Visible = Enabled;
                    textboxint3 = (length * width) / 2;
                    textboxint4 = (length * width) + 1;
                    textboxint5 = (length * width);
                    int[,,] array = new int[2, textboxint3, 3];
                    Image[,] arrayimage = new Image[2, textboxint3];
                    reset.Visible = Enabled;
                    theme(arrayimage);
                    LoadOldExceptions(array);
                    createbuttons(array, arrayimage, length, width);

                    // timer_Sw
                    // 
                    this.timer_Sw.Enabled = true;
                    this.timer_Sw.Interval = 1000;
                    this.timer_Sw.Tick += delegate (object sender, EventArgs e)
                    { timer_Sw_Tick(sender, e, arrayimage, array); };
                    Stopwatch.Visible = true;
                    timer_Sw.Enabled = true;
                }

                else
                {
                    label2.Text = singlenaam;
                    BeurtIndicator1.Visible = false;
                    BeurtIndicator2.Visible = false;
                    label2.Visible = Enabled;
                    label3.Visible = false;
                    Label_Player1score.Visible = Enabled;
                    Label_Player2Score.Visible = false;

                    Stopwatch.Visible = true;
                    timer_Sw.Enabled = true;

                    textboxint3 = (length * width) / 2;
                    textboxint4 = (length * width) + 1;
                    textboxint5 = (length * width);
                    int[,,] array = new int[2, textboxint3, 3];
                    Image[,] arrayimage = new Image[2, textboxint3];
                    reset.Visible = Enabled;
                    theme(arrayimage);
                    fillarray(array);
                    createbuttons(array, arrayimage, length, width);
                    // timer_Sw
                    // 
                    this.timer_Sw.Enabled = true;
                    this.timer_Sw.Interval = 1000;
                    this.timer_Sw.Tick += delegate (object sender, EventArgs e)
                    { timer_Sw_Tick(sender, e, arrayimage, array); };
                    Stopwatch.Visible = true;
                    timer_Sw.Enabled = true;
                }
            }
        }

        public void WriteSP(int[,,] array)
        {
            XmlTextWriter writer = new XmlTextWriter("SPSave.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("values");
            writer.WriteStartElement("ints");
            writer.WriteElementString("score", Convert.ToString(Player1_score));
            writer.WriteElementString("singlenaam", Convert.ToString(singlenaam));
            writer.WriteElementString("length", Convert.ToString(length));
            writer.WriteElementString("width", Convert.ToString(width));
            writer.WriteElementString("selectedtheme", Convert.ToString(selectedtheme));
            writer.WriteElementString("arrayid2", Convert.ToString(arrayid2));
            writer.WriteElementString("counterint", Convert.ToString(counterint));
            writer.WriteElementString("score", Convert.ToString(Player1_score));
            writer.WriteEndElement();
            writer.WriteStartElement("arrays");
            writer.WriteStartElement("arrayimage");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        string ArrayXML = "arrayXML" + Convert.ToString(i) + "-" + Convert.ToString(j) + "-" + Convert.ToString(k);

                        writer.WriteElementString(ArrayXML, Convert.ToString(array[i, j, k]));
                    }
                }
            }

            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();
        }

        public void LoadOldSP(int[,,] array)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SPSave.xml");
            singlenaam = Convert.ToString(doc.SelectSingleNode("values/ints/singlenaam").InnerText);
            length = Convert.ToInt32(doc.SelectSingleNode("values/ints/length").InnerText);
            width = Convert.ToInt32(doc.SelectSingleNode("values/ints/width").InnerText);
            selectedtheme = Convert.ToString(doc.SelectSingleNode("values/ints/selectedtheme").InnerText);
            Player1_score = Convert.ToInt32(doc.SelectSingleNode("values/ints/score").InnerText);
            counterint = Convert.ToInt32(doc.SelectSingleNode("values/ints/counterint").InnerText);

            label2.Text = singlenaam;
            Label_Player1score.Text = Convert.ToString(Player1_score);
            Stopwatch.Text = Convert.ToString(counterint);
        }

        public void LoadOldExceptions(int[,,] array)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SPSave.xml");
            for (int i = 0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j<array.GetLength(1); j++)
                {
                    for (int k = 0; k<array.GetLength(2); k++)
                    {
                        string ArrayXML = "arrayXML" + Convert.ToString(i) + "-" + Convert.ToString(j) + "-" + Convert.ToString(k);
                        array[i, j, k] = Convert.ToInt32(doc.SelectSingleNode("values/arrays/arrayimage/" + ArrayXML).InnerText);
                    }
                }
            }
        }

        private void timer_Sw_Tick(object sender, EventArgs e, Image[,] arrayimage, int[,,] array)
        {
            WriteSP(array);

            Stopwatch.Text = Convert.ToString(counterint = counterint - 1);
            if (counterint == 0)
            {
                timer_Sw.Stop();

                MainForm mainform = new MainForm();
                string message = "Wilt u het spel herstarten?." + Environment.NewLine + "Druk op Yes om te herstarten." + Environment.NewLine + "Druk op No om terug te gaan naar het hoofdmenu.";
                string caption = "De tijd is om!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Spel.multiplayer = false;
                    Spel spel = new Spel();
                    spel.MdiParent = this.ParentForm;
                    spel.Show();
                    Close();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    Hoofdmenu hoofdmenu = new Hoofdmenu();
                    hoofdmenu.MdiParent = this.ParentForm;
                    hoofdmenu.Show();
                    Close();
                    this.Close();
                }
            }
        }

        private void theme(Image[,] arrayimage)
        {
            if (selectedtheme =="Default")
            {
                defaulttheme(arrayimage);
            }

            else
            {
                customtheme(arrayimage);
            }
        }

        private void defaulttheme(Image[,] arrayimage)
        {
            var rm = new System.Resources.ResourceManager(((System.Reflection.Assembly)System.Reflection.Assembly.GetExecutingAssembly()).GetName().Name + ".Properties.Resources", ((System.Reflection.Assembly)System.Reflection.Assembly.GetExecutingAssembly()));
            for (int i = 0; i < textboxint5 / 2; i++)
            {
                picturenumber1 = picturenumber1 + 2;
                arrayimage[0, i] = (Bitmap)rm.GetObject("Picture_" + Convert.ToInt32(picturenumber1));
            }

            for (int e = 0; e < textboxint5 / 2; e++)
            {
                picturenumber2 = picturenumber2 + 2;
                arrayimage[1, e] = (Bitmap)rm.GetObject("Picture_" + Convert.ToInt32(picturenumber2));
            }
        }

        private void customtheme(Image[,] arrayimage)
        {
            for (int i = 0; i < textboxint5 / 2; i++)
            {
                picturenumber1 = picturenumber1 + 2;
                arrayimage[0, i] = (Bitmap)Image.FromFile(selectedtheme + @"\" + "Picture " + Convert.ToInt32(picturenumber1) + ".png");
            }

            for (int e = 0; e < textboxint5 / 2; e++)
            {
                picturenumber2 = picturenumber2 + 2;
                arrayimage[1, e] = (Bitmap)Image.FromFile(selectedtheme + @"\" + "Picture " + Convert.ToInt32(picturenumber2) + ".png");
            }
        }

        private void createbuttons(int[,,] array, Image[,] arrayimage, int length, int width)
        {
            var columnCount = length;
            var rowCount = width;
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
                if (selectedtheme =="Default")
                {
                    button.BackgroundImage = Properties.Resources.defaultpic;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Click += delegate (object sender, EventArgs e)
                    { ButtonClickHandler(sender, e, array, arrayimage); };
                }

                else
                {
                    button.BackgroundImage = (Bitmap)Image.FromFile(selectedtheme + @"\" + "defaultpic.png"); ;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Click += delegate (object sender, EventArgs e)
                    { ButtonClickHandler(sender, e, array, arrayimage); };
                }

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

        private void rotatebutton(object sender, int[,,] array, Image[,] arrayimage)                            //changes image based on button number
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

        private void PlayerScore()
        {
            if (multiplayer == true)
            {

                if (Player1_beurt == true)
                {
                    Player1_score = Player1_score + 1;
                    Label_Player1score.Text = Convert.ToString(Player1_score);
                }
                if (Player2_beurt == true)
                {
                    Player2_score = Player2_score + 1;
                    Label_Player2Score.Text = Convert.ToString(Player2_score);
                }
            }
            else
            {
                Player1_score = Player1_score + 1;
                Label_Player1score.Text = Convert.ToString(Player1_score);
                counterint = counterint + (length * width / 4);
                Stopwatch.Text = Convert.ToString(counterint);
            }
        }

        

        private void SwitchTurn()
        {
            if (Player1_beurt == true)
            {
                BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#76FF03");
                BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                Player2_beurt = true;
                Player1_beurt = false;
            }
            else if (Player2_beurt == true)
            {
                BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#76FF03");
                Player1_beurt = true;
                Player2_beurt = false;

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SwitchTurn();
            timer1.Stop();
            if ((arrayid1 == arrayid2 - textboxint3) || (arrayid1 == arrayid2 + textboxint3))
            {
                PlayerScore();
                firstButton.Enabled = false;
                firstButton.BackgroundImage = null;
                firstButton.BackColor = Color.Transparent;
                secondButton.Enabled = false;
                secondButton.BackgroundImage = null;
                secondButton.BackColor = Color.Transparent;
                firstButton = null;
                secondButton = null;
                if (Player1_beurt == false)
                {
                    BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                    BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#76FF03");
                    Player1_beurt = true;
                    Player2_beurt = false;
                }
                else if (Player2_beurt == false)
                {
                    BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#76FF03");
                    BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                    Player2_beurt = true;
                    Player1_beurt = false;
                }
            }
            else
            {
                if (selectedtheme =="Default")
                {
                    firstButton.BackgroundImage = Properties.Resources.defaultpic;
                    secondButton.BackgroundImage = Properties.Resources.defaultpic;
                    firstButton = null;
                    secondButton = null;
                }

                else
                {
                    firstButton.BackgroundImage = (Bitmap)Image.FromFile(selectedtheme + @"\" + "defaultpic.png");
                    secondButton.BackgroundImage = (Bitmap)Image.FromFile(selectedtheme + @"\" + "defaultpic.png");
                    firstButton = null;
                    secondButton = null;
                }
            }
        }

        public static void helpmenu()
        {
            byte[] PDF = Properties.Resources.Spelregels;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(PDF);
            System.IO.FileStream f = new System.IO.FileStream("help.pdf", System.IO.FileMode.OpenOrCreate);
            ms.WriteTo(f);
            f.Close();
            ms.Close();
            System.Diagnostics.Process.Start("help.pdf");
        }

        //buttons ---------------------------------------------
        private void ButtonClickHandler(object sender, EventArgs e, int[,,] array, Image[,] arrayimage)
        {
            rotatebutton(sender,array,arrayimage);
        }

        private void Singleplayer_CheckedChanged(object sender, EventArgs e)
        {
            multiplayer = false;
        }

        private void Multiplayer_CheckedChanged(object sender, EventArgs e)
        {
            multiplayer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (multiplayer == true)
            {
                MultiNameninvoeren multinameninvoeren = new MultiNameninvoeren();
                multinameninvoeren.MdiParent = this.ParentForm;
                multinameninvoeren.Show();
                Close();
            }
            else
            {
                SingleNameninvoeren singlenameninvoeren = new SingleNameninvoeren();
                singlenameninvoeren.MdiParent = this.ParentForm;
                singlenameninvoeren.Show();
                Close();
            }

        }

    }
}
