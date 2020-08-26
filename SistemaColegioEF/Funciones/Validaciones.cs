using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaColegioEF.Modelo;
using System.Data.Entity.Validation;
using SistemaColegioEF.Controls;
using System.Windows.Forms;

namespace SistemaColegioEF.Funciones
{
    class Validaciones
    {
        EscuelaDB db = new EscuelaDB();

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
            var query = db.Alumno_Materia.Where(pm =>  pm.año == año &&
                                                       pm.activo == 1);
            if (año == 0)
            {
                MessageBox.Show("Por favor, ingrese un año", "Error!");
                resp = true;
            }
            return resp;
        }

        public bool validarAlumnoAño(int año)
        {
            bool resp = false;
            var query = db.Alumno_Materia.Where(pm => pm.activo == 1);
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
    }
}
