namespace TestMDi3
{
    partial class SingleNameninvoeren
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
            this.Singlenaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Volgende = new System.Windows.Forms.Button();
            this.Terug = new System.Windows.Forms.Button();
            this.GrooteSpeelveldSingle = new System.Windows.Forms.Label();
            this.Lengte = new System.Windows.Forms.TextBox();
            this.Breedte = new System.Windows.Forms.TextBox();
            this.LengteLB = new System.Windows.Forms.Label();
            this.BreedteLB = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.errornaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Singlenaam
            // 
            this.Singlenaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singlenaam.Location = new System.Drawing.Point(378, 162);
            this.Singlenaam.Name = "Singlenaam";
            this.Singlenaam.Size = new System.Drawing.Size(245, 53);
            this.Singlenaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // Volgende
            // 
            this.Volgende.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volgende.Location = new System.Drawing.Point(378, 329);
            this.Volgende.Name = "Volgende";
            this.Volgende.Size = new System.Drawing.Size(135, 42);
            this.Volgende.TabIndex = 2;
            this.Volgende.Text = "Volgende";
            this.Volgende.UseVisualStyleBackColor = true;
            this.Volgende.Click += new System.EventHandler(this.Volgende_Click);
            // 
            // Terug
            // 
            this.Terug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terug.Location = new System.Drawing.Point(378, 377);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(135, 42);
            this.Terug.TabIndex = 3;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // GrooteSpeelveldSingle
            // 
            this.GrooteSpeelveldSingle.AutoSize = true;
            this.GrooteSpeelveldSingle.Location = new System.Drawing.Point(375, 239);
            this.GrooteSpeelveldSingle.Name = "GrooteSpeelveldSingle";
            this.GrooteSpeelveldSingle.Size = new System.Drawing.Size(90, 13);
            this.GrooteSpeelveldSingle.TabIndex = 4;
            this.GrooteSpeelveldSingle.Text = "Groote speelveld:";
            // 
            // Lengte
            // 
            this.Lengte.Location = new System.Drawing.Point(378, 255);
            this.Lengte.Name = "Lengte";
            this.Lengte.Size = new System.Drawing.Size(100, 20);
            this.Lengte.TabIndex = 5;
            // 
            // Breedte
            // 
            this.Breedte.Location = new System.Drawing.Point(378, 281);
            this.Breedte.Name = "Breedte";
            this.Breedte.Size = new System.Drawing.Size(100, 20);
            this.Breedte.TabIndex = 6;
            // 
            // LengteLB
            // 
            this.LengteLB.AutoSize = true;
            this.LengteLB.Location = new System.Drawing.Point(329, 258);
            this.LengteLB.Name = "LengteLB";
            this.LengteLB.Size = new System.Drawing.Size(43, 13);
            this.LengteLB.TabIndex = 7;
            this.LengteLB.Text = "Lengte:";
            // 
            // BreedteLB
            // 
            this.BreedteLB.AutoSize = true;
            this.BreedteLB.Location = new System.Drawing.Point(325, 284);
            this.BreedteLB.Name = "BreedteLB";
            this.BreedteLB.Size = new System.Drawing.Size(47, 13);
            this.BreedteLB.TabIndex = 8;
            this.BreedteLB.Text = "Breedte:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(375, 304);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(92, 13);
            this.status.TabIndex = 9;
            this.status.Text = "Voer 2 getallen in.";
            // 
            // errornaam
            // 
            this.errornaam.AutoSize = true;
            this.errornaam.Location = new System.Drawing.Point(375, 146);
            this.errornaam.Name = "errornaam";
            this.errornaam.Size = new System.Drawing.Size(0, 13);
            this.errornaam.TabIndex = 10;
            // 
            // SingleNameninvoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.errornaam);
            this.Controls.Add(this.status);
            this.Controls.Add(this.BreedteLB);
            this.Controls.Add(this.LengteLB);
            this.Controls.Add(this.Breedte);
            this.Controls.Add(this.Lengte);
            this.Controls.Add(this.GrooteSpeelveldSingle);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.Volgende);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Singlenaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleNameninvoeren";
            this.Text = "SingleNameninvoeren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Singlenaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volgende;
        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.Label GrooteSpeelveldSingle;
        private System.Windows.Forms.TextBox Lengte;
        private System.Windows.Forms.TextBox Breedte;
        private System.Windows.Forms.Label LengteLB;
        private System.Windows.Forms.Label BreedteLB;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label errornaam;
    }
}