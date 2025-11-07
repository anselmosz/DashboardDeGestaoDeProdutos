using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSFA_WinForms
{
    public class FiltroDeBuscaBD
    {
        public bool FiltrarPorPeriodo { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public bool FiltrarPorUsuario { get; set; }
        public string NomeUsuario { get; set; }

        public DataTable BuscarProdutos(FiltroDeBuscaBD filtro)
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT prod.nome, prod.quantidade, prod.unidade, prod.peso, ");
                query.Append("vol.nome, prod.dataDeEntrada, prod.dataDeValidade ");
                query.Append("FROM tbprodutos AS prod");
                query.Append("INNER JOIN tbUsuarios AS usr ON prod.codUsu = usr.codUsu ");
                query.Append("INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol ");
                query.Append("WHERE 1=1 ");

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conexao;

                if (filtro.FiltrarPorPeriodo)
                {
                    query.Append("prod.dataDeEntrada BETWEEN @dataInicial AND @dataFinal");
                    comm.Parameters.AddWithValue("@dataInicial", DataInicial.Value);
                    comm.Parameters.AddWithValue("@dataFinal", DataFinal.Value);
                }

                if (filtro.FiltrarPorUsuario && !string.IsNullOrEmpty(filtro.NomeUsuario))
                {
                    query.Append("AND usr.nome = @nomeUsuario ");
                    comm.Parameters.AddWithValue("@nomeUsuario", filtro.NomeUsuario);
                }

                query.Append("ORDER BY prod.dataDeEntrada DESC;");

                comm.CommandText = query.ToString();

                MySqlDataAdapter DA = new MySqlDataAdapter(comm);
                DA.Fill(tabela);
            }

            return tabela;
        }
    }
}
