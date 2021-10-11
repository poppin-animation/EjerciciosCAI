using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Excepciones
{
    public class AsistenciaExistenteEseDiaException : Exception
    {
        public AsistenciaExistenteEseDiaException () : base ("La fecha ingresada ya existe en la lista de fechas controladas. No se pudo agregar la lista de Asistencia.")
        {
        }

    }
}
