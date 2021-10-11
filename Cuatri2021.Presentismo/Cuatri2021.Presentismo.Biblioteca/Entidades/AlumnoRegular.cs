using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Entidades
{
    public class AlumnoRegular : Alumno
    {
        //atributos privados
        private string _email;


        //propiedades publicas
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }




        //Constructor
        public AlumnoRegular(int registro, string nombre, string apellido, string email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._email = email;
            this.Registro = registro;
        
        }



        //metodos






    }
}
