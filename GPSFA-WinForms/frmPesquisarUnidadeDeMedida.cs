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
using System.Windows.Forms.VisualStyles;

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
            btnPesquisarUnidade.Enabled = false;
            ltbPesquisarUnidades.Enabled = false;
        }        

        public frmPesquisarUnidadeDeMedida(string descricao)
        {
            InitializeComponent();          

            txtDescricao.Text = descricao;          

            buscaUnidades(descricao);
        }                
   
        public void buscaUnidades(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT descricao FROM tbUnidades WHERE descricao LIKE '%{descricao}%';";

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
                    buscaUnidades(txtDescricao.Text);
                    ltbPesquisarUnidades.Enabled = true;                    
            }
        }

        private void frmPesquisarUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }    

        private void ltbPesquisarUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {          
            string descricao = ltbPesquisarUnidades.SelectedItem.ToString();          
           
            frmUnidadeMedida abrir = new frmUnidadeMedida(descricao);
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            frmUnidadeMedida abrir = new frmUnidadeMedida();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtDescricao.Focus();
            btnPesquisarUnidade.Enabled = false;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            btnPesquisarUnidade.Enabled = true;
        }
    }
}
