using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.SextaClase.Biblioteca
{
    public class VentaRepuestos
    {
        //PROPIEDADES DE CLASE --> PRIVADAS
        private List<Repuesto> _listaProductos = new List<Repuesto>();
        private string _nombreComercio;
        private string _direccion;


        //ATRIBUTOS DE CLASE --> PUBLICAS ENCAPSULADAS
        public List<Repuesto> ListaProductos 
        {
            get { return this._listaProductos; }
            private set { this._listaProductos = value; }///REVISAR EL SETTER SI ES PRIVADO O QUE. 
        }
        public string Nombre
        {
            get { return this._nombreComercio; }
            set { this._nombreComercio = value; }
        }


        // CONSTRUCTOR
        public VentaRepuestos(string nombre, string direccion)
        {
            




        }



        // MÉTODOS
        public void AgregarRepuesto(Repuesto repuesto)
        {

        }

        public void QuitarRepuesto(int codigo)
        {

        }
        public void ModificarPrecio(int codigo, double precio)
        {

        }
        public void AgregarStock(int codigo, int stock)
        {

        }
        public void QuitarStock(int codigo, int stock)
        {

        }

        public List<Categoria> TraerPorCategoria(int cat)
        {
            List<Categoria> lista = new List<Categoria>();
            

            foreach (int categoria in ListaProductos.Categoria)
            {
                lista.Add(rep);

            }

            for (int i = 1; i <= cantProductosmax; i++)
            {
                Producto prod = new Producto(i, $"Producto n° {i}");
                productos.Add(prod);
            }


            return lista;
        }

    }
}
