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
            this.tmrSidebarAnimation = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlForm.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(5, 136);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(242, 69);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "        Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(5, 776);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(242, 69);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "        Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(5, 298);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(242, 69);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "        Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoluntarios.FlatAppearance.BorderSize = 0;
            this.btnVoluntarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoluntarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVoluntarios.Image")));
            this.btnVoluntarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoluntarios.Location = new System.Drawing.Point(5, 379);
            this.btnVoluntarios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVoluntarios.Size = new System.Drawing.Size(242, 69);
            this.btnVoluntarios.TabIndex = 2;
            this.btnVoluntarios.Text = "        Voluntários";
            this.btnVoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoluntarios.UseVisualStyleBackColor = false;
            this.btnVoluntarios.Click += new System.EventHandler(this.btnVoluntarios_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(5, 216);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(242, 69);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "        Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.lblHome);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(103, 0);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1477, 851);
            this.pnlForm.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(9, 11);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(80, 31);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSidebar.Controls.Add(this.btnMenu);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnSair);
            this.pnlSidebar.Controls.Add(this.btnRelatorios);
            this.pnlSidebar.Controls.Add(this.btnVoluntarios);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(251, 851);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(103, 851);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(103, 851);
            this.pnlSidebar.TabIndex = 0;
            // 
            // tmrSidebarAnimation
            // 
            this.tmrSidebarAnimation.Interval = 10;
            this.tmrSidebarAnimation.Tick += new System.EventHandler(this.tmrSidebarAnimation_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(5, 6);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(242, 118);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "        Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1580, 851);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
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
    }
}