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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridViewALUNO = new System.Windows.Forms.DataGridView();
            this.COL_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_SCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewALUNO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(161, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fim de jogo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.DataGridViewALUNO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 99);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DataGridViewALUNO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewALUNO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DataGridViewALUNO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewALUNO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewALUNO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewALUNO.ColumnHeadersHeight = 40;
            this.DataGridViewALUNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewALUNO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_NOME,
            this.COL_SCORE,
            this.COL_DATA,
            this.COL_HR});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewALUNO.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewALUNO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewALUNO.Location = new System.Drawing.Point(21, 50);
            this.DataGridViewALUNO.MultiSelect = false;
            this.DataGridViewALUNO.Name = "DataGridViewALUNO";
            this.DataGridViewALUNO.ReadOnly = true;
            this.DataGridViewALUNO.RowHeadersVisible = false;
            this.DataGridViewALUNO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewALUNO.RowTemplate.Height = 18;
            this.DataGridViewALUNO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewALUNO.Size = new System.Drawing.Size(443, 280);
            this.DataGridViewALUNO.TabIndex = 487;
            // 
            // COL_NOME
            // 
            this.COL_NOME.DataPropertyName = "COL_NOME";
            this.COL_NOME.HeaderText = "Nome";
            this.COL_NOME.Name = "COL_NOME";
            this.COL_NOME.ReadOnly = true;
            this.COL_NOME.Width = 180;
            // 
            // COL_SCORE
            // 
            this.COL_SCORE.DataPropertyName = "COL_SCORE";
            this.COL_SCORE.HeaderText = "Score";
            this.COL_SCORE.Name = "COL_SCORE";
            this.COL_SCORE.ReadOnly = true;
            // 
            // COL_DATA
            // 
            this.COL_DATA.DataPropertyName = "COL_DATA";
            this.COL_DATA.HeaderText = "Data";
            this.COL_DATA.Name = "COL_DATA";
            this.COL_DATA.ReadOnly = true;
            this.COL_DATA.Width = 80;
            // 
            // COL_HR
            // 
            this.COL_HR.DataPropertyName = "COL_HR";
            this.COL_HR.HeaderText = "Horario";
            this.COL_HR.Name = "COL_HR";
            this.COL_HR.ReadOnly = true;
            this.COL_HR.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ranking";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(518, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewALUNO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridViewALUNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_SCORE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_HR;
    }
}