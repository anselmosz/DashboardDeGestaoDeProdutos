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
            carregarUsuários();
            dtpDataInicialPeriodo.Enabled = false;
            dtpDataFinalPeriodo.Enabled = false;
            cbbUsuarios.SelectedIndex = 0;
            cbbUsuarios.Enabled = false;
        }

        // Carrega no datagrid view os últimos produtos adicionados no banco
        private void CarregarDadosNaListaDeProdutos()
        {
            dgvRelatorio.Columns.Clear();

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

                dgvRelatorio.DataSource = tabela;
                dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataBaseConnection.CloseConnection();
            }
        }


        public DataTable BuscarProdutosPorFiltro(FiltroDeBuscaBD filtro)
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT prod.nome AS 'Nome do Produto', prod.quantidade AS 'Quantidade', CONCAT(prod.peso,' ', prod.unidade) AS 'Peso', prod.dataDeEntrada AS 'Data de Cadastro', prod.dataDeValidade AS 'Data de Validade', vol.nome AS 'Quem Cadastrou' FROM tbprodutos AS prod INNER JOIN tbUsuarios AS usr ON prod.codUsu = usr.codUsu INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol WHERE 1=1 ");

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conexao;

                if (filtro.FiltrarPorPeriodo)
                {
                    query.Append("AND prod.dataDeEntrada BETWEEN @dataInicial AND @dataFinal ");
                    comm.Parameters.AddWithValue("@dataInicial", filtro.DataInicial);
                    comm.Parameters.AddWithValue("@dataFinal", filtro.DataFinal);
                }

                if (filtro.FiltrarPorUsuario && !string.IsNullOrEmpty(filtro.NomeUsuario))
                {
                    query.Append("AND vol.nome = @nomeUsuario ");
                    comm.Parameters.AddWithValue("@nomeUsuario", filtro.NomeUsuario);
                }

                query.Append("ORDER BY prod.dataDeEntrada DESC;");

                comm.CommandText = query.ToString();

                MySqlDataAdapter DA = new MySqlDataAdapter(comm);
                DA.Fill(tabela);
            }

            return tabela;
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            dgvRelatorio.Columns.Clear();

            FiltroDeBuscaBD novoFiltro = new FiltroDeBuscaBD
            {
                FiltrarPorPeriodo = chkbDataEntrada.Checked,
                DataInicial = dtpDataInicialPeriodo.Value.ToString("yyyy-MM-dd"),
                DataFinal = dtpDataFinalPeriodo.Value.ToString("yyyy-MM-dd"),

                FiltrarPorUsuario = chkbListaUsuarios.Checked,
                NomeUsuario = cbbUsuarios.SelectedItem.ToString(),
            };

            DataTable resultado = BuscarProdutosPorFiltro(novoFiltro);
            dgvRelatorio.DataSource = resultado;
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataBaseConnection.CloseConnection();
        }

        private void limparFiltros()
        {
            dtpDataInicialPeriodo.Value = DateTime.Now;
            dtpDataFinalPeriodo.Value = DateTime.Now;
            cbbUsuarios.SelectedIndex = 0;
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
                cbbUsuarios.Items.Add(DR.GetString(0));
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
                cbbUsuarios.Enabled = true;
                cbbUsuarios.Items.Remove("Todos");
            }
            else
            {
                cbbUsuarios.Enabled = false;
                cbbUsuarios.Items.Insert(0, "Todos");
                cbbUsuarios.SelectedIndex = 0;
            }
        }
    }
}
