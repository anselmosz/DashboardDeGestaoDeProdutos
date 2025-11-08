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
            dgvRelatorio.Columns.Clear();

            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT prod.nome AS NomeProduto, prod.quantidade AS Quantidade, CONCAT(prod.peso,' ', prod.unidade) AS PesoFormatado, prod.dataDeEntrada, prod.dataDeValidade, vol.nome AS QuemCadastrou FROM tbprodutos AS prod INNER JOIN tbUsuarios AS usr ON prod.codUsu = usr.codUsu INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol ORDER BY prod.dataDeEntrada DESC;");

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


        public DataTable BuscarProdutos(FiltroDeBuscaBD filtro)
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT prod.nome AS NomeProduto, prod.quantidade AS Quantidade, CONCAT(prod.peso,' ', prod.unidade) AS PesoFormatado, prod.dataDeEntrada, prod.dataDeValidade, vol.nome AS QuemCadastrou FROM tbprodutos AS prod INNER JOIN tbUsuarios AS usr ON prod.codUsu = usr.codUsu INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol WHERE 1=1 ");

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
                    query.Append("AND usr.nome = @nomeUsuario ");
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

            DataTable resultado = BuscarProdutos(novoFiltro);
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
