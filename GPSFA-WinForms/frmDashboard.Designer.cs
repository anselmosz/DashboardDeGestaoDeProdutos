namespace GPSFA_WinForms
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tbctrlDashboard = new System.Windows.Forms.TabControl();
            this.tbpgDashboardAlimentos = new System.Windows.Forms.TabPage();
            this.lblTotalEmQuilosDataReceiver = new System.Windows.Forms.Label();
            this.lblMesAtualDataReceiver = new System.Windows.Forms.Label();
            this.lbTotalDeItensDataReceiver = new System.Windows.Forms.Label();
            this.lblTotalEmQuilos = new System.Windows.Forms.Label();
            this.lblTotalDeItens = new System.Windows.Forms.Label();
            this.lblMesAtual = new System.Windows.Forms.Label();
            this.chartProdutos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpgDashboadMensal = new System.Windows.Forms.TabPage();
            this.chartDoacaoMensal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblTitleDashboard = new System.Windows.Forms.Label();
            this.tbctrlDashboard.SuspendLayout();
            this.tbpgDashboardAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).BeginInit();
            this.tbpgDashboadMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoacaoMensal)).BeginInit();
            this.pnlDadosProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlDashboard
            // 
            this.tbctrlDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrlDashboard.Controls.Add(this.tbpgDashboardAlimentos);
            this.tbctrlDashboard.Controls.Add(this.tbpgDashboadMensal);
            this.tbctrlDashboard.Location = new System.Drawing.Point(12, 45);
            this.tbctrlDashboard.Name = "tbctrlDashboard";
            this.tbctrlDashboard.SelectedIndex = 0;
            this.tbctrlDashboard.Size = new System.Drawing.Size(1861, 854);
            this.tbctrlDashboard.TabIndex = 0;
            // 
            // tbpgDashboardAlimentos
            // 
            this.tbpgDashboardAlimentos.Controls.Add(this.lblTotalEmQuilosDataReceiver);
            this.tbpgDashboardAlimentos.Controls.Add(this.lblMesAtualDataReceiver);
            this.tbpgDashboardAlimentos.Controls.Add(this.lbTotalDeItensDataReceiver);
            this.tbpgDashboardAlimentos.Controls.Add(this.lblTotalEmQuilos);
            this.tbpgDashboardAlimentos.Controls.Add(this.lblTotalDeItens);
            this.tbpgDashboardAlimentos.Controls.Add(this.lblMesAtual);
            this.tbpgDashboardAlimentos.Controls.Add(this.chartProdutos);
            this.tbpgDashboardAlimentos.Location = new System.Drawing.Point(4, 29);
            this.tbpgDashboardAlimentos.Name = "tbpgDashboardAlimentos";
            this.tbpgDashboardAlimentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDashboardAlimentos.Size = new System.Drawing.Size(1853, 821);
            this.tbpgDashboardAlimentos.TabIndex = 0;
            this.tbpgDashboardAlimentos.Text = "Alimentos mais recebidos";
            this.tbpgDashboardAlimentos.UseVisualStyleBackColor = true;
            // 
            // lblTotalEmQuilosDataReceiver
            // 
            this.lblTotalEmQuilosDataReceiver.AutoSize = true;
            this.lblTotalEmQuilosDataReceiver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalEmQuilosDataReceiver.Location = new System.Drawing.Point(1698, 93);
            this.lblTotalEmQuilosDataReceiver.Name = "lblTotalEmQuilosDataReceiver";
            this.lblTotalEmQuilosDataReceiver.Size = new System.Drawing.Size(39, 20);
            this.lblTotalEmQuilosDataReceiver.TabIndex = 9;
            this.lblTotalEmQuilosDataReceiver.Text = "0 kg";
            // 
            // lblMesAtualDataReceiver
            // 
            this.lblMesAtualDataReceiver.AutoSize = true;
            this.lblMesAtualDataReceiver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMesAtualDataReceiver.Location = new System.Drawing.Point(1646, 26);
            this.lblMesAtualDataReceiver.Name = "lblMesAtualDataReceiver";
            this.lblMesAtualDataReceiver.Size = new System.Drawing.Size(39, 20);
            this.lblMesAtualDataReceiver.TabIndex = 11;
            this.lblMesAtualDataReceiver.Text = "Mês";
            // 
            // lbTotalDeItensDataReceiver
            // 
            this.lbTotalDeItensDataReceiver.AutoSize = true;
            this.lbTotalDeItensDataReceiver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalDeItensDataReceiver.Location = new System.Drawing.Point(1678, 60);
            this.lbTotalDeItensDataReceiver.Name = "lbTotalDeItensDataReceiver";
            this.lbTotalDeItensDataReceiver.Size = new System.Drawing.Size(18, 20);
            this.lbTotalDeItensDataReceiver.TabIndex = 8;
            this.lbTotalDeItensDataReceiver.Text = "0";
            // 
            // lblTotalEmQuilos
            // 
            this.lblTotalEmQuilos.AutoSize = true;
            this.lblTotalEmQuilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmQuilos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalEmQuilos.Location = new System.Drawing.Point(1545, 90);
            this.lblTotalEmQuilos.Name = "lblTotalEmQuilos";
            this.lblTotalEmQuilos.Size = new System.Drawing.Size(147, 24);
            this.lblTotalEmQuilos.TabIndex = 7;
            this.lblTotalEmQuilos.Text = "Total em Quilos:";
            // 
            // lblTotalDeItens
            // 
            this.lblTotalDeItens.AutoSize = true;
            this.lblTotalDeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeItens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeItens.Location = new System.Drawing.Point(1545, 56);
            this.lblTotalDeItens.Name = "lblTotalDeItens";
            this.lblTotalDeItens.Size = new System.Drawing.Size(127, 24);
            this.lblTotalDeItens.TabIndex = 6;
            this.lblTotalDeItens.Text = "Total de Itens:";
            // 
            // lblMesAtual
            // 
            this.lblMesAtual.AutoSize = true;
            this.lblMesAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAtual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMesAtual.Location = new System.Drawing.Point(1545, 23);
            this.lblMesAtual.Name = "lblMesAtual";
            this.lblMesAtual.Size = new System.Drawing.Size(95, 24);
            this.lblMesAtual.TabIndex = 10;
            this.lblMesAtual.Text = "Mês atual:";
            // 
            // chartProdutos
            // 
            this.chartProdutos.BackColor = System.Drawing.Color.Lavender;
            this.chartProdutos.BorderlineColor = System.Drawing.Color.Teal;
            this.chartProdutos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartProdutos.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartProdutos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdutos.Legends.Add(legend1);
            this.chartProdutos.Location = new System.Drawing.Point(7, 7);
            this.chartProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.chartProdutos.Name = "chartProdutos";
            this.chartProdutos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdutos.Series.Add(series1);
            this.chartProdutos.Size = new System.Drawing.Size(1515, 807);
            this.chartProdutos.TabIndex = 0;
            this.chartProdutos.Text = "Produtos";
            // 
            // tbpgDashboadMensal
            // 
            this.tbpgDashboadMensal.Controls.Add(this.chartDoacaoMensal);
            this.tbpgDashboadMensal.Location = new System.Drawing.Point(4, 29);
            this.tbpgDashboadMensal.Name = "tbpgDashboadMensal";
            this.tbpgDashboadMensal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDashboadMensal.Size = new System.Drawing.Size(1013, 591);
            this.tbpgDashboadMensal.TabIndex = 1;
            this.tbpgDashboadMensal.Text = "Alimentos mensais";
            this.tbpgDashboadMensal.UseVisualStyleBackColor = true;
            // 
            // chartDoacaoMensal
            // 
            this.chartDoacaoMensal.BackColor = System.Drawing.Color.Lavender;
            this.chartDoacaoMensal.BorderlineColor = System.Drawing.Color.Teal;
            this.chartDoacaoMensal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartDoacaoMensal.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartDoacaoMensal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoacaoMensal.Legends.Add(legend2);
            this.chartDoacaoMensal.Location = new System.Drawing.Point(7, 7);
            this.chartDoacaoMensal.Margin = new System.Windows.Forms.Padding(4);
            this.chartDoacaoMensal.Name = "chartDoacaoMensal";
            this.chartDoacaoMensal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDoacaoMensal.Series.Add(series2);
            this.chartDoacaoMensal.Size = new System.Drawing.Size(741, 577);
            this.chartDoacaoMensal.TabIndex = 1;
            this.chartDoacaoMensal.Text = "Mensal";
            // 
            // pnlDadosProdutos
            // 
            this.pnlDadosProdutos.AutoSize = true;
            this.pnlDadosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlDadosProdutos.Controls.Add(this.lblTitleDashboard);
            this.pnlDadosProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDadosProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlDadosProdutos.Name = "pnlDadosProdutos";
            this.pnlDadosProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlDadosProdutos.Size = new System.Drawing.Size(1884, 39);
            this.pnlDadosProdutos.TabIndex = 1;
            // 
            // lblTitleDashboard
            // 
            this.lblTitleDashboard.AutoSize = true;
            this.lblTitleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblTitleDashboard.Name = "lblTitleDashboard";
            this.lblTitleDashboard.Size = new System.Drawing.Size(97, 20);
            this.lblTitleDashboard.TabIndex = 12;
            this.lblTitleDashboard.Text = "Dashboard";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.tbctrlDashboard);
            this.Controls.Add(this.pnlDadosProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tbctrlDashboard.ResumeLayout(false);
            this.tbpgDashboardAlimentos.ResumeLayout(false);
            this.tbpgDashboardAlimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).EndInit();
            this.tbpgDashboadMensal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoacaoMensal)).EndInit();
            this.pnlDadosProdutos.ResumeLayout(false);
            this.pnlDadosProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlDashboard;
        private System.Windows.Forms.TabPage tbpgDashboardAlimentos;
        private System.Windows.Forms.TabPage tbpgDashboadMensal;
        private System.Windows.Forms.Panel pnlDadosProdutos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdutos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoacaoMensal;
        private System.Windows.Forms.Label lblTitleDashboard;
        private System.Windows.Forms.Label lblTotalEmQuilosDataReceiver;
        private System.Windows.Forms.Label lblMesAtualDataReceiver;
        private System.Windows.Forms.Label lbTotalDeItensDataReceiver;
        private System.Windows.Forms.Label lblTotalEmQuilos;
        private System.Windows.Forms.Label lblTotalDeItens;
        private System.Windows.Forms.Label lblMesAtual;
    }
}