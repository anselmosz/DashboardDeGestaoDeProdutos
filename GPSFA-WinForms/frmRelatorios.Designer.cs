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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quemCadastrou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProduto,
            this.quantidade,
            this.pesoUnd,
            this.dtEntrada,
            this.quemCadastrou});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 172);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(971, 506);
            this.dgvProdutos.TabIndex = 3;
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.MinimumWidth = 6;
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Width = 125;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 125;
            // 
            // pesoUnd
            // 
            this.pesoUnd.HeaderText = "Peso";
            this.pesoUnd.MinimumWidth = 6;
            this.pesoUnd.Name = "pesoUnd";
            this.pesoUnd.Width = 125;
            // 
            // dtEntrada
            // 
            this.dtEntrada.HeaderText = "Data de Entrada";
            this.dtEntrada.MinimumWidth = 6;
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Width = 125;
            // 
            // quemCadastrou
            // 
            this.quemCadastrou.HeaderText = "Adicionado por";
            this.quemCadastrou.MinimumWidth = 6;
            this.quemCadastrou.Name = "quemCadastrou";
            this.quemCadastrou.Width = 125;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 690);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblRelatorios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn quemCadastrou;
    }
}