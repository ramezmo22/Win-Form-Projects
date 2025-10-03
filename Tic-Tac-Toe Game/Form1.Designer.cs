namespace Tic_Tac_Toe_Game
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Winner = new System.Windows.Forms.Label();
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.lbl_Who_Turn = new System.Windows.Forms.Label();
            this.lbl_Who_Win = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Title.Location = new System.Drawing.Point(428, 26);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(396, 58);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Tic-Tac-Toe Game";
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.AutoSize = true;
            this.lbl_Winner.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winner.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Winner.Location = new System.Drawing.Point(46, 294);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(143, 45);
            this.lbl_Winner.TabIndex = 1;
            this.lbl_Winner.Text = "Winner :";
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.AutoSize = true;
            this.lbl_Turn.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turn.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Turn.Location = new System.Drawing.Point(46, 136);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(102, 45);
            this.lbl_Turn.TabIndex = 2;
            this.lbl_Turn.Text = "Turn :";
            // 
            // lbl_Who_Turn
            // 
            this.lbl_Who_Turn.AutoSize = true;
            this.lbl_Who_Turn.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Who_Turn.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Who_Turn.Location = new System.Drawing.Point(46, 215);
            this.lbl_Who_Turn.Name = "lbl_Who_Turn";
            this.lbl_Who_Turn.Size = new System.Drawing.Size(131, 45);
            this.lbl_Who_Turn.TabIndex = 3;
            this.lbl_Who_Turn.Text = "Player 1";
            // 
            // lbl_Who_Win
            // 
            this.lbl_Who_Win.AutoSize = true;
            this.lbl_Who_Win.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Who_Win.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Who_Win.Location = new System.Drawing.Point(46, 373);
            this.lbl_Who_Win.Name = "lbl_Who_Win";
            this.lbl_Who_Win.Size = new System.Drawing.Size(183, 45);
            this.lbl_Who_Win.TabIndex = 4;
            this.lbl_Who_Win.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(39, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Image = ((System.Drawing.Image)(resources.GetObject("btn_1.Image")));
            this.btn_1.Location = new System.Drawing.Point(405, 106);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(139, 138);
            this.btn_1.TabIndex = 6;
            this.btn_1.Tag = "Q";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_2.Image")));
            this.btn_2.Location = new System.Drawing.Point(554, 106);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(139, 138);
            this.btn_2.TabIndex = 7;
            this.btn_2.Tag = "Q";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Image = ((System.Drawing.Image)(resources.GetObject("btn_3.Image")));
            this.btn_3.Location = new System.Drawing.Point(703, 106);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(139, 138);
            this.btn_3.TabIndex = 8;
            this.btn_3.Tag = "Q";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Image = ((System.Drawing.Image)(resources.GetObject("btn_4.Image")));
            this.btn_4.Location = new System.Drawing.Point(405, 260);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(139, 138);
            this.btn_4.TabIndex = 9;
            this.btn_4.Tag = "Q";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Image = ((System.Drawing.Image)(resources.GetObject("btn_5.Image")));
            this.btn_5.Location = new System.Drawing.Point(554, 255);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(139, 138);
            this.btn_5.TabIndex = 10;
            this.btn_5.Tag = "Q";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Image = ((System.Drawing.Image)(resources.GetObject("btn_6.Image")));
            this.btn_6.Location = new System.Drawing.Point(703, 255);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(139, 138);
            this.btn_6.TabIndex = 11;
            this.btn_6.Tag = "Q";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Image = ((System.Drawing.Image)(resources.GetObject("btn_7.Image")));
            this.btn_7.Location = new System.Drawing.Point(405, 404);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(139, 138);
            this.btn_7.TabIndex = 12;
            this.btn_7.Tag = "Q";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Image = ((System.Drawing.Image)(resources.GetObject("btn_8.Image")));
            this.btn_8.Location = new System.Drawing.Point(554, 404);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(139, 138);
            this.btn_8.TabIndex = 13;
            this.btn_8.Tag = "Q";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Image = ((System.Drawing.Image)(resources.GetObject("btn_9.Image")));
            this.btn_9.Location = new System.Drawing.Point(703, 404);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(139, 138);
            this.btn_9.TabIndex = 14;
            this.btn_9.Tag = "Q";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1188, 673);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Who_Win);
            this.Controls.Add(this.lbl_Who_Turn);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.lbl_Winner);
            this.Controls.Add(this.lbl_Title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_Main";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Main_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Winner;
        private System.Windows.Forms.Label lbl_Turn;
        private System.Windows.Forms.Label lbl_Who_Turn;
        private System.Windows.Forms.Label lbl_Who_Win;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
    }
}

