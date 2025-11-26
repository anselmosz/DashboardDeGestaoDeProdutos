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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.lblTitleRelatórios = new System.Windows.Forms.Label();
            this.chkbListaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkbDataEntrada = new System.Windows.Forms.CheckBox();
            this.cbbListaDeUsuarios = new System.Windows.Forms.ComboBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
            this.dgvRelatorioDeProdutos = new System.Windows.Forms.DataGridView();
            this.gpbFiltrosDoRelatorio = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlFiltrosDeBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioDeProdutos)).BeginInit();
            this.gpbFiltrosDoRelatorio.SuspendLayout();
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
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1884, 39);
            this.pnlFiltrosDeBusca.TabIndex = 4;
            // 
            // lblTitleRelatórios
            // 
            this.lblTitleRelatórios.AutoSize = true;
            this.lblTitleRelatórios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleRelatórios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleRelatórios.Location = new System.Drawing.Point(12, 9);
            this.lblTitleRelatórios.Name = "lblTitleRelatórios";
            this.lblTitleRelatórios.Size = new System.Drawing.Size(91, 20);
            this.lblTitleRelatórios.TabIndex = 11;
            this.lblTitleRelatórios.Text = "Relatórios";
            // 
            // chkbListaUsuarios
            // 
            this.chkbListaUsuarios.AutoSize = true;
            this.chkbListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListaUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbListaUsuarios.Location = new System.Drawing.Point(215, 31);
            this.chkbListaUsuarios.Name = "chkbListaUsuarios";
            this.chkbListaUsuarios.Size = new System.Drawing.Size(177, 24);
            this.chkbListaUsuarios.TabIndex = 15;
            this.chkbListaUsuarios.Text = "Selecionar usuário";
            this.chkbListaUsuarios.UseVisualStyleBackColor = true;
            this.chkbListaUsuarios.CheckedChanged += new System.EventHandler(this.chkbListaUsuarios_CheckedChanged);
            // 
            // chkbDataEntrada
            // 
            this.chkbDataEntrada.AutoSize = true;
            this.chkbDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbDataEntrada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbDataEntrada.Location = new System.Drawing.Point(18, 31);
            this.chkbDataEntrada.Name = "chkbDataEntrada";
            this.chkbDataEntrada.Size = new System.Drawing.Size(181, 24);
            this.chkbDataEntrada.TabIndex = 14;
            this.chkbDataEntrada.Text = "Período de entrada";
            this.chkbDataEntrada.UseVisualStyleBackColor = true;
            this.chkbDataEntrada.CheckedChanged += new System.EventHandler(this.chkbDataEntrada_CheckedChanged);
            // 
            // cbbListaDeUsuarios
            // 
            this.cbbListaDeUsuarios.FormattingEnabled = true;
            this.cbbListaDeUsuarios.Items.AddRange(new object[] {
            "Todos"});
            this.cbbListaDeUsuarios.Location = new System.Drawing.Point(218, 64);
            this.cbbListaDeUsuarios.Name = "cbbListaDeUsuarios";
            this.cbbListaDeUsuarios.Size = new System.Drawing.Size(222, 28);
            this.cbbListaDeUsuarios.TabIndex = 12;
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimparFiltros.Location = new System.Drawing.Point(1435, 81);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(142, 41);
            this.btnLimparFiltros.TabIndex = 9;
            this.btnLimparFiltros.Text = "Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(1287, 81);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(142, 41);
            this.btnAplicarFiltros.TabIndex = 8;
            this.btnAplicarFiltros.Text = "Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblE.Location = new System.Drawing.Point(35, 99);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(35, 20);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "Fim";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataInicial.Location = new System.Drawing.Point(24, 67);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(46, 20);
            this.lblDataInicial.TabIndex = 4;
            this.lblDataInicial.Text = "Inicio";
            // 
            // dtpDataFinalPeriodo
            // 
            this.dtpDataFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPeriodo.Location = new System.Drawing.Point(76, 96);
            this.dtpDataFinalPeriodo.Name = "dtpDataFinalPeriodo";
            this.dtpDataFinalPeriodo.Size = new System.Drawing.Size(100, 26);
            this.dtpDataFinalPeriodo.TabIndex = 2;
            // 
            // dtpDataInicialPeriodo
            // 
            this.dtpDataInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPeriodo.Location = new System.Drawing.Point(76, 64);
            this.dtpDataInicialPeriodo.Name = "dtpDataInicialPeriodo";
            this.dtpDataInicialPeriodo.Size = new System.Drawing.Size(100, 26);
            this.dtpDataInicialPeriodo.TabIndex = 1;
            // 
            // btnExportarRelatorio
            // 
            this.btnExportarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarRelatorio.Location = new System.Drawing.Point(1287, 31);
            this.btnExportarRelatorio.Name = "btnExportarRelatorio";
            this.btnExportarRelatorio.Size = new System.Drawing.Size(290, 41);
            this.btnExportarRelatorio.TabIndex = 0;
            this.btnExportarRelatorio.Text = "Exportar relatório em XLS";
            this.btnExportarRelatorio.UseVisualStyleBackColor = true;
            this.btnExportarRelatorio.Click += new System.EventHandler(this.btnExportarRelatorio_Click);
            // 
            // dgvRelatorioDeProdutos
            // 
            this.dgvRelatorioDeProdutos.AllowUserToAddRows = false;
            this.dgvRelatorioDeProdutos.AllowUserToDeleteRows = false;
            this.dgvRelatorioDeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRelatorioDeProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRelatorioDeProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorioDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioDeProdutos.Location = new System.Drawing.Point(12, 193);
            this.dgvRelatorioDeProdutos.Name = "dgvRelatorioDeProdutos";
            this.dgvRelatorioDeProdutos.ReadOnly = true;
            this.dgvRelatorioDeProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRelatorioDeProdutos.Size = new System.Drawing.Size(1860, 706);
            this.dgvRelatorioDeProdutos.TabIndex = 16;
            // 
            // gpbFiltrosDoRelatorio
            // 
            this.gpbFiltrosDoRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnSair);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnLimparFiltros);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.chkbListaUsuarios);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnExportarRelatorio);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.btnAplicarFiltros);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.chkbDataEntrada);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.dtpDataFinalPeriodo);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.lblE);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.cbbListaDeUsuarios);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.lblDataInicial);
            this.gpbFiltrosDoRelatorio.Controls.Add(this.dtpDataInicialPeriodo);
            this.gpbFiltrosDoRelatorio.Location = new System.Drawing.Point(12, 45);
            this.gpbFiltrosDoRelatorio.Name = "gpbFiltrosDoRelatorio";
            this.gpbFiltrosDoRelatorio.Padding = new System.Windows.Forms.Padding(0);
            this.gpbFiltrosDoRelatorio.Size = new System.Drawing.Size(1860, 142);
            this.gpbFiltrosDoRelatorio.TabIndex = 16;
            this.gpbFiltrosDoRelatorio.TabStop = false;
            this.gpbFiltrosDoRelatorio.Text = "Filtros";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1711, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 41);
            this.btnSair.TabIndex = 78;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.dgvRelatorioDeProdutos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioDeProdutos)).EndInit();
            this.gpbFiltrosDoRelatorio.ResumeLayout(false);
            this.gpbFiltrosDoRelatorio.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbbListaDeUsuarios;
        private System.Windows.Forms.CheckBox chkbDataEntrada;
        private System.Windows.Forms.CheckBox chkbListaUsuarios;
        private System.Windows.Forms.DataGridView dgvRelatorioDeProdutos;
        private System.Windows.Forms.GroupBox gpbFiltrosDoRelatorio;
        private System.Windows.Forms.Button btnSair;
    }
}