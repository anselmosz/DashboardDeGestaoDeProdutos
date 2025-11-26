namespace GPSFA_WinForms
{
    partial class frmGerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProdutos));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblUnidadeDeMedida = new System.Windows.Forms.Label();
            this.cbbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtNomeDoItem = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.gpbCamposDoProduto = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpbCamposDoProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(3, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 70);
            this.btnCadastrar.TabIndex = 74;
            this.btnCadastrar.Text = "&Novo";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodBarras.Location = new System.Drawing.Point(39, 43);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(146, 20);
            this.lblCodBarras.TabIndex = 70;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(43, 66);
            this.txtCodBarras.MaxLength = 13;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(390, 34);
            this.txtCodBarras.TabIndex = 53;
            this.txtCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeDeMedida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(897, 143);
            this.lblUnidadeDeMedida.Name = "lblUnidadeDeMedida";
            this.lblUnidadeDeMedida.Size = new System.Drawing.Size(164, 20);
            this.lblUnidadeDeMedida.TabIndex = 67;
            this.lblUnidadeDeMedida.Text = "Unidade de medida";
            // 
            // cbbUnidadeMedida
            // 
            this.cbbUnidadeMedida.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUnidadeMedida.FormattingEnabled = true;
            this.cbbUnidadeMedida.Items.AddRange(new object[] {
            "Quilogramas (Kg)",
            "Gramas (g)",
            "Litros (L)",
            "Mililitros (ml)",
            "Unidades (und)",
            "Caixas (cx)"});
            this.cbbUnidadeMedida.Location = new System.Drawing.Point(901, 166);
            this.cbbUnidadeMedida.Name = "cbbUnidadeMedida";
            this.cbbUnidadeMedida.Size = new System.Drawing.Size(236, 35);
            this.cbbUnidadeMedida.TabIndex = 61;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(765, 166);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(98, 34);
            this.txtPeso.TabIndex = 62;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeso.Location = new System.Drawing.Point(761, 143);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 63;
            this.lblPeso.Text = "Peso";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(596, 166);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(137, 34);
            this.txtQuantidade.TabIndex = 58;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantidade.Location = new System.Drawing.Point(592, 143);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(102, 20);
            this.lblQuantidade.TabIndex = 60;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataValidade.Location = new System.Drawing.Point(205, 256);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(144, 20);
            this.lblDataValidade.TabIndex = 57;
            this.lblDataValidade.Text = "Data de validade";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataValidade.Location = new System.Drawing.Point(209, 279);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(136, 34);
            this.dtpDataValidade.TabIndex = 59;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataEntrada.Location = new System.Drawing.Point(39, 256);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(140, 20);
            this.lblDataEntrada.TabIndex = 54;
            this.lblDataEntrada.Text = "Data de entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(43, 279);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(136, 34);
            this.dtpDataEntrada.TabIndex = 56;
            // 
            // txtNomeDoItem
            // 
            this.txtNomeDoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDoItem.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoItem.Location = new System.Drawing.Point(43, 166);
            this.txtNomeDoItem.MaxLength = 100;
            this.txtNomeDoItem.Name = "txtNomeDoItem";
            this.txtNomeDoItem.Size = new System.Drawing.Size(515, 34);
            this.txtNomeDoItem.TabIndex = 55;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl.Location = new System.Drawing.Point(39, 143);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 20);
            this.lbl.TabIndex = 52;
            this.lbl.Text = "Descrição";
            // 
            // gpbCamposDoProduto
            // 
            this.gpbCamposDoProduto.Controls.Add(this.label2);
            this.gpbCamposDoProduto.Controls.Add(this.dateTimePicker1);
            this.gpbCamposDoProduto.Controls.Add(this.label1);
            this.gpbCamposDoProduto.Controls.Add(this.textBox2);
            this.gpbCamposDoProduto.Controls.Add(this.lblFornecedor);
            this.gpbCamposDoProduto.Controls.Add(this.textBox1);
            this.gpbCamposDoProduto.Controls.Add(this.lblCodBarras);
            this.gpbCamposDoProduto.Controls.Add(this.txtCodBarras);
            this.gpbCamposDoProduto.Controls.Add(this.lblUnidadeDeMedida);
            this.gpbCamposDoProduto.Controls.Add(this.cbbUnidadeMedida);
            this.gpbCamposDoProduto.Controls.Add(this.txtPeso);
            this.gpbCamposDoProduto.Controls.Add(this.lblPeso);
            this.gpbCamposDoProduto.Controls.Add(this.txtQuantidade);
            this.gpbCamposDoProduto.Controls.Add(this.lblQuantidade);
            this.gpbCamposDoProduto.Controls.Add(this.lblDataValidade);
            this.gpbCamposDoProduto.Controls.Add(this.dtpDataValidade);
            this.gpbCamposDoProduto.Controls.Add(this.lblDataEntrada);
            this.gpbCamposDoProduto.Controls.Add(this.dtpDataEntrada);
            this.gpbCamposDoProduto.Controls.Add(this.txtNomeDoItem);
            this.gpbCamposDoProduto.Controls.Add(this.lbl);
            this.gpbCamposDoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCamposDoProduto.Location = new System.Drawing.Point(12, 12);
            this.gpbCamposDoProduto.Name = "gpbCamposDoProduto";
            this.gpbCamposDoProduto.Size = new System.Drawing.Size(1214, 478);
            this.gpbCamposDoProduto.TabIndex = 72;
            this.gpbCamposDoProduto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(12, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 94);
            this.panel1.TabIndex = 80;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1045, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 70);
            this.button6.TabIndex = 80;
            this.button6.Text = "&Voltar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(519, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 70);
            this.button5.TabIndex = 79;
            this.button5.Text = "&Limpar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(863, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 70);
            this.button4.TabIndex = 78;
            this.button4.Text = "&Pesquisar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(347, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 70);
            this.button3.TabIndex = 77;
            this.button3.Text = "&Alterar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(691, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 70);
            this.button2.TabIndex = 76;
            this.button2.Text = "&Excluir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(175, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 70);
            this.button1.TabIndex = 75;
            this.button1.Text = "&Cadastrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFornecedor.Location = new System.Drawing.Point(39, 357);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(101, 20);
            this.lblFornecedor.TabIndex = 82;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 380);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 34);
            this.textBox1.TabIndex = 81;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(427, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Usuário";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(431, 380);
            this.textBox2.MaxLength = 13;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 34);
            this.textBox2.TabIndex = 83;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(427, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Data limite de saída";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 34);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // frmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1235, 602);
            this.Controls.Add(this.gpbCamposDoProduto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Gerenciar Produtos";
            this.Load += new System.EventHandler(this.frmCadastrarAlimentos_Load);
            this.gpbCamposDoProduto.ResumeLayout(false);
            this.gpbCamposDoProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblUnidadeDeMedida;
        private System.Windows.Forms.ComboBox cbbUnidadeMedida;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.TextBox txtNomeDoItem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gpbCamposDoProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}