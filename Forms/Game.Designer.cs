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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PB_PREVIEW = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXT_SCORE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_LEVEL = new System.Windows.Forms.TextBox();
            this.BT_PAUSE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN_GAME)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PREVIEW)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_MAIN_GAME
            // 
            this.PB_MAIN_GAME.Location = new System.Drawing.Point(153, 44);
            this.PB_MAIN_GAME.Name = "PB_MAIN_GAME";
            this.PB_MAIN_GAME.Size = new System.Drawing.Size(281, 520);
            this.PB_MAIN_GAME.TabIndex = 0;
            this.PB_MAIN_GAME.TabStop = false;
            // 
            // BT_START
            // 
            this.BT_START.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BT_START.FlatAppearance.BorderSize = 0;
            this.BT_START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_START.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_START.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_START.Location = new System.Drawing.Point(458, 356);
            this.BT_START.Name = "BT_START";
            this.BT_START.Size = new System.Drawing.Size(186, 37);
            this.BT_START.TabIndex = 1;
            this.BT_START.Text = "Jogar";
            this.BT_START.UseVisualStyleBackColor = false;
            this.BT_START.Click += new System.EventHandler(this.BT_START_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.PB_PREVIEW);
            this.panel1.Location = new System.Drawing.Point(465, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 267);
            this.panel1.TabIndex = 2;
            // 
            // PB_PREVIEW
            // 
            this.PB_PREVIEW.Location = new System.Drawing.Point(17, 30);
            this.PB_PREVIEW.Name = "PB_PREVIEW";
            this.PB_PREVIEW.Size = new System.Drawing.Size(121, 114);
            this.PB_PREVIEW.TabIndex = 4;
            this.PB_PREVIEW.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.TXT_LEVEL);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TXT_SCORE);
            this.panel2.Location = new System.Drawing.Point(12, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 223);
            this.panel2.TabIndex = 3;
            // 
            // TXT_SCORE
            // 
            this.TXT_SCORE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TXT_SCORE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_SCORE.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SCORE.ForeColor = System.Drawing.Color.Gainsboro;
            this.TXT_SCORE.Location = new System.Drawing.Point(10, 56);
            this.TXT_SCORE.Multiline = true;
            this.TXT_SCORE.Name = "TXT_SCORE";
            this.TXT_SCORE.Size = new System.Drawing.Size(102, 47);
            this.TXT_SCORE.TabIndex = 4;
            this.TXT_SCORE.Text = "1";
            this.TXT_SCORE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Level";
            // 
            // TXT_LEVEL
            // 
            this.TXT_LEVEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TXT_LEVEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_LEVEL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_LEVEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.TXT_LEVEL.Location = new System.Drawing.Point(10, 146);
            this.TXT_LEVEL.Multiline = true;
            this.TXT_LEVEL.Name = "TXT_LEVEL";
            this.TXT_LEVEL.Size = new System.Drawing.Size(102, 47);
            this.TXT_LEVEL.TabIndex = 6;
            this.TXT_LEVEL.Text = "1";
            this.TXT_LEVEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_PAUSE
            // 
            this.BT_PAUSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BT_PAUSE.FlatAppearance.BorderSize = 0;
            this.BT_PAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PAUSE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BT_PAUSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_PAUSE.Location = new System.Drawing.Point(458, 407);
            this.BT_PAUSE.Name = "BT_PAUSE";
            this.BT_PAUSE.Size = new System.Drawing.Size(186, 37);
            this.BT_PAUSE.TabIndex = 4;
            this.BT_PAUSE.Text = "Pause";
            this.BT_PAUSE.UseVisualStyleBackColor = false;
            this.BT_PAUSE.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(656, 583);
            this.Controls.Add(this.BT_PAUSE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_START);
            this.Controls.Add(this.PB_MAIN_GAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN_GAME)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PREVIEW)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MAIN_GAME;
        private System.Windows.Forms.Button BT_START;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PB_PREVIEW;
        private System.Windows.Forms.TextBox TXT_LEVEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SCORE;
        private System.Windows.Forms.Button BT_PAUSE;
    }
}

