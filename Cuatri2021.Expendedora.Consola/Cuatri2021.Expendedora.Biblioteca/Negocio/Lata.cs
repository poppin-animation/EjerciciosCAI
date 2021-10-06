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
            set { this._cantidad = value; }
        }



        //////////////////CONSTRUCTOR
        ///
        public Lata(string codigo, string nombre, string sabor, double precio, double volumen, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._sabor = sabor;
            this._precio = precio;
            this._volumen = volumen;
            this._cantidad = cantidad;
        }





        ////////////METODOS
        private double GetPrecioPorLitro()
        {
            double precioLitro;

            precioLitro = ((this._precio*1000) / this._volumen);

            return precioLitro;

        }

        public override string ToString()
        {
            return $"{this._codigo}) {this._nombre} [{this._cantidad}]";
        }
        public string ToToString()
        {
            return $"{ this._nombre} - { this._sabor} $ { this._precio} / $/L { GetPrecioPorLitro()} - [{ this._cantidad}]";
        }

        //FALTA OVERRIDE COMPLETAR

    }
}
