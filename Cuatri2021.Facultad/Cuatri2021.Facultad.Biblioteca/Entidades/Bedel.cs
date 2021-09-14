using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Bedel : Empleado
    {
        //ATRIBUTOS PRIVADOS
        protected string _apodo;



        //PROPIEDADES PUBLICAS
        public string Apodo
        {
            get { return _apodo; }
            set { _apodo = value; }
        }



        //CONSTRUCTOR




        //METODOS
        protected override string GetNombreCompleto()
        {
            string nombreCompleto = this._nombre + " " + this._apellido;

            return nombreCompleto;
        }







    }
}
