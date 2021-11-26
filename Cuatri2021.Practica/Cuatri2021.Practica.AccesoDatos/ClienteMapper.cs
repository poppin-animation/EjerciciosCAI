using System;
using System.Collections.Generic;
using Cuatri2021.Practica.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cuatri2021.Practica.AccesoDatos
{
    public class ClienteMapper
    {
        private List<Cliente> _clienteList;

        //public ClienteMapper() //YA NO ES NECESARIO PORQUE LO TRAIGO TODO DE LA API
        //{
        //    _clienteList = new List<Cliente>(); 
        //}

        public List<Cliente> DatosListaClientes()
        {
            return new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            _clienteList.Add(cliente);
        }

        public Cliente DatosCliente(int codigo)
        {
            return new Cliente();
        }
    }
}
