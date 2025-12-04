using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPSFA_WinForms;
using MySql.Data.MySqlClient;

namespace Projeto_Socorrista
{
    public partial class frmEstoque : Form
    {
        private string busca = "";
        private string unidadeEscolhida = "";
        private string status_validade = "";
        private DateTime? dataValidade = null;
        private bool modoAgrupado = true;

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void ConfigurarDataGridView(bool modoAgrupado)
        {
          // Configuração geral (mantém o visual igual)
          dgvEstoque.Columns.Clear(); 
          dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          dgvEstoque.RowsDefaultCellStyle.BackColor = Color.LightGray; 
          dgvEstoque.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular); 
          dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
          dgvEstoque.RowTemplate.Height = 40;
          dgvEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
          dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
          dgvEstoque.MultiSelect = false; 
          // Define as colunas conforme o modo
          if (modoAgrupado) { 
                // 🧩 Modo AGRUPADO//
                dgvEstoque.Columns.Add("Lote", "Lote");
                dgvEstoque.Columns.Add("ProdutoAgrupado", "Produto"); 
                dgvEstoque.Columns.Add("QuantidadeTotal", "Quantidade Total");
                dgvEstoque.Columns.Add("Unidade", "Unidade"); 
                dgvEstoque.Columns.Add("Peso", "Peso");
                dgvEstoque.Columns.Add("StatusValidade", "Status");
                dgvEstoque.Columns.Add("ValidadeMinima", "Validade Mínima"); 
            } else {
                // Modo DETALHADO//
                dgvEstoque.Columns.Add("CodProd", "Código");
                dgvEstoque.Columns.Add("Nome", "Nome"); 
                dgvEstoque.Columns.Add("Peso", "Peso"); 
                dgvEstoque.Columns.Add("Unidade", "Unidade"); 
                dgvEstoque.Columns.Add("StatusValidade", "Status"); 
                dgvEstoque.Columns.Add("DataDeEntrada", "Entrada"); 
                dgvEstoque.Columns.Add("DataDeValidade", "Validade"); 
                // Adiciona o botão "Editar"//
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar"; btnEditar.HeaderText = "Editar"; 
                btnEditar.Text = "Editar"; btnEditar.UseColumnTextForButtonValue = true;
                dgvEstoque.Columns.Add(btnEditar); 
            } 
        }

        private void CarregarDadosAgrupado(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvEstoque.Rows.Clear();

            MySqlCommand comm = new MySqlCommand();

                comm.CommandText = @"
           SELECT 
                descricao,
                unidade,
                peso,
                SUM(quantidade) AS quantidade_total,
                MIN(dataDeValidade) AS validade_minima,
                CASE
                    WHEN MIN(dataDeValidade) < CURDATE() THEN 'Vencido'
                    WHEN DATEDIFF(MIN(dataDeValidade), CURDATE()) <= 60 THEN 'Próximo do vencimento'
                    ELSE 'Válido'
                END AS status_validade
            FROM tbprodutos
            WHERE
                (@busca = '' OR descricao LIKE @buscaPattern)
                AND (@unidade = '' OR unidade = @unidade)
                AND (@validade IS NULL OR DATE(dataDeValidade) = @validade)
                AND (
                    @status = '' 
                    OR (@status = 'Vencido' AND dataDeValidade < CURDATE())
                    OR (@status = 'Próximo do vencimento' AND DATEDIFF(dataDeValidade, CURDATE()) <= 60 AND dataDeValidade >= CURDATE())
                    OR (@status = 'Válido' AND DATEDIFF(dataDeValidade, CURDATE()) > 60)
                )
            GROUP BY
                descricao, unidade, peso
            ORDER BY descricao;
            ";
            comm.CommandType = CommandType.Text;

            // parâmetros
            comm.Parameters.Clear();
            comm.Parameters.Add("@busca", MySqlDbType.VarChar, 50).Value = busca;
            comm.Parameters.Add("@buscaPattern", MySqlDbType.VarChar, 100).Value = "%" + busca + "%";
            comm.Parameters.Add("@validade", MySqlDbType.Date).Value = validade.HasValue ? validade.Value.Date : (object)DBNull.Value;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 50).Value = unidade == "Selecione..." ? "" : unidade;
            comm.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status == "Selecione..." ? "" : status;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();
            while (DR.Read())
            {
                string validadeMinima = DR["validade_minima"] == DBNull.Value ?
                    "" :
                    Convert.ToDateTime(DR["validade_minima"]).ToString("dd/MM/yyyy");

                dgvEstoque.Rows.Add(
                    "LOTE",                                   // primeira coluna
                    DR["descricao"].ToString(),
                    DR["unidade"].ToString(),
                    DR["quantidade_total"].ToString(),
                    DR["peso"].ToString(),
                    DR["status_validade"].ToString(),
                    validadeMinima                            // data mínima de validade do lote
                );
            }

