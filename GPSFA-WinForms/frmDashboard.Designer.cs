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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbctrlDashboard = new System.Windows.Forms.TabControl();
            this.tbpgDashboardAlimentos = new System.Windows.Forms.TabPage();
            this.chartProdutos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpgDashboadMensal = new System.Windows.Forms.TabPage();
            this.chartDoacaoMensal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblMesAtualDataReceiver = new System.Windows.Forms.Label();
            this.lblMesAtual = new System.Windows.Forms.Label();
            this.lblTotalEmQuilosDataReceiver = new System.Windows.Forms.Label();
            this.lbTotalDeItensDataReceiver = new System.Windows.Forms.Label();
            this.lblTotalEmQuilos = new System.Windows.Forms.Label();
            this.lblTotalDeItens = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.tbctrlDashboard.SuspendLayout();
            this.tbpgDashboardAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).BeginInit();
            this.tbpgDashboadMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoacaoMensal)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlDadosProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlDashboard
            // 
            this.tbctrlDashboard.Controls.Add(this.tbpgDashboardAlimentos);
            this.tbctrlDashboard.Controls.Add(this.tbpgDashboadMensal);
            this.tbctrlDashboard.Controls.Add(this.tabPage3);
            this.tbctrlDashboard.Location = new System.Drawing.Point(12, 140);
            this.tbctrlDashboard.Name = "tbctrlDashboard";
            this.tbctrlDashboard.SelectedIndex = 0;
            this.tbctrlDashboard.Size = new System.Drawing.Size(1040, 529);
            this.tbctrlDashboard.TabIndex = 0;
            // 
            // tbpgDashboardAlimentos
            // 
            this.tbpgDashboardAlimentos.Controls.Add(this.chartProdutos);
            this.tbpgDashboardAlimentos.Location = new System.Drawing.Point(4, 29);
            this.tbpgDashboardAlimentos.Name = "tbpgDashboardAlimentos";
            this.tbpgDashboardAlimentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDashboardAlimentos.Size = new System.Drawing.Size(1032, 496);
            this.tbpgDashboardAlimentos.TabIndex = 0;
            this.tbpgDashboardAlimentos.Text = "Alimentos recebidos";
            this.tbpgDashboardAlimentos.UseVisualStyleBackColor = true;
            // 
            // chartProdutos
            // 
            this.chartProdutos.BackColor = System.Drawing.Color.Lavender;
            this.chartProdutos.BorderlineColor = System.Drawing.Color.Teal;
            this.chartProdutos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chartProdutos.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartProdutos.Legends.Add(legend5);
            this.chartProdutos.Location = new System.Drawing.Point(7, 7);
            this.chartProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.chartProdutos.Name = "chartProdutos";
            this.chartProdutos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartProdutos.Series.Add(series5);
            this.chartProdutos.Size = new System.Drawing.Size(1018, 482);
            this.chartProdutos.TabIndex = 0;
            this.chartProdutos.Text = "Produtos";
            // 
            // tbpgDashboadMensal
            // 
            this.tbpgDashboadMensal.Controls.Add(this.chartDoacaoMensal);
            this.tbpgDashboadMensal.Location = new System.Drawing.Point(4, 29);
            this.tbpgDashboadMensal.Name = "tbpgDashboadMensal";
            this.tbpgDashboadMensal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDashboadMensal.Size = new System.Drawing.Size(1032, 496);
            this.tbpgDashboadMensal.TabIndex = 1;
            this.tbpgDashboadMensal.Text = "Alimentos mensais";
            this.tbpgDashboadMensal.UseVisualStyleBackColor = true;
            // 
            // chartDoacaoMensal
            // 
            this.chartDoacaoMensal.BackColor = System.Drawing.Color.Lavender;
            this.chartDoacaoMensal.BorderlineColor = System.Drawing.Color.Teal;
            this.chartDoacaoMensal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.chartDoacaoMensal.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartDoacaoMensal.Legends.Add(legend6);
            this.chartDoacaoMensal.Location = new System.Drawing.Point(7, 7);
            this.chartDoacaoMensal.Margin = new System.Windows.Forms.Padding(4);
            this.chartDoacaoMensal.Name = "chartDoacaoMensal";
            this.chartDoacaoMensal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartDoacaoMensal.Series.Add(series6);
            this.chartDoacaoMensal.Size = new System.Drawing.Size(1018, 482);
            this.chartDoacaoMensal.TabIndex = 1;
            this.chartDoacaoMensal.Text = "Mensal";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1032, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidade de medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Validade";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(174, 167);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cadastro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 235);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 101);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de barras";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 40);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto";
            // 
            // pnlDadosProdutos
            // 
            this.pnlDadosProdutos.Controls.Add(this.lblMesAtualDataReceiver);
            this.pnlDadosProdutos.Controls.Add(this.lblMesAtual);
            this.pnlDadosProdutos.Controls.Add(this.lblTotalEmQuilosDataReceiver);
            this.pnlDadosProdutos.Controls.Add(this.lbTotalDeItensDataReceiver);
            this.pnlDadosProdutos.Controls.Add(this.lblTotalEmQuilos);
            this.pnlDadosProdutos.Controls.Add(this.lblTotalDeItens);
            this.pnlDadosProdutos.Location = new System.Drawing.Point(12, 32);
            this.pnlDadosProdutos.Name = "pnlDadosProdutos";
            this.pnlDadosProdutos.Size = new System.Drawing.Size(1040, 102);
            this.pnlDadosProdutos.TabIndex = 1;
            // 
            // lblMesAtualDataReceiver
            // 
            this.lblMesAtualDataReceiver.AutoSize = true;
            this.lblMesAtualDataReceiver.Location = new System.Drawing.Point(848, 11);
            this.lblMesAtualDataReceiver.Name = "lblMesAtualDataReceiver";
            this.lblMesAtualDataReceiver.Size = new System.Drawing.Size(39, 20);
            this.lblMesAtualDataReceiver.TabIndex = 5;
            this.lblMesAtualDataReceiver.Text = "Mês";
            // 
            // lblMesAtual
            // 
            this.lblMesAtual.AutoSize = true;
            this.lblMesAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAtual.Location = new System.Drawing.Point(747, 8);
            this.lblMesAtual.Name = "lblMesAtual";
            this.lblMesAtual.Size = new System.Drawing.Size(95, 24);
            this.lblMesAtual.TabIndex = 4;
            this.lblMesAtual.Text = "Mês atual:";
            // 
            // lblTotalEmQuilosDataReceiver
            // 
            this.lblTotalEmQuilosDataReceiver.AutoSize = true;
            this.lblTotalEmQuilosDataReceiver.Location = new System.Drawing.Point(509, 12);
            this.lblTotalEmQuilosDataReceiver.Name = "lblTotalEmQuilosDataReceiver";
            this.lblTotalEmQuilosDataReceiver.Size = new System.Drawing.Size(39, 20);
            this.lblTotalEmQuilosDataReceiver.TabIndex = 3;
            this.lblTotalEmQuilosDataReceiver.Text = "0 kg";
            // 
            // lbTotalDeItensDataReceiver
            // 
            this.lbTotalDeItensDataReceiver.AutoSize = true;
            this.lbTotalDeItensDataReceiver.Location = new System.Drawing.Point(139, 13);
            this.lbTotalDeItensDataReceiver.Name = "lbTotalDeItensDataReceiver";
            this.lbTotalDeItensDataReceiver.Size = new System.Drawing.Size(18, 20);
            this.lbTotalDeItensDataReceiver.TabIndex = 2;
            this.lbTotalDeItensDataReceiver.Text = "0";
            // 
            // lblTotalEmQuilos
            // 
            this.lblTotalEmQuilos.AutoSize = true;
            this.lblTotalEmQuilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmQuilos.Location = new System.Drawing.Point(356, 9);
            this.lblTotalEmQuilos.Name = "lblTotalEmQuilos";
            this.lblTotalEmQuilos.Size = new System.Drawing.Size(147, 24);
            this.lblTotalEmQuilos.TabIndex = 1;
            this.lblTotalEmQuilos.Text = "Total em Quilos:";
            // 
            // lblTotalDeItens
            // 
            this.lblTotalDeItens.AutoSize = true;
            this.lblTotalDeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeItens.Location = new System.Drawing.Point(6, 9);
            this.lblTotalDeItens.Name = "lblTotalDeItens";
            this.lblTotalDeItens.Size = new System.Drawing.Size(127, 24);
            this.lblTotalDeItens.TabIndex = 0;
            this.lblTotalDeItens.Text = "Total de Itens:";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(88, 20);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Dashboard";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.tbctrlDashboard);
            this.Controls.Add(this.pnlDadosProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tbctrlDashboard.ResumeLayout(false);
            this.tbpgDashboardAlimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).EndInit();
            this.tbpgDashboadMensal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoacaoMensal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Label lblTotalDeItens;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdutos;
        private System.Windows.Forms.Label lblMesAtualDataReceiver;
        private System.Windows.Forms.Label lblMesAtual;
        private System.Windows.Forms.Label lblTotalEmQuilosDataReceiver;
        private System.Windows.Forms.Label lbTotalDeItensDataReceiver;
        private System.Windows.Forms.Label lblTotalEmQuilos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoacaoMensal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDashboard;
    }
}