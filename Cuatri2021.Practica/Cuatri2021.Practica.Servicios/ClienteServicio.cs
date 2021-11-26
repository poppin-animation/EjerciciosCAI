using Cuatri2021.Practica.AccesoDatos;
using Cuatri2021.Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Servicios
{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;

        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
        }

        public List<Cliente> GetListaClientes()
        {
            try
            {
                return _clienteMapper.DatosListaClientes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente GetCliente(int codigo)
        {
            try
            {
                return _clienteMapper.DatosCliente(codigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddCliente(Cliente cliente)
        {
            try
            {
                _clienteMapper.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
