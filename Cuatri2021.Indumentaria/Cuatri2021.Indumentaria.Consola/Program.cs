using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Indumentaria.Biblioteca.Entidades;
using Cuatri2021.Indumentaria.Biblioteca.Excepciones;
using Cuatri2021.Indumentaria.Biblioteca.Enumeradores;
using Cuatri2021.Presentismo.Biblioteca.Utilidades;






namespace Cuatri2021.Indumentaria.Consola
{
    static class Program
    {




        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;


            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar Indumentarias \n" +
                "2) Agregar Indumentaria \n" +
                "3) Modificar Indumentaria \n" +
                "4) Eliminar Indumentaria \n" +
                "5) Listar Ordenes \n" +
                "6) Ingresar Orden \n" +
                "7) Devolver Orden \n" +
                "X: Cerrar el Programa";

            // Creo el objeto con el que voy a trabajar en este programa
            TiendaRopa tienda = new TiendaRopa();


            Console.WriteLine("Bienvenidos al Programa de Indumentaria. Que desea hacer?");
            do
            {
                Console.WriteLine(menu);
                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.

                //String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7", "X" };

                if (opcionSeleccionada.ToUpper() == "X")
                {
                    continuarActivo = false;
                    continue;
                }
                switch (opcionSeleccionada)
                {
                    case "1": //- Listar Indumentarias (GetDetalle())
                        Program.ListarIndumentaria(tienda);
                        break;
                    case "2":  //- Agregar Indumentaria(por defecto cada indumentaria ingresa con 3 de stock)
                        Program.AgregarIndumentaria(tienda);
                        break;
                    case "3":   //- Modificar Indumentaria
                        Program.ModificarIndumentaria(tienda);
                        break;
                    case "4":    //- Eliminar Indumentaria
                        Program.EliminarIndumentaria(tienda);
                        break;
                    case "5":   //- Listar ordenes(con el formato "codigo) Apellido, Nombre Cliente, cantidad prendas, $ total pedido"
                        Program.ListarOrdenes(tienda);
                        break;
                    case "6":   //- Ingresar Orden(debe restar stock de la prenda seleccionada)
                        Program.IngresarOrden(tienda);
                        break;
                    case "7":   //- Devolver Orden
                        Program.DevolverOrden(tienda);
                        break;
                    default:
                        Console.WriteLine("Opción Inválida.");
                        break;

                }
                Validador.Continuar();
                //Console.ReadKey();
                Console.Clear();



            } while (continuarActivo == true);
            Console.WriteLine("Gracias por usar el programa.");
            Console.ReadKey();

        }


