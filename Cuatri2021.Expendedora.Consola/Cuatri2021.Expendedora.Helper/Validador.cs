using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Expendedora.Biblioteca.Validador
{
    public static class Validador
    {

        public static int ValidarOpcion(int cantidadOpciones)
        {
            int opcion;
            bool valido = false;
            do
            {
                //Console.WriteLine(opcion);
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar el número de la opcion. ");
                }
                else if (opcion <= 0 || opcion > cantidadOpciones)
                {
                    //Console.WriteLine(opcion); 
                    Console.WriteLine("Ingrese un número válido de opcion.");
                }
                else
                {
                    //Console.WriteLine(opcion);
                    valido = true;
                }
                //Console.Clear();
            } while (valido == false);

            //Console.WriteLine(opcion);
            return opcion;
        }

        public static bool isInt32(String num)
        {
            try
            {
                Int32.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static double ValidarDouble()
        {
            double numero;
            bool valido = false;
            do
            {
                if (!double.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, y que acepte decimales. 
                {
                    Console.WriteLine("Debe ingresar un número.");
                    Console.ReadKey();
                }
                else
                {
                    valido = true;
                }

                //Console.Clear();
            } while (!valido);
            return numero;
        }

        public static int ValidarInt()
        {
            int numero;
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros
                {
                    Console.WriteLine("Debe ingresar un número.");
                    Console.ReadKey();
                }
                else
                {
                    valido = true;
                }
                Console.Clear();
            } while (!valido);
            return numero;
        }

        public static int ValidarIntPositivo()
        {
            int numero;
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, 
                {
                    Console.WriteLine("Debe ingresar un número.");
                    // Console.ReadKey();
                }
                else if (numero <= 0) // tiene que ser mayor a cero
                {
                    Console.WriteLine("Ingrese un número mayor a cero.");
                    // Console.ReadKey();
                }
                else
                {
                    valido = true;
                }
                //Console.Clear();
            } while (!valido);
            return numero;
        }


        public static int ValidarMinMax(int min, int max)
        {
            int numero;
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, 
                {
                    Console.WriteLine("Debe ingresar un número.");

                }
                else if (numero < min || numero > max) /// que el numero a ingresar sea igual o mayor al minimo, nunca menor
                {
                    Console.WriteLine($"El número debe estar entre {min} y {max}.");

                }
                else
                {
                    valido = true;
                }

                //Console.Clear();
            } while (valido == false);
            return numero;
        }


        public static string ValidarString()
        {
            bool valido = false;
            string texto;
            do
            {

                texto = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty(texto))
                {
                    Console.WriteLine("Ingrese un texto.");

                }
                else if (texto == " ")
                {
                    Console.WriteLine("El texto no puede ser vacio. ");

                }
                else
                {
                    valido = true;
                }
                //Console.ReadKey();

            } while (!valido);

            return texto;
        }
    }
}
