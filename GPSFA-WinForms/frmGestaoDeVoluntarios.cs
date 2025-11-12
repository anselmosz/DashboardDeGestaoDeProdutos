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
    public partial class frmGestaoDeVoluntarios : Form
    {
        public frmGestaoDeVoluntarios()
        {
            InitializeComponent();
        }

        private void CarregarDadosNaListaDeVoluntarios()
        {
            dgvListaDeVoluntarios.Columns.Clear();

            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DataBaseConnection.OpenConnection())
            {
                StringBuilder query = new StringBuilder();

                query.Append("SELECT vol.nome AS 'Nome do voluntario', usr.email AS 'Email', vol.telCel AS 'Telefone' FROM tbusuarios AS usr INNER JOIN tbvoluntarios AS vol ON usr.codVol = vol.codVol ORDER BY vol.nome ASC;");

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
        }
    }
}
