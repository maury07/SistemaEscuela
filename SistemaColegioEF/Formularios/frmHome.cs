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
        string idUser, oPermiso;
        public frmHome(int id, string usuario, string pass, string permiso)
        {
            InitializeComponent();
            idUser = id.ToString();
            lblUsuario.Text = usuario;
            oPermiso = permiso;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (oPermiso == "parcial")
            {
                btnSistema.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
