using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Entidades
{
    public class TipoDocumento
    {
        private int _id;
        private string _tipo;

        public TipoDocumento(int id, string tipo)
        {
            _id = id;
            _tipo = tipo;
        }

        public int Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
