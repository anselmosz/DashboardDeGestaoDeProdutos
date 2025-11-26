namespace GPSFA_WinForms
{
    partial class frmCadastrarAlimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAlimentos));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
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
            this.txtNomeDoItem = new System.Windows.Forms.TextBox();
            this.lblNomeDoItem = new System.Windows.Forms.Label();
            this.gpbCamposDoAlimento = new System.Windows.Forms.GroupBox();
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblTitleDashboard = new System.Windows.Forms.Label();
            this.cbbListaDeItensPreRegistrados = new System.Windows.Forms.ComboBox();
            this.lblTitleListaDeItens = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gpbCamposDoAlimento.SuspendLayout();
            this.pnlDadosProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(287, 407);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 43);
            this.btnSair.TabIndex = 77;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.Location = new System.Drawing.Point(6, 407);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(126, 43);
            this.btnAtualizarDados.TabIndex = 76;
            this.btnAtualizarDados.Text = "Atualizar";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.btnAtualizarDados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(693, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 471);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Últimos Itens Adcionados";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 28);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(1074, 358);
            this.dgvProdutos.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(155, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 43);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(23, 407);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 43);
            this.btnCadastrar.TabIndex = 74;
            this.btnCadastrar.Text = "Registrar item";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(19, 41);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(146, 20);
            this.lblCodBarras.TabIndex = 70;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodBarras.Location = new System.Drawing.Point(23, 64);
            this.txtCodBarras.MaxLength = 13;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(390, 26);
            this.txtCodBarras.TabIndex = 53;
            this.txtCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(19, 317);
            this.lblUnidadeDeMedida.Name = "lblUnidadeDeMedida";
            this.lblUnidadeDeMedida.Size = new System.Drawing.Size(164, 20);
            this.lblUnidadeDeMedida.TabIndex = 67;
            this.lblUnidadeDeMedida.Text = "Unidade de Medida";
            // 
            // cbbUnidadeMedida
            // 
            this.cbbUnidadeMedida.FormattingEnabled = true;
            this.cbbUnidadeMedida.Items.AddRange(new object[] {
            "Quilogramas (Kg)",
            "Gramas (g)",
            "Litros (L)",
            "Mililitros (ml)",
            "Unidades (und)",
            "Caixas (cx)"});
            this.cbbUnidadeMedida.Location = new System.Drawing.Point(23, 340);
            this.cbbUnidadeMedida.Name = "cbbUnidadeMedida";
            this.cbbUnidadeMedida.Size = new System.Drawing.Size(236, 28);
            this.cbbUnidadeMedida.TabIndex = 61;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(294, 340);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(119, 26);
            this.txtPeso.TabIndex = 62;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(290, 317);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 63;
            this.lblPeso.Text = "Peso";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(23, 282);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(236, 26);
            this.txtQuantidade.TabIndex = 58;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(19, 259);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(102, 20);
            this.lblQuantidade.TabIndex = 60;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.Location = new System.Drawing.Point(290, 256);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(144, 20);
            this.lblDataValidade.TabIndex = 57;
            this.lblDataValidade.Text = "Data de validade";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataValidade.Location = new System.Drawing.Point(294, 279);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(119, 26);
            this.dtpDataValidade.TabIndex = 59;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(290, 204);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(140, 20);
            this.lblDataEntrada.TabIndex = 54;
            this.lblDataEntrada.Text = "Data de entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(294, 227);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(119, 26);
            this.dtpDataEntrada.TabIndex = 56;
            // 
            // txtNomeDoItem
            // 
            this.txtNomeDoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDoItem.Location = new System.Drawing.Point(23, 227);
            this.txtNomeDoItem.MaxLength = 100;
            this.txtNomeDoItem.Name = "txtNomeDoItem";
            this.txtNomeDoItem.Size = new System.Drawing.Size(236, 26);
            this.txtNomeDoItem.TabIndex = 55;
            // 
            // lblNomeDoItem
            // 
            this.lblNomeDoItem.AutoSize = true;
            this.lblNomeDoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoItem.Location = new System.Drawing.Point(19, 204);
            this.lblNomeDoItem.Name = "lblNomeDoItem";
            this.lblNomeDoItem.Size = new System.Drawing.Size(121, 20);
            this.lblNomeDoItem.TabIndex = 52;
            this.lblNomeDoItem.Text = "Nome do Item";
            // 
            // gpbCamposDoAlimento
            // 
            this.gpbCamposDoAlimento.Controls.Add(this.lblTitleListaDeItens);
            this.gpbCamposDoAlimento.Controls.Add(this.cbbListaDeItensPreRegistrados);
            this.gpbCamposDoAlimento.Controls.Add(this.lblCodBarras);
            this.gpbCamposDoAlimento.Controls.Add(this.btnSair);
            this.gpbCamposDoAlimento.Controls.Add(this.txtCodBarras);
            this.gpbCamposDoAlimento.Controls.Add(this.lblUnidadeDeMedida);
            this.gpbCamposDoAlimento.Controls.Add(this.cbbUnidadeMedida);
            this.gpbCamposDoAlimento.Controls.Add(this.btnCancelar);
            this.gpbCamposDoAlimento.Controls.Add(this.txtPeso);
            this.gpbCamposDoAlimento.Controls.Add(this.btnCadastrar);
            this.gpbCamposDoAlimento.Controls.Add(this.lblPeso);
            this.gpbCamposDoAlimento.Controls.Add(this.txtQuantidade);
            this.gpbCamposDoAlimento.Controls.Add(this.lblQuantidade);
            this.gpbCamposDoAlimento.Controls.Add(this.lblDataValidade);
            this.gpbCamposDoAlimento.Controls.Add(this.dtpDataValidade);
            this.gpbCamposDoAlimento.Controls.Add(this.lblDataEntrada);
            this.gpbCamposDoAlimento.Controls.Add(this.dtpDataEntrada);
            this.gpbCamposDoAlimento.Controls.Add(this.txtNomeDoItem);
            this.gpbCamposDoAlimento.Controls.Add(this.lblNomeDoItem);
            this.gpbCamposDoAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCamposDoAlimento.Location = new System.Drawing.Point(12, 188);
            this.gpbCamposDoAlimento.Name = "gpbCamposDoAlimento";
            this.gpbCamposDoAlimento.Size = new System.Drawing.Size(675, 650);
            this.gpbCamposDoAlimento.TabIndex = 72;
            this.gpbCamposDoAlimento.TabStop = false;
            this.gpbCamposDoAlimento.Text = "Registro de Produtos";
            // 
            // pnlDadosProdutos
            // 
            this.pnlDadosProdutos.AutoSize = true;
            this.pnlDadosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlDadosProdutos.Controls.Add(this.lblTitleDashboard);
            this.pnlDadosProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDadosProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlDadosProdutos.Name = "pnlDadosProdutos";
            this.pnlDadosProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlDadosProdutos.Size = new System.Drawing.Size(1884, 39);
            this.pnlDadosProdutos.TabIndex = 78;
            // 
            // lblTitleDashboard
            // 
            this.lblTitleDashboard.AutoSize = true;
            this.lblTitleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblTitleDashboard.Name = "lblTitleDashboard";
            this.lblTitleDashboard.Size = new System.Drawing.Size(191, 20);
            this.lblTitleDashboard.TabIndex = 12;
            this.lblTitleDashboard.Text = "Cadastro de Alimentos";
            // 
            // cbbListaDeItensPreRegistrados
            // 
            this.cbbListaDeItensPreRegistrados.FormattingEnabled = true;
            this.cbbListaDeItensPreRegistrados.Location = new System.Drawing.Point(23, 130);
            this.cbbListaDeItensPreRegistrados.Name = "cbbListaDeItensPreRegistrados";
            this.cbbListaDeItensPreRegistrados.Size = new System.Drawing.Size(390, 28);
            this.cbbListaDeItensPreRegistrados.TabIndex = 78;
            // 
            // lblTitleListaDeItens
            // 
            this.lblTitleListaDeItens.AutoSize = true;
            this.lblTitleListaDeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleListaDeItens.Location = new System.Drawing.Point(19, 107);
            this.lblTitleListaDeItens.Name = "lblTitleListaDeItens";
            this.lblTitleListaDeItens.Size = new System.Drawing.Size(117, 20);
            this.lblTitleListaDeItens.TabIndex = 79;
            this.lblTitleListaDeItens.Text = "Lista de itens";
            // 
            // frmCadastrarAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.pnlDadosProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbCamposDoAlimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastrarAlimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Cadastrar Alimentos";
            this.Load += new System.EventHandler(this.frmCadastrarAlimentos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gpbCamposDoAlimento.ResumeLayout(false);
            this.gpbCamposDoAlimento.PerformLayout();
            this.pnlDadosProdutos.ResumeLayout(false);
            this.pnlDadosProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
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
        private System.Windows.Forms.TextBox txtNomeDoItem;
        private System.Windows.Forms.Label lblNomeDoItem;
        private System.Windows.Forms.GroupBox gpbCamposDoAlimento;
        private System.Windows.Forms.Panel pnlDadosProdutos;
        private System.Windows.Forms.Label lblTitleDashboard;
        private System.Windows.Forms.Label lblTitleListaDeItens;
        private System.Windows.Forms.ComboBox cbbListaDeItensPreRegistrados;
    }
}