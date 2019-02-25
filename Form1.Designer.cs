namespace GameProject
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zombie_right = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.zombie_bottom = new System.Windows.Forms.PictureBox();
            this.zombie_top = new System.Windows.Forms.PictureBox();
            this.zombie_left = new System.Windows.Forms.PictureBox();
            this.StartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_left)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bullets: |||||";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(360, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "hp";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Brown;
            this.scoreLabel.Location = new System.Drawing.Point(9, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(164, 50);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar.Location = new System.Drawing.Point(405, 639);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(271, 10);
            this.progressBar.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.gameInterval);
            // 
            // zombie_right
            // 
            this.zombie_right.BackColor = System.Drawing.Color.Transparent;
            this.zombie_right.BackgroundImage = global::GameProject.Properties.Resources.zombie_right;
            this.zombie_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zombie_right.Location = new System.Drawing.Point(29, 340);
            this.zombie_right.Name = "zombie_right";
            this.zombie_right.Size = new System.Drawing.Size(30, 59);
            this.zombie_right.TabIndex = 7;
            this.zombie_right.TabStop = false;
            this.zombie_right.Tag = "zombie";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::GameProject.Properties.Resources.player_top;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(458, 322);
            this.player.MaximumSize = new System.Drawing.Size(45, 59);
            this.player.MinimumSize = new System.Drawing.Size(45, 59);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(45, 59);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 8;
            this.player.TabStop = false;
            // 
            // zombie_bottom
            // 
            this.zombie_bottom.BackColor = System.Drawing.Color.Transparent;
            this.zombie_bottom.BackgroundImage = global::GameProject.Properties.Resources.zombie_bottom;
            this.zombie_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zombie_bottom.Location = new System.Drawing.Point(403, 42);
            this.zombie_bottom.Name = "zombie_bottom";
            this.zombie_bottom.Size = new System.Drawing.Size(30, 59);
            this.zombie_bottom.TabIndex = 4;
            this.zombie_bottom.TabStop = false;
            this.zombie_bottom.Tag = "zombie";
            // 
            // zombie_top
            // 
            this.zombie_top.BackColor = System.Drawing.Color.Transparent;
            this.zombie_top.BackgroundImage = global::GameProject.Properties.Resources.zombie_top;
            this.zombie_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zombie_top.Location = new System.Drawing.Point(284, 529);
            this.zombie_top.Name = "zombie_top";
            this.zombie_top.Size = new System.Drawing.Size(30, 59);
            this.zombie_top.TabIndex = 5;
            this.zombie_top.TabStop = false;
            this.zombie_top.Tag = "zombie";
            // 
            // zombie_left
            // 
            this.zombie_left.BackColor = System.Drawing.Color.Transparent;
            this.zombie_left.BackgroundImage = global::GameProject.Properties.Resources.zombie_left;
            this.zombie_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zombie_left.Location = new System.Drawing.Point(928, 352);
            this.zombie_left.Name = "zombie_left";
            this.zombie_left.Size = new System.Drawing.Size(30, 59);
            this.zombie_left.TabIndex = 6;
            this.zombie_left.TabStop = false;
            this.zombie_left.Tag = "zombie";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.StartLabel.Location = new System.Drawing.Point(-90, 171);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Padding = new System.Windows.Forms.Padding(100);
            this.StartLabel.Size = new System.Drawing.Size(1216, 327);
            this.StartLabel.TabIndex = 9;
            this.StartLabel.Text = " Press Space to Start";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.zombie_right);
            this.Controls.Add(this.zombie_left);
            this.Controls.Add(this.zombie_top);
            this.Controls.Add(this.zombie_bottom);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.zombie_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox zombie_right;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox zombie_bottom;
        private System.Windows.Forms.PictureBox zombie_top;
        private System.Windows.Forms.PictureBox zombie_left;
        private System.Windows.Forms.Label StartLabel;
    }
}

