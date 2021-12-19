using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoTetris.Classes
{
    internal class SQL
    {
        public static string connetionString = "Data Source=.;Initial Catalog=Master;User ID=" +  MyNoTetris.Properties.Resources.User + ";Password=" + MyNoTetris.Properties.Resources.PassWord + ";";
        public static Dictionary<int, string> userHash = new Dictionary<int, string>();
        public static string _user { get; set; } = "PlayerO1";
        public static int _id { get; set; }
        private static globalCommands Gm = new globalCommands();
        public static int InsertSQL(string SqlCommandLine = "")
        {

            int newProdID = 0;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand(SqlCommandLine, conn);
                try
                {
                    conn.Open();
                    newProdID = (Int32)cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão SQL envie mensagem para o desenvolvedor! " + System.Environment.NewLine + ex.ToString());
                    return 0;
                }
            }
            return newProdID;
        }

        public static string ReadSQL(string SqlCommandLine = "")
        {

            string newProdID = "";
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand(SqlCommandLine, conn);
                try
                {
                    conn.Open();
                    newProdID = Convert.ToString(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
              //      MessageBox.Show("Erro na conexão SQL envie mensagem para o desenvolvedor! " + System.Environment.NewLine + ex.ToString());

                }
            }
            return newProdID;
        }
        public static bool RunSQLCommand(string SqlCommandLine = "")
        {

            SqlConnection connection;
            SqlCommand command;
            SqlDataReader dataReader;
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(SqlCommandLine, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão SQL envie mensagem para o desenvolvedor! " + System.Environment.NewLine + ex.ToString());
                return false;
            }
            return true;
        }
        public static void ConsistSQLDatabase()
        {
            string mysql = " IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'BDTetris') BEGIN CREATE DATABASE[BDTetris] END";
            /* Cria data base inicinal */
            RunSQLCommand(mysql);
            /* Cria tabela de usuarios*/
            mysql = CreateTableUserTetris(mysql);
            RunSQLCommand(mysql);
            /* Cria tabela de scores*/
            mysql = CreateTableScoreTetris(mysql);
            RunSQLCommand(mysql);
            /*monta hash de usuarios para nao ter que ficar executando qury do sql toda hora*/
            MakeUserHash();

        }
       
        public static void MakeUserHash()
        {
            string sql = "Select ID,NAME FROM BDTetris.dbo.[USER](nolock)";
            List<Dictionary<string, string>> listUser = SQL.CreateDataTable(sql);
            foreach (Dictionary<string, string> item in listUser)
            {
                string AuxID = item["ID"];
                string AuxNAME = item["NAME"];
                if (!userHash.ContainsKey(Int32.Parse(AuxID)))
                    userHash.Add(Int32.Parse(AuxID), AuxNAME);
            }
        }
        private static string CreateTableUserTetris(string mysql)
        {
            mysql = "IF NOT (EXISTS (SELECT * FROM BDTetris.INFORMATION_SCHEMA.TABLES WHERE  TABLE_NAME = 'USER')) ";
            mysql += "BEGIN USE [BDTetris]";
            mysql += "CREATE TABLE[dbo].[USER](";
            mysql += "[ID][int] IDENTITY(1,1) NOT NULL,";
            mysql += "[NAME] [varchar] (50) NOT NULL";
            mysql += ") ON[PRIMARY]";
            mysql += " END";
            return mysql;
        }
        private static string CreateTableScoreTetris(string mysql)
        {
            mysql = "IF NOT (EXISTS (SELECT * FROM BDTetris.INFORMATION_SCHEMA.TABLES WHERE  TABLE_NAME = 'SCORE')) ";
            mysql += "BEGIN USE [BDTetris]";
            mysql += "CREATE TABLE[dbo].[SCORE](";
            mysql += "[ID] [int] NOT NULL,";
            mysql += "[SCORE] [int] NOT NULL,";
            mysql += "[DATE] [int] NOT NULL,";
            mysql += "[TIME] [varchar](9) NOT NULL)";
            mysql += " END";
            return mysql;
        }
        public static List<Dictionary<string, string>> CreateDataTable(string commandLine)
        {
            
            HashSet<string> columns = new HashSet<string>();
            List<Dictionary<string,string>> rows = new List<Dictionary<string,string>>();
            string line =(string)Gm.Split(commandLine.ToLower(), "select").GetValue(1);
           line = (string)Gm.Split(line.ToLower(), "from").GetValue(0);
            string[] reg = Gm.Split(line, ",");
            foreach (var item in reg)
                columns.Add(item);

                
            SqlConnection connection;
            SqlCommand command;
            SqlDataReader dataReader;
            Dictionary<string,string> sqlRows = new Dictionary<string,string>();
            var values = new List<string>();
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(commandLine, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int i = 0;
                    Dictionary<string, string> result = new Dictionary<string, string>();
                    foreach (var item in columns)
                    {
                        result.Add(item.ToUpper().Trim(), dataReader[i].ToString());
                        i++;
                    }                   
                    rows.Add(result);
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão SQL envie mensagem para o desenvolvedor! " + System.Environment.NewLine + ex.ToString());
            }

            return rows;
        }
  }
}
