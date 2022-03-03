namespace Star_Wars_Game
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblShield = new System.Windows.Forms.Label();
            this.shieldBar = new System.Windows.Forms.ProgressBar();
            this.lblHiScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtHiScore = new System.Windows.Forms.TextBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.TextBox();
            this.explosionTimer1 = new System.Windows.Forms.Timer(this.components);
            this.explosionTimer2 = new System.Windows.Forms.Timer(this.components);
            this.explosionTimer3 = new System.Windows.Forms.Timer(this.components);
            this.explosionTimer4 = new System.Windows.Forms.Timer(this.components);
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExitGF = new System.Windows.Forms.Button();
            this.hiScorePanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.fireworks = new System.Windows.Forms.PictureBox();
            this.explosion4 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.explosion3 = new System.Windows.Forms.PictureBox();
            this.explosion2 = new System.Windows.Forms.PictureBox();
            this.redLaser6 = new System.Windows.Forms.PictureBox();
            this.redLaser5 = new System.Windows.Forms.PictureBox();
            this.redLaser4 = new System.Windows.Forms.PictureBox();
            this.explosion1 = new System.Windows.Forms.PictureBox();
            this.greenLaser3 = new System.Windows.Forms.PictureBox();
            this.greenLaser2 = new System.Windows.Forms.PictureBox();
            this.redLaser3 = new System.Windows.Forms.PictureBox();
            this.redLaser2 = new System.Windows.Forms.PictureBox();
            this.redLaser1 = new System.Windows.Forms.PictureBox();
            this.greenLaser1 = new System.Windows.Forms.PictureBox();
            this.picStarDestroyer = new System.Windows.Forms.PictureBox();
            this.picDeathStar = new System.Windows.Forms.PictureBox();
            this.gameOverTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit2 = new System.Windows.Forms.Button();
            this.hiScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireworks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLaser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLaser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLaser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarDestroyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeathStar)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(502, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 23);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            // 
            // lblShield
            // 
            this.lblShield.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShield.AutoSize = true;
            this.lblShield.BackColor = System.Drawing.Color.Transparent;
            this.lblShield.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShield.Location = new System.Drawing.Point(45, 12);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(69, 23);
            this.lblShield.TabIndex = 6;
            this.lblShield.Text = "Shield:";
            // 
            // shieldBar
            // 
            this.shieldBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shieldBar.BackColor = System.Drawing.Color.Black;
            this.shieldBar.ForeColor = System.Drawing.Color.Black;
            this.shieldBar.Location = new System.Drawing.Point(120, 15);
            this.shieldBar.Name = "shieldBar";
            this.shieldBar.Size = new System.Drawing.Size(166, 16);
            this.shieldBar.Step = 100;
            this.shieldBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.shieldBar.TabIndex = 7;
            // 
            // lblHiScore
            // 
            this.lblHiScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHiScore.AutoSize = true;
            this.lblHiScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHiScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiScore.Location = new System.Drawing.Point(720, 12);
            this.lblHiScore.Name = "lblHiScore";
            this.lblHiScore.Size = new System.Drawing.Size(93, 23);
            this.lblHiScore.TabIndex = 9;
            this.lblHiScore.Text = "Hi-Score:";
            // 
            // txtScore
            // 
            this.txtScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtScore.BackColor = System.Drawing.Color.Black;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.CausesValidation = false;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(573, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.ShortcutsEnabled = false;
            this.txtScore.Size = new System.Drawing.Size(135, 25);
            this.txtScore.TabIndex = 15;
            this.txtScore.TabStop = false;
            // 
            // txtHiScore
            // 
            this.txtHiScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHiScore.BackColor = System.Drawing.Color.Black;
            this.txtHiScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHiScore.CausesValidation = false;
            this.txtHiScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHiScore.ForeColor = System.Drawing.Color.Gold;
            this.txtHiScore.Location = new System.Drawing.Point(819, 10);
            this.txtHiScore.Name = "txtHiScore";
            this.txtHiScore.ReadOnly = true;
            this.txtHiScore.ShortcutsEnabled = false;
            this.txtHiScore.Size = new System.Drawing.Size(117, 25);
            this.txtHiScore.TabIndex = 16;
            this.txtHiScore.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Papyrus", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(273, 52);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(400, 100);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "Game Over!";
            // 
            // lblAmmo
            // 
            this.lblAmmo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.Location = new System.Drawing.Point(323, 12);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(74, 23);
            this.lblAmmo.TabIndex = 22;
            this.lblAmmo.Text = "Ammo:";
            // 
            // txtAmmo
            // 
            this.txtAmmo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmmo.BackColor = System.Drawing.Color.Black;
            this.txtAmmo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmmo.CausesValidation = false;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(403, 12);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.ReadOnly = true;
            this.txtAmmo.ShortcutsEnabled = false;
            this.txtAmmo.Size = new System.Drawing.Size(32, 25);
            this.txtAmmo.TabIndex = 23;
            this.txtAmmo.TabStop = false;
            // 
            // explosionTimer1
            // 
            this.explosionTimer1.Tick += new System.EventHandler(this.explosionTimer1_Tick);
            // 
            // btnRetry
            // 
            this.btnRetry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRetry.BackColor = System.Drawing.Color.DarkGray;
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.Enabled = false;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetry.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.Black;
            this.btnRetry.Location = new System.Drawing.Point(315, 149);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(134, 39);
            this.btnRetry.TabIndex = 32;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Enabled = false;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(496, 149);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(134, 39);
            this.btnMenu.TabIndex = 33;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExitGF
            // 
            this.btnExitGF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitGF.BackColor = System.Drawing.Color.DarkGray;
            this.btnExitGF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitGF.Enabled = false;
            this.btnExitGF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitGF.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGF.ForeColor = System.Drawing.Color.Black;
            this.btnExitGF.Location = new System.Drawing.Point(405, 220);
            this.btnExitGF.Name = "btnExitGF";
            this.btnExitGF.Size = new System.Drawing.Size(134, 39);
            this.btnExitGF.TabIndex = 34;
            this.btnExitGF.Text = "Exit";
            this.btnExitGF.UseVisualStyleBackColor = false;
            this.btnExitGF.Visible = false;
            this.btnExitGF.Click += new System.EventHandler(this.btnExitGF_Click);
            // 
            // hiScorePanel
            // 
            this.hiScorePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hiScorePanel.BackColor = System.Drawing.Color.Gold;
            this.hiScorePanel.Controls.Add(this.btnExit2);
            this.hiScorePanel.Controls.Add(this.btnSave);
            this.hiScorePanel.Controls.Add(this.txtName);
            this.hiScorePanel.Controls.Add(this.lblName);
            this.hiScorePanel.Controls.Add(this.lblCongrats);
            this.hiScorePanel.ForeColor = System.Drawing.Color.Black;
            this.hiScorePanel.Location = new System.Drawing.Point(269, 142);
            this.hiScorePanel.Name = "hiScorePanel";
            this.hiScorePanel.Size = new System.Drawing.Size(404, 141);
            this.hiScorePanel.TabIndex = 35;
            this.hiScorePanel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(220, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(152, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 28);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(18, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCongrats
            // 
            this.lblCongrats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lblCongrats.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.Black;
            this.lblCongrats.Location = new System.Drawing.Point(42, 25);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(73, 21);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "Congrats";
            this.lblCongrats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fireworks
            // 
            this.fireworks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireworks.BackColor = System.Drawing.Color.Transparent;
            this.fireworks.Image = global::Star_Wars_Game.Properties.Resources.fireworks_gif;
            this.fireworks.Location = new System.Drawing.Point(-3, 2);
            this.fireworks.Name = "fireworks";
            this.fireworks.Size = new System.Drawing.Size(971, 576);
            this.fireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireworks.TabIndex = 36;
            this.fireworks.TabStop = false;
            this.fireworks.Visible = false;
            // 
            // explosion4
            // 
            this.explosion4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.explosion4.BackColor = System.Drawing.Color.Transparent;
            this.explosion4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.explosion4.ErrorImage = global::Star_Wars_Game.Properties.Resources.explosion_gif;
            this.explosion4.Image = global::Star_Wars_Game.Properties.Resources.explosion_gif;
            this.explosion4.InitialImage = null;
            this.explosion4.Location = new System.Drawing.Point(102, 185);
            this.explosion4.Name = "explosion4";
            this.explosion4.Size = new System.Drawing.Size(96, 74);
            this.explosion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion4.TabIndex = 31;
            this.explosion4.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy3.BackgroundImage")));
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Location = new System.Drawing.Point(868, 194);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(90, 65);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy3.TabIndex = 2;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(868, 123);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(90, 65);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy1.BackgroundImage")));
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Location = new System.Drawing.Point(868, 52);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(90, 65);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1.TabIndex = 2;
            this.enemy1.TabStop = false;
            // 
            // player
            // 
            this.player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(6, 52);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(108, 60);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // explosion3
            // 
            this.explosion3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.explosion3.BackColor = System.Drawing.Color.Transparent;
            this.explosion3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.explosion3.ErrorImage = null;
            this.explosion3.Image = global::Star_Wars_Game.Properties.Resources.explosion_gif;
            this.explosion3.InitialImage = null;
            this.explosion3.Location = new System.Drawing.Point(6, 185);
            this.explosion3.Name = "explosion3";
            this.explosion3.Size = new System.Drawing.Size(96, 74);
            this.explosion3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion3.TabIndex = 30;
            this.explosion3.TabStop = false;
            // 
            // explosion2
            // 
            this.explosion2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.explosion2.BackColor = System.Drawing.Color.Transparent;
            this.explosion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.explosion2.ErrorImage = null;
            this.explosion2.Image = global::Star_Wars_Game.Properties.Resources.explosion_gif;
            this.explosion2.InitialImage = null;
            this.explosion2.Location = new System.Drawing.Point(102, 114);
            this.explosion2.Name = "explosion2";
            this.explosion2.Size = new System.Drawing.Size(96, 74);
            this.explosion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion2.TabIndex = 29;
            this.explosion2.TabStop = false;
            // 
            // redLaser6
            // 
            this.redLaser6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLaser6.BackColor = System.Drawing.Color.Transparent;
            this.redLaser6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redLaser6.BackgroundImage")));
            this.redLaser6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redLaser6.Location = new System.Drawing.Point(810, 132);
            this.redLaser6.Name = "redLaser6";
            this.redLaser6.Size = new System.Drawing.Size(52, 10);
            this.redLaser6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLaser6.TabIndex = 28;
            this.redLaser6.TabStop = false;
            // 
            // redLaser5
            // 
            this.redLaser5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLaser5.BackColor = System.Drawing.Color.Transparent;
            this.redLaser5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redLaser5.BackgroundImage")));
            this.redLaser5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redLaser5.Location = new System.Drawing.Point(810, 116);
            this.redLaser5.Name = "redLaser5";
            this.redLaser5.Size = new System.Drawing.Size(52, 10);
            this.redLaser5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLaser5.TabIndex = 27;
            this.redLaser5.TabStop = false;
            // 
            // redLaser4
            // 
            this.redLaser4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLaser4.BackColor = System.Drawing.Color.Transparent;
            this.redLaser4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redLaser4.BackgroundImage")));
            this.redLaser4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redLaser4.Location = new System.Drawing.Point(810, 100);
            this.redLaser4.Name = "redLaser4";
            this.redLaser4.Size = new System.Drawing.Size(52, 10);
            this.redLaser4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLaser4.TabIndex = 26;
            this.redLaser4.TabStop = false;
            // 
            // explosion1
            // 
            this.explosion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.explosion1.BackColor = System.Drawing.Color.Transparent;
            this.explosion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.explosion1.ErrorImage = null;
            this.explosion1.Image = global::Star_Wars_Game.Properties.Resources.explosion_gif;
            this.explosion1.InitialImage = null;
            this.explosion1.Location = new System.Drawing.Point(6, 114);
            this.explosion1.Name = "explosion1";
            this.explosion1.Size = new System.Drawing.Size(96, 74);
            this.explosion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion1.TabIndex = 24;
            this.explosion1.TabStop = false;
            // 
            // greenLaser3
            // 
            this.greenLaser3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenLaser3.BackColor = System.Drawing.Color.Transparent;
            this.greenLaser3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenLaser3.BackgroundImage")));
            this.greenLaser3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenLaser3.Location = new System.Drawing.Point(120, 84);
            this.greenLaser3.Name = "greenLaser3";
            this.greenLaser3.Size = new System.Drawing.Size(52, 10);
            this.greenLaser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenLaser3.TabIndex = 18;
            this.greenLaser3.TabStop = false;
            // 
            // greenLaser2
            // 
            this.greenLaser2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenLaser2.BackColor = System.Drawing.Color.Transparent;
            this.greenLaser2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenLaser2.BackgroundImage")));
            this.greenLaser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenLaser2.Location = new System.Drawing.Point(120, 68);
            this.greenLaser2.Name = "greenLaser2";
            this.greenLaser2.Size = new System.Drawing.Size(52, 10);
            this.greenLaser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenLaser2.TabIndex = 17;
            this.greenLaser2.TabStop = false;
            // 
            // redLaser3
            // 
            this.redLaser3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLaser3.BackColor = System.Drawing.Color.Transparent;
            this.redLaser3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redLaser3.BackgroundImage")));
            this.redLaser3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redLaser3.Location = new System.Drawing.Point(810, 84);
            this.redLaser3.Name = "redLaser3";
            this.redLaser3.Size = new System.Drawing.Size(52, 10);
            this.redLaser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLaser3.TabIndex = 3;
            this.redLaser3.TabStop = false;
            // 
            // redLaser2
            // 
            this.redLaser2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLaser2.BackColor = System.Drawing.Color.Transparent;
            this.redLaser2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redLaser2.BackgroundImage")));
            this.redLaser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redLaser2.Location = new System.Drawing.Point(810, 68);
            this.redLaser2.Name = "redLaser2";
            this.redLaser2.Size = new System.Drawing.Size(52, 10);
            this.redLaser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLaser2.TabIndex = 3;
            this.redLaser2.TabStop = false;
            // 
            // redLaser1
            // 
            this.redLaser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLaser1.BackColor = System.Drawing.Color.Transparent;
            this.redLaser1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redLaser1.BackgroundImage")));
            this.redLaser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redLaser1.Location = new System.Drawing.Point(810, 52);
            this.redLaser1.Name = "redLaser1";
            this.redLaser1.Size = new System.Drawing.Size(52, 10);
            this.redLaser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLaser1.TabIndex = 3;
            this.redLaser1.TabStop = false;
            // 
            // greenLaser1
            // 
            this.greenLaser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenLaser1.BackColor = System.Drawing.Color.Transparent;
            this.greenLaser1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenLaser1.BackgroundImage")));
            this.greenLaser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenLaser1.Location = new System.Drawing.Point(120, 52);
            this.greenLaser1.Name = "greenLaser1";
            this.greenLaser1.Size = new System.Drawing.Size(52, 10);
            this.greenLaser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenLaser1.TabIndex = 1;
            this.greenLaser1.TabStop = false;
            // 
            // picStarDestroyer
            // 
            this.picStarDestroyer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStarDestroyer.BackColor = System.Drawing.Color.Transparent;
            this.picStarDestroyer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStarDestroyer.BackgroundImage")));
            this.picStarDestroyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStarDestroyer.Location = new System.Drawing.Point(6, 318);
            this.picStarDestroyer.Name = "picStarDestroyer";
            this.picStarDestroyer.Size = new System.Drawing.Size(334, 252);
            this.picStarDestroyer.TabIndex = 25;
            this.picStarDestroyer.TabStop = false;
            // 
            // picDeathStar
            // 
            this.picDeathStar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDeathStar.BackColor = System.Drawing.Color.Transparent;
            this.picDeathStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDeathStar.BackgroundImage")));
            this.picDeathStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDeathStar.Location = new System.Drawing.Point(346, 318);
            this.picDeathStar.Name = "picDeathStar";
            this.picDeathStar.Size = new System.Drawing.Size(250, 250);
            this.picDeathStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDeathStar.TabIndex = 4;
            this.picDeathStar.TabStop = false;
            // 
            // gameOverTimer
            // 
            this.gameOverTimer.Tick += new System.EventHandler(this.gameOverTimer_Tick);
            // 
            // btnExit2
            // 
            this.btnExit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit2.BackColor = System.Drawing.Color.Black;
            this.btnExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.ForeColor = System.Drawing.Color.White;
            this.btnExit2.Location = new System.Drawing.Point(77, 100);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(107, 26);
            this.btnExit2.TabIndex = 4;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 582);
            this.Controls.Add(this.hiScorePanel);
            this.Controls.Add(this.btnExitGF);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.explosion4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.explosion3);
            this.Controls.Add(this.explosion2);
            this.Controls.Add(this.redLaser6);
            this.Controls.Add(this.redLaser5);
            this.Controls.Add(this.redLaser4);
            this.Controls.Add(this.explosion1);
            this.Controls.Add(this.greenLaser3);
            this.Controls.Add(this.greenLaser2);
            this.Controls.Add(this.redLaser3);
            this.Controls.Add(this.redLaser2);
            this.Controls.Add(this.redLaser1);
            this.Controls.Add(this.greenLaser1);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.txtHiScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblHiScore);
            this.Controls.Add(this.shieldBar);
            this.Controls.Add(this.lblShield);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picStarDestroyer);
            this.Controls.Add(this.picDeathStar);
            this.Controls.Add(this.fireworks);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "STAR WARS Game Demo";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyRelease);
            this.hiScorePanel.ResumeLayout(false);
            this.hiScorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireworks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLaser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLaser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLaser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLaser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarDestroyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeathStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox greenLaser1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox redLaser1;
        private System.Windows.Forms.PictureBox redLaser2;
        private System.Windows.Forms.PictureBox redLaser3;
        private System.Windows.Forms.PictureBox picDeathStar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblShield;
        private System.Windows.Forms.ProgressBar shieldBar;
        private System.Windows.Forms.Label lblHiScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtHiScore;
        private System.Windows.Forms.PictureBox greenLaser2;
        private System.Windows.Forms.PictureBox greenLaser3;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.TextBox txtAmmo;
        private System.Windows.Forms.PictureBox explosion1;
        private System.Windows.Forms.Timer explosionTimer1;
        private System.Windows.Forms.PictureBox picStarDestroyer;
        private System.Windows.Forms.PictureBox redLaser4;
        private System.Windows.Forms.PictureBox redLaser5;
        private System.Windows.Forms.PictureBox redLaser6;
        private System.Windows.Forms.PictureBox explosion2;
        private System.Windows.Forms.PictureBox explosion3;
        private System.Windows.Forms.PictureBox explosion4;
        private System.Windows.Forms.Timer explosionTimer2;
        private System.Windows.Forms.Timer explosionTimer3;
        private System.Windows.Forms.Timer explosionTimer4;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExitGF;
        private System.Windows.Forms.Panel hiScorePanel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.PictureBox fireworks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer gameOverTimer;
        private System.Windows.Forms.Button btnExit2;
    }
}

