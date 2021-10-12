using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Indumentaria.Biblioteca.Entidades
{
    public abstract class Indumentariaa
    {
        //Atributos privados
        private TipoIndumentaria _tipo;
        private int _codigo;
        private int _stock;
        private string _talle;
        private double _precio;



        //propiedades publicas
        public TipoIndumentaria Tipo
        {
            get { return this._tipo; }
            // set { this._tipo = value; }
        }
        public int Codigo
        {
            get { return this._codigo; }
            internal set { this._codigo = value; }
        }
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        public string Talle
        {
            get { return this._talle; }
            set { this._talle = value; }
        }
        public double Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        //constructor
        public Indumentariaa()
        {
            this._stock = 3;
        }


        //metodos
        public override string ToString()
        {
            return GetDetalle();
        }
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }

            if (this._codigo == ((Indumentariaa)o).Codigo)
            {
                return true;
            }
            else
            {
                return false; 
          
            }
        }
        public abstract string GetDetalle();


    }
}
