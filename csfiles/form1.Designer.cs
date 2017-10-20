namespace WindowsFormsApp3
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.Singleplayer = new System.Windows.Forms.RadioButton();
            this.Multiplayer = new System.Windows.Forms.RadioButton();
            this.Label_Player1score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Player2Score = new System.Windows.Forms.Label();
            this.BeurtIndicator1 = new System.Windows.Forms.Button();
            this.BeurtIndicator2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(12, 140);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(100, 23);
            this.Apply.TabIndex = 22;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 487);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Label1";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(12, 476);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 23);
            this.reset.TabIndex = 26;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Singleplayer
            // 
            this.Singleplayer.AutoSize = true;
            this.Singleplayer.Checked = true;
            this.Singleplayer.Location = new System.Drawing.Point(12, 94);
            this.Singleplayer.Name = "Singleplayer";
            this.Singleplayer.Size = new System.Drawing.Size(82, 17);
            this.Singleplayer.TabIndex = 27;
            this.Singleplayer.TabStop = true;
            this.Singleplayer.Text = "Singleplayer";
            this.Singleplayer.UseVisualStyleBackColor = true;
            this.Singleplayer.CheckedChanged += new System.EventHandler(this.Singleplayer_CheckedChanged);
            // 
            // Multiplayer
            // 
            this.Multiplayer.AutoSize = true;
            this.Multiplayer.Location = new System.Drawing.Point(12, 117);
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Size = new System.Drawing.Size(75, 17);
            this.Multiplayer.TabIndex = 28;
            this.Multiplayer.Text = "Multiplayer";
            this.Multiplayer.UseVisualStyleBackColor = true;
            this.Multiplayer.CheckedChanged += new System.EventHandler(this.Multiplayer_CheckedChanged);
            // 
            // Label_Player1score
            // 
            this.Label_Player1score.AutoSize = true;
            this.Label_Player1score.Location = new System.Drawing.Point(92, 173);
            this.Label_Player1score.Name = "Label_Player1score";
            this.Label_Player1score.Size = new System.Drawing.Size(13, 13);
            this.Label_Player1score.TabIndex = 29;
            this.Label_Player1score.Text = "0";
            this.Label_Player1score.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Player 1:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Player 2:";
            this.label3.Visible = false;
            // 
            // Label_Player2Score
            // 
            this.Label_Player2Score.AutoSize = true;
            this.Label_Player2Score.Location = new System.Drawing.Point(92, 199);
            this.Label_Player2Score.Name = "Label_Player2Score";
            this.Label_Player2Score.Size = new System.Drawing.Size(13, 13);
            this.Label_Player2Score.TabIndex = 32;
            this.Label_Player2Score.Text = "0";
            this.Label_Player2Score.Visible = false;
            // 
            // BeurtIndicator1
            // 
            this.BeurtIndicator1.Enabled = false;
            this.BeurtIndicator1.Location = new System.Drawing.Point(12, 169);
            this.BeurtIndicator1.Name = "BeurtIndicator1";
            this.BeurtIndicator1.Size = new System.Drawing.Size(20, 20);
            this.BeurtIndicator1.TabIndex = 33;
            this.BeurtIndicator1.UseVisualStyleBackColor = true;
            this.BeurtIndicator1.Visible = false;
            // 
            // BeurtIndicator2
            // 
            this.BeurtIndicator2.Enabled = false;
            this.BeurtIndicator2.Location = new System.Drawing.Point(12, 195);
            this.BeurtIndicator2.Name = "BeurtIndicator2";
            this.BeurtIndicator2.Size = new System.Drawing.Size(20, 20);
            this.BeurtIndicator2.TabIndex = 34;
            this.BeurtIndicator2.UseVisualStyleBackColor = true;
            this.BeurtIndicator2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 511);
            this.Controls.Add(this.BeurtIndicator2);
            this.Controls.Add(this.BeurtIndicator1);
            this.Controls.Add(this.Label_Player2Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Player1score);
            this.Controls.Add(this.Multiplayer);
            this.Controls.Add(this.Singleplayer);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.RadioButton Singleplayer;
        private System.Windows.Forms.RadioButton Multiplayer;
        private System.Windows.Forms.Label Label_Player1score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Player2Score;
        private System.Windows.Forms.Button BeurtIndicator1;
        private System.Windows.Forms.Button BeurtIndicator2;
    }
}

