namespace Projeto_Socorrista
{
    partial class frmEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.lblTitleEstoque = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQRCODE = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCarregaTodosProdutos = new System.Windows.Forms.Button();
            this.txtNomeOrCod = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCodOrNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLimiteSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLerQRCode = new System.Windows.Forms.Button();
            this.btnDarBaixa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblValidadeAte = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlFiltrosDeBusca.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.AutoSize = true;
            this.pnlFiltrosDeBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlFiltrosDeBusca.Controls.Add(this.lblTitleEstoque);
            this.pnlFiltrosDeBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosDeBusca.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrosDeBusca.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Padding = new System.Windows.Forms.Padding(17, 0, 17, 16);
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1884, 51);
            this.pnlFiltrosDeBusca.TabIndex = 15;
            // 
            // lblTitleEstoque
            // 
            this.lblTitleEstoque.AutoSize = true;
            this.lblTitleEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleEstoque.Location = new System.Drawing.Point(20, 15);
            this.lblTitleEstoque.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitleEstoque.Name = "lblTitleEstoque";
            this.lblTitleEstoque.Size = new System.Drawing.Size(186, 20);
            this.lblTitleEstoque.TabIndex = 11;
            this.lblTitleEstoque.Text = "Controle de Alimentos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.lblQRCODE);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblCodOrNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvEstoque);
            this.panel2.Controls.Add(this.lblSubTitulo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(465, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1575, 1409);
            this.panel2.TabIndex = 20;
            // 
            // lblQRCODE
            // 
            this.lblQRCODE.AutoSize = true;
            this.lblQRCODE.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblQRCODE.Location = new System.Drawing.Point(28, 286);
            this.lblQRCODE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQRCODE.Name = "lblQRCODE";
            this.lblQRCODE.Size = new System.Drawing.Size(210, 21);
            this.lblQRCODE.TabIndex = 14;
            this.lblQRCODE.Text = "Leitor de código de barras";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.panel4.Controls.Add(this.btnCarregaTodosProdutos);
            this.panel4.Controls.Add(this.txtNomeOrCod);
            this.panel4.Controls.Add(this.btnPesquisar);
            this.panel4.Location = new System.Drawing.Point(37, 160);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1265, 92);
            this.panel4.TabIndex = 13;
            // 
            // btnCarregaTodosProdutos
            // 
            this.btnCarregaTodosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(75)))), ((int)(((byte)(13)))));
            this.btnCarregaTodosProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregaTodosProdutos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCarregaTodosProdutos.FlatAppearance.BorderSize = 0;
            this.btnCarregaTodosProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaTodosProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btnCarregaTodosProdutos.ForeColor = System.Drawing.Color.White;
            this.btnCarregaTodosProdutos.Location = new System.Drawing.Point(1097, 27);
            this.btnCarregaTodosProdutos.Margin = new System.Windows.Forms.Padding(5);
            this.btnCarregaTodosProdutos.Name = "btnCarregaTodosProdutos";
            this.btnCarregaTodosProdutos.Size = new System.Drawing.Size(140, 42);
            this.btnCarregaTodosProdutos.TabIndex = 14;
            this.btnCarregaTodosProdutos.Text = "Todos";
            this.btnCarregaTodosProdutos.UseVisualStyleBackColor = false;
            // 
            // txtNomeOrCod
            // 
            this.txtNomeOrCod.BackColor = System.Drawing.Color.White;
            this.txtNomeOrCod.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNomeOrCod.Location = new System.Drawing.Point(28, 27);
            this.txtNomeOrCod.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeOrCod.Multiline = true;
            this.txtNomeOrCod.Name = "txtNomeOrCod";
            this.txtNomeOrCod.Size = new System.Drawing.Size(839, 40);
            this.txtNomeOrCod.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(75)))), ((int)(((byte)(13)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(897, 27);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(167, 42);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblCodOrNome
            // 
            this.lblCodOrNome.AutoSize = true;
            this.lblCodOrNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblCodOrNome.Location = new System.Drawing.Point(28, 121);
            this.lblCodOrNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodOrNome.Name = "lblCodOrNome";
            this.lblCodOrNome.Size = new System.Drawing.Size(146, 21);
            this.lblCodOrNome.TabIndex = 2;
            this.lblCodOrNome.Text = "Código ou Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.produto,
            this.quantidade,
            this.unidade,
            this.peso,
            this.status,
            this.dataLimiteSaida});
            this.dgvEstoque.Location = new System.Drawing.Point(35, 430);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(5);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(1267, 588);
            this.dgvEstoque.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // unidade
            // 
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // dataLimiteSaida
            // 
            this.dataLimiteSaida.HeaderText = "Limite de Saída ";
            this.dataLimiteSaida.Name = "dataLimiteSaida";
            this.dataLimiteSaida.ReadOnly = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblSubTitulo.Location = new System.Drawing.Point(28, 36);
            this.lblSubTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(404, 21);
            this.lblSubTitulo.TabIndex = 4;
            this.lblSubTitulo.Text = "Consulta e gerenciamento de produtos em estoque";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.panel3.Controls.Add(this.btnLerQRCode);
            this.panel3.Controls.Add(this.btnDarBaixa);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(37, 328);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 92);
            this.panel3.TabIndex = 2;
            // 
            // btnLerQRCode
            // 
            this.btnLerQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(75)))), ((int)(((byte)(13)))));
            this.btnLerQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerQRCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLerQRCode.FlatAppearance.BorderSize = 0;
            this.btnLerQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerQRCode.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btnLerQRCode.ForeColor = System.Drawing.Color.White;
            this.btnLerQRCode.Location = new System.Drawing.Point(897, 27);
            this.btnLerQRCode.Margin = new System.Windows.Forms.Padding(5);
            this.btnLerQRCode.Name = "btnLerQRCode";
            this.btnLerQRCode.Size = new System.Drawing.Size(167, 42);
            this.btnLerQRCode.TabIndex = 12;
            this.btnLerQRCode.Text = "   Ler Código";
            this.btnLerQRCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLerQRCode.UseVisualStyleBackColor = false;
            // 
            // btnDarBaixa
            // 
            this.btnDarBaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(75)))), ((int)(((byte)(13)))));
            this.btnDarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarBaixa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDarBaixa.FlatAppearance.BorderSize = 0;
            this.btnDarBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaixa.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btnDarBaixa.ForeColor = System.Drawing.Color.White;
            this.btnDarBaixa.Location = new System.Drawing.Point(1097, 27);
            this.btnDarBaixa.Margin = new System.Windows.Forms.Padding(5);
            this.btnDarBaixa.Name = "btnDarBaixa";
            this.btnDarBaixa.Size = new System.Drawing.Size(140, 42);
            this.btnDarBaixa.TabIndex = 11;
            this.btnDarBaixa.Text = "Dar baixa";
            this.btnDarBaixa.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(839, 40);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnLimparFiltros);
            this.panel1.Controls.Add(this.dtpDataValidade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAplicarFiltros);
            this.panel1.Controls.Add(this.lblValidadeAte);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.lblFiltros);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 860);
            this.panel1.TabIndex = 19;
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(75)))), ((int)(((byte)(13)))));
            this.btnLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimparFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimparFiltros.Location = new System.Drawing.Point(215, 387);
            this.btnLimparFiltros.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(158, 45);
            this.btnLimparFiltros.TabIndex = 15;
            this.btnLimparFiltros.Text = "Limpar Filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = false;
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataValidade.Location = new System.Drawing.Point(29, 340);
            this.dtpDataValidade.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(344, 29);
            this.dtpDataValidade.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "________________________";
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(75)))), ((int)(((byte)(13)))));
            this.btnAplicarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAplicarFiltros.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btnAplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(28, 387);
            this.btnAplicarFiltros.Margin = new System.Windows.Forms.Padding(5);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(158, 45);
            this.btnAplicarFiltros.TabIndex = 11;
            this.btnAplicarFiltros.Text = "Aplicar filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            // 
            // lblValidadeAte
            // 
            this.lblValidadeAte.AutoSize = true;
            this.lblValidadeAte.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblValidadeAte.ForeColor = System.Drawing.Color.White;
            this.lblValidadeAte.Location = new System.Drawing.Point(24, 298);
            this.lblValidadeAte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValidadeAte.Name = "lblValidadeAte";
            this.lblValidadeAte.Size = new System.Drawing.Size(109, 21);
            this.lblValidadeAte.TabIndex = 7;
            this.lblValidadeAte.Text = "Validade até:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Selecione...",
            "Valido",
            "Vencido"});
            this.cbxStatus.Location = new System.Drawing.Point(30, 160);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(5);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(344, 29);
            this.cbxStatus.TabIndex = 9;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.lblFiltros.ForeColor = System.Drawing.Color.White;
            this.lblFiltros.Location = new System.Drawing.Point(17, 36);
            this.lblFiltros.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(67, 25);
            this.lblFiltros.TabIndex = 10;
            this.lblFiltros.Text = "Filtros";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Selecione...",
            "Quilogramas (kg)",
            "Gramas (g)",
            "Litros (l)",
            "Mililitros (ml)",
            "Unidades",
            "Caixas"});
            this.cbxCategoria.Location = new System.Drawing.Point(29, 253);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(344, 29);
            this.cbxCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(24, 206);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 21);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(25, 118);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de estoque ";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.pnlFiltrosDeBusca.ResumeLayout(false);
            this.pnlFiltrosDeBusca.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltrosDeBusca;
        private System.Windows.Forms.Label lblTitleEstoque;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQRCODE;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCarregaTodosProdutos;
        private System.Windows.Forms.TextBox txtNomeOrCod;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCodOrNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLimiteSaida;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLerQRCode;
        private System.Windows.Forms.Button btnDarBaixa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Label lblValidadeAte;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStatus;
    }
}