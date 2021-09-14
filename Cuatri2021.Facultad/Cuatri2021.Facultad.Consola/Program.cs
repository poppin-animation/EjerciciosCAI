using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Facultad.Biblioteca;
using Cuatri2021.Facultad.Biblioteca.Utilidades;



namespace Cuatri2021.Facultad.Consola
{
    class Program
    {



        static bool _consolaActiva;
        static Facultad _facultad;

        static Program()
        {
            _consolaActiva = true;
            _veterinaria = new TiendaMascotas("Santa Elena", "Monroe 900");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenida a la veterinaria " + _veterinaria.Nombre);

            while (_consolaActiva)
            {


                Console.Clear();
                DesplegarMenu();
                string opcionMenu = Console.ReadLine();

                switch (opcionMenu.ToLower())
                {
                    case "1":
                        // Lista fichas de la veterinar
                        ListarFichas();
                        break;
                    case "2":
                        // Agregar una ficha
                        AgregarFicha();
                        break;
                    case "x":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadLine();

            }


        }

    }
}
