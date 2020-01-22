namespace Rock_Paper_Scissors_Game
{
    partial class Game
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
            this.Header = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ScoreHolder = new System.Windows.Forms.Panel();
            this.ScoreTitle = new System.Windows.Forms.Label();
            this.playerscoreholder = new System.Windows.Forms.Panel();
            this.playerscore = new System.Windows.Forms.Label();
            this.cpuscoreholder = new System.Windows.Forms.Panel();
            this.cpuscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveTime = new System.Windows.Forms.Label();
            this.WhoWins = new System.Windows.Forms.Label();
            this.wintext = new System.Windows.Forms.Label();
            this.retrybutton = new System.Windows.Forms.Button();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.ScoreHolder.SuspendLayout();
            this.playerscoreholder.SuspendLayout();
            this.cpuscoreholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.Header.Controls.Add(this.ReturnButton);
            this.Header.Controls.Add(this.ExitButton);
            this.Header.Controls.Add(this.Title);
            this.Header.Location = new System.Drawing.Point(-3, -1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(738, 94);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clicked);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Moved);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Released);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BackgroundImage = global::Rock_Paper_Scissors_Game.Properties.Resources.Return2;
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReturnButton.Location = new System.Drawing.Point(670, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(26, 27);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::Rock_Paper_Scissors_Game.Properties.Resources.Shutdown_Icon1;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(702, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 29);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.Title.Location = new System.Drawing.Point(119, -8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(485, 102);
            this.Title.TabIndex = 0;
            this.Title.Text = "Rock Paper Scissors";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreHolder
            // 
            this.ScoreHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ScoreHolder.Controls.Add(this.ScoreTitle);
            this.ScoreHolder.Location = new System.Drawing.Point(282, 99);
            this.ScoreHolder.Name = "ScoreHolder";
            this.ScoreHolder.Size = new System.Drawing.Size(133, 71);
            this.ScoreHolder.TabIndex = 1;
            // 
            // ScoreTitle
            // 
            this.ScoreTitle.AutoSize = true;
            this.ScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.ScoreTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.ScoreTitle.Location = new System.Drawing.Point(10, 4);
            this.ScoreTitle.Name = "ScoreTitle";
            this.ScoreTitle.Size = new System.Drawing.Size(123, 58);
            this.ScoreTitle.TabIndex = 0;
            this.ScoreTitle.Text = "Score:";
            this.ScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerscoreholder
            // 
            this.playerscoreholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(3)))));
            this.playerscoreholder.Controls.Add(this.playerscore);
            this.playerscoreholder.Location = new System.Drawing.Point(212, 164);
            this.playerscoreholder.Name = "playerscoreholder";
            this.playerscoreholder.Size = new System.Drawing.Size(136, 60);
            this.playerscoreholder.TabIndex = 2;
            // 
            // playerscore
            // 
            this.playerscore.BackColor = System.Drawing.Color.Transparent;
            this.playerscore.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.playerscore.Location = new System.Drawing.Point(5, 0);
            this.playerscore.Name = "playerscore";
            this.playerscore.Size = new System.Drawing.Size(182, 58);
            this.playerscore.TabIndex = 0;
            this.playerscore.Text = "User : 0";
            this.playerscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuscoreholder
            // 
            this.cpuscoreholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(72)))));
            this.cpuscoreholder.Controls.Add(this.cpuscore);
            this.cpuscoreholder.Location = new System.Drawing.Point(353, 164);
            this.cpuscoreholder.Name = "cpuscoreholder";
            this.cpuscoreholder.Size = new System.Drawing.Size(127, 60);
            this.cpuscoreholder.TabIndex = 3;
            // 
            // cpuscore
            // 
            this.cpuscore.BackColor = System.Drawing.Color.Transparent;
            this.cpuscore.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cpuscore.Location = new System.Drawing.Point(5, 0);
            this.cpuscore.Name = "cpuscore";
            this.cpuscore.Size = new System.Drawing.Size(158, 58);
            this.cpuscore.TabIndex = 0;
            this.cpuscore.Text = "CPU : 0";
            this.cpuscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(113, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 77);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quick! Choose a Move:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveTime
            // 
            this.MoveTime.AutoSize = true;
            this.MoveTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.MoveTime.Location = new System.Drawing.Point(333, 304);
            this.MoveTime.Name = "MoveTime";
            this.MoveTime.Size = new System.Drawing.Size(53, 45);
            this.MoveTime.TabIndex = 6;
            this.MoveTime.Text = "3 s";
            this.MoveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhoWins
            // 
            this.WhoWins.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.WhoWins.Location = new System.Drawing.Point(127, 495);
            this.WhoWins.Name = "WhoWins";
            this.WhoWins.Size = new System.Drawing.Size(474, 77);
            this.WhoWins.TabIndex = 10;
            this.WhoWins.Text = "Paper beats Rock";
            this.WhoWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wintext
            // 
            this.wintext.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wintext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.wintext.Location = new System.Drawing.Point(277, 572);
            this.wintext.Name = "wintext";
            this.wintext.Size = new System.Drawing.Size(172, 68);
            this.wintext.TabIndex = 11;
            this.wintext.Text = "You Lose";
            this.wintext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // retrybutton
            // 
            this.retrybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.retrybutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.retrybutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.retrybutton.FlatAppearance.BorderSize = 5;
            this.retrybutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retrybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retrybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrybutton.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrybutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.retrybutton.Location = new System.Drawing.Point(287, 643);
            this.retrybutton.Name = "retrybutton";
            this.retrybutton.Size = new System.Drawing.Size(139, 69);
            this.retrybutton.TabIndex = 12;
            this.retrybutton.Text = "Retry";
            this.retrybutton.UseVisualStyleBackColor = false;
            this.retrybutton.Click += new System.EventHandler(this.retrybutton_Click);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // Scissors
            // 
            this.Scissors.BackgroundImage = global::Rock_Paper_Scissors_Game.Properties.Resources.Scissors2;
            this.Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scissors.Location = new System.Drawing.Point(457, 357);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(144, 122);
            this.Scissors.TabIndex = 9;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.BackgroundImage = global::Rock_Paper_Scissors_Game.Properties.Resources.Paper1;
            this.Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paper.Location = new System.Drawing.Point(282, 357);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(144, 122);
            this.Paper.TabIndex = 8;
            this.Paper.TabStop = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Rock
            // 
            this.Rock.BackgroundImage = global::Rock_Paper_Scissors_Game.Properties.Resources.Rock1;
            this.Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rock.Location = new System.Drawing.Point(108, 357);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(144, 122);
            this.Rock.TabIndex = 7;
            this.Rock.TabStop = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(341, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 60);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(735, 725);
            this.Controls.Add(this.retrybutton);
            this.Controls.Add(this.wintext);
            this.Controls.Add(this.WhoWins);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.MoveTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cpuscoreholder);
            this.Controls.Add(this.playerscoreholder);
            this.Controls.Add(this.ScoreHolder);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Header.ResumeLayout(false);
            this.ScoreHolder.ResumeLayout(false);
            this.ScoreHolder.PerformLayout();
            this.playerscoreholder.ResumeLayout(false);
            this.cpuscoreholder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel ScoreHolder;
        private System.Windows.Forms.Label ScoreTitle;
        private System.Windows.Forms.Panel playerscoreholder;
        private System.Windows.Forms.Label playerscore;
        private System.Windows.Forms.Panel cpuscoreholder;
        private System.Windows.Forms.Label cpuscore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoveTime;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.Label WhoWins;
        private System.Windows.Forms.Label wintext;
        private System.Windows.Forms.Button retrybutton;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Button ReturnButton;
    }
}

