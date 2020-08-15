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
using System.Data.Entity.Validation;
using SistemaColegioEF.Controls;

namespace SistemaColegioEF.Formularios
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
            suscribeEventos();
        }

        EscuelaDB db = new EscuelaDB();
        ucAbm abm = new ucAbm();
        ucBusqueda busq = new ucBusqueda();
        int id = 0;
        bool edit;

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = null;
            cargarAlumnos();
            setearGrilla();
            deshabilitCampos(sender, e);
        }

        #region MÉTODOS PRIVADOS

        private void suscribeEventos()
        {
            abm.OnClickAgregar += habilitCampos;
            abm.OnClickEliminar += eliminar;
            abm.OnClickEditar += habilitCampos;
            abm.OnClickAceptar += confirmar;
            abm.OnClickCancelar += deshabilitCampos;
            abm.OnClickCancelar += limpiarCampos;
            abm.habilitarCampos += habilitCampos;
            abm.deshabilitarCampos += deshabilitCampos;
            abm.deshabilitarGrilla += deshabilitGrilla;
            abm.habilitarGrilla += habilitGrilla;
            abm.deshabilitarEdit += deshabilitEdit;
            busq.textChanged += tbBusqueda_TextChanged;
            pnlBusqueda.Controls.Add(busq);
            pnlAbm.Controls.Add(abm);
        }

        private void setearGrilla()
        {
            dgvAlumnos.Columns[1].HeaderText = "Nombre";
            dgvAlumnos.Columns[2].HeaderText = "Apellido";
            dgvAlumnos.Columns[3].HeaderText = "DNI";
            dgvAlumnos.Columns[4].HeaderText = "Sexo";
            dgvAlumnos.Columns[5].HeaderText = "Fecha de Nacimiento";
            dgvAlumnos.Columns[5].Width = 150;
            dgvAlumnos.Columns[6].HeaderText = "Dirección";
            dgvAlumnos.Columns[7].HeaderText = "Tel.";
            dgvAlumnos.Columns[8].HeaderText = "Email";
            dgvAlumnos.Columns[9].HeaderText = "Año Lectivo";
            dgvAlumnos.Columns[10].HeaderText = "N° Legajo";
        }

        public void confirmar(object sender, EventArgs e)
        {
            try
            {
                if (abm.Valid = validarCampos())
                {
                    if (edit)
                    {
                        editar();
                    }
                    else
                    {
                        agregar();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos necesarios");
                    return;
                }
                cargarAlumnos();
                limpiarCampos(sender, e);
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

        public void agregar()
        {
            string sexo = "";
            if (rbSexoAlu_F.Checked)
                sexo = "F";
            if (rbSexoAlu_H.Checked)
                sexo = "H";
            Persona oPersona = new Persona();
            oPersona.nombre = tbNombreAlu.Text;
            oPersona.apellido = tbApellidoAlu.Text;
            oPersona.dni = tbDniAlumno.Text;
            oPersona.sexo = sexo;
            oPersona.fechaNac = dtpFechaNacAlu.Value;
            oPersona.direccion = tbDireccionAlu.Text;
            oPersona.telefono = tbTelefonoAlu.Text;
            oPersona.email = tbEmailAlu.Text;
            oPersona.activo = 1;

            db.Personas.Add(oPersona);
            db.SaveChanges();

            Alumno oAlumno = new Alumno();
            oAlumno.año_lectivo = int.Parse(tbAñoLectivoAlu.Text);
            oAlumno.nroLegajo = tbNroLegajoAlu.Text;
            oAlumno.idPersona = oPersona.idPersona;
            db.Alumnoes.Add(oAlumno);
            db.SaveChanges();

        }

        public void editar()
        {
            var persona = (from a in db.Personas
                           where a.idPersona == id
                           select a).FirstOrDefault();

            persona.nombre = tbNombreAlu.Text;
            persona.apellido = tbApellidoAlu.Text;
            persona.dni = tbDniAlumno.Text;
            persona.sexo = (rbSexoAlu_F.Checked) ? "F" : "H";
            persona.fechaNac = dtpFechaNacAlu.Value;
            persona.direccion = tbDireccionAlu.Text;
            persona.telefono = tbTelefonoAlu.Text;
            persona.email = tbEmailAlu.Text;
            
            var alumno = (from a in db.Alumnoes
                          where a.idPersona == persona.idPersona
                          select a).FirstOrDefault();
            alumno.año_lectivo = int.Parse(tbAñoLectivoAlu.Text);
            alumno.nroLegajo = tbNroLegajoAlu.Text;

            db.SaveChanges();
        }

        public void eliminar(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DialogResult dgEliminar = MessageBox.Show(this, "¿Está seguro que desea eliminar este registro?", "¡Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dgEliminar == DialogResult.Yes)
                {
                    try
                    {
                        //Alumno oAlumno = (from a in db.Alumnoes
                        //                  where a.idPersona == id
                        //                  select a).FirstOrDefault();
                        //db.Alumnoes.Remove(oAlumno);
                        var persona = (from a in db.Personas
                                       where a.idPersona == id
                                       select a).FirstOrDefault();
                        persona.activo = 0; //Persona inactiva (Baja lógica)
                        db.SaveChanges();
                        MessageBox.Show("Se eliminó el registo con éxito!");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                cargarAlumnos();
                limpiarCampos(sender, e);
                deshabilitCampos(sender, e);
            }
            else
                abm.Valid = false;
        }

        #endregion

        #region METODOS DE VALIDACION DE CAMPOS

        public void limpiarCampos(object sender, EventArgs e)
        {
            id = 0;
            tbNombreAlu.Clear();
            tbApellidoAlu.Clear();
            tbDniAlumno.Clear();
            tbDireccionAlu.Clear();
            tbTelefonoAlu.Clear();
            tbEmailAlu.Clear();
            tbAñoLectivoAlu.Clear();
            tbNroLegajoAlu.Clear();
            tbNombreAlu.Focus();
            dgvAlumnos.ClearSelection();
        }

        public void cargarCampos(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Error!");
                return;
            }
            edit = true;
            tbNombreAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[1].Value.ToString();
            tbApellidoAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[2].Value.ToString();
            tbDniAlumno.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[3].Value.ToString();
            if (dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[4].Value.ToString() == "F")
                rbSexoAlu_F.Checked = true;
            if (dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[4].Value.ToString() == "H")
                rbSexoAlu_H.Checked = true;
            dtpFechaNacAlu.Value = DateTime.Parse(dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[5].Value.ToString());
            tbDireccionAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[6].Value.ToString();
            tbTelefonoAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[7].Value.ToString();
            tbEmailAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[8].Value.ToString();
            tbAñoLectivoAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[9].Value.ToString();
            tbNroLegajoAlu.Text = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[10].Value.ToString();
            abm.Valid = validarCampos();
        }

        public void cargarAlumnos()
        {
            var result = from p in db.Personas
                         join al in db.Alumnoes on p.idPersona equals al.idPersona
                         where p.activo == 1
                         select new { p.idPersona, p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, al.año_lectivo, al.nroLegajo };

            dgvAlumnos.DataSource = result.ToList();
            dgvAlumnos.Columns["idPersona"].Visible = false;
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(tbNombreAlu.Text))
                return false;
            if (string.IsNullOrEmpty(tbApellidoAlu.Text))
                return false;
            if (string.IsNullOrEmpty(tbDniAlumno.Text))
                return false;
            if (dtpFechaNacAlu.Value.Date == DateTime.Today.Date)
                return false;
            if (string.IsNullOrEmpty(tbDireccionAlu.Text))
                return false;
            if (string.IsNullOrEmpty(tbTelefonoAlu.Text))
                return false;
            if (string.IsNullOrEmpty(tbEmailAlu.Text))
                return false;
            if (string.IsNullOrEmpty(tbNroLegajoAlu.Text))
                return false;
            if (string.IsNullOrEmpty(tbAñoLectivoAlu.Text))
                return false;
            return true;
        }

        public void habilitCampos(object sender, EventArgs e)
        {
            tbNombreAlu.Enabled = true;
            tbApellidoAlu.Enabled = true;
            tbDniAlumno.Enabled = true;
            tbDireccionAlu.Enabled = true;
            rbSexoAlu_F.Enabled = true;
            rbSexoAlu_H.Enabled = true;
            dtpFechaNacAlu.Enabled = true;
            tbTelefonoAlu.Enabled = true;
            tbEmailAlu.Enabled = true;
            tbNroLegajoAlu.Enabled = true;
            tbAñoLectivoAlu.Enabled = true;
            tbNombreAlu.Focus();
        }

        public void deshabilitCampos(object sender, EventArgs e)
        {
            tbNombreAlu.Enabled = false;
            tbApellidoAlu.Enabled = false;
            tbDniAlumno.Enabled = false;
            tbDireccionAlu.Enabled = false;
            rbSexoAlu_F.Enabled = false;
            rbSexoAlu_H.Enabled = false;
            dtpFechaNacAlu.Enabled = false;
            tbTelefonoAlu.Enabled = false;
            tbEmailAlu.Enabled = false;
            tbNroLegajoAlu.Enabled = false;
            tbAñoLectivoAlu.Enabled = false;
        }

        public void habilitGrilla(object sender, EventArgs e)
        {
            dgvAlumnos.Enabled = true;
        }

        public void deshabilitGrilla(object sender, EventArgs e)
        {
            dgvAlumnos.Enabled = false;
        }

        public void deshabilitEdit()
        {
            edit = false;
        }

        #endregion

        #region VALIDACION DE CAMPOS NUMERICOS

        private void tbDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbNroLegajoAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbTelefonoAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbAñoLectivoAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        #endregion

        #region MÉTODOS PERSONALIZADOS

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[0].Value.ToString());
            dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Selected = true;
            cargarCampos(sender, e);
        }

        private void btnSalirAlu_Click(object sender, EventArgs e)
        {

            DialogResult dgCerrar = MessageBox.Show(this, "¿Desea cerrar la sección Alumnos?", "¡Atención!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dgCerrar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            RadioButton rb = busq.getRadioButton();
            string cadenaBusq = busq.getTextBox();
            if (rb.Name == "rbBusqDni")
            {
               var result = from p in db.Personas
                             join al in db.Alumnoes on p.idPersona equals al.idPersona
                             where p.dni.StartsWith(cadenaBusq)
                             select new { p.idPersona, p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, al.año_lectivo, al.nroLegajo };

                dgvAlumnos.DataSource = result.ToList();
            }
            if (rb.Name == "rbBusqNombre")
            {
                var result = from p in db.Personas
                             join al in db.Alumnoes on p.idPersona equals al.idPersona
                             where p.nombre.StartsWith(cadenaBusq)
                             select new { p.idPersona, p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, al.año_lectivo, al.nroLegajo };

                dgvAlumnos.DataSource = result.ToList();
            }

           
        }

        #endregion

    }
}
