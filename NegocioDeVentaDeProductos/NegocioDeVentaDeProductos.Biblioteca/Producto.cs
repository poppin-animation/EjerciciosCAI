using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDeVentaDeProductos.Biblioteca
{
    public class Producto
    {
        //VARIABLES SIEMPRE PRIVADAS
        private int _idProducto;
        private string _nombreProducto;
        private int _cantidad;
        private int _precio;


        // ATRIBUTOS PUBLICOS

        public int IdProducto
        {
            get { return this._idProducto; }
            private set { this._idProducto = value; }
        }
        public string NombreProducto
        {
            get { return this._nombreProducto; }
            set { this._nombreProducto = value; } // --> hacer un set privado 
        }

        public int GetPrecio
        {
            get { return this._precio; }
            private set { this._precio = value; } // --> hacer un set privado ya que solo se podra modificar este valor accediendo al metodo SETPRECIO
        }

        public void SetPrecio(int precio) ///////////////////REVISAR EL ACCESS MODIFIER------------------------------------------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<°°°°||
        {

            int precioactual = this._precio;
            if (precioactual == 0 /*&& precio > 0 && precio <= 800*/) /// si el precio es cero, significa que no fue modificado aun. 
            {
                this._precio = precio;

                if (precio > 0 && precio <= 800) // si el precio ingresado es positivo y menor igual a 800, se modifica el precio del objeto. 
                {
                    this._precio = precio;
                }
                else // si no, se mantiene el precio que ya tenía. (manera de mostrar un mensaje de error?????????????)
                {
                    this._precio = precioactual;
                }
            }
            else /// si el precio NO ES CERO, significa que ya fue modificado anteriormenta, y no puede volver a ser modificado. 
            {
                this._precio = precioactual;
            }

        }

        public int CantidadProducto
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        //CONSTRUCTOR
        public Producto(int id, string nombre)
        {
            this._idProducto = id;
            this._nombreProducto = nombre;
            this._cantidad = 0;
            this._precio = 0;
        }


        public Producto(int id, string nombre, int cant, int precio)
        {
            this._idProducto = id;
            this._nombreProducto = nombre;
            this._cantidad = cant;
            this._precio = precio;
        }


        //METODOS

        public override string ToString()
        {
            //estamos definiendo un metodo que ya esta definido en el arbol para la clase objeto. 
            //ToString es el POLIMORFISMO MAS USADO se define 99% de las veces para subsanar ese error
            //es VIRTUAL y por eso permite sobreescribir el miembro en clases derivadas. 
            ///typeof(Repositor).Name me trae el nombre de la clase
            return string.Format($"{this._idProducto} - {this._nombreProducto} - Cantidad: {this._cantidad} - Precio: ${this._precio}.-");

        }
    }

}
