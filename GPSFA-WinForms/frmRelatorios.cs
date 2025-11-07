using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();

        }
        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // Carrega no datagrid view os últimos produtos adicionados no banco
            CarregarDadosNaListaDeProdutos();
            cbbUsuarios.SelectedIndex = 0;
            carregarUsuários();
        }

        // Carrega no datagrid view os últimos produtos adicionados no banco
        private void CarregarDadosNaListaDeProdutos()
        {
            try
            {
                // Limpa os dados do datagrid view quando o método é acionado
                dgvRelatorio.Rows.Clear();

                // Consulta SQL responsável por buscar os 8 produtos mais recentemente cadastrados no sistema.
                // A consulta realiza um INNER JOIN entre as tabelas de produtos e usuários, formatando as datas e retornando informações essenciais para exibição
                string buscarProdutosCadastrados = "SELECT prod.nome, prod.quantidade, prod.peso, prod.unidade, DATE_FORMAT(prod.dataDeEntrada, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), tbvol.nome FROM tbprodutos as prod INNER JOIN tbusuarios AS tbusr ON prod.codUsu = tbusr.codUsu INNER JOIN tbvoluntarios AS tbvol ON tbusr.codVol = tbvol.codVol ORDER BY dataDeEntrada DESC;";

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
                        // As próximas colunas são verificadas quanto a valores nulos (DBNull)
                        // Caso sejam nulas, uma string vazia é atribuída para evitar erros de conversão
                        string nomeProduto = dr.ItemArray[0] != DBNull.Value ? dr.ItemArray[0].ToString() : "";
                        string quantidadeProduto = dr.ItemArray[1] != DBNull.Value ? dr.ItemArray[1].ToString() : "";
                        string peso = dr.ItemArray[2] != DBNull.Value ? dr.ItemArray[2].ToString() : "";
                        string unidadeMedida = dr.ItemArray[3] != DBNull.Value ? dr.ItemArray[3].ToString() : "";
                        string dataDeEntrada = dr.ItemArray[4] != DBNull.Value ? dr.ItemArray[4].ToString() : "";
                        string dataDeValidade = dr.ItemArray[5] != DBNull.Value ? dr.ItemArray[5].ToString() : "";
                        string cadastradoPor = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";

                        // Adiciona os dados formatados no DataGridView (interface visual)
                        // Exemplo de célula: "2 kg"
                        dgvRelatorio.Rows.Add(nomeProduto, quantidadeProduto, peso + " " + unidadeMedida, dataDeEntrada, dataDeValidade, cadastradoPor);
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
        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            dgvRelatorio.Rows.Clear();

            string dataInicial = dtpDataInicialPeriodo.Value.ToString("yyyy-MM-dd");
            string dataFinal = dtpDataFinalPeriodo.Value.ToString("yyyy-MM-dd");

            try
            {
                string querySql = $"SELECT prod.nome, prod.quantidade, prod.peso, prod.unidade, DATE_FORMAT(prod.dataDeEntrada, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), tbvol.nome FROM tbprodutos as prod INNER JOIN tbusuarios AS tbusr ON prod.codUsu = tbusr.codUsu INNER JOIN tbvoluntarios AS tbvol ON tbusr.codVol = tbvol.codVol WHERE prod.dataDeEntrada BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY prod.dataDeEntrada DESC;";

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
                        // As próximas colunas são verificadas quanto a valores nulos (DBNull)
                        // Caso sejam nulas, uma string vazia é atribuída para evitar erros de conversão
                        string nomeProduto = dr.ItemArray[0] != DBNull.Value ? dr.ItemArray[0].ToString() : "";
                        string quantidadeProduto = dr.ItemArray[1] != DBNull.Value ? dr.ItemArray[1].ToString() : "";
                        string peso = dr.ItemArray[2] != DBNull.Value ? dr.ItemArray[2].ToString() : "";
                        string unidadeMedida = dr.ItemArray[3] != DBNull.Value ? dr.ItemArray[3].ToString() : "";
                        string dataDeEntrada = dr.ItemArray[4] != DBNull.Value ? dr.ItemArray[4].ToString() : "";
                        string dataDeValidade = dr.ItemArray[5] != DBNull.Value ? dr.ItemArray[5].ToString() : "";
                        string cadastradoPor = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";

                        // Adiciona os dados formatados no DataGridView (interface visual)
                        // Exemplo de célula: "2 kg"
                        dgvRelatorio.Rows.Add(nomeProduto, quantidadeProduto, peso + " " + unidadeMedida, dataDeEntrada, dataDeValidade, cadastradoPor);
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

        private void limparFiltros()
        {
            dtpDataInicialPeriodo.Value = DateTime.Now;
            dtpDataFinalPeriodo.Value = DateTime.Now;
            cbbUsuarios.SelectedIndex = 0;
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            CarregarDadosNaListaDeProdutos();
            limparFiltros();
        }

        private void carregarUsuários()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "SELECT tbvol.nome, tbusr.email FROM tbusuarios AS tbusr INNER JOIN tbvoluntarios AS tbvol ON tbusr.codVol = tbvol.codvol ORDER BY tbvol.nome DESC;";

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbUsuarios.Items.Add(DR.GetString(0));
            }

            DataBaseConnection.CloseConnection();
        }

       
        
    }
}
