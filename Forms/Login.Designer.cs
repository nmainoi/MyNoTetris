namespace MyNoTetris.Forms
{
    partial class Login
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
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.BT_JOGAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.TXT_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_USUARIO.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.TXT_USUARIO.ForeColor = System.Drawing.Color.Gainsboro;
            this.TXT_USUARIO.Location = new System.Drawing.Point(103, 52);
            this.TXT_USUARIO.Multiline = true;
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(197, 35);
            this.TXT_USUARIO.TabIndex = 0;
            this.TXT_USUARIO.Text = "Player01";
            this.TXT_USUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_JOGAR
            // 
            this.BT_JOGAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_JOGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BT_JOGAR.BackgroundImage = global::MyNoTetris.Properties.Resources.BACKGROUND;
            this.BT_JOGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_JOGAR.FlatAppearance.BorderSize = 0;
            this.BT_JOGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_JOGAR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BT_JOGAR.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_JOGAR.Location = new System.Drawing.Point(103, 94);
            this.BT_JOGAR.Name = "BT_JOGAR";
            this.BT_JOGAR.Size = new System.Drawing.Size(197, 43);
            this.BT_JOGAR.TabIndex = 5;
            this.BT_JOGAR.Text = "Jogar";
            this.BT_JOGAR.UseVisualStyleBackColor = false;
            this.BT_JOGAR.Click += new System.EventHandler(this.BT_JOGAR_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do jogador";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(403, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_JOGAR);
            this.Controls.Add(this.TXT_USUARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Button BT_JOGAR;
        private System.Windows.Forms.Label label1;
    }
}