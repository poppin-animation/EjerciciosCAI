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
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;


        //ATRIBUTOS DE CLASE --> PUBLICAS ENCAPSULADAS
        public string Nombre
        {
            get { return this._nombreComercio; }
            set { this._nombreComercio = value; }
        }
        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        public List<Repuesto> ListaProductos()
        {
            if (_listaProductos.Count == 0)
                return null;
            else
                return _listaProductos;
        }
        /// es un GETER sin SETTER.... si existen productos en la lista, te devuelvo la lista para mostrarla
        /// si no, te devuelvo un null. Desde program hacer metodo que diga si devuelve null... mensaje NOHAY PRODUCTOS. 


       


        // CONSTRUCTOR
        public VentaRepuestos(string nombre, string direccion)
        {
            _nombreComercio = nombre;
            _direccion = direccion;
            _listaProductos = new List<Repuesto>();

        }
        


        // MÉTODOS

        public void AgregarRepuesto(Repuesto repuesto)
        {
            // validar que datos  no sea null
            // validar que repuesto no sea null
            // validar que el cliente + mascota no exista. Si existe devolver FALSE


            _listaProductos.Add(repuesto);

            

        }
        /// <summary>
        /// 
        //int nuevoCodigo = TraerNuevoCodigo();
        //Repuesto repuesto = new Repuesto();
        /// private int _codigo;
        /// private string _nombre;
        ///private double _precio;
        /// private int _stock;
        /// private Categoria _categoria;
        /// </summary>
        /// <param name="codigo"></param>


        public void QuitarRepuesto(int codigo)
        {
            foreach (Repuesto repuesto in _listaProductos)
            {
                if(repuesto.Codigo == codigo)
                {
                    _listaProductos.Remove(repuesto);
                }

            }
        }
        public void ModificarPrecio(int codigo, double precio)
        {
            foreach (Repuesto repuesto in _listaProductos)
            {
                if (repuesto.Codigo == codigo)
                {
                    repuesto.SetPrecio(precio);
                }
            }
        }

        public void AgregarStock(int codigo, int stock)
        {
            foreach (Repuesto repuesto in _listaProductos)
            {
                if (repuesto.Codigo == codigo)
                {
                    repuesto.Stock = repuesto.Stock + stock;
                }
            }
        }

        public void QuitarStock(int codigo, int stock)
        {
            foreach (Repuesto repuesto in _listaProductos)
            {
                if (repuesto.Codigo == codigo)
                {
                    repuesto.Stock = repuesto.Stock - stock;
                }
            }

        }

        public List<Repuesto> TraerPorCategoria(int codigo)
        {
            List<Repuesto> lista = new List<Repuesto>();

            foreach (Repuesto repuesto in _listaProductos)
            {
                if (repuesto.GetCategoria().Codigo == codigo)
                {
                    lista.Add(repuesto);
                }
            }
            
            return lista;
        }

    }
}
