using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Presentismo.Biblioteca.Excepciones;

namespace Cuatri2021.Presentismo.Biblioteca.Entidades
{
    public class Ppresentismo
    {
        //atributos privados
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<String> _fechas;


        //propiedades publicas
        public List<Preceptor> Preceptores
        {
            get { return this._preceptores; }
            set { this._preceptores = value; }
        }



        //Constructor
        // iniciar Presentismo con los siguientes datos
        public Ppresentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();
            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }




        //metodos
        private bool AsistenciaRegistrada(string fecha)
        {
            //Contains() me devuelve un bool, si la lista contiene el elemento es TRUE si la lista NO lo contiene es FALSE. 
            if (this._fechas.Contains(fecha) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
               

        }

        private int GetCantidadAlumnosRegulares()
        {
            int alumnosRegulares = 0;
            //int alumnosOyentes = 0;
            foreach(Alumno a in _alumnos)
            {
                if(a is AlumnoRegular)
                {
                    alumnosRegulares = alumnosRegulares + 1;
                }
                //else
                //{
                //    alumnosOyentes = alumnosOyentes + 1;
                //}
            }
            
            return alumnosRegulares;
        }

        public Preceptor GetPreceptorActivo()
        {
            if(this._preceptores.Any() == true)
            {
                return this._preceptores.Last();
            }
            else
            {
                throw new Cuatri2021.Presentismo.Biblioteca.Excepciones.AsistenciaInconsistenteException();
            }

        }
        public List<Alumno> GetListaAlumnos(string fecha)
        {
            //primero reviso si hay ALGUN elemento en la lista alumnos, si no hay, tiro excepcion
            if (_alumnos.Any() == false)
            {
                throw new SinAlumnosRegistradosException();
            }
            else
            {
                //si hay, devuelvo la lista
                return this._alumnos;
            }
               
        }


        public void AgregarAsistencia(List<Asistencia> asistencias, string fecha)
        {
            //) En caso que la lista de asistencia ingresada no tenga una cantidad igual a la lista de alumnos regulares registrados, se debe arrojar una AsistenciaInconsistenteException.
            if (GetCantidadAlumnosRegulares() == asistencias.Count())
            {
                if (AsistenciaRegistrada(fecha))
                {
                    //si la lista de fechas ya contiene esa fecha, significa que ya existe una asistencia tomada para esa fecha, por ende tiro excepcion
                    throw new AsistenciaExistenteEseDiaException();
                }
                else
                {
                    //para agregar una LISTA dentro de OTRA LISTA, se usa el metodo ADDRANGE()
                    _asistencias.AddRange(asistencias);
                    
                }
                _fechas.Add(fecha);
            }
            else
            {
                throw new AsistenciaInconsistenteException();
            }
        }
        public List<Asistencia> GetAsistenciaPorFecha(string fecha)
        {
            //instancio una nueva lista para guardar asistencias por fecha. 
            List<Asistencia> asistenciasPorFecha = new List<Asistencia>();
            
            //si existe una asistencia registrada para esa fecha
            if (AsistenciaRegistrada(fecha) == true)
            {
                foreach (Asistencia a in this._asistencias)
                {
                    if (a.FechaReferencia == fecha)
                    {
                        asistenciasPorFecha.Add(a);
                    }
                }
                if (asistenciasPorFecha.Count == 0)
                {
                    throw new SinAlumnosRegistradosException();
                }
                else
                {
                    return asistenciasPorFecha;
                }
                    
            }
            else //si no existe asistencia registrada para esa fecha, tiro mensaje por excepcion de que no hay registros para la fecha. 
            {
                throw new Exception($"No hay registros para la fecha {fecha}");
                
            }


        }

    }
}