            DR.Close();
            DataBaseConnection.CloseConnection();
        }

        private void CarregarDadosDetalhados(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvEstoque.Rows.Clear();

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = @"
        SELECT
            p.codProd,
            l.descricao AS nomeProduto,
            l.peso,
            u.descricao AS descricao,
            p.dataDeEntrada,
            p.dataDeValidade,
            CASE
                WHEN p.dataDeValidade < NOW() THEN 'Vencido'
                WHEN p.dataDeValidade < DATE_ADD(NOW(), INTERVAL 2 MONTH) THEN 'Próximo do vencimento'
                ELSE 'Válido'
            END AS status_validade
         
        FROM tbprodutos p
        INNER JOIN tblista l ON l.codList = p.codList
        INNER JOIN tbunidade u ON u.codUni = l.codUni
         
        WHERE
            (@busca = '' OR l.descricao LIKE @buscaPattern)
            AND (@unidade = '' OR u.descricao = @unidade)
            AND (@validade IS NULL OR DATE(p.dataDeValidade) = @validade)

            AND (
                    @status = '' 
                OR (@status = 'Válido' AND p.dataDeValidade >= DATE_ADD(NOW(), INTERVAL 2 MONTH))
                OR (@status = 'Próximo do vencimento' AND p.dataDeValidade < DATE_ADD(NOW(), INTERVAL 2 MONTH) AND p.dataDeValidade >= NOW())
                OR (@status = 'Vencido' AND p.dataDeValidade < NOW())
            )

        ORDER BY l.descricao, p.dataDeValidade ASC;";

            comm.CommandType = CommandType.Text;

            // parâmetros
            comm.Parameters.Clear();
            comm.Parameters.Add("@busca", MySqlDbType.VarChar, 50).Value = busca;
            comm.Parameters.Add("@buscaPattern", MySqlDbType.VarChar, 100).Value = "%" + busca + "%";
            comm.Parameters.Add("@validade", MySqlDbType.Date).Value = validade.HasValue ? validade.Value.Date : (object)DBNull.Value;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 50).Value = unidade == "Selecione..." ? "" : unidade;
            comm.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status == "Selecione..." ? "" : status;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();
            while (DR.Read())
            {
                string entrada = Convert.ToDateTime(DR["dataDeEntrada"]).ToString("dd/MM/yyyy");
                string validadeStr = Convert.ToDateTime(DR["dataDeValidade"]).ToString("dd/MM/yyyy");

                dgvEstoque.Rows.Add(
                    DR["codProd"].ToString(),         // CodProd
                    DR["nomeProduto"].ToString(),     // Nome
                    DR["peso"].ToString(),            // Peso
                    DR["unidade"].ToString(),         // Unidade
                    DR["status_validade"].ToString(), // Status
                    entrada,                          // Entrada
                    validadeStr                       // Validade
                                                      // Botão Editar já existe como coluna fixa
                );
            }

            DR.Close();
            DataBaseConnection.CloseConnection();
        }

        private void CarregarUnidades()
        {
            try
            {
                cbxCategoria.Items.Clear();

                MySqlCommand comm = new MySqlCommand();
                // NOTE: column name is "descricao" in tbUnidade (not "unidade")
                comm.CommandText = @"SELECT descricao FROM tbunidade ORDER BY descricao ASC";
                comm.CommandType = CommandType.Text;
                comm.Connection = DataBaseConnection.OpenConnection();

                MySqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    cbxCategoria.Items.Add(dr["descricao"].ToString());
                }

                dr.Close();
                DataBaseConnection.CloseConnection();

                // Optional: add first item to indicate "no selection"
                cbxCategoria.Items.Insert(0, "Selecione...");
                cbxCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar unidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carregaDados()
        {
            dgvEstoque.Rows.Clear();
            ConfigurarDataGridView(modoAgrupado);
            if (modoAgrupado)
            {
                CarregarDadosAgrupado();
            }
            else
            {
                CarregarDadosDetalhados();
            }
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // Configura o DataGridView baseado no modo atual (agrupado ou detalhado)
            ConfigurarDataGridView(modoAgrupado);

            // Carrega as unidades do banco para o combo
            CarregarUnidades();

            // Define valores iniciais dos combos
     
            cbxStatus.SelectedIndex = 0;

            // Data não marcada no início
            dtpDataValidade.Value = DateTime.Today;
            dtpDataValidade.Checked = false;

            // Carrega os dados pela primeira vez
            carregaDados();
        }

        private void AplicarFiltros()
        {
            // --- 1. Validação dos filtros ---
            bool categoriaSelecionada = cbxCategoria.SelectedIndex > 0;
            bool statusSelecionado = cbxStatus.SelectedIndex > 0;
            bool validadeSelecionada = dtpDataValidade.Checked;

            if (!categoriaSelecionada && !statusSelecionado && !validadeSelecionada && string.IsNullOrWhiteSpace(txtNomeOrCod.Text))
            {
                MessageBox.Show("Nenhum filtro foi selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nome ou código
            busca = txtNomeOrCod.Text.Trim();
            unidadeEscolhida = categoriaSelecionada ? cbxCategoria.Text : "";
            status_validade = statusSelecionado ? cbxStatus.Text : "";
            dataValidade = validadeSelecionada ? dtpDataValidade.Value.Date : (DateTime?)null;
            carregaDados();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEstoque.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                // Obter o código do produto da linha selecionada
                string rowData = dgvEstoque.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                frmEditarEstoque f = new frmEditarEstoque(rowData);
                f.DadosAtualizados += () =>
                {
                    AtualizarStatusValidade();
                    carregaDados();
                };

                f.Show();
            }
            else
            {
                MessageBox.Show("Clique no botão 'Editar' para mudar os dados do item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedIndex == 0 && cbxStatus.SelectedIndex == 0 && dtpDataValidade.Value == DateTime.Today) {
                MessageBox.Show("Não há filtros para limpar", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            carregaDados();
            cbxCategoria.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;
            dtpDataValidade.Value = DateTime.Today;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarStatusValidade()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"SELECT nome, quantidade, peso, unidade, codBar, dataDeEntrada, dataDeValidade, dataLimiteDeSaida, " +
                "CASE WHEN dataDeValidade < CURDATE() THEN 'Valído' ELSE 'Vencido' END AS status_validade FROM tbProdutos ORDER BY codProd;";
            comm.CommandType = CommandType.Text;
            comm.Connection = DataBaseConnection.OpenConnection();
            comm.ExecuteNonQuery();
            DataBaseConnection.CloseConnection();
        }

        private void btnCarregaTodosProdutos_Click(object sender, EventArgs e)
        {
            if (!txtNomeOrCod.Text.Equals(""))
            {
                txtNomeOrCod.Clear();
                AplicarFiltros();
            }
            else { 
                AplicarFiltros();
            }
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
