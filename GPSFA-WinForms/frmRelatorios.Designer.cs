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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.chkbListaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkbDataEntrada = new System.Windows.Forms.CheckBox();
            this.cbbListaDeUsuarios = new System.Windows.Forms.ComboBox();
            this.lblTitleRelatórios = new System.Windows.Forms.Label();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
            this.gpbFiltrosDoRelatorio = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.pnlFiltrosDeBusca.SuspendLayout();
            this.gpbFiltrosDoRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(12, 193);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowHeadersWidth = 51;
            this.dgvRelatorio.Size = new System.Drawing.Size(1020, 476);
            this.dgvRelatorio.TabIndex = 3;
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
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1044, 39);
            this.pnlFiltrosDeBusca.TabIndex = 4;
            // 
            // chkbListaUsuarios
            // 
            this.chkbListaUsuarios.AutoSize = true;
            this.chkbListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListaUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbListaUsuarios.Location = new System.Drawing.Point(207, 29);
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
            this.chkbDataEntrada.Location = new System.Drawing.Point(10, 29);
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
            this.cbbListaDeUsuarios.Location = new System.Drawing.Point(210, 62);
            this.cbbListaDeUsuarios.Name = "cbbListaDeUsuarios";
            this.cbbListaDeUsuarios.Size = new System.Drawing.Size(222, 28);
            this.cbbListaDeUsuarios.TabIndex = 12;
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
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimparFiltros.Location = new System.Drawing.Point(875, 78);
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
            this.btnAplicarFiltros.Location = new System.Drawing.Point(727, 78);
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
            this.lblE.Location = new System.Drawing.Point(24, 91);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(35, 20);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "Fim";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataInicial.Location = new System.Drawing.Point(13, 59);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(46, 20);
            this.lblDataInicial.TabIndex = 4;
            this.lblDataInicial.Text = "Inicio";
            // 
            // dtpDataFinalPeriodo
            // 
            this.dtpDataFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPeriodo.Location = new System.Drawing.Point(68, 94);
            this.dtpDataFinalPeriodo.Name = "dtpDataFinalPeriodo";
            this.dtpDataFinalPeriodo.Size = new System.Drawing.Size(100, 26);
            this.dtpDataFinalPeriodo.TabIndex = 2;
            // 
            // dtpDataInicialPeriodo
            // 
            this.dtpDataInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPeriodo.Location = new System.Drawing.Point(68, 62);
            this.dtpDataInicialPeriodo.Name = "dtpDataInicialPeriodo";
            this.dtpDataInicialPeriodo.Size = new System.Drawing.Size(100, 26);
            this.dtpDataInicialPeriodo.TabIndex = 1;
            // 
            // btnExportarRelatorio
            // 
            this.btnExportarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarRelatorio.Location = new System.Drawing.Point(727, 28);
            this.btnExportarRelatorio.Name = "btnExportarRelatorio";
            this.btnExportarRelatorio.Size = new System.Drawing.Size(290, 41);
            this.btnExportarRelatorio.TabIndex = 0;
            this.btnExportarRelatorio.Text = "Exportar relatório em XLS";
            this.btnExportarRelatorio.UseVisualStyleBackColor = true;
            // 
            // gpbFiltrosDoRelatorio
            // 
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
            this.gpbFiltrosDoRelatorio.Size = new System.Drawing.Size(1020, 142);
            this.gpbFiltrosDoRelatorio.TabIndex = 16;
            this.gpbFiltrosDoRelatorio.TabStop = false;
            this.gpbFiltrosDoRelatorio.Text = "Filtros de pesquisa";
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1044, 681);
            this.Controls.Add(this.gpbFiltrosDoRelatorio);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.Controls.Add(this.dgvRelatorio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.pnlFiltrosDeBusca.ResumeLayout(false);
            this.pnlFiltrosDeBusca.PerformLayout();
            this.gpbFiltrosDoRelatorio.ResumeLayout(false);
            this.gpbFiltrosDoRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRelatorio;
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
        private System.Windows.Forms.GroupBox gpbFiltrosDoRelatorio;
    }
}