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
    public partial class MultiNameninvoeren : Form
    {
        public static string multispeler1, multispeler2;
        public static int length, width;
        public static bool spelmultiplayer;

        public MultiNameninvoeren()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            Spelers f3 = new Spelers();
            f3.MdiParent = this.ParentForm;
            f3.Show();
            Close();
        }

        private void Volgende_Click(object sender, EventArgs e)
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
                if (speler1.Text == "" || speler2.Text == "")
                {
                    errornaam.Text = "Vul een naam in.";
                    errornaam.ForeColor = Color.Red;
                    return;
                }

                else
                {
                    Spel.length = Convert.ToInt32(Lengte.Text);
                    Spel.width = Convert.ToInt32(Breedte.Text);
                    Spel.multinaam1 = speler1.Text;
                    Spel.multinaam2 = speler2.Text;
                    Spel.multiplayer = true;
                    Dobbelsteen f6 = new Dobbelsteen();
                    f6.MdiParent = this.ParentForm;
                    f6.Show();
                    Close();
                }
            }

        }
    }
}
