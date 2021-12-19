namespace MyNoTetris.Forms
{
    partial class ScoreBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_TITLE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridViewALUNO = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.COL_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_SCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewALUNO)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_TITLE
            // 
            this.LBL_TITLE.AutoSize = true;
            this.LBL_TITLE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITLE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBL_TITLE.Location = new System.Drawing.Point(161, 9);
            this.LBL_TITLE.Name = "LBL_TITLE";
            this.LBL_TITLE.Size = new System.Drawing.Size(169, 37);
            this.LBL_TITLE.TabIndex = 5;
            this.LBL_TITLE.Text = "Fim de jogo";
            this.LBL_TITLE.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DataGridViewALUNO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 352);
            this.panel1.TabIndex = 7;
            // 
            // DataGridViewALUNO
            // 
            this.DataGridViewALUNO.AllowUserToAddRows = false;
            this.DataGridViewALUNO.AllowUserToDeleteRows = false;
            this.DataGridViewALUNO.AllowUserToOrderColumns = true;
            this.DataGridViewALUNO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DataGridViewALUNO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewALUNO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DataGridViewALUNO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewALUNO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewALUNO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewALUNO.ColumnHeadersHeight = 4;
            this.DataGridViewALUNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewALUNO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_NOME,
            this.COL_SCORE,
            this.COL_DATA,
            this.COL_HR});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewALUNO.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewALUNO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewALUNO.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DataGridViewALUNO.Location = new System.Drawing.Point(26, 64);
            this.DataGridViewALUNO.MultiSelect = false;
            this.DataGridViewALUNO.Name = "DataGridViewALUNO";
            this.DataGridViewALUNO.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewALUNO.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewALUNO.RowHeadersVisible = false;
            this.DataGridViewALUNO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewALUNO.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewALUNO.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DataGridViewALUNO.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewALUNO.RowTemplate.Height = 18;
            this.DataGridViewALUNO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewALUNO.Size = new System.Drawing.Size(432, 267);
            this.DataGridViewALUNO.TabIndex = 487;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(184, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ranking";
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.BT_EXIT.BackgroundImage = global::MyNoTetris.Properties.Resources.BACKGROUND;
            this.BT_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_EXIT.FlatAppearance.BorderSize = 0;
            this.BT_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EXIT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EXIT.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_EXIT.Location = new System.Drawing.Point(309, 427);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(195, 43);
            this.BT_EXIT.TabIndex = 8;
            this.BT_EXIT.Text = "Sair";
            this.BT_EXIT.UseVisualStyleBackColor = false;
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 39);
            this.panel2.TabIndex = 488;
            // 
            // COL_NOME
            // 
            this.COL_NOME.DataPropertyName = "COL_NOME";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            this.COL_NOME.DefaultCellStyle = dataGridViewCellStyle3;
            this.COL_NOME.HeaderText = "Nome";
            this.COL_NOME.Name = "COL_NOME";
            this.COL_NOME.ReadOnly = true;
            this.COL_NOME.Width = 180;
            // 
            // COL_SCORE
            // 
            this.COL_SCORE.DataPropertyName = "COL_SCORE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COL_SCORE.DefaultCellStyle = dataGridViewCellStyle4;
            this.COL_SCORE.HeaderText = "Score";
            this.COL_SCORE.Name = "COL_SCORE";
            this.COL_SCORE.ReadOnly = true;
            this.COL_SCORE.Width = 50;
            // 
            // COL_DATA
            // 
            this.COL_DATA.DataPropertyName = "COL_DATA";
            this.COL_DATA.HeaderText = "Data";
            this.COL_DATA.Name = "COL_DATA";
            this.COL_DATA.ReadOnly = true;
            this.COL_DATA.Width = 120;
            // 
            // COL_HR
            // 
            this.COL_HR.DataPropertyName = "COL_HR";
            this.COL_HR.HeaderText = "Horario";
            this.COL_HR.Name = "COL_HR";
            this.COL_HR.ReadOnly = true;
            this.COL_HR.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(152, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(228, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(518, 482);
            this.Controls.Add(this.BT_EXIT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_TITLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewALUNO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_TITLE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridViewALUNO;
        private System.Windows.Forms.Button BT_EXIT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_SCORE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_HR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}