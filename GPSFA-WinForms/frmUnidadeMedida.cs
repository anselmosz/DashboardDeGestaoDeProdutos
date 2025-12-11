using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmUnidadeMedida : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmUnidadeMedida()
        {
            InitializeComponent();
            desativarBotoes();
            desativaCampos();
        }

        public frmUnidadeMedida(string descricao)
        {
            InitializeComponent();                   
            buscaCodigoUnidade(descricao);
            txtDescricao.Text = descricao;
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
           
        }

        int codUni = 0; 

        public void buscaCodigoUnidade(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT codUni FROM tbUnidades WHERE descricao LIKE '%{descricao}%';";

            comm.CommandType = CommandType.Text;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            codUni = 0;

            while (DR.Read())
            {               
                codUni = DR.GetInt32(0);
            }

            DataBaseConnection.CloseConnection();
        }
               
        private int excluirUnidade(int codUni)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbUnidades WHERE codUni = " +codUni;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();            

            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnCadastrar.Enabled = false;
            btnNovo.Enabled = true;
            btnLimpar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtDescricao.Enabled = false;
        }

        private void limparCampos()
        {
           txtDescricao.Clear();
           txtDescricao.Focus();
        }

        private void desativarBotoes()
        {
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;        
        } 

        public int cadastrarUnidades(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbUnidades(descricao)VALUES(@descricao);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 20).Value = descricao;           

            comm.Connection = DataBaseConnection.OpenConnection();

            try
            {
                int resp = comm.ExecuteNonQuery();
                
                DataBaseConnection.CloseConnection();

                return resp;
            }
            catch (Exception)
            {
                MessageBox.Show("Este registro já existe!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);                 
            }
            return 0;
        }
       

        private int alterarUnidadeDeMedida(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbUnidades SET descricao = @descricao WHERE codUni = " + codUni;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 20).Value = descricao;
           

            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;

        }
        private int BuscaUnidade(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT descricao FROM tbUnidades WHERE descricao LIKE '%{descricao}%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 20).Value = descricao;


            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;
        }


        private void desativarBotoesNovo()
        {
            btnNovo.Enabled = false;
        }

        private void habilitarBotoes()
        {
            btnCadastrar.Enabled = true;           
            btnLimpar.Enabled = true;           
        }

        private void desativaCampos()
        {
            txtDescricao.Enabled = false; 
        }

        private void habilitaCampos()
        {
            txtDescricao.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerenciarProdutos abrir = new frmGerenciarProdutos();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarBotoes();
            desativarBotoesNovo();
            habilitaCampos();
            txtDescricao.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else if (BuscaUnidade(txtDescricao.Text).Equals(1))
            {
                MessageBox.Show("Este registro já existe!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else
            {

                int resp = cadastrarUnidades(txtDescricao.Text.Trim());

                if (resp.Equals(1))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desativarBotoes();
                    txtDescricao.Clear();
                    txtDescricao.Enabled = false;
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    limparCampos();
                    btnCadastrar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    txtDescricao.Enabled = false;

                }
            }
        }
       
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUnidadeDeMedida abrir = new frmPesquisarUnidadeDeMedida();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarUnidadeDeMedida(txtDescricao.Text).Equals(1))
            {

                MessageBox.Show("Unidade alterada com sucesso!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                limparCampos();
                btnLimpar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro ao alterar!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                limparCampos();
                btnLimpar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?", "Mensagem do Sistema",
              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result.Equals(DialogResult.Yes))
            {
                int resp = excluirUnidade(codUni);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Excluido com Sucesso!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);                   
                    txtDescricao.Clear();
                    txtDescricao.Focus();
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    txtDescricao.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtDescricao.Clear();
                    txtDescricao.Focus();
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    txtDescricao.Enabled = false;
                }
            }            
        }
        private void frmUnidadeMedida_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
    }

