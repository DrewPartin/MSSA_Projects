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
    public partial class ScoresForm : Form
    {
        SoundPlayer musicPlayer = new SoundPlayer(@"D:\MSSA\MSSA_Projects_GitRepo\MSSA_Projects\Star Wars Game\Resources\rebel-theme.wav");
        SoundPlayer soundPlayer;

        public ScoresForm()
        {
            InitializeComponent();
        }

        public void ScoresForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            musicTimer.Start();
            musicTimer.Interval = 500;
        }

        private void musicTimer_Tick(object sender, EventArgs e)
        {
            musicTimer.Stop();           
            musicPlayer.Play();
        }

        public void SetGridHeight(DataGridView grd, int maxHeight)
        {
            var height = 2;
            maxHeight = 244;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Visible)
                {
                    height += row.Height;
                }
            }
            if (height > maxHeight)
            {
                height = maxHeight;
            }
            grd.Height = height;
        }

        public void RefreshData()
        {
            scoresGrid.DataSource = null;
            scoresGrid.DataSource = HighScoreRepository.GetScores().ToList();
            scoresGrid.BackgroundColor = Color.Black;
            scoresGrid.ReadOnly = true;
            scoresGrid.RowHeadersVisible = false;
            scoresGrid.ColumnHeadersVisible = false;
            SetGridHeight(scoresGrid, scoresGrid.Height);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"D:\MSSA\MSSA_Projects_GitRepo\MSSA_Projects\Star Wars Game\Resources\light-saber-on.wav");
            soundPlayer.Play();  
            backTimer.Start();
            backTimer.Interval = 550;
        }

        private void backTimer_Tick(object sender, EventArgs e)
        {
            //musicPlayer.Stop();
            backTimer.Stop();
            MenuForm mf = new MenuForm();
            this.Visible = false;
            mf.Show();
        }

        private void btnExitHS_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"D:\MSSA\MSSA_Projects_GitRepo\MSSA_Projects\Star Wars Game\Resources\light-saber-off.wav");
            soundPlayer.Play();
            exitTimer.Start();
            exitTimer.Interval = 1000;
        }

        private void exitTimer_Tick(object sender, EventArgs e)
        {
            exitTimer.Stop();
            Application.Exit();
        }
    }
}
