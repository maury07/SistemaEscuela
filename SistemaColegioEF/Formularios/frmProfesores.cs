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
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
            suscribeEventos();
        }

        EscuelaDB db = new EscuelaDB();
        ucAbm abm = new ucAbm();
        ucBusqueda busq = new ucBusqueda();
        int id = 0;
        bool edit;

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            dgvProfesores.DataSource = null;
            cargarProfes();
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
            busq.textChanged += tbBusqueda_TextChanged;
            pnlBusqueda.Controls.Add(busq);
            pnlAbm.Controls.Add(abm);
        }

        private void setearGrilla()
        {
            dgvProfesores.Columns[0].Width = 10;
            dgvProfesores.Columns[1].HeaderText = "Nombre";
            dgvProfesores.Columns[2].HeaderText = "Apellido";
            dgvProfesores.Columns[3].HeaderText = "DNI";
            dgvProfesores.Columns[4].HeaderText = "Sexo";
            dgvProfesores.Columns[5].HeaderText = "Fecha de Nacimiento";
            dgvProfesores.Columns[5].Width = 150;
            dgvProfesores.Columns[6].HeaderText = "Dirección";
            dgvProfesores.Columns[7].HeaderText = "Tel.";
            dgvProfesores.Columns[8].HeaderText = "Email";
            dgvProfesores.Columns[9].HeaderText = "Nivel";
            dgvProfesores.Columns[10].HeaderText = "Especialidad";
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
                cargarProfes();
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
            if (rbSexoProf_F.Checked)
                sexo = "F";
            if (rbSexoProf_H.Checked)
                sexo = "H";
            Persona oPersona = new Persona();
            oPersona.nombre = tbNombreProf.Text;
            oPersona.apellido = tbApellidoProf.Text;
            oPersona.dni = tbDniProf.Text;
            oPersona.sexo = sexo;
            oPersona.fechaNac = dtpFechaNacAlu.Value;
            oPersona.direccion = tbDireccionProf.Text;
            oPersona.telefono = tbTelefonoProf.Text;
            oPersona.email = tbEmailProf.Text;

            db.Personas.Add(oPersona);
            db.SaveChanges();

            Profesor oProfesor = new Profesor();
            oProfesor.especialidad = tbEspecialidadProf.Text;
            oProfesor.nivel = tbNivelProf.Text;
            oProfesor.idPersona = oPersona.idPersona;
            db.Profesors.Add(oProfesor);
            db.SaveChanges();

        }

        public void editar()
        {
            var persona = (from a in db.Personas
                           where a.idPersona == id
                           select a).FirstOrDefault();

            persona.nombre = tbNombreProf.Text;
            persona.apellido = tbApellidoProf.Text;
            persona.dni = tbDniProf.Text;
            persona.sexo = (rbSexoProf_F.Checked) ? "F" : "H";
            persona.fechaNac = dtpFechaNacAlu.Value;
            persona.direccion = tbDireccionProf.Text;
            persona.telefono = tbTelefonoProf.Text;
            persona.email = tbEmailProf.Text;
            var profesor = (from a in db.Profesors
                          where a.idPersona == persona.idPersona
                          select a).FirstOrDefault();
            profesor.especialidad = tbEspecialidadProf.Text;
            profesor.nivel = tbNivelProf.Text;

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
                        Profesor oProfesor = (from a in db.Profesors
                                          where a.idPersona == id
                                          select a).FirstOrDefault();
                        db.Profesors.Remove(oProfesor);
                        db.SaveChanges();
                        MessageBox.Show("Se eliminó el registo con éxito!");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                cargarProfes();
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
            tbNombreProf.Clear();
            tbApellidoProf.Clear();
            tbDniProf.Clear();
            tbDireccionProf.Clear();
            tbTelefonoProf.Clear();
            tbEmailProf.Clear();
            tbEspecialidadProf.Clear();
            tbNivelProf.Clear();
            tbNombreProf.Focus();
            dgvProfesores.ClearSelection();
        }

        public void cargarCampos(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Error!");
                return;
            }
            edit = true;
            tbNombreProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[1].Value.ToString();
            tbApellidoProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[2].Value.ToString();
            tbDniProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[3].Value.ToString();
            if (dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[4].Value.ToString() == "F")
                rbSexoProf_F.Checked = true;
            if (dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[4].Value.ToString() == "H")
                rbSexoProf_H.Checked = true;
            dtpFechaNacAlu.Value = DateTime.Parse(dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[5].Value.ToString());
            tbDireccionProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[6].Value.ToString();
            tbTelefonoProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[7].Value.ToString();
            tbEmailProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[8].Value.ToString();
            tbEspecialidadProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[9].Value.ToString();
            tbNivelProf.Text = dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[10].Value.ToString();
            abm.Valid = validarCampos();
        }

        public void cargarProfes()
        {
            var result = from p in db.Personas
                         join pr in db.Profesors on p.idPersona equals pr.idPersona
                         select new { p.idPersona, p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, pr.nivel, pr.especialidad };

            dgvProfesores.DataSource = result.ToList();
            dgvProfesores.Columns["idPersona"].Visible = false;
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(tbNombreProf.Text))
                return false;
            if (string.IsNullOrEmpty(tbApellidoProf.Text))
                return false;
            if (string.IsNullOrEmpty(tbDniProf.Text))
                return false;
            if (dtpFechaNacAlu.Value.Date == DateTime.Today.Date)
                return false;
            if (string.IsNullOrEmpty(tbDireccionProf.Text))
                return false;
            if (string.IsNullOrEmpty(tbTelefonoProf.Text))
                return false;
            if (string.IsNullOrEmpty(tbEmailProf.Text))
                return false;
            if (string.IsNullOrEmpty(tbNivelProf.Text))
                return false;
            if (string.IsNullOrEmpty(tbEspecialidadProf.Text))
                return false;
            return true;
        }

        public void habilitCampos(object sender, EventArgs e)
        {
            tbNombreProf.Enabled = true;
            tbApellidoProf.Enabled = true;
            tbDniProf.Enabled = true;
            tbDireccionProf.Enabled = true;
            rbSexoProf_F.Enabled = true;
            rbSexoProf_H.Enabled = true;
            dtpFechaNacAlu.Enabled = true;
            tbTelefonoProf.Enabled = true;
            tbEmailProf.Enabled = true;
            tbNivelProf.Enabled = true;
            tbEspecialidadProf.Enabled = true;
        }

        public void deshabilitCampos(object sender, EventArgs e)
        {
            tbNombreProf.Enabled = false;
            tbApellidoProf.Enabled = false;
            tbDniProf.Enabled = false;
            tbDireccionProf.Enabled = false;
            rbSexoProf_F.Enabled = false;
            rbSexoProf_H.Enabled = false;
            dtpFechaNacAlu.Enabled = false;
            tbTelefonoProf.Enabled = false;
            tbEmailProf.Enabled = false;
            tbNivelProf.Enabled = false;
            tbEspecialidadProf.Enabled = false;
        }

        public void habilitGrilla(object sender, EventArgs e)
        {
            dgvProfesores.Enabled = true;
        }

        public void deshabilitGrilla(object sender, EventArgs e)
        {
            dgvProfesores.Enabled = false;
        }

        #endregion

        #region VALIDACION DE CAMPOS NUMERICOS

        private void tbDniProfesor_KeyPress(object sender, KeyPressEventArgs e)
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


        private void tbTelefonoProf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Cells[0].Value.ToString());
            dgvProfesores.Rows[dgvProfesores.CurrentRow.Index].Selected = true;
            cargarCampos(sender, e);
        }

        private void btnSalirAlu_Click(object sender, EventArgs e)
        {

            DialogResult dgEliminar = MessageBox.Show(this, "¿Desea cerrar la sección Profesores?", "¡Atención!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dgEliminar == DialogResult.Yes)
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
                             join pr in db.Profesors on p.idPersona equals pr.idPersona
                             where p.dni.StartsWith(cadenaBusq)
                             select new { p.idPersona, p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, pr.nivel, pr.especialidad};

                dgvProfesores.DataSource = result.ToList();
            }
            if (rb.Name == "rbBusqNombre")
            {
                var result = from p in db.Personas
                             join pr in db.Profesors on p.idPersona equals pr.idPersona
                             where p.nombre.StartsWith(cadenaBusq)
                             select new { p.idPersona, p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, pr.nivel, pr.especialidad };

                dgvProfesores.DataSource = result.ToList();
            }


        }

        #endregion

    }
}
