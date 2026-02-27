using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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

        //Métodos construtores

        public frmGerenciarProdutos()
        {
            InitializeComponent();
            carregarOrigemCbb();
            carregarUnidadesCbb();
            carregarProdutosCbb();
        }

        public frmGerenciarProdutos(int codUsu)
        {
            codUsuLogado = codUsu;
            InitializeComponent();
            carregarOrigemCbb();
            carregarUnidadesCbb();
            carregarProdutosCbb();

            dtpDiaDistribuicao.Value = diaDeDistribuicao;
        }

        public frmGerenciarProdutos(int codUsu, string origemSelecionada)
        {
            nomeOrigem = origemSelecionada;
            codUsuLogado = codUsu;
            InitializeComponent();
            carregarOrigemCbb();
            carregarUnidadesCbb();
            carregarProdutosCbb();

            cbbOrigemDoacao.Text = nomeOrigem;
            
            dtpDiaDistribuicao.Value = diaDeDistribuicao;
        }

        // Variavel global da janela para salvar o código do usuário logado
        int codUsuLogado;

        // Variavel global da janela para salvar o código de produto da tabela TBLista
        int codList;

        // Variavel global da janela para salvar o código de Origem da tabela TBOrigemDoacao
        int codOri;

        // Variavel global da janela para salvar o código de Origem da tabela TBOrigemDoacao
        string nomeOrigem;

        int codOrigem;

        //Desativando botão fechar da janela

        private void frmCadastrarAlimentos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //Método para carregar Origem na CBBOrigem

        private void carregarOrigemCbb()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "SELECT * FROM TBOrigemDoacao ORDER BY nome ASC;";

            comm.CommandType = CommandType.Text;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbOrigemDoacao.Items.Add(DR.GetString(1));
            }

            DataBaseConnection.CloseConnection();
        }

        //Método para carregar Unidades na CBBUnidade

        private void carregarUnidadesCbb()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbUnidades ORDER BY descricao ASC;";
            comm.CommandType = CommandType.Text;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbUnidadeMedida.Items.Add(DR.GetString(1));
            }

            DataBaseConnection.CloseConnection();
        }

        //Método para carregar Descrição dos Produtos na CBBDescrição

        private void carregarProdutosCbb()
        {
            cbbDescricao.Items.Clear();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT descricao FROM tbLista ORDER BY descricao ASC;";
            comm.CommandType = CommandType.Text;

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbDescricao.Items.Add(DR.GetString(0));
            }

            DataBaseConnection.CloseConnection();
        }

        //Método para validar DataLimite de Saída
        
            int diaDeArrecadacao = DateTime.Now.Day;

            DateTime diaDeDistribuicao = DateTime.Now.AddDays(7);          

        private void validaSaida()
        {
            int dataValidade = Convert.ToInt32(dtpDataValidade.Value.Day);

            int calculoData = Convert.ToInt32(dtpDiaDistribuicao.Value.Day);

            //if ()
            //{

            //}

        }

            

        

        //Método para verificar Formatação de Campos

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
                MessageBox.Show("O período para cadastro de doação excedeu!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Método para cadastrar Produtos na TBPRODUTOS

        private int cadastrarProdutos(string descricao, int estoqueAtual, decimal peso, string unidade, string codBar, DateTime dataDeEntrada, DateTime dataDeValidade, DateTime dataLimiteDeSaida, int codUsu, int codOri, int codList)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbprodutos(descricao, estoqueAtual, peso, unidade, codBar, dataDeEntrada, dataDeValidade, dataLimiteDeSaida, codUsu, codOri, codList)VALUES(@descricao, @estoqueAtual, @peso, @unidade, @codBar, @dataDeEntrada, @dataDeValidade, @dataLimiteDeSaida, @codUsu, @codOri, @codList);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            comm.Parameters.Add("@estoqueAtual", MySqlDbType.Int32).Value = estoqueAtual;
            comm.Parameters.Add("@peso", MySqlDbType.Int32).Value = peso;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 20).Value = unidade;
            comm.Parameters.Add("@codBar", MySqlDbType.VarChar, 13).Value = codBar;
            comm.Parameters.Add("@dataDeEntrada", MySqlDbType.Date).Value = dataDeEntrada;
            comm.Parameters.Add("@dataDeValidade", MySqlDbType.Date).Value = dataDeValidade;
            comm.Parameters.Add("@dataLimiteDeSaida", MySqlDbType.Date).Value = dataLimiteDeSaida;
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = 1;
            comm.Parameters.Add("@codOri", MySqlDbType.Int32).Value = codOri;
            comm.Parameters.Add("@codList", MySqlDbType.Int32).Value = codList;

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


        //Botão ação cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
