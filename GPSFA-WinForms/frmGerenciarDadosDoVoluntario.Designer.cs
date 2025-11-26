namespace GPSFA_WinForms
{
    partial class frmGerenciarDadosDoVoluntario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarDadosDoVoluntario));
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblTitleDashboard = new System.Windows.Forms.Label();
            this.pnlDadosProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDadosProdutos
            // 
            this.pnlDadosProdutos.AutoSize = true;
            this.pnlDadosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlDadosProdutos.Controls.Add(this.lblTitleDashboard);
            this.pnlDadosProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDadosProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlDadosProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDadosProdutos.Name = "pnlDadosProdutos";
            this.pnlDadosProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlDadosProdutos.Size = new System.Drawing.Size(1884, 49);
            this.pnlDadosProdutos.TabIndex = 3;
            // 
            // lblTitleDashboard
            // 
            this.lblTitleDashboard.AutoSize = true;
            this.lblTitleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleDashboard.Location = new System.Drawing.Point(18, 14);
            this.lblTitleDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleDashboard.Name = "lblTitleDashboard";
            this.lblTitleDashboard.Size = new System.Drawing.Size(250, 20);
            this.lblTitleDashboard.TabIndex = 12;
            this.lblTitleDashboard.Text = "Gerenciar dados do voluntário";
            // 
            // frmGerenciarDadosDoVoluntario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.pnlDadosProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmGerenciarDadosDoVoluntario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Gerenciar dados do voluntário";
            this.pnlDadosProdutos.ResumeLayout(false);
            this.pnlDadosProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosProdutos;
        private System.Windows.Forms.Label lblTitleDashboard;
    }
}