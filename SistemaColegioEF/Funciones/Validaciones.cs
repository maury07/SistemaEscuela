using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaColegioEF.Modelo;
using System.Data.Entity.Validation;
using SistemaColegioEF.Controls;
using System.Windows.Forms;
using SistemaColegioEF.Funciones;

namespace SistemaColegioEF.Funciones
{
    class Validaciones
    {
        EscuelaDB db = new EscuelaDB();

        #region VALIDACION DE MATERIAS
        public bool validarProfMateria(int materia, int año)
        {
            bool resp = true;
            var query = db.Profesor_Materia.Where(pm => pm.idMateria == materia &&
                                                        pm.año == año &&
                                                        pm.activo == 1);
            if (query.Count() > 0)
            {
                MessageBox.Show("Existe un profesor dictando la materia en este año!", "Error!");
                resp = false;
            }

            return resp;
        }

        public int validarBajaProfMateria(int profesor, int materia, int año)
        {
            int id;

            var query = db.Profesor_Materia.Where(pm => pm.idProfesor == profesor &&
                                                        pm.idMateria == materia &&
                                                        pm.año == año &&
                                                        pm.activo == 1)
                                           .Select(pm => pm.idProfMateria).FirstOrDefault();
            if (query == 0)
            {
                MessageBox.Show("No existe profesor dictando la materia en este año!", "Error!");
                return id = 0;
            }
            else
            { id = int.Parse(query.ToString()); }

            return id;
        }

        public bool validarBajaAlumnoAño(int alumno, int año)
        {
            bool resp = false;

            var query = db.Alumno_Materia.Where(pm => pm.idAlumno == alumno &&
                                                        pm.año == año &&
                                                        pm.activo == 1)
                                           .Select(pm => pm.idAlumnoMateria).FirstOrDefault();
            if (query == 0)
            {
                MessageBox.Show("No existe alumno cursando en este año!", "Error!");
                resp = true;
            }

            return resp;
        }

        public bool validarAñoInscripcion(int año)
        {
            bool resp = false;
            var query = db.Alumno_Materia.Where(pm => pm.año == año &&
                                                       pm.activo == 1);
            if (año == 0)
            {
                MessageBox.Show("Por favor, ingrese un año", "Error!");
                resp = true;
            }
            return resp;
        }

        public bool validarAlumnoAño(int id, int año)
        {
            bool resp = false;
            var query = db.Alumno_Materia.Where(pm => pm.idAlumno == id &&
                                                      pm.activo == 1);
            if (año == 0)
            {
                MessageBox.Show("Por favor, ingrese un año", "Error!");
                return true;
            }
            if (query.Count() > 0)
            {
                MessageBox.Show("El alumno ya está cursando un año", "Error!");
                return true;
            }

            return resp;
        }

        public bool existeAlumnosInscriptos()
        {
            var result = (from am in db.Alumno_Materia
                          join al in db.Alumnoes on am.idAlumno equals al.idAlumno
                          join p in db.Personas on al.idPersona equals p.idPersona
                          where am.activo == 1
                          select new
                          {
                              nombreCompletoProf = p.apellido + ", " + p.nombre,
                              idAlumno = al.idAlumno
                          }).ToList();
            if (result.Count() == 0)
            {
                MessageBox.Show("No existen inscripciones de alumnos", "Error!");
                return false;
            }
            else
                return true;
        }

        public bool existeMaterias()
        {
            var resultMaterias = from m in db.Materias
                                 where m.activo == 1
                                 select m.idMateria;
            if (resultMaterias.Count() == 0)
            {
                MessageBox.Show("No existen materias en el sistema", "Error!");
                return false;
            }
            else
            { return true; }
        }

        #endregion

        #region VALIDACIONES DE CALIFICACIONES

