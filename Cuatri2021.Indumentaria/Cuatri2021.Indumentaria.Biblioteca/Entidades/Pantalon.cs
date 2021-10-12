using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        //metodos
        public override string GetDetalle()
        {
            return $"{this.Codigo}) Este es un Pantalon";
        }
    }
}
