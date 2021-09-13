using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Facultad.Biblioteca
{
    class Salario
    {
        //ATRIBUTOS PRIVADOS
        private double _bruto;
        private string _codigoTransferencia; //se puede hacer que este codigo sea de aumento auto´´atico .!!! 
        private double _descuentos;
        private DateTime _fecha;



        //PROPIEDADES PUBLICAS
        public double Bruto
        {
            get { return _bruto;  }
            set { _bruto = value; }
        }

        public string CodigoTransferencia
        {
            get { return _codigoTransferencia; }
            set { _codigoTransferencia = value; }
        }

        public double Descuentos
        {
            get { return _descuentos; }
            set { _descuentos = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            //------------------------------------------>>> como seteas unj datetime sin usar laconsola por las claseS? tenes que ya enviarlo seteado en datetime
            set { _fecha = value; }
        }



        //CONSTRUCTOR
        public Salario(double salario)
        {
            //ver que va en el constructor//
            this._bruto = salario;
            this._fecha = DateTime.Now; ///???????
        }



        //METODOS
        public double GetSalarioNeto()
        {
            double salarioNeto;
            salarioNeto = _bruto * _descuentos; //Esta bien hecho este calculo ?  ? ? es divvidido ?  es menos ? ? ? ?
            return salarioNeto;
            //consultar si es necesario definir la FECHA para la cual estoy buscando el salario neto. 
        }








    }
}
