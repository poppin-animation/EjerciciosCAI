using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Indumentaria.Biblioteca
{
    public class Cliente
    {
        //Atributos privados
        private int _codigo;
        private string _apellido;
        private string _nombre;

        //propiedades publicas

        public int Codigo
        {
            get { return this._codigo; }
        }
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

        //constructor



        //metodos




    }
}
