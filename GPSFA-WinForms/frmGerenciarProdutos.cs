using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmGerenciarProdutos : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarProdutos()
        {
            InitializeComponent();
        }

        private void frmCadastrarAlimentos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            //carregaProdutosNaLista();
            limparCamposDeCadastro();
            //CarregarListaProdutos();
            //cbbTipoDoacao.SelectedIndex = 0;
            cbbUnidadeMedida.SelectedIndex = 0;
        }

        private int enviarDoacoes(string nomeProduto, int quantidade, int peso, string unidadeMedida, string codBar, DateTime dataArrecadacao, DateTime dataDeValidade, DateTime dataLimiteDeSaida, int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"INSERT INTO tbProdutos(
                                nome,
                                quantidade,
                                peso,
                                unidade,
                                codBar,
                                dataDeEntrada,
                                dataDeValidade,
                                dataLimiteDeSaida,
                                codUsu) 
                                VALUES(
                                @nome, 
                                @quantidade, 
                                @peso, 
                                @unidade,
                                @codBar,
                                @dataArrecadacao, 
                                @dataDeValidade, 
                                @dataLimiteDeSaida, 
                                @codUsu);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeProduto;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@peso", MySqlDbType.Int32).Value = peso;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 5).Value = unidadeMedida;
            comm.Parameters.Add("@codBar", MySqlDbType.VarChar, 13).Value = codBar;
            comm.Parameters.Add("@dataArrecadacao", MySqlDbType.Date).Value = dataArrecadacao;
            comm.Parameters.Add("@dataDeValidade", MySqlDbType.Date).Value = dataDeValidade;
            comm.Parameters.Add("@dataLimiteDeSaida", MySqlDbType.VarChar, 300).Value = dataLimiteDeSaida;
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = codUsu;

            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();


            DataBaseConnection.CloseConnection();

            limparCamposDeCadastro();

            return resp;
        }
       

        private bool VerificaFormatacaoDosCampos()
        {
            DateTime.TryParse(dtpDataEntrada.Text, out DateTime dataRecebimento);
            if (dataRecebimento > DateTime.Today)
            {
                MessageBox.Show("Você inseriu uma data futura", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataEntrada.Focus();
                return false;
            }

            DateTime.TryParse(dtpDataValidade.Text, out DateTime dataValidade);

            if (dataValidade < DateTime.Now.AddMonths(-3))
            {
                MessageBox.Show("O periodo para cadastro de doação excedeu!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataEntrada.Focus();
                return false;
            }

            if (Regex.IsMatch(txtQuantidade.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Quantidade inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return false;
            }
            return true;
        }

        private string SimplificarUnidade(string unidadeSelecionada)
        {
            switch (unidadeSelecionada)
            {
                case "Quilogramas (Kg)":
                    return "Kg";
                case "Gramas (g)":
                    return "g";
                case "Litros (L)":
                    return "L";
                case "Mililitros (ml)":
                    return "ml";
                case "Unidades (und)":
                    return "und";
                case "Caixas (cx)":
                    return "cx";
                default:
                    return "";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeDoItem.Text.Equals("") || txtQuantidade.Text.Equals(""))
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificaFormatacaoDosCampos())
            {
                return;
            }
            string nomeItem = txtNomeDoItem.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            int peso = Convert.ToInt32(txtPeso.Text);
            string tipoUnidade = SimplificarUnidade(cbbUnidadeMedida.Text);
            string codBar = txtCodBarras.Text;
            DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
            DateTime dataValidade = Convert.ToDateTime(dtpDataValidade.Text);
            DateTime dataLimiteDeSaida = dataValidade.AddDays(21);
            int codUsu = 1;

            if (enviarDoacoes(nomeItem, quantidade, peso, tipoUnidade, codBar, dataRecebimento, dataValidade, dataLimiteDeSaida, codUsu) == 1)
            {
                MessageBox.Show("Doação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dgvProdutos.Columns.Clear();
                //CarregarListaProdutos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar doação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCamposDeCadastro();
            }

            //dgvProdutos.Columns.Clear();
            //CarregarListaProdutos();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            //dgvRegistro.Rows.Clear();
            //CarregarListaProdutos();
            limparCamposDeCadastro();
            //carregaProdutosNaLista();
        }

        public void limparCamposDeCadastro()
        {
            txtNomeDoItem.Clear();
            txtQuantidade.Clear();
            dtpDataValidade.Value = DateTime.Now;
            DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
            dtpDataValidade.Value = DateTime.Now;
            cbbUnidadeMedida.SelectedIndex = 0;
            txtPeso.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Close();
        }
    }
}
