namespace Tic_TacToe
{
    partial class MainScreen
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
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbTurnVal = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbWinnerVal = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picture7 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture5 = new System.Windows.Forms.PictureBox();
            this.picture8 = new System.Windows.Forms.PictureBox();
            this.picture9 = new System.Windows.Forms.PictureBox();
            this.picture6 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTurn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lbTurn.Location = new System.Drawing.Point(94, 87);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(143, 56);
            this.lbTurn.TabIndex = 9;
            this.lbTurn.Text = "Turn";
            // 
            // lbTurnVal
            // 
            this.lbTurnVal.AutoSize = true;
            this.lbTurnVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTurnVal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnVal.ForeColor = System.Drawing.Color.White;
            this.lbTurnVal.Location = new System.Drawing.Point(47, 156);
            this.lbTurnVal.Name = "lbTurnVal";
            this.lbTurnVal.Size = new System.Drawing.Size(234, 56);
            this.lbTurnVal.TabIndex = 10;
            this.lbTurnVal.Text = "Player 1";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbWinner.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lbWinner.Location = new System.Drawing.Point(72, 273);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(209, 56);
            this.lbWinner.TabIndex = 11;
            this.lbWinner.Text = "Winner";
            // 
            // lbWinnerVal
            // 
            this.lbWinnerVal.AutoSize = true;
            this.lbWinnerVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbWinnerVal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinnerVal.ForeColor = System.Drawing.Color.Lime;
            this.lbWinnerVal.Location = new System.Drawing.Point(31, 353);
            this.lbWinnerVal.Name = "lbWinnerVal";
            this.lbWinnerVal.Size = new System.Drawing.Size(312, 56);
            this.lbWinnerVal.TabIndex = 12;
            this.lbWinnerVal.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(41, 449);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(293, 78);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picture7
            // 
            this.picture7.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture7.Location = new System.Drawing.Point(418, 450);
            this.picture7.Name = "picture7";
            this.picture7.Size = new System.Drawing.Size(146, 133);
            this.picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture7.TabIndex = 18;
            this.picture7.TabStop = false;
            this.picture7.Tag = "?";
            this.picture7.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.Black;
            this.picture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture1.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture1.Location = new System.Drawing.Point(418, 33);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(146, 142);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 14;
            this.picture1.TabStop = false;
            this.picture1.Tag = "?";
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture5
            // 
            this.picture5.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture5.Location = new System.Drawing.Point(677, 240);
            this.picture5.Name = "picture5";
            this.picture5.Size = new System.Drawing.Size(146, 136);
            this.picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture5.TabIndex = 15;
            this.picture5.TabStop = false;
            this.picture5.Tag = "?";
            this.picture5.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture8
            // 
            this.picture8.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture8.Location = new System.Drawing.Point(677, 450);
            this.picture8.Name = "picture8";
            this.picture8.Size = new System.Drawing.Size(146, 133);
            this.picture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture8.TabIndex = 16;
            this.picture8.TabStop = false;
            this.picture8.Tag = "?";
            this.picture8.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture9
            // 
            this.picture9.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture9.Location = new System.Drawing.Point(934, 450);
            this.picture9.Name = "picture9";
            this.picture9.Size = new System.Drawing.Size(146, 133);
            this.picture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture9.TabIndex = 17;
            this.picture9.TabStop = false;
            this.picture9.Tag = "?";
            this.picture9.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture6
            // 
            this.picture6.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture6.Location = new System.Drawing.Point(934, 240);
            this.picture6.Name = "picture6";
            this.picture6.Size = new System.Drawing.Size(146, 136);
            this.picture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture6.TabIndex = 19;
            this.picture6.TabStop = false;
            this.picture6.Tag = "?";
            this.picture6.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture3
            // 
            this.picture3.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture3.Location = new System.Drawing.Point(934, 33);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(146, 142);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture3.TabIndex = 22;
            this.picture3.TabStop = false;
            this.picture3.Tag = "?";
            this.picture3.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture2
            // 
            this.picture2.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture2.Location = new System.Drawing.Point(677, 33);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(146, 142);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 20;
            this.picture2.TabStop = false;
            this.picture2.Tag = "?";
            this.picture2.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture4
            // 
            this.picture4.Image = global::Tic_TacToe.Properties.Resources.question_mark_96;
            this.picture4.Location = new System.Drawing.Point(418, 240);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(146, 136);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture4.TabIndex = 21;
            this.picture4.TabStop = false;
            this.picture4.Tag = "?";
            this.picture4.Click += new System.EventHandler(this.picture1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1340, 648);
            this.Controls.Add(this.picture7);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.picture5);
            this.Controls.Add(this.picture8);
            this.Controls.Add(this.picture9);
            this.Controls.Add(this.picture6);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lbWinnerVal);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.lbTurnVal);
            this.Controls.Add(this.lbTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbTurnVal;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label lbWinnerVal;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picture7;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture5;
        private System.Windows.Forms.PictureBox picture8;
        private System.Windows.Forms.PictureBox picture9;
        private System.Windows.Forms.PictureBox picture6;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture4;
    }
}

