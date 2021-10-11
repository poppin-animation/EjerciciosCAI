using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Entidades
{
    public abstract class Persona
    {
        //atributos privados
        protected string _nombre;
        protected string _apellido;



        //propiedades publicas
        public string Nombre
        {
            get { return this._nombre; }
            set {this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }



        //Constructor




        //metodos
        internal abstract string Display();


        public override string ToString()
        {
           if(this is Alumno)
           {
                return $"{Nombre} - Registro n° {((Alumno)this).Registro}"; ;
           }
           else 
           {
                return $"{Apellido} -  Legajo n° {((Preceptor)this).Legajo}";
           }
 
        }





    }
}
