using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Presentismo.Biblioteca.Utilidades
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

                Console.Clear();
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

        public static double ValidarDoublePositivo()
        {
            double numero;
            bool valido = false;
            do
            {
                if (!double.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, 
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

        /// <summary>
        /// Solicita un entero y valida también que se encuentre entre min y max
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static int PedirNumero(string mensaje, int min, int max)
        {
            int salida;
            Console.Write(mensaje + ": ");
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out salida)) // que no permita ingresar letras y simbolos, solo numeros, 
                {
                    Console.WriteLine("Debe ingresar un número.");

                }
                else if (salida < min || salida > max) /// que el numero a ingresar sea igual o mayor al minimo, nunca menor
                {
                    Console.WriteLine($"El número debe estar entre {min} y {max}.");

                }
                else
                {
                    valido = true;
                }

                //Console.Clear();
            } while (valido == false);
            return salida;


        }







        /// <summary>
        /// Solicita dia mes y año y devuelve una fecha
        /// </summary>
        /// <returns></returns>
        public static DateTime PedirFecha()
        {
            int numero1, numero2, numero3;
            numero3 = PedirNumero("Ingrese un año", 1, 2021);
            numero2 = PedirNumero("Ingrese un mes", 1, 12);
            if(numero2 == 2)
            {
                numero1 = PedirNumero("Ingrese un día", 1, 28);
            }
            else
            {

                numero1 = PedirNumero("Ingrese un día", 1, 31);
            }

            DateTime fecha = new DateTime(numero3, numero2, numero1);
            return fecha;
        }

        public static DateTime PedirFechaBis()
        {
           
                int numero1, numero2, numero3;
                numero3 = PedirNumero("Ingrese un año", 1, 2021);
                numero2 = PedirNumero("Ingrese un mes", 1, 12);
                if (numero3 % 4 == 0 && numero3 % 100 != 0 || numero3 % 400 == 0)
                {
                    //Console.WriteLine("Es bisiesto {0}\n", numero3);
                    if (numero2 == 2)
                    {
                        numero1 = PedirNumero("Ingrese un día", 1, 29);
                    }
                    else if (numero2 == 1 || numero2 == 3 || numero2 == 5 || numero2 == 7 || numero2 == 8 || numero2 == 10 || numero2 == 12)
                    {

                        numero1 = PedirNumero("Ingrese un día", 1, 31);
                    }
                    else
                    {
                        numero1 = PedirNumero("Ingrese un día", 1, 30);
                    }
                }
                else
                {
                    //Console.WriteLine("no es bisiesto {0} \n", numero3);
                    if (numero2 == 2)
                    {
                        numero1 = PedirNumero("Ingrese un día", 1, 28);
                    }
                    else if (numero2 == 1 || numero2 == 3 || numero2 == 5 || numero2 == 7 || numero2 == 8 || numero2 == 10 || numero2 == 12)
                    {

                        numero1 = PedirNumero("Ingrese un día", 1, 31);
                    }
                    else
                    {
                        numero1 = PedirNumero("Ingrese un día", 1, 30);
                    }
                }
            DateTime fecha = new DateTime(numero3, numero2, numero1);
            return fecha;
        }

        public static string PedirFechaString(string mensaje)
        {
            Console.WriteLine(mensaje);
            string fecha = "";
            fecha += PedirNumero("Ingrese un año", 1900, 2021) + "-"; 
            fecha += PedirNumero("Ingrese un mes", 1, 12) + "-";
            fecha += PedirNumero("Ingrese un día", 1, 31);

            return fecha;
        }

        
        public static bool PedirSN()
        {

            string salida;
            do
            {
                Console.Write("Ingrese 'S' por SI o 'N' por NO: ");
                salida = ValidarString();

            } while (salida.ToUpper() != "S" && salida.ToUpper() != "N");

            return salida.ToUpper() == "S";



        }

        /// <summary>
        /// Solicita ingreso de S o N para ver si el usuario quiere continuar 
        /// lo que se esta realizando
        /// </summary>
        /// <returns></returns>
        internal static string QuiereReintentar()
        {
            string salida;
            do
            {
                Console.Write("Desea reintentar? Ingrese S o N: ");
                salida = ValidarString();
            } while (salida.ToUpper() != "S" && salida.ToUpper() != "N");

            return salida.ToUpper();
        }
        public static void Continuar()
        {
            Console.Write("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        public static string ConvertirFecha(DateTime date)
        {
            //DateTime thisDate1 = new DateTime(2011, 6, 10);
            DateTime thisDate = date;
            return $"{thisDate.ToString("yyyy - MM - dd")}";

            //DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
            //                                              TimeSpan.Zero);
            //Console.WriteLine("The current date and time: {0:MM/dd/yy H:mm:ss zzz}",
            //                   thisDate2);
        }


        internal static bool QuiereContinuar() //El modificador internal indica que aquellos miembros o tipos que se hayan definido con este modificador de acceso
                                               ////sólo serán accesibles desde los archivos del mismo ensamblado.
        {
            string salida;
            do
            {
                Console.Write("Desea continuar? Ingrese S o N: ");
                salida = ValidarString();
            } while (salida.ToUpper() != "S" && salida.ToUpper() != "N");

            return salida.ToUpper() == "S";
        }

        public static DateTime ValidarFecha(string mensaje)
        {
            DateTime fecha;
            do
            {
                Console.WriteLine(mensaje);
                if (!DateTime.TryParse(Console.ReadLine(), out fecha))
                {
                    Console.WriteLine("Dato invalido");
                }


            } while (!DateTime.TryParse(Console.ReadLine(), out fecha));

            return fecha;
        }


        public static string BoolSiNo(bool valor)
        {
            
                if (valor == true)
                {
                    return "SI";
                }
                else
                {
                    return "NO";
                }
            
        }




        /// <summary>
        ///CALCULAR DIFERENCIA DE FECHAS EN AÑOS.  POR EDAD. si cumplio o no los años ya 
        ///        ///
        /// </summary>
        /// <param name="fecha1"> es la fecha mas grande, la actual, el dia de hoy. o la fecha de despido par ala antiguedad</param>
        /// <param name="fecha2"> es la fehca inicial, de nacimiento, la mas antigua</param>
        /// <returns></returns>
        public static int Edad(DateTime fechaInicial, DateTime fechaFinal)
        {

            if ((fechaFinal.Month >= fechaInicial.Month) && (fechaFinal.Day >= fechaInicial.Day))
            {
                return (fechaFinal.Year - fechaInicial.Year);

            }
            else
            {
                return (fechaFinal.Year - fechaInicial.Year - 1);
            }

        }


        /// <summary>
        /// calculo de diferencia de fechas. al numero devuelto, se le calcula 
        /// Double segundos = dateDiff.TotalSeconds;
        ///Double minutos = dateDiff.TotalMinutes;
        ///Double horas = dateDiff.TotalHours;
        ///int dias = dateDiff.Days;
        ///int años = dateDiff.Year;
        /// </summary>
        /// <param name="fechaInicial"></param>
        /// <param name="fechaFinal"></param>
        /// <returns></returns>
        public static TimeSpan DateDiff(DateTime fechaInicial, DateTime fechaFinal)
        {
            TimeSpan datediff = fechaFinal - fechaInicial;
            return datediff;
        }














    }
}
