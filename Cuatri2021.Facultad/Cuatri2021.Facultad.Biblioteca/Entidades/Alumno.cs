using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    class Alumno : Persona
    {
        //ATRIBUTOS PRIVADOS
        private int _codigo;
        private string _credencial;


        //PROPIEDADES PUBLICAS
        public string Credencial
        {
            get { return this._credencial; }
            set { this._credencial = value; }
        }
        public int Codigo 
        {
            get { return this._codigo; }
            set { this._codigo = value; }

        }



        //CONSTRUCTOR




        //METODOS
        public override string GetCredencial()
        {
            return "algo";
        }


        public override string ToString()
        {
            return string.Format($"{this._codigo} - {this.GetNombreCompleto()} ");

        }




    }
}
