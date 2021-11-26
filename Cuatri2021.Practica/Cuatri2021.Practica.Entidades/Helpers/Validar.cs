using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Entidades
{

    public static class Validar
    {
        public static string usuario = "/892293";


        public static string BoolSiNo(bool Dato)
        {
                if (Dato)
                {
                    return "ACTIVO";
                }
                else
                {
                    return "INACTIVO";
                }
        }

        public static void ValidarCuit(long cuit)
        {
                if (cuit.ToString().Length != 11)
                
                    throw new Exception("El CUIT tiene que ser de 11 dígitos");
                
        }

        public static void ValoresMinMax(int min, int max, string text) //---------------------------------INT
        {
            int numero = Convert.ToInt32(text);
            if (numero < min || numero > max) /// que el numero a ingresar sea igual o mayor al minimo, nunca menor
                throw new Exception($"El Valor Ingresado tiene que estar entre {min} y {max}");
        }

        public static void ValoresMinMax(double min, double max, string text) //---------------------------------DOUBLE
        {
            double numero = Convert.ToInt32(text);
            if (numero < min || numero > max) /// que el numero a ingresar sea igual o mayor al minimo, nunca menor
                throw new Exception($"El Valor {text} tiene que estar entre {min} y {max}");
        }

        public static void ValidarIntPositivo(string text) //---------------------------------INT
        {
            int numero = Convert.ToInt32(text);
            if (numero <= 0) /// que el numero a ingresar sea mayor a 0. 
                throw new Exception($"El Valor {text} no puede ser negativo");
        }

        public static void ValidarDoublePositivo(double min, double max, string text) //---------------------------------DOUBLE
        {
            double numero = Convert.ToInt32(text);
            if (numero <= 0) //// que el numero a ingresar sea mayor a 0. 
                throw new Exception($"El Valor {text} no puede ser negativo");
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


        public static int Edad(DateTime date1) 
        {
                int edad;
                edad = (DateTime.Today - date1).Days / 365;
                //(la fecha de hoy, menos la fecha de nacimiento) en dias.... dividido 365 para calcular años.
                return edad;
        }

        public static int AñosSpan(DateTime date1, DateTime date2)
        {
            int años;
            años = (date2 - date1).Days / 365;
            //(la fecha de hoy, menos la fecha de nacimiento) en dias.... dividido 365 para calcular años.
            return años;
        }
        public static int DiasSpan(DateTime date1, DateTime date2)
        {
            int dias;
            dias = (date2 - date1).Days ;
             return dias;
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

    }
    











}

