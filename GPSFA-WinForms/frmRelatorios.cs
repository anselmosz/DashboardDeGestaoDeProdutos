using MySql.Data.MySqlClient;
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
        public frmRelatorios()
        {
            InitializeComponent();
        }
        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDadosNaListaDeProdutos()
        {
            try
            {
                // Limpa os dados do datagrid view quando o método é acionado
                dgvProdutos.Rows.Clear();

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
                        dgvProdutos.Rows.Add(nomeProduto, quantidadeProduto, peso + " " + unidadeMedida, dataArrecadacao, cadastradoPor);
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

        public void CarregarDados()
        {
            // Carrega no datagrid view os últimos produtos adicionados no banco
            CarregarDadosNaListaDeProdutos();
        }


    }
}
