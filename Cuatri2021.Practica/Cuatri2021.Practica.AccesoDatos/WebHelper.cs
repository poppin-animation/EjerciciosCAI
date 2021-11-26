using System;
using System.Collections.Generic;
using System.Collections.Specialized; //USING NECESARIO PARA LOS nAMEvALUEcOLLECTION
//using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Cuatri2021.Practica.Entidades;

namespace Cuatri2021.Practica.AccesoDatos
{
    internal static class WebHelper
    {
        static WebClient client;
        static readonly string rutaBase;
        //public static string usuario = "/892293";

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/api/v1/";
            //rutaBase = ConfigurationManager.AppSettings["URL_API"];

            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        //url -> solo la dirección de la api de la entidad especifica. 
        public static string Get(string url, string usuario = "") //si no lo envio, lo toma por default string vacio. Si lo envío, le mando el /usuario
        {
            var uri = rutaBase + url + usuario;
            //agregar breakpoint f10 f11 y CHEQUEAR LA URI si muestra ok o si tira error 

            var responseString = client.DownloadString(uri);

            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros, string usuario = "")
        {
            string uri = rutaBase + url + usuario; 

            try
            {
                var response = client.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }

        public static string Put(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "PUT", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }

        public static string Delete(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "DELETE", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }



    }
}
