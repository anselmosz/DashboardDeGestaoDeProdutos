using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GPSFA_WinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        public void CarregarDados()
        {
            // Atualiza o total dos itens (quantidade e depois o total em kg)
            AtualizarTotais();

            // Atualiza e exibe mês atual com base na último cadastro de produto
            AtualizarLabelMesAtual();
            
            // Carrega no gráfico de produtos os 8 itens mais recebidos
            CarregarDadosNoChartProdutos();

            // Carrega a quantidade total de itens recebidos por mês
            CarregarDadosNoGraficoMensal();
            
            // Carrega no datagrid view os últimos produtos adicionados no banco
            CarregarDadosNaListaDeProdutos();
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
                string buscarProdutosCadastrados = "SELECT DATE_FORMAT(prod.dataDeEntrada, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), prod.nome, prod.quantidade, prod.unidade, prod.peso, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu ORDER BY dataDeEntrada DESC LIMIT 8;";
                
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

        private void CarregarDadosNoChartProdutos()
        {
            // Remove todas as séries e títulos existentes do gráfico
            // Isso garante que o gráfico será redesenhado do zero, sem sobreposição de dados antigos
            chartProdutos.Series.Clear();
            chartProdutos.Titles.Clear();

            // Cria uma nova série para o gráfico chamada "Produtos Recebidos"
            // Define o tipo como gráfico de colunas (barras verticais) e exibe os valores numéricos diretamente sobre cada coluna
            var series = new Series("Produtos Recebidos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Consulta SQL que obtém os 8 produtos com maior quantidade total cadastrada
            // Soma as quantidades de cada produto (SUM) e agrupa por nome
            // Ordena do maior para o menor e limita a 8 resultados
            string query = "SELECT p.nome AS nomeProduto, SUM(p.quantidade) AS totalQuantidadeProdutos FROM tbProdutos as p GROUP BY p.nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;";

            try
            {
                // Abre a conexão com o banco e executa a consulta
                using (var cmd = new MySqlCommand(query, DataBaseConnection.OpenConnection()))
                {
                    // O ExecuteReader permite percorrer os resultados linha por linha  
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Lê cada produto retornado pela consulta
                        while (reader.Read())
                        {
                            // Obtém o nome do produto
                            string nome = reader["nomeProduto"].ToString();

                            // Se o nome for muito longo, encurta e adiciona "..." - Isso evita sobreposição dos rótulos no gráfico
                            if (nome.Length > 15) nome = nome.Substring(0, 12) + "...";

                            // Adiciona um ponto ao gráfico (eixo X = nome do produto, eixo Y = quantidade total)
                            series.Points.AddXY(
                                nome,
                                Convert.ToDouble(reader["totalQuantidadeProdutos"])
                            );
                        }
                    }
                }

                // Adiciona a série finalizada ao gráfico
                chartProdutos.Series.Add(series);

                // Define o título do gráfico
                chartProdutos.Titles.Add("Produtos Mais Recebidos (Quantidade)");

                // Inclina os rótulos do eixo X em -45° para melhor leitura
                chartProdutos.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
            catch (Exception ex)
            {
                // Caso ocorra erro (ex: falha de conexão, erro SQL), exibe uma mensagem informando o problema ao usuário
                MessageBox.Show("Erro ao carregar gráfico de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Fecha a conexão com o banco de dados para liberar recursos
            DataBaseConnection.CloseConnection();
        } 

        private void CarregarDadosNoGraficoMensal()
        {
            // Remove quaisquer séries e títulos existentes no gráfico
            // Isso evita sobreposição de dados antigos e garante um novo carregamento limpo
            chartDoacaoMensal.Series.Clear();
            chartDoacaoMensal.Titles.Clear();

            // Cria uma nova série de dados chamada "Itens por Mês"
            // Define o tipo do gráfico como linha (ideal para acompanhar variação temporal) e ativa a exibição dos valores acima de cada ponto
            var series = new Series("Itens por Mês")
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true
            };

            // Consulta SQL que retorna o total de produtos cadastrados em cada mês/ano
            // Agrupa os resultados por ano e mês, somando as quantidades de produtos e ordena os resultados em ordem cronológica crescente
            string query = "SELECT YEAR(dataDeEntrada) AS ano, MONTH(dataDeEntrada) AS mes, SUM(quantidade) AS totalMensal FROM tbProdutos GROUP BY YEAR(dataDeEntrada), MONTH(dataDeEntrada) ORDER BY ano, mes;";

            try
            {   // Abre a conexão com o banco e executa o comando SQL
                using (var cmd = new MySqlCommand(query, DataBaseConnection.OpenConnection()))
                {
                    // O reader permite percorrer os resultados da consulta linha por linha
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Lê cada registro retornado (um por mês/ano)
                        while (reader.Read())
                        {
                            // Extrai o mês e o ano dos dados retornados
                            int mes = Convert.ToInt32(reader["mes"]);
                            int ano = Convert.ToInt32(reader["ano"]);

                            // Cria o rótulo do eixo X no formato "mês/ano"
                            string label = $"{mes}/{ano}";

                            // Adiciona o ponto ao gráfico:
                            // eixo X = mês/ano | eixo Y = total de produtos cadastrados no período
                            series.Points.AddXY(
                                label,
                                Convert.ToDouble(reader["totalMensal"])
                            );
                        }
                    }
                }

                // Adiciona a série ao gráfico após carregar todos os dados
                chartDoacaoMensal.Series.Add(series);

                // Define o título exibido acima do gráfico
                chartDoacaoMensal.Titles.Add("Quantidade de Itens por Mês");
            }
            catch (Exception ex)
            {
                // Caso ocorra qualquer erro (falha de conexão, erro SQL, etc.),
                // exibe uma mensagem amigável ao usuário com detalhes do problema
                MessageBox.Show("Erro ao carregar gráfico mensal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Fecha a conexão com o banco de dados para liberar recursos e evitar bloqueios
            DataBaseConnection.CloseConnection();
        }

        private void AtualizarLabelMesAtual()
        {   /*
                Comportamento "inesperado" encontrado: Só mostra o mês atual se houver um cadastro no mês de referência

                Ex:
                    - Só mostra o mês de Novembro se tiver ocorrido algum cadastro em Novembro
                    - Do contrário, exibirá o componente "lblMesAtualDataReceiver" com o valor base "mês"
            */
            try
            {
                // Consulta SQL que conta quantos produtos foram cadastrados no mês e ano atual
                // Utiliza as funções do MySQL MONTH() e YEAR() comparadas com CURDATE() (data atual do servidor)
                string query = "SELECT COUNT(*) as total_mes_atual FROM tbProdutos WHERE MONTH(dataDeEntrada) = MONTH(CURDATE()) AND YEAR(dataDeEntrada) = YEAR(CURDATE());";

                // Cria o comando SQL e abre a conexão com o banco de dados
                // O 'using' garante que o objeto será liberado automaticamente ao final do bloco
                using (var cmd = new MySqlCommand(query, DataBaseConnection.OpenConnection()))
                {
                    // Executa a consulta e retorna o primeiro valor (total de registros)
                    int totalMesAtual = Convert.ToInt32(cmd.ExecuteScalar());

                    // Se houver produtos cadastrados no mês atual
                    if (totalMesAtual > 0)
                    {
                        // Array com os nomes dos meses em português
                        string[] meses =
                        {
                            "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
                        };
                        // Obtém o nome do mês atual baseado na data do sistema
                        string mesAtual = meses[DateTime.Now.Month - 1];

                        // Obtém o ano atual (não utilizado, mas pode ser útil em versões futuras)
                        int anoAtual = DateTime.Now.Year;

                        // Atualiza o label na interface com o nome do mês atual0
                        lblMesAtualDataReceiver.Text = mesAtual;
                        lblMesAtualDataReceiver.Visible = true;
                        lblMesAtualDataReceiver.ForeColor = Color.Orange;
                    }
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra qualquer erro (falha de conexão, SQL, etc.), exibe uma mensagem de erro para o usuário
                lblMesAtualDataReceiver.Text = "Erro ao carregar informações do mês";
                lblMesAtualDataReceiver.Visible = true;
                lblMesAtualDataReceiver.ForeColor = Color.Red;
                Console.WriteLine("Erro ao atualizar label do mês: " + ex.Message);
            }
            // Fecha a conexão com o banco de dados para evitar vazamentos de recursos
            DataBaseConnection.CloseConnection();
        }

        private void AtualizarTotais()
        {
            // Consulta que retorna a soma total de todos os itens cadastrados na tabela
            string queryTotalItens = "SELECT SUM(quantidade) as total_itens FROM tbProdutos;";

            // Consulta que retorna o peso total (em kg) de todos os produtos cuja unidade é "KG"
            // Multiplica a quantidade de cada produto pelo seu peso individual
            string queryTotalKilos = "SELECT SUM(quantidade * peso) as total_peso FROM tbProdutos WHERE unidade = 'KG';";

            try
            {
                // Abre uma única conexão com o banco de dados para executar ambas as consultas
                using (var conn = DataBaseConnection.OpenConnection())
                {
                    // ===== CONSULTA 1: Total de Itens =====
                    using (var cmd1 = new MySqlCommand(queryTotalItens, conn))
                    {
                        // Executa a consulta e obtém o resultado (primeiro valor da primeira linha)
                        object result = cmd1.ExecuteScalar();

                        // Se houver valor válido, converte para inteiro e formata com separadores de milhar
                        // Caso contrário, exibe "0"
                        lbTotalDeItensDataReceiver.Text = result != DBNull.Value ? Convert.ToInt64(result).ToString("N0") : "0";
                    }

                    // ===== CONSULTA 2: Total em Quilos =====
                    using (var cmd2 = new MySqlCommand(queryTotalKilos, conn))
                    {
                        // Executa a consulta que retorna o total de peso em quilos
                        object result = cmd2.ExecuteScalar();

                        // Se houver valor, converte para decimal e formata com 2 casas decimais
                        // Adiciona "kg" ao final do texto exibido
                        lblTotalEmQuilosDataReceiver.Text = result != DBNull.Value ? Convert.ToDecimal(result).ToString("N2") + " kg" : "0 kg";
                    }
                }
            }
            catch (Exception ex)

            {   // Caso ocorra qualquer erro (SQL, conexão ou conversão), exibe uma mensagem ao usuário
                MessageBox.Show("Erro ao carregar totais: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Fecha a conexão com o banco de dados para evitar vazamentos de recursos
            DataBaseConnection.CloseConnection();
        }
    }
}