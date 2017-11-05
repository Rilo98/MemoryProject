namespace TestMDi3
{
    partial class Winscherm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_winnaarnaam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_newhighscore = new System.Windows.Forms.Label();
            this.FireTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_combo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ranglijst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 446);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gefeliciteerd!";
            // 
            // label_winnaarnaam
            // 
            this.label_winnaarnaam.AutoSize = true;
            this.label_winnaarnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_winnaarnaam.Location = new System.Drawing.Point(283, 162);
            this.label_winnaarnaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_winnaarnaam.Name = "label_winnaarnaam";
            this.label_winnaarnaam.Size = new System.Drawing.Size(100, 29);
            this.label_winnaarnaam.TabIndex = 3;
            this.label_winnaarnaam.Text = "<naam>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(355, 266);
            this.label_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(20, 24);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 446);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "New Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_newhighscore
            // 
            this.label_newhighscore.AutoSize = true;
            this.label_newhighscore.ForeColor = System.Drawing.Color.YellowGreen;
            this.label_newhighscore.Location = new System.Drawing.Point(277, 252);
            this.label_newhighscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newhighscore.Name = "label_newhighscore";
            this.label_newhighscore.Size = new System.Drawing.Size(100, 13);
            this.label_newhighscore.TabIndex = 7;
            this.label_newhighscore.Text = "NEW HIGHSCORE";
            // 
            // FireTimer
            // 
            this.FireTimer.Interval = 1000;
            this.FireTimer.Tick += new System.EventHandler(this.FireTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Combo";
            // 
            // label_combo
            // 
            this.label_combo.AutoSize = true;
            this.label_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_combo.Location = new System.Drawing.Point(354, 289);
            this.label_combo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_combo.Name = "label_combo";
            this.label_combo.Size = new System.Drawing.Size(20, 24);
            this.label_combo.TabIndex = 9;
            this.label_combo.Text = "0";
            // 
            // Winscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestMDi3.Properties.Resources.achtergrondentrofee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.label_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_newhighscore);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_winnaarnaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Winscherm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public  System.Windows.Forms.Label label_winnaarnaam;
        private System.Windows.Forms.Label label3;
        public  System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_newhighscore;
        private System.Windows.Forms.Timer FireTimer;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label_combo;
    }   
}

