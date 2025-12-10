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
            dgvEstoque.SuspendLayout();
            dgvEstoque.Columns.Clear();
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.MultiSelect = false;
            dgvEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvEstoque.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvEstoque.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvEstoque.RowTemplate.Height = 38;
            dgvEstoque.ClearSelection();

            if (modoAgrupado)
            {
                dgvEstoque.Columns.Add("ProdutoAgrupado", "Produto");
                dgvEstoque.Columns.Add("QuantidadeTotal", "Quantidade Total");
                dgvEstoque.Columns.Add("Unidade", "Unidade");
                dgvEstoque.Columns.Add("Peso", "Peso");
                dgvEstoque.Columns.Add("StatusValidade", "Status");
                dgvEstoque.Columns.Add("ValidadeMinima", "Validade Mínima");
            }
            else
            {
                dgvEstoque.Columns.Add("CodProd", "Código");
                dgvEstoque.Columns.Add("Nome", "Nome");
                dgvEstoque.Columns.Add("Peso", "Peso");
                dgvEstoque.Columns.Add("Unidade", "Unidade");
                dgvEstoque.Columns.Add("StatusValidade", "Status");
                dgvEstoque.Columns.Add("DataDeEntrada", "Entrada");
                dgvEstoque.Columns.Add("DataDeValidade", "Validade");

                // botão editar
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dgvEstoque.Columns.Add(btnEditar);
            }

            dgvEstoque.ResumeLayout();
        }

        private void CarregarDadosAgrupado(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvEstoque.Rows.Clear();

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = @"
        SELECT
            l.descricao AS descricao,
            SUM(p.quantidade) AS quantidade_total,
            u.descricao AS unidade,
            l.peso AS peso,
            MIN(p.dataDeValidade) AS validade_minima,
            CASE
                WHEN MIN(p.dataDeValidade) < CURDATE() THEN 'Vencido'
                WHEN DATEDIFF(MIN(p.dataDeValidade), CURDATE()) <= 60 THEN 'Próximo do vencimento'
                ELSE 'Válido'
            END AS status_validade
        FROM tbprodutos p
        INNER JOIN tblista l ON l.codList = p.codList
        INNER JOIN tbunidade u ON u.codUni = l.codUni
        WHERE
            (@busca = '' OR l.descricao LIKE @buscaPattern OR p.codProd LIKE @buscaPattern)
            AND (@unidade = '' OR u.descricao = @unidade)
            AND (@validade IS NULL OR DATE(p.dataDeValidade) = @validade)
        GROUP BY l.codList, l.descricao, u.descricao, l.peso
        HAVING
            (@status = '')
            OR (@status = 'Vencido' AND validade_minima < CURDATE())
            OR (@status = 'Próximo do vencimento' AND DATEDIFF(validade_minima, CURDATE()) <= 60 AND validade_minima >= CURDATE())
            OR (@status = 'Válido' AND DATEDIFF(validade_minima, CURDATE()) > 60)
        ORDER BY l.descricao;
        ";

            comm.CommandType = CommandType.Text;

            comm.Parameters.AddWithValue("@busca", busca ?? "");
            comm.Parameters.AddWithValue("@buscaPattern", "%" + (busca ?? "") + "%");
            comm.Parameters.AddWithValue("@validade", validade.HasValue ? validade.Value.Date : (object)DBNull.Value);
            comm.Parameters.AddWithValue("@unidade", unidade == "Selecione..." ? "" : unidade ?? "");
            comm.Parameters.AddWithValue("@status", status == "Selecione..." ? "" : status ?? "");

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                string validadeMinima = DR["validade_minima"] == DBNull.Value
                    ? ""
                    : Convert.ToDateTime(DR["validade_minima"]).ToString("dd/MM/yyyy");

                dgvEstoque.Rows.Add(
                    DR["descricao"].ToString(),
                    DR["quantidade_total"].ToString(),
                    DR["unidade"].ToString(),
                    DR["peso"].ToString(),
                    DR["status_validade"].ToString(),
                    validadeMinima
                );
            }

            DR.Close();
            DataBaseConnection.CloseConnection();
        }


        private void CarregarDadosDetalhados(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvEstoque.Rows.Clear();

            using (MySqlCommand comm = new MySqlCommand())
            {
                comm.CommandText = @"
                    SELECT
                        p.codProd,
                        l.descricao AS nomeProduto,
                        l.peso,
                        u.descricao AS unidade,
                        p.dataDeEntrada,
                        p.dataDeValidade,
                        CASE
                            WHEN p.dataDeValidade < CURDATE() THEN 'Vencido'
                            WHEN DATEDIFF(p.dataDeValidade, CURDATE()) <= 60 THEN 'Próximo do vencimento'
                            ELSE 'Válido'
                        END AS status_validade
                    FROM tbprodutos p
                    INNER JOIN tblista l ON l.codList = p.codList
                    INNER JOIN tbunidade u ON u.codUni = l.codUni
                    WHERE
                        (@busca = '' OR l.descricao LIKE @buscaPattern OR p.codProd LIKE @buscaPattern)
                        AND (@unidade = '' OR u.descricao = @unidade)
                        AND (@validade IS NULL OR DATE(p.dataDeValidade) = @validade)
                        AND (
                            @status = ''
                            OR (@status = 'Válido' AND DATEDIFF(p.dataDeValidade, CURDATE()) > 60)
                            OR (@status = 'Próximo do vencimento' AND DATEDIFF(p.dataDeValidade, CURDATE()) BETWEEN 0 AND 60)
                            OR (@status = 'Vencido' AND p.dataDeValidade < CURDATE())
                        )
                    ORDER BY l.descricao, p.dataDeValidade ASC;
                    ";
                comm.CommandType = CommandType.Text;

                comm.Parameters.AddWithValue("@busca", busca ?? "");
                comm.Parameters.AddWithValue("@buscaPattern", "%" + (busca ?? "") + "%");
                comm.Parameters.AddWithValue("@validade", validade.HasValue ? validade.Value.Date : (object)DBNull.Value);
                comm.Parameters.AddWithValue("@unidade", unidade == "Selecione..." ? "" : unidade ?? "");
                comm.Parameters.AddWithValue("@status", status == "Selecione..." ? "" : status ?? "");

                comm.Connection = DataBaseConnection.OpenConnection();

                using (MySqlDataReader DR = comm.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        string entrada = DR["dataDeEntrada"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDeEntrada"]).ToString("dd/MM/yyyy");
                        string validadeStr = DR["dataDeValidade"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDeValidade"]).ToString("dd/MM/yyyy");

                        dgvEstoque.Rows.Add(
                            DR["codProd"].ToString(),
                            DR["nomeProduto"].ToString(),
                            DR["peso"].ToString(),
                            DR["unidade"].ToString(),
                            DR["status_validade"].ToString(),
                            entrada,
                            validadeStr
                        );
                    }
                }

                DataBaseConnection.CloseConnection();
            }
        }
        private void CarregarUnidades()
        {
            cbxCategoria.Items.Clear();
            try
            {
                using (MySqlCommand comm = new MySqlCommand())
                {
                    comm.CommandText = @"SELECT descricao FROM tbunidade ORDER BY descricao ASC";
                    comm.CommandType = CommandType.Text;
                    comm.Connection = DataBaseConnection.OpenConnection();

                    using (MySqlDataReader dr = comm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cbxCategoria.Items.Add(dr["descricao"].ToString());
                        }
                    }

                    DataBaseConnection.CloseConnection();
                }

                // garante item de "nenhuma seleção"
                cbxCategoria.Items.Insert(0, "Selecione...");
                cbxCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                DataBaseConnection.CloseConnection();
                MessageBox.Show("Erro ao carregar unidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregaDados()
        {
            dgvEstoque.Rows.Clear();
            ConfigurarDataGridView(modoAgrupado);

            if (modoAgrupado)
            {
                CarregarDadosAgrupado(busca, dataValidade, unidadeEscolhida, status_validade);
            }
            else
            {
                CarregarDadosDetalhados(busca, dataValidade, unidadeEscolhida, status_validade);
            }
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // inicializa visual e dados
            ConfigurarDataGridView(modoAgrupado);
            CarregarUnidades();

            // garantir itens do status (exemplo)
            if (cbxStatus.Items.Count == 0)
            {
                cbxStatus.Items.Add("Selecione...");
                cbxStatus.Items.Add("Válido");
                cbxStatus.Items.Add("Próximo do vencimento");
                cbxStatus.Items.Add("Vencido");
            }

            cbxStatus.SelectedIndex = 0;

            // modo exibicao combo (sincronize itens com seu uso)
            if (cbxModoExibicao.Items.Count == 0)
            {
                cbxModoExibicao.Items.Add("Agrupado");
                cbxModoExibicao.Items.Add("Exibidor");
            }
            cbxModoExibicao.SelectedIndex = modoAgrupado ? 0 : 1;

            // data inicial sem checked
            dtpDataValidade.Value = DateTime.Today;
            dtpDataValidade.Checked = false;

            // carrega primeira vez
            carregaDados();
        }
        private void AplicarFiltros()
        {
            bool categoriaSelecionada = cbxCategoria.SelectedIndex > 0;
            bool statusSelecionado = cbxStatus.SelectedIndex > 0;
            bool validadeSelecionada = dtpDataValidade.Checked;
            bool nomeOuCodDigitado = !string.IsNullOrWhiteSpace(txtNomeOrCod.Text);

            if (!categoriaSelecionada && !statusSelecionado && !validadeSelecionada && !nomeOuCodDigitado)
            {
                MessageBox.Show("Nenhum filtro foi selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            busca = nomeOuCodDigitado ? txtNomeOrCod.Text.Trim() : "";
            unidadeEscolhida = categoriaSelecionada ? cbxCategoria.Text : "";
            status_validade = statusSelecionado ? cbxStatus.Text : "";
            dataValidade = validadeSelecionada ? dtpDataValidade.Value.Date : (DateTime?)null;

            carregaDados();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // se não existe coluna Editar ou estamos no modo agrupado, ignore
            if (!dgvEstoque.Columns.Contains("Editar") || modoAgrupado)
            {
                MessageBox.Show("Mude para o modo detalhado para editar um item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvEstoque.Columns["Editar"].Index == e.ColumnIndex)
            {
                var cell = dgvEstoque.Rows[e.RowIndex].Cells["CodProd"];
                if (cell == null || cell.Value == null)
                {
                    MessageBox.Show("Código do produto não encontrado nesta linha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string codigo = cell.Value.ToString();
                frmEditarEstoque f = new frmEditarEstoque(codigo);
                f.DadosAtualizados += () =>
                {
                    AtualizarStatusValidade();
                    carregaDados();
                };

                f.Show();
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            bool isClean = (cbxCategoria.SelectedIndex == 0 || cbxCategoria.SelectedIndex == -1)
                           && (cbxStatus.SelectedIndex == 0 || cbxStatus.SelectedIndex == -1)
                           && !dtpDataValidade.Checked
                           && string.IsNullOrWhiteSpace(txtNomeOrCod.Text);

            if (isClean)
            {
                MessageBox.Show("Não há filtros para limpar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // limpar
            cbxCategoria.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;
            dtpDataValidade.Value = DateTime.Today;
            dtpDataValidade.Checked = false;
            txtNomeOrCod.Clear();

            // reset globals
            busca = "";
            unidadeEscolhida = "";
            status_validade = "";
            dataValidade = null;

            carregaDados();
        }

        private void AtualizarStatusValidade()
        {
            try
            {
                using (MySqlCommand comm = new MySqlCommand())
                {
                    comm.CommandText = @"
                        UPDATE tbprodutos
                        SET status_validade =
                            CASE
                                WHEN dataDeValidade < CURDATE() THEN 'Vencido'
                                WHEN DATEDIFF(dataDeValidade, CURDATE()) BETWEEN 0 AND 60 THEN 'Próximo do vencimento'
                                ELSE 'Válido'
                            END
                        WHERE dataDeValidade IS NOT NULL;
                        ";
                    comm.CommandType = CommandType.Text;
                    comm.Connection = DataBaseConnection.OpenConnection();
                    comm.ExecuteNonQuery();
                    DataBaseConnection.CloseConnection();
                }
            }
            catch (MySqlException mex)
            {
                DataBaseConnection.CloseConnection();
                // pode ser que a coluna status_validade não exista; trate se necessário
                Console.WriteLine("AtualizarStatusValidade failed: " + mex.Message);
            }
        }
        private void btnCarregaTodosProdutos_Click(object sender, EventArgs e)
        {
            txtNomeOrCod.Clear();
            busca = "";
            carregaDados();
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeOrCod.Text))
            {
                MessageBox.Show("Digite o nome ou código do produto para pesquisar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AplicarFiltros();
        }

        private void btnAplicarModoExibicao_Click(object sender, EventArgs e)
        {
            modoAgrupado = !modoAgrupado;

            // Combo mostra o modo atual
            cbxModoExibicao.Text = modoAgrupado ? "Agrupado" : "Exibidor";

            // Botão mostra para onde vai (inverter)
            btnAplicarModoExibicao.Text = modoAgrupado ? "Modo Exibidor" : "Modo Agrupado";

            carregaDados();
        }

    }
}
