using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    public abstract class Persona
    {
        //ATRIBUTOS PRIVADOS
        private string _apellido;
        private string _nombre;
        private DateTime _fechaNac;
       



        //PROPIEDADES PUBLICAS
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public int Edad ////PIDE QUE DEVOLVAMOS UN INT, PERO TENEMOS UN DATETIME. 
        {
            get 
            {
                int edad;
                edad = (DateTime.Today - this._fechaNac).Days / 365;
                //(la fecha de hoy, menos la fecha de nacimiento) en dias.... dividido 365 para calcular años.
                return edad;
            }
         
        }

        //CONSTRUCTOR




        //METODOS
        public abstract string GetCredencial();

        protected string GetNombreCompleto()
        {
            string nombreCompleto = this._nombre + " " + this._apellido;

            return nombreCompleto;
        }






    }
}
