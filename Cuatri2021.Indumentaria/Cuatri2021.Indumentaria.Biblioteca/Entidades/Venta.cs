using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Indumentaria.Biblioteca.Enumeradores;
using Cuatri2021.Indumentaria.Biblioteca.Entidades;

namespace Cuatri2021.Indumentaria.Biblioteca.Entidades
{
    public class Venta
    {
        //Atributos privados
        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;



        //propiedades publicas
        public List<VentaItem> Items
        {
            get { return _items; }
            //set {_items = value; }
        }
        public Cliente Cliente
        {
            get { return _cliente; }
        }
        public int Codigo
        {
            get { return _codigo; }
            internal set { _codigo = value; }
        }
        public int Estado
        {
            get { return _estado; }
        }



        //constructor
        public Venta()
        {
            this._items = new List<VentaItem>();
            this._cliente = new Cliente();
            this._estado = 1; ///enumerador EstadoVenta[1] = iniciada
        }


        //metodos
        public double GetTotalPedido()
        {
            double total = 0;
            foreach(VentaItem item in _items)
            {
                total = total + (item.Cantidad * item.Prenda.Precio);
            }
            return total;
        }






    }
}
