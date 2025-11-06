using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmRelatorios : Form
    {
        string rdbtnDataReferencia;

        public frmRelatorios()
        {
            InitializeComponent();

        }
        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // Carrega no datagrid view os últimos produtos adicionados no banco
            CarregarDadosNaListaDeProdutos();
        }

        // Carrega no datagrid view os últimos produtos adicionados no banco
        private void CarregarDadosNaListaDeProdutos()
        {
            try
            {
                // Limpa os dados do datagrid view quando o método é acionado
                dgvRelatorio.Rows.Clear();

                // Nova instancia da biblioteca do MySql do tipo "Comando do MySql"
                MySqlCommand comm = new MySqlCommand();

                // Consulta SQL responsável por buscar os 8 produtos mais recentemente cadastrados no sistema.
                // A consulta realiza um INNER JOIN entre as tabelas de produtos e usuários, formatando as datas e retornando informações essenciais para exibição
                string buscarProdutosCadastrados = "SELECT DATE_FORMAT(prod.dataDeEntrada, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), prod.nome, prod.quantidade, prod.unidade, prod.peso, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu ORDER BY dataDeEntrada DESC;";

                // Abre conexão com o banco e usa a string para aplicar o comando de busca, realizando a adaptação dos dados para o app
                MySqlDataAdapter DA = new MySqlDataAdapter(buscarProdutosCadastrados, DataBaseConnection.OpenConnection());

                // Cria um novo DataTable para armazenar os dados vindos do banco
                DataTable dt = new DataTable();

                // Executa o DataAdapter (provavelmente DA é um SqlDataAdapter) e preenche o DataTable
                // O método Fill retorna o número de registros retornados pela consulta
                if (DA.Fill(dt) < 1)
                {
                    // Se não houver registros, exibe uma mensagem informando o usuário
                    MessageBox.Show("Sem registros no banco de dados");
                }
                else
                {
                    // Percorre todas as linhas retornadas pelo banco de dados
                    foreach (DataRow dr in dt.Rows)
                    {
                        // Extrai os valores das colunas e converte para string
                        // As duas primeiras colunas são convertidas diretamente
                        string dataArrecadacao = Convert.ToString(dr.ItemArray[0]);
                        string dataValidade = Convert.ToString(dr.ItemArray[1]);

                        // As próximas colunas são verificadas quanto a valores nulos (DBNull)
                        // Caso sejam nulas, uma string vazia é atribuída para evitar erros de conversão
                        string nomeProduto = dr.ItemArray[2] != DBNull.Value ? dr.ItemArray[2].ToString() : "";
                        string quantidadeProduto = dr.ItemArray[3] != DBNull.Value ? dr.ItemArray[3].ToString() : "";
                        string unidadeMedida = dr.ItemArray[4] != DBNull.Value ? dr.ItemArray[4].ToString() : "";
                        string peso = dr.ItemArray[5] != DBNull.Value ? dr.ItemArray[5].ToString() : "";
                        string cadastradoPor = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";

                        // Adiciona os dados formatados no DataGridView (interface visual)
                        // Exemplo de célula: "2 kg"
                        dgvRelatorio.Rows.Add(nomeProduto, quantidadeProduto, peso + " " + unidadeMedida, dataArrecadacao, cadastradoPor);
                    }
                    // Libera os recursos utilizados pelo DataAdapter
                    DA.Dispose();
                }
                // Fecha a conexão com o banco de dados para evitar conexões abertas desnecessariamente
                DataBaseConnection.CloseConnection();
            }

            catch (Exception ex)
            {
                // Caso ocorra qualquer erro (falha de conexão, SQL, etc.), exibe uma mensagem de erro para o usuário
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Fecha a conexão com o banco de dados para evitar vazamentos de recursos
            DataBaseConnection.CloseConnection();
        }

        private int BuscaDeProdutosComFiltroDePeriodo(string dataDeReferencia, DateTime dataInicial, DateTime dataFinal)
        {   
            // Nova instancia da biblioteca do MySql do tipo "Comando do MySql"
            MySqlCommand comm = new MySqlCommand();

            // Consulta SQL responsável por buscar os 8 produtos mais recentemente cadastrados no sistema.
            // A consulta realiza um INNER JOIN entre as tabelas de produtos e usuários, formatando as datas e retornando informações essenciais para exibição
            comm.CommandText = "SELECT prod.nome, prod.quantidade, prod.peso, prod.unidade, prod.dataDeEntrada, prod.dataDeValidade, prod.dataDeSaida, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu WHERE prod.@dataDeReferencia BETWEEN @dataInicial AND @dataFinal ORDER BY prod.@dataDeReferencia DESC;";

            comm.Parameters.Clear();

            comm.Parameters.Add("@rdbtnReferencia", MySqlDbType.String, 100).Value = dataDeReferencia;
            comm.Parameters.Add("@dataInicial", MySqlDbType.Date).Value = dataInicial;
            comm.Parameters.Add("@dataFinal", MySqlDbType.Date).Value = dataFinal;

            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;
        }

        private void btnAtualizarRelatorio_Click(object sender, EventArgs e)
        {
            dgvRelatorio.Rows.Clear();

            if (!rdbtnDataDeEntrada.Checked && !rdbtnDataDeSaida.Checked)
            {
                MessageBox.Show("É necessário que um parametro de data esteja selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string dataInicial = dtpDataInicialPeriodo.Value.ToString("yyyy-MM-dd");
                string dataFinal = dtpDataFinalPeriodo.Value.ToString("yyyy-MM-dd");

                if (rdbtnDataDeEntrada.Checked)
                {
                    rdbtnDataReferencia = "dataDeEntrada";

                    if (rdbtnDataDeSaida.Checked)
                    {
                        rdbtnDataReferencia = "dataDeValidade";
                    }
                }

                try
                {
                    //MySqlCommand comm = new MySqlCommand();

                    string querySql = $"SELECT prod.nome, prod.quantidade, prod.peso, prod.unidade, prod.dataDeEntrada, prod.dataDeValidade, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu WHERE prod.{rdbtnDataReferencia} BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY prod.{rdbtnDataReferencia} DESC;";


                    MySqlDataAdapter DA = new MySqlDataAdapter(querySql, DataBaseConnection.OpenConnection());

                    DataTable dt = new DataTable();

                    if (DA.Fill(dt) < 1)
                    {
                        MessageBox.Show("Sem registros no banco de dados");
                    }
                    else
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            // Extrai os valores das colunas e converte para string
                            // As duas primeiras colunas são convertidas diretamente
                            string dataArrecadacao = Convert.ToString(dr.ItemArray[4]);
                            string dataValidade = Convert.ToString(dr.ItemArray[5]);

                            // As próximas colunas são verificadas quanto a valores nulos (DBNull)
                            // Caso sejam nulas, uma string vazia é atribuída para evitar erros de conversão
                            string nomeProduto = dr.ItemArray[0] != DBNull.Value ? dr.ItemArray[0].ToString() : "";
                            string quantidadeProduto = dr.ItemArray[1] != DBNull.Value ? dr.ItemArray[1].ToString() : "";
                            string peso = dr.ItemArray[2] != DBNull.Value ? dr.ItemArray[2].ToString() : "";
                            string unidadeMedida = dr.ItemArray[3] != DBNull.Value ? dr.ItemArray[3].ToString() : "";
                            string cadastradoPor = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";

                            // Adiciona os dados formatados no DataGridView (interface visual)
                            // Exemplo de célula: "2 kg"
                            dgvRelatorio.Rows.Add(nomeProduto, quantidadeProduto, peso + " " + unidadeMedida, dataArrecadacao, dataValidade, cadastradoPor);
                        }
                        // Libera os recursos utilizados pelo DataAdapter
                        DA.Dispose();
                    }
                    // Fecha a conexão com o banco de dados para evitar conexões abertas desnecessariamente
                    DataBaseConnection.CloseConnection();
                }

                catch (Exception ex)
                {
                    // Caso ocorra qualquer erro (falha de conexão, SQL, etc.), exibe uma mensagem de erro para o usuário
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Fecha a conexão com o banco de dados para evitar vazamentos de recursos
                DataBaseConnection.CloseConnection();
            }
        }

        private void limparFiltros()
        {
            rdbtnDataDeEntrada.Checked = false;
            rdbtnDataDeSaida.Checked = false;
            dtpDataInicialPeriodo.Value = DateTime.Now;
            dtpDataFinalPeriodo.Value = DateTime.Now;
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            CarregarDadosNaListaDeProdutos();
            limparFiltros();
        }
    }
}
