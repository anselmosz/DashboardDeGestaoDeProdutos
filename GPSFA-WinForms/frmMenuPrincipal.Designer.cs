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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlSideMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSideMenu.Controls.Add(this.btnMenu);
            this.pnlSideMenu.Controls.Add(this.btnSair);
            this.pnlSideMenu.Controls.Add(this.btnRelatorios);
            this.pnlSideMenu.Controls.Add(this.btnVoluntarios);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 681);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(4, 173);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(192, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Location = new System.Drawing.Point(4, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(192, 100);
            this.pnlLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.FlatAppearance.BorderSize = 0;
            this.btnVoluntarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVoluntarios.Image")));
            this.btnVoluntarios.Location = new System.Drawing.Point(4, 303);
            this.btnVoluntarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVoluntarios.Size = new System.Drawing.Size(192, 55);
            this.btnVoluntarios.TabIndex = 2;
            this.btnVoluntarios.Text = "Voluntários";
            this.btnVoluntarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoluntarios.UseVisualStyleBackColor = true;
            this.btnVoluntarios.Click += new System.EventHandler(this.btnVoluntarios_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.Location = new System.Drawing.Point(4, 238);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(192, 55);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(4, 621);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(192, 55);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.lblMenu);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(200, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1064, 681);
            this.pnlForm.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(7, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(112, 20);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(4, 108);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(192, 55);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnMenu;
    }
}