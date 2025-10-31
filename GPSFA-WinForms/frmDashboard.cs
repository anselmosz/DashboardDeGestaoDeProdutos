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
using MySql.Data.MySqlClient;

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
            AtualizarTotais();
            AtualizarLabelMesAtual();
            CarregarDadosNoChartProdutos();
            CarregarDadosNoGraficoMensal();
            CarregarDadosNaListaDeProdutos();
        }

        private void CarregarDadosNaListaDeProdutos()
        {
            try
            {
                dgvProdutos.Rows.Clear();

                MySqlCommand comm = new MySqlCommand();
                string sql = "SELECT DATE_FORMAT(prod.dataDeEntrada, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), prod.nome, prod.quantidade, prod.unidade, prod.peso, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu ORDER BY dataDeEntrada DESC LIMIT 8;";

                MySqlDataAdapter DA = new MySqlDataAdapter(sql, DataBaseConnection.OpenConnection());
                DataTable dt = new DataTable();

                if (DA.Fill(dt) < 1)
                {
                    MessageBox.Show("Sem registros no banco de dados");
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string dataArrecadacao = Convert.ToString(dr.ItemArray[0]);
                        string dataValidade = Convert.ToString(dr.ItemArray[1]);

                        string nomeProduto = dr.ItemArray[2] != DBNull.Value ? dr.ItemArray[2].ToString() : "";
                        string quantidadeProduto = dr.ItemArray[3] != DBNull.Value ? dr.ItemArray[3].ToString() : "";
                        string unidadeMedida = dr.ItemArray[4] != DBNull.Value ? dr.ItemArray[4].ToString() : "";
                        string peso = dr.ItemArray[5] != DBNull.Value ? dr.ItemArray[5].ToString() : "";
                        string cadastradoPor = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";

                        dgvProdutos.Rows.Add(nomeProduto, quantidadeProduto, peso + " " + unidadeMedida, dataArrecadacao, cadastradoPor);
                    }
                    DA.Dispose();
                }
                DataBaseConnection.CloseConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBaseConnection.CloseConnection();
        }

        private void CarregarDadosNoChartProdutos()
        {
            chartProdutos.Series.Clear();
            chartProdutos.Titles.Clear();

            var series = new Series("Produtos Recebidos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            string query = "SELECT p.nome AS nomeProduto, SUM(p.quantidade) AS totalQuantidadeProdutos FROM tbProdutos as p GROUP BY p.nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;";

            try
            {
                using (var cmd = new MySqlCommand(query, DataBaseConnection.OpenConnection()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader["nomeProduto"].ToString();
                            if (nome.Length > 15) nome = nome.Substring(0, 12) + "...";

                            series.Points.AddXY(
                                nome,
                                Convert.ToDouble(reader["totalQuantidadeProdutos"])
                            );
                        }
                    }
                }
                
                chartProdutos.Series.Add(series);
                chartProdutos.Titles.Add("Produtos Mais Recebidos (Quantidade)");
                chartProdutos.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar gráfico de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBaseConnection.CloseConnection();
        }

        private void CarregarDadosNoGraficoMensal()
        {
            chartDoacaoMensal.Series.Clear();
            chartDoacaoMensal.Titles.Clear();

            var series = new Series("Itens por Mês")
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true
            };

            string query = "SELECT YEAR(dataDeEntrada) AS ano, MONTH(dataDeEntrada) AS mes, SUM(quantidade) AS totalMensal FROM tbProdutos GROUP BY YEAR(dataDeEntrada), MONTH(dataDeEntrada) ORDER BY ano, mes;";

            try
            {
                using (var cmd = new MySqlCommand(query, DataBaseConnection.OpenConnection()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mes = Convert.ToInt32(reader["mes"]);
                            int ano = Convert.ToInt32(reader["ano"]);
                            string label = $"{mes}/{ano}";

                            series.Points.AddXY(
                                label,
                                Convert.ToDouble(reader["totalMensal"])
                            );
                        }
                    }
                }
                
                chartDoacaoMensal.Series.Add(series);
                chartDoacaoMensal.Titles.Add("Quantidade de Itens por Mês");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar gráfico mensal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBaseConnection.CloseConnection();
        }

        private void AtualizarLabelMesAtual()
        {
            try
            {
                string query = "SELECT COUNT(*) as total_mes_atual FROM tbProdutos WHERE MONTH(dataDeEntrada) = MONTH(CURDATE()) AND YEAR(dataDeEntrada) = YEAR(CURDATE());";

                using (var cmd = new MySqlCommand(query, DataBaseConnection.OpenConnection()))
                {
                    int totalMesAtual = Convert.ToInt32(cmd.ExecuteScalar());
                    if (totalMesAtual > 0)
                    {
                        string[] meses =
                        {
                            "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
                        };
                        string mesAtual = meses[DateTime.Now.Month - 1];
                        int anoAtual = DateTime.Now.Year;

                        lblMesAtualDataReceiver.Text = mesAtual;

                        lblMesAtualDataReceiver.Visible = true;
                        lblMesAtualDataReceiver.ForeColor = Color.Orange;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMesAtualDataReceiver.Text = "Erro ao carregar informações do mês";
                lblMesAtualDataReceiver.Visible = true;
                lblMesAtualDataReceiver.ForeColor = Color.Red;
                Console.WriteLine("Erro ao atualizar label do mês: " + ex.Message);
            }
            DataBaseConnection.CloseConnection();
        }

        private void AtualizarTotais()
        {
            string queryTotalItens = "SELECT SUM(quantidade) as total_itens FROM tbProdutos;";
            string queryTotalKilos = "SELECT SUM(quantidade * peso) as total_peso FROM tbProdutos WHERE unidade = 'KG';";

            try
            {
                // Total de itens
                using (var cmd = new MySqlCommand(queryTotalItens, DataBaseConnection.OpenConnection()))
                {
                    object result = cmd.ExecuteScalar();
                    lbTotalDeItensDataReceiver.Text = result != DBNull.Value ? Convert.ToInt64(result).ToString("N0") : "0";
                }

                // Total em quilos
                using (var cmd = new MySqlCommand(queryTotalKilos, DataBaseConnection.OpenConnection()))
                {
                    object result = cmd.ExecuteScalar();
                    lblTotalEmQuilosDataReceiver.Text = result != DBNull.Value ? Convert.ToDecimal(result).ToString("N2") + " kg" : "0 kg";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar totais: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
