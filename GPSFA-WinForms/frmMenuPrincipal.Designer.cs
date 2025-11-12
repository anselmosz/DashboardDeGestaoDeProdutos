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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tmrSidebarAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlForm.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 117);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 53);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "        Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 594);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 82);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "        Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 243);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(220, 53);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "        Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnVoluntarios.FlatAppearance.BorderSize = 0;
            this.btnVoluntarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoluntarios.ForeColor = System.Drawing.Color.White;
            this.btnVoluntarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVoluntarios.Image")));
            this.btnVoluntarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoluntarios.Location = new System.Drawing.Point(0, 306);
            this.btnVoluntarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVoluntarios.Size = new System.Drawing.Size(220, 53);
            this.btnVoluntarios.TabIndex = 2;
            this.btnVoluntarios.Text = "        Voluntários";
            this.btnVoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoluntarios.UseVisualStyleBackColor = false;
            this.btnVoluntarios.Click += new System.EventHandler(this.btnVoluntarios_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 180);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 53);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "        Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.pnlForm.Controls.Add(this.lblHome);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(82, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1150, 676);
            this.pnlForm.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(7, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(52, 20);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.pnlSidebar.Controls.Add(this.btnEstoque);
            this.pnlSidebar.Controls.Add(this.btnMenu);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnSair);
            this.pnlSidebar.Controls.Add(this.btnRelatorios);
            this.pnlSidebar.Controls.Add(this.btnVoluntarios);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(220, 1080);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(82, 681);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(82, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 369);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(220, 53);
            this.btnEstoque.TabIndex = 8;
            this.btnEstoque.Text = "        Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(220, 82);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "        Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tmrSidebarAnimation
            // 
            this.tmrSidebarAnimation.Interval = 20;
            this.tmrSidebarAnimation.Tick += new System.EventHandler(this.tmrSidebarAnimation_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1232, 676);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1920, 1077);
            this.MinimumSize = new System.Drawing.Size(1230, 659);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Timer tmrSidebarAnimation;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEstoque;
    }
}