using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Entidades
{
    public class Cuenta
    {
        private int _idCuenta;
        private int _nroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;



        public int IdCuenta { get => _idCuenta; set => _idCuenta = value; }
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }



        public Cuenta(int idCuenta, int nroCuenta, string descripcion, double saldo, DateTime fechaApertura, DateTime fechaModificacion, bool activo, int idCliente)
        {
            _idCuenta = idCuenta;
            _nroCuenta = nroCuenta;
            _descripcion = descripcion;
            _saldo = saldo;
            _fechaApertura = fechaApertura;
            _fechaModificacion = fechaModificacion;
            _activo = activo;
            _idCliente = idCliente;

        }



    }

}
