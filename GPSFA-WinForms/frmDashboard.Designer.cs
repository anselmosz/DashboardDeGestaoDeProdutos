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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quemCadastrou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblMesAtualDataReceiver = new System.Windows.Forms.Label();
            this.lblMesAtual = new System.Windows.Forms.Label();
            this.lblTotalEmQuilosDataReceiver = new System.Windows.Forms.Label();
            this.lbTotalDeItensDataReceiver = new System.Windows.Forms.Label();
            this.lblTotalEmQuilos = new System.Windows.Forms.Label();
            this.lblTotalDeItens = new System.Windows.Forms.Label();
            this.tbctrlDashboard.SuspendLayout();
            this.tbpgDashboardAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).BeginInit();
            this.tbpgDashboadMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoacaoMensal)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlDadosProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlDashboard
            // 
            this.tbctrlDashboard.Controls.Add(this.tbpgDashboardAlimentos);
            this.tbctrlDashboard.Controls.Add(this.tbpgDashboadMensal);
            this.tbctrlDashboard.Controls.Add(this.tabPage3);
            this.tbctrlDashboard.Location = new System.Drawing.Point(12, 128);
            this.tbctrlDashboard.Name = "tbctrlDashboard";
            this.tbctrlDashboard.SelectedIndex = 0;
            this.tbctrlDashboard.Size = new System.Drawing.Size(755, 541);
            this.tbctrlDashboard.TabIndex = 0;
            // 
            // tbpgDashboardAlimentos
            // 
            this.tbpgDashboardAlimentos.Controls.Add(this.chartProdutos);
            this.tbpgDashboardAlimentos.Location = new System.Drawing.Point(4, 29);
            this.tbpgDashboardAlimentos.Name = "tbpgDashboardAlimentos";
            this.tbpgDashboardAlimentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDashboardAlimentos.Size = new System.Drawing.Size(747, 508);
            this.tbpgDashboardAlimentos.TabIndex = 0;
            this.tbpgDashboardAlimentos.Text = "Alimentos recebidos";
            this.tbpgDashboardAlimentos.UseVisualStyleBackColor = true;
            // 
            // chartProdutos
            // 
            this.chartProdutos.BackColor = System.Drawing.Color.Lavender;
            this.chartProdutos.BorderlineColor = System.Drawing.Color.Teal;
            this.chartProdutos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartProdutos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdutos.Legends.Add(legend1);
            this.chartProdutos.Location = new System.Drawing.Point(7, 7);
            this.chartProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.chartProdutos.Name = "chartProdutos";
            this.chartProdutos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdutos.Series.Add(series1);
            this.chartProdutos.Size = new System.Drawing.Size(733, 494);
            this.chartProdutos.TabIndex = 0;
            this.chartProdutos.Text = "Produtos";
            // 
            // tbpgDashboadMensal
            // 
            this.tbpgDashboadMensal.Controls.Add(this.chartDoacaoMensal);
            this.tbpgDashboadMensal.Location = new System.Drawing.Point(4, 29);
            this.tbpgDashboadMensal.Name = "tbpgDashboadMensal";
            this.tbpgDashboadMensal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDashboadMensal.Size = new System.Drawing.Size(747, 508);
            this.tbpgDashboadMensal.TabIndex = 1;
            this.tbpgDashboadMensal.Text = "Alimentos mensais";
            this.tbpgDashboadMensal.UseVisualStyleBackColor = true;
            // 
            // chartDoacaoMensal
            // 
            this.chartDoacaoMensal.BackColor = System.Drawing.Color.Lavender;
            this.chartDoacaoMensal.BorderlineColor = System.Drawing.Color.Teal;
            this.chartDoacaoMensal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartDoacaoMensal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoacaoMensal.Legends.Add(legend2);
            this.chartDoacaoMensal.Location = new System.Drawing.Point(7, 7);
            this.chartDoacaoMensal.Margin = new System.Windows.Forms.Padding(4);
            this.chartDoacaoMensal.Name = "chartDoacaoMensal";
            this.chartDoacaoMensal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDoacaoMensal.Series.Add(series2);
            this.chartDoacaoMensal.Size = new System.Drawing.Size(733, 494);
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
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(747, 508);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dgvProdutos.Location = new System.Drawing.Point(769, 162);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(861, 507);
            this.dgvProdutos.TabIndex = 2;
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
            // pnlDadosProdutos
            // 
            this.pnlDadosProdutos.Controls.Add(this.lblMesAtualDataReceiver);
            this.pnlDadosProdutos.Controls.Add(this.lblMesAtual);
            this.pnlDadosProdutos.Controls.Add(this.lblTotalEmQuilosDataReceiver);
            this.pnlDadosProdutos.Controls.Add(this.lbTotalDeItensDataReceiver);
            this.pnlDadosProdutos.Controls.Add(this.lblTotalEmQuilos);
            this.pnlDadosProdutos.Controls.Add(this.lblTotalDeItens);
            this.pnlDadosProdutos.Location = new System.Drawing.Point(12, 12);
            this.pnlDadosProdutos.Name = "pnlDadosProdutos";
            this.pnlDadosProdutos.Size = new System.Drawing.Size(1236, 110);
            this.pnlDadosProdutos.TabIndex = 1;
            // 
            // lblMesAtualDataReceiver
            // 
            this.lblMesAtualDataReceiver.AutoSize = true;
            this.lblMesAtualDataReceiver.Location = new System.Drawing.Point(616, 19);
            this.lblMesAtualDataReceiver.Name = "lblMesAtualDataReceiver";
            this.lblMesAtualDataReceiver.Size = new System.Drawing.Size(39, 20);
            this.lblMesAtualDataReceiver.TabIndex = 5;
            this.lblMesAtualDataReceiver.Text = "Mês";
            // 
            // lblMesAtual
            // 
            this.lblMesAtual.AutoSize = true;
            this.lblMesAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAtual.Location = new System.Drawing.Point(461, 16);
            this.lblMesAtual.Name = "lblMesAtual";
            this.lblMesAtual.Size = new System.Drawing.Size(95, 24);
            this.lblMesAtual.TabIndex = 4;
            this.lblMesAtual.Text = "Mês atual:";
            // 
            // lblTotalEmQuilosDataReceiver
            // 
            this.lblTotalEmQuilosDataReceiver.AutoSize = true;
            this.lblTotalEmQuilosDataReceiver.Location = new System.Drawing.Point(228, 63);
            this.lblTotalEmQuilosDataReceiver.Name = "lblTotalEmQuilosDataReceiver";
            this.lblTotalEmQuilosDataReceiver.Size = new System.Drawing.Size(39, 20);
            this.lblTotalEmQuilosDataReceiver.TabIndex = 3;
            this.lblTotalEmQuilosDataReceiver.Text = "0 kg";
            // 
            // lbTotalDeItensDataReceiver
            // 
            this.lbTotalDeItensDataReceiver.AutoSize = true;
            this.lbTotalDeItensDataReceiver.Location = new System.Drawing.Point(228, 19);
            this.lbTotalDeItensDataReceiver.Name = "lbTotalDeItensDataReceiver";
            this.lbTotalDeItensDataReceiver.Size = new System.Drawing.Size(18, 20);
            this.lbTotalDeItensDataReceiver.TabIndex = 2;
            this.lbTotalDeItensDataReceiver.Text = "0";
            // 
            // lblTotalEmQuilos
            // 
            this.lblTotalEmQuilos.AutoSize = true;
            this.lblTotalEmQuilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmQuilos.Location = new System.Drawing.Point(14, 63);
            this.lblTotalEmQuilos.Name = "lblTotalEmQuilos";
            this.lblTotalEmQuilos.Size = new System.Drawing.Size(147, 24);
            this.lblTotalEmQuilos.TabIndex = 1;
            this.lblTotalEmQuilos.Text = "Total em Quilos:";
            // 
            // lblTotalDeItens
            // 
            this.lblTotalDeItens.AutoSize = true;
            this.lblTotalDeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeItens.Location = new System.Drawing.Point(14, 16);
            this.lblTotalDeItens.Name = "lblTotalDeItens";
            this.lblTotalDeItens.Size = new System.Drawing.Size(127, 24);
            this.lblTotalDeItens.TabIndex = 0;
            this.lblTotalDeItens.Text = "Total de Itens:";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 681);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.tbctrlDashboard);
            this.Controls.Add(this.pnlDadosProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tbctrlDashboard.ResumeLayout(false);
            this.tbpgDashboardAlimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).EndInit();
            this.tbpgDashboadMensal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoacaoMensal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlDadosProdutos.ResumeLayout(false);
            this.pnlDadosProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlDashboard;
        private System.Windows.Forms.TabPage tbpgDashboardAlimentos;
        private System.Windows.Forms.TabPage tbpgDashboadMensal;
        private System.Windows.Forms.Panel pnlDadosProdutos;
        private System.Windows.Forms.Label lblTotalDeItens;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn quemCadastrou;
        private System.Windows.Forms.Label lblMesAtualDataReceiver;
        private System.Windows.Forms.Label lblMesAtual;
        private System.Windows.Forms.Label lblTotalEmQuilosDataReceiver;
        private System.Windows.Forms.Label lbTotalDeItensDataReceiver;
        private System.Windows.Forms.Label lblTotalEmQuilos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoacaoMensal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
    }
}