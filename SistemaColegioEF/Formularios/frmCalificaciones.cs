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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }
        EscuelaDB db = new EscuelaDB();
        Validaciones validar = new Validaciones();

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            cargaCombosPantalla();
            cargarCalificaciones();
            setearGrillaCalif();
        }

        #region TAB GESTION NOTAS
        public void cargaCombosPantalla()
        {
            cargaComboProfes();
            cargaComboTrimestres();
        }

        public void setearGrillaCalif()
        {
            dgvCalificaciones.Columns[0].HeaderText = "Alumno";
            dgvCalificaciones.Columns[0].Width = 150;
            dgvCalificaciones.Columns[1].HeaderText = "Materia";
            dgvCalificaciones.Columns[1].Width = 120;
            dgvCalificaciones.Columns[2].HeaderText = "Profesor";
            dgvCalificaciones.Columns[2].Width = 150;
            dgvCalificaciones.Columns[3].HeaderText = "Año/Grado";
            dgvCalificaciones.Columns[3].Width = 65;
            dgvCalificaciones.Columns[4].HeaderText = "1er Trim";
            dgvCalificaciones.Columns[4].Width = 70;
            dgvCalificaciones.Columns[4].DefaultCellStyle.Format = "n2";
            dgvCalificaciones.Columns[5].HeaderText = "2do Trim";
            dgvCalificaciones.Columns[5].Width = 75;
            dgvCalificaciones.Columns[5].DefaultCellStyle.Format = "n2";
            dgvCalificaciones.Columns[6].HeaderText = "3er Trim";
            dgvCalificaciones.Columns[6].Width = 70;
            dgvCalificaciones.Columns[6].DefaultCellStyle.Format = "n2";
            dgvCalificaciones.Columns[7].HeaderText = "Dic/Marzo";
            dgvCalificaciones.Columns[7].Width = 70;
            dgvCalificaciones.Columns[7].DefaultCellStyle.Format = "n2";
            dgvCalificaciones.Columns[8].HeaderText = "Promedio Materia";
            dgvCalificaciones.Columns[8].Width = 90;
            dgvCalificaciones.Columns[8].DefaultCellStyle.Format = "n3";
        }

        public void cargarCalificaciones()
        {
            var result = (from c in db.Calificacions
                          join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                          join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                          join pe in db.Personas on al.idPersona equals pe.idPersona
                          join p in db.Personas on pr.idPersona equals p.idPersona
                          join m in db.Materias on c.idMateria equals m.idMateria
                          join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                          select new
                          {
                              Alumno = pe.apellido + ", " + pe.nombre,
                              nombreMateria = m.nombre,
                              Profe = p.apellido + ", " + p.nombre,
                              añoCalificacion = c.año,
                              nota1 = np.nota1,
                              nota2 = np.nota2,
                              nota3 = np.nota3,
                              previa = np.previa,
                              promedio = np.promedioMateria
                          }).OrderBy(x => x.añoCalificacion);
            dgvCalificaciones.DataSource = result.ToList();
        }

        #region COMBOS
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
                cboProfesores.DataSource = null;
                cboProfesores.Items.Clear();
                cboAños.Enabled = false;
                cboAlumnos.Enabled = false;
                cboMaterias.Enabled = false;
                return;
            }

            //Asignar la propiedad DataSource
            cboProfesores.DataSource = resultProfs;

            //Indicar qué propiedad se verá en la lista
            cboProfesores.DisplayMember = "nombreCompletoProf";

            //Indicar qué valor tendrá cada ítem
            cboProfesores.ValueMember = "idProfesor";
        }

        public void cargaComboAño(int idProf)
        {
            var result = (from mp in db.Profesor_Materia
                          join pr in db.Profesors on mp.idProfesor equals pr.idProfesor
                          join m in db.Materias on mp.idMateria equals m.idMateria
                          where mp.activo == 1 && mp.idProfesor == idProf
                          group mp by new { añoMateria = mp.año }
                          into grp
                          select new
                          {
                              añoMateria = grp.Key.añoMateria
                          })
                          .ToList();

            if (result.Count() == 0)
            {
                cboAños.DataSource = null;
                cboAños.Items.Clear();
                cboAlumnos.Enabled = false;
                cboMaterias.Enabled = false;
                return;
            }

            //Asignar la propiedad DataSource
            cboAños.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboAños.DisplayMember = "añoMateria";

            //Indicar qué valor tendrá cada ítem
            cboAños.ValueMember = "añoMateria";
        }

        public void cargaComboAlumnos(int añoAlumno)
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

            if (result.Count() == 0)
            {
                cboAlumnos.DataSource = null;
                cboAlumnos.Items.Clear();
                cboMaterias.Enabled = false;
                return;
            }

            //Asignar la propiedad DataSource
            cboAlumnos.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboAlumnos.DisplayMember = "nombreCompletoAlu";

            //Indicar qué valor tendrá cada ítem
            cboAlumnos.ValueMember = "idAlumno";
        }

        public void cargaComboMaterias(int idProfe)
        {
            var result = (from mp in db.Profesor_Materia
                          join pr in db.Profesors on mp.idProfesor equals pr.idProfesor
                          join m in db.Materias on mp.idMateria equals m.idMateria
                          where mp.activo == 1 && mp.idProfesor == idProfe
                          select new
                          {
                              nombreMateria = m.nombre,
                              idMateria = m.idMateria
                          }).Distinct().ToList();

            //Asignar la propiedad DataSource
            cboMaterias.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboMaterias.DisplayMember = "nombreMateria";

            //Indicar qué valor tendrá cada ítem
            cboMaterias.ValueMember = "idMateria";
        }

        public void cargaComboTrimestres()
        {
            //Llenar lista
            var dataSource = new List<NotaPorPeriodo>();
            dataSource.Add(new NotaPorPeriodo("Primer Trimestre") { periodo = 1 });
            dataSource.Add(new NotaPorPeriodo("Segundo Trimestre") { periodo = 2 });
            dataSource.Add(new NotaPorPeriodo("Tercer Trimestre") { periodo = 3 });
            dataSource.Add(new NotaPorPeriodo("Previa") { periodo = 4 });

            //Asignar la propiedad DataSource
            cboTrimestres.DataSource = dataSource;

            //Indicar qué propiedad se verá en la lista
            cboTrimestres.DisplayMember = "nombrePeriodo";

            //Indicar qué valor tendrá cada ítem
            cboTrimestres.ValueMember = "periodo";
        }

        public string devuelveNombrePeriodo(int trimestre)
        {
            string resp = "";
            if (trimestre == 1) resp = "Primer Trimestre";
            else if (trimestre == 2) resp = "Segundo Trimestre";
            else if (trimestre == 3) resp = "Tercer Trimestre";
            else if (trimestre == 4) resp = "Previa";

            return resp;
        }

        #endregion


        private void cboProfesores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboAños.Enabled = true;
            int profe = int.Parse(cboProfesores.SelectedValue.ToString());
            cargaComboAño(profe);
        }

        private void cboAños_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboAlumnos.Enabled = true;
            int año = int.Parse(cboAños.SelectedValue.ToString());
            cargaComboAlumnos(año);
        }

        private void cboAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboMaterias.Enabled = true;
            int profe = int.Parse(cboProfesores.SelectedValue.ToString());
            cargaComboMaterias(profe);
        }

        private bool validarCombos()
        {
            if (cboProfesores.SelectedIndex == -1)
            {
                MessageBox.Show("No existe profesor inscripto", "ERROR!");
                return true;
            }
            if (cboAños.SelectedIndex == -1)
            {
                MessageBox.Show("El profesor no está dictando alguna materia", "ERROR!");
                return true;
            }
            if (cboAlumnos.SelectedIndex == -1)
            {
                MessageBox.Show("No existe alumno inscripto en este año ", "ERROR!");
                return true;
            }
            if (cboMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una materia", "ERROR!");
                return true;
            }
            if (tbNota.Text.ToString().Contains("."))
            {
                MessageBox.Show("Por favor, use 'coma' y no 'punto'", "ERROR!");
                return true;
            }

            return false;
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(string.Format(tbNota.Text));
            valor = decimal.Parse(String.Format("{0:0.00}", valor));
            int trimestre = int.Parse(cboTrimestres.SelectedValue.ToString());
            int idProf = int.Parse(cboProfesores.SelectedValue.ToString());
            int año = int.Parse(cboAños.SelectedValue.ToString());
            int idAlumn = int.Parse(cboAlumnos.SelectedValue.ToString());
            int idMat = int.Parse(cboMaterias.SelectedValue.ToString());

            try
            {
                if (validarCombos()) { return; }
                if (validar.validarNotaTrimestre(idProf, idMat, idAlumn, trimestre, valor, año)) { return; }
                int idCalific = validar.calificacionAbierta(idProf, idMat, idAlumn, año);
                if (idCalific.Equals(0)) //Si el método CalificacionAbierta devuelve 0 es porque es la primra vez que se agrega una nota
                {
                    NotaPorPeriodo oNotaPorPeriodo = new NotaPorPeriodo(devuelveNombrePeriodo(trimestre));
                    oNotaPorPeriodo.nota1 = valor;
                    oNotaPorPeriodo.periodo = 1;
                    db.NotaPorPeriodoes.Add(oNotaPorPeriodo);
                    db.SaveChanges();
                    Calificacion oCalificacion = new Calificacion();
                    oCalificacion.idProfesor = idProf;
                    oCalificacion.año = año;
                    oCalificacion.idAlumno = idAlumn;
                    oCalificacion.idMateria = idMat;
                    oCalificacion.fecha = dtpFechaCalificacion.Value.Date;
                    oCalificacion.idNotaPorPeriodo = oNotaPorPeriodo.idNotaPorPeriodo;
                    oCalificacion.notaCerrada = 0; //       Nota abierta = 0 / Nota cerrada = 1
                    db.Calificacions.Add(oCalificacion);
                    db.SaveChanges();
                    MessageBox.Show("La calificación se creo exitosamente!");
                }
                else //busca IdNotaPorPeriodo para agregar una nota a una calificacion existente
                {
                    int idNot = 0;
                    switch (trimestre)
                    {
                        case 2:
                            idNot = validar.devuelveIdNotaPeriodo(validar.calificacionAbierta(idProf, idMat, idAlumn, año));
                            var query2 = (from np in db.NotaPorPeriodoes
                                          where np.idNotaPorPeriodo == idNot
                                          select np).FirstOrDefault();
                            query2.nota2 = valor;
                            query2.periodo = trimestre;
                            break;
                        case 3:
                            idNot = validar.devuelveIdNotaPeriodo(validar.calificacionAbierta(idProf, idMat, idAlumn, año));
                            var query3 = (from np in db.NotaPorPeriodoes
                                          where np.idNotaPorPeriodo == idNot
                                          select np).FirstOrDefault();
                            decimal promedio = validar.calcularPromedioAnual(idNot, valor);
                            if (promedio == 0)
                                return;
                            else
                            {
                                query3.nota3 = valor;
                                query3.periodo = trimestre;
                                query3.promedioMateria = promedio;
                            }
                            break;
                        default:
                            idNot = validar.devuelveIdNotaPeriodo(validar.calificacionAbierta(idProf, idMat, idAlumn, año));
                            var query4 = (from np in db.NotaPorPeriodoes
                                          where np.idNotaPorPeriodo == idNot
                                          select np).FirstOrDefault();
                            query4.previa = valor;
                            query4.periodo = trimestre;
                            break;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Se agregó la nota satisfactoriamente!");
                }
                cargarCalificaciones();
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

        private void btnCerrarNota_Click(object sender, EventArgs e)
        {
            decimal? promAnual = null;
            decimal promedioTope = 7;
            decimal? notaprevia = null;

            try
            {
                if (validarCombos()) { return; }
                int idProf = int.Parse(cboProfesores.SelectedValue.ToString());
                int año = int.Parse(cboAños.SelectedValue.ToString());
                int idAlumn = int.Parse(cboAlumnos.SelectedValue.ToString());
                int idMat = int.Parse(cboMaterias.SelectedValue.ToString());
                int idCal = validar.calificacionAbierta(idProf, idMat, idAlumn, año);
                int idNot = validar.devuelveIdNotaPeriodo(idCal);

                if (validar.notasCargadas(idNot)) { return; }
                else //se han cargado todas las notas, puede calcular el promedio anual
                {
                    var res = (from np in db.NotaPorPeriodoes
                               where np.idNotaPorPeriodo == idNot
                               select np).FirstOrDefault();
                    promAnual = res?.promedioMateria ?? 0;
                    notaprevia = res?.previa ?? 0;

                    var query = (from c in db.Calificacions
                                 where c.idCalificacion == idCal
                                 select c).FirstOrDefault();

                    if (promAnual < promedioTope)// su promedio no llega al 7, debe rendir previa
                    {
                        if (notaprevia == 0)
                        {
                            MessageBox.Show("Su promedio no llega a 7. Ingrese nota previa", "Error!");
                            return;
                        }
                        else
                        {
                            query.promedioFinal = notaprevia;
                        }
                    }
                    else //aprobó, poner el promedio anual como Promedio Definitivo
                    {

                        query.promedioFinal = promAnual;
                    }
                    query.notaCerrada = 1;
                    db.SaveChanges();
                    MessageBox.Show("La nota ha sido cerrada con éxito");
                }
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

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCombos()) { return; }
                int trimestre = int.Parse(cboTrimestres.SelectedValue.ToString());
                int idProf = int.Parse(cboProfesores.SelectedValue.ToString());
                int año = int.Parse(cboAños.SelectedValue.ToString());
                int idAlumn = int.Parse(cboAlumnos.SelectedValue.ToString());
                int idMat = int.Parse(cboMaterias.SelectedValue.ToString());
                int idCal = validar.calificacionAbierta(idProf, idMat, idAlumn, año);
                int idNot = validar.devuelveIdNotaPeriodo(idCal);
                decimal? notaNueva = null;
                decimal? promedio = null;

                var query = (from np in db.NotaPorPeriodoes
                             where np.idNotaPorPeriodo == idNot
                             select np).FirstOrDefault();

                switch (trimestre)
                {
                    case 1:
                        notaNueva = query?.nota1 ?? 0;
                        if (notaNueva != 0)
                        {
                            query.nota1 = decimal.Parse(tbNota.Text);
                            db.SaveChanges();
                            MessageBox.Show("La nota ha sido modificada");
                        }
                        else
                            MessageBox.Show("No ha sido cargada la nota", "Error!");
                        break;
                    case 2:
                        notaNueva = query?.nota2 ?? 0;
                        if (notaNueva != 0)
                        {
                            query.nota2 = decimal.Parse(tbNota.Text);
                            db.SaveChanges();
                            MessageBox.Show("La nota ha sido modificada");
                        }
                        else
                            MessageBox.Show("No ha sido cargada la nota", "Error!");
                        break;
                    case 3:
                        notaNueva = query?.nota3 ?? 0;
                        if (notaNueva != 0)
                        {
                            query.nota3 = decimal.Parse(tbNota.Text);
                            db.SaveChanges();
                            MessageBox.Show("La nota ha sido modificada");
                        }
                        else
                            MessageBox.Show("No ha sido cargada la nota", "Error!");
                        break;
                    case 4:
                        notaNueva = query?.previa ?? 0;
                        if (notaNueva != 0)
                        {
                            query.previa = decimal.Parse(tbNota.Text);
                            db.SaveChanges();
                            MessageBox.Show("La nota ha sido modificada");
                        }
                        else
                            MessageBox.Show("No ha sido cargada la nota", "Error!");
                        break;
                }

                promedio = query?.promedioMateria ?? 0;
                if (promedio != 0)
                {
                    promedio = (query.nota1 + query.nota2 + query.nota3) / 3;
                    query.promedioMateria = promedio;
                    db.SaveChanges();
                }
                cargarCalificaciones();
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

        #endregion

        private void tabNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabNotas.SelectedTab == tabNotas.TabPages["tpGestionNotas"])
            {
                cargarCalificaciones();
                setearGrillaCalif();
                cargaCombosPantalla();
            }
            if (tabNotas.SelectedTab == tabNotas.TabPages["tpBusqNotas"])
            {
                dtpFechaCalifBusq.Format = DateTimePickerFormat.Custom;
                dtpFechaCalifBusq.CustomFormat = "yyyy";
                dtpFechaCalifBusq.ShowUpDown = true;
                cargaComboAñoBusq();
                cargaComboMateriasBusq();
            }
        }

        #region TAB BUSQUEDA NOTAS
        private void rbBusqCalifxDni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBusqCalifxDni.Checked)
            {
                tbDniBusqNotas.Enabled = true;
                cboMateriaBusq.Enabled = false;
                cboAñoBusqNota.Enabled = false;
            }
            else
            {
                tbDniBusqNotas.Enabled = false;
                cboMateriaBusq.Enabled = true;
                cboAñoBusqNota.Enabled = true;
            }
        }

        public void cargaComboMateriasBusq()
        {
            var result = (from m in db.Materias 
                          where m.activo == 1
                          select new
                          {
                              nombreMateria = m.nombre,
                              idMateria = m.idMateria
                          }).ToList();

            //Asignar la propiedad DataSource
            cboMateriaBusq.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboMateriaBusq.DisplayMember = "nombreMateria";

            //Indicar qué valor tendrá cada ítem
            cboMateriaBusq.ValueMember = "idMateria";
        }
        public void cargaComboAñoBusq()
        {
            var result = (from alm in db.Alumno_Materia
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
                MessageBox.Show("No hay materias creadas");
            }

            //Asignar la propiedad DataSource
            cboAñoBusqNota.DataSource = result;

            //Indicar qué propiedad se verá en la lista
            cboAñoBusqNota.DisplayMember = "añoMateria";

            //Indicar qué valor tendrá cada ítem
            cboAñoBusqNota.ValueMember = "añoMateria";
        }

        public void setearGrillaCalifBusq()
        {
            dgvCalifBusqueda.Columns[0].HeaderText = "Alumno";
            dgvCalifBusqueda.Columns[0].Width = 150;
            dgvCalifBusqueda.Columns[1].HeaderText = "Materia";
            dgvCalifBusqueda.Columns[1].Width = 120;
            dgvCalifBusqueda.Columns[2].HeaderText = "Profesor";
            dgvCalifBusqueda.Columns[2].Width = 150;
            dgvCalifBusqueda.Columns[3].HeaderText = "Año/Grado";
            dgvCalifBusqueda.Columns[3].Width = 65;
            dgvCalifBusqueda.Columns[4].HeaderText = "1er Trim";
            dgvCalifBusqueda.Columns[4].Width = 70;
            dgvCalifBusqueda.Columns[4].DefaultCellStyle.Format = "n2";
            dgvCalifBusqueda.Columns[5].HeaderText = "2do Trim";
            dgvCalifBusqueda.Columns[5].Width = 75;
            dgvCalifBusqueda.Columns[5].DefaultCellStyle.Format = "n2";
            dgvCalifBusqueda.Columns[6].HeaderText = "3er Trim";
            dgvCalifBusqueda.Columns[6].Width = 70;
            dgvCalifBusqueda.Columns[6].DefaultCellStyle.Format = "n2";
            dgvCalifBusqueda.Columns[7].HeaderText = "Dic/Marzo";
            dgvCalifBusqueda.Columns[7].Width = 70;
            dgvCalifBusqueda.Columns[7].DefaultCellStyle.Format = "n2";
            dgvCalifBusqueda.Columns[8].HeaderText = "Promedio Materia";
            dgvCalifBusqueda.Columns[8].Width = 90;
            dgvCalifBusqueda.Columns[8].DefaultCellStyle.Format = "n3";
        }

        private void btnBusqNotas_Click(object sender, EventArgs e)
        {
            int añoLectivo = dtpFechaCalifBusq.Value.Year;
            if (rbBusqCalifxDni.Checked)
            {
                var calif = (from c in db.Calificacions
                             join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                             join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                             join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                             join m in db.Materias on c.idMateria equals m.idMateria
                             join pe in db.Personas on al.idPersona equals pe.idPersona
                             join p in db.Personas on pr.idPersona equals p.idPersona
                             where p.dni.StartsWith(tbDniBusqNotas.Text) && c.fecha.Year == añoLectivo
                             select new
                             {
                                 Alumno = pe.apellido + ", " + pe.nombre,
                                 nombreMateria = m.nombre,
                                 Profe = p.apellido + ", " + p.nombre,
                                 añoCalificacion = c.año,
                                 nota1 = np.nota1,
                                 nota2 = np.nota2,
                                 nota3 = np.nota3,
                                 previa = np.previa,
                                 promedio = np.promedioMateria
                             }).OrderBy(x => x.añoCalificacion)
                             .ToList();

                if (calif.Count() == 0)
                {
                    MessageBox.Show("No se ha encontrado calificación", "Error!");
                    dgvCalifBusqueda.DataSource = null;
                    return;
                }

                dgvCalifBusqueda.DataSource = calif;
                setearGrillaCalifBusq();
            }
            else
            {
                int materiaBusq = int.Parse(cboMateriaBusq.SelectedValue.ToString());
                int cursoBusq = int.Parse(cboAñoBusqNota.SelectedValue.ToString());
                var calif = (from c in db.Calificacions
                             join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                             join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                             join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                             join m in db.Materias on c.idMateria equals m.idMateria
                             join pe in db.Personas on al.idPersona equals pe.idPersona
                             join p in db.Personas on pr.idPersona equals p.idPersona
                             where c.fecha.Year == añoLectivo &&
                                   m.idMateria == materiaBusq &&
                                   c.año == cursoBusq
                             select new
                             {
                                 Alumno = pe.apellido + ", " + pe.nombre,
                                 nombreMateria = m.nombre,
                                 Profe = p.apellido + ", " + p.nombre,
                                 añoCalificacion = c.año,
                                 nota1 = np.nota1,
                                 nota2 = np.nota2,
                                 nota3 = np.nota3,
                                 previa = np.previa,
                                 promedio = np.promedioMateria
                             }).OrderBy(x => x.Alumno)
                             .ToList();

                if (calif.Count() == 0)
                {
                    MessageBox.Show("No se ha encontrado calificación", "Error!");
                    dgvCalifBusqueda.DataSource = null;
                    return;
                }

                dgvCalifBusqueda.DataSource = calif;
                setearGrillaCalifBusq();
            }
        }


        #endregion

        
    }
}
