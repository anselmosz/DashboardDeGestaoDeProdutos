namespace GPSFA_WinForms
{
    partial class frmRelatorios
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
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quemCadastrou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
            this.lblTitleFiltros = new System.Windows.Forms.Label();
            this.cbbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblTitlePesquisarUsuario = new System.Windows.Forms.Label();
            this.ckbDataEntrada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.pnlFiltrosDeBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Location = new System.Drawing.Point(8, 9);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(81, 20);
            this.lblRelatorios.TabIndex = 2;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProduto,
            this.quantidade,
            this.pesoUnd,
            this.dtEntrada,
            this.dtValidade,
            this.quemCadastrou});
            this.dgvRelatorio.Location = new System.Drawing.Point(12, 222);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.RowHeadersWidth = 51;
            this.dgvRelatorio.Size = new System.Drawing.Size(1040, 447);
            this.dgvRelatorio.TabIndex = 3;
            // 
            // nomeProduto
            // 
            this.nomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.MaxInputLength = 100;
            this.nomeProduto.MinimumWidth = 6;
            this.nomeProduto.Name = "nomeProduto";
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MaxInputLength = 10;
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            // 
            // pesoUnd
            // 
            this.pesoUnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pesoUnd.HeaderText = "Peso";
            this.pesoUnd.MaxInputLength = 10;
            this.pesoUnd.MinimumWidth = 6;
            this.pesoUnd.Name = "pesoUnd";
            // 
            // dtEntrada
            // 
            this.dtEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtEntrada.HeaderText = "Data de Entrada";
            this.dtEntrada.MaxInputLength = 20;
            this.dtEntrada.MinimumWidth = 6;
            this.dtEntrada.Name = "dtEntrada";
            // 
            // dtValidade
            // 
            this.dtValidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtValidade.HeaderText = "Data de Validade";
            this.dtValidade.MaxInputLength = 100;
            this.dtValidade.Name = "dtValidade";
            // 
            // quemCadastrou
            // 
            this.quemCadastrou.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quemCadastrou.HeaderText = "Adicionado por";
            this.quemCadastrou.MaxInputLength = 100;
            this.quemCadastrou.MinimumWidth = 6;
            this.quemCadastrou.Name = "quemCadastrou";
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.Controls.Add(this.ckbDataEntrada);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblTitlePesquisarUsuario);
            this.pnlFiltrosDeBusca.Controls.Add(this.cbbUsuarios);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblTitleFiltros);
            this.pnlFiltrosDeBusca.Controls.Add(this.btnLimparFiltros);
            this.pnlFiltrosDeBusca.Controls.Add(this.btnAplicarFiltros);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblE);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblDataInicial);
            this.pnlFiltrosDeBusca.Controls.Add(this.dtpDataFinalPeriodo);
            this.pnlFiltrosDeBusca.Controls.Add(this.dtpDataInicialPeriodo);
            this.pnlFiltrosDeBusca.Controls.Add(this.btnExportarRelatorio);
            this.pnlFiltrosDeBusca.Location = new System.Drawing.Point(12, 32);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1040, 184);
            this.pnlFiltrosDeBusca.TabIndex = 4;
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Location = new System.Drawing.Point(690, 3);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(114, 41);
            this.btnLimparFiltros.TabIndex = 9;
            this.btnLimparFiltros.Text = "Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Location = new System.Drawing.Point(570, 3);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(114, 41);
            this.btnAplicarFiltros.TabIndex = 8;
            this.btnAplicarFiltros.Text = "Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(23, 91);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(35, 20);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "Fim";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(11, 59);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(46, 20);
            this.lblDataInicial.TabIndex = 4;
            this.lblDataInicial.Text = "Inicio";
            // 
            // dtpDataFinalPeriodo
            // 
            this.dtpDataFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPeriodo.Location = new System.Drawing.Point(63, 88);
            this.dtpDataFinalPeriodo.Name = "dtpDataFinalPeriodo";
            this.dtpDataFinalPeriodo.Size = new System.Drawing.Size(102, 26);
            this.dtpDataFinalPeriodo.TabIndex = 2;
            // 
            // dtpDataInicialPeriodo
            // 
            this.dtpDataInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPeriodo.Location = new System.Drawing.Point(63, 56);
            this.dtpDataInicialPeriodo.Name = "dtpDataInicialPeriodo";
            this.dtpDataInicialPeriodo.Size = new System.Drawing.Size(102, 26);
            this.dtpDataInicialPeriodo.TabIndex = 1;
            // 
            // btnExportarRelatorio
            // 
            this.btnExportarRelatorio.Location = new System.Drawing.Point(810, 3);
            this.btnExportarRelatorio.Name = "btnExportarRelatorio";
            this.btnExportarRelatorio.Size = new System.Drawing.Size(227, 41);
            this.btnExportarRelatorio.TabIndex = 0;
            this.btnExportarRelatorio.Text = "Exportar relatório em XLS";
            this.btnExportarRelatorio.UseVisualStyleBackColor = true;
            // 
            // lblTitleFiltros
            // 
            this.lblTitleFiltros.AutoSize = true;
            this.lblTitleFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFiltros.Location = new System.Drawing.Point(3, 3);
            this.lblTitleFiltros.Name = "lblTitleFiltros";
            this.lblTitleFiltros.Size = new System.Drawing.Size(59, 20);
            this.lblTitleFiltros.TabIndex = 11;
            this.lblTitleFiltros.Text = "Filtros";
            // 
            // cbbUsuarios
            // 
            this.cbbUsuarios.FormattingEnabled = true;
            this.cbbUsuarios.Items.AddRange(new object[] {
            "Todos"});
            this.cbbUsuarios.Location = new System.Drawing.Point(9, 146);
            this.cbbUsuarios.Name = "cbbUsuarios";
            this.cbbUsuarios.Size = new System.Drawing.Size(317, 28);
            this.cbbUsuarios.TabIndex = 12;
            // 
            // lblTitlePesquisarUsuario
            // 
            this.lblTitlePesquisarUsuario.AutoSize = true;
            this.lblTitlePesquisarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePesquisarUsuario.Location = new System.Drawing.Point(5, 123);
            this.lblTitlePesquisarUsuario.Name = "lblTitlePesquisarUsuario";
            this.lblTitlePesquisarUsuario.Size = new System.Drawing.Size(155, 20);
            this.lblTitlePesquisarUsuario.TabIndex = 13;
            this.lblTitlePesquisarUsuario.Text = "Pesquisar Usuário";
            // 
            // ckbDataEntrada
            // 
            this.ckbDataEntrada.AutoSize = true;
            this.ckbDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDataEntrada.Location = new System.Drawing.Point(15, 32);
            this.ckbDataEntrada.Name = "ckbDataEntrada";
            this.ckbDataEntrada.Size = new System.Drawing.Size(181, 24);
            this.ckbDataEntrada.TabIndex = 14;
            this.ckbDataEntrada.Text = "Período de entrada";
            this.ckbDataEntrada.UseVisualStyleBackColor = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.lblRelatorios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.pnlFiltrosDeBusca.ResumeLayout(false);
            this.pnlFiltrosDeBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Panel pnlFiltrosDeBusca;
        private System.Windows.Forms.Button btnExportarRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataFinalPeriodo;
        private System.Windows.Forms.DateTimePicker dtpDataInicialPeriodo;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn quemCadastrou;
        private System.Windows.Forms.Label lblTitleFiltros;
        private System.Windows.Forms.Label lblTitlePesquisarUsuario;
        private System.Windows.Forms.ComboBox cbbUsuarios;
        private System.Windows.Forms.CheckBox ckbDataEntrada;
    }
}