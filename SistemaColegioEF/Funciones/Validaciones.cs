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
        private string error;
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

        public bool validarAñoInscripcion(int año)
        {
            bool resp = false;
            if(año == 0)
            {
                MessageBox.Show("Por favor, ingrese un año", "Error!");
                resp = true;
            }
            return resp;
        }
    }
}
