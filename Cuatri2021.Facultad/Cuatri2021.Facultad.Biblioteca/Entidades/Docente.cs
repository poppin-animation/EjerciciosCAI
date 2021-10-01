using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Docente : Empleado
    {
        //ATRIBUTOS PRIVADOS




        //PROPIEDADES PUBLICAS




        //CONSTRUCTOR
        public Docente(int legajo, string nombre, string apellido) : base(legajo, nombre, apellido)
        {
       

        }



        //METODOS

        protected override string GetNombreCompleto()
        {
            string nombreCompleto = $"Docente {_nombre}";

            return nombreCompleto;
        }






    }
}
