namespace Pong
{
    partial class Frm_Pongy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pongy));
            this.Pic_LeftPaddle = new System.Windows.Forms.PictureBox();
            this.Pic_RightPaddle = new System.Windows.Forms.PictureBox();
            this.Delete_Me = new System.Windows.Forms.PictureBox();
            this.Tmr_Game = new System.Windows.Forms.Timer(this.components);
            this.Pic_GameArea = new System.Windows.Forms.PictureBox();
            this.Tmr_Paddle = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.Menu_MainList = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Players = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Player0 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Player1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Player2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Challenge = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ChallengemodeEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ChallengemodeNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ChallengemodeHard = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ChallengemodeExtreme = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_EmergencyTimerReset = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_LeftPlayer = new System.Windows.Forms.Label();
            this.Lbl_RightPlayer = new System.Windows.Forms.Label();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Btn_Restart = new System.Windows.Forms.Button();
            this.PicBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LeftPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_RightPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Me)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GameArea)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_LeftPaddle
            // 
            this.Pic_LeftPaddle.BackColor = System.Drawing.Color.Red;
            this.Pic_LeftPaddle.Location = new System.Drawing.Point(13, 150);
            this.Pic_LeftPaddle.Name = "Pic_LeftPaddle";
            this.Pic_LeftPaddle.Size = new System.Drawing.Size(23, 50);
            this.Pic_LeftPaddle.TabIndex = 0;
            this.Pic_LeftPaddle.TabStop = false;
            // 
            // Pic_RightPaddle
            // 
            this.Pic_RightPaddle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pic_RightPaddle.Location = new System.Drawing.Point(799, 150);
            this.Pic_RightPaddle.Name = "Pic_RightPaddle";
            this.Pic_RightPaddle.Size = new System.Drawing.Size(23, 50);
            this.Pic_RightPaddle.TabIndex = 1;
            this.Pic_RightPaddle.TabStop = false;
            // 
            // Delete_Me
            // 
            this.Delete_Me.BackColor = System.Drawing.Color.Lime;
            this.Delete_Me.Location = new System.Drawing.Point(0, 0);
            this.Delete_Me.Name = "Delete_Me";
            this.Delete_Me.Size = new System.Drawing.Size(20, 20);
            this.Delete_Me.TabIndex = 2;
            this.Delete_Me.TabStop = false;
            // 
            // Tmr_Game
            // 
            this.Tmr_Game.Interval = 1;
            this.Tmr_Game.Tick += new System.EventHandler(this.Tmr_game_Tick);
            // 
            // Pic_GameArea
            // 
            this.Pic_GameArea.Location = new System.Drawing.Point(12, 53);
            this.Pic_GameArea.Name = "Pic_GameArea";
            this.Pic_GameArea.Size = new System.Drawing.Size(810, 266);
            this.Pic_GameArea.TabIndex = 3;
            this.Pic_GameArea.TabStop = false;
            // 
            // Tmr_Paddle
            // 
            this.Tmr_Paddle.Enabled = true;
            this.Tmr_Paddle.Interval = 1;
            this.Tmr_Paddle.Tick += new System.EventHandler(this.tmrpaddle_Tick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_MainList});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(834, 25);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "toolStrip1";
            // 
            // Menu_MainList
            // 
            this.Menu_MainList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_MainList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Players,
            this.Menu_Challenge,
            this.Menu_EmergencyTimerReset});
            this.Menu_MainList.Image = ((System.Drawing.Image)(resources.GetObject("Menu_MainList.Image")));
            this.Menu_MainList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_MainList.Name = "Menu_MainList";
            this.Menu_MainList.Size = new System.Drawing.Size(29, 22);
            this.Menu_MainList.Text = "toolStripDropDownButton1";
            // 
            // Menu_Players
            // 
            this.Menu_Players.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Player0,
            this.Menu_Player1,
            this.Menu_Player2});
            this.Menu_Players.Name = "Menu_Players";
            this.Menu_Players.Size = new System.Drawing.Size(164, 22);
            this.Menu_Players.Text = "Players";
            // 
            // Menu_Player0
            // 
            this.Menu_Player0.Name = "Menu_Player0";
            this.Menu_Player0.Size = new System.Drawing.Size(80, 22);
            this.Menu_Player0.Text = "0";
            this.Menu_Player0.Click += new System.EventHandler(this.Menu_Players0_Click);
            // 
            // Menu_Player1
            // 
            this.Menu_Player1.Name = "Menu_Player1";
            this.Menu_Player1.Size = new System.Drawing.Size(80, 22);
            this.Menu_Player1.Text = "1";
            this.Menu_Player1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Menu_Player2
            // 
            this.Menu_Player2.Name = "Menu_Player2";
            this.Menu_Player2.Size = new System.Drawing.Size(80, 22);
            this.Menu_Player2.Text = "2";
            this.Menu_Player2.Click += new System.EventHandler(this.Menu_Player2_Click);
            // 
            // Menu_Challenge
            // 
            this.Menu_Challenge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ChallengemodeEasy,
            this.Menu_ChallengemodeNormal,
            this.Menu_ChallengemodeHard,
            this.Menu_ChallengemodeExtreme});
            this.Menu_Challenge.Name = "Menu_Challenge";
            this.Menu_Challenge.Size = new System.Drawing.Size(164, 22);
            this.Menu_Challenge.Text = "Challenge";
            // 
            // Menu_ChallengemodeEasy
            // 
            this.Menu_ChallengemodeEasy.Name = "Menu_ChallengemodeEasy";
            this.Menu_ChallengemodeEasy.Size = new System.Drawing.Size(116, 22);
            this.Menu_ChallengemodeEasy.Text = "Easy";
            this.Menu_ChallengemodeEasy.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // Menu_ChallengemodeNormal
            // 
            this.Menu_ChallengemodeNormal.Name = "Menu_ChallengemodeNormal";
            this.Menu_ChallengemodeNormal.Size = new System.Drawing.Size(116, 22);
            this.Menu_ChallengemodeNormal.Text = "Normal";
            this.Menu_ChallengemodeNormal.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // Menu_ChallengemodeHard
            // 
            this.Menu_ChallengemodeHard.Name = "Menu_ChallengemodeHard";
            this.Menu_ChallengemodeHard.Size = new System.Drawing.Size(116, 22);
            this.Menu_ChallengemodeHard.Text = "Hard";
            this.Menu_ChallengemodeHard.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // Menu_ChallengemodeExtreme
            // 
            this.Menu_ChallengemodeExtreme.Name = "Menu_ChallengemodeExtreme";
            this.Menu_ChallengemodeExtreme.Size = new System.Drawing.Size(116, 22);
            this.Menu_ChallengemodeExtreme.Text = "Extreme";
            this.Menu_ChallengemodeExtreme.Click += new System.EventHandler(this.extremeToolStripMenuItem_Click);
            // 
            // Menu_EmergencyTimerReset
            // 
            this.Menu_EmergencyTimerReset.Name = "Menu_EmergencyTimerReset";
            this.Menu_EmergencyTimerReset.Size = new System.Drawing.Size(164, 22);
            this.Menu_EmergencyTimerReset.Text = "Emergency Reset";
            this.Menu_EmergencyTimerReset.Click += new System.EventHandler(this.emergencyResetToolStripMenuItem_Click);
            // 
            // Lbl_LeftPlayer
            // 
            this.Lbl_LeftPlayer.AutoSize = true;
            this.Lbl_LeftPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LeftPlayer.Location = new System.Drawing.Point(12, 25);
            this.Lbl_LeftPlayer.Name = "Lbl_LeftPlayer";
            this.Lbl_LeftPlayer.Size = new System.Drawing.Size(24, 25);
            this.Lbl_LeftPlayer.TabIndex = 5;
            this.Lbl_LeftPlayer.Text = "0";
            // 
            // Lbl_RightPlayer
            // 
            this.Lbl_RightPlayer.AutoSize = true;
            this.Lbl_RightPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RightPlayer.Location = new System.Drawing.Point(798, 25);
            this.Lbl_RightPlayer.Name = "Lbl_RightPlayer";
            this.Lbl_RightPlayer.Size = new System.Drawing.Size(24, 25);
            this.Lbl_RightPlayer.TabIndex = 6;
            this.Lbl_RightPlayer.Text = "0";
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Location = new System.Drawing.Point(373, 176);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(124, 47);
            this.Btn_Quitter.TabIndex = 7;
            this.Btn_Quitter.Text = "Quit";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Visible = false;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Btn_Restart
            // 
            this.Btn_Restart.Location = new System.Drawing.Point(373, 94);
            this.Btn_Restart.Name = "Btn_Restart";
            this.Btn_Restart.Size = new System.Drawing.Size(124, 50);
            this.Btn_Restart.TabIndex = 8;
            this.Btn_Restart.Text = "Restart";
            this.Btn_Restart.UseVisualStyleBackColor = true;
            this.Btn_Restart.Visible = false;
            this.Btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // PicBall
            // 
            this.PicBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PicBall.Location = new System.Drawing.Point(425, 150);
            this.PicBall.Name = "PicBall";
            this.PicBall.Size = new System.Drawing.Size(20, 20);
            this.PicBall.TabIndex = 9;
            this.PicBall.TabStop = false;
            // 
            // Frm_Pongy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 331);
            this.Controls.Add(this.PicBall);
            this.Controls.Add(this.Btn_Restart);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Lbl_RightPlayer);
            this.Controls.Add(this.Lbl_LeftPlayer);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Pic_RightPaddle);
            this.Controls.Add(this.Pic_LeftPaddle);
            this.Controls.Add(this.Pic_GameArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frm_Pongy";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Frm_Pongy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Pongy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Pongy_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LeftPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_RightPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Me)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GameArea)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_LeftPaddle;
        private System.Windows.Forms.PictureBox Pic_RightPaddle;
        private System.Windows.Forms.PictureBox Delete_Me;
        private System.Windows.Forms.Timer Tmr_Game;
        private System.Windows.Forms.PictureBox Pic_GameArea;
        private System.Windows.Forms.Timer Tmr_Paddle;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripDropDownButton Menu_MainList;
        private System.Windows.Forms.ToolStripMenuItem Menu_Players;
        private System.Windows.Forms.ToolStripMenuItem Menu_Player1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Player2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Player0;
        private System.Windows.Forms.Label Lbl_LeftPlayer;
        private System.Windows.Forms.Label Lbl_RightPlayer;
        private System.Windows.Forms.ToolStripMenuItem Menu_Challenge;
        private System.Windows.Forms.ToolStripMenuItem Menu_ChallengemodeEasy;
        private System.Windows.Forms.ToolStripMenuItem Menu_ChallengemodeNormal;
        private System.Windows.Forms.ToolStripMenuItem Menu_ChallengemodeHard;
        private System.Windows.Forms.ToolStripMenuItem Menu_ChallengemodeExtreme;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.Button Btn_Restart;
        private System.Windows.Forms.ToolStripMenuItem Menu_EmergencyTimerReset;
        private System.Windows.Forms.PictureBox PicBall;
    }
}

