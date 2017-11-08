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
using TestMDi3;

namespace TestMDi3
{
    /// <summary>class SingleNameninvoeren : Form</summary>
    /// <para>This class is the main class SingleNameninvoerencs Form</para>
    public partial class SingleNameninvoeren : Form
    {
        /// <summary>Method Singlenameninvoeren</summary>
        /// <para>Method to let the user fill in the textboxes and changes the text in the form for which language is selected</para>
        public SingleNameninvoeren()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            Lengte.Value = 4;
            Lengte.Maximum = 8;
            Lengte.Minimum = 4;
            
            Breedte.Value = 4;
            Breedte.Maximum = 8;
            Breedte.Minimum = 4;

            if (Spel.taalEngels == true)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "Terug")
                    {
                        button.Text = "Back";
                    }
                    if (button.Text == "Volgende")
                    {
                        button.Text = "Next";
                    }
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    if (label.Text == "Speler:")
                    {
                        label.Text = "Player:";
                    }
                    if (label.Text == "Formaat speelveld <4-8>")
                    {
                        label.Text = "Size game board <4-8>";
                    }
                    if (label.Text == "Lengte:")
                    {
                        label.Text = "Length:";
                    }
                    if (label.Text == "Breedte:")
                    {
                        label.Text = "Width:";
                    }
                }
            }
        }

        /// <summary>Method for the button Terug_Click</summary>
        /// <para>This method will go back to the Spelers.cs form</para>
        private void Terug_Click(object sender, EventArgs e)
        {
            Spelers f3 = new Spelers();
            f3.MdiParent = this.ParentForm;
            f3.Show();
            Close();
        }

        /// <summary>Method for the the button Volgende_Click</summary>
        /// <para>This method will check if everything has a value and of that is true it will load the game with the values given</para>
        public void Volgende_Click(object sender, EventArgs e)
        {
            if (Breedte.Text == "" || Lengte.Text == "" || (Convert.ToInt32(Lengte.Text) > 8 || Convert.ToInt32(Lengte.Text) < 4) || (Convert.ToInt32(Breedte.Text) > 8 || Convert.ToInt32(Breedte.Text) < 4))
            {
                status.Text = "Voer een getal tussen de 4 en de 8 in.";
                status.ForeColor = Color.Red;
                return;
            }
            else if ((Convert.ToInt32(Lengte.Text) == 7 && Convert.ToInt32(Breedte.Text) == 7) || (Convert.ToInt32(Lengte.Text) == 5 && Convert.ToInt32(Breedte.Text) == 5) || (Convert.ToInt32(Lengte.Text) == 7 && Convert.ToInt32(Breedte.Text) == 5) || (Convert.ToInt32(Lengte.Text) == 5 && Convert.ToInt32(Breedte.Text) == 7))
            {
                status.Text = "Voer 2 even getallen, of een even en oneven getal.";
                status.ForeColor = Color.Red;
                return;
            }

            else
            {
                if (Singlenaam.Text == "")
                {
                    errornaam.Text = "Vul een naam in.";
                    errornaam.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    Spel.length = Convert.ToInt32(Lengte.Text);
                    Spel.width = Convert.ToInt32(Breedte.Text);
                    Spel.singlenaam = Singlenaam.Text;
                    Spel.multiplayer = false;
                    Spel spel = new Spel();
                    spel.MdiParent = this.ParentForm;
                    spel.Show();
                    Close();
                }
            }
        }
    }
}
