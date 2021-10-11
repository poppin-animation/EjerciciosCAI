using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Entidades
{
    public abstract class Alumno : Persona
    {
        //atributos privados
        private int _registro;


        //propiedades publicas
        public int Registro
        {
            get { return this._registro; }
            set { this._registro = value; }
        }




        //Constructor




        //metodos
        internal override string Display()
        {
            return $"";
        }





    }
}