        public bool validarNotaTrimestre(int idProfe, int idMateria, int idAlumno, int trimestre, decimal nota, int año)
        {
            bool resp = false;
            if (trimestre == 1)
            {
                var resultNota = (from c in db.Calificacions
                                  join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                                  join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                                  join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                                  join m in db.Materias on c.idMateria equals m.idMateria
                                  where c.idProfesor == idProfe && c.idMateria == idMateria && c.idAlumno == idAlumno && c.año == año
                                  select new
                                  {
                                      nota1 = np.nota1
                                  }).ToList();

                if (resultNota.Any())
                {
                    foreach (var x in resultNota)
                    {
                        if (x.nota1 != null)
                        {
                            MessageBox.Show("Ya se ha cargado la nota del Primer Trimestre");
                            resp = true;
                            break;
                        }
                    }
                }
            }
            else if (trimestre == 2)
            {
                var resultNota = (from c in db.Calificacions
                                  join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                                  join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                                  join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                                  join m in db.Materias on c.idMateria equals m.idMateria
                                  where c.idProfesor == idProfe && c.idMateria == idMateria && c.idAlumno == idAlumno && c.año == año
                                  select new
                                  {
                                      nota2 = np.nota2
                                  }).ToList();
                if (resultNota.Any())
                {
                    foreach (var x in resultNota)
                    {
                        if (x.nota2 != null)
                        {
                            MessageBox.Show("Ya se ha cargado la nota del Segundo Trimestre");
                            resp = true;
                            break;
                        }
                    }
                }
            }
            else if (trimestre == 3)
            {
                var resultNota = (from c in db.Calificacions
                                  join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                                  join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                                  join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                                  join m in db.Materias on c.idMateria equals m.idMateria
                                  where c.idProfesor == idProfe && c.idMateria == idMateria && c.idAlumno == idAlumno && c.año == año
                                  select new
                                  {
                                      nota3 = np.nota3
                                  }).ToList();
                if (resultNota.Any())
                {
                    foreach (var x in resultNota)
                    {
                        if (x.nota3 != null)
                        {
                            MessageBox.Show("Ya se ha cargado la nota del Tercer Trimestre");
                            resp = true;
                            break;
                        }
                    }
                }
            }
            else if (trimestre == 4)
            {
                var resultNota = (from c in db.Calificacions
                                  join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                                  join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                                  join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                                  join m in db.Materias on c.idMateria equals m.idMateria
                                  where c.idProfesor == idProfe && c.idMateria == idMateria && c.idAlumno == idAlumno && c.año == año
                                  select new
                                  {
                                      idCalif = c.idCalificacion,
                                      notaprevia = np.previa
                                  }).ToList();
                if (resultNota.Any())
                {
                    foreach (var x in resultNota)
                    {
                        if (x.notaprevia != null)
                        {
                            sobreescribirNotaPrevia(x.idCalif, idProfe, idMateria, idAlumno, trimestre, nota, año);
                            resp = false;
                        }
                    }
                }
            }

            return resp;
        }

