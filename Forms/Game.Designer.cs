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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PB_PREVIEW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN_GAME)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PREVIEW)).BeginInit();
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
            this.BT_START.Location = new System.Drawing.Point(569, 511);
            this.BT_START.Name = "BT_START";
            this.BT_START.Size = new System.Drawing.Size(75, 62);
            this.BT_START.TabIndex = 1;
            this.BT_START.Text = "Jogar!";
            this.BT_START.UseVisualStyleBackColor = true;
            this.BT_START.Click += new System.EventHandler(this.BT_START_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.PB_PREVIEW);
            this.panel1.Location = new System.Drawing.Point(465, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 267);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(12, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 121);
            this.panel2.TabIndex = 3;
            // 
            // PB_PREVIEW
            // 
            this.PB_PREVIEW.Location = new System.Drawing.Point(17, 30);
            this.PB_PREVIEW.Name = "PB_PREVIEW";
            this.PB_PREVIEW.Size = new System.Drawing.Size(121, 114);
            this.PB_PREVIEW.TabIndex = 4;
            this.PB_PREVIEW.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_START);
            this.Controls.Add(this.PB_MAIN_GAME);
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAIN_GAME)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PREVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MAIN_GAME;
        private System.Windows.Forms.Button BT_START;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PB_PREVIEW;
    }
}

