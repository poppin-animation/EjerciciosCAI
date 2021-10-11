using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Presentismo.Biblioteca.Utilidades;



namespace Cuatri2021.Presentismo.Biblioteca.Entidades
{
    public class Asistencia
    {
        //atributos privados
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;
        


        //propiedades publicas
         public string FechaReferencia
         {
            get { return this._fechaReferencia; }
            set { this._fechaReferencia = value; }
         }
        public DateTime FechaHoraReal
        {
            get { return this._fechaHoraReal; }
        }



        //Constructor
        public Asistencia(string fecha, Preceptor p, Alumno a, bool Presente)
        {
            this._fechaReferencia = fecha;
            this._preceptor = p;
            this._alumno = a;
            this._fechaHoraReal = DateTime.Now;
            this._estaPresente = Presente;
        }



        //metodos

        public string EstaPresente
        {
            get
            {

                if (_estaPresente == true)
                {
                    return "SI";
                }
                else
                {
                    return "NO";
                }
            }
        }


        public override string ToString()
        {
            return $"{FechaReferencia} - {_alumno.ToString()} está presente {this.EstaPresente} por {_preceptor.ToString()} registrado el {_fechaHoraReal.ToString()}";

        }





    }
}
