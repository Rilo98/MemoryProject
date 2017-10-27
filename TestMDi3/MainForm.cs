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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this;
            f2.Show();
        }

        public void afsluiten()
        {
            Close();
        }
    }
}
