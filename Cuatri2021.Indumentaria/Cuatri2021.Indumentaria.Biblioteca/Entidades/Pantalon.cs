using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Presentismo.Biblioteca.Utilidades;

namespace Cuatri2021.Indumentaria.Biblioteca.Entidades
{
    public class Pantalon : Indumentariaa
    {
        private bool _bolsillos;
        private string _material;

        //propiedades publicas
        public bool TieneBolsillos
        {
            get { return this._bolsillos; }
        }
        public string Material
        {
            get { return this._material; }
        }

        //constructor
        public Pantalon(int stock) : base (stock)
        {

        }


        //metodos
        public override string GetDetalle()
        {
            return $"{this.Codigo}) Camisa - Talle {this.Talle} - Stock {this.Stock} - Material {this.Material} - Bolsillos {Validador.BoolSiNo(this.TieneBolsillos)}";
        }
    }
}
