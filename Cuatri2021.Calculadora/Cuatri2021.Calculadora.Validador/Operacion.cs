using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Calculadora.Validador
{

    public static class Operacion
    {

        public static double Suma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }

        public static double Resta(double num1, double num2)
        {
            double resultado = num1 - num2;
            return resultado;
        }
        public static double Multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
        public static double Division(double num1, double num2)
        {
            double resultado = num1 / num2;
            return resultado;
        }



        /// ///////////////////////////////////////////// AQUI INICIAN LAS OPERACIONES PARA LA CALCULADORA RECURSIVAAAA //////////////////////////////////////////////////////////////////////////
        public static int RestoRecursivo(int numero1, int numero2)
        {
            //Caso base --> el problema es suficientemente pequeño para salir 
            if (numero1 < numero2) // no puedo sacar un numero 2 del numero 1{ no puedo sacar mas divisores
            {
                return numero1;
            }
            //paso recursivo --> achico el problema y arranco de vuelta
            return RestoRecursivo(numero1 - numero2, numero2);
        }

        public static int MultiplicacionRecursivaCero(int numero, int veces)
        {
            //Caso base --> el problema es suficientemente pequeño para salir 
            if (numero == 0 || veces == 0) // contemplo el 0, si alguno de los dos valores es 0 , el valor de cualquier multiplicacion == 0;
            {
                return 0;
            }
            if (veces == 1) //caso base minimo, cualquier numero multiplicado por uno es == al numero en si. 
            {
                return numero;
            }
            //paso recursivo --> achico el problema y arranco de vuelta
            if (veces > 1)
            {
                return numero + MultiplicacionRecursivaCero(numero, veces - 1); /// sumo el numero mas f(veces-1) hasta que se suma el numero uno por vez. 
            }
            else
            {
                return numero - MultiplicacionRecursivaCero(numero, veces + 1); /// sumo el numero mas f(veces-1) hasta que se suma el numero uno por vez. 

            }
        }

        public static int Fibonacci(int numfibonacci)
        {
            //Casos bases
            if (numfibonacci == 0)
            {
                return 0;
            }
            if (numfibonacci == 1)
            {
                return 1;
            }
            //Paso recursivo
            return Fibonacci(numfibonacci - 1) + Fibonacci(numfibonacci - 2);
        }

        public static int Factorial(int fact)
        {

            if (fact > 0)
            {
                int valor = fact * Factorial(fact - 1);
                return valor;
            }
            else
                return 1;

        }
        /*
        public static int SumaRecursiva(List<int> sum)
        {
            int suma = 0;
            int resultado = 0;
            //. Diseñar la función Promedio. Solicitar al usuario el ingreso de números hasta que no ingrese un valor entero y calcular promedio de todo lo ingresado.
            foreach (var s in sum)
            {
                suma = suma + s;
            }

            //Casos base
            if(sum.Count == 1)
            {
                return sum[0];
            }
            if(sum.Count > 1)
            {

            }


           
            //Paso Recursivo

            return resultado;


        }

        public static int Promedio(List<int> prom)
        {
            int resultado = 0;
            // . Diseñar la función Promedio. Solicitar al usuario el ingreso de números hasta que no ingrese un valor entero y calcular promedio de todo lo ingresado.
            //Casos base



            //Paso Recursivo

            return resultado;


        } 
        
         
          /*
             *  for (int i = 0; i < suma.Count; i++)
            {
                Console.WriteLine(personalFacultad[i]);
            }
             * */




    }

}