//<<<<<<< HEAD
>>>>>>> parent of cb96210 (att origem doacao)
            if (dtpDataValidade.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Data de validade inválida.");
                return;
            }

            if (VerificaFormatacaoDosCampos()) {
                //MessageBox.Show("Um ou mais campos estão em brancos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DataBaseConnection.OpenConnection())
<<<<<<< HEAD
<<<<<<< Updated upstream

=======
//=======
>>>>>>> parent of cb96210 (att origem doacao)
           
            //int resp = cadastrarProdutos(cbbDescricao.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtPeso.Text), cbbUnidadeMedida.Text, txtCodBarras.Text, dtpDataEntrada.Value, dtpDataValidade.Value, dtpDataEntrada.Value, codUsuLogado, codOri, codList);
=======
>>>>>>> Stashed changes
           
            if (dtpDataValidade.Value < DateTime.Today)
            {
                MessageBox.Show("A data de validade não pode ser anterior a data atual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                dtpDataValidade.Focus();                
                return;
            }
<<<<<<< HEAD

            else if (cadastrarProdutos(cbbDescricao.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtPeso.Text), cbbUnidadeMedida.Text, txtCodBarras.Text, dtpDataEntrada.Value, dtpDataValidade.Value, dtpDataEntrada.Value, codUsuLogado, codOri, codList).Equals(1))
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
            else if (cadastrarProdutos(cbbDescricao.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtPeso.Text), cbbUnidadeMedida.Text, txtCodBarras.Text, dtpDataEntrada.Value, dtpDataValidade.Value, dtpDataEntrada.Value, codUsuLogado, codOri, codList).Equals(1))
