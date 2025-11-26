namespace GPSFA_WinForms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblTitleDashboard = new System.Windows.Forms.Label();
            this.lblUusuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlDadosProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDadosProdutos
            // 
            this.pnlDadosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlDadosProdutos.Controls.Add(this.lblTitleDashboard);
            this.pnlDadosProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDadosProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlDadosProdutos.Name = "pnlDadosProdutos";
            this.pnlDadosProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlDadosProdutos.Size = new System.Drawing.Size(1884, 174);
            this.pnlDadosProdutos.TabIndex = 3;
            // 
            // lblTitleDashboard
            // 
            this.lblTitleDashboard.AutoSize = true;
            this.lblTitleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleDashboard.Location = new System.Drawing.Point(13, 9);
            this.lblTitleDashboard.Name = "lblTitleDashboard";
            this.lblTitleDashboard.Size = new System.Drawing.Size(56, 20);
            this.lblTitleDashboard.TabIndex = 12;
            this.lblTitleDashboard.Text = "Home";
            // 
            // lblUusuario
            // 
            this.lblUusuario.AutoSize = true;
            this.lblUusuario.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUusuario.Location = new System.Drawing.Point(569, 391);
            this.lblUusuario.Name = "lblUusuario";
            this.lblUusuario.Size = new System.Drawing.Size(85, 27);
            this.lblUusuario.TabIndex = 4;
            this.lblUusuario.Text = "Usuário";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(574, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 34);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(574, 510);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 34);
            this.textBox2.TabIndex = 7;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(569, 479);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 27);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(574, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Entrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(846, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Sair";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUusuario);
            this.Controls.Add(this.pnlDadosProdutos);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista São Francisco de Assis - Login";
            this.pnlDadosProdutos.ResumeLayout(false);
            this.pnlDadosProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosProdutos;
        private System.Windows.Forms.Label lblTitleDashboard;
        private System.Windows.Forms.Label lblUusuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}