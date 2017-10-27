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
    public partial class Opties : Form
    {
        public Opties()
        {
            InitializeComponent();

            string[] files = System.IO.Directory.GetDirectories(@"\");
            this.dropdown.Items.AddRange(files);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            Hoofdmenu f2 = new Hoofdmenu();
            f2.MdiParent = this.ParentForm;
            f2.Show();
            Close();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            String imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jph| PNG files(*.png)|*.png| All files (*.*)|*.*|";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
