using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Star_Wars_Game
{   
    public partial class GameForm : Form
    {
        bool goUp, goDown, goLeft, goRight, shooting1, shooting2, shooting3, isGameOver;
        int score, greenLaserSpeed, playerSpeed, ammo;
        Random rnd = new Random();
        SoundPlayer laser = new SoundPlayer(@"D:\MSSA\PCAD5\Project1\Star Wars Game\Resources\blaster-firing.wav");
        SoundPlayer explosion = new SoundPlayer(@"D:\MSSA\PCAD5\Project1\Star Wars Game\Resources\damage.wav");
        SoundPlayer scream = new SoundPlayer(@"D:\MSSA\PCAD5\Project1\Star Wars Game\Resources\WilhelmScream.wav");
        SoundPlayer cantina = new SoundPlayer(@"D:\MSSA\PCAD5\Project1\Star Wars Game\Resources\star-wars-cantina-song.wav");
        SoundPlayer jabba = new SoundPlayer(@"D:\MSSA\PCAD5\Project1\Star Wars Game\Resources\jabba-the-hutt-laughing.wav");

        private void AmmoCheck()
        {
            if (shooting1 == false && shooting2 == false && shooting3 == false)
            {
                ammo = 3;
            }
            if (ammo < 0) { ammo = 0; }
            else if (ammo > 3) { ammo = 3; }
        }

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            var hiscore = HighScoreRepository.GetScores().Max(x=>x.Score);
            txtHiScore.Text = hiscore.ToString();                     
            fireworks.Visible = false;
            hiScorePanel.Enabled = false;
            hiScorePanel.Visible = false;
            btnMenu.Enabled = false;
            btnMenu.Visible = false;
            btnRetry.Enabled = false;
            btnRetry.Visible = false;
            btnExitGF.Enabled = false;
            btnExitGF.Visible = false;
            lblGameOver.Visible = false;
            GameTimer.Start();
            shieldBar.Value = 100;
            score = 0;
            ammo = 3;
            playerSpeed = 15;           
            greenLaserSpeed = 20;
            shooting1 = false;
            shooting2 = false;
            shooting3 = false;
            player.Visible = true;
            player.Location = new Point(12, 281);
            picDeathStar.Top = 155;
            picDeathStar.Visible = true;
            picDeathStar.Left = 1200;
            picStarDestroyer.Top = rnd.Next(250, 450);
            picStarDestroyer.Visible = true;
            picStarDestroyer.Left = 1200;
            explosion1.Top = 800;
            explosion1.Left = -800;
            greenLaser1.Location = new Point(-1000, -1000);
            greenLaser2.Location = new Point(-1000, -1000);
            greenLaser3.Location = new Point(-1000, -1000);
            explosion1.Location = new Point(-1000, -1000);
            explosion2.Location = new Point(-1000, -1000);
            explosion3.Location = new Point(-1000, -1000);
            explosion4.Location = new Point(-1000, -1000);
            redLaser1.Location = new Point(-600, -1000);
            redLaser2.Location = new Point(-600, -1000);
            redLaser3.Location = new Point(-600, -1000);
            redLaser4.Location = new Point(-600, -1000);
            redLaser5.Location = new Point(-600, -1000);
            redLaser6.Location = new Point(-600, -1000);
            enemy1.Top = rnd.Next(60, 490);
            enemy1.Left = rnd.Next(960, 1500);
            enemy1.Visible = true;
            enemy2.Top = rnd.Next(60, 490);
            enemy2.Left = rnd.Next(960, 1500);
            enemy2.Visible = true;
            enemy3.Top = rnd.Next(60, 490);
            enemy3.Left = rnd.Next(960, 1500);
            enemy3.Visible = true;
            redLaser1.Top = enemy1.Top + 25;
            redLaser1.Left = enemy1.Left;
            redLaser2.Top = enemy2.Top + 25;
            redLaser2.Left = enemy2.Left;
            redLaser3.Top = enemy3.Top + 25;
            redLaser3.Left = enemy3.Left;
        }

        #region Explosion Animations
        private void explosionTimer1Event()
        {
            explosionTimer1.Interval = 750;
            explosionTimer1.Start();                       
            explosion1.Location = new Point(enemy1.Left, enemy1.Top);
            enemy1.Top = rnd.Next(60, 490);
            enemy1.Left = rnd.Next(960, 1500);
            if (redLaser1.Left < -60)
            {
                redLaser1.Top = enemy1.Top + 25;
                redLaser1.Left = enemy1.Left;
            }
            else if (redLaser4.Left < -60)
            {
                redLaser4.Top = enemy1.Top + 25;
                redLaser4.Left = enemy1.Left;
            }
            explosionTimer1.Tick += explosionTimer1_Tick;
        }

        private void explosionTimer1_Tick(object sender, EventArgs e)
        {            
            explosion1.Location = new Point(-1000, -1000);
            explosionTimer1.Stop();
        }

        private void explosionTimer2Event()
        {
            explosionTimer2.Interval = 750;
            explosionTimer2.Start();           
            explosion2.Location = new Point(enemy2.Left, enemy2.Top);
            enemy2.Top = rnd.Next(60, 490);
            enemy2.Left = rnd.Next(960, 1500);
            if (redLaser2.Left < -60)
            {
                redLaser2.Top = enemy2.Top + 25;
                redLaser2.Left = enemy2.Left;
            }
            else if (redLaser5.Left < -60)
            {
                redLaser5.Top = enemy2.Top + 25;
                redLaser5.Left = enemy2.Left;
            }
            explosionTimer2.Tick += explosionTimer2_Tick;
        }

        private void explosionTimer2_Tick(object sender, EventArgs e)
        {            
            explosion2.Location = new Point(-1000, -1000);
            explosionTimer2.Stop();
        }

        private void explosionTimer3Event()
        {
            explosionTimer3.Interval = 750;
            explosionTimer3.Start();           
            explosion3.Location = new Point(enemy3.Left, enemy3.Top);
            enemy3.Top = rnd.Next(60, 490);
            enemy3.Left = rnd.Next(960, 1500);
            if (redLaser3.Left < -60)
            {
                redLaser3.Top = enemy3.Top + 25;
                redLaser3.Left = enemy3.Left;
            }
            else if (redLaser6.Left < -60)
            {
                redLaser6.Top = enemy3.Top + 25;
                redLaser6.Left = enemy3.Left;
            }
            explosionTimer3.Tick += explosionTime3_Tick;
        }

        private void explosionTime3_Tick(object sender, EventArgs e)
        {           
            explosion3.Location = new Point(-1000, -1000);
            explosionTimer3.Stop();
        }

        private void explosionTimer4Event()
        {            
            player.Visible = false;
            explosionTimer4.Interval = 5000;
            explosionTimer4.Start();           
            explosion4.Location = new Point(player.Left, player.Top);
            explosionTimer4.Tick += explosionTimer4_Tick;
        }

        private void explosionTimer4_Tick(object sender, EventArgs e)
        {            
            explosion4.Location = new Point(-1000, -1000);
            explosionTimer4.Stop();
        }
        #endregion

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            isGameOver = false;
            if (isGameOver == false)
            {
                txtScore.Text = score.ToString();
                enemy1.Left -= 10;
                enemy2.Left -= 10;
                enemy3.Left -= 10;
                redLaser1.Left -= 20;
                redLaser2.Left -= 20;
                redLaser3.Left -= 20;
                picDeathStar.Left -= 2;
                if (picDeathStar.Left < -1200) { picDeathStar.Left = 1200; }               
                picStarDestroyer.Left -= 3;
                if (picStarDestroyer.Left < -1200) { picStarDestroyer.Left = 1200; }

                #region Speed Increase Intervals
                if (score >= 3500 && score < 6500)
                {
                    enemy1.Left -= 3;
                    enemy2.Left -= 3;
                    enemy3.Left -= 3;
                    redLaser1.Left -= 3;
                    redLaser2.Left -= 3;
                    redLaser3.Left -= 3;
                }
                if (score >= 6500 && score < 10000)
                {
                    enemy1.Left -= 3;
                    enemy2.Left -= 3;
                    enemy3.Left -= 3;
                    redLaser1.Left -= 3;
                    redLaser2.Left -= 3;
                    redLaser3.Left -= 3;
                }
                if (score > 10000)
                {
                    enemy1.Left -= 3;
                    enemy2.Left -= 3;
                    enemy3.Left -= 3;
                    redLaser1.Left -= 3;
                    redLaser2.Left -= 3;
                    redLaser3.Left -= 3;
                } 
                #endregion

                #region Ammo Logic
                if (shooting1 == true)
                {
                    greenLaser1.Left += greenLaserSpeed;
                }
                if (shooting2 == true)
                {
                    greenLaser2.Left += greenLaserSpeed;
                }
                if (shooting3 == true)
                {
                    greenLaser3.Left += greenLaserSpeed;
                }

                if (ammo == 3) { txtAmmo.ForeColor = Color.LimeGreen; }
                if (ammo == 2) { txtAmmo.ForeColor = Color.Yellow; }
                if (ammo == 1) { txtAmmo.ForeColor = Color.DarkOrange; }
                if (ammo == 0) { txtAmmo.ForeColor = Color.Red; }
                txtAmmo.Text = ammo.ToString();

                if (greenLaser1.Left > 960) { ammo++; shooting1 = false; greenLaser1.Location = new Point(-1000, 1000); AmmoCheck(); }
                if (greenLaser2.Left > 960) { ammo++; shooting2 = false; greenLaser2.Location = new Point(-1000, 1000); AmmoCheck(); }
                if (greenLaser3.Left > 960) { ammo++; shooting3 = false; greenLaser3.Location = new Point(-1000, 1000); AmmoCheck(); }

                if (redLaser1.Left < -60) { redLaser1.Location = new Point(-600, 1000); }
                if (redLaser2.Left < -60) { redLaser2.Location = new Point(-600, 1000); }
                if (redLaser3.Left < -60) { redLaser3.Location = new Point(-600, 1000); }
                if (redLaser4.Left < -60) { redLaser4.Location = new Point(-600, 1000); }
                if (redLaser5.Left < -60) { redLaser5.Location = new Point(-600, 1000); }
                if (redLaser6.Left < -60) { redLaser6.Location = new Point(-600, 1000); }
                #endregion

                #region Player Movement Logic
                if (goUp == true && player.Top >= 52) { player.Top -= playerSpeed; }
                if (goDown == true && player.Bottom <= 575) { player.Top += playerSpeed; }
                if (goLeft == true && player.Left >= 20) { player.Left -= playerSpeed; }
                if (goRight == true && player.Left <= 835) { player.Left += playerSpeed; }
                #endregion

                #region Enemy Escape Logic
                if (enemy1.Left < -60)
                {
                    if (score >= 25)
                    {
                        score -= 25;
                    }
                    enemy1.Top = rnd.Next(60, 490);
                    enemy1.Left = rnd.Next(960, 1500);
                    if (redLaser1.Left < -60)
                    {
                        redLaser1.Top = enemy1.Top + 25;
                        redLaser1.Left = enemy1.Left;
                    }
                    else if (redLaser4.Left < -60)
                    {
                        redLaser4.Top = enemy1.Top + 25;
                        redLaser4.Left = enemy1.Left;
                    }
                }
                if (enemy2.Left < -100)
                {
                    if (score >= 25)
                    {
                        score -= 25;
                    }
                    enemy2.Top = rnd.Next(60, 490);
                    enemy2.Left = rnd.Next(960, 1500);
                    if (redLaser2.Left < -60)
                    {
                        redLaser2.Top = enemy2.Top + 25;
                        redLaser2.Left = enemy2.Left;
                    }
                    else if (redLaser5.Left < -60)
                    {
                        redLaser5.Top = enemy2.Top + 25;
                        redLaser5.Left = enemy2.Left;
                    }
                }
                if (enemy3.Left < -140)
                {
                    if (score >= 25)
                    {
                        score -= 25;
                    }
                    enemy3.Top = rnd.Next(60, 490);
                    enemy3.Left = rnd.Next(960, 1500);
                    if (redLaser3.Left < -60)
                    {
                        redLaser3.Top = enemy3.Top + 25;
                        redLaser3.Left = enemy3.Left;
                    }
                    else if (redLaser6.Left < -60)
                    {
                        redLaser6.Top = enemy3.Top + 25;
                        redLaser6.Left = enemy3.Left;
                    }
                }
                #endregion

                #region Shoot Enemy Events
                if (greenLaser1.Bounds.IntersectsWith(enemy1.Bounds))
                {  
                    this.explosion.Play();
                    score += 100;
                    explosionTimer1Event();                  
                    ammo++;
                    shooting1 = false;
                    greenLaser1.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser2.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer1Event();                   
                    ammo++;
                    shooting2 = false;
                    greenLaser2.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser3.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer1Event();                   
                    ammo++;
                    shooting3 = false;
                    greenLaser3.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser1.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer2Event();                    
                    ammo++;
                    shooting1 = false;
                    greenLaser1.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser2.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer2Event();                    
                    ammo++;
                    shooting2 = false;
                    greenLaser2.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser3.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer2Event();                    
                    ammo++;
                    shooting3 = false;
                    greenLaser3.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser1.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer3Event();                    
                    ammo++;
                    shooting1 = false;
                    greenLaser1.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser2.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer3Event();                    
                    ammo++;
                    shooting2 = false;
                    greenLaser2.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                if (greenLaser3.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    this.explosion.Play();
                    score += 100;
                    explosionTimer3Event();                    
                    ammo++;
                    shooting3 = false;
                    greenLaser3.Location = new Point(-1000, 1000);
                    AmmoCheck();
                }
                #endregion

                #region Shoot Player Events
                if (redLaser1.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        redLaser1.Location = new Point(-600, -1000);
                    }
                    else { GameOver(); }

                }
                if (redLaser2.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        redLaser2.Location = new Point(-600, -1000);
                    }
                    else { GameOver(); }
                }
                if (redLaser3.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        redLaser3.Location = new Point(-600, -1000);
                    }
                    else { GameOver(); }
                }
                if (redLaser4.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        redLaser4.Location = new Point(-600, -1000);
                    }
                    else { GameOver(); }
                }
                if (redLaser5.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        redLaser5.Location = new Point(-600, -1000);
                    }
                    else { GameOver(); }
                }
                if (redLaser6.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        redLaser6.Location = new Point(-600, -1000);
                    }
                    else { GameOver(); }
                }
                #endregion

                #region Collision Events
                if (enemy1.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        explosionTimer1Event();
                    }
                    else { GameOver(); }

                }
                if (enemy2.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        explosionTimer2Event();
                    }
                    else { GameOver(); }
                }
                if (enemy3.Bounds.IntersectsWith(player.Bounds))
                {
                    if (shieldBar.Value > 0)
                    {
                        shieldBar.Value -= 25;
                        if (score >= 25)
                        {
                            score -= 25;
                        }
                        explosionTimer3Event();
                    }
                    else { GameOver(); }
                }

                #endregion
            }
        }
            
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (isGameOver == false)
            {
                if (e.KeyCode == Keys.W) { goUp = true; }
                if (e.KeyCode == Keys.S) { goDown = true; }
                if (e.KeyCode == Keys.A) { goLeft = true; }
                if (e.KeyCode == Keys.D) { goRight = true; }
                if (e.KeyCode == Keys.Space && shooting1 == false)
                {
                    this.laser.Play();
                    shooting1 = true;
                    greenLaser1.Top = player.Top + (player.Height / 3);
                    greenLaser1.Left = player.Left + 100;
                }
                else if (e.KeyCode == Keys.Space && shooting2 == false)
                {
                    this.laser.Play();
                    shooting2 = true;
                    greenLaser2.Top = player.Top + (player.Height / 3);
                    greenLaser2.Left = player.Left + 100;
                }
                else if (e.KeyCode == Keys.Space && shooting3 == false)
                {
                    this.laser.Play();
                    shooting3 = true;
                    greenLaser3.Top = player.Top + (player.Height / 3);
                    greenLaser3.Left = player.Left + 100;
                }
                else if (e.KeyCode == Keys.Space && ammo == 0)
                {
                    ammo = 0;
                }
            }
        }

        private void keyRelease(object sender, KeyEventArgs e)
        {
            if (isGameOver == false)
            {
                if (e.KeyCode == Keys.W) { goUp = false; }
                if (e.KeyCode == Keys.S) { goDown = false; }
                if (e.KeyCode == Keys.A) { goLeft = false; }
                if (e.KeyCode == Keys.D) { goRight = false; }
                if (e.KeyCode == Keys.Space && ammo > 0) { ammo--; }
                if (e.KeyCode == Keys.Space && ammo == 0) { ammo = 0; }
            }
        }

        private void gameOverTimerEvent()
        {
            explosionTimer4Event();
            isGameOver = true;
            GameTimer.Stop();
            scream.Play();
            lblGameOver.Text = "Game Over!";
            lblGameOver.Location = new Point(273, 52);
            lblGameOver.Visible = true;
            explosion1.Visible = false;
            explosion2.Visible = false;
            explosion3.Visible = false;
            enemy1.Visible = false;
            enemy2.Visible = false;
            enemy3.Visible = false;
            greenLaser1.Visible = false;
            greenLaser2.Visible = false;
            greenLaser3.Visible = false;
            redLaser1.Visible = false;
            redLaser2.Visible = false;
            redLaser3.Visible = false;
            redLaser4.Visible = false;
            redLaser5.Visible = false;
            redLaser6.Visible = false;
            gameOverTimer.Start();
            gameOverTimer.Interval = 800;
        }

        private void gameOverTimer_Tick(object sender, EventArgs e)
        {
            gameOverTimer.Stop();
            var score = HighScoreRepository.GetScores().Min(y => y.Score);
            if (Int32.Parse(txtScore.Text) > Int32.Parse(txtHiScore.Text))
            {
                cantina.Play();
                picDeathStar.Visible = false;
                picStarDestroyer.Visible = false;
                lblCongrats.Text = "CONGRATS! You have the new High Score!";
                hiScorePanel.Enabled = true;
                hiScorePanel.Visible = true;
                fireworks.Visible = true;
            }
            else if (Int32.Parse(txtScore.Text) > score || HighScoreRepository.GetScores().Count() < 10)
            {
                cantina.Play();
                picDeathStar.Visible = false;
                picStarDestroyer.Visible = false;
                lblCongrats.Text = "Congrats! You made it onto the leaderboard!";
                hiScorePanel.Enabled = true;
                hiScorePanel.Visible = true;
                fireworks.Visible = true;
            }
            else
            {
                jabba.Play();
                hiScorePanel.Enabled = false;
                hiScorePanel.Visible = false;
                enemy1.Visible = false;
                enemy2.Visible = false;
                enemy3.Visible = false;
                fireworks.Visible = false;
                btnMenu.Visible = true;
                btnMenu.Enabled = true;
                btnRetry.Visible = true;
                btnRetry.Enabled = true;
                btnExitGF.Visible = true;
                btnExitGF.Enabled = true;
            }
        }

        public void GameOver()
        {
            gameOverTimerEvent();                              
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != String.Empty)
            {
                var newscore = new ScoresSW();
                newscore.Player_Name = txtName.Text;
                newscore.Score = Int32.Parse(txtScore.Text);
                HighScoreRepository.AddScore(newscore);
                if (HighScoreRepository.GetScores().Count > 10)
                {
                    var lowscore = HighScoreRepository.GetScores().Min(z => z.Score);
                    var scoretodel = HighScoreRepository.FindScore(lowscore);
                    HighScoreRepository.DeleteScore(scoretodel);
                }
                txtName.Text = null;
                fireworks.Visible = false;
                hiScorePanel.Enabled = false;
                hiScorePanel.Visible = false;
                this.Visible = false;
                ScoresForm sf = new ScoresForm();
                sf.Show();
            }
            else
            {
                MessageBox.Show("Player name cannot be blank");
                return;
            }            
        }
        
        private void btnRetry_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm();
            this.Visible = false;
            gf.Show();
            ResetGame();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            this.Visible = false;
            mf.Show();
        }

        private void btnExitGF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
