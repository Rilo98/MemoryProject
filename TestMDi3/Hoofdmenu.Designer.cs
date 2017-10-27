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
            this.SuspendLayout();
            // 
            // Speel
            // 
            this.Speel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Speel.Location = new System.Drawing.Point(391, 205);
            this.Speel.Name = "Speel";
            this.Speel.Size = new System.Drawing.Size(132, 52);
            this.Speel.TabIndex = 0;
            this.Speel.Text = "Speel";
            this.Speel.UseVisualStyleBackColor = true;
            this.Speel.UseWaitCursor = true;
            this.Speel.Click += new System.EventHandler(this.Speel_Click);
            // 
            // Opties
            // 
            this.Opties.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Opties.Location = new System.Drawing.Point(391, 263);
            this.Opties.Name = "Opties";
            this.Opties.Size = new System.Drawing.Size(132, 52);
            this.Opties.TabIndex = 1;
            this.Opties.Text = "Opties";
            this.Opties.UseVisualStyleBackColor = true;
            this.Opties.UseWaitCursor = true;
            this.Opties.Click += new System.EventHandler(this.Opties_Click);
            // 
            // Afsluiten
            // 
            this.Afsluiten.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Afsluiten.Location = new System.Drawing.Point(391, 321);
            this.Afsluiten.Name = "Afsluiten";
            this.Afsluiten.Size = new System.Drawing.Size(132, 52);
            this.Afsluiten.TabIndex = 2;
            this.Afsluiten.Text = "Afsluiten";
            this.Afsluiten.UseVisualStyleBackColor = true;
            this.Afsluiten.UseWaitCursor = true;
            this.Afsluiten.Click += new System.EventHandler(this.Afsluiten_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.Afsluiten);
            this.Controls.Add(this.Opties);
            this.Controls.Add(this.Speel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Speel;
        private System.Windows.Forms.Button Opties;
        private System.Windows.Forms.Button Afsluiten;
    }
}