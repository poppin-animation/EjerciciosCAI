using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Expendedora.Biblioteca.Negocio;
using Cuatri2021.Expendedora.Biblioteca.Validador;
using Cuatri2021.Expendedora.Biblioteca.Exceptions;
using Cuatri2021.Expendedora.Biblioteca;



namespace Cuatri2021.Expendedora.Consola
{
    public static class Program
    {
        static void Main(string[] args)
        {

            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;

            // menú que se va a mostrar luego de CADA acción
            string menu = "¿Que desea hacer?: \n" +
                $"0 - Encender la máquina Expendedora \n" +
                $"1 - Listar Latas Disponibles \n" +
                $"2 - Agregar Lata \n" +
                $"3 - Extraer Lata \n" +
                $"4 - Conocer el Balance \n" +
                $"5 - Conocer el Stock Disponible \n" +
                $"X - Salir de la Aplicación";


            // Creo el objeto con el que voy a trabajar en este programa
            Eexpendedora expendedora = new Eexpendedora();

            // pantalla de bienvenida
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese una tecla para continuar.");
            Console.ReadKey();
            do
            {
                Console.Clear();
                //METER ACA EL TRY 
                Console.WriteLine(menu); //mostramos el menú


                string opcionSeleccionada = Console.ReadLine();//capturamos la seleccion
                                                               // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.


                String[] opcionesValidas = new String[] { "0", "1", "2", "3", "4", "5", "X" };

                if (opcionSeleccionada.ToUpper() == "X")
                {
                    continuarActivo = false;
                    continue;
                }
                else if (Validador.isInt32(opcionSeleccionada) == true)
                {
                    switch (opcionSeleccionada)
                    {
                        case "0":
                            // Encender la máquina Expendedora \n" + 
                            Program.EncenderMaquina(expendedora);

                            break;
                        case "1":
                            // $"1 - Listar Latas Disponibles \n" +
                            Program.ListarLatas(expendedora);

                            break;
                        case "2":
                            //  $"2 - Agregar Lata \n" +
                            Program.IngresarLata(expendedora);

                            break;
                        case "3": ////  $"3 - Extraer Lata \n" +
                            Program.ExtraerLata(expendedora);

                            break;
                        case "4":
                            // $"4 - Conocer el Balance \n" +
                            Program.ObtenerBalance(expendedora);

                            break;
                        case "5":
                            //$"5 - Conocer el Stock Disponible \n" +
                            Program.MostrarStock(expendedora);

                            break;
                        case "6":
                            //Agregar datos de prueba
                            AgregarDatos(expendedora);

                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                // Console.Clear();
            }
            while (continuarActivo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }


        private static void EncenderMaquina(Eexpendedora expendedora)
        {
            expendedora.EncenderMaquina();
            Console.WriteLine("La maquina ha sido correctamente encendida.");

        }

        private static void ListarLatas(Eexpendedora expendedora)
        {
            if (expendedora.EstaVacia() == true)
            {
                Console.WriteLine("La máquina expendedora se encuentra vacía. Ingrese productos para continuar.");
                //Console.ReadKey();
            }
            else
            {
                foreach (Lata l in expendedora.Latas)
                {
                    if(l.Cantidad != 0)
                    {
                        Console.WriteLine(l.ToString());
                    }
                    
                }


            }


        }
        private static void IngresarLata(Eexpendedora expendedora)
        {
            Console.Clear();
            if(expendedora.Encendida == true)
            {
                try
                {
                    Console.WriteLine("Ingrese el CODIGO de la Lata a ingresar");
                    string codigo = Validador.ValidarString();
                    //Validar Que no exista ya el codigo:

                    Console.WriteLine("Ingrese el NOMBRE de la Lata a ingresar");
                    string nombre = Validador.ValidarString();

                    Console.WriteLine("Ingrese el SABOR de la Lata a ingresar");
                    string sabor = Validador.ValidarString();

                    Console.WriteLine("Ingrese el PRECIO de la Lata a ingresar");
                    double precio = Validador.ValidarDouble();

                    Console.WriteLine("Ingrese el VOLUMEN de la Lata a ingresar");
                    double volumen = Validador.ValidarDouble();

                    Console.WriteLine("Ingrese la CANTIDAD de la Lata a ingresar");
                    int cantidad = Validador.ValidarIntPositivo();

                    Lata l = new Lata(codigo, nombre, sabor, precio, volumen, cantidad);
                    expendedora.AgregarLata(l);
                }
                catch (Exception)
                {

                }
            }
            else
            {
                Console.WriteLine("La máquina expendedora se encuentra apagada. Enciénda la Máquina para continuar.");
                //Console.ReadKey();
            }


        }


        private static void ExtraerLata(Eexpendedora expendedora)
        {
            Console.Clear();
            if (expendedora.Encendida == true)
            {
                //Se le listan los códigos de las latas(include CU 1)
                Console.WriteLine("Las Latas disponibles son las siguientes");
                Program.ListarLatas(expendedora);
                 
                //La lata es seleccionada mediante un código que ingresa el usuario.
                Console.WriteLine("Ingrese el CODIGO de la Lata a extraer");
                string codigo = Validador.ValidarString();
                //int cantidad = 1;

                //El Usuario ingresa dinero que tiene.
                Console.WriteLine("Ingrese el DINERO para abonar la Lata");
                double dinero = Validador.ValidarDouble();

                try
                {
                    Lata extraida = expendedora.ExtraerLata(codigo, dinero);
                    Console.WriteLine($"Se ha extraído correctamente la Lata: " + extraida.ToString());
                    

                }
                catch (CodigoInvalidoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (SinStockException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DineroInsuficienteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No es posible extraer la lata solicitada." + ex.Message);
                }

            }
            else
            {
                Console.WriteLine("La máquina expendedora se encuentra apagada. Enciénda la Máquina para continuar.");
                //Console.ReadKey();
            }
        }


        private static void ObtenerBalance(Eexpendedora expendedora)
        { 

        }


        private static void MostrarStock(Eexpendedora expendedora)
        {

        }


        // ---> SWITCH 10
        private static void AgregarDatos(Eexpendedora expendedora)
        {
            Lata l1 = new Lata("0001", "Coca Cola", "Cola", 50, 340, 100);
            Lata l2 = new Lata("0002", "Coca Cola", "Cola", 100, 500, 75);
            Lata l3 = new Lata("0003", "Coto Cola", "Cola", 25, 500, 250);
            expendedora.AgregarLata(l1);
            expendedora.AgregarLata(l2);
            expendedora.AgregarLata(l3);



        }







    }


}
