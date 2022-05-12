using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioHerencia
{
    public class Alumnos : Personas
    {
        public int noCarne { get; set; }
        public int notas { get; set; }
    }
}