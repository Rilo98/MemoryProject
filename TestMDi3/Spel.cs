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
        public static bool multiplayer, Player1_beurt, Player2_beurt, Doorgaan1Speler, DoorgaanMultiPlayer;
        public static string singlenaam, multinaam1, multinaam2, selectedtheme = "Default",winnaar, winnaar_score;

        public static int arrayid1, arrayid2, textboxint3, textboxint4, textboxint5, picturenumber1 = 0, picturenumber2 = 1, Player1_score, Player2_score, counterint = (length * width / 2), x_kaarten, Player1_zetten, Player2_zetten, disabledint;
        Button firstButton = null, secondButton = null;

        public Spel()
        {
            InitializeComponent();

            SwitchTurn();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);


            if (multiplayer == true)
            {
                Gamemode.Text = "Multiplayer";

                if (DoorgaanMultiPlayer == true)
                {
                    XmlDocument docMP = new XmlDocument();
                    docMP.Load("MPSave.xml");
                    length = length = Convert.ToInt32(docMP.SelectSingleNode("values/ints/length").InnerText);
                    width = width = Convert.ToInt32(docMP.SelectSingleNode("values/ints/width").InnerText);

                    multinaam1 = docMP.SelectSingleNode("values/ints/multinaam1").InnerText;
                    multinaam2 = docMP.SelectSingleNode("values/ints/multinaam2").InnerText;

                    label2.Text = multinaam1;
                    label3.Text = multinaam2;


                    selectedtheme = Convert.ToString(docMP.SelectSingleNode("values/ints/selectedtheme").InnerText);

                    Player1_score = Convert.ToInt32(docMP.SelectSingleNode("values/ints/Player1_score").InnerText);
                    Player2_score = Convert.ToInt32(docMP.SelectSingleNode("values/ints/Player2_score").InnerText);
                    Label_Player1score.Text = Convert.ToString(Player1_score);
                    Label_Player2Score.Text = Convert.ToString(Player2_score);

                    BeurtIndicator1.Visible = Enabled;
                    BeurtIndicator2.Visible = Enabled;
                    label2.Visible = Enabled;
                    label3.Visible = Enabled;
                    Label_Player1score.Visible = Enabled;
                    Label_Player2Score.Visible = Enabled;
                    reset.Visible = Enabled;
                    textboxint3 = (length * width) / 2;
                    textboxint4 = (length * width) + 1;
                    textboxint5 = (length * width);

                    int[,,] array = new int[2, textboxint3, 3];
                    Image[,] arrayimage = new Image[2, textboxint3];
                    string[,] disabledbuttons = new string[2, textboxint3];


                    theme(arrayimage);
                    LoadOldExceptionsMP(array, disabledbuttons);
                    createbuttons(array, arrayimage,disabledbuttons , length, width);
                    PlayerBeurtStartGame();
                    LoadDisabledButtonsMP(array);

                    this.TimerMP.Enabled = true;
                    this.TimerMP.Interval = 1000;
                    this.TimerMP.Tick += delegate (object sender, EventArgs e)
                    { TimerMP_Tick(sender, e, disabledbuttons, array); };
                    
                    this.timer1.Interval = 250;
                    this.timer1.Tick += delegate (object sender, EventArgs e)
                    { timer1_Tick(sender, e, disabledbuttons); };
                }

                else
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
                    string[,] disabledbuttons = new string[2, textboxint3];
                    reset.Visible = Enabled;
                    theme(arrayimage);
                    fillarray(array);
                    createbuttons(array, arrayimage, disabledbuttons, length, width);
                    PlayerBeurtStartGame();


                    this.TimerMP.Enabled = true;
                    this.TimerMP.Interval = 1000;
                    this.TimerMP.Tick += delegate (object sender, EventArgs e)
                    { TimerMP_Tick(sender, e, disabledbuttons, array); };

                    this.timer1.Interval = 250;
                    this.timer1.Tick += delegate (object sender, EventArgs e)
                    { timer1_Tick(sender, e, disabledbuttons); };
                }
            }

            else
            {
                Gamemode.Text = "Race tegen de klok";
                if (Doorgaan1Speler == true)
                {
                    XmlDocument docSP = new XmlDocument();
                    docSP.Load("SPSave.xml");
                    length = length = Convert.ToInt32(docSP.SelectSingleNode("values/ints/length").InnerText);
                    width = width = Convert.ToInt32(docSP.SelectSingleNode("values/ints/width").InnerText);

                    singlenaam = Convert.ToString(docSP.SelectSingleNode("values/ints/singlenaam").InnerText);

                    BeurtIndicator1.Visible = false;
                    BeurtIndicator2.Visible = false;
                    label2.Text = singlenaam;
                    label2.Visible = true;
                    label3.Visible = false;
                    Label_Player1score.Visible = true;
                    Label_Player2Score.Visible = false;
                    textboxint3 = (length * width) / 2;
                    textboxint4 = (length * width) + 1;
                    textboxint5 = (length * width);
                    int[,,] array = new int[2, textboxint3, 3];
                    Image[,] arrayimage = new Image[2, textboxint3];
                    string[,] disabledbuttons = new string[2, textboxint3];
                    reset.Visible = Enabled;
                    theme(arrayimage);
                    LoadOldExceptionsSP(array,disabledbuttons);
                    createbuttons(array, arrayimage, disabledbuttons, length, width);
                    LoadDisabledButtonsSP(array);
                    LoadOldSP();
                    // timer_Sw
                    // 
                    Stopwatch.Text = Convert.ToString(counterint);
                    this.timer_Sw.Enabled = true;
                    this.timer_Sw.Interval = 1000;
                    this.timer_Sw.Tick += delegate (object sender, EventArgs e)
                    { timer_Sw_Tick(sender, e, arrayimage, array, disabledbuttons); };
                    Stopwatch.Visible = true;
                    timer_Sw.Enabled = true;

                    this.timer1.Interval = 250;
                    this.timer1.Tick += delegate (object sender, EventArgs e)
                    { timer1_Tick(sender, e, disabledbuttons); };
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
                    string[,] disabledbuttons = new string[2, textboxint3];
                    reset.Visible = Enabled;
                    theme(arrayimage);
                    fillarray(array);
                    createbuttons(array, arrayimage, disabledbuttons, length, width);
                    
                    // timer_Sw
                    // 
                    Stopwatch.Text = Convert.ToString(counterint);
                    this.timer_Sw.Enabled = true;
                    this.timer_Sw.Interval = 1000;
                    this.timer_Sw.Tick += delegate (object sender, EventArgs e)
                    { timer_Sw_Tick(sender, e, arrayimage, array, disabledbuttons); };
                    Stopwatch.Visible = true;
                    timer_Sw.Enabled = true;

                    this.timer1.Interval = 250;
                    this.timer1.Tick += delegate (object sender, EventArgs e)
                    { timer1_Tick(sender, e, disabledbuttons); };
                }
            }
        }
        
       
        public void WriteSP(int[,,] array, string[,] disabledbuttons)
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

            writer.WriteStartElement("arraydisabledbuttons");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (disabledbuttons[i, j] != null)
                    {
                        writer.WriteElementString("disabledbuttons" + i + "-" + j, Convert.ToString(disabledbuttons[i, j]));
                    }
                    else
                    {
                        writer.WriteElementString("disabledbuttons" + i + "-" + j, "empty");
                    }
                }
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();
        }
        public void WriteMP(int[,,] arrayMP, string[,] disabledbuttons)
        {
            XmlTextWriter writer = new XmlTextWriter("MPSave.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("values");
            writer.WriteStartElement("ints");
            writer.WriteElementString("Player1_score", Convert.ToString(Player1_score));
            writer.WriteElementString("Player2_score", Convert.ToString(Player2_score));
            writer.WriteElementString("multinaam1", multinaam1);
            writer.WriteElementString("multinaam2", multinaam2);
            writer.WriteElementString("length", Convert.ToString(length));
            writer.WriteElementString("width", Convert.ToString(width));
            writer.WriteElementString("selectedtheme", Convert.ToString(selectedtheme));
            writer.WriteEndElement();
            writer.WriteStartElement("arrays");
            writer.WriteStartElement("arrayimage");

            for (int i = 0; i < arrayMP.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMP.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayMP.GetLength(2); k++)
                    {
                        string ArrayXML = "arrayXML" + Convert.ToString(i) + "-" + Convert.ToString(j) + "-" + Convert.ToString(k);
                        writer.WriteElementString(ArrayXML, Convert.ToString(arrayMP[i, j, k]));
                    }
                }
            }
            writer.WriteEndElement();

            writer.WriteStartElement("arraydisabledbuttons");
            for (int i = 0; i < arrayMP.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMP.GetLength(1); j++)
                {
                    if (disabledbuttons[i,j] != null)
                    {
                        writer.WriteElementString("disabledbuttons" + i + "-" + j, Convert.ToString(disabledbuttons[i, j]));
                    }
                    else
                    {
                        writer.WriteElementString("disabledbuttons" + i + "-" + j, "empty");
                    }
                }
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();
        }

        public void LoadOldSP()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SPSave.xml");
            length                      = Convert.ToInt32(doc.SelectSingleNode("values/ints/length").InnerText);
            width                       = Convert.ToInt32(doc.SelectSingleNode("values/ints/width").InnerText);
            selectedtheme               = Convert.ToString(doc.SelectSingleNode("values/ints/selectedtheme").InnerText);
            Player1_score               = Convert.ToInt32(doc.SelectSingleNode("values/ints/score").InnerText);
            counterint                  = Convert.ToInt32(doc.SelectSingleNode("values/ints/counterint").InnerText);
            label2.Text                 = Convert.ToString(doc.SelectSingleNode("values/ints/singlenaam").InnerText); 
            Label_Player1score.Text     = Convert.ToString(Player1_score);
            Stopwatch.Text              = Convert.ToString(counterint);
        }

        private void TimerMP_Tick(object sender, EventArgs e)
        {

        }

        public void LoadOldMP(int[,,] array)
        {
            XmlDocument MP = new XmlDocument();
            MP.Load("MPSave.xml");

        }

        public void LoadOldExceptionsSP(int[,,] array, string[,] disabledbuttons)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SPSave.xml");
            for (int i = 0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j<array.GetLength(1); j++)
                {
                    string button = doc.SelectSingleNode("values/arrays/arraydisabledbuttons/" + "disabledbuttons" + Convert.ToString(i) + "-" + Convert.ToString(j)).InnerText;
                    disabledbuttons[i, j] = button;
                    for (int k = 0; k<array.GetLength(2); k++)
                    {
                        string ArrayXML = "arrayXML" + Convert.ToString(i) + "-" + Convert.ToString(j) + "-" + Convert.ToString(k);
                        array[i, j, k] = Convert.ToInt32(doc.SelectSingleNode("values/arrays/arrayimage/" + ArrayXML).InnerText);
                    }
                }
            }
        }


        public void LoadOldExceptionsMP(int[,,] array, string[,] disabledbuttons)
        {
            XmlDocument MP = new XmlDocument();
            MP.Load("MPSave.xml");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    string button = MP.SelectSingleNode("values/arrays/arraydisabledbuttons/" + "disabledbuttons" + Convert.ToString(i) + "-" + Convert.ToString(j)).InnerText;
                    disabledbuttons[i, j] = button;
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        string ArrayXML = "arrayXML" + Convert.ToString(i) + "-" + Convert.ToString(j) + "-" + Convert.ToString(k);
                        array[i, j, k] = Convert.ToInt32(MP.SelectSingleNode("values/arrays/arrayimage/" + ArrayXML).InnerText);
                    }
                }
            }
        }

        public void LoadDisabledButtonsMP(int[,,] array)
        {
            XmlDocument MP = new XmlDocument();
            MP.Load("MPSave.xml");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    string button = MP.SelectSingleNode("values/arrays/arraydisabledbuttons/" + "disabledbuttons" + Convert.ToString(i) + "-" + Convert.ToString(j)).InnerText;
                    if (button != "empty")
                    {
                        {
                            tableLayoutPanel1.Controls[button].Enabled = false;
                            tableLayoutPanel1.Controls[button].BackgroundImage = null;
                            tableLayoutPanel1.Controls[button].BackColor = Color.Transparent;
                        }
                    }
                }
            }
        }

        public void LoadDisabledButtonsSP(int[,,] array)
        {
            XmlDocument SP = new XmlDocument();
            SP.Load("SPSave.xml");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    string button = SP.SelectSingleNode("values/arrays/arraydisabledbuttons/" + "disabledbuttons" + Convert.ToString(i) + "-" + Convert.ToString(j)).InnerText;
                    if (button != "empty")
                    {
                        {
                            tableLayoutPanel1.Controls[button].Enabled = false;
                            tableLayoutPanel1.Controls[button].BackgroundImage = null;
                            tableLayoutPanel1.Controls[button].BackColor = Color.Transparent;
                        }
                    }
                }
            }
        }

        private void PlayerBeurtStartGame()
        {
            if (Player1_beurt == true)
            {
                BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#76FF03");
                BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#F5F5F5");

                label2.Font = new Font(label2.Font, FontStyle.Bold);
                Label_Player1score.Font = new Font(label2.Font, FontStyle.Bold);
                label2.ForeColor = Color.White;
                Label_Player1score.ForeColor = Color.White;

                label3.Font = new Font(label3.Font, FontStyle.Regular);
                Label_Player2Score.Font = new Font(label3.Font, FontStyle.Regular);
                label3.ForeColor = Color.DimGray;
                Label_Player2Score.ForeColor = Color.DimGray;
            }
            else if (Player2_beurt == true)
            {
                BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#76FF03");

                label2.Font = new Font(label2.Font, FontStyle.Regular);
                Label_Player1score.Font = new Font(label2.Font, FontStyle.Regular);
                label2.ForeColor = Color.DimGray;
                Label_Player1score.ForeColor = Color.DimGray;

                label3.Font = new Font(label3.Font, FontStyle.Bold);
                Label_Player2Score.Font = new Font(label3.Font, FontStyle.Bold);
                label3.ForeColor = Color.White;
                Label_Player2Score.ForeColor = Color.White;
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

        private void createbuttons(int[,,] array, Image[,] arrayimage,string[,] disabledbuttons, int length, int width)
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
                    { ButtonClickHandler(sender, e, array, arrayimage, disabledbuttons); };
                }

                else
                {
                    button.BackgroundImage = (Bitmap)Image.FromFile(selectedtheme + @"\" + "defaultpic.png"); ;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Click += delegate (object sender, EventArgs e)
                    { ButtonClickHandler(sender, e, array, arrayimage, disabledbuttons); };
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

        private void rotatebutton(object sender, int[,,] array, Image[,] arrayimage, string[,] disabledbuttons)                            //changes image based on button number
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

        private void PlayerScore()                                                                                                          //adds score based on player turn
        {
            if (multiplayer == true)
            {

                if (BeurtIndicator1.BackColor == ColorTranslator.FromHtml("#76FF03"))
                {
                    // Speler 1 scoort een punt
                    Player1_score = Player1_score + 1;
                    if (x_kaarten == textboxint3)
                    {
                        Player1_score = Player1_score - 1;
                    }
                    Label_Player1score.Text = Convert.ToString(Player1_score);
                }
                if (BeurtIndicator2.BackColor == ColorTranslator.FromHtml("#76FF03"))
                {
                    // Speler 2 scoort een punt
                    Player2_score = Player2_score + 1;
                    if (x_kaarten == textboxint3)
                    {
                        Player2_score = Player2_score - 1;
                    }
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

        private  void checkwinnaar()
        {
            if (x_kaarten == textboxint3)
            {
                if (Player1_score > Player2_score)
                {
                    winnaar = multinaam1;
                    winnaar_score = Convert.ToString(Player1_score);
                    Winscherm winscherm = new Winscherm();
                    winscherm.MdiParent = this.ParentForm;
                    winscherm.Show();
                    Close();
                }

                if (Player2_score > Player1_score)
                {
                    winnaar = multinaam2;
                    winnaar_score = Convert.ToString(Player2_score);
                    Winscherm winscherm = new Winscherm();
                    winscherm.MdiParent = this.ParentForm;
                    winscherm.Show();
                    Close();
                }
            }
        }
        
        private void SwitchTurn()
        {
            if (BeurtIndicator2.BackColor == ColorTranslator.FromHtml("#76FF03"))
            {

                Player2_zetten = Player2_zetten + 1;
                BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#76FF03");
                BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#F5F5F5");

                label2.Font = new Font(label2.Font, FontStyle.Bold);
                Label_Player1score.Font = new Font(label2.Font, FontStyle.Bold);
                label2.ForeColor = Color.White;
                Label_Player1score.ForeColor = Color.White;

                label3.Font = new Font(label3.Font, FontStyle.Regular);
                Label_Player2Score.Font = new Font(label3.Font, FontStyle.Regular);
                label3.ForeColor = Color.DimGray;
                Label_Player2Score.ForeColor = Color.DimGray;
            }
            else if (BeurtIndicator1.BackColor == ColorTranslator.FromHtml("#76FF03"))
            {

                Player1_zetten = Player1_zetten + 1;
                BeurtIndicator1.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                BeurtIndicator2.BackColor = ColorTranslator.FromHtml("#76FF03");

                label2.Font = new Font(label2.Font, FontStyle.Regular);
                Label_Player1score.Font = new Font(label2.Font, FontStyle.Regular);
                label2.ForeColor = Color.DimGray;
                Label_Player1score.ForeColor = Color.DimGray;

                label3.Font = new Font(label3.Font, FontStyle.Bold);
                Label_Player2Score.Font = new Font(label3.Font, FontStyle.Bold);
                label3.ForeColor = Color.White;
                Label_Player2Score.ForeColor = Color.White;

            }

        }
        private void timer_Sw_Tick(object sender, EventArgs e, Image[,] arrayimage, int[,,] array, string[,] disabledbuttons)                                                  //when the time is up in singleplayer it will stop the game and prompt the player to restart/go to the main menu
        {
            WriteSP(array,disabledbuttons);
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
                File.Delete("SPSave.xml");

                if (result == DialogResult.Yes)
                {
                    Spel.Doorgaan1Speler = false;
                    Spel.multiplayer = false;
                    Spel spel = new Spel();
                    spel.MdiParent = this.ParentForm;
                    counterint = (length * width / 2);
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
        private void timer1_Tick(object sender, EventArgs e, string[,] disabledbuttons)                                             //timer waits 250ms before turning the cards back around
        {
            timer1.Stop();

            if ((arrayid1 == arrayid2 - textboxint3) || (arrayid1 == arrayid2 + textboxint3))
            {
                x_kaarten = x_kaarten + 1;
                checkwinnaar();
                PlayerScore();
                firstButton.Enabled = false;
                firstButton.BackgroundImage = null;
                firstButton.BackColor = Color.Transparent;
                secondButton.Enabled = false;
                secondButton.BackgroundImage = null;
                secondButton.BackColor = Color.Transparent;

                disabledbuttons[0, disabledint] = firstButton.Name;
                disabledbuttons[1, disabledint] = secondButton.Name;
                disabledint++;

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
                    SwitchTurn();
                    firstButton.BackgroundImage = Properties.Resources.defaultpic;
                    secondButton.BackgroundImage = Properties.Resources.defaultpic;
                    firstButton = null;
                    secondButton = null;
                }

                else
                {
                    SwitchTurn();
                    firstButton.BackgroundImage = (Bitmap)Image.FromFile(selectedtheme + @"\" + "defaultpic.png");
                    secondButton.BackgroundImage = (Bitmap)Image.FromFile(selectedtheme + @"\" + "defaultpic.png");
                    firstButton = null;
                    secondButton = null;
                }
            }
        }


        private void TimerMP_Tick(object sender, EventArgs e, string[,] disabledbuttons, int[,,] array)                         
        {
            WriteMP(array, disabledbuttons);
        }

        public static void helpmenu()
        {
            byte[] PDF = Properties.Resources.Spelregels;
            MemoryStream ms = new MemoryStream(PDF);
            FileStream f = new FileStream("help.pdf", FileMode.OpenOrCreate);
            ms.WriteTo(f);
            f.Close();
            ms.Close();
            System.Diagnostics.Process.Start("help.pdf");
        }

        //buttons ---------------------------------------------
        private void ButtonClickHandler(object sender, EventArgs e, int[,,] array, Image[,] arrayimage, string [,] disabledbuttons)
        {
            rotatebutton(sender,array, arrayimage,disabledbuttons);
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
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).afsluiten();
        }

    }
}
