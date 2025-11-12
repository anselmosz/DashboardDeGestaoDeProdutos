using MySql.Data.MySqlClient;
using Projeto_Socorrista;
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
    public partial class frmGestaoDeVoluntarios : Form
    {
        public frmGestaoDeVoluntarios()
        {
            InitializeComponent();
        }

        private void ConfigurarDataGridViewDaListaDeVoluntarios()
        {
            // Ajustar para ocupar toda a largura
            dgvListaDeVoluntarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Alternar cores das linhas
            dgvListaDeVoluntarios.RowsDefaultCellStyle.BackColor = Color.LightGray;
            // Aumentar fonte
            dgvListaDeVoluntarios.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvListaDeVoluntarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            // Ajustar altura das linhas
            dgvListaDeVoluntarios.RowTemplate.Height = 40;
            // Habilitar quebra de texto
            dgvListaDeVoluntarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Adicionar botões na coluna Ações
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvListaDeVoluntarios.Columns.Add(btnEditar);
            // Ajustar a coluna Quantidade para edição
            dgvListaDeVoluntarios.Columns[3].ReadOnly = false;
            // Ajustar seleção de célula
            dgvListaDeVoluntarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDeVoluntarios.MultiSelect = false;
        }

        private void CarregarDadosNaListaDeVoluntarios()
        {
            dgvListaDeVoluntarios.Columns.Clear();

            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT vol.codVol as 'codigo', vol.nome AS 'Nome do voluntario', usr.email AS 'Email', vol.telCel AS 'Telefone' FROM tbusuarios AS usr INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol ORDER BY vol.nome ASC;");

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conexao;

                comm.CommandText = query.ToString();

                MySqlDataAdapter DA = new MySqlDataAdapter(comm);
                DA.Fill(tabela);

                dgvListaDeVoluntarios.DataSource = tabela;
                dgvListaDeVoluntarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DataBaseConnection.CloseConnection();
            }
        }

        private void frmVoluntarios_Load(object sender, EventArgs e)
        {
            CarregarDadosNaListaDeVoluntarios();
            ConfigurarDataGridViewDaListaDeVoluntarios();
        }

        private void dgvListaDeVoluntarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListaDeVoluntarios.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                // Obter o código do produto da linha selecionada
                string rowData = dgvListaDeVoluntarios.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                frmEditarEstoque f = new frmEditarEstoque(rowData);
                f.DadosAtualizados += () =>
                {
                };

                f.Show();
            }
            else
            {
                MessageBox.Show("Clique no botão 'Editar' para mudar os dados do item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
