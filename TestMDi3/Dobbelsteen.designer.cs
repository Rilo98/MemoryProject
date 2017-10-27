namespace TestMDi3
{
    partial class Dobbelsteen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gooi_1 = new System.Windows.Forms.Button();
            this.Speler1 = new System.Windows.Forms.Label();
            this.Speler2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.afterlb = new System.Windows.Forms.Label();
            this.Terug = new System.Windows.Forms.Button();
            this.volgende = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gooi_1
            // 
            this.Gooi_1.Location = new System.Drawing.Point(456, 413);
            this.Gooi_1.Name = "Gooi_1";
            this.Gooi_1.Size = new System.Drawing.Size(75, 23);
            this.Gooi_1.TabIndex = 0;
            this.Gooi_1.Text = "Gooi!";
            this.Gooi_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Gooi_1.UseVisualStyleBackColor = true;
            this.Gooi_1.Click += new System.EventHandler(this.Gooi_1_Click);
            // 
            // Speler1
            // 
            this.Speler1.AutoSize = true;
            this.Speler1.Location = new System.Drawing.Point(341, 383);
            this.Speler1.Name = "Speler1";
            this.Speler1.Size = new System.Drawing.Size(46, 13);
            this.Speler1.TabIndex = 5;
            this.Speler1.Text = "Speler 1";
            // 
            // Speler2
            // 
            this.Speler2.AutoSize = true;
            this.Speler2.Location = new System.Drawing.Point(611, 383);
            this.Speler2.Name = "Speler2";
            this.Speler2.Size = new System.Drawing.Size(46, 13);
            this.Speler2.TabIndex = 6;
            this.Speler2.Text = "Speler 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(503, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(243, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // afterlb
            // 
            this.afterlb.AutoSize = true;
            this.afterlb.Location = new System.Drawing.Point(453, 439);
            this.afterlb.Name = "afterlb";
            this.afterlb.Size = new System.Drawing.Size(28, 13);
            this.afterlb.TabIndex = 7;
            this.afterlb.Text = "after";
            // 
            // Terug
            // 
            this.Terug.Location = new System.Drawing.Point(404, 474);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(75, 23);
            this.Terug.TabIndex = 8;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // volgende
            // 
            this.volgende.Enabled = false;
            this.volgende.Location = new System.Drawing.Point(503, 474);
            this.volgende.Name = "volgende";
            this.volgende.Size = new System.Drawing.Size(75, 23);
            this.volgende.TabIndex = 9;
            this.volgende.Text = "Volgende";
            this.volgende.UseVisualStyleBackColor = true;
            this.volgende.Click += new System.EventHandler(this.volgende_Click);
            // 
            // Dobbelsteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.volgende);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.afterlb);
            this.Controls.Add(this.Speler2);
            this.Controls.Add(this.Speler1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gooi_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dobbelsteen";
            this.Text = "Dobbelsteen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gooi_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label Speler1;
        public System.Windows.Forms.Label Speler2;
        private System.Windows.Forms.Label afterlb;
        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.Button volgende;
    }
}

