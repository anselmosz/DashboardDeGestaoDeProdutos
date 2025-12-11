using GPSFA_WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public class UnidadeItem
    {
        public int codList { get; set; }
        public string descricao { get; set; }

        public override string ToString()
        {
            return descricao;
        }
    }

    public partial class frmEditarEstoque : Form
    {   private int codProduto;
        private int codListProdutos;
        public event Action DadosAtualizados;
        public frmEditarEstoque()
        {
            InitializeComponent();
        }

        public frmEditarEstoque(string codProd)
        {
            codProduto = Convert.ToInt32(codProd);
            InitializeComponent();
            carregaDadosProduto(codProduto);
            CarregarUnidades();
            CarregarListProdutos();

        }

        private void CarregarUnidades()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = @"SELECT descricao FROM tbunidade ORDER BY descricao ASC";
                comm.CommandType = CommandType.Text;
                comm.Connection = DataBaseConnection.OpenConnection();
                cbxCategoria.Items.Clear();

                comm.Connection = DataBaseConnection.OpenConnection();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();

                while (DR.Read())
                {
                    cbxCategoria.Items.Add(DR["descricao"].ToString());
                }

                // garante item de "nenhuma seleção"
                cbxCategoria.Items.Insert(0, "Selecione...");
                cbxCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                DataBaseConnection.CloseConnection();
                MessageBox.Show("Erro ao carregar unidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarListProdutos()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "SELECT codList, descricao FROM tblista ORDER BY descricao ASC";
                comm.Connection = DataBaseConnection.OpenConnection();


                MySqlDataReader DR;
                DR = comm.ExecuteReader();

                cbxListProdutos.Items.Add(new UnidadeItem
                {
                    codList = 0,
                    descricao = "Selecione"
                });

                while (DR.Read())
                {
                    cbxListProdutos.Items.Add(new UnidadeItem
                    {
                        codList = Convert.ToInt32(DR["codList"]),
                        descricao = DR["descricao"].ToString()
                    });
                }
                cbxListProdutos.SelectedIndex = 0;
            } 
            catch (Exception ex){
                DataBaseConnection.CloseConnection();
                MessageBox.Show("Erro ao carregar unidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void carregaDadosProduto(int codProd){
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbProdutos WHERE codProd = @codProd";
            comm.Parameters.AddWithValue("@codProd", codProduto);

            comm.Connection = DataBaseConnection.OpenConnection();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            if (DR.Read())
            {
                txtCodigo.Text = DR["codProd"].ToString();
                txtProduto.Text = DR["descricao"].ToString();
                cbxCategoria.Text = DR["unidade"].ToString();
                nudQuantidade.Value = Convert.ToInt32(DR["quantidade"]);
                dtpValidade.Text = DR["dataDEValidade"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDEValidade"]).ToString("dd/MM/yyyy");
            }
        }

        public int atualizarEstoque(string nomeProduto, int quantidade, string unidade, DateTime dataValidade, int codProd, int codList) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbProdutos set codList=@codlist,quantidade=@quantidade, unidade=@unidade, dataDeValidade=@dataValidade WHERE codProd=@codProd;";

            comm.Parameters.Clear();
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 50).Value = unidade;
            comm.Parameters.Add("@dataValidade", MySqlDbType.Date).Value = dataValidade;
            comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = codProd;
            comm.Parameters.Add("@codList", MySqlDbType.Int32).Value = codList;
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

            if (atualizarEstoque(txtProduto.Text, Convert.ToInt32(nudQuantidade.Value), unidadeEscolhida, dtpValidade.Value, codProduto, codListProdutos) == 1)
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

        private void cbxListProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListProdutos.SelectedIndex > 0) {
                UnidadeItem item = (UnidadeItem)cbxListProdutos.SelectedItem;
                codListProdutos = item.codList;
            }
        }
    }
}
