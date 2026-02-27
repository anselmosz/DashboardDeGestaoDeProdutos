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
using MySql.Data.MySqlClient;

namespace GPSFA_WinForms
{
    public partial class frmOrigemDoacao : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmOrigemDoacao()
        {
            InitializeComponent();
            desativarBotoes();
            desativarCampos();
        }

        // Variavel global do código do usuário logado
        int codUsuLogado;

        public frmOrigemDoacao(int codUsu)
        {   
            codUsuLogado = codUsu;
            InitializeComponent();
            desativarBotoes();
            desativarCampos();
        }

        public frmOrigemDoacao(string nome, string cpf, string cnpj, string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado, string telCel, string referencia)
        {            
            InitializeComponent();
            buscaCodigoOrigem(nome);
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            txtNomeFornecedor.Text = nome;
            mskCpf.Text = cpf;
            mskCnpj.Text = cnpj;
            mskCep.Text = cep;
            txtRua.Text = rua;
            txtNumero.Text = numero;
            txtComplemento.Text = complemento;
            txtBairro.Text = bairro;
            cbbCidade.Text = cidade;
            cbbEstado.Text = estado;
            mskTelefone.Text = telCel;
            txtReferencia.Text = referencia;
            mskCnpj.Enabled = false;
            mskCpf.Enabled = false;
        }

        public frmOrigemDoacao(string nome)
        {
            InitializeComponent();
            buscaCodigoOrigem(nome); 
            txtNomeFornecedor.Text = nome;
            buscaOrigemDoacao(nome);
            desativarBotoes();            
            btnNovo.Enabled = false;
            btnAlterar.Enabled = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        // Criando método de pesquisa com o parametro NOME da vindo da janela anterior

        int respBuscar;

        public int buscaOrigemDoacao(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT nome, cpf, cnpj, cep, rua, numero, complemento, bairro, cidade, estado, telCel, referencia FROM tborigemdoacao WHERE nome LIKE '%{nome}%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = DataBaseConnection.OpenConnection();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();


            if (DR.HasRows == false)
            {
                MessageBox.Show("Nenhuma origem encontrada com este valor.",
                    "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);               
                limparCamposNovo();
            }
            else
            {
                while (DR.Read())
                {
                    txtNomeFornecedor.Text = (DR.GetString(0));

                    try
                    {
                        mskCpf.Text = DR.GetString(1);
                        mskCpf.Enabled = false;
                    }
                    catch (Exception)
                    {                       
                        mskCpf.Enabled = false;                        
                    }
                    try
                    {
                        mskCnpj.Text = DR.GetString(2);
                        mskCnpj.Enabled = false;
                    }
                    catch (Exception)
                    {
                        mskCnpj.Enabled = false;                        
                    }

                    mskCep.Text = DR.GetString(3);
                    txtRua.Text = DR.GetString(4);
                    txtNumero.Text = DR.GetString(5);
                    txtComplemento.Text = DR.GetString(6);
                    txtBairro.Text = DR.GetString(7);
                    cbbCidade.Items.Add(DR.GetString(8));
                    cbbEstado.Items.Add(DR.GetString(9));
                    mskTelefone.Text = DR.GetString(10);
                    txtReferencia.Text = DR.GetString(11);
                }
            }
            DataBaseConnection.CloseConnection();
            return respBuscar;
        }

        private int excluirOrigem(int codOri)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tborigemdoacao WHERE codOri = " + codOri;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;
        }

        int codOri = 0;


        int respAlterar = 0;
        private int alterarOrigemDoacao(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tborigemdoacao SET nome = @nome WHERE codOri = " + codOri;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;


            comm.Connection = DataBaseConnection.OpenConnection();

            try
            {
                respAlterar = comm.ExecuteNonQuery();
                DataBaseConnection.CloseConnection();
            }

            catch (Exception)
            {
                MessageBox.Show("Este registro já existe!", "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                txtNomeFornecedor.Enabled = false;
            }

            return respAlterar;

        }

        public void buscaCodigoOrigem(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT codOri FROM tborigemdoacao WHERE nome LIKE '%{nome}%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            codOri = 0;

            while (DR.Read())
            {
                codOri = DR.GetInt32(0);
            }

            DataBaseConnection.CloseConnection();
        }

        public void desativarBotoes()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;           
        }

        public void desativarCampos()
        {
            txtNomeFornecedor.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtReferencia.Enabled = false;
            mskCep.Enabled = false;
            mskTelefone.Enabled = false;
            mskCpf.Enabled = false;
            mskCnpj.Enabled = false;
            cbbEstado.Enabled = false;
            cbbCidade.Enabled = false;
            rdbCpf.Enabled = false;
            rdbCnpj.Enabled = false;
        }

        public void habilitaCampos()
        {
            txtNomeFornecedor.Enabled = true;
            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtReferencia.Enabled = true;
            mskCep.Enabled = true;
            mskTelefone.Enabled = true;
            mskCpf.Enabled = false;
            mskCnpj.Enabled = false;
            cbbEstado.Enabled = true;
            cbbCidade.Enabled = true;
            rdbCpf.Enabled = true;
            rdbCnpj.Enabled = true;
        }

        public void limparCampos()
        {
            txtNomeFornecedor.Clear();            
        }

        public void limparCamposNovo()
        {
            txtNomeFornecedor.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtReferencia.Clear();
            mskCep.Clear();
            mskTelefone.Clear();
            mskCpf.Clear();
            mskCnpj.Clear();
            cbbEstado.Text = "";
            cbbCidade.Text = "";         
        }

        public int cadastrarFornecedores(string nome, string cpf, string cnpj, string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado, string telCel, string referencia)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO TBOrigemDoacao(nome, cpf, cnpj, cep, rua, numero, complemento, bairro, cidade, estado, telCel, referencia)VALUES(@nome, @cpf, @cnpj, @cep, @rua, @numero, @complemento, @bairro, @cidade, @estado, @telCel, @referencia);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = cpf;
            comm.Parameters.Add("@cnpj", MySqlDbType.VarChar, 18).Value = cnpj;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@rua", MySqlDbType.VarChar, 100).Value = rua;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = complemento;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@referencia", MySqlDbType.VarChar, 200).Value = referencia;            

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

