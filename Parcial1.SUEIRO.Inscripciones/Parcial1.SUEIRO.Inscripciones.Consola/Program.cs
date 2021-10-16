using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.SUEIRO.Inscripciones.Biblioteca;
using Parcial1.SUEIRO.Inscripciones.Biblioteca.Entidades;
using Parcial1.SUEIRO.Inscripciones.Biblioteca.Excepciones;
using Parcial1.SUEIRO.Inscripciones.Validaciones;

/// <summary>
/// README
/// 
/// No me alcanza el tiempo para comprobar los errores de inscripcion de estudiantes por registro o por nombre, ni de materias por codigo ni de inscripciones por fecha. 
/// </summary>





namespace Parcial1.SUEIRO.Inscripciones.Consola
{
    public class Program
    {
        private static Instituto _instituto;
        static Program()
        {
            _instituto = new Instituto("NOMBRE");
        }
        static void Main(string[] args)
        {
            //Flag para mantener activa la consola. 
            bool continuarActiva = true;


            //traemos el profesor de turno por legajo (elegir el que quieran)
            Profesor profesor = _instituto.GetProfesor(5);
            do
            {

                DesplegarOpcionesMenu();
                string opcionMenu = Validador.ValidarString(); // pedir el valor
                if (opcionMenu.ToUpper() == "X")
                {
                    continuarActiva = false;
                    continue;
                }
                switch (opcionMenu)
                {
                    case "1":
                        InscribirEstudiante(profesor);
                        break;
                    case "2":
                        MostrarInscripciones();
                        break;
                    case "X":
                        // SALIR
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Validador.Continuar();
                Console.Clear();


            } while (continuarActiva == true);
            Console.WriteLine("Gracias por utilizar el programa");
            Console.ReadKey();

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Inscribir Estudiante");
            Console.WriteLine("2) Mostrar Inscripciones");
            Console.WriteLine("X: Terminar");
        }
        static void InscribirEstudiante(Profesor p)
        {
            try
            {
                Estudiante estudiante;
                // Listar los estudiantes
                Console.WriteLine("Lista de Estudiantes: ");
                foreach (Estudiante e in _instituto.GetEstudiantes())
                {
                    Console.WriteLine(e.ToString());
                }
                //El to string nomuestra REGISTRO, pero por nombre no lo pude hacer que el find no me de siempre null
                Console.WriteLine("Seleccionar el Estudiante por REGISTRO");
                int registro = Validador.ValidarIntPositivo();
                estudiante = _instituto.GetEstudiantes().Find(x => x.Registro == registro);
                //string nombre = Validador.ValidarString();
                //int index;
                //foreach(Estudiante e in _instituto.GetEstudiantes())
                //{
                //    if(e.Nombre.ToUpper() == nombre.ToUpper())
                //    {
                //        index = _instituto.GetEstudiantes().IndexOf(e);
                //    }
                //}
                //estudiante = _instituto.GetEstudiantes()[index];

                Materia materia;
                // Listar las materias
                Console.WriteLine("Lista de materias: ");
                foreach (Materia m in _instituto.GetMaterias())
                {
                    Console.WriteLine(m.ToString());
                }
                Console.WriteLine("Seleccionar la MATERIA por CODIGO ");
                int codigoMateria = Validador.ValidarIntPositivo();
                materia = _instituto.GetMaterias().Find(x => x.Codigo == codigoMateria);
                // Intento cargar la Inscripción


                Inscripcion i = new Inscripcion(p, estudiante, materia, DateTime.Today);
                //Console.WriteLine($"se va a intentar cargar la siguiente inscripcion: {i.ToString()}");
                _instituto.CargarInscripcion(i);
                Console.WriteLine($"La inscripcion fue realizada correctamente: {i.ToString()}");
            }
            catch (EstudianteInhabilitadoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (EstudianteInscriptoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            // Error: mostrar el error y que luego muestre el menú nuevamente
        }
        static void MostrarInscripciones()
        {
            // ingreso fecha
            Console.WriteLine("Ingrese una fecha ");
            DateTime fecha = Validador.PedirFechaBis();
            // muestro el toString de cada inscripción
            try
            {
                List<Inscripcion> listaInscripciones = _instituto.GetInscripcionesPorFecha(fecha);
                foreach (Inscripcion i in listaInscripciones)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}