        public static void ListarIndumentaria(TiendaRopa tienda)
        {
            try
            {
                foreach (Indumentariaa indu in tienda.Listar())
                {
                    Console.WriteLine(indu.GetDetalle());
                    
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AgregarIndumentaria(TiendaRopa tienda)
        {
            try
            {
                Indumentariaa indu1;
                Console.WriteLine("¿Desea agregar una CAMISA? Si elige NO se ingresará un PANTALON");
                if (Validador.PedirSN() == true)
                {
                    Console.WriteLine("Ingrese la cantidad");
                    int stock = Validador.ValidarIntPositivo();
                    Console.WriteLine("Ingrese el talle");
                    string talle = Validador.ValidarString();
                    Console.WriteLine("Ingrese la cantidad");
                    double precio = Validador.ValidarDoublePositivo();
                    indu1 = new Camisa(stock);
                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad");
                    int stock = Validador.ValidarIntPositivo();
                    indu1 = new Pantalon(stock);
                }

                tienda.Agregar(indu1);
                Console.WriteLine($"Se ha agregado correctamente la prenda {indu1.GetDetalle()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }

        public static void ModificarIndumentaria(TiendaRopa tienda)
        {
            Console.Clear();
            Console.WriteLine("La siguiente lista de Indumentarias se encuentra en Sistema: ");
            ListarIndumentaria(tienda);
            try
            {
                bool continuar = true;
                Console.WriteLine("Ingrese el código de la Prenda que desea Modificar: ");
                int codigo = Validador.ValidarInt();
                Indumentariaa indu = tienda.Seleccionar(codigo);
                Console.WriteLine("la prenda seleccionada es la siguiente: \n" + indu.GetDetalle());

                do
                {
                    Console.Clear();
                    Console.WriteLine("¿Qué desea modificar? \n" +
                     "1) Tipo de Indumentaria \n" +
                     "2) Stock \n" +
                     "3) Talle \n" +
                     "4) Precio \n" +
                     "X: Terminar las Modificaciones");
                    string opcionSelecc = Validador.ValidarString();
                   
                    if (opcionSelecc.ToUpper() == "X")
                    {
                        //   "X: Volver sin modificar");
                        continuar = false;
                        continue;
                    }
                    switch (opcionSelecc)
                    {
                        case "1": //- "1) Tipo de Indumentaria \n" +
                            Console.WriteLine($"El Tipo de Indumentaria NO se puede modificar");
                            Console.ReadKey();
                            break;

                        case "2":  //-  "2) Stock \n" +
                            Console.WriteLine($"El Stock de Esta Prenda es de {indu.Stock}");
                            Console.WriteLine("Desea modificarlo?");
                            if (Validador.PedirSN() == true)
                            {
                                Console.WriteLine("Ingresar el Stock Actualizado:");
                                indu.Stock = Validador.ValidarIntPositivo();

                            }
                            
                            break;
                        case "3":   //- "3) Talle \n" +
                            Console.WriteLine($"El talle de Esta Prenda es de {indu.Talle}");
                            Console.WriteLine("Desea modificarlo?");
                            if (Validador.PedirSN() == true)
                            {
                                Console.WriteLine("Ingresar el Talle Actualizado:");
                                indu.Talle = Validador.ValidarString();

                            }


                            break;
                        case "4":    //"4) Precio \n" +
                            Console.WriteLine($"El Precio de Esta Prenda es de $ {indu.Precio}.-");
                            Console.WriteLine("Desea modificarlo?");
                            if (Validador.PedirSN() == true)
                            {
                                Console.WriteLine("Ingresar el Precio Actualizado:");
                                indu.Precio = Validador.ValidarDoublePositivo();

                            }

                            break;
                        default:
                            Console.WriteLine("Opción Inválida.");
                            break;

                    }
                    Validador.Continuar();
                   // Console.ReadKey();
                    Console.Clear();
                } while (continuar == true);
                tienda.Modificar(indu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void EliminarIndumentaria(TiendaRopa tienda)
        {
            Console.WriteLine("La siguiente lista de Indumentarias se encuentra en Sistema: ");
            ListarIndumentaria(tienda);

            try
            {
                Console.WriteLine("Ingrese el código de la Prenda que desea eliminar: ");
                int codigo = Validador.ValidarInt();
                Indumentariaa indu = tienda.Seleccionar(codigo);
                tienda.Quitar(indu);
            }
            catch(SinStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void ListarOrdenes(TiendaRopa tienda)
        {
            try
            {
                foreach (Venta venta in tienda.ListarOrden())
                {
                    Console.WriteLine($"{venta.Codigo}) {venta.Cliente.Apellido}, {venta.Cliente.Nombre} , cantidad prendas: {venta.Items.Count()}, ${venta.GetTotalPedido()} total pedido");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        public static void IngresarOrden(TiendaRopa tienda)
        {

            try
            {
                Venta venta1;
                Console.WriteLine("¿Desea Ingresar una Orden de Venta");
                if (Validador.PedirSN() == true)
                {
                    venta1 = new Venta();
                    Console.WriteLine("por favor ingresar el Apellido del Cliente");
                    venta1.Cliente.Apellido = Validador.ValidarString();
                    Console.WriteLine("por favor ingresar el Nombre del Cliente");
                    venta1.Cliente.Nombre = Validador.ValidarString();
                    ///
                    ///REVISAR QUE ESTA HACIENDO MAL, SEGURO ES EL DOWHILE... PERO FIJARSE COMO ARREGLARLO PARA PODER AGREGAR MAS DE UN ITEM
                    ///POR OTRO LADO, QUE NO SE PUEDA AGREGAR MAS DE UN MISMO ITEM... DEBERIA CREAR UNA SUBLISTA NO ?  PARA IR CHEQUEANDO  ?
                    ///REVISAR TODO. AL MENSO AGREGA LAS LISTAS OK. 
                    ///TAMBIEN ME FALTA EL METODO DE DEVOLVER. 
                    ///EL QUE RESTE STOCK DE LO LISTADO 
                    ///QUE LOS GETDETALLE DE LAS ROPAS ME MUESTRE EL STOCK
                    ///QUE CAMBIE EL ESTADO DE LAS ORDENES DE VENTA ! ! ! 
                    
                    do
                    {
                        Console.WriteLine("las prendas disponibles son las siguientes:");
                        Program.ListarIndumentaria(tienda);
                        Console.WriteLine("por favor ingresar el código de la Prenda");
                        int codigo1 = Validador.ValidarIntPositivo();
                        Indumentariaa indu1 = tienda.Seleccionar(codigo1);
                        Console.WriteLine("por favor ingresar la cantidad de Prendas");
                        int cantidad = Validador.ValidarIntPositivo();
                        VentaItem item = new VentaItem(cantidad, indu1);
                        venta1.Items.Add(item);
                        Console.WriteLine("¿Desea Agregar un nuevo item?");
                    } while (Validador.PedirSN() == true);
                    tienda.IngresarOrden(venta1);
                    Console.WriteLine($"Se ha agregado correctamente la Orden {venta1.Codigo}");
                    Console.WriteLine($"{venta1.Codigo}) {venta1.Cliente.Apellido}, {venta1.Cliente.Nombre} , cantidad prendas: {venta1.Items.Count()}, ${venta1.GetTotalPedido()} total pedido");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        public static void DevolverOrden(TiendaRopa tienda)
        {


        }



    }

}
