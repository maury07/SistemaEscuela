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
using System.Data.Entity.Validation;

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
                    oFrmHome.ShowDialog();
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
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }
    }
}
