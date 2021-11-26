using Cuatri2021.Practica.Entidades;
using Cuatri2021.Practica.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Cuatri2021.Practica.AccesoDatos
{
    public class CuentaMapper
    {
        //HTTP por servidor. HACER REQUEST, VERBO. HEADER BODY Y RESPONSE
        //DESERIALIZAICON Y MAPEAR
        //SERIALIZACION Y MAPEO INVERSO
        private List<Cuenta> _listaCuentas;

        public List<Cuenta> DatosListaCuentas()
        {
            string respuestaServidor = WebHelper.Get("cuenta");
            _listaCuentas = JsonConvert.DeserializeObject<List<Cuenta>>(respuestaServidor);
            return _listaCuentas;
            //ESTO SE PUEDE MODULARIZAR----- llevar el mappeador aparte
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            //BODY
            NameValueCollection objeto = ReverseMap(cuenta);
            //HEADER CON EL VERBO
            string json = WebHelper.Post("cuenta", objeto);
            //RESULTADO
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            // _listaCuentas.Add(cuenta); //NO es necesario, porque con el GET siempre se pisa la lista. 

        }


        private List<Cuenta> MapearLista(string json)
        {
            List<Cuenta> lista = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return lista;
        }

        private Cuenta MapearCuenta(string json)
        {
            Cuenta cuenta = JsonConvert.DeserializeObject<Cuenta>(json);
            return cuenta;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", "0");
            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString("0.00"));
            n.Add("FechaApertura", cuenta.FechaApertura.ToString("yyyy-MM-dd"));
            n.Add("FechaModificacion", cuenta.FechaModificacion.ToString("yyyy-MM-dd"));
            n.Add("Activo", cuenta.Activo.ToString());
            n.Add("idCliente", cuenta.IdCliente.ToString());
            return n;
        }

    }
}
