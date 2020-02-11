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

        EscuelaDBEntities db = new EscuelaDBEntities();
        public void cargaUsuarios()
        {
            var result = from u in db.Usuarios
                         join r in db.Roles on u.idUsuario equals r.idUsuario
                         select new { u.idUsuario, u.usuario1, u.pass, r.permiso };

            dgvUsuariosSys.DataSource = result.ToList();
        }

        int idUser;

        private void frmSistema_Load(object sender, EventArgs e)
        {
            cargaUsuarios();
            cbPermisosSys.Items.Clear();
            cargarPermisos();
            dgvUsuariosSys.ClearSelection();

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
            dgvUsuariosSys.DataSource = null;
            cargaUsuarios();
            tbBusquedaUsuarioNombre.Clear();
        }

        private void btnNuevoSys_Click(object sender, EventArgs e)
        {
            tbUsuarioSys.Clear();
            tbContraseñaSys.Clear();
            tbUsuarioSys.Focus();
            btnEditarSys.Enabled = false;
            btnEliminarSys.Enabled = false;
            gbSistema_ABM.Enabled = true;
        }

        private void dgvUsuariosSys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarSys.Enabled = true;
            btnEliminarSys.Enabled = true;
            gbSistema_ABM.Enabled = true;
            btnNuevoSys.Enabled = false;
            idUser = int.Parse(dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[0].Value.ToString());
            tbUsuarioSys.Text = dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[1].Value.ToString();
            tbContraseñaSys.Text = dgvUsuariosSys.Rows[dgvUsuariosSys.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void btnCancelarSys_Click(object sender, EventArgs e)
        {
            btnNuevoSys.Enabled = true;
            btnEliminarSys.Enabled = true;
            btnEditarSys.Enabled = true;
            tbUsuarioSys.Clear();
            tbContraseñaSys.Clear();
        }

        private void tbBusquedaUsuarioNombre_TextChanged(object sender, EventArgs e)
        {
            var temp = from u in db.Usuarios
                       join r in db.Roles on u.idUsuario equals r.idUsuario
                       where u.usuario1.StartsWith(tbBusquedaUsuarioNombre.Text)
                       select new { u.idUsuario, u.usuario1, u.pass, r.permiso };

            dgvUsuariosSys.DataSource = temp.ToList();
        }

        private void btnGuardarSys_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idUser.ToString() + ", " + tbUsuarioSys.Text + ", " + tbContraseñaSys.Text+", "+ cbPermisosSys.SelectedItem.ToString());
        }
    }
}
