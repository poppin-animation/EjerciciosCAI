using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Calculadora.Validador
{
    public static class Valida
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
                else if (opcion < 0 || opcion > cantidadOpciones)
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

        public static double ValidarDoublePositivo()
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
                else if (numero < 0)
                {
                    Console.WriteLine("Ingrese un número mayor a cero.");
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

        public static double ValidarDoubleNoCero()
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
                else if (numero == 0)
                {
                    Console.WriteLine("Ingrese un número distinto de cero.");
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
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, y que acepte decimales. 
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
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, y que acepte decimales. 
                {
                    Console.WriteLine("Debe ingresar un número.");
                    Console.ReadKey();
                }
                else if (numero <= 0)
                {
                    Console.WriteLine("Ingrese un número mayor a cero.");
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

        public static int ValidarIntPositivoCero()
        {
            int numero;
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, y que acepte decimales. 
                {
                    Console.WriteLine("Debe ingresar un número.");
                    Console.ReadKey();
                }
                else if (numero < -1)
                {
                    Console.WriteLine("Debe ingresar un numero positivo, o Cero.");
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

        public static int ValidarIntNoCero()
        {
            int numero;
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero)) // que no permita ingresar letras y simbolos, solo numeros, y que acepte decimales. 
                {
                    Console.WriteLine("Debe ingresar un número.");
                    Console.ReadKey();
                }
                else if (numero == 0)
                {
                    Console.WriteLine("Ingrese un número distinto de cero.");
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







        public static double ValidarCapital(int i)
        {
            double capital;
            bool valido = false;
            do
            {
                Console.WriteLine($"Ingrese el Capital Inicial para el Jugador N° { i + 1}:");

                if (!double.TryParse(Console.ReadLine(), out capital)) // que no permita ingresar letras y simbolos, solo numeros. 
                {
                    Console.WriteLine("El Capital debe ser un número.");
                    Console.ReadKey();
                }
                else
                {
                    if (capital < 0)                     //numero menor a cero, significa que no tiene capital para apostar. . .
                    {
                        Console.WriteLine("El Capital debe ser Mayor a Cero.");
                        Console.ReadKey();
                    }
                    else
                    {
                        valido = true;
                    }
                }

                Console.Clear();
            } while (!valido);
            return capital;
        }

        public static Tuple<string, double, int> ResultadoMayor(int randomSecond, int randomFirst, double apostarCapital, int opcionMM, double saldo)
        {
            string resultado;
            double nuevoSaldo;
            int ganancia;
            Console.WriteLine($"El segundo número es: {randomSecond}");
            if (randomSecond > randomFirst)  /* GANASTE =   recibe lo DOBLE (para normal) eel TRIPLE (para intermedio) o el CUADRUPLE (para dificil) de lo apostado */
            {
                nuevoSaldo = saldo + (apostarCapital * (opcionMM + 1));
                ganancia = (opcionMM + 1);
                resultado = "GANASTE";
            }
            else if (randomSecond == randomFirst) /* NO GANA NI PIERDE =   recibe lo apostado */
            {
                nuevoSaldo = saldo + (apostarCapital * 1);
                ganancia = 1;
                resultado = "FUE UN EMPATE";
            }
            else /* (randomSecond < randomFirst)   PERDISTE  =   no gana nada */
            {
                resultado = "PERDISTE";
                ganancia = 0;
                nuevoSaldo = saldo;
            }
            return new Tuple<string, double, int>(resultado, nuevoSaldo, ganancia);
        }

        public static Tuple<string, double, int> ResultadoMenor(int randomSecond, int randomFirst, double apostarCapital, int opcionMM, double saldo)
        {
            string resultado;
            double nuevoSaldo;
            int ganancia;
            Console.WriteLine($"El segundo número es: {randomSecond}");
            if (randomSecond < randomFirst)  /* GANASTE =   recibe lo DOBLE (para normal) eel TRIPLE (para intermedio) o el CUADRUPLE (para dificil) de lo apostado */
            {
                nuevoSaldo = saldo + (apostarCapital * (opcionMM + 1));
                ganancia = (opcionMM + 1);
                resultado = "GANASTE";
            }
            else if (randomSecond == randomFirst) /* NO GANA NI PIERDE =   recibe lo apostado */
            {
                nuevoSaldo = saldo + (apostarCapital * 1);
                ganancia = 1;
                resultado = "FUE UN EMPATE";
            }
            else /* (randomSecond > randomFirst)   PERDISTE  =   no gana nada */
            {
                resultado = "PERDISTE";
                ganancia = 0;
                nuevoSaldo = saldo;
            }
            return new Tuple<string, double, int>(resultado, nuevoSaldo, ganancia);
        }

        public static int VarRandom(int min, int max)
        {
            var random = new Random();
            int rand = random.Next(min, max);

            return rand;
        }


        public static double ValidarApuesta(double saldo)
        {
            double apuesta;
            bool valido = false;
            do
            {
                Console.WriteLine($"Ingrese el Capital que desea Apostar:");
                if (!double.TryParse(Console.ReadLine(), out apuesta)) // que no permita ingresar letras y simbolos, solo numeros. 
                {
                    Console.WriteLine("El Capital debe ser un número.");
                }
                else
                {
                    if (apuesta > saldo)   //numero menor AL CAPITAL FINAL, significa que no tiene capital para apostar. . .
                    {
                        Console.WriteLine("No dispone de Saldo suficiente.");
                    }
                    else if (apuesta < 0) /// no pueden apostar numeros negativos ! 
                    {
                        Console.WriteLine("La apuesta no puede ser negativa.");
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            return apuesta;
        }












        public static long PedirLong()
        {
            long numero;
            bool valido = false;
            string mensaje = "Debe ingresar un numero.";

            do
            {
                Console.WriteLine(mensaje);
                if (!long.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine(mensaje);
                }
                else
                {
                    valido = true;
                }
            } while (!valido);

            return numero;
        }

        public static void MostrarNumero(long num) ///solo devuelve un texto 
        {
            Console.WriteLine("El numero es " + num);
            Console.ReadKey();
        }

        public static void ModificarNumero(ref long num) ///le paso una variable numerica long, llamo a la funcion PedirLong, y modifica la variable que le estoy pasando en main. 
        {
            num = PedirLong();
        }

        public static void NoModificarNumero(long num)  /////le paso una variable numerica long, llamo a la funcion PedirLong, y NOOO modifica la variable que le pase en main.
        {
            num = PedirLong();
        }





    }
}
