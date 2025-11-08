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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.chkbListaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkbDataEntrada = new System.Windows.Forms.CheckBox();
            this.cbbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblTitleFiltros = new System.Windows.Forms.Label();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(12, 273);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.RowHeadersWidth = 51;
            this.dgvRelatorio.Size = new System.Drawing.Size(1039, 396);
            this.dgvRelatorio.TabIndex = 3;
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.Controls.Add(this.chkbListaUsuarios);
            this.pnlFiltrosDeBusca.Controls.Add(this.chkbDataEntrada);
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
            this.pnlFiltrosDeBusca.MaximumSize = new System.Drawing.Size(1182, 681);
            this.pnlFiltrosDeBusca.MinimumSize = new System.Drawing.Size(1039, 235);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1039, 235);
            this.pnlFiltrosDeBusca.TabIndex = 4;
            // 
            // chkbListaUsuarios
            // 
            this.chkbListaUsuarios.AutoSize = true;
            this.chkbListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListaUsuarios.Location = new System.Drawing.Point(14, 142);
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
            this.chkbDataEntrada.Location = new System.Drawing.Point(15, 32);
            this.chkbDataEntrada.Name = "chkbDataEntrada";
            this.chkbDataEntrada.Size = new System.Drawing.Size(181, 24);
            this.chkbDataEntrada.TabIndex = 14;
            this.chkbDataEntrada.Text = "Período de entrada";
            this.chkbDataEntrada.UseVisualStyleBackColor = true;
            this.chkbDataEntrada.CheckedChanged += new System.EventHandler(this.chkbDataEntrada_CheckedChanged);
            // 
            // cbbUsuarios
            // 
            this.cbbUsuarios.FormattingEnabled = true;
            this.cbbUsuarios.Items.AddRange(new object[] {
            "Todos"});
            this.cbbUsuarios.Location = new System.Drawing.Point(15, 177);
            this.cbbUsuarios.Name = "cbbUsuarios";
            this.cbbUsuarios.Size = new System.Drawing.Size(317, 28);
            this.cbbUsuarios.TabIndex = 12;
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
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Location = new System.Drawing.Point(922, 50);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(114, 41);
            this.btnLimparFiltros.TabIndex = 9;
            this.btnLimparFiltros.Text = "Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Location = new System.Drawing.Point(802, 50);
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
            this.lblE.Location = new System.Drawing.Point(33, 103);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(35, 20);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "Fim";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(20, 67);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(46, 20);
            this.lblDataInicial.TabIndex = 4;
            this.lblDataInicial.Text = "Inicio";
            // 
            // dtpDataFinalPeriodo
            // 
            this.dtpDataFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPeriodo.Location = new System.Drawing.Point(81, 98);
            this.dtpDataFinalPeriodo.Name = "dtpDataFinalPeriodo";
            this.dtpDataFinalPeriodo.Size = new System.Drawing.Size(124, 26);
            this.dtpDataFinalPeriodo.TabIndex = 2;
            // 
            // dtpDataInicialPeriodo
            // 
            this.dtpDataInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPeriodo.Location = new System.Drawing.Point(81, 62);
            this.dtpDataInicialPeriodo.Name = "dtpDataInicialPeriodo";
            this.dtpDataInicialPeriodo.Size = new System.Drawing.Size(124, 26);
            this.dtpDataInicialPeriodo.TabIndex = 1;
            // 
            // btnExportarRelatorio
            // 
            this.btnExportarRelatorio.Location = new System.Drawing.Point(802, 3);
            this.btnExportarRelatorio.Name = "btnExportarRelatorio";
            this.btnExportarRelatorio.Size = new System.Drawing.Size(234, 41);
            this.btnExportarRelatorio.TabIndex = 0;
            this.btnExportarRelatorio.Text = "Exportar relatório em XLS";
            this.btnExportarRelatorio.UseVisualStyleBackColor = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 681);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.lblRelatorios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1182, 681);
            this.MinimumSize = new System.Drawing.Size(1063, 681);
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
        private System.Windows.Forms.Label lblTitleFiltros;
        private System.Windows.Forms.ComboBox cbbUsuarios;
        private System.Windows.Forms.CheckBox chkbDataEntrada;
        private System.Windows.Forms.CheckBox chkbListaUsuarios;
    }
}