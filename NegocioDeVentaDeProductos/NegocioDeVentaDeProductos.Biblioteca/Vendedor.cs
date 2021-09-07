using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDeVentaDeProductos.Biblioteca
{
    public class Vendedor : Repositor
    {
        //VARIABLES SIEMPRE PRIVADAS



        // ATRIBUTOS PUBLICOS
        public override string Tipo
        {
            get { return this._tipo = "Vendedor"; }

        }


        //CONSTRUCTOR (los constructores NO se heredan)
        public Vendedor()
        {


            this._tipo = Tipo;

        }
        public Vendedor(int LegajoEntrada, string NombreEntrada, string ApellidoEntrada)
            : base(LegajoEntrada, NombreEntrada, ApellidoEntrada)
        {


            this._tipo = Tipo;

        }


        /// METODOS
        public bool ComprobarPrecio(List<Producto> productos, int posicionProducto) //// COMPRUEBO QUE EL PRODUCTO TENGA PRECIO PARA ESTABLECER EL PRECIO 
        {

            if (productos[posicionProducto].GetPrecio == 0)
            {
                return true;
                //NO TIENE PRECIO = FALSE
            }
            else
            {
                return false; // TIENE PRECIO = TRUE
            }



        }

        public int EstablecerPrecio(List<Producto> productos, int posicionProducto) //// ESTABLECER EL PRECIO DE UN PRODUCTO 
        {
            int nuevoPrecio;
            int id = posicionProducto + 1;


            if (ComprobarPrecio(productos, posicionProducto) == true)
            {
                Console.Clear();
                Console.WriteLine($"Actualmente el precio del {productos[posicionProducto].NombreProducto} es de $ {productos[posicionProducto].GetPrecio}. Ingrese el nuevo Precio. \n" +
                $"Tenga en cuenta que el precio NO puede superar los $800  \n" +
                $"y una vez establecido el Precio de un producto, el mismo NO puede ser modificado.");
                nuevoPrecio = Validador.ValidarMinMax(0, 800);

                productos[posicionProducto].SetPrecio(nuevoPrecio);
                Console.WriteLine(productos[posicionProducto]);

            }
            else
            {
                Console.WriteLine($"Actualmente el precio del {productos[posicionProducto].NombreProducto} es de $ {productos[posicionProducto].GetPrecio} y el mismo ya NO puede ser modificado.");
                nuevoPrecio = productos[posicionProducto].GetPrecio;

            }
            //Console.ReadKey();
            return nuevoPrecio;
        }

        public int SeleccionarProducto(string cliente, List<Producto> prodVentas) //sobrecarga de metodos vendedor.SeleccionarProducto(); es el que viene de la clase padre repositor. 
        {
            Console.Clear();
            int cantidadingresos = prodVentas.Count() + 1;
            Console.WriteLine($"Sr/a. {cliente}. {cantidadingresos}° Ingreso: Ingrese el ID de producto que desea Seleccionar. \n" +
                          $"Debe ingresar un número del 1 al 37.");
            int idproducto = Validador.ValidarOpcion(37);
            Console.WriteLine($"Usted a seleccionado el Producto n° {idproducto}");
            Console.ReadKey();
            //idproducto = idproducto - 1; //le resto uno porque en la lista se arranca con el i=0, entonces el producto id = 1 se encuentra en la posicion 0 de la lista. 
            return idproducto; // DEVUELVO EL IDPRODUCTO no la posicion. 
        }

        public int SeleccionarProdVentas(string cliente)
        {
            Console.Clear();
            Console.WriteLine($"Buenos días {cliente}, ¿Cuántos productos desea agregar a la venta? \n" +
                           $"Recuerde que solo puede seleccionar un mínimo de 1 y un máximo de 7 productos diferentes. ");
            int cantidad = Validador.ValidarMinMax(1, 7);
            //this.DefinirCantProducto(cantidad);////INSTANCIO LOS PRODUCTOS DE LA VENTA Y LOS AGREGO A LA LISTA PRODVENTA
            return cantidad;
        }

        public Tuple<bool, int> ComprobarStock(int idprod, List<Producto> productos, string cliente)
        {
            bool resultado;
            int posicionProducto = idprod - 1;
            Console.WriteLine($"Gracias {cliente}, ¿Cuánta cantidad del Producto n°{idprod} desea agregar a la venta? Stock Actual:{productos[posicionProducto].CantidadProducto}. \n" +
                            $"Recuerde que solo puede seleccionar un total de 25 unidades para toda la venta. ");
            int cantidad = Validador.ValidarIntPositivo();
            if (productos[posicionProducto].CantidadProducto <= 0) //// si no tiene stock, falso 
            {
                resultado = false; //Falso, no puedo agregarlo 
            }
            else
            {
                if (productos[posicionProducto].CantidadProducto < cantidad) ////si tiene menos stock del que necesito = falso 
                {
                    resultado = false;
                }
                else // si tiene el stock que necesito ... !
                {

                    resultado = true;  //true, puedo agregarlo PERO 
                }

            }
            return new Tuple<bool, int>(resultado, cantidad);

        }

        public bool ComprobarCantidad(List<Producto> prodVentas, int cant) //// COMPUREBO QUE NO SE SUPERE LA CANTIDAD TOTAL DE 25 U SIN INSTANCIAR VENTAS 
        {
            int cantidadTotal = 0;
            foreach (Producto p in prodVentas)
            {
                cantidadTotal += cantidadTotal + p.CantidadProducto;
            }
            cantidadTotal += cant; //le agrego la suma del ultimo producto que aun no se encuentra en la lista

            if (cantidadTotal <= 25)
            {

                return true; //PUEDE AGREGAr = TRUE
            }
            else
            {
                return false; // NO SE PUEDE AGREGAR ESA CANTIDAD DE PRODUCTOS, LLEGO AL LIMITE
            }

        }

        public int BajarStockPorVenta(List<Producto> productos, int cant, int id)
        {
            //bool valido = false; 
            int calculo = productos[id - 1].CantidadProducto - cant;

            return calculo; //retorno el nuevo stock. 
        }

        public void AgregarProductoaLista(List<Producto> productos, List<Producto> prodVentas, int id, int cant)
        {
            int precio = productos[id - 1].GetPrecio;
            //INSTANCIO NUEVO PRODUCTO
            Producto prod = new Producto(id, $"Producto n° {id}", cant, precio);
            //LO AGREGO A LA LISTA DE PRODUCTOS PARA LA VENTA
            prodVentas.Add(prod);
            ///BAJO EL STOCK DEL PROD ORIGINAL
            productos[id - 1].CantidadProducto = this.BajarStockPorVenta(productos, cant, id);
            Console.WriteLine($"Producto agregado: {prod}");
            Console.ReadKey();

        }

        public bool ValidarRepetido(List<Producto> prodVentas, int idprod)
        {
            bool valido = false;
            if (prodVentas.Exists(producto1 => producto1.IdProducto == idprod))
            {
                Console.WriteLine($"No se puede seleccionar. El Producto n° {idprod} ya se encuentra en la canasta.");
                Console.ReadKey();
            }
            else
            {
                valido = true;
            }
            return valido;

        }

        public void AgregarProducto(string cliente, List<Producto> productos, List<Venta> ventas, int posicionVenta, Vendedor vendedor, ref int opcionV)
        {
            bool opcion = false;
            int cantidadProd = this.SeleccionarProdVentas(cliente);
            //Creo la lista de productos para agregar antes de crear la venta. 
            List<Producto> prodVentas = new List<Producto>();
            do
            {
                int idprod = this.SeleccionarProducto(cliente, prodVentas); // selecciono el NUMERODEPRODCUTO para comprobar y agregar ala lista de prodventas. 
                if ((ComprobarPrecio(productos, (idprod - 1)) == true))
                {
                    //si no tiene precio salgo del loop y vuelvo a arrancaR?
                    Console.WriteLine("NOTIENEPRECIO");
                    if (!QuiereContinuar())
                    {
                        Program.MenuVendedor(productos, ventas, vendedor, cliente);
                    }
                    Console.ReadKey();
                }
                else
                {
                    //SI TIENE PRECIO
                    //COMPRUEBO STOCK
                    var result2 = ComprobarStock(idprod, productos, cliente);
                    bool resultado = result2.Item1;
                    int cantidad = result2.Item2;

                    if (resultado == false)
                    {
                        //Si no tiene stock salgo del loop y vuelvo a arrancaR?
                        Console.WriteLine("NOTIENESTOCK");
                        if (!QuiereContinuar())
                        {
                            Program.MenuVendedor(productos, ventas, vendedor, cliente);
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        //SI TIENE STOCK
                        //COMPRUEBO QUE LA CANTIDAD NO SUPERE EL TOTAL POSIBLE POR VENTA

                        if ((ComprobarCantidad(prodVentas, cantidad) == false))
                        {
                            //NO SE PUEDE AGREGAR
                            Console.WriteLine("SUPERA LA CANTIDAD");
                            if (!QuiereContinuar())
                            {
                                Program.MenuVendedor(productos, ventas, vendedor, cliente);
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            //SI lA CANTIDAD NO SUPERA EL TOTAL POSIBLE DE 25 UNIDADES 
                            // VALIDO QUE NO ESTE REPETIDO EN LA LISTA 
                            if (ValidarRepetido(prodVentas, idprod) == false)
                            {
                                // NO SE PUEDE AGREGAR
                                //Console.WriteLine("ESTA REPETIDO");
                                if (!QuiereContinuar())
                                {
                                    Program.MenuVendedor(productos, ventas, vendedor, cliente);
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                //SI NO ESTA REPETIDO, LO PUEDO AGREGAR
                                //AGREGO EL PRODUCTO A LA LISTA 
                                AgregarProductoaLista(productos, prodVentas, idprod, cantidad);
                                opcion = true;

                            }
                        }
                    }
                }
            } while (prodVentas.Count() != cantidadProd || opcion == false);
            Venta nuevaVenta = new Venta(cliente, prodVentas);
            ventas.Add(nuevaVenta);
            Console.WriteLine(nuevaVenta);
        }

        internal static bool QuiereContinuar() //El modificador internal indica que aquellos miembros o tipos que se hayan definido con este modificador de acceso
                                               ////sólo serán accesibles desde los archivos del mismo ensamblado.
        {
            string salida;
            do
            {
                Console.Write("Desea continuar? Ingrese S o N: ");
                salida = Console.ReadLine();
                if (string.IsNullOrEmpty(salida))
                    Console.Write("\nEl campo no puede ser vacío." +
                        "\nPor favor, ingrese un nuevo valor.\n");
            } while (string.IsNullOrEmpty(salida) || (salida.ToUpper() != "S" && salida.ToUpper() != "N"));

            return salida.ToUpper() == "S";
        }
    }

}
