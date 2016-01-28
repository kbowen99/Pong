using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Frm_Pongy : Form
    {
        //variables
        #region Vars
        int MoveSpeed = 5;
        int x ; //no more than 400
        int y ;
        Random rndgen = new Random();
        const int speed = 8;
        bool[] player1 = new bool[2];
        bool[] player2 = new bool[2];
        int players = 2;
        int challengemode = 2;
        int playerLeftScore = 0;
        int playerRightScore = 0;
        int scorelimit = 14;
        bool countscore = true;
        bool GameSpawning = false;
        #endregion
        public Frm_Pongy()
        {
            //this makes all the magic happen
            InitializeComponent();
            int x = MoveSpeed; //no more than 400
            int y = MoveSpeed;
        }

        private void Frm_Pongy_KeyDown(object sender, KeyEventArgs e)
        {
            //Keydown codes
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.Space && Tmr_Game.Enabled == false)
            {
                //start the games
                Tmr_Game.Start();
                Tmr_Paddle.Start();
                if (GameSpawning == false)
                {
                    RndBallSpawn();
                    RndDir();
                    GameSpawning = true;
                }
                Btn_Restart.Visible = false;
                Btn_Quitter.Visible = false;
            }
            else if (keyCode == Keys.W && Pic_LeftPaddle.Top > Pic_GameArea.Top)
                player1[0] = true; //move left paddle up
            else if (keyCode == Keys.S && Pic_LeftPaddle.Bottom < Pic_GameArea.Bottom)
                player1[1] = true; //move left paddle down
            else if (keyCode == Keys.Up && Pic_RightPaddle.Top > Pic_GameArea.Top)
                player2[0] = true; //move right paddle up
            else if (keyCode == Keys.Down && Pic_RightPaddle.Bottom < Pic_GameArea.Bottom)
                player2[1] = true; //move right paddle down
            else if (keyCode == Keys.Escape)
            {
                Tmr_Game.Stop();
                Tmr_Paddle.Stop();
                GameSpawning = true;
                Btn_Quitter.Visible = true;
                Btn_Restart.Visible = true;
            }
        }

        private void Tmr_game_Tick(object sender, EventArgs e)
        {
            // game runner
            if (players == 1)
            {
                //one player computer competition
                Pic_LeftPaddle.Top = PicBall.Top - 10;
            }
            else if (players == 0)
            {
                //CPU VS CPU Mode
                Pic_LeftPaddle.Top = PicBall.Top - 10;
                Pic_RightPaddle.Top = PicBall.Top - 10;
            }
            //Move Left/Right
            PicBall.Left = PicBall.Left + x;
            //Move Up/Down
            PicBall.Top = PicBall.Top + y;
            //change direction if ceiling is hit
            if (collisionPaddle() == true && PicBall.Bottom >= Pic_GameArea.Bottom || collisionPaddle() == true && PicBall.Top <= Pic_GameArea.Top)
            {
                y = -y;
            }
            else if (collisionPaddle() == true)
            {
                //change direction if anything else hit (IE: Paddle)
                x = -x;
            }
            //check for a goal
            Goal();
        }
        public bool collisionPaddle()
        {
            //look for PicBall Collision
            //hit blue paddle
            if (PicBall.Right >= Pic_RightPaddle.Left)
            {
                if (PicBall.Top <= Pic_RightPaddle.Bottom && PicBall.Bottom >= Pic_RightPaddle.Top)
                {
                    PicBall.BackColor = Color.Blue;
                    return true;
                }
            } //hit red paddle
            else if (PicBall.Left <= Pic_LeftPaddle.Right)
            {
                if (PicBall.Top <= Pic_LeftPaddle.Bottom && PicBall.Bottom >= Pic_LeftPaddle.Top)
                {
                    PicBall.BackColor = Color.Red;
                    return true;
                }
            }
            else if (PicBall.Top <= Pic_GameArea.Top)
            {
                //stay under game area
                return true;
            }
            else if (PicBall.Bottom >= Pic_GameArea.Bottom)
            {
                //stay in game area
                return true;
            }
            //all paths must return a value; nothing hit
            return false;
        }
        private void RndDir()
        {
            //generate a random direction for ball to travel
            if (rndgen.Next(0, 2) == 1)
            {
                y = 2 * challengemode;
            }
            else
            {
                y = -2 * challengemode;
            }
            if (rndgen.Next(0, 2) == 1)
            {
                x = 2 * challengemode;
            }
            else
            {
                x = -2 * challengemode;
            }
        }

        private void tmrpaddle_Tick(object sender, EventArgs e)
        {
            //Move those paddles
            if (player1[0])
                Pic_LeftPaddle.Top -= speed;

            if (player1[1])
                Pic_LeftPaddle.Top += speed;

            if (player2[0])
                Pic_RightPaddle.Top -= speed;

            if (player2[1])
                Pic_RightPaddle.Top += speed;
            //don't move too far though...
            StayInBox();
        }

        private void Frm_Pongy_KeyUp(object sender, KeyEventArgs e)
        {
            //Stop Moving paddles
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.W)
                player1[0] = false;
            else if (keyCode == Keys.S)
                player1[1] = false;
            else if (keyCode == Keys.Up)
                player2[0] = false;
            else if (keyCode == Keys.Down)
                player2[1] = false;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            players = 1; //Enable Player VS CPU Mode
        }

        private void Menu_Player2_Click(object sender, EventArgs e)
        {
            players = 2; //Enable Player VS Player
        }

        private void Menu_Players0_Click(object sender, EventArgs e)
        {
            players = 0; //Enable CPU VS CPU
        }
        private void RndBallSpawn()
        {
            //give ball a random spawn within boundaries of Pic_Gamearea
            //VVV Only works when using variables....
            int ballTop = rndgen.Next(Pic_GameArea.Top + 25, Pic_GameArea.Bottom - 25);
            int ballLeft = rndgen.Next(Pic_GameArea.Left + 150, Pic_GameArea.Right - 150);
            PicBall.Top = ballTop;
            PicBall.Left = ballLeft;
        }
        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Easy Mode
            challengemode = 1;
            //New Velocity (required, this is what factors in "Challengemode")
            RndDir();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Normal Mode
            challengemode = 2;
            //New Velocity
            RndDir();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hard Mode
            challengemode = 5;
            //New Velocity
            RndDir();
        }

        private void extremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //extreme mode
            challengemode = 15;
            //New Velocity
            RndDir();
        }
        private void Goal()
        {
            //check for goals
            if (PicBall.Left < Pic_GameArea.Left || PicBall.Right > Pic_GameArea.Right)
            {
                Tmr_Game.Stop();
                if (PicBall.Left < Pic_GameArea.Left && countscore == true)
                {
                    playerRightScore = playerRightScore + 1;
                    Lbl_RightPlayer.Text = playerRightScore.ToString();
                    GameSpawning = false;
                    if (playerRightScore > scorelimit)
                    {
                        MessageBox.Show(" Right Player Won ");
                        RndDir();
                        RndBallSpawn();
                        Tmr_Game.Stop();
                        Tmr_Paddle.Stop();
                        Btn_Restart.Visible = true;
                        Btn_Quitter.Visible = true;
                    }
                    else
                    {
                        PicBall.BackColor = Color.Black;
                        PicBall.Left = 424;
                        PicBall.Top = 154;
                        Tmr_Game.Stop();
                    }
                }
                else if (PicBall.Right > Pic_GameArea.Right && countscore == true)
                {
                    playerLeftScore = playerLeftScore + 1;
                    Lbl_LeftPlayer.Text = playerLeftScore.ToString();
                    GameSpawning = false;
                    if (playerLeftScore > scorelimit)
                    {
                        MessageBox.Show(" Left Player Won ");
                        RndDir();
                        RndBallSpawn();
                        Tmr_Game.Stop();
                        Tmr_Paddle.Stop();
                        Btn_Restart.Visible = true;
                        Btn_Quitter.Visible = true;
                    }
                    else
                    {
                        PicBall.BackColor = Color.Black;
                        PicBall.Left = 424;
                        PicBall.Top = 154;
                        Tmr_Game.Stop();
                    }
                }
            }
        }
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            //restart for those who like pong
            Application.Restart();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            //a quit Button for all the haters
            //Determine Winner
            if (playerLeftScore > playerRightScore)
                MessageBox.Show(" Player Left Won! ");
            else if (playerRightScore > playerLeftScore)
                MessageBox.Show(" Player Right Won! ");
            else if (playerLeftScore == playerRightScore)
                MessageBox.Show(" You Two Somehow Tied... ");
            //Exit
            Application.Exit();
        }
        private void StayInBox()
        {
            if (Pic_LeftPaddle.Top > Pic_GameArea.Bottom)
            {
                Pic_LeftPaddle.Top = Pic_GameArea.Bottom - 20;
            }
            if (Pic_RightPaddle.Top > Pic_GameArea.Bottom)
            {
                Pic_RightPaddle.Top = Pic_GameArea.Bottom - 20;
            }
            if (Pic_RightPaddle.Top < Pic_GameArea.Top)
            {
                Pic_RightPaddle.Top = Pic_GameArea.Top + 20;
            }
            if (Pic_LeftPaddle.Top < Pic_GameArea.Top)
            {
                Pic_LeftPaddle.Top = Pic_GameArea.Top + 20;
            }
        }

        private void emergencyResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Emergency Timer Reset
            Tmr_Paddle.Start();
            Tmr_Game.Start();
        }
        private void Frm_Pongy_Load(object sender, EventArgs e)
        {
        }
    }

}
