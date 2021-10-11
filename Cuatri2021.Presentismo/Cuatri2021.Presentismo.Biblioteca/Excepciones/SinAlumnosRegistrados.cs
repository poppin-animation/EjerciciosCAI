using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Excepciones
{
    public class SinAlumnosRegistradosException : Exception
    {
        public SinAlumnosRegistradosException() : base("No se encuentran alumnos registrados para esta fecha")
        {
        }
    }
}
