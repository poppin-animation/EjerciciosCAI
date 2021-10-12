using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Indumentaria.Biblioteca.Entidades;
using Cuatri2021.Indumentaria.Biblioteca.Enumeradores;
using Cuatri2021.Indumentaria.Biblioteca.Excepciones;





namespace Cuatri2021.Indumentaria.Biblioteca.Entidades
{
    public class VentaItem
    {
        //Atributos privados
        private Indumentariaa _prenda;
        private int _cantidad;

        //propiedades publicas
        public Indumentariaa Prenda
        {
            get { return this._prenda; }
        }
        public int Cantidad
        {
            get { return this._cantidad; }
        }


        //constructor
        public VentaItem(int cantidad, Indumentariaa prenda)
        {
            this._prenda = prenda;
            this._cantidad = cantidad;
        }


        //metodos
        public double GetTotal()
        {
            return 0;
        }




    }
}
