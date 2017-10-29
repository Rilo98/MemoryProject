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
    public partial class SingleNameninvoeren : Form
    {
        
        
        public SingleNameninvoeren()
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
