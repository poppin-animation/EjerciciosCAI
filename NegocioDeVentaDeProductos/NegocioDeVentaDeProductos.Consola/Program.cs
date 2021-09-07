using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NegocioDeVentaDeProductos.Biblioteca;

namespace NegocioDeVentaDeProductos.Consola
{

    class Program
    {
        static void Main(string[] args)
        {
            //Crea una nueva lista y le ingresa elementos en el momento de su creacion
            List<Producto> productos = new List<Producto>();
            int cantProductosmax = 37;
            //inicializo , instancio, creo 37 productos, y los agrego a una lista. 
            for (int i = 1; i <= cantProductosmax; i++)
            {
                Producto prod = new Producto(i, $"Producto n° {i}");
                productos.Add(prod);
            }
            //creo una lista para guardar las ventas de todo el día. inicialmente, se encuentra vacia de objetos venta.
            List<Venta> ventas = new List<Venta>();
            string cliente = "";

            ///LLAMO AL MENU PRINCIPAL 
            MenuPrincipal(productos, cliente, ventas);

            //Cuando regreso al MAIN, se cierra. 
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }


        /////////////////////                            MENUES                             ///////////////////////////////////////
        public static void MenuPrincipal(List<Producto> productos, string cliente, List<Venta> ventas)
        {
            int opcion;
            ///INSTANCIO LOS TRES POSIBLES ACTORES 
            Repositor repositor = new Repositor();
            Vendedor vendedor = new Vendedor();
            Cajero cajero = new Cajero();
            do
            {
                Console.Clear(); //limpio la pantalla. 
                Console.WriteLine("NEGOCIO DE VENTA DE PRODUCTOS:");
                Console.WriteLine("¿Que desea hacer?: \n" +
                $"1 - Utilizar el Sistema como REPOSITOR \n" +
                $"2 - Utilizar el Sistema como VENDEDOR \n" +
                $"3 - Utilizar el Sistema como CAJERO");
                opcion = Validador.ValidarOpcion(3);

                switch (opcion)
                {
                    case 1: ///////////// "MENU DEL REPOSITOR" ////////////////////
                        Console.WriteLine("MENU DEL REPOSITOR");
                        MenuRepositor(ref opcion, productos, repositor);

                        break;
                    case 2: ///////////// "MENU DEL VENDEDOR" ////////////////////
                        Console.Clear();
                        MenuVendedor(ref opcion, productos, ventas, vendedor, cliente);

                        break;
                    case 3: ///////////// "MENU DEL CAJERO" ////////////////////
                        Console.Clear();
                        MenuCajero(ref opcion, productos, ventas, cajero, cliente);

                        break;
                }
            } while (opcion != 1 && opcion != 2 && opcion != 3);
        }


        public static void MenuRepositor(ref int opcion, List<Producto> productos, Repositor repositor)
        {

            int opcionR;
            do
            {
                Console.Clear(); //limpio la pantalla. Console.Clear();
                Console.WriteLine("MENU DEL REPOSITOR");
                Console.WriteLine("¿Qué desea hacer? \n" +
                $"1 - Aumentar o Disminuir el stock de un producto \n" +
                $"2 - Volver al Menu Anterior");
                opcionR = Validador.ValidarOpcion(2);

                switch (opcionR)
                {
                    case 1: ///////////// "MODIFICAR STOCK" ////////////////////
                        Console.Clear();
                        Console.WriteLine("MODIFICAR STOCK");
                        int idproducto = repositor.SeleccionarProducto();
                        productos[idproducto].CantidadProducto = repositor.ModificarStock(productos[idproducto].CantidadProducto, idproducto);
                        //dentro del metodo me pide una nueva cantidad y la modifica si cumple con las condiciones. 
                        Console.WriteLine(productos[idproducto]); //muestro el producto con los valores modificados. 

                        Console.ReadKey();
                        opcionR = 0;
                        break;

                    case 2: ///////////// "VOLVER AL MENU PRINCIPAL" ////////////////////
                            //Console.Clear();

                        opcion = 0;
                        break;
                }
            } while (opcionR != 1 && opcionR != 2);
        }

