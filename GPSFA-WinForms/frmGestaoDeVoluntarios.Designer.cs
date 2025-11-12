namespace GPSFA_WinForms
{
    partial class frmGestaoDeVoluntarios
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
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.lblTitleGestaoDeVoluntarios = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListaDeVoluntarios = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltrosDeBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeVoluntarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.AutoSize = true;
            this.pnlFiltrosDeBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlFiltrosDeBusca.Controls.Add(this.lblTitleGestaoDeVoluntarios);
            this.pnlFiltrosDeBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosDeBusca.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1044, 39);
            this.pnlFiltrosDeBusca.TabIndex = 5;
            // 
            // lblTitleGestaoDeVoluntarios
            // 
            this.lblTitleGestaoDeVoluntarios.AutoSize = true;
            this.lblTitleGestaoDeVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGestaoDeVoluntarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleGestaoDeVoluntarios.Location = new System.Drawing.Point(12, 9);
            this.lblTitleGestaoDeVoluntarios.Name = "lblTitleGestaoDeVoluntarios";
            this.lblTitleGestaoDeVoluntarios.Size = new System.Drawing.Size(189, 20);
            this.lblTitleGestaoDeVoluntarios.TabIndex = 11;
            this.lblTitleGestaoDeVoluntarios.Text = "Gestão de Voluntários";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lista de voluntários";
            // 
            // dgvListaDeVoluntarios
            // 
            this.dgvListaDeVoluntarios.AllowUserToAddRows = false;
            this.dgvListaDeVoluntarios.AllowUserToDeleteRows = false;
            this.dgvListaDeVoluntarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaDeVoluntarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListaDeVoluntarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaDeVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeVoluntarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo});
            this.dgvListaDeVoluntarios.Location = new System.Drawing.Point(12, 100);
            this.dgvListaDeVoluntarios.Name = "dgvListaDeVoluntarios";
            this.dgvListaDeVoluntarios.ReadOnly = true;
            this.dgvListaDeVoluntarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaDeVoluntarios.Size = new System.Drawing.Size(1020, 569);
            this.dgvListaDeVoluntarios.TabIndex = 6;
            this.dgvListaDeVoluntarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDeVoluntarios_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // frmGestaoDeVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1044, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListaDeVoluntarios);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestaoDeVoluntarios";
            this.Text = "frmVoluntarios";
            this.Load += new System.EventHandler(this.frmVoluntarios_Load);
            this.pnlFiltrosDeBusca.ResumeLayout(false);
            this.pnlFiltrosDeBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeVoluntarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltrosDeBusca;
        private System.Windows.Forms.Label lblTitleGestaoDeVoluntarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListaDeVoluntarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
    }
}