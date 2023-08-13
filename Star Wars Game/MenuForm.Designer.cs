namespace Star_Wars_Game
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExitMF = new System.Windows.Forms.Button();
            this.exitTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(54, 135);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(401, 82);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STAR WARS";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Demo";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Star_Wars_Game.Properties.Resources.GreenLaser;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(346, 282);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(219, 62);
            this.btnPlay.TabIndex = 33;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHighScores.BackColor = System.Drawing.Color.Transparent;
            this.btnHighScores.BackgroundImage = global::Star_Wars_Game.Properties.Resources.GreenLaser;
            this.btnHighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHighScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighScores.FlatAppearance.BorderSize = 0;
            this.btnHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScores.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.ForeColor = System.Drawing.Color.Black;
            this.btnHighScores.Location = new System.Drawing.Point(346, 369);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(219, 62);
            this.btnHighScores.TabIndex = 34;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExitMF
            // 
            this.btnExitMF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitMF.BackColor = System.Drawing.Color.Transparent;
            this.btnExitMF.BackgroundImage = global::Star_Wars_Game.Properties.Resources.RedLaser;
            this.btnExitMF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitMF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitMF.FlatAppearance.BorderSize = 0;
            this.btnExitMF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMF.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMF.ForeColor = System.Drawing.Color.Black;
            this.btnExitMF.Location = new System.Drawing.Point(346, 451);
            this.btnExitMF.Name = "btnExitMF";
            this.btnExitMF.Size = new System.Drawing.Size(219, 62);
            this.btnExitMF.TabIndex = 35;
            this.btnExitMF.Text = "Exit";
            this.btnExitMF.UseVisualStyleBackColor = false;
            this.btnExitMF.Click += new System.EventHandler(this.btnExitMF_Click);
            // 
            // exitTimer
            // 
            this.exitTimer.Tick += new System.EventHandler(this.exitTimer_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Star_Wars_Game.Properties.Resources.Space_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 578);
            this.Controls.Add(this.btnExitMF);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "STAR WARS Game Demo";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExitMF;
        private System.Windows.Forms.Timer exitTimer;
    }
}