        public static void MenuVendedor(ref int opcion, List<Producto> productos, List<Venta> ventas, Vendedor vendedor, string cliente)
        {

            //int idproducto;
            int opcionV;

            do
            {

                Console.Clear(); //limpio la pantalla. Console.Clear();
                Console.WriteLine("MENU DEL VENDEDOR");
                Console.WriteLine("¿Qué desea hacer? \n" +
                $"1 - Aumentar o Disminuir el stock de un producto \n" +
                $"2 - Agregar Productos a la Venta \n" +
                $"3 - Establecer el Precio de un producto \n" +
                $"4 - Volver al Menu Anterior");
                opcionV = Validador.ValidarOpcion(4);

                switch (opcionV)
                {
                    case 1: ///////////// "MODIFICAR STOCK" ////////////////////
                        Console.Clear();
                        Console.WriteLine("MODIFICAR STOCK");
                        int posicionProducto = vendedor.SeleccionarProducto();
                        productos[posicionProducto].CantidadProducto = vendedor.ModificarStock(productos[posicionProducto].CantidadProducto, posicionProducto);
                        //dentro del metodo me pide una nueva cantidad y la modifica si cumple con las condiciones. 
                        Console.WriteLine(productos[posicionProducto]); //muestro el producto con los valores modificados. 

                        Console.ReadKey();
                        opcionV = 0;
                        break;

                    case 2: ///////////// "AGREGAR PRODUCTOS A LA VENTA" ////////////////////
                        Console.Clear();
                        Console.WriteLine("AGREGAR PRODUCTOS A UNA VENTA");
                        Console.WriteLine("Ingrese el nombre del Cliente");
                        cliente = Validador.ValidarString();

                        int posicionVenta = ventas.Count(); //sin ventas--> posicion = 0, con 1 venta, nueva posicion = 1, con 2 = 2, 
                        vendedor.AgregarProducto(cliente, productos, ventas, posicionVenta, vendedor, ref opcionV);
                        Console.WriteLine(ventas[ventas.Count() - 1]);

                        Console.ReadKey();
                        opcionV = 0;
                        break;

                    case 3: ///////////// "ESTABLECER EL PRECIO DE UN PRODUCTO" ////////////////////
                        Console.Clear();
                        Console.WriteLine("ESTABLECER EL PRECIO DE UN PRODUCTO");
                        posicionProducto = vendedor.SeleccionarProducto();
                        int nuevoprecio = vendedor.EstablecerPrecio(productos, posicionProducto);
                        productos[posicionProducto].SetPrecio(nuevoprecio);

                        Console.ReadKey();
                        opcionV = 0;
                        break;
                    case 4: ///////////// "VOLVER AL MENU ANTERIOR" ////////////////////
                        Console.Clear();

                        opcion = 0;
                        //opcionV = 0;
                        break;
                }
            } while (opcionV != 1 && opcionV != 2 && opcionV != 3 && opcionV != 4);
        }

        public static void MenuVendedor(List<Producto> productos, List<Venta> ventas, Vendedor vendedor, string cliente)
        {

            //int idproducto;
            int opcionV;

            do
            {

                Console.Clear(); //limpio la pantalla. Console.Clear();
                Console.WriteLine("MENU DEL VENDEDOR");
                Console.WriteLine("¿Qué desea hacer? \n" +
                $"1 - Aumentar o Disminuir el stock de un producto \n" +
                $"2 - Agregar Productos a la Venta \n" +
                $"3 - Establecer el Precio de un producto \n" +
                $"4 - Volver al Menu Principal");
                opcionV = Validador.ValidarOpcion(4);

                switch (opcionV)
                {
                    case 1: ///////////// "MODIFICAR STOCK" ////////////////////
                        Console.Clear();
                        Console.WriteLine("MODIFICAR STOCK");
                        int posicionProducto = vendedor.SeleccionarProducto();
                        productos[posicionProducto].CantidadProducto = vendedor.ModificarStock(productos[posicionProducto].CantidadProducto, posicionProducto);
                        //dentro del metodo me pide una nueva cantidad y la modifica si cumple con las condiciones. 
                        Console.WriteLine(productos[posicionProducto]); //muestro el producto con los valores modificados. 

                        Console.ReadKey();
                        opcionV = 0;
                        break;

                    case 2: ///////////// "AGREGAR PRODUCTOS A LA VENTA" ////////////////////
                        Console.Clear();
                        Console.WriteLine("AGREGAR PRODUCTOS A UNA VENTA");
                        Console.WriteLine("Ingrese el nombre del Cliente");
                        cliente = Validador.ValidarString();

                        int posicionVenta = ventas.Count(); //sin ventas--> posicion = 0, con 1 venta, nueva posicion = 1, con 2 = 2, 
                        vendedor.AgregarProducto(cliente, productos, ventas, posicionVenta, vendedor, ref opcionV);
                        Console.WriteLine(ventas[ventas.Count() - 1]);

                        Console.ReadKey();
                        opcionV = 0;
                        break;

                    case 3: ///////////// "ESTABLECER EL PRECIO DE UN PRODUCTO" ////////////////////
                        Console.Clear();
                        Console.WriteLine("ESTABLECER EL PRECIO DE UN PRODUCTO");
                        posicionProducto = vendedor.SeleccionarProducto();
                        int nuevoprecio = vendedor.EstablecerPrecio(productos, posicionProducto);
                        productos[posicionProducto].SetPrecio(nuevoprecio);

                        Console.ReadKey();
                        opcionV = 0;
                        break;
                    case 4: ///////////// "VOLVER AL MENU PRINCIPAL" ////////////////////
                        Console.Clear();

                        MenuPrincipal(productos, cliente, ventas);
                        //opcionV = 0;
                        break;
                }
            } while (opcionV != 1 && opcionV != 2 && opcionV != 3 && opcionV != 4);
        }

