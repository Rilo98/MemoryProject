﻿using System;
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
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void Speel_Click(object sender, EventArgs e)
        {
            Spelers f3 = new Spelers();
            f3.MdiParent = this.ParentForm;
            f3.Show();
            Close();
        }

        private void Afsluiten_Click(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).afsluiten();
        }

        private void Opties_Click(object sender, EventArgs e)
        {
            Opties opties = new Opties();
            opties.MdiParent = this.ParentForm;
            opties.Show();
            Close();
        }
    }
}
