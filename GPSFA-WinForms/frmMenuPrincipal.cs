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
            foreach (Control ctrl in pnlSideMenu.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }
            frmAtivo.ForeColor = Color.Red;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(btnDashboard);
            FormShow(new frmDashboard());
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnVoluntarios);
            FormShow(new frmVoluntarios());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMenu);
            ActiveFormClose();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorios);
            FormShow(new frmRelatorios());
        }
    }
}
