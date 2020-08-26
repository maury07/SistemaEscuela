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

namespace SistemaColegioEF.Formularios
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
            suscribeEventos();
            
        }
        #region VARIABLES GLOBALES

        EscuelaDB db = new EscuelaDB();
        Validaciones validar = new Validaciones();
        ucAbm abm = new ucAbm();
        int id = 0;
        bool edit;
        int idMateriaProf, idProf, idMateriaAlumno, idAlumno, añoMateriaProf, añoMateriaAlumn, idRelMateriaProf, idRelMateriaAl;

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            cargarMaterias();
            
            tbNombreMateria.Clear();
            this.dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.Columns[0].Width = 1;
            dgvMaterias.Columns[1].HeaderText = "Nombre de Materia";
        }

        #endregion

        #region SECCION TAB GESTION MATERIAS

        private void suscribeEventos()
        {
            abm.OnClickAgregar += habilitarTextBox;
            abm.OnClickAgregar += limpiar;
            abm.OnClickEditar += habilitarTextBox;
            abm.OnClickEliminar += eliminar;
            abm.OnClickEliminar += limpiar;
            abm.OnClickAceptar += confirmar;
            abm.OnClickCancelar += deshabilitarTextBox;
            abm.deshabilitarGrilla += deshabilitGrilla;
            abm.habilitarGrilla += habilitGrilla;
            abm.OnClickCancelar += limpiar;
            abm.habilitarCampos += habilitarTextBox;
            abm.deshabilitarCampos += deshabilitarTextBox;
            abm.deshabilitarEdit += deshabilitEdit;
            pnlAcciones.Controls.Add(abm);
        }

        #region ABM GESTION MATERIAS
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
                cargarMaterias();
                limpiar(sender, e);
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
            Materia oMateria = new Materia();
            oMateria.nombre = tbNombreMateria.Text.ToString();
            oMateria.activo = 1;
            db.Materias.Add(oMateria);
            db.SaveChanges();
            MessageBox.Show("Se agregó el registro con éxito!");
        }

        public void editar()
        {

            var materia = (from a in db.Materias
                       where a.idMateria == id
                       select a).FirstOrDefault();

            materia.nombre = tbNombreMateria.Text;

            db.SaveChanges();
            MessageBox.Show("Se modificó el registro con éxito!");
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
                        //Materia oMateria = (from a in db.Materias
                        //                      where a.idMateria == id
                        //                      select a).FirstOrDefault();
                        //db.Materias.Remove(oMateria);

                        var materia = (from a in db.Materias
                                       where a.idMateria == id
                                       select a).FirstOrDefault();
                        materia.activo = 0; //Persona inactiva (Baja lógica)
                        db.SaveChanges();
                        MessageBox.Show("Se eliminó el registro con éxito!");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                cargarMaterias();
                limpiar(sender, e);
            }
            else
                abm.Valid = false;
        }

        #endregion

        public void limpiar(object sender, EventArgs e)
        {
            id = 0;
            tbNombreMateria.Clear();
            tbNombreMateria.Enabled = true;
        }

        public void habilitarTextBox(object sender, EventArgs e)
        {
            tbNombreMateria.Enabled = true;
            tbNombreMateria.Focus();
        }

        public void deshabilitarTextBox(object sender, EventArgs e)
        {
            tbNombreMateria.Enabled = false;
        }

        public void habilitGrilla(object sender, EventArgs e)
        {
            dgvMaterias.Enabled = true;
        }

        public void deshabilitGrilla(object sender, EventArgs e)
        {
            dgvMaterias.Enabled = false;
        }

        public void cargarCampos(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Error!");
                return;
            }
            edit = true;
            abm.Valid = validarCampos();
        }

        public void habilitEdit()
        {
            edit = true;
        }

        public void deshabilitEdit()
        {
            edit = false;
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(tbNombreMateria.Text))
                return false;
            return true;
        }

        public void cargarMaterias()
        {
            var result = from m in db.Materias
                         where m.activo == 1
                         select new
                         {
                             m.idMateria,
                             m.nombre
                         };

                             dgvMaterias.DataSource = result.ToList();
            dgvMaterias.Columns["idMateria"].Visible = false;
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvMaterias.Rows[dgvMaterias.CurrentRow.Index].Cells[0].Value.ToString());
            var mat = (from a in db.Materias
                           where a.idMateria == id
                           select a).FirstOrDefault();
            tbNombreMateria.Text = mat.nombre;
            dgvMaterias.Rows[dgvMaterias.CurrentRow.Index].Selected = true;
            cargarCampos(sender, e);
        }

        #endregion // Seccion Materias

        #region SECCION TAB PROFESORES

        private void setearGrillaProfes()
        {
            dgvProfMateria.Columns[0].HeaderText = "Profesor";
            dgvProfMateria.Columns[0].Width = 170;
            dgvProfMateria.Columns[1].HeaderText = "Materia";
            dgvProfMateria.Columns[1].Width = 150;
            dgvProfMateria.Columns[2].HeaderText = "Año";
            dgvProfMateria.Columns[2].Width = 50;
        }

        public void cargarRelProfMateria()
        {
            var result = (from mp in db.Profesor_Materia
                          join pr in db.Profesors on mp.idProfesor equals pr.idProfesor
                          join p in db.Personas on pr.idPersona equals p.idPersona
                          join m in db.Materias on mp.idMateria equals m.idMateria
                          where mp.activo == 1
                          select new
                          {
                              nombreCompletoProf = p.apellido + ", " + p.nombre,
                              nombreMateria = m.nombre,
                              añoMateria = mp.año
                          });
            dgvProfMateria.DataSource = result.ToList();
        }
        public void cargaComboMaterias()
        {
            var resultMaterias = from m in db.Materias
                                 where m.activo == 1
                                 select m;

            List < Materia > listMaterias = new List<Materia>();
            listMaterias = resultMaterias.ToList();
            //Vaciar comboBox
            cboMateria_Prof.DataSource = null;

            //Asignar la propiedad DataSource
            cboMateria_Prof.DataSource = listMaterias;

            //Indicar qué propiedad se verá en la lista
            cboMateria_Prof.DisplayMember = "nombre";

            //Indicar qué valor tendrá cada ítem
            cboMateria_Prof.ValueMember = "idMateria";
        }

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

            //Asignar la propiedad DataSource
            cboProfesores.DataSource = resultProfs;

            //Indicar qué propiedad se verá en la lista
            cboProfesores.DisplayMember = "nombreCompletoProf";

            //Indicar qué valor tendrá cada ítem
            cboProfesores.ValueMember = "idProfesor";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            idMateriaProf = int.Parse(cboMateria_Prof.SelectedValue.ToString());
            idProf = int.Parse(cboProfesores.SelectedValue.ToString());
            añoMateriaProf = int.Parse(nudAñoProfMateria.Value.ToString());
            try
            {
                if (validar.validarAñoInscripcion(añoMateriaProf)) { return; }
                if (!validar.validarProfMateria(idMateriaProf, añoMateriaProf)) { return; }

                Profesor_Materia oProfMateria = new Profesor_Materia();
                oProfMateria.idMateria = int.Parse(cboMateria_Prof.SelectedValue.ToString());
                oProfMateria.idProfesor = int.Parse(cboProfesores.SelectedValue.ToString()); ;
                oProfMateria.año = int.Parse(nudAñoProfMateria.Value.ToString());
                oProfMateria.activo = 1;
                db.Profesor_Materia.Add(oProfMateria);
                db.SaveChanges();
                MessageBox.Show("Inscripción exitosa!");
            }
            catch (Exception ex)
            { throw ex; }
            cargarRelProfMateria();
        }
        private void btnDesinscribirProf_Click(object sender, EventArgs e)
        {
            idMateriaProf = int.Parse(cboMateria_Prof.SelectedValue.ToString());
            idProf = int.Parse(cboProfesores.SelectedValue.ToString());
            añoMateriaProf = int.Parse(nudAñoProfMateria.Value.ToString());
            try
            {
                if (validar.validarAñoInscripcion(añoMateriaProf)) { return; }
                idRelMateriaProf = validar.validarBajaProfMateria(idProf, idMateriaProf, añoMateriaProf);
                if(idRelMateriaProf == 0)
                { return; }

                var materiaProf = (from am in db.Profesor_Materia
                               where am.idProfMateria == idRelMateriaProf
                               select am).FirstOrDefault();
                materiaProf.activo = 0; //Persona inactiva (Baja lógica)
                db.SaveChanges();
                MessageBox.Show("Se dió de baja la inscripción!");
                idRelMateriaProf = 0;
            }
            catch (Exception ex)
            { throw ex; }
            cargarRelProfMateria();
        }

        #endregion

        #region SECCION TAB ALUMNOS

        private void setearGrillaAlumnos()
        {
            dgvAlumnoMateria.Columns[0].HeaderText = "Alumno";
            dgvAlumnoMateria.Columns[0].Width = 270;
            dgvAlumnoMateria.Columns[1].HeaderText = "Año";
            dgvAlumnoMateria.Columns[1].Width = 100;
        }

        public void cargarRelAlumnoMateria()
        {
            var result = (from am in db.Alumno_Materia
                          join al in db.Alumnoes on am.idAlumno equals al.idAlumno
                          join p in db.Personas on al.idPersona equals p.idPersona
                          where am.activo == 1
                          select new
                          {
                              nombreCompletoProf = p.apellido + ", " + p.nombre,
                              añoMateria = am.año
                          }).Distinct();
            dgvAlumnoMateria.DataSource = result.ToList();
        }


        public void cargaComboAlumnos()
        {
            var resultProfs = (from p in db.Personas
                               join al in db.Alumnoes on p.idPersona equals al.idPersona
                               where p.activo == 1
                               select new
                               {
                                   nombreCompletoProf = p.apellido + ", " + p.nombre,
                                   idAlumno = al.idAlumno
                               }).ToList();

            //Asignar la propiedad DataSource
            cboAlumnos.DataSource = resultProfs;

            //Indicar qué propiedad se verá en la lista
            cboAlumnos.DisplayMember = "nombreCompletoProf";

            //Indicar qué valor tendrá cada ítem
            cboAlumnos.ValueMember = "idAlumno";
        }

        private void btnInscrAlumn_Click(object sender, EventArgs e)
        {
            idAlumno = int.Parse(cboAlumnos.SelectedValue.ToString());
            añoMateriaAlumn = int.Parse(nudAñoAlumnoMateria.Value.ToString());
            var resultMaterias = from m in db.Materias
                                 where m.activo == 1
                                 select m.idMateria;
            try
            {
                if(!validar.existeMaterias()) { return; }
                if (validar.validarAlumnoAño(añoMateriaAlumn)) { return; }

                Alumno_Materia oAlumnoMateria = new Alumno_Materia();
                foreach (var materia in resultMaterias)
                {
                    oAlumnoMateria.idAlumno = int.Parse(cboAlumnos.SelectedValue.ToString()); ;
                    oAlumnoMateria.activo = 1;
                    oAlumnoMateria.idMateria = materia;
                    oAlumnoMateria.año = añoMateriaAlumn;
                    db.Alumno_Materia.Add(oAlumnoMateria);
                    db.SaveChanges();
                }
                
                MessageBox.Show("Inscripción exitosa!");
            }
            catch (Exception ex)
            { throw ex; }
            cargarRelAlumnoMateria();
        }

        private void btnDesinscrAlum_Click(object sender, EventArgs e)
        {
            idAlumno = int.Parse(cboAlumnos.SelectedValue.ToString());
            añoMateriaAlumn = int.Parse(nudAñoAlumnoMateria.Value.ToString());
            var resultMaterias = from m in db.Materias
                                 where m.activo == 1
                                 select m.idMateria;
            try
            {
                if (validar.validarAñoInscripcion(añoMateriaAlumn)) { return; }
                if (validar.validarBajaAlumnoAño(idAlumno, añoMateriaAlumn)) { return; }

                foreach (var materia in resultMaterias)
                {
                    db.Alumno_Materia
                        .Where(am => am.idAlumno == idAlumno &&  am.año == añoMateriaAlumn && am.activo == 1 && am.idMateria == materia)
                        .ToList()
                        .ForEach(a => a.activo = 0);
                    db.SaveChanges();
                }
                MessageBox.Show("Se dió de baja la inscripción!");
                idRelMateriaAl = 0;
            }
            catch (Exception ex)
            { throw ex; }
            cargarRelAlumnoMateria();
        }

        #endregion

        private void tabMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMaterias.SelectedTab == tabMaterias.TabPages["tpGestionMaterias"])
            {
                cargarMaterias();
            }
            if (tabMaterias.SelectedTab == tabMaterias.TabPages["tpInscProf"])
            {
                cargarRelProfMateria();
                setearGrillaProfes();
                
                cargaComboMaterias();
                cargaComboProfes();
                
                //CARGA RELACION MATERIA PROFESOR
            }
            if (tabMaterias.SelectedTab == tabMaterias.TabPages["tpInscAlumn"])
            {
                cargaComboAlumnos();
                cargarRelAlumnoMateria();
                if (validar.existeAlumnosInscriptos())
                { setearGrillaAlumnos(); }
            }

        }

       
    }
}