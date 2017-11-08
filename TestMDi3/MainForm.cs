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
    /// <summary>class MainForm : Form</summary>
    /// <para>This is the class for the mainform.cs. this form is the mdi parent and contains all the mdi childs</para>
    public partial class MainForm : Form
    {
        /// <summary>method MainForm</summary>
        /// <para>This method loads the location of the form, and loads the main menu mdi in the form</para>
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

        /// <summary>method afsluiten</summary>
        /// <para>this method closes the form</para>
        public void afsluiten()
        {
            Close();
        }
    }
}
