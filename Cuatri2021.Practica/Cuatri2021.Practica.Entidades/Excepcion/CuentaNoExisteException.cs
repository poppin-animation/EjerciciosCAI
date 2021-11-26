using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Entidades
{
    public class CuentaNoExisteException:Exception
    {
        public CuentaNoExisteException() : base("Cuenta no encontrada")
        {

        }
    }
}
