using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Expendedora.Biblioteca.Exceptions
{
    public class SinStockException : Exception
    {
        public SinStockException(string codigo) : base("No hay stock del producto con código: " + codigo + ". Por favor verifique el dato")
        {

        }
    }

    public class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException(int cantidad) : base("No hay capacidad suficiente para ingresar la siguiente cantidad: " + cantidad + " de unidades. Por favor verifique el dato")
        {

        }
    }


    public class DineroInsuficienteException : Exception
    {
        public DineroInsuficienteException() : base("No hay dinero suficiente para hacer frente a operacion. Por favor verifique el dato")
        {

        }
    }


    public class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException(string codigo) : base("El código: " + codigo + " es inválido. Por favor verifique el dato")
        {

        }
    }


}
