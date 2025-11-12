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
        public frmEstoque()
        {
            InitializeComponent();
        }


        private void configDataGridView()
        {
            // Ajustar para ocupar toda a largura
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Alternar cores das linhas
            dgvEstoque.RowsDefaultCellStyle.BackColor = Color.LightGray;
            // Aumentar fonte
            dgvEstoque.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            // Ajustar altura das linhas
            dgvEstoque.RowTemplate.Height = 40;
            // Habilitar quebra de texto
            dgvEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Adicionar botões na coluna Ações
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvEstoque.Columns.Add(btnEditar);
            // Ajustar a coluna Quantidade para edição
            dgvEstoque.Columns[3].ReadOnly = false;
            // Ajustar seleção de célula
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.MultiSelect = false;
        }
        private void carregaDados(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvEstoque.Rows.Clear();

            MySqlCommand comm = new MySqlCommand();

            // [COLOCAR A NOVA QUERY SQL AQUI]
            comm.CommandText = @"SELECT 
                            nome, 
                            COUNT(*) AS quantidade_total,
                            peso, 
                            unidade,
                            MIN(dataDeValidade) AS validade_minima,
                            MIN(dataLimiteDeSaida) AS saida_limite_minima,
                            CASE 
                                WHEN MIN(dataDeValidade) > NOW() THEN 'Válido' 
                                ELSE 'Vencido' 
                            END AS status_validade_lote 
                         FROM 
                            tbProdutos
                         WHERE 
                            (@busca = '' OR nome LIKE @buscaPattern)
                            AND (@unidade = '' OR unidade = @unidade)
                            AND (@validade IS NULL OR DATE(dataDeValidade) = @validade)
                            AND (@status = '' OR (@status = 'Válido' AND dataDeValidade > NOW()) OR (@status = 'Vencido' AND dataDeValidade <= NOW()))
                         GROUP BY
                            nome, peso, unidade
                         ORDER BY 
                            nome;";

            comm.CommandType = CommandType.Text;

            // Parameters (permanecem os mesmos)
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
                // 1. Lendo e formatando a data de validade MÍNIMA
                string validadeMinimaFormatada = DR["validade_minima"] == DBNull.Value ? "" : Convert.ToDateTime(DR["validade_minima"]).ToString("dd/MM/yyyy");

                // 2. Lendo e formatando a data limite de saída MÍNIMA
                string dataLimiteSaidaMinimaFormatada = DR["saida_limite_minima"] == DBNull.Value ? "" : Convert.ToDateTime(DR["saida_limite_minima"]).ToString("dd/MM/yyyy");

                // Adicionando ao DataGridView
                dgvEstoque.Rows.Add(
                    "LOTE",                                
                    DR["nome"].ToString(),                  
                    DR["quantidade_total"].ToString(),     
                    DR["unidade"].ToString(),           
                    DR["peso"].ToString(),                  
                    DR["status_validade_lote"].ToString(),  
                    dataLimiteSaidaMinimaFormatada          // dataLimiteDeSaida (Agora é a data mínima)
                );
            }

            DR.Close();
            DataBaseConnection.CloseConnection();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        { 
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            configDataGridView();
            cbxCategoria.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;  
            dtpDataValidade.Value = DateTime.Today;
            dtpDataValidade.Checked = false; 
            AplicarFiltros();
        }
        string unidades;
        string unidadeEscolhida;
        string status_validade;
        DateTime? dataValidade = null;

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedIndex == 0 && cbxStatus.SelectedIndex == 0 && dtpDataValidade.Value == DateTime.Today)
            {
                MessageBox.Show("Não há filtros para busca", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            unidades = cbxCategoria.Text;
            status_validade = cbxStatus.Text;

            switch (unidades) {
                case "Quilogramas (kg)":
                    unidadeEscolhida = "kg";
                    break;
                case "Gramas (g)":
                    unidadeEscolhida = "g";
                    break;
                case "Litros (l)":   
                    unidadeEscolhida = "L";
                    break;

                case "Mililitros (ml)":
                    unidadeEscolhida = "ml";
                    break;
                case "Unidades":
                    unidadeEscolhida = "unidades";
                    break;
                case "Caixas":
                    unidadeEscolhida = "Caixas";
                    break;
                default:
                    unidadeEscolhida = "";  
                    break;
            }

            if (dtpDataValidade.Value.Date != DateTime.Today)
            {
                dataValidade = dtpDataValidade.Value.Date;
            }

            carregaDados(txtNomeOrCod.Text, dataValidade, unidadeEscolhida, status_validade);
        }

        private void AplicarFiltros()
        {
            string busca = txtNomeOrCod.Text.Replace(" ", "");

            DateTime? validade = null;
            if (dtpDataValidade.Checked)
            {
                validade = dtpDataValidade.Value.Date;
            }

            string unidades = cbxCategoria.Text;
            string status_validade = cbxStatus.Text;
            string unidadeEscolhida = "";

            switch (unidades)
            {
                case "Quilogramas (kg)":
                    unidadeEscolhida = "kg";
                    break;
                case "Gramas (g)":
                    unidadeEscolhida = "g";
                    break;
                case "Litros (l)":
                    unidadeEscolhida = "litros";
                    break;
                case "Mililitros (ml)":
                    unidadeEscolhida = "ml";
                    break;
                case "Unidades":
                    unidadeEscolhida = "unidades";
                    break;
                case "Caixas":
                    unidadeEscolhida = "Caixas";
                    break;
                default:
                    unidadeEscolhida = "";
                    break;
            }
            carregaDados(busca, validade, unidadeEscolhida, status_validade);
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header row
            {
                if (e.ColumnIndex == dgvEstoque.Columns["Editar"].Index)
                {
                    // Obter o código do produto da linha selecionada
                    string codProd = dgvEstoque.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    frmEditarEstoque f = new frmEditarEstoque(codProd);
                    f.DadosAtualizados += () =>
                    {
                        AtualizarStatusValidade();
                        carregaDados();
                    };

                    f.Show();
                }
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
            if (txtNomeOrCod.Text.Equals("")) {
                MessageBox.Show("Informe um nome ou um código para busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AplicarFiltros();
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
    }
}
