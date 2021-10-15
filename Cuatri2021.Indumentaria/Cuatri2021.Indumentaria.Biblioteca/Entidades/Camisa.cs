using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Presentismo.Biblioteca.Utilidades;

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
        public Camisa(int stock) : base(stock)
        {

        }


        //metodos
        public override string GetDetalle()
        {
            return $"{this.Codigo}) Camisa - Talle {this.Talle} - Stock {this.Stock} - Estampado {Validador.BoolSiNo(this.TieneEstampado)} - Tipo Manga {this.TipoManga}";
        }




    }
}
