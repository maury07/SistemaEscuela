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
    
    public partial class Alumno_Materia
    {
        public int idAlumnoMateria { get; set; }
        public Nullable<int> idAlumno { get; set; }
        public Nullable<int> idMateria { get; set; }
        public Nullable<int> activo { get; set; }
        public Nullable<int> año { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
