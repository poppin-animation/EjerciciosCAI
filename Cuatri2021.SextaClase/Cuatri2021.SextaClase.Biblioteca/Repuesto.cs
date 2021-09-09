using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cuatri2021.SextaClase.Biblioteca
{
    public class Repuesto
    {
        //PROPIEDADES DE CLASE --> PRIVADAS
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;



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
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        public double GetPrecio
        {
            get { return this._precio; }
            private set { this._precio = value; } // --> hacer un set privado ya que solo se podra modificar este valor accediendo al metodo SETPRECIO
        }

        public void SetPrecio(double precio) ///////////////////REVISAR EL ACCESS MODIFIER------------------------------------------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<°°°°||
        {

            double precioactual = GetPrecio;
            if (precioactual == 0 ) /// si el precio es cero, significa que no fue modificado aun. 
            {
                this._precio = precio;

            }
            else /// si el precio NO ES CERO, significa que ya fue modificado anteriormenta, y no puede volver a ser modificado. 
            {
                this._precio = precioactual;
            }

        }

        // CONSTRUCTOR

        public Repuesto()
        {
            this._codigo = ; // --> lo quiero seteado automatico ? o manual ? 
            this._nombre = ;
            this._stock = 0;
            this._precio = 0;
        }



        // MÉTODOS
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
