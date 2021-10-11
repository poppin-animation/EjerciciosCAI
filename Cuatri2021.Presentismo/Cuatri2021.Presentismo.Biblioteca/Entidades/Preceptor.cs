using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cuatri2021.Presentismo.Biblioteca.Entidades
{
   public class Preceptor : Persona
    {
        //atributos privados
        private int _legajo;


        //propiedades publicas
        public int Legajo 
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }




        //Constructor
        public Preceptor(int legajo, string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._legajo = legajo;

        }



        //metodos
        internal override string Display()
        {
            return $"";
        }





    }
}