        private void frmOrigemDoacao_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
           
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerenciarProdutos abrir = new frmGerenciarProdutos(codUsuLogado);
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
            txtNomeFornecedor.Focus();
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        private void rdbCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCpf.Checked.Equals(true))
            {
                mskCpf.Enabled = true;
                mskCpf.Focus();
            }
            else if (rdbCpf.Checked.Equals(true) && mskCpf.Text.Equals(""))
            {
                mskCpf.Enabled = false;
                mskCpf.Clear();
            }
            else
            {
                mskCpf.Enabled= false;
            }
        }

        private void rdbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCnpj.Checked.Equals(true))
            {
                mskCnpj.Enabled = true;
                mskCnpj.Focus();
            }
            else if (rdbCnpj.Checked.Equals(true) && mskCnpj.Text.Equals(""))
            {
                mskCnpj.Enabled = false;
                mskCnpj.Clear();
            }
            else
            {
                mskCnpj.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um nome!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtNomeFornecedor.Focus();
            }
            else if (rdbCpf.Checked)
            {
                string cnpj = null;
                //Regex utilizado para remover espaços extras entre as palavras.

                int resp = cadastrarFornecedores(Regex.Replace(txtNomeFornecedor.Text, @"\s+", " ").Trim().ToUpper(), mskCpf.Text, cnpj, mskCep.Text, txtRua.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, cbbCidade.Text, cbbEstado.Text, mskTelefone.Text, txtReferencia.Text);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desativarBotoes();
                    limparCamposNovo();
                    desativarCampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    //limparCampos();
                    btnCadastrar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    desativarCampos();

                }
            }
            else if (rdbCnpj.Checked)
            {
                string cpf = null;

                //Regex utilizado para remover espaços extras entre as palavras.
                int resp = cadastrarFornecedores(Regex.Replace(txtNomeFornecedor.Text, @"\s+", " ").Trim().ToUpper(), cpf, mskCnpj.Text, mskCep.Text, txtRua.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, cbbCidade.Text, cbbEstado.Text, mskTelefone.Text, txtReferencia.Text);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desativarBotoes();
                    limparCamposNovo();
                    desativarCampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    //limparCampos();
                    btnCadastrar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    desativarCampos();

                }
            }
            else if (!txtNomeFornecedor.Text.Equals("") && !buscaOrigemDoacao(txtNomeFornecedor.Text).Equals(1))
            {
                string cpf = null;
                string cnpj = null;

                //Regex utilizado para remover espaços extras entre as palavras.
                int resp = cadastrarFornecedores(Regex.Replace(txtNomeFornecedor.Text, @"\s+", " ").Trim().ToUpper(), cpf, cnpj, mskCep.Text, txtRua.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, cbbCidade.Text, cbbEstado.Text, mskTelefone.Text, txtReferencia.Text);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desativarBotoes();
                    limparCamposNovo();
                    desativarCampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);                    
                    btnCadastrar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    desativarCampos();
                }
            }
        }
        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarOrigemDoacao abrir = new frmPesquisarOrigemDoacao(codUsuLogado);
            abrir.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?", "Mensagem do Sistema",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result.Equals(DialogResult.Yes))
            {
                int resp = excluirOrigem(codOri);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Excluido com Sucesso!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);                 
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;                 
                    limparCamposNovo();
                    desativarCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtNomeFornecedor.Clear();
                    txtNomeFornecedor.Focus();
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    txtNomeFornecedor.Enabled = false;
                    limparCamposNovo();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtNomeFornecedor.Enabled = false;
                desativarBotoes();
                btnPesquisar.Focus();
            }
            else if (alterarOrigemDoacao(Regex.Replace(txtNomeFornecedor.Text, @"\s+", " ").Trim().ToUpper()).Equals(1))
            {
                MessageBox.Show("Fornecedor alterado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                limparCamposNovo();
                desativarCampos();
                btnLimpar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnNovo.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao alterar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCamposNovo();
                btnLimpar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = false;
            }
        }
        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.Length > 0)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.Equals(""))
            {
                MessageBox.Show("Campo já está vazio!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtNomeFornecedor.Focus();
            }
            else
               limparCampos();
               btnCadastrar.Enabled = false;
               btnNovo.Enabled = true;
               btnLimpar.Enabled = false;
               btnAlterar.Enabled = false;
               btnExcluir.Enabled = false;
               desativarCampos();
               btnNovo.Focus(); 
        }
    }
}
