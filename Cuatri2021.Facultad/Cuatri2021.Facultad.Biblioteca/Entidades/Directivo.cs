using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Directivo : Empleado
    {
        //ATRIBUTOS PRIVADOS




        //PROPIEDADES PUBLICAS




        //CONSTRUCTOR




        //METODOS

        protected override string GetNombreCompleto()
        {
            string nombreCompleto = this._nombre + " " + this._apellido;

            return nombreCompleto;
        }






    }
}
