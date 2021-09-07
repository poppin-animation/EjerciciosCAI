using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDeVentaDeProductos.Biblioteca
{
    public class Venta
    {
        //PROPIEDADES
        private static int IdVenta = 0;
        private int _idVenta = 0;
        private string _nombreCliente;
        private List<Producto> _prodVenta = new List<Producto>();
        private int _totalCantidad;
        private double _totalImporte;
        private double _totalImporteConDescuento;
        private bool _cobrado = false;

        //ATRIBUTOS
        public int Idventa
        {
            get { return this._idVenta; }
            //private set { this._idVenta = value;  }
        }
        public string NombreCliente
        {
            get { return this._nombreCliente; }
            set { this._nombreCliente = value; }
        }
        public List<Producto> ProdVenta
        {
            get { return this._prodVenta; }
            private set { this._prodVenta = value; }
        }

        public int TotalCantidad ///AGREGAR VALIDACION de MAX 25?
        {
            get { return this._totalCantidad; }
            private set { this._totalCantidad = value; }
        }
        public double TotalImporte
        {
            get { return this._totalImporte; }
            private set { this._totalImporte = value; }
        }
        public double TotalImporteConDescuento
        {
            get { return this._totalImporteConDescuento; }
            set { this._totalImporteConDescuento = value; }
        }
        public bool Cobrado
        {
            get { return this._cobrado; }
            set { this._cobrado = value; }
        }

        public Venta(string cliente, List<Producto> prodVenta)
        {
            //HAGO CALCULOS
            int cantidadTotal = 0;
            int posicionVenta = IdVenta; //uso idventa aca por que es la posicion dela lista, antes de aumentar unaunidad. 
            double importeTotal = 0;
            foreach (Producto p in prodVenta)
            {
                cantidadTotal += p.CantidadProducto;

            }

            foreach (Producto p in prodVenta)
            {
                importeTotal += (double)(p.GetPrecio * p.CantidadProducto); //Dotnet preffers compound assignment x+=y que es x = x + y

            }

            //SETEO ATRIBUTOS
            IdVenta++; //aumento enuna unidad al idventa
            this._idVenta = IdVenta; //grabo el Idventa acumulado 
            this._nombreCliente = cliente;
            this._prodVenta = prodVenta;
            this.TotalCantidad = cantidadTotal;
            this.TotalImporte = importeTotal;
        }


        //MÉTODOS
        public override string ToString()
        {
            //hago un override del ToString de Clase Objeto.
            return string.Format($"Venta n° {this._idVenta} - Cliente: {this._nombreCliente} - Cantidad de Productos: {this._totalCantidad} - Importe Total: ${this._totalImporte} - Importe con Descuento: ${this._totalImporteConDescuento} - Cobrado: {this._cobrado}.");

        }

    }
}