        public static void MenuVendedor2(ref int opcion, List<Producto> productos, List<Venta> ventas, Vendedor vendedor, string cliente)
        {

            //int idproducto;
            int opcionV;

            do
            {

                Console.Clear(); //limpio la pantalla. Console.Clear();
                Console.WriteLine("MENU DEL VENDEDOR");
                Console.WriteLine("¿Qué desea hacer? \n" +
                $"1 - Agregar Productos a la Venta \n" +
                $"2 - Establecer el Precio de un producto \n" +
                $"3 - Volver al Menu Anterior");
                opcionV = Validador.ValidarOpcion(3);

                switch (opcionV)
                {
                    case 1: ///////////// "AGREGAR PRODUCTOS A LA VENTA" ////////////////////
                        Console.Clear();
                        Console.WriteLine("AGREGAR PRODUCTOS A UNA VENTA");
                        Console.WriteLine("Ingrese el nombre del Cliente");
                        cliente = Validador.ValidarString();

                        int posicionVenta = ventas.Count(); //sin ventas--> posicion = 0, con 1 venta, nueva posicion = 1, con 2 = 2, 
                        vendedor.AgregarProducto(cliente, productos, ventas, posicionVenta, vendedor, ref opcionV);
                        Console.WriteLine(ventas[ventas.Count() - 1]);

                        Console.ReadKey();
                        opcionV = 0;
                        break;

                    case 2: ///////////// "ESTABLECER EL PRECIO DE UN PRODUCTO" ////////////////////
                        Console.Clear();
                        Console.WriteLine("ESTABLECER EL PRECIO DE UN PRODUCTO");
                        int posicionProducto = vendedor.SeleccionarProducto();
                        int nuevoprecio = vendedor.EstablecerPrecio(productos, posicionProducto);
                        productos[posicionProducto].SetPrecio(nuevoprecio);

                        Console.ReadKey();
                        opcionV = 0;
                        break;
                    case 3: ///////////// "VOLVER AL MENU ANTERIOR" ////////////////////
                        Console.Clear();

                        opcion = 0;
                        break;
                }
            } while (opcionV != 1 && opcionV != 2 && opcionV != 3 && opcionV != 4);
        }


        public static void MenuCajero(ref int opcion, List<Producto> productos, List<Venta> ventas, Cajero cajero, string cliente)
        {

            int opcionC;
            do
            {
                Console.Clear(); //limpio la pantalla. Console.Clear();
                Console.WriteLine("MENU DEL CAJERO");
                Console.WriteLine("¿Qué desea hacer? \n" +
                $"1 - Realizar Funciones de Vendedor \n" +
                $"2 - Cobrar al Cliente \n" +
                $"3 - Cierre del Día \n" +
                $"4 - Volver al Menu Anterior");
                opcionC = Validador.ValidarOpcion(4);

                switch (opcionC)
                {
                    case 1: ///////////// "FUNCIONAR COMO VENDEDOR" ////////////////////

                        MenuVendedor2(ref opcionC, productos, ventas, cajero, cliente);

                        break;

                    case 2: ///////////// "Cobrar al Cliente" ////////////////////
                        Console.Clear();
                        Console.WriteLine("COBRAR AL CLIENTE");
                        if (cajero.ValidarVenta(ventas) == false)
                        {
                            Console.WriteLine("No existen Ventas cargadas. Solicite al Vendedor o carguela por su cuenta ");
                        }
                        else
                        {
                            ////TRAIGO LA ULTIMA VENTA
                            int ultimaventa = ventas.Count() - 1;
                            Venta ultimaVenta = ventas[ultimaventa];
                            //Cobro la venta (valido si ya fue cobrada, calculo los importes con descuento, la marco como cobrada)                            
                            cajero.Cobrar(ultimaVenta);

                            cliente = "";
                        }
                        Console.ReadKey();
                        opcionC = 0;
                        break;

                    case 3: ///////////// "CIERRE DEL DIA" ////////////////////
                        Console.Clear();
                        Console.WriteLine("CIERRE DEL DIA");
                        try
                        {
                            cajero.CierreDelDia(ventas);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ha ocurrido un error al realizar el Cierre del Dia por: " + e.Message);
                            if (QuiereContinuar())
                            {
                                MenuCajero(ref opcion, productos, ventas, cajero, cliente);
                            }
                        }

                        Console.ReadKey();
                        ///---> SIN limpiar la variable opcionC, me devuelve al MAIN para salir de los menues y cerrar la consola =) 

                        break;
                    case 4: ///////////// "VOLVER AL MENU PRINCIPAL" ////////////////////
                        Console.Clear();
                        opcion = 0;
                        break;
                }
            } while (opcionC != 1 && opcionC != 2 && opcionC != 3 && opcionC != 4);
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
