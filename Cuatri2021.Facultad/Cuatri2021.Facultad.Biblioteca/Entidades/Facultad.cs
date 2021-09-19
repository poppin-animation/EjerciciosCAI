using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Facultad.Biblioteca.Utilidades;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Ffacultad
    {
        //ATRIBUTOS PRIVADOS
        private List<Alumno> _alumnos ;
        private int _cantidadSedes;
        private List<Empleado> _empleados ;
        private string _nombre;



        //PROPIEDADES PUBLICAS
        public int CantidadSedes
        {
            get { return _cantidadSedes;  }
            set { _cantidadSedes = value;  }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<Empleado> ListaEmpleados
        {
            get { return _empleados; }
            set { _empleados = value; }
        }
        public List<Alumno> ListaAlumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        }





        //CONSTRUCTOR
        public Ffacultad (String nombre)
        {
            this._nombre = nombre;
            this._alumnos = new List<Alumno>();
            this._empleados = new List<Empleado>();
        }



        //METODOS
        // Sobrecarga de metodos para AgregarAlumno o AgregarEmpleado
        //(por ejemplo, en lugar de pasar un Objeto, pasar los input y que el obj se instancie dentro del metodo Agregar)

        public void AgregarAlumno(Alumno alumno)
        {
            this._alumnos.Add(alumno);
        }
        public void AgregarAlumno(string nombre, string apellido)
        {
            Alumno alumno = new Alumno(nombre, apellido);
            AgregarAlumno(alumno);
        }


        public void AgregarEmpleado(Empleado empleado)
        {
            this._empleados.Add(empleado);
        }
        public void AgregarEmpleado(int legajo, string nombre, string apellido)
        {
            Empleado empleado = new Empleado(legajo, nombre, apellido);
            AgregarEmpleado(empleado); //delego responsabilidad al metodo... las validaciones directamente en este método. 
        }



        public void EliminarAlumno(int codigo)
        {
            foreach (Alumno a in this._alumnos)
            {
                if (a.Codigo == codigo)
                {
                    this._alumnos.Remove(a);
                }
            }
        }

        public void EliminarEmpleado(int legajo)
        {
            foreach (Empleado e in this._empleados)
            {
                if (e.Legajo == legajo)
                {
                    this._empleados.Remove(e);
                }
            }
        }



        public void ModificarEmpleado(Empleado empleado)
        {
            ///////////////QUE DE TODOS LOS DATOS QUIEREN MODIFICAR ?  ADemas el ingreso es por EMPLEADO, no por dato ?  como identifico a que empleado quiero modificar? tengo que hacer un equals? 
        }



        public List<Alumno> TraerAlumnos()
        {
            
            return ListaAlumnos;
        }

        public List<Empleado> TraerEmpleados()
        {
            return ListaEmpleados;
        }

        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            return ListaEmpleados.Find(e => e.Legajo == legajo);
        }

        public List<Empleado> TraerEmpleadoPorNombre(string nombre)
        {
            List<Empleado> listarEmpleado = new List<Empleado>();
            foreach (Empleado e in _empleados)
            {
                if (e.Nombre == nombre)
                {
                    listarEmpleado.Add(e);
                }
            }
            return listarEmpleado;

            ///#########################################
            //foreach (Empleado e in _empleados)
            //{
            //    if (e.Nombre == nombre)
            //    {
            //        return e;
            //    }
            //}
            //AGREGAR THROW EXCEPCION
            //---------------------------------
            ////###el problema es que si hay mas de uno, me va a tomar solo el ultimo.
            ///buscar manera de usar el list.find , seguro hay algun metodo asi 
            ///LA OTRA OPCION ES HACERLO POR LISTA, PORQUE SI BUSCO POR NOMBRE, ME PUEDE TRAER MAS DE UNO, ENTONCES QUE ME TRAIGA / DEVUELVA TODO LO QUE ENCUENTRE. . . 
            ///PREGUNTAR A LOS PROFESORES, QUE HACER , YA QUE EL RETURN ES UNO SOLO Y TIPO EMPLEADO. 

        }
        public Empleado TraerEmpleadoPorName(string nombre)
        {
            return ListaEmpleados.Find(e => e.Nombre == nombre);
            //Probar cual de los dos anda bien o mejor (Y)
        }




    }
}
