namespace GPSFA_WinForms
{
    partial class frmGerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProdutos));
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblUnidadeDeMedida = new System.Windows.Forms.Label();
            this.cbbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.gpbCamposDoProduto = new System.Windows.Forms.GroupBox();
            this.btnDoacao = new System.Windows.Forms.Button();
            this.lbOrigemDoacao = new System.Windows.Forms.Label();
            this.cbbOrigemDoacao = new System.Windows.Forms.ComboBox();
            this.btnMedida = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.cbbDescricao = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbCamposDoProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(3, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(166, 70);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.Color.Black;
            this.lblCodBarras.Location = new System.Drawing.Point(36, 80);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(216, 29);
            this.lblCodBarras.TabIndex = 1;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(36, 111);
            this.txtCodBarras.MaxLength = 13;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(362, 39);
            this.txtCodBarras.TabIndex = 1;
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeDeMedida.ForeColor = System.Drawing.Color.Black;
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(895, 192);
            this.lblUnidadeDeMedida.Name = "lblUnidadeDeMedida";
            this.lblUnidadeDeMedida.Size = new System.Drawing.Size(242, 29);
            this.lblUnidadeDeMedida.TabIndex = 9;
            this.lblUnidadeDeMedida.Text = "Unidade de medida";
            // 
            // cbbUnidadeMedida
            // 
            this.cbbUnidadeMedida.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUnidadeMedida.FormattingEnabled = true;
            this.cbbUnidadeMedida.Location = new System.Drawing.Point(900, 223);
            this.cbbUnidadeMedida.Name = "cbbUnidadeMedida";
            this.cbbUnidadeMedida.Size = new System.Drawing.Size(236, 39);
            this.cbbUnidadeMedida.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(766, 223);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(98, 39);
            this.txtPeso.TabIndex = 4;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(761, 192);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(73, 29);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(593, 223);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(137, 39);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(588, 192);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(148, 29);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.Color.Black;
            this.lblDataValidade.Location = new System.Drawing.Point(272, 310);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(116, 29);
            this.lblDataValidade.TabIndex = 57;
            this.lblDataValidade.Text = "Validade";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidade.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataValidade.Location = new System.Drawing.Point(278, 342);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(160, 34);
            this.dtpDataValidade.TabIndex = 7;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.ForeColor = System.Drawing.Color.Black;
            this.lblDataEntrada.Location = new System.Drawing.Point(36, 310);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(103, 29);
            this.lblDataEntrada.TabIndex = 54;
            this.lblDataEntrada.Text = "Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(36, 342);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(160, 34);
            this.dtpDataEntrada.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(35, 192);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(130, 29);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Descrição";
            // 
            // gpbCamposDoProduto
            // 
            this.gpbCamposDoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.gpbCamposDoProduto.Controls.Add(this.btnDoacao);
            this.gpbCamposDoProduto.Controls.Add(this.lbOrigemDoacao);
            this.gpbCamposDoProduto.Controls.Add(this.cbbOrigemDoacao);
            this.gpbCamposDoProduto.Controls.Add(this.btnMedida);
            this.gpbCamposDoProduto.Controls.Add(this.btnLista);
            this.gpbCamposDoProduto.Controls.Add(this.cbbDescricao);
            this.gpbCamposDoProduto.Controls.Add(this.lblCodBarras);
            this.gpbCamposDoProduto.Controls.Add(this.txtCodBarras);
            this.gpbCamposDoProduto.Controls.Add(this.lblUnidadeDeMedida);
            this.gpbCamposDoProduto.Controls.Add(this.cbbUnidadeMedida);
            this.gpbCamposDoProduto.Controls.Add(this.txtPeso);
            this.gpbCamposDoProduto.Controls.Add(this.lblPeso);
            this.gpbCamposDoProduto.Controls.Add(this.txtQuantidade);
            this.gpbCamposDoProduto.Controls.Add(this.lblQuantidade);
            this.gpbCamposDoProduto.Controls.Add(this.lblDataValidade);
            this.gpbCamposDoProduto.Controls.Add(this.dtpDataValidade);
            this.gpbCamposDoProduto.Controls.Add(this.lblDataEntrada);
            this.gpbCamposDoProduto.Controls.Add(this.dtpDataEntrada);
            this.gpbCamposDoProduto.Controls.Add(this.lbl);
            this.gpbCamposDoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCamposDoProduto.Location = new System.Drawing.Point(12, 12);
            this.gpbCamposDoProduto.Name = "gpbCamposDoProduto";
            this.gpbCamposDoProduto.Size = new System.Drawing.Size(1214, 478);
            this.gpbCamposDoProduto.TabIndex = 0;
            this.gpbCamposDoProduto.TabStop = false;
            // 
            // btnDoacao
            // 
            this.btnDoacao.FlatAppearance.BorderSize = 0;
            this.btnDoacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoacao.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoacao.Image = ((System.Drawing.Image)(resources.GetObject("btnDoacao.Image")));
            this.btnDoacao.Location = new System.Drawing.Point(709, 111);
            this.btnDoacao.Name = "btnDoacao";
            this.btnDoacao.Size = new System.Drawing.Size(48, 36);
            this.btnDoacao.TabIndex = 63;
            this.btnDoacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoacao.UseVisualStyleBackColor = true;
            this.btnDoacao.Click += new System.EventHandler(this.btnDoacao_Click);
            // 
            // lbOrigemDoacao
            // 
            this.lbOrigemDoacao.AutoSize = true;
            this.lbOrigemDoacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigemDoacao.ForeColor = System.Drawing.Color.Black;
            this.lbOrigemDoacao.Location = new System.Drawing.Point(462, 80);
            this.lbOrigemDoacao.Name = "lbOrigemDoacao";
            this.lbOrigemDoacao.Size = new System.Drawing.Size(232, 29);
            this.lbOrigemDoacao.TabIndex = 62;
            this.lbOrigemDoacao.Text = "Origem da Doação";
            // 
            // cbbOrigemDoacao
            // 
            this.cbbOrigemDoacao.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOrigemDoacao.FormattingEnabled = true;
            this.cbbOrigemDoacao.Location = new System.Drawing.Point(462, 111);
            this.cbbOrigemDoacao.Name = "cbbOrigemDoacao";
            this.cbbOrigemDoacao.Size = new System.Drawing.Size(236, 39);
            this.cbbOrigemDoacao.TabIndex = 61;
            // 
            // btnMedida
            // 
            this.btnMedida.FlatAppearance.BorderSize = 0;
            this.btnMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedida.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnMedida.Image")));
            this.btnMedida.Location = new System.Drawing.Point(1142, 226);
            this.btnMedida.Name = "btnMedida";
            this.btnMedida.Size = new System.Drawing.Size(48, 36);
            this.btnMedida.TabIndex = 60;
            this.btnMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedida.UseVisualStyleBackColor = true;
            this.btnMedida.Click += new System.EventHandler(this.btnMedida_Click);
            // 
            // btnLista
            // 
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Image = ((System.Drawing.Image)(resources.GetObject("btnLista.Image")));
            this.btnLista.Location = new System.Drawing.Point(518, 223);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(48, 36);
            this.btnLista.TabIndex = 59;
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // cbbDescricao
            // 
            this.cbbDescricao.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDescricao.FormattingEnabled = true;
            this.cbbDescricao.Location = new System.Drawing.Point(35, 223);
            this.cbbDescricao.Name = "cbbDescricao";
            this.cbbDescricao.Size = new System.Drawing.Size(477, 39);
            this.cbbDescricao.TabIndex = 58;
            this.cbbDescricao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(12, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 94);
            this.panel1.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1045, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(166, 70);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(519, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 70);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(863, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(166, 70);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(347, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(166, 70);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(691, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(166, 70);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(175, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 70);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1235, 602);
            this.Controls.Add(this.gpbCamposDoProduto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Gerenciar Produtos";
            this.Load += new System.EventHandler(this.frmCadastrarAlimentos_Load);
            this.gpbCamposDoProduto.ResumeLayout(false);
            this.gpbCamposDoProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblUnidadeDeMedida;
        private System.Windows.Forms.ComboBox cbbUnidadeMedida;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gpbCamposDoProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbbDescricao;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnMedida;
        private System.Windows.Forms.Button btnDoacao;
        private System.Windows.Forms.Label lbOrigemDoacao;
        private System.Windows.Forms.ComboBox cbbOrigemDoacao;
    }
}