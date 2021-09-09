using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.SextaClase.Biblioteca;

namespace Cuatri2021.SextaClase.Consola
{
    class Program
    {

        static bool _consolaActiva;
        static VentaRepuestos _ventaRepuestos;

        static Program()
        {
            _consolaActiva = true;
            _ventaRepuestos = new VentaRepuestos("Mi Tienda", "Gascon 797");
        }

        static void Main(string[] args)
        {

            Console.WriteLine($"Bienvenid@ a la Tienda de Repuestos {_ventaRepuestos.Nombre}.");

            while (_consolaActiva == true)
            {
                DesplegarMenu();
                int opcion = Validador.ValidarOpcion(3);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");


                        break;
                    case 2:                       
                        Console.Clear();
                        Console.WriteLine("");


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("");


                        break;
                    default:
                        Console.WriteLine("La opción es inválida");
                        Console.ReadLine();


                        break;

                }

            }
        }

        static void DesplegarMenu()
        {
            Console.Clear(); //limpio la pantalla. 
            Console.WriteLine("Bienvenido al MENU");
            Console.WriteLine("¿Que desea hacer?: \n" +
            $"1 -  \n" +
            $"2 -  \n" +
            $"3 - ");
            
        }





    }
}
