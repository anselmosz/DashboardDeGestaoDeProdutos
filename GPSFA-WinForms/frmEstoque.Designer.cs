namespace GPSFA_WinForms
{
    partial class frmEstoque
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
            this.pnlFiltrosDeBusca = new System.Windows.Forms.Panel();
            this.lblTitleEstoque = new System.Windows.Forms.Label();
            this.pnlFiltrosDeBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltrosDeBusca
            // 
            this.pnlFiltrosDeBusca.AutoSize = true;
            this.pnlFiltrosDeBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlFiltrosDeBusca.Controls.Add(this.lblTitleEstoque);
            this.pnlFiltrosDeBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosDeBusca.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrosDeBusca.Name = "pnlFiltrosDeBusca";
            this.pnlFiltrosDeBusca.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFiltrosDeBusca.Size = new System.Drawing.Size(1028, 39);
            this.pnlFiltrosDeBusca.TabIndex = 5;
            // 
            // lblTitleEstoque
            // 
            this.lblTitleEstoque.AutoSize = true;
            this.lblTitleEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleEstoque.Location = new System.Drawing.Point(12, 9);
            this.lblTitleEstoque.Name = "lblTitleEstoque";
            this.lblTitleEstoque.Size = new System.Drawing.Size(76, 20);
            this.lblTitleEstoque.TabIndex = 11;
            this.lblTitleEstoque.Text = "Estoque";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1028, 642);
            this.Controls.Add(this.pnlFiltrosDeBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.Text = "frmEstoque";
            this.pnlFiltrosDeBusca.ResumeLayout(false);
            this.pnlFiltrosDeBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltrosDeBusca;
        private System.Windows.Forms.Label lblTitleEstoque;
    }
}