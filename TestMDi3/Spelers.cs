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
            if (File.Exists(@"SPSave.XML"))
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

            else
            {
                SingleNameninvoeren f4 = new SingleNameninvoeren();
                f4.MdiParent = this.ParentForm;
                f4.Show();
                Close();
            }
        }

       

        public void MultiPlayer_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"MPSave.XML"))
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
                    Spel spel = new Spel();
                    Spel.multiplayer = true;
                    MultiNameninvoeren f5 = new MultiNameninvoeren();
                    f5.MdiParent = this.ParentForm;
                    f5.Show();
                    Close();
                }
            }

            else
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
}
