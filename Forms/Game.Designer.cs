namespace MyNoTetris
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
            this.PB_MAIN_GAME = new System.Windows.Forms.PictureBox();
            this.BT_START = new System.Windows.Forms.Button();
            this.PB_PREVIEW = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_PAUSE = new System.Windows.Forms.Button();
            this.BT_RANKING = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_MINIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.LBL_SCORE = new System.Windows.Forms.Label();
            this.LBL_LEVEL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN_GAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PREVIEW)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_MAIN_GAME
            // 
            this.PB_MAIN_GAME.Location = new System.Drawing.Point(153, 89);
            this.PB_MAIN_GAME.Name = "PB_MAIN_GAME";
            this.PB_MAIN_GAME.Size = new System.Drawing.Size(281, 520);
            this.PB_MAIN_GAME.TabIndex = 0;
            this.PB_MAIN_GAME.TabStop = false;
            // 
            // BT_START
            // 
            this.BT_START.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.BT_START.BackgroundImage = global::MyNoTetris.Properties.Resources.BACKGROUND;
            this.BT_START.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_START.FlatAppearance.BorderSize = 0;
            this.BT_START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_START.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_START.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_START.Location = new System.Drawing.Point(458, 401);
            this.BT_START.Name = "BT_START";
            this.BT_START.Size = new System.Drawing.Size(195, 43);
            this.BT_START.TabIndex = 1;
            this.BT_START.Text = "Novo Jogo";
            this.BT_START.UseVisualStyleBackColor = false;
            this.BT_START.Click += new System.EventHandler(this.BT_START_Click);
            // 
            // PB_PREVIEW
            // 
            this.PB_PREVIEW.Location = new System.Drawing.Point(455, 134);
            this.PB_PREVIEW.Name = "PB_PREVIEW";
            this.PB_PREVIEW.Size = new System.Drawing.Size(115, 114);
            this.PB_PREVIEW.TabIndex = 4;
            this.PB_PREVIEW.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.LBL_LEVEL);
            this.panel2.Controls.Add(this.LBL_SCORE);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 223);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // BT_PAUSE
            // 
            this.BT_PAUSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.BT_PAUSE.BackgroundImage = global::MyNoTetris.Properties.Resources.BACKGROUND;
            this.BT_PAUSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_PAUSE.FlatAppearance.BorderSize = 0;
            this.BT_PAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PAUSE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BT_PAUSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_PAUSE.Location = new System.Drawing.Point(458, 450);
            this.BT_PAUSE.Name = "BT_PAUSE";
            this.BT_PAUSE.Size = new System.Drawing.Size(195, 43);
            this.BT_PAUSE.TabIndex = 4;
            this.BT_PAUSE.Text = "Pause";
            this.BT_PAUSE.UseVisualStyleBackColor = false;
            this.BT_PAUSE.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_RANKING
            // 
            this.BT_RANKING.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.BT_RANKING.BackgroundImage = global::MyNoTetris.Properties.Resources.BACKGROUND;
            this.BT_RANKING.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_RANKING.FlatAppearance.BorderSize = 0;
            this.BT_RANKING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_RANKING.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BT_RANKING.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_RANKING.Location = new System.Drawing.Point(458, 499);
            this.BT_RANKING.Name = "BT_RANKING";
            this.BT_RANKING.Size = new System.Drawing.Size(195, 43);
            this.BT_RANKING.TabIndex = 5;
            this.BT_RANKING.Text = "Ranking";
            this.BT_RANKING.UseVisualStyleBackColor = false;
            this.BT_RANKING.Click += new System.EventHandler(this.BT_RANKING_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BT_MINIZE);
            this.panel3.Controls.Add(this.BT_CLOSE);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 55);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tetris Black n\' white";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyNoTetris.Properties.Resources.tetrisSmallBW;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BT_MINIZE
            // 
            this.BT_MINIZE.FlatAppearance.BorderSize = 0;
            this.BT_MINIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MINIZE.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MINIZE.Location = new System.Drawing.Point(566, 0);
            this.BT_MINIZE.Name = "BT_MINIZE";
            this.BT_MINIZE.Size = new System.Drawing.Size(42, 42);
            this.BT_MINIZE.TabIndex = 8;
            this.BT_MINIZE.Text = "_";
            this.BT_MINIZE.UseVisualStyleBackColor = true;
            this.BT_MINIZE.Click += new System.EventHandler(this.BT_MINIZE_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.FlatAppearance.BorderSize = 0;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLOSE.Location = new System.Drawing.Point(614, 0);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(42, 42);
            this.BT_CLOSE.TabIndex = 7;
            this.BT_CLOSE.Text = "X";
            this.BT_CLOSE.UseVisualStyleBackColor = true;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // LBL_SCORE
            // 
            this.LBL_SCORE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SCORE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBL_SCORE.Image = global::MyNoTetris.Properties.Resources.SCOREBG;
            this.LBL_SCORE.Location = new System.Drawing.Point(18, 44);
            this.LBL_SCORE.Name = "LBL_SCORE";
            this.LBL_SCORE.Size = new System.Drawing.Size(88, 68);
            this.LBL_SCORE.TabIndex = 7;
            this.LBL_SCORE.Text = "1";
            this.LBL_SCORE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_LEVEL
            // 
            this.LBL_LEVEL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_LEVEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBL_LEVEL.Image = global::MyNoTetris.Properties.Resources.SCOREBG;
            this.LBL_LEVEL.Location = new System.Drawing.Point(18, 140);
            this.LBL_LEVEL.Name = "LBL_LEVEL";
            this.LBL_LEVEL.Size = new System.Drawing.Size(88, 68);
            this.LBL_LEVEL.TabIndex = 8;
            this.LBL_LEVEL.Text = "1";
            this.LBL_LEVEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(444, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Próximo bloco";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(656, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PB_PREVIEW);
            this.Controls.Add(this.BT_RANKING);
            this.Controls.Add(this.BT_PAUSE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BT_START);
            this.Controls.Add(this.PB_MAIN_GAME);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN_GAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PREVIEW)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MAIN_GAME;
        private System.Windows.Forms.Button BT_START;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PB_PREVIEW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_PAUSE;
        private System.Windows.Forms.Button BT_RANKING;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_MINIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_SCORE;
        private System.Windows.Forms.Label LBL_LEVEL;
        private System.Windows.Forms.Label label4;
    }
}

