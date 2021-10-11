using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Excepciones
{
    public class AsistenciaInconsistenteException : Exception
    {
        public AsistenciaInconsistenteException() : base("la lista de asistencia ingresada no tiene una cantidad igual a la lista de alumnos regulares registrados.")
        {
        }
    }
}
