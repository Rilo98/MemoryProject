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
    public partial class Spelers : Form
    {
        public Spelers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void Terugspeler_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.ParentForm;
            f2.Show();
            Close();
        }

        public void SinglePlayer_Click(object sender, EventArgs e)
        {
           
            SingleNameninvoeren f4 = new SingleNameninvoeren();
            f4.MdiParent = this.ParentForm;
            f4.Show();
            Close();
        }

        public void MultiPlayer_Click(object sender, EventArgs e)
        {
            Spel spel = new Spel();
            Spel.multiplayer = true;
            MultiNameninvoeren f5 = new MultiNameninvoeren();
            f5.MdiParent = this.ParentForm;
            f5.Show();
            Close();
        }
    }
}
