namespace TestMDi3
{
    partial class Spelers
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
            this.SinglePlayer = new System.Windows.Forms.Button();
            this.MultiPlayer = new System.Windows.Forms.Button();
            this.Terugspeler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinglePlayer
            // 
            this.SinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinglePlayer.Location = new System.Drawing.Point(207, 216);
            this.SinglePlayer.Name = "SinglePlayer";
            this.SinglePlayer.Size = new System.Drawing.Size(219, 70);
            this.SinglePlayer.TabIndex = 0;
            this.SinglePlayer.Text = "Single Player";
            this.SinglePlayer.UseVisualStyleBackColor = true;
            this.SinglePlayer.Click += new System.EventHandler(this.SinglePlayer_Click);
            // 
            // MultiPlayer
            // 
            this.MultiPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiPlayer.Location = new System.Drawing.Point(479, 216);
            this.MultiPlayer.Name = "MultiPlayer";
            this.MultiPlayer.Size = new System.Drawing.Size(219, 70);
            this.MultiPlayer.TabIndex = 1;
            this.MultiPlayer.Text = "MultiPlayer";
            this.MultiPlayer.UseVisualStyleBackColor = true;
            this.MultiPlayer.Click += new System.EventHandler(this.MultiPlayer_Click);
            // 
            // Terugspeler
            // 
            this.Terugspeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terugspeler.Location = new System.Drawing.Point(345, 292);
            this.Terugspeler.Name = "Terugspeler";
            this.Terugspeler.Size = new System.Drawing.Size(219, 70);
            this.Terugspeler.TabIndex = 2;
            this.Terugspeler.Text = "Terug";
            this.Terugspeler.UseVisualStyleBackColor = true;
            this.Terugspeler.Click += new System.EventHandler(this.Terugspeler_Click);
            // 
            // Spelers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.Terugspeler);
            this.Controls.Add(this.MultiPlayer);
            this.Controls.Add(this.SinglePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spelers";
            this.Text = "Spelers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayer;
        private System.Windows.Forms.Button MultiPlayer;
        private System.Windows.Forms.Button Terugspeler;
    }
}