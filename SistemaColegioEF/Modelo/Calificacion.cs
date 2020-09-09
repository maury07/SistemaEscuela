//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaColegioEF.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificacion
    {
        public int idCalificacion { get; set; }
        public System.DateTime fecha { get; set; }
        public int idProfesor { get; set; }
        public int idAlumno { get; set; }
        public int idMateria { get; set; }
        public Nullable<int> idNotaPorPeriodo { get; set; }
        public Nullable<decimal> promedioFinal { get; set; }
        public Nullable<int> año { get; set; }
        public Nullable<int> notaCerrada { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual NotaPorPeriodo NotaPorPeriodo { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
