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
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
            this.dtpDataInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.lblBuscarPorPeriodo = new System.Windows.Forms.Label();
            this.lblEntre = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.rdbtnDataDeEntrada = new System.Windows.Forms.RadioButton();
            this.rdbtnDataDeSaida = new System.Windows.Forms.RadioButton();
            this.btnAtualizarRelatorio = new System.Windows.Forms.Button();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quemCadastrou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.pnlFiltrosDeBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Location = new System.Drawing.Point(12, 9);
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
            this.quemCadastrou,
            this.dtValidade});
            this.dgvRelatorio.Location = new System.Drawing.Point(12, 179);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.RowHeadersWidth = 51;
            this.dgvRelatorio.Size = new System.Drawing.Size(1040, 490);
            this.dgvRelatorio.TabIndex = 3;
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.Controls.Add(this.btnLimparFiltros);
            this.pnlFiltrosDeBusca.Controls.Add(this.btnAtualizarRelatorio);
            this.pnlFiltrosDeBusca.Controls.Add(this.rdbtnDataDeSaida);
            this.pnlFiltrosDeBusca.Controls.Add(this.rdbtnDataDeEntrada);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblE);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblEntre);
            this.pnlFiltrosDeBusca.Controls.Add(this.lblBuscarPorPeriodo);
            this.pnlFiltrosDeBusca.Controls.Add(this.dtpDataFinalPeriodo);
            this.pnlFiltrosDeBusca.Controls.Add(this.dtpDataInicialPeriodo);
            this.pnlFiltrosDeBusca.Controls.Add(this.btnExportarRelatorio);
            this.pnlFiltrosDeBusca.Location = new System.Drawing.Point(12, 32);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1040, 141);
            this.pnlFiltrosDeBusca.TabIndex = 4;
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
            // dtpDataInicialPeriodo
            // 
            this.dtpDataInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPeriodo.Location = new System.Drawing.Point(66, 73);
            this.dtpDataInicialPeriodo.Name = "dtpDataInicialPeriodo";
            this.dtpDataInicialPeriodo.Size = new System.Drawing.Size(102, 26);
            this.dtpDataInicialPeriodo.TabIndex = 1;
            // 
            // dtpDataFinalPeriodo
            // 
            this.dtpDataFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPeriodo.Location = new System.Drawing.Point(200, 73);
            this.dtpDataFinalPeriodo.Name = "dtpDataFinalPeriodo";
            this.dtpDataFinalPeriodo.Size = new System.Drawing.Size(102, 26);
            this.dtpDataFinalPeriodo.TabIndex = 2;
            // 
            // lblBuscarPorPeriodo
            // 
            this.lblBuscarPorPeriodo.AutoSize = true;
            this.lblBuscarPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorPeriodo.Location = new System.Drawing.Point(7, 10);
            this.lblBuscarPorPeriodo.Name = "lblBuscarPorPeriodo";
            this.lblBuscarPorPeriodo.Size = new System.Drawing.Size(161, 20);
            this.lblBuscarPorPeriodo.TabIndex = 3;
            this.lblBuscarPorPeriodo.Text = "Buscar por período";
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Location = new System.Drawing.Point(12, 78);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(48, 20);
            this.lblEntre.TabIndex = 4;
            this.lblEntre.Text = "Entre";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(176, 77);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(18, 20);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "e";
            // 
            // rdbtnDataDeEntrada
            // 
            this.rdbtnDataDeEntrada.AutoSize = true;
            this.rdbtnDataDeEntrada.Location = new System.Drawing.Point(11, 43);
            this.rdbtnDataDeEntrada.Name = "rdbtnDataDeEntrada";
            this.rdbtnDataDeEntrada.Size = new System.Drawing.Size(145, 24);
            this.rdbtnDataDeEntrada.TabIndex = 6;
            this.rdbtnDataDeEntrada.TabStop = true;
            this.rdbtnDataDeEntrada.Text = "Data de Entrada";
            this.rdbtnDataDeEntrada.UseVisualStyleBackColor = true;
            // 
            // rdbtnDataDeSaida
            // 
            this.rdbtnDataDeSaida.AutoSize = true;
            this.rdbtnDataDeSaida.Location = new System.Drawing.Point(162, 43);
            this.rdbtnDataDeSaida.Name = "rdbtnDataDeSaida";
            this.rdbtnDataDeSaida.Size = new System.Drawing.Size(129, 24);
            this.rdbtnDataDeSaida.TabIndex = 7;
            this.rdbtnDataDeSaida.TabStop = true;
            this.rdbtnDataDeSaida.Text = "Data de Saída";
            this.rdbtnDataDeSaida.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarRelatorio
            // 
            this.btnAtualizarRelatorio.Location = new System.Drawing.Point(810, 50);
            this.btnAtualizarRelatorio.Name = "btnAtualizarRelatorio";
            this.btnAtualizarRelatorio.Size = new System.Drawing.Size(227, 41);
            this.btnAtualizarRelatorio.TabIndex = 8;
            this.btnAtualizarRelatorio.Text = "Atualizar Relatório";
            this.btnAtualizarRelatorio.UseVisualStyleBackColor = true;
            this.btnAtualizarRelatorio.Click += new System.EventHandler(this.btnAtualizarRelatorio_Click);
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Location = new System.Drawing.Point(810, 97);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(227, 41);
            this.btnLimparFiltros.TabIndex = 9;
            this.btnLimparFiltros.Text = "Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
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
            // quemCadastrou
            // 
            this.quemCadastrou.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quemCadastrou.HeaderText = "Adicionado por";
            this.quemCadastrou.MaxInputLength = 100;
            this.quemCadastrou.MinimumWidth = 6;
            this.quemCadastrou.Name = "quemCadastrou";
            // 
            // dtValidade
            // 
            this.dtValidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtValidade.HeaderText = "Data de Validade";
            this.dtValidade.MaxInputLength = 100;
            this.dtValidade.Name = "dtValidade";
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
        private System.Windows.Forms.Label lblEntre;
        private System.Windows.Forms.Label lblBuscarPorPeriodo;
        private System.Windows.Forms.RadioButton rdbtnDataDeSaida;
        private System.Windows.Forms.RadioButton rdbtnDataDeEntrada;
        private System.Windows.Forms.Button btnAtualizarRelatorio;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn quemCadastrou;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtValidade;
    }
}