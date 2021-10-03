using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Alumno : Persona
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
        public Alumno(int codigo, string nombre, string apellido) : base()
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public Alumno(string nombre, string apellido) : base()
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public Alumno() : base()
        {

        }

        //METODOS
        public override string GetCredencial()
        {
            return $"Código {_codigo} - {_apellido}, {_nombre}";
        }


        public override string ToString()
        {
            return this.GetCredencial();

        }

        public override bool Equals(Object o)
        {
            if (o == null)
            {
                return false;
            }

            if (this._codigo == ((Alumno)o).Codigo)
            {
                return true;
            }

            return false;
        }


    }
}
