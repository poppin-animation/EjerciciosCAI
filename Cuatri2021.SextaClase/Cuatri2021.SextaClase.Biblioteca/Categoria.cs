using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.SextaClase.Biblioteca
{
    class Categoria
    {
        //PROPIEDADES DE CLASE --> PRIVADAS
        private int _codigo;
        private string _nombre;


        //ATRIBUTOS DE CLASE --> PUBLICAS ENCAPSULADAS

        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }


        // CONSTRUCTOR --> implicito 




        // MÉTODOS




    }
}
