using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TestMDi3
{
    /// <summary>class Spelers : Form</summary>
    /// <para>This is the main class for the Spelers.cs form .</para>
    public partial class Spelers : Form
    {
        /// <summary>Method Spelers</summary>
        /// <para>This method initializes the form and checks if the buttons need to have an other language</para>
        /// <para>Creator: Richard en Hidzer</para>
        public Spelers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            if (Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Singleplayer")
                    {
                        button.Text = "Singleplayer";
                    }
                    if (button.Text == "Multiplayer")
                    {
                        button.Text = "Multiplayer";
                    }
                    if (button.Text == "Terug")
                    {
                        button.Text = "Back";
                    }
                }
            }
        }
        /// <summary>Method for button Terugspeler_Click</summary>
        /// <para>This method will load the Hoofdmenu form when clicked on this button</para>
        /// <para>Creator: Richard</para>
        private void Terugspeler_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.ParentForm;
            f2.Show();
            Close();
        }
        /// <summary>Method SinglePlayer_Click</summary>
        /// <para>This method will load the singleplayer game and checks if an savefile is available and will load the old values if answered yes in the popupbox and loads the game with old values</para>
        /// <para>If answered no it will load the "singlenameninvoeren" form</para>
        /// <para>Creator: Kevin</para>
        public void SinglePlayer_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"SPSave.sav"))
            {

                if(Spel.taalEngels == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Er is een spel opgeslagen; Wilt u doorgaan?", "Doorgaan", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Spel.Doorgaan1Speler = true;
                        Spel.multiplayer = false;
                        Spel spel = new Spel();
                        spel.MdiParent = this.ParentForm;
                        spel.Show();
                        Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        SingleNameninvoeren f4 = new SingleNameninvoeren();
                        f4.MdiParent = this.ParentForm;
                        f4.Show();
                        Close();
                    }
                }
                if (Spel.taalEngels == true)
                {
                    DialogResult dialogResult = MessageBox.Show("There is an unfinished game saved, do you want to continue?", "Continue", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Spel.Doorgaan1Speler = true;
                        Spel.multiplayer = false;
                        Spel spel = new Spel();
                        spel.MdiParent = this.ParentForm;
                        spel.Show();
                        Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        SingleNameninvoeren f4 = new SingleNameninvoeren();
                        f4.MdiParent = this.ParentForm;
                        f4.Show();
                        Close();
                    }
                }
            }
            else
            {
                SingleNameninvoeren f4 = new SingleNameninvoeren();
                f4.MdiParent = this.ParentForm;
                f4.Show();
                Close();
            }
        }
        /// <summary>Method MinglePlayer_Click</summary>
        /// <para>This method will load the singleplayer game and checks if an savefile is available and will load the old values if answered yes in the popupbox and loads the game with old values</para>
        /// <para>If answered no it will load the "multinameninvoeren" form</para>
        /// <para>Creator: Kevin</para>
        public void MultiPlayer_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"MPSave.sav"))
            {
                if(Spel.taalEngels == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Er is een spel opgeslagen; Wilt u doorgaan?", "Doorgaan", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Spel.DoorgaanMultiPlayer = true;
                        Spel.multiplayer = true;
                        Spel spel = new Spel();
                        spel.MdiParent = this.ParentForm;
                        spel.Show();
                        Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Spel.multiplayer = true;
                        MultiNameninvoeren f5 = new MultiNameninvoeren();
                        f5.MdiParent = this.ParentForm;
                        f5.Show();
                        Close();
                    }
                }
                if (Spel.taalEngels == true)
                {
                    DialogResult dialogResult = MessageBox.Show("There is an unfinished game saved, do you want to continue?", "Continue", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Spel.DoorgaanMultiPlayer = true;
                        Spel.multiplayer = true;
                        Spel spel = new Spel();
                        spel.MdiParent = this.ParentForm;
                        spel.Show();
                        Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Spel.multiplayer = true;
                        MultiNameninvoeren f5 = new MultiNameninvoeren();
                        f5.MdiParent = this.ParentForm;
                        f5.Show();
                        Close();
                    }
                }

            }

            else
            {
                Spel.multiplayer = true;
                MultiNameninvoeren f5 = new MultiNameninvoeren();
                f5.MdiParent = this.ParentForm;
                f5.Show();
                Close();
            }
        }
    }
}
