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
            this.Singlenaam.Font = new System.Drawing.Font("Segoe UI Emoji", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singlenaam.Location = new System.Drawing.Point(454, 106);
            this.Singlenaam.Name = "Singlenaam";
            this.Singlenaam.Size = new System.Drawing.Size(245, 61);
            this.Singlenaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speler:";
            // 
            // Volgende
            // 
            this.Volgende.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volgende.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volgende.Location = new System.Drawing.Point(546, 427);
            this.Volgende.Name = "Volgende";
            this.Volgende.Size = new System.Drawing.Size(166, 42);
            this.Volgende.TabIndex = 2;
            this.Volgende.Text = "Volgende";
            this.Volgende.UseVisualStyleBackColor = true;
            this.Volgende.Click += new System.EventHandler(this.Volgende_Click);
            // 
            // Terug
            // 
            this.Terug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terug.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terug.Location = new System.Drawing.Point(374, 427);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(166, 42);
            this.Terug.TabIndex = 3;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // GrooteSpeelveldSingle
            // 
            this.GrooteSpeelveldSingle.AutoSize = true;
            this.GrooteSpeelveldSingle.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrooteSpeelveldSingle.ForeColor = System.Drawing.Color.White;
            this.GrooteSpeelveldSingle.Location = new System.Drawing.Point(450, 230);
            this.GrooteSpeelveldSingle.Name = "GrooteSpeelveldSingle";
            this.GrooteSpeelveldSingle.Size = new System.Drawing.Size(249, 28);
            this.GrooteSpeelveldSingle.TabIndex = 4;
            this.GrooteSpeelveldSingle.Text = "Formaat speelveld <4-8>:";
            // 
            // Lengte
            // 
            this.Lengte.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lengte.Location = new System.Drawing.Point(599, 261);
            this.Lengte.Name = "Lengte";
            this.Lengte.Size = new System.Drawing.Size(100, 35);
            this.Lengte.TabIndex = 5;
            // 
            // Breedte
            // 
            this.Breedte.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Breedte.Location = new System.Drawing.Point(599, 302);
            this.Breedte.Name = "Breedte";
            this.Breedte.Size = new System.Drawing.Size(100, 35);
            this.Breedte.TabIndex = 6;
            // 
            // LengteLB
            // 
            this.LengteLB.AutoSize = true;
            this.LengteLB.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengteLB.ForeColor = System.Drawing.Color.White;
            this.LengteLB.Location = new System.Drawing.Point(513, 264);
            this.LengteLB.Name = "LengteLB";
            this.LengteLB.Size = new System.Drawing.Size(80, 28);
            this.LengteLB.TabIndex = 7;
            this.LengteLB.Text = "Lengte:";
            // 
            // BreedteLB
            // 
            this.BreedteLB.AutoSize = true;
            this.BreedteLB.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreedteLB.ForeColor = System.Drawing.Color.White;
            this.BreedteLB.Location = new System.Drawing.Point(505, 305);
            this.BreedteLB.Name = "BreedteLB";
            this.BreedteLB.Size = new System.Drawing.Size(88, 28);
            this.BreedteLB.TabIndex = 8;
            this.BreedteLB.Text = "Breedte:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(363, 341);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 28);
            this.status.TabIndex = 9;
            // 
            // errornaam
            // 
            this.errornaam.AutoSize = true;
            this.errornaam.Location = new System.Drawing.Point(391, 141);
            this.errornaam.Name = "errornaam";
            this.errornaam.Size = new System.Drawing.Size(0, 13);
            this.errornaam.TabIndex = 10;
            // 
            // SingleNameninvoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
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