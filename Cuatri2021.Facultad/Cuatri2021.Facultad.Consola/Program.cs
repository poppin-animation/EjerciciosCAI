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


        static void Main(string[] args)
        {

            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;


            // menú que se va a mostrar luego de CADA acción
            string menu = "¿Que desea hacer?: \n" +
                $"1 - Listar Alumno \n" +
                $"2 - Listar Empleados \n" +
                $"3 - Listar Empleados por legajo \n" +
                $"4 - Listar Empleados por nombre \n" +
                $"5 - Agregar Alumno \n" +
                $"6 - Agregar Empleado \n" +
                $"7 - Modificar Empleado \n" +
                $"8 - Eliminar Alumno \n" +
                $"9 - Eliminar Empleado \n" +
                $"X - Salir de la Aplicación";


            

            // Creo el objeto con el que voy a trabajar en este programa
            Ffacultad facultad = new Ffacultad("FCE");



            // pantalla de bienvenida
            Console.WriteLine("Bienvenido a " + facultad.Nombre);
            do
            {
                Console.WriteLine(menu); //mostramos el menú
                                         //capturamos la seleccion

                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
               
                String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7", "X" };

                if (opcionSeleccionada.ToUpper() == "X")
                {
                    continuarActivo = false;
                    continue;
                }
                else if (Validador.isInt32(opcionSeleccionada) == true)
                {
                    switch (opcionSeleccionada)
                    {
                        case "1":
                            // listar Alumnos
                            Program.ListarAlumno(facultad);
                            break;
                        case "2":
                            // listar Empleados
                            Program.ListarEmpleado(facultad);
                           
                            break; 
                        case "3":
                            // Listar Empleados por legajo
                            Program.ListarEmpleadoPorLegajo(facultad);
                            
                            break;
                        case "4": //-------------------------------------------------------NO ESTA FUNCIONANDO, CONSULTAR A LOS PROFESORES ! ! ! ! 
                                  // Listar Empleados por Nombre
                            Program.ListarEmpleadoPorNombre(facultad);
                            
                            break;
                        case "5":
                            //Agregar Alumno
                            Program.AgregarAlumno(facultad);

                            break;
                        case "6":
                            // Agregar Empleado 
                            Program.AgregarEmpleado(facultad);
                           
                            break;
                        case "7":
                            // Modificar Empleado
                            Program.ModificarEmpleado(facultad);

                            break;
                        case "8"://-------------------------------------------------------NO ESTA FUNCIONANDO, CONSULTAR A LOS PROFESORES ! ! ! ! 
                            //Eliminar Alumno 
                            Program.EliminarAlumno(facultad); 
                           
                            break;
                        case "9":
                            //Eliminar Empleado
                            Program.EliminarEmpleado(facultad);
                            
                            break;
                        case "10":
                            //agregar datos de prueba
                            Program.AgregarDatos(facultad);

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


      
        // ---> SWITCH 1
        private static void ListarAlumno(Ffacultad facultad)
        {
            List<Alumno> listarAlumnos = facultad.TraerAlumnos();
            foreach (Alumno alu in listarAlumnos)
            {
                Console.WriteLine(alu.ToString());
            }
            //ES necesario el Console.Readkey() ? 
        }

        // ---> SWITCH 2
        private static void ListarEmpleado(Ffacultad facultad)
        {
            List<Empleado> listarEmpleado = facultad.TraerEmpleados();
            foreach (Empleado e in listarEmpleado)
            {
                Console.WriteLine(e.ToString());
            }
            //ES necesario el Console.Readkey() ? 
        }

        
        // ---> SWITCH 3
        private static void ListarEmpleadoPorLegajo(Ffacultad facultad)
        {

            Console.WriteLine("Ingrese el número de legajo del empleado a buscar:");
            int legajo = Validador.ValidarIntPositivo();
            Console.WriteLine(facultad.TraerEmpleadoPorLegajo(legajo).ToString());
            //ES necesario el Console.Readkey() ? 

        }

        // ---> SWITCH 4
        private static void ListarEmpleadoPorNombre(Ffacultad facultad)
        {
            Console.WriteLine("Ingrese el nombre del empleado a buscar:");
            string nombre = Validador.ValidarString();

            List<Empleado> listarEmpleadoPorNombre = facultad.TraerEmpleadoPorNombre(nombre);
            foreach (Empleado e in listarEmpleadoPorNombre)
            {
                Console.WriteLine(e.ToString());
            }
            //ES necesario el Console.Readkey() ? 
        }

        // ---> SWITCH 5
        private static void AgregarAlumno(Ffacultad facultad)
        {
            Console.WriteLine("Ingrese el Código del alumno a agregar");
            int codigoAl = Validador.ValidarIntPositivo();
            Console.WriteLine("Ingrese el nombre del alumno a agregar");
            string nombreAlumno = Validador.ValidarString();
            Console.WriteLine("Ingrese el apellido del alumno a agregar");
            string apellidoAlumno = Validador.ValidarString();
            Alumno alumno = new Alumno(codigoAl, nombreAlumno, apellidoAlumno);
            facultad.AgregarAlumno(alumno);
            //THROW EXCEPTION --> AVISAR SI EL ALUMNO SE PUDO AGREGAR CORRECTAMENTE
            Console.WriteLine($"El alumno {facultad.ListaAlumnos.Last().ToString()} fue agregado de manera exitosa.");
            Console.ReadKey();
        }

        // ---> SWITCH 6
        private static void AgregarEmpleado(Ffacultad facultad)
        {
            int tipoEmpleado;
            string strTipoEmpleado = "";
            do
            {
                Console.WriteLine("¿Que tipo de Empleado desea agregar?: \n" +
                $"1 - Bedel \n" +
                $"2 - Docente \n" +
                $"3 - Directivo";);
                tipoEmpleado = Validador.ValidarOpcion(3);
                TipoEmpleado tipoDeEmpleado = TipoEmpleado.Docente;
                if (tipoEmpleado == 1)
                {
                    tipoDeEmpleado = TipoEmpleado.Bedel;
                    strTipoEmpleado = "Bedel";
                }
                else if (tipoEmpleado == 2)
                {
                    tipoDeEmpleado = TipoEmpleado.Docente;
                    strTipoEmpleado = "Docente";
                }
                else 
                {
                    tipoDeEmpleado = TipoEmpleado.Directivo;
                    strTipoEmpleado = "Directivo";
                }
            } while (tipoEmpleado != 1 && tipoEmpleado != 2 && tipoEmpleado != 3);

            Console.WriteLine($"Ingrese el Número de Legajo del {strTipoEmpleado} a agregar");
            int numLegajo = Validador.ValidarIntPositivo();
            Console.WriteLine($"Ingrese el nombre del {strTipoEmpleado} a agregar");
            string nombreEmpleado = Validador.ValidarString();
            Console.WriteLine($"Ingrese el apellido del {strTipoEmpleado} a agregar");
            string apellidoEmpleado = Validador.ValidarString();
            if (strTipoEmpleado == "Bedel")
            {
                Console.WriteLine($"Ingrese el apodo del {strTipoEmpleado} a agregar");
                string apodoEmpleado = Validador.ValidarString();
            }
            Empleado empleado = new Empleado(numLegajo, nombreEmpleado, apellidoEmpleado, apodoEmpleado);
            facultad.AgregarEmpleado(empleado);
            //THROW EXCEPTION --> AVISAR SI EL EMPLEADO SE PUDO AGREGAR CORRECTAMENTE
            Console.WriteLine($"El empleado {facultad.ListaEmpleados.Last().ToString()} fue agregado de manera exitosa.");
            Console.ReadKey();

        }

        // ---> SWITCH 7
        private static void ModificarEmpleado(Ffacultad facultad)
        {

        }

        // ---> SWITCH 8
        private static void EliminarAlumno(Ffacultad facultad)
        {
            Console.WriteLine("Ingrese el código del alumno a eliminar");
            int codigoAlumno = Validador.ValidarIntPositivo();
            Alumno al = new Alumno();
            al = facultad.ListaAlumnos.Find(alum => alum.Codigo == codigoAlumno); //lo guardo para recordar los datos y confirmar el borrado
            facultad.EliminarAlumno(codigoAlumno);
            //THROW EXCEPTION --> AVISAR SI EL ALUMNO SE PUDO ELIMINAR CORRECTAMENTE
            Console.WriteLine($"El alumno {al.ToString()} fue eliminado de manera exitosa.");
            Console.ReadKey();
            al = null;
            Console.Clear();
        }

        // ---> SWITCH 9
        private static void EliminarEmpleado(Ffacultad facultad)
        {
            Console.WriteLine("Ingrese el número de Legajo del empleado a eliminar");
            int legajoEmpleado = Validador.ValidarIntPositivo();
            Empleado emp = new Empleado();
            emp = facultad.ListaEmpleados.Find(em => em.Legajo == legajoEmpleado); //lo guardo para recordar los datos y confirmar el borrado
            facultad.EliminarEmpleado(legajoEmpleado);
            //THROW EXCEPTION --> AVISAR SI EL ALUMNO SE PUDO ELIMINAR CORRECTAMENTE
            Console.WriteLine($"El empleado {emp.ToString()} fue eliminado de manera exitosa.");
            Console.ReadKey();
            emp = null;
            Console.Clear();
        }


        // ---> SWITCH 10
        private static void AgregarDatos(Ffacultad facultad)
        {
            Alumno a1 = new Alumno(892293, "Florencia", "Sueiro");
            facultad.AgregarAlumno(a1);
            Alumno a2 = new Alumno(892294, "Antonella", "Orlando");
            facultad.AgregarAlumno(a2);
            Alumno a3 = new Alumno(892295, "Sofia", "Pallotta");
            facultad.AgregarAlumno(a3);
            Alumno a4 = new Alumno(892296, "Marilin", "Gomez");
            facultad.AgregarAlumno(a4);
            Alumno a5 = new Alumno(892297, "Rodrigo", "Dente");
            facultad.AgregarAlumno(a5);

            Empleado e1 = new Empleado(893, "Florencia", "Sueiro");
            facultad.AgregarEmpleado(e1);
            Empleado e2 = new Empleado(894, "Antonella", "Orlando");
            facultad.AgregarEmpleado(e2);
            Empleado e3 = new Empleado(895, "Sofia", "Pallotta");
            facultad.AgregarEmpleado(e3);
            Empleado e4 = new Empleado(896, "Marilin", "Gomez");
            facultad.AgregarEmpleado(e4);
            Empleado e5 = new Empleado(897, "Rodrigo", "Dente");
            facultad.AgregarEmpleado(e5);
        }
    }


}
