using Projeto_Socorrista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmMenuPrincipal : Form
    {
        private Form frmAtivo;
        bool sidebarExpand;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;

            frm.TopLevel = false;

            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null) { 
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                ctrl.ForeColor = Color.White;
                ctrl.BackColor = Color.FromArgb(48, 112, 99);
            }
            frmAtivo.BackColor = Color.FromArgb(112, 194, 177);

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(btnDashboard);
            FormShow(new frmDashboard());
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnVoluntarios);
            FormShow(new frmGestaoDeVoluntarios());
        }


        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorios);
            FormShow(new frmRelatorios());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEstoque);
            FormShow(new frmEstoque());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrSidebarAnimation.Start();
        }

       
        private void tmrSidebarAnimation_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // se a sidebar estiver expandida, ela minimiza
                pnlSidebar.Width -= 10;
                if (pnlSidebar.Width == pnlSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tmrSidebarAnimation.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if (pnlSidebar.Width == pnlSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tmrSidebarAnimation.Stop();
                }
            }
        }
    }
}
