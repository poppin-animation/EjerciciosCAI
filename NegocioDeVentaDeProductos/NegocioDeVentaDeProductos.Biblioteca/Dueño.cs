using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDeVentaDeProductos.Biblioteca
{
    public abstract class Dueño
    {
        //// Clase Base,, abstracta. no tiene implementación. 

        //VARIABLES SIEMPRE PRIVADAS
        private string _nombre;
        private string _apellido;
        protected string _tipo; ////////// QUE sea solo accesible por esta clase y sus derivadas


        /// ATRIBUTOS OUBLICOS
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public virtual string Tipo ////////// QUE sea solo de esta clase y se pueda OVERRIDE por las demas 
        {
            get { return this._tipo = "Dueño"; }

        }

        public Dueño()
        {

        }

        public Dueño(string NombreEntrada, string ApellidoEntrada)
        {
            this._nombre = NombreEntrada;
            this._apellido = ApellidoEntrada;
            this._tipo = Tipo;
        }


        public void ModificarStock(int stockactual, int idProducto)
        {

        }
    }

}
