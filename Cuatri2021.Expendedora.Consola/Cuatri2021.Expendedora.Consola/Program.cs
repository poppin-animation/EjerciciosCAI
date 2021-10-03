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
            Eexpendedora expendedora  = new Eexpendedora();

            // pantalla de bienvenida
            Console.WriteLine("Bienvenido");
            do
            {
                //METER ACA EL TRY 
                Console.WriteLine(menu); //mostramos el menú
                                         //capturamos la seleccion

                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.

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
                Console.Clear();
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
            if(expendedora.EstaVacia() == true)
            {
                Console.WriteLine("La máquina expendedora se encuentra vacía. Ingrese productos para continuar.");
            }
            else
            {
                Console.WriteLine(expendedora.Latas.ToString());
            }

        }
        private static void IngresarLata(Eexpendedora expendedora)
        {


        }


        private static void ExtraerLata(Eexpendedora expendedora)
        {

        }

        private static void ObtenerBalance(Eexpendedora expendedora)
        {
        }


        private static void MostrarStock(Eexpendedora expendedora)
        {
        }


    }


}
