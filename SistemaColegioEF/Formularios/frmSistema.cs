using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaColegioEF.Modelo;

namespace SistemaColegioEF.Formularios
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        EscuelaDB db = new EscuelaDB();
        public void cargaUsuarios()
        {
            var result = from u in db.Usuarios
                         join r in db.Roles on u.idRol equals r.idRoles
                         select new { u.idUsuario, u.usuario1, u.pass, r.permiso };

            dgvUsuariosSys.DataSource = result.ToList();
        }
        public void listarUsuarios()
        {
            dgvUsuariosSys.DataSource = null;
            cargaUsuarios();
            tbBusquedaUsuarioNombre.Clear();
        }

        int idUser, idRol;
        bool editar = false;

        private void frmSistema_Load(object sender, EventArgs e)
        {
            cargaUsuarios();
            cbPermisosSys.Items.Clear();
            cargarPermisos();
            dgvUsuariosSys.ClearSelection();
            idRol = int.Parse(cbPermisosSys.SelectedValue.ToString());
        }

        public void cargarPermisos() 
        {
            var result1 = from roles in db.Roles
                         select roles;

            List<Role> listaRoles = new List<Role>();
            listaRoles = result1.ToList();
            //Vaciar comboBox
            cbPermisosSys.DataSource = null;

            //Asignar la propiedad DataSource
            cbPermisosSys.DataSource = listaRoles;

            //Indicar qué propiedad se verá en la lista
            cbPermisosSys.DisplayMember = "permiso";

            //Indicar qué valor tendrá cada ítem
            cbPermisosSys.ValueMember = "idRoles";
        }

        private void btnSalirSys_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarUsuariosSys_Click(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void btnNuevoSys_Click(object sender, EventArgs e)
        {
            tbUsuarioSys.Clear();
            tbContraseñaSys.Clear();
            tbUsuarioSys.Focus();
            btnEliminarSys.Enabled = false;
            gbSistema_ABM.Enabled = true;
            btnGuardarSys.Text = "Guardar";
            editar = false;
        }



        private void btnCancelarSys_Click(object sender, EventArgs e)
        {
            btnNuevoSys.Enabled = true;
            btnEliminarSys.Enabled = true;
            tbUsuarioSys.Clear();
            tbContraseñaSys.Clear();
        }

        private void tbBusquedaUsuarioNombre_TextChanged(object sender, EventArgs e)
        {
            var temp = from u in db.Usuarios
                       join r in db.Roles on u.idRol equals r.idRoles
                       where u.usuario1.StartsWith(tbBusquedaUsuarioNombre.Text)
                       select new { u.idUsuario, u.usuario1, u.pass, r.permiso };

            dgvUsuariosSys.DataSource = temp.ToList();
        }

        private void btnGuardarSys_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(idUser.ToString() + ", " + tbUsuarioSys.Text + ", " + tbContraseñaSys.Text+", "+ cbPermisosSys.SelectedText + ", "+ cbPermisosSys.SelectedValue.ToString());
            if (editar)
            {
                try
                {
                    var query = (from a in db.Usuarios
                                 where a.idUsuario == idUser
                                 select a).FirstOrDefault();

                    query.idUsuario = idUser;
                    query.pass = tbContraseñaSys.Text;
                    query.usuario1 = tbUsuarioSys.Text;
                    query.idRol = idRol;

                    db.SaveChanges();
                }
                catch (Exception ex)
                { }
            }
            else
            {
                try
                {
                    Usuario oUser = new Usuario();
                    oUser.usuario1 = tbUsuarioSys.Text;
                    oUser.pass = tbContraseñaSys.Text;
                    oUser.idRol = int.Parse(cbPermisosSys.SelectedValue.ToString());
                    db.Usuarios.Add(oUser);
                    
                    db.SaveChanges();
                }
                catch (Exception ex)
                { }
            }
            tbUsuarioSys.Clear();
            tbContraseñaSys.Clear();
            tbUsuarioSys.Focus();
            listarUsuarios();
        }


        private void dgvUsuariosSys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardarSys.Text = "Modificar";
            btnEliminarSys.Enabled = true;
            gbSistema_ABM.Enabled = true;
            btnNuevoSys.Enabled = false;
            editar = true;
            idUser = int.Parse(dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[0].Value.ToString());
            tbUsuarioSys.Text = dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[1].Value.ToString();
            tbContraseñaSys.Text = dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[2].Value.ToString();
            cbPermisosSys.SelectedValue = cambiaComboBox(dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[3].Value.ToString());
        }

        private void btnEliminarSys_Click(object sender, EventArgs e)
        {
            DialogResult dgEliminar = MessageBox.Show(this, "¿Está seguro que desea eliminar el usuario?", "¡Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dgEliminar == DialogResult.Yes)
            {
                Usuario oUser = (from a in db.Usuarios
                             where a.idUsuario == idUser
                             select a).FirstOrDefault();
                db.Usuarios.Remove(oUser);
                db.SaveChanges();
            }
            listarUsuarios();
        }

        public int cambiaComboBox(string rol)
        {
            int rol_id = 0;

            var result1 = from roles in db.Roles
                          select roles;

            List<Role> listaRoles = new List<Role>();
            listaRoles = result1.ToList();

            foreach (var i in listaRoles)
            {
                if (rol == i.permiso)
                { rol_id = i.idRoles; }
            }

            return rol_id;
            
        }
    }
}
