using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Forms;
*/
namespace TestMDi3
{
    public partial class Winscherm : Form
    {
        private Point pt;
        public Winscherm()
        {
            InitializeComponent();
            this.BackgroundImage = win1;
            System.Media.SoundPlayer player0 = new System.Media.SoundPlayer(Properties.Resources.celebrate);
            player0.Play();
            FireTimer.Start();
            label_winnaarnaam.Text = Spel.winnaar;
            label_score.Text = Spel.winnaar_score;
            pt = this.Location;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        private int timertick = 0;
        private Image win1 = Properties.Resources.achtergrondentrofee0;
        private Image win2 = Properties.Resources.achtergrondentrofee1;
        private Image win3 = Properties.Resources.achtergrondentrofee2;
        private Image win4 = Properties.Resources.achtergrondentrofee3;

        private void FireTimer_Tick(object sender, EventArgs e)
        {
            timertick += 1;
            if (timertick == 1)
            {
                this.BackgroundImage = win2;
                label1.ForeColor = Color.Green;
                button3.BackColor = DefaultBackColor;
            }
            if (timertick == 2)
            {
                this.BackgroundImage = win3;

            }
            if (timertick == 3)
            {
                this.BackgroundImage = win4;
                label1.ForeColor = Color.DarkOrange;
            }
            if (timertick == 4)
            {
                this.BackgroundImage = win1;
                timertick = 0;
                label1.ForeColor = Color.Green;
                button3.BackColor = Color.GreenYellow;

            }
        }

        //menu knop
        private void button2_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            Close();
        }

        //new game knop
        private void button3_Click(object sender, EventArgs e)
        {
            Spelers f3 = new Spelers();
            f3.MdiParent = this.ParentForm;
            f3.Show();
            Close();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Location = pt;
        }
    }
}
