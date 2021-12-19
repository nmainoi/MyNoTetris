using MyNoTetris.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MyNoTetris.Forms
{
    public partial class ScoreBoard : Form
    {
        private static globalCommands Gc = new globalCommands();

        public ScoreBoard()
        {
            InitializeComponent();
        }

        public void CreateDataCrid(bool gameOver = false)
        {
            LBL_TITLE.Visible = gameOver;
            DataRow line_ds;
            DataTable dt = new DataTable { Locale = System.Globalization.CultureInfo.GetCultureInfo("pt-BR") };

            dt.Columns.Add(new DataColumn(nameof(COL_NOME)));
            dt.Columns.Add(new DataColumn(nameof(COL_SCORE)));
            dt.Columns.Add(new DataColumn(nameof(COL_DATA), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(nameof(COL_HR)));
            string sql = "Select ID,SCORE,DATE,TIME FROM BDTetris.dbo.SCORE (nolock) order by SCORE desc";

            List<Dictionary<string, string>> reg = Classes.SQL.CreateDataTable(sql);
            foreach (Dictionary<string, string> row in reg)
            {
                string AuxID = row["ID"];
                string AuxSCORE = row.ContainsKey("SCORE") ? row["SCORE"] : "";
                string AuxDATE = row.ContainsKey("DATE") ? row["DATE"] : "";
                string AuxTIME = row.ContainsKey("TIME") ? row["TIME"] : "";
                line_ds = dt.NewRow();
                line_ds["COL_SCORE"] = AuxSCORE;
                line_ds["COL_NOME"] = SQL.userHash.ContainsKey(Int32.Parse(AuxID)) ? SQL.userHash[Int32.Parse(AuxID)] : "Guest";
                line_ds["COL_DATA"] = Gc.EdData(AuxDATE);
                line_ds["COL_HR"] = AuxTIME;

                dt.Rows.Add(line_ds);
            }
            DataGridViewALUNO.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}