﻿namespace TestMDi3
{
    partial class Opties
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
            this.Terug = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.themename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Terug
            // 
            this.Terug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terug.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terug.Location = new System.Drawing.Point(420, 405);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(135, 42);
            this.Terug.TabIndex = 7;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(222, 251);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(170, 38);
            this.dropdown.TabIndex = 8;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(224, 113);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(142, 35);
            this.upload.TabIndex = 9;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nieuw Thema";
            // 
            // themename
            // 
            this.themename.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themename.Location = new System.Drawing.Point(222, 55);
            this.themename.Name = "themename";
            this.themename.Size = new System.Drawing.Size(144, 35);
            this.themename.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thema Naam:";
            // 
            // Apply
            // 
            this.Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apply.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply.Location = new System.Drawing.Point(240, 308);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(126, 40);
            this.Apply.TabIndex = 13;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecteer een Thema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thema Naam:";
            // 
            // Opties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.themename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.Terug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opties";
            this.Text = "Opties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox themename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}