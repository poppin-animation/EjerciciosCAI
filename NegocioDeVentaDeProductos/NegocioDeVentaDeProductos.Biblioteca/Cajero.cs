using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDeVentaDeProductos.Biblioteca
{
    public class Cajero : Vendedor
    {
        //VARIABLES SIEMPRE PRIVADAS



        // ATRIBUTOS PUBLICOS
        public override string Tipo ////////// QUE sea solo de esta clase y se pueda OVERRIDE por las demas 
        {
            get { return this._tipo = "Cajero"; }

        }

        //CONSTRUCTOR (los constructores NO se heredan)
        public Cajero()
        {
            this._tipo = Tipo;
        }

        public Cajero(int LegajoEntrada, string NombreEntrada, string ApellidoEntrada)
            : base(LegajoEntrada, NombreEntrada, ApellidoEntrada)
        {
            this._tipo = Tipo;
        }

        /// METODOS
        //con el new definimos polimorfismo en tiempo de compilacion. De esta manera no se puede acceder al metodo dela clase base, ya que lo "oculto". 
        //To hide an inherited member, declare it in the derived class by using the same member name, and modify it with the new keyword.
        private new int ModificarStock(int stockactual, int idProducto)
        {
            int calculo = 0;
            return calculo;
        }

        public bool ValidarVenta(List<Venta> ventas)
        {
            if (ventas.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private protected bool ValidarCobro(Venta ultimaVenta)
        {
            if (ultimaVenta.Cobrado == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Cobrar(Venta ultimaVenta)
        {
            List<Producto> listaUltimaVenta = ultimaVenta.ProdVenta;
            if (ValidarCobro(ultimaVenta) == false)
            {
                Console.WriteLine($"La última Venta realizada (n° {ultimaVenta.Idventa}) ya ha sido cobrada. ");
            }
            else
            {
                //CALCULAR TOTAL A COBRAR
                if (ultimaVenta.TotalImporte >= 16000)
                {
                    ultimaVenta.TotalImporteConDescuento = Math.Round(((double)ultimaVenta.TotalImporte * 0.90), 2, MidpointRounding.AwayFromZero); //Descuento del 10% 
                }
                else if (ultimaVenta.TotalImporte >= 8000 && ultimaVenta.TotalImporte < 16000)
                {
                    ultimaVenta.TotalImporteConDescuento = Math.Round(((double)ultimaVenta.TotalImporte * 0.92), 2, MidpointRounding.AwayFromZero); //Descuento del 8% 
                                                                                                                                                    //Math.Round(123.4567, 2, MidpointRounding.AwayFromZero)
                }
                else if (ultimaVenta.TotalImporte > 4000 && ultimaVenta.TotalImporte < 8000)
                {
                    ultimaVenta.TotalImporteConDescuento = Math.Round(((double)ultimaVenta.TotalImporte * 0.94), 2, MidpointRounding.AwayFromZero); ; //Descuento del 6% 
                }
                else
                {
                    ultimaVenta.TotalImporteConDescuento = Math.Round(((double)ultimaVenta.TotalImporte), 2, MidpointRounding.AwayFromZero); ;
                }


                if (ultimaVenta.TotalImporteConDescuento == (double)ultimaVenta.TotalImporte)
                {
                    Console.WriteLine($"El total a cobrar es de ${ultimaVenta.TotalImporte} Bruto. No tiene descuento.");
                    Console.WriteLine($"Presione cualquier tecla para realizar el Cobro.");
                    Console.ReadKey();
                    CobrarVenta(ultimaVenta);
                }
                else
                {
                    Console.WriteLine($"El total a cobrar es de ${ultimaVenta.TotalImporte} Bruto y de $ {ultimaVenta.TotalImporteConDescuento} con descuento.");
                    Console.WriteLine($"Presione cualquier tecla para realizar el Cobro.");
                    Console.ReadKey();
                    CobrarVenta(ultimaVenta);
                }
            }

            Console.ReadKey();
        }

        //private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
        //lo puedo llamar desde aca y desde alguna clase derivada. NO DESDE EL MAIN ni otras clases. 
        private protected void CobrarVenta(Venta ultimaVenta)
        {
            ultimaVenta.Cobrado = true;
            Console.WriteLine($"La venta n°{ultimaVenta.Idventa} ha sido cobrada correctamente");
            Console.WriteLine(ultimaVenta);
            Console.WriteLine("Presione cualquier tecla para volver al menú anterior");
        }

        public void CierreDelDia(List<Venta> ventas)
        {
            double totalCobradoSinDescuento = 0;
            double totalCobradoConDescuento = 0;
            double totalVendidoSinDescuento = 0;
            double totalVendidoConDescuento = 0;
            int totalProductos = 0;
            int totalProductosCobrados = 0;
            int cantidadVentas = ventas.Count(); //total de las ventas, NO DISCRIMINA SI LA VENTA FUE COBRADA O NO 
            int cantidadVentasCobradas = 0;
            foreach (Venta v in ventas)
            {
                totalProductos += v.TotalCantidad; //total de los productos agregados a las ventas. NO DISCRIMINA SI LA VENTA FUE COBRADA O NO 
                if (v.Cobrado == true)
                {
                    totalCobradoConDescuento += v.TotalImporteConDescuento;
                    totalCobradoSinDescuento += (double)v.TotalImporte;
                    cantidadVentasCobradas++;
                    totalProductosCobrados += v.TotalCantidad;//total de los productos agregados a las ventas. 
                }
                else
                {
                    ///estoy calculando los totalesvendidos <> totales cobrados pero al final el calculo es por operacion (y en teorico por producto) pero no por
                    ///totalcobrado/totalvendido, que me podria dar un % de efectividad en las ventas. 
                    totalVendidoConDescuento += v.TotalImporteConDescuento;
                    totalVendidoSinDescuento += (double)v.TotalImporte;
                }
            }
            //cobrado Con/Sin descuento sobre las ventas creadas
            //USO Math.Round(((double)) --> usar para recortar el double a dos decimales
            double promedioConDescuento = Math.Round((totalCobradoConDescuento / cantidadVentas), 2, MidpointRounding.AwayFromZero);
            double promedioSinDescuento = Math.Round((totalCobradoSinDescuento / cantidadVentas), 2, MidpointRounding.AwayFromZero);

            //cobrado Con/Sin descuento sobre las ventas creadas
            //USO Math.Round(((double)) --> usar para recortar el double a dos decimales
            double promedioCobradoConDescuento = Math.Round((totalCobradoConDescuento / cantidadVentasCobradas), 2, MidpointRounding.AwayFromZero);
            double promedioCobradoSinDescuento = Math.Round((totalCobradoSinDescuento / cantidadVentasCobradas), 2, MidpointRounding.AwayFromZero);

            if ((Double.IsInfinity(promedioConDescuento)) || (Double.IsNaN(promedioConDescuento)))
            {
                throw new ArithmeticException();
            }
            Console.WriteLine($"El Total Cobrado del día SIN Descuentos fue de ${totalCobradoSinDescuento}.");
            Console.WriteLine($"El Total Cobrado del día CON Descuentos fue de ${totalCobradoConDescuento}.");
            Console.WriteLine();
            Console.WriteLine($"La Cantidad de Ventas en el día fue {cantidadVentas} venta(s)."); //lo saco por que no lo piden.
            Console.WriteLine($"La Cantidad de Productos Vendidos del día fue de {totalProductos} productos.");
            Console.WriteLine($"El Promedio de lo cobrado CON descuento contra lo vendido fue de ${promedioConDescuento} por venta.");
            Console.WriteLine($"El Promedio de lo cobrado SIN descuento contra lo vendido fue de ${promedioSinDescuento} por venta.");
            Console.WriteLine();
            Console.WriteLine($"La Cantidad de Ventas Cobradas en el día fue {cantidadVentasCobradas} venta(s)."); //lo saco por que no lo piden.
            Console.WriteLine($"La Cantidad de Productos Vendidos y Cobrados del día fue de {totalProductosCobrados} productos.");
            Console.WriteLine($"El Promedio de lo cobrado CON descuento contra lo vendido y cobrado fue de ${promedioCobradoConDescuento} por venta.");
            Console.WriteLine($"El Promedio de lo cobrado SIN descuento contra lo vendido y cobrado fue de ${promedioCobradoSinDescuento} por venta.");
        }
    }
}
