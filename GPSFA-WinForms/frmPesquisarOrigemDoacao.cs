using CpfLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmPesquisarOrigemDoacao : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        
        public frmPesquisarOrigemDoacao()
        {
            InitializeComponent();
            btnPesquisarOrigem.Enabled = false;
            ltbPesquisarOrigem.Enabled = false;
            btnLimpar.Enabled = false;
        }

        int codUsuLogado;

        public frmPesquisarOrigemDoacao(int codUsu)
        {
            InitializeComponent();
            codUsuLogado = codUsu;
            btnPesquisarOrigem.Enabled = false;
            ltbPesquisarOrigem.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void frmPesquisarOrigemDoacao_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }        

        public void buscaOrigemDoacao(string nome)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT nome FROM tborigemdoacao WHERE nome LIKE '%{nome}%';";

            comm.CommandType = CommandType.Text;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbPesquisarOrigem.Items.Clear();

            if (DR.HasRows == false)
            {
                MessageBox.Show("Nenhuma origem encontrada com este valor.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);                
                txtDescricao.Clear();
                txtDescricao.Focus();
            }
            else
            {
              
                    while (DR.Read())
                    {
                    ltbPesquisarOrigem.Items.Add(DR.GetString(0));                  
           
                }
                
                
            }
            DataBaseConnection.CloseConnection();
        }        

        private void btnPesquisarOrigem_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um valor",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else
            {
                buscaOrigemDoacao(txtDescricao.Text);
                ltbPesquisarOrigem.Enabled = true;
                txtDescricao.Clear();
                txtDescricao.Enabled = false;
                btnPesquisarOrigem.Enabled = false;
                btnLimpar.Enabled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmOrigemDoacao abrir = new frmOrigemDoacao(codUsuLogado);
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            ltbPesquisarOrigem.Items.Clear();
            btnPesquisarOrigem.Enabled = false;
            btnLimpar.Enabled = false;
            txtDescricao.Enabled = true;
            txtDescricao.Clear();
            txtDescricao.Focus();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            btnPesquisarOrigem.Enabled = true;
            btnLimpar.Enabled = true;
            if (txtDescricao.Text.Equals(""))
            {
                btnPesquisarOrigem.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }     
        
        private void ltbPesquisarOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
                string nome = ltbPesquisarOrigem.SelectedItem.ToString();               

                frmOrigemDoacao abrir = new frmOrigemDoacao(nome);
                abrir.Show();
                this.Hide();          
           
        }
            
    }
}
