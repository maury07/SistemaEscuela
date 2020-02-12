using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaColegioEF.Modelo;
using SistemaColegioEF.Formularios;

namespace SistemaColegioEF
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        EscuelaDB db = new EscuelaDB();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsuario.Text))
            {
                MessageBox.Show("Ingrese por favor un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsuario.Focus();
                return;
            }
            try
            {
                var result = from u in db.Usuarios
                            join r in db.Roles on u.idRol equals r.idRoles
                            where u.usuario1 == tbUsuario.Text && u.pass == tbContraseña.Text
                            select new { Id = u.idUsuario, User = u.usuario1, Pass = u.pass, Permiso = r.permiso};

                if(result?.FirstOrDefault() != null)
                {
                    var oUser = result.First();
                    frmHome oFrmHome = new frmHome(oUser.Id, oUser.User, oUser.Pass, oUser.Permiso);
                    oFrmHome.Show();
                    tbUsuario.Clear();
                    tbContraseña.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    tbUsuario.Clear();
                    tbContraseña.Clear();
                    tbUsuario.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
