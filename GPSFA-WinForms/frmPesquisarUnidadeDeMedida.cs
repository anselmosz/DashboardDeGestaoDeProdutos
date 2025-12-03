using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmPesquisarUnidadeDeMedida : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmPesquisarUnidadeDeMedida()
        {
            InitializeComponent();
            desativarBotoes();
        }
        private void desativarBotoes()
        {
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        private int excluirUnidade(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbUnidade WHERE descricao = @descricao limit 1;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@descricao", MySqlDbType.VarChar,20).Value = descricao;

            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.CloseConnection();

            return resp;
        }

        public void buscaUnidadesPorDescricao(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT descricao FROM tbUnidade WHERE descricao LIKE '%{descricao}%';";

            comm.CommandType = CommandType.Text;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbPesquisarUnidades.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisarUnidades.Items.Add(DR.GetString(0));
            }

            DataBaseConnection.CloseConnection();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmUnidadeMedida abrir = new frmUnidadeMedida();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisarUnidade_Click(object sender, EventArgs e)
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
                    buscaUnidadesPorDescricao(txtDescricao.Text);
                    ltbPesquisarUnidades.Enabled = true;                    
            }
        }

        private void frmPesquisarUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?", "Mensagem do Sistema",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result.Equals(DialogResult.Yes))
            {
                int resp = excluirUnidade(ltbPesquisarUnidades.SelectedItem.ToString());

                if (resp.Equals(1))
                {
                    MessageBox.Show("Excluido com Sucesso", "Mensagem do Sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                btnPesquisarUnidade.Enabled = true;
            }
        }

        private void ltbPesquisarUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
        }
    }
}
