namespace DobbelsteenMemory
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gooi_1
            // 
            this.Gooi_1.Location = new System.Drawing.Point(225, 300);
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
            this.Speler1.Location = new System.Drawing.Point(110, 269);
            this.Speler1.Name = "Speler1";
            this.Speler1.Size = new System.Drawing.Size(46, 13);
            this.Speler1.TabIndex = 5;
            this.Speler1.Text = "Speler 1";
            // 
            // Speler2
            // 
            this.Speler2.AutoSize = true;
            this.Speler2.Location = new System.Drawing.Point(380, 269);
            this.Speler2.Name = "Speler2";
            this.Speler2.Size = new System.Drawing.Size(46, 13);
            this.Speler2.TabIndex = 6;
            this.Speler2.Text = "Speler 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(272, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Dobbelsteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.Speler2);
            this.Controls.Add(this.Speler1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gooi_1);
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
        private System.Windows.Forms.Label Speler1;
        private System.Windows.Forms.Label Speler2;
    }
}

