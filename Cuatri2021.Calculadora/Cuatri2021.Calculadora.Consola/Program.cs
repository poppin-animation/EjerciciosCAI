using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Calculadora.Validador;


namespace Cuatri2021.Calculadora.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            int opcionNormal;
            int opcionRecursiva;
            double num1;
            double num2;
            int numero1;
            int numero2;
            double resultado;

            do ///////////////INICIO MENU PRINCIPAL/////////////
            {
                resultado = 0;
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("Elija la Calculadora que desea Utilizar");
                Console.WriteLine("1 - NORMAL");
                Console.WriteLine("2 - RECURSIVA");
                Console.WriteLine("3 - FINALIZAR");

                opcion = Valida.ValidarOpcion(3);
                Console.Clear();

                switch (opcion)
                {
                    case 1: ///////////////CALCULADORA NORMAL/////////////
                        do
                        {
                            resultado = 0;
                            Console.WriteLine("CALCULADORA NORMAL");
                            Console.WriteLine("Elija la operación que desea realizar");
                            Console.WriteLine("1 - SUMA");
                            Console.WriteLine("2 - RESTA");
                            Console.WriteLine("3 - MULTIPLICACIÓN");
                            Console.WriteLine("4 - DIVISIÓN");
                            Console.WriteLine("5 - VOLVER AL MENU PRINCIPAL");
                            //eSTO SE PODRIA HACER CON UNA LISTA ! Y USAR EL VALOR DEL LENGTH DE LA LSITA ! REVISAR :) 

                            opcionNormal = Valida.ValidarOpcion(5);
                            Console.Clear();

                            switch (opcionNormal)
                            {
                                case 1:/// SUMA NORMAL ///
                                    Console.WriteLine("Ingrese el primer número");
                                    num1 = Valida.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    num2 = Valida.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {num1} y el segundo {num2}.");

                                    resultado = Operacion.Suma(num1, num2);
                                    Console.WriteLine($"El resultado de la SUMA es {resultado}.");
                                    Console.ReadKey();
                                    opcionNormal = 0;
                                    break;
                                case 2:/// RESTA NORMAL ///
                                    Console.WriteLine("Ingrese el primer número");
                                    num1 = Valida.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    num2 = Valida.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {num1} y el segundo {num2}.");

                                    resultado = Operacion.Resta(num1, num2);
                                    Console.WriteLine($"El resultado de la RESTA es {resultado}.");
                                    Console.ReadKey();
                                    opcionNormal = 0;
                                    break;
                                case 3:/// MULTIPLICACION NORMAL ///
                                    Console.WriteLine("Ingrese el primer número");
                                    num1 = Valida.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    num2 = Valida.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {num1} y el segundo {num2}.");

                                    resultado = Operacion.Multiplicacion(num1, num2);
                                    Console.WriteLine($"El resultado dela MULTIPLICACION es {resultado}.");
                                    Console.ReadKey();
                                    opcionNormal = 0;
                                    break;
                                case 4: /// DIVISION NORMAL ///
                                    Console.WriteLine("Ingrese el primer número");
                                    num1 = Validador.ValidarDouble();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    num2 = Valida.ValidarDoubleNoCero();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {num1} y el segundo {num2}.");

                                    resultado = Operacion.Division(num1, num2);
                                    Console.WriteLine($"El resultado de la DIVISION es {resultado}.");
                                    Console.ReadKey();
                                    opcionNormal = 0;
                                    break;
                                case 5: //volver al menu principal /
                                    opcion = 0;
                                    break;
                                default:
                                    Console.WriteLine($"La opción ingresada es incorrecta. Vuelva a intentar.");
                                    Console.ReadKey();
                                    break;

                            }
                            Console.Clear();


                        } while (opcionNormal != 1 && opcionNormal != 2 && opcionNormal != 3 && opcionNormal != 4 && opcionNormal != 5);
                        break; ///////////////FIN CALCULADORA NORMAL/////////////

                    case 2:///////////////CALCULADORA RECURSIVA/////////////
                        do
                        {
                            resultado = 0;
                            Console.WriteLine("CALCULADORA RECURSIVA");
                            Console.WriteLine("Elija la operación que desea realizar");
                            Console.WriteLine("1 - RESTO");
                            Console.WriteLine("2 - MULTIPLICAR 1.0");
                            Console.WriteLine("3 - MULTIPLICAR 2.0");
                            Console.WriteLine("4 - PROMEDIO");
                            Console.WriteLine("5 - FIBONACCI");
                            Console.WriteLine("6 - CAPICÚA");
                            Console.WriteLine("7 - ANAGRAMA");
                            Console.WriteLine("8 - VOLVER AL MENU PRINCIPAL");
                            //eSTO SE PODRIA HACER CON UNA LISTA ! Y USAR EL VALOR DEL LENGTH DE LA LSITA ! REVISAR :) 

                            opcionRecursiva = Valida.ValidarOpcion(8);
                            Console.Clear();

                            switch (opcionRecursiva)
                            {
                                case 1: //RESTO RECURSIVO//
                                    Console.WriteLine("Ingrese el primer número");
                                    numero1 = Valida.ValidarIntPositivo();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    numero2 = Valida.ValidarIntPositivo();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {numero1} y el segundo {numero2}.");

                                    resultado = Operacion.RestoRecursivo(numero1, numero2);
                                    Console.WriteLine($"El resultado del RESTO es {resultado}.");
                                    Console.ReadKey();
                                    opcionRecursiva = 0;
                                    break;
                                case 2: //// MULTIPLICACION RECURSIVA 1.0////
                                    Console.WriteLine("Ingrese el primer número");
                                    numero1 = Valida.ValidarIntPositivo();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    numero2 = Valida.ValidarIntPositivo();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {numero1} y el segundo {numero2}.");

                                    resultado = Operacion.MultiplicacionRecursivaCero(numero1, numero2);
                                    Console.WriteLine($"El resultado de la MULTIPLICACION es {resultado}.");
                                    Console.ReadKey();
                                    opcionRecursiva = 0;
                                    break;
                                case 3: //// MULTIPLICACION RECURSIVA 2.0////
                                    Console.WriteLine("Ingrese el primer número");
                                    numero1 = Valida.ValidarIntPositivoCero();
                                    Console.Clear();

                                    Console.WriteLine("Ingrese el segundo número");
                                    numero2 = Valida.ValidarIntPositivoCero();
                                    Console.Clear();

                                    Console.WriteLine($"El primer numero ingresado fue {numero1} y el segundo {numero2}.");

                                    resultado = Operacion.MultiplicacionRecursivaCero(numero1, numero2);
                                    Console.WriteLine($"El resultado de la MULTIPLICACION es {resultado}.");
                                    Console.ReadKey();
                                    opcionRecursiva = 0;
                                    break;
                                case 4://////PROMEDIO RECURSIVO////////
                                       //necesitas una lista o un array y saber el length ! ! 
                                    /* . Diseñar la función Promedio. Solicitar al usuario el ingreso de números hasta que no ingrese un valor entero y calcular promedio de todo lo ingresado.*/
                                    List<int> promedios = new List<int>();
                                    //para crear una lista 

                                    /*Console.WriteLine("Ingrese un número");
                                    numero1 = Validador.ValidarIntPositivo(); 
                                    promedios.Add(numero1);


                                    resultado = Operacion.Promedio(promedios);*/
                                    Console.WriteLine($"Los números ingresados fueron:");
                                    foreach (var p in promedios)
                                    {
                                        Console.Write($" {p}, ");
                                    }
                                    Console.WriteLine($"El resultado del Promedio es {resultado}.");
                                    Console.ReadKey();
                                    opcionRecursiva = 0;
                                    break;
                                case 5://///////////FIBONACCI/////////////////
                                    Console.WriteLine("Ingrese un número positivo.");
                                    numero1 = Valida.ValidarIntPositivo();
                                    Console.Clear();

                                    resultado = Operacion.Fibonacci(numero1);
                                    Console.WriteLine($"El número Fibonacci para la posición {numero1} es {resultado}.");
                                    Console.ReadKey();
                                    opcionRecursiva = 0;
                                    break;
                                case 6: //// CAPICUA ////






                                    opcionRecursiva = 0;
                                    break;
                                case 7: //// ANAGRAMA ////






                                    opcionRecursiva = 0;
                                    break;
                                case 8: //volver al menu principal /
                                    opcion = 0;
                                    break;
                                default:
                                    Console.WriteLine($"La opción ingresada es incorrecta. Vuelva a intentar.");
                                    Console.ReadKey();
                                    break;

                            }
                            Console.Clear();


                        } while (opcionRecursiva != 1 && opcionRecursiva != 2 && opcionRecursiva != 3 && opcionRecursiva != 4 && opcionRecursiva != 5 && opcionRecursiva != 6 && opcionRecursiva != 7 && opcionRecursiva != 8);
                        break;
                    case 3:
                        Console.WriteLine("La Calculadora se Cerrará.");
                        Console.ReadKey();
                        break;/////////////// FIN CALCULADORA RECURSIVA/////////////

                }



            } while (opcion != 1 && opcion != 2 && opcion != 3); 
            ///////////////FIN MENU PRINCIPAL/////////////




       










        }
    }
