using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Facultad.Biblioteca.Utilidades;

namespace Cuatri2021.Facultad.Biblioteca
{
    public class Facultad
    {
        //ATRIBUTOS PRIVADOS
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
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


        //CONSTRUCTOR




        //METODOS
        public void AgregarAlumno(Alumno alumno)
        {

        }

        public void AgregarEmpleado(Empleado empleado)
        {

        }


        public void EliminarAlumno(int codigo)
        {

        }

        public void EliminarEmpleado(int legajo)
        {

        }

        public void ModificarEmpleado(Empleado empleado)
        {

        }

        public List<Alumno> TraerAlumnos()
        {
            ///#########################################
            List<Alumno> alumnos = new List<Alumno>();
            return alumnos;
        }

        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            ///#########################################
            Empleado empleado = new Empleado();
            return empleado;
        }

        public List<Empleado> TraerEmpleados()
        {
            ///#########################################
            List<Empleado> empleados = new List<Empleado>();
            return empleados;
        }

        public Empleado TraerEmpleadoPorNombre(string nombre)
        {
            ///#########################################
            Empleado empleado = new Empleado();
            return empleado;
        }







    }
}
