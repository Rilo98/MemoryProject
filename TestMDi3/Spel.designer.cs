namespace TestMDi3
{
    partial class Spel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reset = new System.Windows.Forms.Button();
            this.Label_Player1score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Player2Score = new System.Windows.Forms.Label();
            this.BeurtIndicator1 = new System.Windows.Forms.Button();
            this.BeurtIndicator2 = new System.Windows.Forms.Button();
            this.Stopwatch = new System.Windows.Forms.Label();
            this.timer_Sw = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.Gamemode = new System.Windows.Forms.Label();
            this.Gamemode_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(443, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 525);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(13, 492);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(126, 45);
            this.reset.TabIndex = 26;
            this.reset.Text = "Hoofdmenu";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Player1score
            // 
            this.Label_Player1score.AutoSize = true;
            this.Label_Player1score.BackColor = System.Drawing.Color.Transparent;
            this.Label_Player1score.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Player1score.ForeColor = System.Drawing.Color.White;
            this.Label_Player1score.Location = new System.Drawing.Point(132, 168);
            this.Label_Player1score.Name = "Label_Player1score";
            this.Label_Player1score.Size = new System.Drawing.Size(28, 32);
            this.Label_Player1score.TabIndex = 29;
            this.Label_Player1score.Text = "0";
            this.Label_Player1score.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "Player 1:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Player 2:";
            this.label3.Visible = false;
            // 
            // Label_Player2Score
            // 
            this.Label_Player2Score.AutoSize = true;
            this.Label_Player2Score.BackColor = System.Drawing.Color.Transparent;
            this.Label_Player2Score.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Player2Score.ForeColor = System.Drawing.Color.White;
            this.Label_Player2Score.Location = new System.Drawing.Point(132, 201);
            this.Label_Player2Score.Name = "Label_Player2Score";
            this.Label_Player2Score.Size = new System.Drawing.Size(28, 32);
            this.Label_Player2Score.TabIndex = 32;
            this.Label_Player2Score.Text = "0";
            this.Label_Player2Score.Visible = false;
            // 
            // BeurtIndicator1
            // 
            this.BeurtIndicator1.Enabled = false;
            this.BeurtIndicator1.Location = new System.Drawing.Point(10, 173);
            this.BeurtIndicator1.Name = "BeurtIndicator1";
            this.BeurtIndicator1.Size = new System.Drawing.Size(25, 25);
            this.BeurtIndicator1.TabIndex = 33;
            this.BeurtIndicator1.UseVisualStyleBackColor = true;
            this.BeurtIndicator1.Visible = false;
            // 
            // BeurtIndicator2
            // 
            this.BeurtIndicator2.Enabled = false;
            this.BeurtIndicator2.Location = new System.Drawing.Point(10, 205);
            this.BeurtIndicator2.Name = "BeurtIndicator2";
            this.BeurtIndicator2.Size = new System.Drawing.Size(25, 25);
            this.BeurtIndicator2.TabIndex = 34;
            this.BeurtIndicator2.UseVisualStyleBackColor = true;
            this.BeurtIndicator2.Visible = false;
            // 
            // Stopwatch
            // 
            this.Stopwatch.AutoSize = true;
            this.Stopwatch.BackColor = System.Drawing.Color.Transparent;
            this.Stopwatch.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopwatch.ForeColor = System.Drawing.Color.White;
            this.Stopwatch.Location = new System.Drawing.Point(35, 233);
            this.Stopwatch.Name = "Stopwatch";
            this.Stopwatch.Size = new System.Drawing.Size(108, 32);
            this.Stopwatch.TabIndex = 35;
            this.Stopwatch.Text = "<Timer>";
            this.Stopwatch.Visible = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F);
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(7, 134);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(86, 36);
            this.Score.TabIndex = 36;
            this.Score.Text = "Score:";
            // 
            // Gamemode
            // 
            this.Gamemode.AutoSize = true;
            this.Gamemode.BackColor = System.Drawing.Color.Transparent;
            this.Gamemode.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamemode.ForeColor = System.Drawing.Color.White;
            this.Gamemode.Location = new System.Drawing.Point(11, 37);
            this.Gamemode.Name = "Gamemode";
            this.Gamemode.Size = new System.Drawing.Size(147, 32);
            this.Gamemode.TabIndex = 37;
            this.Gamemode.Text = "Gamemode";
            // 
            // Gamemode_Label
            // 
            this.Gamemode_Label.AutoSize = true;
            this.Gamemode_Label.BackColor = System.Drawing.Color.Transparent;
            this.Gamemode_Label.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamemode_Label.ForeColor = System.Drawing.Color.White;
            this.Gamemode_Label.Location = new System.Drawing.Point(12, 9);
            this.Gamemode_Label.Name = "Gamemode_Label";
            this.Gamemode_Label.Size = new System.Drawing.Size(124, 28);
            this.Gamemode_Label.TabIndex = 38;
            this.Gamemode_Label.Text = "Gamemode:";
            // 
            // Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.Gamemode_Label);
            this.Controls.Add(this.Gamemode);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Stopwatch);
            this.Controls.Add(this.BeurtIndicator2);
            this.Controls.Add(this.BeurtIndicator1);
            this.Controls.Add(this.Label_Player2Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Player1score);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name = "Spel";
            this.Text = "Spel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label Label_Player1score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Player2Score;
        private System.Windows.Forms.Button BeurtIndicator1;
        private System.Windows.Forms.Button BeurtIndicator2;
        private System.Windows.Forms.Label Stopwatch;
        private System.Windows.Forms.Timer timer_Sw;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Gamemode;
        private System.Windows.Forms.Label Gamemode_Label;
    }
}

