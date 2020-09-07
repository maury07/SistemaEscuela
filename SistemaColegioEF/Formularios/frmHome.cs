using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaColegioEF.Formularios
{
    public partial class frmHome : Form
    {
        string idUser;
        bool logueado;
        public frmHome(int id, string usuario, string pass, string permiso)
        {
            InitializeComponent();
            idUser = id.ToString();
            lblUsuario.Text = usuario;
            lblPermiso.Text = permiso;
            logueado = true;
            var a = permiso == "total" ? btnSistema.Enabled = true : btnSistema.Enabled = false;

        }

        //CIERRE_DE_SESION
        private void button1_Click(object sender, EventArgs e)
        {
            logueado = false;
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logueado)
            {
                DialogResult dgLogout = MessageBox.Show(this, "¿Está seguro que quiere cerrar la sesión?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dgLogout == DialogResult.Yes)
                {
                    return;
                }
                if (dgLogout == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                DialogResult dgExit = MessageBox.Show(this, "Saliendo del programa, ¿Está seguro?", "¡ATENCIÓN!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dgExit == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                if (dgExit == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }*/

        private void btnSistema_Click(object sender, EventArgs e)
        {
            frmSistema oFrmSistema = new frmSistema();
            oFrmSistema.ShowDialog();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiantes oFrmEstudiantes = new frmEstudiantes();
            oFrmEstudiantes.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmProfesores ofrmProfesores = new frmProfesores();
            ofrmProfesores.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            frmMaterias ofrmMaterias = new frmMaterias();
            ofrmMaterias.ShowDialog();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            frmCalificaciones ofrmCalificaciones = new frmCalificaciones();
            ofrmCalificaciones.ShowDialog();
        }
    }
}
