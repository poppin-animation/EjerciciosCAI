using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Indumentaria.Biblioteca.Entidades
{
    public class Camisa : Indumentariaa
    {
        //Atributos privados
        private bool _estampado;
        private string _tipoManga;

        //propiedades publicas
        public bool TieneEstampado
        {
            get { return this._estampado; }
        }
        public string TipoManga
        {
            get { return this._tipoManga; }
        }

        //constructor



        //metodos
        public override string GetDetalle()
        {
            return $"{this.Codigo}) Esta es una Camisa";
        }




    }
}
