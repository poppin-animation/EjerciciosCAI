using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Empleado : Persona
    {
        //ATRIBUTOS PRIVADOS
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios = new List<Salario>();
        private Salario _ultimoSalario;


        //PROPIEDADES PUBLICAS
        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public List<Salario> Salarios
        {
            get { return this._salarios; }
        }

        public Salario UltimoSalario
        {
            get { return _ultimoSalario; }
        }
        // return this._salarios.Last(); } //Retrieves LAST objet from list
        //otra opcion this._salarios[_salarios.Count()-1]
        

        public DateTime FechaNacimiento 
        {
            get { return _fechaNac; }
            //------------------------------------------>>> como seteas unj datetime sin usar laconsola por las claseS? tenes que ya enviarlo seteado en datetime
            //////DateTime nacimiento = new DateTime(2000,1,25); 
            set
            {
                _fechaNac = value;
            }
        }

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set
            {
                _fechaIngreso = value;
            }
        }

        public int Antiguedad
        {
            get
            {
                int antiguedad;
                antiguedad = (DateTime.Today - this._fechaIngreso).Days / 365;
                //(la fecha de hoy, menos la fecha de ingreso) en dias.... dividido 365 para calcular años.
                return antiguedad;
            }
        }





        //CONSTRUCTOR
        public Empleado(int legajo, string nombre, string apellido) : base()
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public Empleado() : base()
        {

        }




        //METODOS
        public override string GetCredencial()
        {
            return $"Legajo n° {_legajo} - {GetNombreCompleto()} - Salario $ {_ultimoSalario}";
        }

        protected override string GetNombreCompleto()
        {
            string nombreCompleto = this._nombre + " " + this._apellido ;

            return nombreCompleto;
        }


        public override string ToString()
        {
            return GetCredencial();

        }

        public void AgregarSalario (Salario salario)
        {
            _salarios.Add(salario);
            //agregar manexo de excepciones. si e salario es null si se pudo agregar o no ala lista. 


        }

        public override bool Equals(object obj)
        {
            //si el objeto a validar es nulo,  o el tipo de ESTE objeto empleado NO es igual al tipo del objeto a validar, retornar FALSO. 
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else // de otra manera, retornar verdadero
            {
                return true;
            }
        }


    }
}
