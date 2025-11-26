using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx;
using Projeto_Socorrista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmRelatorios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // Carrega no datagrid view os últimos produtos adicionados no banco
            CarregarDadosNaListaDeProdutos();
            carregarUsuários();
            ConfigDGVRelatorios();
            dtpDataInicialPeriodo.Enabled = false;
            dtpDataFinalPeriodo.Enabled = false;
            cbbListaDeUsuarios.SelectedIndex = 0;
            cbbListaDeUsuarios.Enabled = false;
        }

        private void ConfigDGVRelatorios()
        { // Ajustar para ocupar toda a largura
            dgvRelatorioDeProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Alternar cores das linhas
            dgvRelatorioDeProdutos.RowsDefaultCellStyle.BackColor = Color.LightGray;
            // Aumentar fonte
            dgvRelatorioDeProdutos.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvRelatorioDeProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            // Ajustar altura das linhas
            dgvRelatorioDeProdutos.RowTemplate.Height = 40;
            // Habilitar quebra de texto
            dgvRelatorioDeProdutos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Ajustar seleção de célula
            dgvRelatorioDeProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorioDeProdutos.MultiSelect = false;
        }

        // Carrega no datagrid view os últimos produtos adicionados no banco
        private void CarregarDadosNaListaDeProdutos()
        {
            dgvRelatorioDeProdutos.Columns.Clear();

            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT prod.nome AS 'Nome do Produto', prod.quantidade AS 'Quantidade', CONCAT(prod.peso,' ', prod.unidade) AS 'Peso', prod.dataDeEntrada AS 'Data de Cadastro', prod.dataDeValidade AS 'Data de Validade', vol.nome AS 'Quem Cadastrou' FROM tbprodutos AS prod INNER JOIN tbUsuarios AS usr ON prod.codUsu = usr.codUsu INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol ORDER BY prod.dataDeEntrada DESC;");

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conexao;

                comm.CommandText = query.ToString();

                MySqlDataAdapter DA = new MySqlDataAdapter(comm);
                DA.Fill(tabela);

                dgvRelatorioDeProdutos.DataSource = tabela;

                dgvRelatorioDeProdutos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DataBaseConnection.CloseConnection();
            }
        }


        public DataTable BuscarProdutosPorFiltro(params FiltroDeBuscaBD[] filtros)
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT prod.nome AS 'Nome do Produto', prod.quantidade AS 'Quantidade', CONCAT(prod.peso,' ', prod.unidade) AS 'Peso', prod.dataDeEntrada AS 'Data de Cadastro', prod.dataDeValidade AS 'Data de Validade', vol.nome AS 'Quem Cadastrou' FROM tbprodutos AS prod INNER JOIN tbUsuarios AS usr ON prod.codUsu = usr.codUsu INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol WHERE 1=1 ");

                using (MySqlCommand comm = new MySqlCommand())
                {
                    comm.Connection = conexao;
                    int paramCount = 0;

                    foreach (var filtro in filtros)
                    {
                        // Filtro por período
                        if (filtro.FiltrarPorPeriodo && !string.IsNullOrEmpty(filtro.DataInicial) && !string.IsNullOrEmpty(filtro.DataFinal))
                        {
                            string paramInicio = "@dataInicio" + paramCount;
                            string paramFim = "@dataFim" + paramCount;
                            query.Append($" AND prod.dataDeEntrada BETWEEN {paramInicio} AND {paramFim} ");

                            comm.Parameters.AddWithValue(paramInicio, filtro.DataInicial);
                            comm.Parameters.AddWithValue(paramFim, filtro.DataFinal);
                            paramCount++;
                        }

                        // Filtro por voluntário
                        if (filtro.FiltrarPorUsuario && !string.IsNullOrEmpty(filtro.NomeUsuario))
                        {
                            string paramNome = "@nomeUsuario" + paramCount;
                            query.Append($" AND vol.nome LIKE {paramNome} ");
                            comm.Parameters.AddWithValue(paramNome, "%" + filtro.NomeUsuario + "%");
                            paramCount++;
                        }
                    }
                    query.Append(" ORDER BY prod.dataDeEntrada DESC;");

                    comm.CommandText = query.ToString();
                    using(MySqlDataAdapter DA = new MySqlDataAdapter(comm))
                    {
                        DA.Fill(tabela);
                    }
                }
            }
            return tabela;
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            dgvRelatorioDeProdutos.Columns.Clear();

            try
            {
                if (cbbListaDeUsuarios.SelectedItem == null)
                {
                    MessageBox.Show($"Selecione uma opção válida da lista para usar o filtro", "Erro do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limparFiltros();
                    CarregarDadosNaListaDeProdutos();
                }
                else
                {
                    FiltroDeBuscaBD filtroDeData = new FiltroDeBuscaBD
                    {
                        FiltrarPorPeriodo = chkbDataEntrada.Checked,
                        DataInicial = dtpDataInicialPeriodo.Value.ToString("yyyy-MM-dd"),
                        DataFinal = dtpDataFinalPeriodo.Value.ToString("yyyy-MM-dd"),
                    };
                    
                    FiltroDeBuscaBD filtroDeVoluntario = new FiltroDeBuscaBD
                    {
                        FiltrarPorUsuario = chkbListaUsuarios.Checked,
                        NomeUsuario = cbbListaDeUsuarios.SelectedItem.ToString(),
                    };

                    DataTable resultado = BuscarProdutosPorFiltro(filtroDeData, filtroDeVoluntario);
                    dgvRelatorioDeProdutos.DataSource = resultado;
                    dgvRelatorioDeProdutos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception error) {
                MessageBox.Show($"Erro: {error}", "Erro do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparFiltros();
            }
            DataBaseConnection.CloseConnection();
        }

        private void limparFiltros()
        {
            dtpDataInicialPeriodo.Value = DateTime.Now;
            dtpDataFinalPeriodo.Value = DateTime.Now;
            cbbListaDeUsuarios.SelectedIndex = 0;
            chkbDataEntrada.Checked = false;
            chkbListaUsuarios.Checked = false;
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            CarregarDadosNaListaDeProdutos();
            limparFiltros();
        }

        private void carregarUsuários()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "SELECT nome FROM tbvoluntarios ORDER BY nome DESC;";

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbListaDeUsuarios.Items.Add(DR.GetString(0));
            }

            DataBaseConnection.CloseConnection();
        }

        private void chkbDataEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbDataEntrada.Checked)
            {
                dtpDataInicialPeriodo.Enabled = true;
                dtpDataFinalPeriodo.Enabled = true;
            }
            else
            {
                dtpDataInicialPeriodo.Enabled = false;
                dtpDataFinalPeriodo.Enabled = false;
                dtpDataInicialPeriodo.Value = DateTime.Now;
                dtpDataFinalPeriodo.Value = DateTime.Now;

            }
        }

        private void chkbListaUsuarios_CheckedChanged (object sender, EventArgs e)
        {
            if (chkbListaUsuarios.Checked)
            {
                cbbListaDeUsuarios.Enabled = true;
                cbbListaDeUsuarios.Items.Remove("Todos");
            }
            else
            {
                cbbListaDeUsuarios.Enabled = false;
                cbbListaDeUsuarios.Items.Insert(0, "Todos");
                cbbListaDeUsuarios.SelectedIndex = 0;
            }
        }

        private void btnExportarRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Close();
        }
    }
}
