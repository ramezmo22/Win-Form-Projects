using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        enum turn { player1 = 1 , player2 = 2 }
        turn thisTurn=turn.player1;
        enum Winner { player1 = 1 , player2 = 2 ,Draw = 3 }
        void UpdateInfos(object sender,EventArgs e)
        {
            Button selected = (Button)sender;

            if ((thisTurn == turn.player1) && (selected.Tag.ToString() == "Q"))
            {  
                    selected.Image = Image.FromFile(@"C:\Users\Acer\Downloads\_Images\Images\X.png");
                    thisTurn = turn.player2;
                    selected.Tag = "X";
                lbl_Who_Turn.Text = "Player 2";
            }
            else if ((thisTurn == turn.player2 ) && (selected.Tag.ToString() == "Q"))
            {  
                selected.Image= Image.FromFile(@"C:\Users\Acer\Downloads\_Images\Images\O.png");
                thisTurn = turn.player1;
                selected.Tag ="O";
                lbl_Who_Turn.Text = "Player 1";
            }
            else
            {
                MessageBox.Show("This Box is selected ","Alarm !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
       
        void CheckWin(object sender, EventArgs e)
        {
           CheckWin();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestartTheGame();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void frm_Main_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 5;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            // الخطوط الأفقيّة
            e.Graphics.DrawLine(Pen, 400, 250, 850, 250);
            e.Graphics.DrawLine(Pen, 400, 400, 850, 400);

            // الخطوط العموديّة
            e.Graphics.DrawLine(Pen, 550, 100, 550, 550);
            e.Graphics.DrawLine(Pen, 700, 100, 700, 550);
        }

        //btn_1.Image = Image.FromFile(@"C:\Users\Acer\Downloads\_Images\Images\question-mark-96.png");
        //btn_1.Image = Image.FromFile(@"C:\Users\Acer\Downloads\_Images\Images\X.png");
        //btn_1.Image = Image.FromFile(@"C:\Users\Acer\Downloads\_Images\Images\O.png");
        private void btn_1_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();


        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            UpdateInfos(sender, e);
            CheckWin();

        }
        void CheckWin()
        {
            Button[] btns = { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };

                //here i use some copilot  Because I stuck here :-(
            int[,] winPatterns = new int[,]
            {
                {0,1,2}, {3,4,5}, {6,7,8}, 
                {0,3,6}, {1,4,7}, {2,5,8}, 
                {0,4,8}, {2,4,6}           
            };

            for (int i = 0; i < winPatterns.GetLength(0); i++)
            {
                string a = btns[winPatterns[i, 0]].Tag.ToString();
                string b = btns[winPatterns[i, 1]].Tag.ToString();
                string c = btns[winPatterns[i, 2]].Tag.ToString();
                //im dead here :-(
                if (a != "Q" && a == b && b == c)
                {
                    lbl_Who_Win.Text = (a == "X") ? "Player 1 Win!" : "Player 2 Win!";
                    DisableAllButtons(btns);
                    lbl_Who_Turn.Text = "Game Over";
                    btns[winPatterns[i, 0]].BackColor = Color.Green;
                    btns[winPatterns[i, 1]].BackColor = Color.Green;
                    btns[winPatterns[i, 2]].BackColor = Color.Green;
                    MessageBox.Show((a == "X") ? "        Player 1 Win!         " : "Player 2 Win!", "Congratulations !", MessageBoxButtons.OK);
                    return;
                }
            }

            bool draw = true;
            foreach (Button btn in btns)
            {
                if (btn.Tag == null || btn.Tag.ToString() == "Q")
                {
                    draw = false;
                    break;
                }
            }
            if (draw)
            {
                lbl_Who_Win.Text = "Draw";
                lbl_Who_Turn.Text = "Game Over";
                MessageBox.Show("It's a Draw!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAllButtons(btns);
            }
        }

        void DisableAllButtons(Button[] btns)
        {
            foreach (Button btn in btns)
            {
                btn.Enabled = false;
            }
        }
        void RestartTheGame()
        {
            Button[] btns = { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };

            foreach (Button btn in btns)
            {
                btn.Enabled = true;
                btn.Image= Image.FromFile(@"C:\Users\Acer\Downloads\_Images\Images\question-mark-96.png");
                btn.Tag = "Q";
                btn.BackColor = Color.Black;
                lbl_Who_Turn.Text = "Player 1";
                lbl_Who_Win.Text = "in progress";
            }
            //----------------------------------
            //end Ramez alkhabbas :-)

        }
    }
}
