namespace TestMDi3
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
            this.SuspendLayout();
            // 
            // Terug
            // 
            this.Terug.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(156, 85);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(121, 21);
            this.dropdown.TabIndex = 8;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(178, 112);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 9;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Opties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.Terug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opties";
            this.Text = "Opties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button upload;
    }
}