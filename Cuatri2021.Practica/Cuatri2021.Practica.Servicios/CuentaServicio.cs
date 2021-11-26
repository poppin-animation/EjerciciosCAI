using Cuatri2021.Practica.AccesoDatos;
using Cuatri2021.Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Servicios
{
    public class CuentaServicio
    {
        private CuentaMapper _cuentaMapper;

        public CuentaServicio()
        {
            _cuentaMapper = new CuentaMapper();
        }


        /*  //_listaCuentas = new List<Cuenta>();
            //_listaCuentas.Add(new Cuenta(0001,new TipoCuenta(1,"CA"), "Caja de Ahorro", 9.08, new DateTime(2009, 09, 20), new DateTime(2021, 08, 21), true));
            //_listaCuentas.Add(new Cuenta(0002,new TipoCuenta(2,"CC"), "Cuenta Corriente", 40.05, new DateTime(2020, 05, 06), new DateTime(2005, 04, 12), false ));


        */


        public List<Cuenta> GetListaCuentas()
        {
            //AQUI podría agregar validaciones del tipo de negocio. 
            //ver de modularizarlo y agregarlo al try
            try
            {
                //CREO UN METODO QUE ME TRAIGA LA LISTA DE LAS CUENTAS                 //PERO PARA ESO LLAMO AL METODO DE MI PROPIEDAD MAPPER, A MODO DE PASAMANOS
                return _cuentaMapper.DatosListaCuentas();
                //MAPPER HABLA JSON CON LA API, Y ME DEVUELVA UNA LISTA... YO NEGOCIO SERVICIO LE PASO ESTA LISTA AL FORM. 

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void AddCuenta(Cuenta cuenta)
        {
            try
            {
                _cuentaMapper.AgregarCuenta(cuenta);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
