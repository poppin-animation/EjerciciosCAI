using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Expendedora.Biblioteca.Negocio
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio; 
        private double _volumen;
        private int _cantidad;

        public string Codigo
        {
            get { return this._codigo; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }
        public string Sabor
        {
            get { return this._sabor; }
        }
        public double Precio
        {
            get { return this._precio; }
        }
        public double Volumen
        {
            get { return this._volumen; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
        }



        //////////////////CONSTRUCTOR
        ///






        ////////////METODOS
        private double GetPrecioPorLitro()
        {
            double precioLitro;

            precioLitro = (this._precio * this._volumen);

            return precioLitro;

        }

        public override string ToString()
        {
            return $"{this._codigo}) {this._nombre} [{this._cantidad}]";
        }

        //FALTA OVERRIDE COMPLETAR

    }
}
