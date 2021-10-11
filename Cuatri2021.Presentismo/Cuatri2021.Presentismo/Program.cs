using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Presentismo.Biblioteca;
using Cuatri2021.Presentismo.Biblioteca.Entidades;
using Cuatri2021.Presentismo.Biblioteca.Utilidades;
using Cuatri2021.Presentismo.Biblioteca.Excepciones;

namespace Cuatri2021.Presentismo
{
    public class Program
    {
        //atributos privados 
        private static Ppresentismo _presentismo;


        //Constructor
        static Program()
        {
            _presentismo = new Ppresentismo();
        }

       
        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;

            try
            {
                Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            
                do
                {
                    Console.Clear();
                    DesplegarOpcionesMenu();
                    string opcionMenu = Validador.ValidarString(); // pedir el valor

                    switch (opcionMenu.ToUpper())
                    {
                        case "1":
                            TomarAsistencia(preceptorActivo);
                            break;
                        case "2":
                            MostrarAsistencia();
                            break;
                        case "X":
                            // SALIR
                            continuarActivo = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Presione una tecla para intentar nuevamente.");
                            Console.ReadKey();
                            break;
                    }


                } while (continuarActivo == true);
                Console.Clear();
                Console.WriteLine("Gracias por utilizar la aplicacion");
                Console.ReadKey();

            }
            catch (AsistenciaInconsistenteException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            Console.Clear();
            try
            {
                // Ingreso fecha
                string fechaS = Validador.PedirFechaString("A continuación se le solicitará ingresar una fecha");
                Console.WriteLine(fechaS);
                Console.ReadKey();
                //PRUEBA DE FECHA INGRESADA

                // Listar los alumnos
                List<Alumno> listaAlumnos = _presentismo.GetListaAlumnos(fechaS);
                List<Asistencia> asistenciaPorFecha = new List<Asistencia>();
                foreach(Alumno a in listaAlumnos)
                {
                    //) Si el alumno no es regular, mostrar por pantalla “El alumno {FORMATO} es oyente” y no pedir asistencia ni agregar a la lista de asistencia.
                    if (a is AlumnoOyente)
                    {
                        Console.WriteLine($"El alumno {a.ToString()} es oyente.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(a.ToString());
                        // para cada alumno solo preguntar si está presente
                       
                        Asistencia asistencia;
                        if (Validador.PedirPresente() == true)
                        {
                            asistencia = new Asistencia(fechaS, p, a, true);
                           
                        }
                        else
                        {
                            asistencia = new Asistencia(fechaS, p, a, false);
                            
                        }
                        // agrego la lista de asistencia
                        asistenciaPorFecha.Add(asistencia);

                    }

                }

                _presentismo.AgregarAsistencia(asistenciaPorFecha, fechaS);
                Console.WriteLine($"Se ha agregado correctamente la Lista de Asistencia para la fecha {fechaS}");
                Console.ReadKey();

            }
            catch (AsistenciaExistenteEseDiaException ex)
            {
                // Error: mostrar el error y que luego muestre el menu nuevamente
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (AsistenciaInconsistenteException ex)
            {
                // Error: mostrar el error y que luego muestre el menu nuevamente
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                // Error: mostrar el error y que luego muestre el menu nuevamente
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        static void MostrarAsistencia()
        {
            Console.Clear();
            try
            {
                // Ingreso fecha
                string fechaS = Validador.PedirFechaString("A continuación se le solicitará ingresar una fecha");
                //Console.WriteLine(fechaS);
                //Console.ReadKey();
                ////PRUEBA DE FECHA INGRESADA



                // muestro el toString de cada asistencia
                List<Asistencia> asistenciaPorFecha = _presentismo.GetAsistenciaPorFecha(fechaS);
                Console.WriteLine($"La asistencia para la fecha {fechaS} solicitada es la siguiente:");
                foreach(Asistencia a in asistenciaPorFecha)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.ReadKey();

            }
            catch (SinAlumnosRegistradosException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                // Error: mostrar el error y que luego muestre el menu nuevamente
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }




    }






}
