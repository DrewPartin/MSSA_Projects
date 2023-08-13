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
    public partial class MenuForm : Form
    {
        SoundPlayer musicPlayer = new SoundPlayer(@"D:\GitRepos\MSSA_Projects\MSSA_Projects\Star Wars Game\Resources\starwars.wav");
        SoundPlayer soundPlayer;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            musicPlayer.Play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop();
            soundPlayer = new SoundPlayer(@"D:\GitRepos\MSSA_Projects\MSSA_Projects\Star Wars Game\Resources\light-saber-on.wav");
            soundPlayer.Play();
            GameForm gf = new GameForm();
            this.Visible = false;
            gf.Show();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"D:\GitRepos\MSSA_Projects\MSSA_Projects\Star Wars Game\Resources\light-saber-on.wav");
            soundPlayer.Play();
            ScoresForm sf = new ScoresForm();
            this.Visible = false;           
            sf.Show();
        }

        private void btnExitMF_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"D:\GitRepos\MSSA_Projects\MSSA_Projects\Star Wars Game\Resources\light-saber-off.wav");
            soundPlayer.Play();
            exitTimer.Start();
            exitTimer.Interval = 1000;          
        }

        private void exitTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
