namespace GPSFA_WinForms
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlDadosProdutos = new System.Windows.Forms.Panel();
            this.lblTitleDashboard = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDadosProdutos.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlDadosProdutos.TabIndex = 2;
            // 
            // lblTitleDashboard
            // 
            this.lblTitleDashboard.AutoSize = true;
            this.lblTitleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblTitleDashboard.Name = "lblTitleDashboard";
            this.lblTitleDashboard.Size = new System.Drawing.Size(56, 20);
            this.lblTitleDashboard.TabIndex = 12;
            this.lblTitleDashboard.Text = "Home";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.pnlForm.Controls.Add(this.button1);
            this.pnlForm.Controls.Add(this.btnHome);
            this.pnlForm.Controls.Add(this.btnVoluntarios);
            this.pnlForm.Controls.Add(this.btnRelatorios);
            this.pnlForm.Controls.Add(this.btnAlimentos);
            this.pnlForm.Controls.Add(this.pnlDadosProdutos);
            this.pnlForm.Controls.Add(this.btnDashboard);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1884, 911);
            this.pnlForm.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(567, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 173);
            this.button1.TabIndex = 9;
            this.button1.Text = "     Cadastrar       Alimentos";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(16, 78);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 173);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "        Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnVoluntarios.FlatAppearance.BorderSize = 0;
            this.btnVoluntarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoluntarios.ForeColor = System.Drawing.Color.White;
            this.btnVoluntarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVoluntarios.Image")));
            this.btnVoluntarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoluntarios.Location = new System.Drawing.Point(288, 281);
            this.btnVoluntarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVoluntarios.Size = new System.Drawing.Size(220, 188);
            this.btnVoluntarios.TabIndex = 2;
            this.btnVoluntarios.Text = "     Voluntários";
            this.btnVoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoluntarios.UseVisualStyleBackColor = false;
            this.btnVoluntarios.Click += new System.EventHandler(this.btnVoluntarios_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(16, 281);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(220, 188);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "     Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnAlimentos.FlatAppearance.BorderSize = 0;
            this.btnAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentos.ForeColor = System.Drawing.Color.White;
            this.btnAlimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlimentos.Image")));
            this.btnAlimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlimentos.Location = new System.Drawing.Point(288, 78);
            this.btnAlimentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAlimentos.Size = new System.Drawing.Size(220, 173);
            this.btnAlimentos.TabIndex = 8;
            this.btnAlimentos.Text = "     Estoque";
            this.btnAlimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlimentos.UseVisualStyleBackColor = false;
            this.btnAlimentos.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(567, 289);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 180);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "     Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Socorrista Francisco de Assis";
            this.pnlDadosProdutos.ResumeLayout(false);
            this.pnlDadosProdutos.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosProdutos;
        private System.Windows.Forms.Label lblTitleDashboard;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnAlimentos;
        private System.Windows.Forms.Button btnDashboard;
    }
}