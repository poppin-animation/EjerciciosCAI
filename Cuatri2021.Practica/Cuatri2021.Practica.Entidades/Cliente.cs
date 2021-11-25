using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Entidades
{
    public class Cliente
    {
        private static int _id;
        private long _cuit;
        private string _email;
        private DateTime _fechaNacimiento;
        private bool _activo;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;

        public Cliente(int id, long cuit, string email, DateTime fechaNacimiento, bool activo, string nombre, string apellido, string direccion, string telefono)
        {
            _id = id;
            _cuit = cuit;
            _email = email;
            _fechaNacimiento = fechaNacimiento;
            _activo = activo;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
        }
        public Cliente(int id, string nombre, string apellido)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;

        }

        public int Id { get => _id; set => _id = value; }
        public long Cuit { get => _cuit;
            set
            {
                if (value.ToString().Length != 11)
                {
                    throw new Exception("El CUIT tiene que ser de 11 dígitos");
                }
                else
                {
                    _cuit = value;
                }
            }
        }
        public bool Activo { get => _activo; set => _activo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public override string ToString()
        {
            return $"{this.Nombre}, {this.Apellido}";
        }

    }
}
