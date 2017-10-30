namespace TestMDi3
{
    partial class Hoofdmenu
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
            this.Speel = new System.Windows.Forms.Button();
            this.Opties = new System.Windows.Forms.Button();
            this.Afsluiten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speel
            // 
            this.Speel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Speel.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speel.Location = new System.Drawing.Point(406, 180);
            this.Speel.Name = "Speel";
            this.Speel.Size = new System.Drawing.Size(180, 52);
            this.Speel.TabIndex = 0;
            this.Speel.Text = "Speel";
            this.Speel.UseVisualStyleBackColor = true;
            this.Speel.UseWaitCursor = true;
            this.Speel.Click += new System.EventHandler(this.Speel_Click);
            // 
            // Opties
            // 
            this.Opties.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Opties.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opties.Location = new System.Drawing.Point(406, 327);
            this.Opties.Name = "Opties";
            this.Opties.Size = new System.Drawing.Size(180, 52);
            this.Opties.TabIndex = 1;
            this.Opties.Text = "Opties";
            this.Opties.UseVisualStyleBackColor = true;
            this.Opties.UseWaitCursor = true;
            this.Opties.Click += new System.EventHandler(this.Opties_Click);
            // 
            // Afsluiten
            // 
            this.Afsluiten.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Afsluiten.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afsluiten.Location = new System.Drawing.Point(406, 398);
            this.Afsluiten.Name = "Afsluiten";
            this.Afsluiten.Size = new System.Drawing.Size(180, 52);
            this.Afsluiten.TabIndex = 2;
            this.Afsluiten.Text = "Afsluiten";
            this.Afsluiten.UseVisualStyleBackColor = true;
            this.Afsluiten.UseWaitCursor = true;
            this.Afsluiten.Click += new System.EventHandler(this.Afsluiten_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::TestMDi3.Properties.Resources.question;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(936, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Memory";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(406, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Highscores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Afsluiten);
            this.Controls.Add(this.Opties);
            this.Controls.Add(this.Speel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Speel;
        private System.Windows.Forms.Button Opties;
        private System.Windows.Forms.Button Afsluiten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}