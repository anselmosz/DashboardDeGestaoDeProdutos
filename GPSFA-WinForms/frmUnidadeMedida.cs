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
    public partial class frmUnidadeMedida : Form
    {
        public frmUnidadeMedida()
        {
            InitializeComponent();
            desativarBotoes();
            desativaCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
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
            comm.CommandText = "INSERT INTO tbUnidade(descricao)VALUES(@descricao);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 20).Value = descricao;           

            comm.Connection = DataBaseConnection.OpenConnection();


            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;
        }

        public int excluirUnidades(int codUni)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbUnidades WHERE codUni=@codUni;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUni", MySqlDbType.Int32).Value = codUni;


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
                MessageBox.Show("Favor inserir valores", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else
            {
                int resp = cadastrarUnidades(txtDescricao.Text);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desativarBotoes();
                    txtDescricao.Clear();
                    btnNovo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    limparCampos();

                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //    DialogResult dr = MessageBox.Show("Deseja excluir?",
            //        "Mensagem do sistema",
            //        MessageBoxButtons.OKCancel,
            //        MessageBoxIcon.Question,
            //        MessageBoxDefaultButton.Button2);

            //    if (dr.Equals(DialogResult.OK))
            //    {

            //        int resp = excluirUnidades(Convert.ToInt32(txtCodigo.Text));
            //        if (resp.Equals(1))
            //        {
            //            MessageBox.Show("Excluido com sucesso!",
            //        "Mensagem do sistema",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information,
            //        MessageBoxDefaultButton.Button1);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Erro ao excluir",
            //        "Mensagem do sistema",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error,
            //        MessageBoxDefaultButton.Button1);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erro ao excluir",
            //        "Mensagem do sistema",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error,
            //        MessageBoxDefaultButton.Button1);
            //    }
        }
    }
    }

