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
using SistemaColegioEF.Funciones;
using System.Globalization;

namespace SistemaColegioEF.Formularios
{
    public partial class frmAsistencias : Form
    {
        public frmAsistencias()
        {
            InitializeComponent();
        }
        EscuelaDB db = new EscuelaDB();
        Validaciones validar = new Validaciones();

        private void frmAsistencias_Load(object sender, EventArgs e)
        {
            cargaCombosPantalla();
            cargarAsistenciasAlumnos();
            setearGrillaAsistencias();
        }

        private void tcAsistencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (tcAsistencias.SelectedTab == tcAsistencias.TabPages["tpAlumnosAsist"])
                {
                    cargarAsistenciasAlumnos();
                    setearGrillaAsistencias();
                    cargaCombosPantalla();
                }
                if (tcAsistencias.SelectedTab == tcAsistencias.TabPages["tpProfAsist"])
                {
                    cargaComboProfes();
                    cargarAsistenciasProfes();
                    setearGrillaAsistenciasProfes();
                }
                if (tcAsistencias.SelectedTab == tcAsistencias.TabPages["tpBusqAsist"])
                {
                    cargaComboProfesBusq();
                    cargaComboCursoBusq();
                }
            }
        }

        #region TAB ASISTENCIA ALUMNOS

        public void setearGrillaAsistencias()
        {
            dgvAsistAlumn.Columns[0].HeaderText = "Nombre Completo";
            dgvAsistAlumn.Columns[0].Width = 170;
            dgvAsistAlumn.Columns[1].HeaderText = "Estado";
            dgvAsistAlumn.Columns[1].Width = 150;
            dgvAsistAlumn.Columns[2].HeaderText = "Fecha";
            dgvAsistAlumn.Columns[2].Width = 150;
        }

        public void cargaCombosPantalla()
        {
            cargaComboAño();
        }

        private void cargaComboAño()
        {
            var result = (from alm in db.Alumno_Materia
                          join pr in db.Alumnoes on alm.idAlumno equals pr.idAlumno
                          join m in db.Materias on alm.idMateria equals m.idMateria
                          where alm.activo == 1
                          group alm by new { añoMateria = alm.año }
                          into grp
                          select new
                          {
                              añoMateria = grp.Key.añoMateria
                          })
                          .ToList();

            if (result.Count() == 0)
            {
                cboAlumnoAsist.DataSource = null;
                cboAlumnoAsist.Enabled = false;
                return;
            }

            //Asignar la propiedad DataSource
            cboAñoAlumnoAsist.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboAñoAlumnoAsist.DisplayMember = "añoMateria";

            //Indicar qué valor tendrá cada ítem
            cboAñoAlumnoAsist.ValueMember = "añoMateria";
        }

        private void cargaComboAlumnos(int añoAlumno)
        {
            var result = (from am in db.Alumno_Materia
                          join al in db.Alumnoes on am.idAlumno equals al.idAlumno
                          join p in db.Personas on al.idPersona equals p.idPersona
                          where am.activo == 1 && am.año == añoAlumno
                          select new
                          {
                              nombreCompletoAlu = p.apellido + ", " + p.nombre,
                              añoAlumno = am.año,
                              idAlumno = al.idAlumno
                          }).Distinct().ToList();

            //Asignar la propiedad DataSource
            cboAlumnoAsist.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboAlumnoAsist.DisplayMember = "nombreCompletoAlu";

            //Indicar qué valor tendrá cada ítem
            cboAlumnoAsist.ValueMember = "idAlumno";
        }

        private void cboAñoAlumnoAsist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboAlumnoAsist.Enabled = true;
            int curso = int.Parse(cboAñoAlumnoAsist.SelectedValue.ToString());
            cargaComboAlumnos(curso);
        }

        private bool validarCombos()
        {
            if (cboAñoAlumnoAsist.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun curso", "ERROR!");
                return true;
            }
            if (cboAlumnoAsist.SelectedIndex == -1)
            {
                MessageBox.Show("No se seleccionó el alumno", "ERROR!");
                return true;
            }

            return false;
        }

        private void cargarAsistenciasAlumnos()
        {
            var asist = (from asi in db.AlumnoAsistencias
                         join a in db.Alumnoes on asi.idAlumno equals a.idAlumno
                         join p in db.Personas on a.idPersona equals p.idPersona
                         where p.activo == 1
                         select new
                         {
                             nombreCompleto = p.nombre + ", " + p.apellido,
                             estado = asi.estado,
                             fecha = asi.fecha
                         }).OrderBy(x => x.fecha);
            dgvAsistAlumn.DataSource = asist.ToList();
        }

        private void btnAsistioAlumno_Click(object sender, EventArgs e)
        {
            int curso = int.Parse(cboAñoAlumnoAsist.SelectedValue.ToString());
            int idAlumn = int.Parse(cboAlumnoAsist.SelectedValue.ToString());
            DateTime fecha = dtpFechaAlumnAsist.Value.Date;

            try
            {
                if (validarCombos()) { return; }
                if(validar.validarExisteAsistAlumno(idAlumn, fecha)) { return; }

                AlumnoAsistencia oAlumnoAsistencia = new AlumnoAsistencia();
                oAlumnoAsistencia.idAlumno = idAlumn;
                oAlumnoAsistencia.estado = "ASISTIÓ";
                oAlumnoAsistencia.fecha = fecha;
                db.AlumnoAsistencias.Add(oAlumnoAsistencia);
                db.SaveChanges();
                MessageBox.Show("Se cargó la asistencia");

                cargarAsistenciasAlumnos();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        private void btnNoasistioAlumno_Click(object sender, EventArgs e)
        {
            int curso = int.Parse(cboAñoAlumnoAsist.SelectedValue.ToString());
            int idAlumn = int.Parse(cboAlumnoAsist.SelectedValue.ToString());
            DateTime fecha = dtpFechaAlumnAsist.Value.Date;

            try
            {
                if (validarCombos()) { return; }
                if (validar.validarExisteAsistAlumno(idAlumn, fecha)) { return; }

                AlumnoAsistencia oAlumnoAsistencia = new AlumnoAsistencia();
                oAlumnoAsistencia.idAlumno = idAlumn;
                oAlumnoAsistencia.estado = "NO ASISTIÓ";
                oAlumnoAsistencia.fecha = fecha;
                db.AlumnoAsistencias.Add(oAlumnoAsistencia);
                db.SaveChanges();
                MessageBox.Show("Se cargó la asistencia");

                cargarAsistenciasAlumnos();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var asist = (from asi in db.AlumnoAsistencias
                         join a in db.Alumnoes on asi.idAlumno equals a.idAlumno
                         join p in db.Personas on a.idPersona equals p.idPersona
                         where p.activo == 1 && asi.fecha == dtpFechaAlumnAsist.Value.Date
                         select new
                         {
                             nombreCompleto = p.nombre + ", " + p.apellido,
                             estado = asi.estado,
                             fecha = asi.fecha
                         });
            dgvAsistAlumn.DataSource = asist.ToList();
        }

        private void btnListarAsistAlumn_Click(object sender, EventArgs e)
        {
            cargarAsistenciasAlumnos();
        }

        #endregion

        #region TAB ASISTENCIA PROFESORES

        public void cargaComboProfes()
        {
            var resultProfs = (from p in db.Personas
                               join pr in db.Profesors on p.idPersona equals pr.idPersona
                               where p.activo == 1
                               select new
                               {
                                   nombreCompletoProf = p.apellido + ", " + p.nombre,
                                   idProfesor = pr.idProfesor
                               }).ToList();

            if (resultProfs.Count() == 0)
            {
                dgvAsistProf.DataSource = null;
                return;
            }

            //Asignar la propiedad DataSource
            cboProfAsist.DataSource = resultProfs;

            //Indicar qué propiedad se verá en la lista
            cboProfAsist.DisplayMember = "nombreCompletoProf";

            //Indicar qué valor tendrá cada ítem
            cboProfAsist.ValueMember = "idProfesor";
        }

        public void setearGrillaAsistenciasProfes()
        {
            dgvAsistProf.Columns[0].HeaderText = "Nombre Completo";
            dgvAsistProf.Columns[0].Width = 170;
            dgvAsistProf.Columns[1].HeaderText = "Estado";
            dgvAsistProf.Columns[1].Width = 150;
            dgvAsistProf.Columns[2].HeaderText = "Fecha";
            dgvAsistProf.Columns[2].Width = 150;
        }

        private bool validarCombosProf()
        {
            if (cboProfAsist.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun profesor", "ERROR!");
                return true;
            }

            return false;
        }

        private void cargarAsistenciasProfes()
        {
            var asist = (from pra in db.ProfAsistencias
                         join pr in db.Profesors on pra.idProfesor equals pr.idProfesor
                         join p in db.Personas on pr.idPersona equals p.idPersona
                         where p.activo == 1
                         select new
                         {
                             nombreCompleto = p.nombre + ", " + p.apellido,
                             estado = pra.estado,
                             fecha = pra.fecha
                         }).OrderBy(x => x.fecha);
            dgvAsistProf.DataSource = asist.ToList();
        }

        private void btnProfAsistio_Click(object sender, EventArgs e)
        {
            int idProf = int.Parse(cboAñoAlumnoAsist.SelectedValue.ToString());
            DateTime fechaProf = dtpFechaProfAsist.Value.Date;

            try
            {
                if (validarCombosProf()) { return; }
                if (validar.validarExisteAsistProfe(idProf, fechaProf)) { return; }

                ProfAsistencia profAsistencia = new ProfAsistencia();
                profAsistencia.idProfesor = idProf;
                profAsistencia.estado = "ASISTIÓ";
                profAsistencia.fecha = fechaProf;
                db.ProfAsistencias.Add(profAsistencia);
                db.SaveChanges();
                MessageBox.Show("Se cargó la asistencia");

                cargarAsistenciasProfes();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        private void btnProfNoAsistio_Click(object sender, EventArgs e)
        {
            int idProf = int.Parse(cboAñoAlumnoAsist.SelectedValue.ToString());
            DateTime fechaProf = dtpFechaProfAsist.Value.Date;

            try
            {
                if (validarCombosProf()) { return; }
                if (validar.validarExisteAsistProfe(idProf, fechaProf)) { return; }

                ProfAsistencia profAsistencia = new ProfAsistencia();
                profAsistencia.idProfesor = idProf;
                profAsistencia.estado = "NO ASISTIÓ";
                profAsistencia.fecha = fechaProf;
                db.ProfAsistencias.Add(profAsistencia);
                db.SaveChanges();
                MessageBox.Show("Se cargó la asistencia");

                cargarAsistenciasProfes();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }
        private void btnFiltrarFechaProfAsist_Click(object sender, EventArgs e)
        {
            var asist = (from pra in db.ProfAsistencias
                         join pr in db.Profesors on pra.idProfesor equals pr.idProfesor
                         join p in db.Personas on pr.idPersona equals p.idPersona
                         where p.activo == 1 && pra.fecha == dtpFechaProfAsist.Value.Date
                         select new
                         {
                             nombreCompleto = p.nombre + ", " + p.apellido,
                             estado = pra.estado,
                             fecha = pra.fecha
                         });
            dgvAsistProf.DataSource = asist.ToList();
        }

        private void btnListarAsistProf_Click(object sender, EventArgs e)
        {
            cargarAsistenciasProfes();
        }

        #endregion

        #region TAB BUSQUEDA ASISTENCIAS

        private void rbBusqProfAsist_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBusqProfAsist.Checked)
            {
                cboProfAsistBusqueda.Enabled = true;
                cboAñoBusqAsist.Enabled = false;
            }
            else
            {
                cboProfAsistBusqueda.Enabled = false;
                cboAñoBusqAsist.Enabled = true;
            }
        }

        public void cargaComboProfesBusq()
        {
            var resultProfs = (from p in db.Personas
                               join pr in db.Profesors on p.idPersona equals pr.idPersona
                               where p.activo == 1
                               select new
                               {
                                   nombreCompletoProf = p.apellido + ", " + p.nombre,
                                   idProfesor = pr.idProfesor
                               }).ToList();

            if (resultProfs.Count() == 0)
            {
                cboProfAsistBusqueda.DataSource = null;
                return;
            }

            //Asignar la propiedad DataSource
            cboProfAsistBusqueda.DataSource = resultProfs;

            //Indicar qué propiedad se verá en la lista
            cboProfAsistBusqueda.DisplayMember = "nombreCompletoProf";

            //Indicar qué valor tendrá cada ítem
            cboProfAsistBusqueda.ValueMember = "idProfesor";
        }

        private void cargaComboCursoBusq()
        {
            var result = (from alm in db.Alumno_Materia
                          join pr in db.Alumnoes on alm.idAlumno equals pr.idAlumno
                          join m in db.Materias on alm.idMateria equals m.idMateria
                          where alm.activo == 1
                          group alm by new { añoMateria = alm.año }
                          into grp
                          select new
                          {
                              añoMateria = grp.Key.añoMateria
                          })
                          .ToList();

            if (result.Count() == 0)
            {
                cboAñoBusqAsist.DataSource = null;
                return;
            }

            //Asignar la propiedad DataSource
            cboAñoBusqAsist.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboAñoBusqAsist.DisplayMember = "añoMateria";

            //Indicar qué valor tendrá cada ítem
            cboAñoBusqAsist.ValueMember = "añoMateria";
        }

        public void setearGrillaAsistenciasBusqueda()
        {
            dgvAsistBusq.Columns[0].HeaderText = "Nombre Completo";
            dgvAsistBusq.Columns[0].Width = 170;
            dgvAsistBusq.Columns[1].HeaderText = "Estado";
            dgvAsistBusq.Columns[1].Width = 150;
            dgvAsistBusq.Columns[2].HeaderText = "Fecha";
            dgvAsistBusq.Columns[2].Width = 150;
        }

        private void btnBuscarAsist_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaBusqAsist.Value.Date;

            if (rbBusqProfAsist.Checked)
            {
                if (cboProfAsistBusqueda.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ha seleccionado ningun profesor", "ERROR!");
                    return;
                }
                var asist = (from pra in db.ProfAsistencias
                             join pr in db.Profesors on pra.idProfesor equals pr.idProfesor
                             join p in db.Personas on pr.idPersona equals p.idPersona
                             where pra.fecha == fecha
                             select new
                             {
                                 nombreCompleto = p.nombre + ", " + p.apellido,
                                 estado = pra.estado,
                                 fecha = pra.fecha
                             }).OrderBy(x => x.nombreCompleto)
                             .Distinct().ToList();

                if (asist.Count() == 0)
                {
                    MessageBox.Show("No se ha encontrado asistencias guardadas", "Error!");
                    dgvAsistBusq.DataSource = null;
                    return;
                }

                dgvAsistBusq.DataSource = asist;
                setearGrillaAsistenciasBusqueda();
            }
            else
            {
                if (cboAñoBusqAsist.SelectedIndex == -1) 
                {
                    MessageBox.Show("No se ha seleccionado ningun curso", "ERROR!");
                    return;
                }
                int cursoAlumno = int.Parse(cboAñoBusqAsist.SelectedValue.ToString());
                var asist = (from asi in db.AlumnoAsistencias
                             join al in db.Alumnoes on asi.idAlumno equals al.idAlumno
                             join p in db.Personas on al.idPersona equals p.idPersona
                             join am in db.Alumno_Materia on asi.idAlumno equals am.idAlumno
                             where asi.fecha == fecha && am.año == cursoAlumno
                             select new
                             {
                                 nombreCompleto = p.nombre + ", " + p.apellido,
                                 estado = asi.estado,
                                 fecha = asi.fecha
                             }).OrderBy(x => x.nombreCompleto)
                             .Distinct().ToList();

                if (asist.Count() == 0)
                {
                    MessageBox.Show("No se ha encontrado asistencias guardadas", "Error!");
                    dgvAsistBusq.DataSource = null;
                    return;
                }

                dgvAsistBusq.DataSource = asist;
                setearGrillaAsistenciasBusqueda();
            }
        }
        #endregion


    }
}
