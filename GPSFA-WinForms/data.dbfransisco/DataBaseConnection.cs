using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFA_WinForms
{
    internal class DataBaseConnection
    {   // Informações do banco de dados utilizado até o momento (DB de testes rodando localmente)
<<<<<<< HEAD
        private static string DataBase = "Server=localhost;Port=3306;Database=dbfrancisco;Uid=root;Pwd=''";
=======
        private static string DataBase = "Server=localhost; Port=3306; DataBase=dbfrancisco; Uid=root; Pwd=''";
>>>>>>> 8a4891c64d0dfecf2bcb618494e642262a0574db

        // Variável sem valor definido utilizando a biblioteca do MySql para recebimento de dados
        private static MySqlConnection conn = null;

        // Método para abrir a conexão com o banco
        public static MySqlConnection OpenConnection()
        {
            conn = new MySqlConnection(DataBase); // A váriável "conn" recebe as informãções do banco

            try
            {   // É aberta conexão com o banco
                conn.Open();
            }
            catch (MySqlException ex) 
            {   // Em caso de falha na conexão, "conn" é retornado sem um valor definido e é retornado o erro
                MessageBox.Show("Erro na conexão: " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return conn = null;
            }

            // Retorna "conn" ao final da tentativa de conexão,
            return conn;
        }

        // Método para fechar a conexão com o banco
        public static void CloseConnection()
        {   
            if (conn != null) // Verifica se a conexão do banco está ativa para então fechar
            {
                conn.Close(); // Fecha conexão do banco
            }
        }
    }
}
