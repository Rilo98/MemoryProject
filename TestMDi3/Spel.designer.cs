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
            this.TimerMP = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelcombo1 = new System.Windows.Forms.Label();
            this.Combo_Player1_label = new System.Windows.Forms.Label();
            this.Combo_Player2_label = new System.Windows.Forms.Label();
            this.labelcombo2 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.reset.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(12, 446);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(95, 29);
            this.reset.TabIndex = 26;
            this.reset.Text = "Hoofdmenu";
            this.reset.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(35, 231);
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
            this.Label_Player2Score.Location = new System.Drawing.Point(132, 231);
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
            this.BeurtIndicator2.Location = new System.Drawing.Point(10, 235);
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
            this.Stopwatch.Location = new System.Drawing.Point(35, 200);
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
            this.Gamemode_Label.Size = new System.Drawing.Size(119, 28);
            this.Gamemode_Label.TabIndex = 38;
            this.Gamemode_Label.Text = "Spelmodus:";
            // 
            // TimerMP
            // 
            this.TimerMP.Tick += new System.EventHandler(this.TimerMP_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 44;
            this.button1.Text = "Herstart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 45;
            this.button2.Text = "Afsluiten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelcombo1
            // 
            this.labelcombo1.AutoSize = true;
            this.labelcombo1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcombo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelcombo1.Location = new System.Drawing.Point(220, 166);
            this.labelcombo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcombo1.Name = "labelcombo1";
            this.labelcombo1.Size = new System.Drawing.Size(98, 32);
            this.labelcombo1.TabIndex = 46;
            this.labelcombo1.Text = "Combo:";
            // 
            // Combo_Player1_label
            // 
            this.Combo_Player1_label.AutoSize = true;
            this.Combo_Player1_label.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Player1_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Combo_Player1_label.Location = new System.Drawing.Point(316, 166);
            this.Combo_Player1_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Combo_Player1_label.Name = "Combo_Player1_label";
            this.Combo_Player1_label.Size = new System.Drawing.Size(28, 32);
            this.Combo_Player1_label.TabIndex = 47;
            this.Combo_Player1_label.Text = "0";
            // 
            // Combo_Player2_label
            // 
            this.Combo_Player2_label.AutoSize = true;
            this.Combo_Player2_label.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Player2_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Combo_Player2_label.Location = new System.Drawing.Point(316, 235);
            this.Combo_Player2_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Combo_Player2_label.Name = "Combo_Player2_label";
            this.Combo_Player2_label.Size = new System.Drawing.Size(28, 32);
            this.Combo_Player2_label.TabIndex = 49;
            this.Combo_Player2_label.Text = "0";
            // 
            // labelcombo2
            // 
            this.labelcombo2.AutoSize = true;
            this.labelcombo2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcombo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelcombo2.Location = new System.Drawing.Point(220, 235);
            this.labelcombo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcombo2.Name = "labelcombo2";
            this.labelcombo2.Size = new System.Drawing.Size(98, 32);
            this.labelcombo2.TabIndex = 48;
            this.labelcombo2.Text = "Combo:";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.message.Location = new System.Drawing.Point(153, 446);
            this.message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 32);
            this.message.TabIndex = 50;
            // 
            // Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Combo_Player2_label);
            this.Controls.Add(this.labelcombo2);
            this.Controls.Add(this.Combo_Player1_label);
            this.Controls.Add(this.labelcombo1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Timer TimerMP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelcombo1;
        private System.Windows.Forms.Label Combo_Player1_label;
        private System.Windows.Forms.Label Combo_Player2_label;
        private System.Windows.Forms.Label labelcombo2;
        private System.Windows.Forms.Label message;
    }
}

