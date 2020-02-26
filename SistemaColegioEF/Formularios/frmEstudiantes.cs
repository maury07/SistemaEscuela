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

namespace SistemaColegioEF.Formularios
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        EscuelaDB db = new EscuelaDB();
        public void cargarAlumnos()
        {
            var result = from p in db.Personas
                         join al in db.Alumnoes on p.idPersona equals al.idPersona
                         select new { p.nombre, p.apellido, p.dni, p.sexo, p.fechaNac, p.direccion, p.telefono, p.email, al.año_lectivo, al.nroLegajo };

            dgvAlumnos.DataSource = result.ToList();
        }

        public void limpiarCampos()
        {
            tbNombreAlu.Clear();
            tbApellidoAlu.Clear();
            tbDniAlumno.Clear();
            tbDireccionAlu.Clear();
            tbTelefonoAlu.Clear();
            tbEmailAlu.Clear();
            tbAñoLectivoAlu.Clear();
            tbNroLegajoAlu.Clear();
            tbNombreAlu.Focus();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = null;
            cargarAlumnos();
        }

        private void btnAgregarAlu_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (rbSexoAlu_F.Checked)
                sexo = "F";
            if (rbSexoAlu_H.Checked)
                sexo = "H";

            try
            {
                Persona oPersona = new Persona();
                oPersona.nombre = tbNombreAlu.Text;
                oPersona.apellido = tbApellidoAlu.Text;
                oPersona.dni = int.Parse(tbDniAlumno.Text);
                oPersona.sexo = sexo;
                oPersona.fechaNac = dtpFechaNacAlu.Value;
                oPersona.direccion = tbDireccionAlu.Text;
                oPersona.telefono = int.Parse(tbTelefonoAlu.Text);
                oPersona.email = tbEmailAlu.Text;
                db.Personas.Add(oPersona);
                db.SaveChanges();

                Alumno oAlumno = new Alumno();
                oAlumno.año_lectivo = int.Parse(tbAñoLectivoAlu.Text);
                oAlumno.nroLegajo = tbNroLegajoAlu.Text;
                oAlumno.idPersona = oPersona.idPersona;
                db.Alumnoes.Add(oAlumno);
                db.SaveChanges();

                
                cargarAlumnos();
                limpiarCampos();
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

        #region METODOS_DE_VALIDACION_DE_CAMPOS_DE_SOLO_NUMEROS

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

        #endregion
    }
}
