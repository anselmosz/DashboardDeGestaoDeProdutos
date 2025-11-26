using Projeto_Socorrista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFA_WinForms
{
    public partial class frmMenuPrincipal : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

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
            //foreach (Control ctrl in pnlSidebar.Controls)
            //{
            //    ctrl.ForeColor = Color.White;
            //    ctrl.BackColor = Color.FromArgb(48, 112, 99);
            //}

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            //    ActiveButton(btnHome);
            //    ActiveFormClose();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //    ActiveButton(btnDashboard);
            //    FormShow(new frmDashboard());

            frmDashboard abrir = new frmDashboard();
            abrir.Show();
            this.Hide();
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            //ActiveButton(btnVoluntarios);
            //FormShow(new frmGestaoDeVoluntarios());
            
            frmGestaoDeVoluntarios abrir = new frmGestaoDeVoluntarios();

            abrir.Show();
            this.Hide();
        }


        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            //ActiveButton(btnRelatorios);
            //FormShow(new frmRelatorios());

            frmRelatorios abrir = new frmRelatorios();

            abrir.Show();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //ActiveButton(btnAlimentos);
            //FormShow(new frmEstoque());

            frmEstoque abrir = new frmEstoque();

            abrir.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrarAlimentos abrir = new frmCadastrarAlimentos();
            abrir.Show();
            this.Hide();
        }
    }
}