//>>>>>>> 8f8a8eddb33d53196da667df434a240a8808af77
>>>>>>> parent of cb96210 (att origem doacao)
            {
                // Verifica se já existe produto
                string sqlVerifica = "SELECT codProd, estoqueAtual FROM tbProdutos WHERE codBar = @codBar";

                using (var cmdVerifica = new MySqlCommand(sqlVerifica, conn))
                {
                    cmdVerifica.Parameters.AddWithValue("@codBar", txtCodBarras.Text);

                    using (var reader = cmdVerifica.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int codProd = reader.GetInt32("codProd");
                            int qtdAtual = reader.GetInt32("estoqueAtual");
                            reader.Close();

                            // Atualiza estoque
                            string sqlUpdate = "UPDATE tbProdutos SET estoqueAtual = @novaQtd WHERE codProd = @codProd";

                            using (var cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@novaQtd",
                                    qtdAtual + Convert.ToInt32(txtQuantidade.Text));
                                cmdUpdate.Parameters.AddWithValue("@codProd", codProd);
                                cmdUpdate.ExecuteNonQuery();
                            }

                            MessageBox.Show("Quantidade atualizada no estoque.");
                            return;
                        }
                    }
                }

                // Se não existir, insere novo produto
                string sqlInsert = @"INSERT INTO tbProdutos
                             (descricao, quantidade, peso, unidade, codBar,
                              dataDeEntrada, dataDeValidade, codUsu, codOri, codList)
                             VALUES
                             (@descricao, @qtd, @peso, @un, @codBar,
                              @entrada, @validade, @codUsu, @codOri, @codList)";

                using (var cmdInsert = new MySqlCommand(sqlInsert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@descricao", cbbDescricao.Text);
                    cmdInsert.Parameters.AddWithValue("@qtd", Convert.ToInt32(txtQuantidade.Text));
                    cmdInsert.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                    cmdInsert.Parameters.AddWithValue("@un", cbbUnidadeMedida.Text);
                    cmdInsert.Parameters.AddWithValue("@codBar", txtCodBarras.Text);
                    cmdInsert.Parameters.AddWithValue("@entrada", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@validade", dtpDataValidade.Value);
                    cmdInsert.Parameters.AddWithValue("@codUsu", codUsuLogado);
                    cmdInsert.Parameters.AddWithValue("@codOri", 1);
                    cmdInsert.Parameters.AddWithValue("@codList", 1);

                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Produto cadastrado com sucesso.");
            }
        }


        //Botão ação cadastrar

        //private void btnCadastrar_Click(object sender, EventArgs e)
        //{
        //    int resp = cadastrarProdutos(cbbDescricao.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtPeso.Text), cbbUnidadeMedida.Text, txtCodBarras.Text, dtpDataEntrada.Value, dtpDataValidade.Value, dtpDataEntrada.Value, codUsuLogado, codOri, codList);

        //    if (dtpDataValidade.Value < DateTime.Today)
        //    {
        //        MessageBox.Show("A data de validade não pode ser anterior a data atual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dtpDataValidade.Focus();
        //        return;
        //    }
        //    else if (resp.Equals(1))
        //    {
        //        MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Information,
        //        MessageBoxDefaultButton.Button1);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Error,
        //        MessageBoxDefaultButton.Button1);
        //    }
        //}


        ///Exemplos para serem utilizados no futuro para validação de campos

        //    if (Regex.IsMatch(txtQuantidade.Text, @"[a-zA-Z]") || Convert.ToInt32(txtQuantidade.Text) == 0)
        //    {
        //        MessageBox.Show("Quantidade inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtQuantidade.Focus();
        //        return false;
        //    }

        //    return true;
        //}     

        //if (cbbDescricao.Text.Equals("") || txtQuantidade.Text.Equals(""))
        //{
        //    MessageBox.Show("Um ou mais campos não foram preenchidos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    return;
        //}

        //if (!VerificaFormatacaoDosCampos())
        //{
        //    return;
        //}
        //string nomeItem = cbbDescricao.Text;
        //int quantidade = Convert.ToInt32(txtQuantidade.Text);
        //int peso = Convert.ToInt32(txtPeso.Text);
        //string tipoUnidade = SimplificarUnidade(cbbUnidadeMedida.Text);
        //string codBar = txtCodBarras.Text;
        //DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
        //DateTime dataValidade = Convert.ToDateTime(dtpDataValidade.Text);
        //DateTime dataLimiteDeSaida = dataValidade.AddDays(21);
        //int codUsu = 1;

        //if (enviarDoacoes(nomeItem, quantidade, peso, tipoUnidade, codBar, dataRecebimento, dataValidade, dataLimiteDeSaida, codUsu) == 1)
        //{
        //    MessageBox.Show("Doação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //dgvProdutos.Columns.Clear();
        //    //CarregarListaProdutos();
        //}
        //else
        //{
        //    MessageBox.Show("Erro ao cadastrar doação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    limparCamposDeCadastro();
        //}

        //    if (cbbDescricao.Text.Equals("") || txtQuantidade.Text.Equals(""))
        //    {
        //        MessageBox.Show("Um ou mais campos não foram preenchidos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    //if (!VerificaFormatacaoDosCampos())
        //    //{
        //    //    return;
        //    //}
        //    //string nomeItem = cbbDescricao.Text;
        //    //int quantidade = Convert.ToInt32(txtQuantidade.Text);
        //    //int peso = Convert.ToInt32(txtPeso.Text);
        //    //string tipoUnidade = SimplificarUnidade(cbbUnidadeMedida.Text);
        //    //string codBar = txtCodBarras.Text;
        //    //DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
        //    //DateTime dataValidade = Convert.ToDateTime(dtpDataValidade.Text);
        //    //DateTime dataLimiteDeSaida = dataValidade.AddDays(21);
        //    //int codUsu = 1;
        //    //var (codOrigem, codLista) = BuscaCodigoDeListEOrigem(cbbOrigemDoacao.Text, cbbDescricao.Text);

        //    //if (dtpDataValidade.Value < DateTime.Today){
        //    //    MessageBox.Show("A data de validade não pode ser anterior a data atual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    dtpDataValidade.Focus();
        //    //    return;
        //    //}

        //    //if (enviarDoacoes(nomeItem, quantidade, peso, tipoUnidade, codBar, dataRecebimento, dataValidade, dataLimiteDeSaida, codUsu, codOrigem, codLista) == 1)
        //    //{
        //    //    MessageBox.Show("Doação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    //dgvProdutos.Columns.Clear();
        //    //    //CarregarListaProdutos();
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Erro ao cadastrar doação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    limparCamposDeCadastro();
        //    //}

        //    ////dgvProdutos.Columns.Clear();
        //    ////CarregarListaProdutos();
        //    ///

        //    //cadastrarProdutos(cbbDescricao.SelectedItem.ToString(), Convert.ToInt32(txtQuantidade.Text), peso, cbbUnidadeMedida.Text, codBar.ToString() ,dtpDataEntrada.Value, dtpDataValidade.Value, dtpDataValidade.Value, 1, 1, 1);

        //    if (dtpDataValidade.Value < DateTime.Today)
        //    {
        //        MessageBox.Show("A data de validade não pode ser anterior a data atual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dtpDataValidade.Focus();
        //        return;
        //    }

        //    int quantidadeMinimaParaCadastroDeProduto = 1;
        //    while (quantidadeMinimaParaCadastroDeProduto <= quantidade)
        //    {
        //        if (enviarDoacoes(nomeItem, 1, peso, tipoUnidade, codBar, dataRecebimento, dataValidade, dataLimiteDeSaida, codUsu, codOrigem, codLista) == 1)
        //        {
        //            quantidadeMinimaParaCadastroDeProduto++;
        //            //dgvProdutos.Columns.Clear();
        //            //CarregarListaProdutos();
        //            if (quantidadeMinimaParaCadastroDeProduto == quantidade)
        //            {
        //                MessageBox.Show("Doação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                limparCamposDeCadastro();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erro ao cadastrar doação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            limparCamposDeCadastro();
        //        }

        //    }

        //    //dgvProdutos.Columns.Clear();
        //    //CarregarListaProdutos();

        //}

        //private void btnAtualizarDados_Click(object sender, EventArgs e)
        //{
        //    //dgvRegistro.Rows.Clear();
        //    //CarregarListaProdutos();
        //    limparCamposDeCadastro();
        //    //carregaProdutosNaLista();
        //}

        //public void limparCamposDeCadastro()
        //{

        //    txtQuantidade.Clear();
        //    dtpDataValidade.Value = DateTime.Now;
        //    DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
        //    dtpDataValidade.Value = DateTime.Now;
        //    //cbbUnidadeMedida.SelectedIndex = 0;
        //    txtPeso.Clear();
        //}   


        // Criada instância das janelas com o código do usuário imbutido
        private void btnDoacao_Click(object sender, EventArgs e)
        {
            frmOrigemDoacao abrir = new frmOrigemDoacao(codUsuLogado);
            abrir.Show();
            this.Hide();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmListaProdutos abrir = new frmListaProdutos(codUsuLogado);
            abrir.Show();
            this.Hide();
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            frmUnidadeMedida abrir = new frmUnidadeMedida(codUsuLogado);
            abrir.Show();
            this.Hide();
        }

        private void gpbCamposDoProduto_Enter(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal(codUsuLogado);
            abrir.Show();
            this.Close();
        }

        private void cbbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDescricao.SelectedItem == null) return;

            string nomeSelecionado = cbbDescricao.SelectedItem.ToString();

            cbbUnidadeMedida.Items.Clear();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codList, peso, unidade FROM tbLista WHERE descricao = @descricao;";
            comm.CommandType = CommandType.Text;           
            comm.Parameters.AddWithValue("@descricao", nomeSelecionado);

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                codList = DR.GetInt32(0);
                txtPeso.Text = DR.GetInt32(1).ToString();
                cbbUnidadeMedida.Text = DR.GetString(2);
                cbbUnidadeMedida.Enabled = false;
                txtPeso.Enabled = false;
            }

            DataBaseConnection.CloseConnection();
        }

        private void cbbOrigemDoacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOrigemDoacao.SelectedItem == null) return;

            string origemSelecionada = cbbOrigemDoacao.SelectedItem.ToString();

            cbbUnidadeMedida.Items.Clear();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codOri FROM tborigemdoacao WHERE nome = @nome;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.AddWithValue("@nome", origemSelecionada);

            comm.Connection = DataBaseConnection.OpenConnection();

            MySqlDataReader DR = comm.ExecuteReader();

            if (DR.Read())
            {
                codOri = DR.GetInt32(0);                
            }

            DataBaseConnection.CloseConnection();
        }
     
    }        
}