        private void sobreescribirNotaPrevia(int idCalif, int idProfe, int idMateria, int idAlumno, int trimestre, decimal notaPrevia, int año)
        {
            DialogResult dgPregunta = MessageBox.Show("Ya existe una nota previa cargada ¿Desea sobreescribir la nota?", "¡Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dgPregunta == DialogResult.Yes)
            {
                try
                {  //consultar por idCalificacion y asi llegar a la NotaPorPeriodo, porque no se puede filtrar por la idNotaPorPeriodo si todavia no está creada
                    var califNota = (from c in db.Calificacions
                                     join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                                     join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                                     join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                                     join m in db.Materias on c.idMateria equals m.idMateria
                                     where c.idProfesor == idProfe && c.idMateria == idMateria && c.idAlumno == idAlumno && c.idMateria == idMateria && c.año == año
                                     select new
                                     {
                                         idNotaPorPeriodo = np.idNotaPorPeriodo
                                     }).FirstOrDefault();

                    var idNota = (from npp in db.NotaPorPeriodoes
                                  where npp.idNotaPorPeriodo == califNota.idNotaPorPeriodo
                                  select npp).FirstOrDefault();
                    idNota.previa = notaPrevia;
                    db.SaveChanges();
                    MessageBox.Show("Se sobreescribió la nota!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int calificacionAbierta(int idProfe, int idMateria, int idAlumno, int año)
        {
            int idCalif = 0;
            var resultNota = (from c in db.Calificacions
                              join pr in db.Profesors on c.idProfesor equals pr.idProfesor
                              join al in db.Alumnoes on c.idAlumno equals al.idAlumno
                              join np in db.NotaPorPeriodoes on c.idNotaPorPeriodo equals np.idNotaPorPeriodo
                              join m in db.Materias on c.idMateria equals m.idMateria
                              where c.idProfesor == idProfe && c.idMateria == idMateria && c.idAlumno == idAlumno && c.idMateria == idMateria && c.año == año
                              select new
                              {
                                  idCalif = c.idCalificacion,
                                  nota = np.nota1
                              }).ToList();
            if (resultNota.Count > 0)
            {
                foreach (var x in resultNota)
                    idCalif = x.idCalif;
            }
            return idCalif;
        }

        public int devuelveIdNotaPeriodo(int calificacion)
        {
            var notaPeriodo = (from c in db.Calificacions
                               where c.idCalificacion == calificacion
                               select c.idNotaPorPeriodo).FirstOrDefault();
            return notaPeriodo.GetValueOrDefault(); //GetValueOrDefault
        }

        public decimal calcularPromedioAnual(int idNotPorPeriodo, decimal nota3)
        {
            decimal promedio = 0;
            decimal? nota1 = null;
            decimal? nota2 = null;
            var res = (from n in db.NotaPorPeriodoes
                       where n.idNotaPorPeriodo == idNotPorPeriodo
                       select new
                       {
                           n.nota1,
                           n.nota2,
                           n.nota3
                       }).FirstOrDefault();
            nota1 = res?.nota1 ?? 0;
            nota2 = res?.nota2 ?? 0;

            if ((nota1 == 0) || (nota2 == 0))
            {
                MessageBox.Show("Debe completar las notas anteriores para poder ingresar la nota del 3er trimestre");
                return promedio;
            }
            else
            {
                promedio = (res.nota1.Value + res.nota2.Value + nota3) / 3;
            }


            return promedio;
        }

        public bool notasCargadas(int idNotaPorPeriodo)
        {
            bool resp = false;
            decimal? nota1 = null;
            decimal? nota2 = null;
            decimal? nota3 = null;
            var res = (from n in db.NotaPorPeriodoes
                       where n.idNotaPorPeriodo == idNotaPorPeriodo
                       select new
                       {
                           n.nota1,
                           n.nota2,
                           n.nota3
                       }).FirstOrDefault();
            nota1 = res?.nota1 ?? 0;
            nota2 = res?.nota2 ?? 0;
            nota3 = res?.nota3 ?? 0;

            if ((nota1 == 0) || (nota2 == 0) || (nota3 == 0))
            {
                MessageBox.Show("No se han cargado todas las notas");
                resp = true;
            }
            return resp;
        }

        #endregion

        #region ASISTENCIAS DE ALUMNO

        public bool validarExisteAsistAlumno(int idAlumn, DateTime fecha)
        {
            int? id = null;
            bool resp = false;
            var res = (from asi in db.AlumnoAsistencias
                       where asi.idAlumno == idAlumn && asi.fecha == fecha
                       select asi).FirstOrDefault();
            id = res?.idAlumnoAsistencia ?? 0;
            if (id != 0)
            {
                MessageBox.Show("Ya existe una asistencia cargada para ese alumno en esa fecha");
                resp = true;
            }
            return resp;
        }
        #endregion

        #region ASISTENCIAS DE PROFES

        public bool validarExisteAsistProfe(int idProf, DateTime fecha)
        {
            int? id = null;
            bool resp = false;
            var res = (from pra in db.ProfAsistencias
                       where pra.idProfesor == idProf && pra.fecha == fecha
                       select pra).FirstOrDefault();
            id = res?.idProfAsistencia ?? 0;
            if (id != 0)
            {
                MessageBox.Show("Ya existe una asistencia cargada para ese profesor en esa fecha");
                resp = true;
            }
            return resp;
        }

        #endregion
    }
}
