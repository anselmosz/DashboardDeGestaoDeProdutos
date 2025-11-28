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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.lblTitleRelatórios = new System.Windows.Forms.Label();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
            this.gpbFiltrosDoRelatorio = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltrosDeBusca.SuspendLayout();
            this.gpbFiltrosDoRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.AutoSize = true;
            this.pnlFiltrosDeBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlFiltrosDeBusca.Controls.Add(this.lblTitleRelatórios);
            this.pnlFiltrosDeBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosDeBusca.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1198, 41);
            this.pnlFiltrosDeBusca.TabIndex = 4;
            // 
            // lblTitleRelatórios
            // 
            this.lblTitleRelatórios.AutoSize = true;
            this.lblTitleRelatórios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleRelatórios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleRelatórios.Location = new System.Drawing.Point(12, 9);
            this.lblTitleRelatórios.Name = "lblTitleRelatórios";
            this.lblTitleRelatórios.Size = new System.Drawing.Size(93, 22);
            this.lblTitleRelatórios.TabIndex = 11;
            this.lblTitleRelatórios.Text = "Relatórios";
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Location = new System.Drawing.Point(1556, 81);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(142, 41);
            this.btnLimparFiltros.TabIndex = 9;
            this.btnLimparFiltros.Text = "&Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Location = new System.Drawing.Point(1408, 81);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(142, 41);
            this.btnAplicarFiltros.TabIndex = 8;
            this.btnAplicarFiltros.Text = "&Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblE.Location = new System.Drawing.Point(237, 35);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(38, 21);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "Fim";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataInicial.Location = new System.Drawing.Point(15, 35);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(51, 21);
            this.lblDataInicial.TabIndex = 4;
            this.lblDataInicial.Text = "Inicio";
            // 
            // dtpDataFinalPeriodo
            // 
            this.dtpDataFinalPeriodo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPeriodo.Location = new System.Drawing.Point(278, 35);
            this.dtpDataFinalPeriodo.Name = "dtpDataFinalPeriodo";
            this.dtpDataFinalPeriodo.Size = new System.Drawing.Size(136, 29);
            this.dtpDataFinalPeriodo.TabIndex = 2;
            // 
            // dtpDataInicialPeriodo
            // 
            this.dtpDataInicialPeriodo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPeriodo.Location = new System.Drawing.Point(67, 35);
            this.dtpDataInicialPeriodo.Name = "dtpDataInicialPeriodo";
            this.dtpDataInicialPeriodo.Size = new System.Drawing.Size(136, 29);
            this.dtpDataInicialPeriodo.TabIndex = 1;
            // 
            // btnExportarRelatorio
            // 
            this.btnExportarRelatorio.Location = new System.Drawing.Point(1408, 31);
            this.btnExportarRelatorio.Name = "btnExportarRelatorio";
            this.btnExportarRelatorio.Size = new System.Drawing.Size(290, 41);
            this.btnExportarRelatorio.TabIndex = 0;
            this.btnExportarRelatorio.Text = "&Exportar relatório em XLS";
            this.btnExportarRelatorio.UseVisualStyleBackColor = true;
            this.btnExportarRelatorio.Click += new System.EventHandler(this.btnExportarRelatorio_Click);
            // 
            // gpbFiltrosDoRelatorio
            // 
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnPesquisar);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnSair);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnLimparFiltros);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnExportarRelatorio);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnAplicarFiltros);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.dtpDataFinalPeriodo);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.lblE);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.lblDataInicial);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.dtpDataInicialPeriodo);
            this.gpbFiltrosDoRelatorio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltrosDoRelatorio.Location = new System.Drawing.Point(8, 45);
            this.gpbFiltrosDoRelatorio.Name = "gpbFiltrosDoRelatorio";
            this.gpbFiltrosDoRelatorio.Padding = new System.Windows.Forms.Padding(0);
            this.gpbFiltrosDoRelatorio.Size = new System.Drawing.Size(1186, 75);
            this.gpbFiltrosDoRelatorio.TabIndex = 16;
            this.gpbFiltrosDoRelatorio.TabStop = false;
            this.gpbFiltrosDoRelatorio.Text = "Filtros";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(1045, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 40);
            this.btnPesquisar.TabIndex = 80;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1711, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 41);
            this.btnSair.TabIndex = 78;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 126);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(1174, 524);
            this.dgvProdutos.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome do Produto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantidade";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unidade";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data de Entrada";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // frmRelatorios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1198, 662);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.gpbFiltrosDoRelatorio);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.pnlFiltrosDeBusca.ResumeLayout(false);
            this.pnlFiltrosDeBusca.PerformLayout();
            this.gpbFiltrosDoRelatorio.ResumeLayout(false);
            this.gpbFiltrosDoRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltrosDeBusca;
        private System.Windows.Forms.Button btnExportarRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataFinalPeriodo;
        private System.Windows.Forms.DateTimePicker dtpDataInicialPeriodo;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.Label lblTitleRelatórios;
        private System.Windows.Forms.GroupBox gpbFiltrosDoRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}