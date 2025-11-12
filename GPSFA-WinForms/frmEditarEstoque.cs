using GPSFA_WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmEditarEstoque : Form
    {
        private int codProduto;
        public event Action DadosAtualizados;
        public frmEditarEstoque()
        {
            InitializeComponent();
        }

        public frmEditarEstoque(string codProd)
        {
            
            InitializeComponent();
            carregaDadosProduto(codProduto);

        }

        public void carregaDadosProduto(int codProd){
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbProdutos WHERE codProd = @codProd";
            comm.Parameters.AddWithValue("@codProd", codProd);

            comm.Connection = DataBaseConnection.OpenConnection();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            if (DR.Read())
            {
                txtCodigo.Text = DR["codProd"].ToString();
                txtProduto.Text = DR["nome"].ToString();
                cbxCategoria.Text = DR["unidade"].ToString();
                nudQuantidade.Value = Convert.ToInt32(DR["quantidade"]);
                dtpValidade.Text = DR["dataDEValidade"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDEValidade"]).ToString("dd/MM/yyyy");
            }
        }

        public int atualizarEstoque(string nomeProduto, int quantidade, string unidade, DateTime dataValidade, int codProd) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbProdutos set nome=@nomeProduto, quantidade=@quantidade, unidade=@unidade, dataDeValidade=@dataValidade WHERE codProd=@codProd;";

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProduto", MySqlDbType.VarChar, 100).Value = nomeProduto;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 50).Value = unidade;
            comm.Parameters.Add("@dataValidade", MySqlDbType.Date).Value = dataValidade;
            comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = codProd;
            comm.Connection = DataBaseConnection.OpenConnection();

            int resp = comm.ExecuteNonQuery();

            DataBaseConnection.OpenConnection();

            return resp;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string unidades = cbxCategoria.Text;
            string unidadeEscolhida = cbxCategoria.Text;
            switch (unidades)
            {
                case "Quilogramas (kg)":
                    unidadeEscolhida = "kg";
                    break;
                case "Gramas (g)":
                    unidadeEscolhida = "g";
                    break;
                case "Litros (l)":
                    unidadeEscolhida = "litros";
                    break;

                case "Mililitros (ml)":
                    unidadeEscolhida = "ml";
                    break;
                case "Unidades":
                    unidadeEscolhida = "unidades";
                    break;
                case "Caixas":
                    unidadeEscolhida = "Caixas";
                    break;
            }

            if (atualizarEstoque(txtProduto.Text, Convert.ToInt32(nudQuantidade.Value), unidadeEscolhida, dtpValidade.Value, codProduto) == 1)
            {
                if (cbxCategoria.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor Selecione uma categoria valida!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DadosAtualizados?.Invoke();
            }
            else {
                MessageBox.Show("Error ao atualizar sucesso!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
