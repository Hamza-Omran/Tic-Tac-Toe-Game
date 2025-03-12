using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_TacToe.Properties;

namespace Tic_TacToe
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private bool GetDraw()
        {
            return !(picture1.Tag == "?" || picture2.Tag == "?" || picture3.Tag == "?" || picture4.Tag == "?"
                || picture5.Tag == "?" || picture6.Tag == "?" || picture7.Tag == "?" || picture8.Tag == "?"
                || picture9.Tag == "?");
        }

        private bool GetResult()
        {
            if (GetDraw())
            {
                lbWinner.Text = "Draw";
                MessageBox.Show("Draw", "Message");
                return false;
            }
                
            string result = "O";

            if (lbTurnVal.Text == "Player 1")
                result = "X";

            if (picture1.Tag == result && picture2.Tag == result
                && picture3.Tag == result)
            {
                picture1.BackColor = Color.LightGreen;
                picture2.BackColor = Color.LightGreen;
                picture3.BackColor = Color.LightGreen;

                return true;
            }

            if (picture4.Tag == result && picture5.Tag == result
                && picture6.Tag == result)
            {
                picture4.BackColor = Color.LightGreen;
                picture5.BackColor = Color.LightGreen;
                picture6.BackColor = Color.LightGreen;
                
                return true;
            }

            if (picture7.Tag == result && picture8.Tag == result
                && picture9.Tag == result)
            {
                picture7.BackColor = Color.LightGreen;
                picture8.BackColor = Color.LightGreen;
                picture9.BackColor = Color.LightGreen;
                return true;
            }

            if (picture1.Tag == result && picture4.Tag == result
                && picture7.Tag == result)
            {
                picture1.BackColor = Color.LightGreen;
                picture4.BackColor = Color.LightGreen;
                picture7.BackColor = Color.LightGreen;
                return true;
            }

            if (picture2.Tag == result && picture5.Tag == result
                && picture8.Tag == result)
            {
                picture2.BackColor = Color.LightGreen;
                picture8.BackColor = Color.LightGreen;
                picture5.BackColor = Color.LightGreen;
                return true;
            }
            if (picture3.Tag == result && picture6.Tag == result
                && picture9.Tag == result)
            {
                picture3.BackColor = Color.LightYellow;
                picture6.BackColor = Color.LightYellow;
                picture9.BackColor = Color.LightYellow;
                return true;
            }
            if (picture1.Tag == result && picture5.Tag == result
                && picture9.Tag == result){

                picture1.BackColor = Color.LightGreen;
                picture5.BackColor = Color.LightGreen;
                picture9.BackColor = Color.LightGreen;
                return true;
            }
            if (picture3.Tag == result && picture5.Tag == result
                && picture7.Tag == result) 
            {
                picture3.BackColor = Color.LightGreen;
                picture5.BackColor = Color.LightGreen;
                picture7.BackColor = Color.LightGreen;
                return true;
            }
            return false;
            
        }

        private void UpdateResult()
        {
            if (GetResult())
            {
                lbWinnerVal.Text = lbTurnVal.Text;
                MessageBox.Show(lbTurnVal.Text + " is the winner", "Message");
                    
            }
        }

        private void UpdateImageAndTurn(object sender)
        {
            
            if (lbWinnerVal.Text == "In Progress")
            {
                if (((PictureBox)sender).Tag == "?")
                {
                    if (lbTurnVal.Text == "Player 1")
                    {
                        ((PictureBox)sender).Image = Resources.X;
                        ((PictureBox)sender).Tag = "X";
                        UpdateResult();
                        lbTurnVal.Text = "Player 2";
                    }
                    else
                    {   
                        ((PictureBox)sender).Image = Resources.O;   
                        ((PictureBox)sender).Tag = "O";
                        UpdateResult();
                        lbTurnVal.Text = "Player 1";
                    }
                    
                }
                else
                    MessageBox.Show("You Cannot Play Here!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Game Is Over!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

        }

        private void ResetForm()
        {
            lbWinnerVal.Text = "In Progress";
            lbTurnVal.Text = "Player 1";

            picture1.Image=Resources.question_mark_96;
            picture1.Tag = "?";

            picture2.Image = Resources.question_mark_96;
            picture2.Tag = "?";

            picture3.Image = Resources.question_mark_96;
            picture3.Tag = "?";

            picture4.Image = Resources.question_mark_96;
            picture4.Tag = "?";
            picture6.Image = Resources.question_mark_96;
            picture6.Tag = "?";
            picture5.Image = Resources.question_mark_96;
            picture5.Tag = "?";
            picture7.Image = Resources.question_mark_96;
            picture7.Tag = "?";
            picture8.Image = Resources.question_mark_96;
            picture8.Tag = "?";
            picture9.Image = Resources.question_mark_96;
            picture9.Tag = "?";

            picture1.BackColor = Color.Transparent;
            picture2.BackColor = Color.Transparent;
            picture3.BackColor = Color.Transparent;
            picture4.BackColor = Color.Transparent;
            picture5.BackColor = Color.Transparent;
            picture6.BackColor = Color.Transparent;
            picture7.BackColor = Color.Transparent;
            picture8.BackColor = Color.Transparent;
            picture9.BackColor = Color.Transparent;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 400, 10, 400, 400);
            e.Graphics.DrawLine(Pen, 600, 10, 600, 400);
            e.Graphics.DrawLine(Pen, 240, 130, 770, 130);
            e.Graphics.DrawLine(Pen, 240, 260, 770, 260);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            UpdateImageAndTurn(sender);
        }
    }
}
