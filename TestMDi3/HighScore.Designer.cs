namespace TestMDi3
{
    partial class Highscore
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
            this.label1 = new System.Windows.Forms.Label();
            this.HighscoreName = new System.Windows.Forms.Label();
            this.HighscoreCombo = new System.Windows.Forms.Label();
            this.HighscoreScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Highscore menu";
            // 
            // HighscoreName
            // 
            this.HighscoreName.Location = new System.Drawing.Point(12, 97);
            this.HighscoreName.Name = "HighscoreName";
            this.HighscoreName.Size = new System.Drawing.Size(100, 23);
            this.HighscoreName.TabIndex = 6;
            this.HighscoreName.Text = "HighscoreName";
            // 
            // HighscoreCombo
            // 
            this.HighscoreCombo.AutoSize = true;
            this.HighscoreCombo.Location = new System.Drawing.Point(361, 97);
            this.HighscoreCombo.Name = "HighscoreCombo";
            this.HighscoreCombo.Size = new System.Drawing.Size(88, 13);
            this.HighscoreCombo.TabIndex = 7;
            this.HighscoreCombo.Text = "HighscoreCombo";
            // 
            // HighscoreScore
            // 
            this.HighscoreScore.AutoSize = true;
            this.HighscoreScore.Location = new System.Drawing.Point(668, 97);
            this.HighscoreScore.Name = "HighscoreScore";
            this.HighscoreScore.Size = new System.Drawing.Size(83, 13);
            this.HighscoreScore.TabIndex = 8;
            this.HighscoreScore.Text = "HighscoreScore";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hoofdmenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HighscoreScore);
            this.Controls.Add(this.HighscoreCombo);
            this.Controls.Add(this.HighscoreName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HighscoreName;
        private System.Windows.Forms.Label HighscoreCombo;
        private System.Windows.Forms.Label HighscoreScore;
        private System.Windows.Forms.Button button1;
    }
}