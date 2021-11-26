using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.Practica.Entidades
{
    public class Cuenta
    {
        private static int _id;
        private int _nroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private TipoCuenta _tipoCuenta;



        public int id { get => _id; private set => _id = value; }

        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        internal TipoCuenta TipoCuenta { get => _tipoCuenta; set => _tipoCuenta = value; }

        public Cuenta( int nroCuenta, TipoCuenta tipocuenta, string descripcion, double saldo, DateTime fechaApertura, DateTime fechaModificacion, bool activo /*, int idCliente*/)
        {
            
            
            _nroCuenta = nroCuenta;
            _descripcion = descripcion;
            _saldo = saldo;
            _fechaApertura = fechaApertura;
            _fechaModificacion = fechaModificacion;
            _activo = activo;
            //_idCliente = idCliente;
            _tipoCuenta = tipocuenta;

        }

        public override string ToString()
        {
           // return string.Format("{3}) Cuenta nro {0} / {1} Saldo $ {2}", this.NroCuenta, this.Descripcion, this.Saldo.ToString("0.00"), this.id);
            return $"{this.id}) Cuenta nro {this.NroCuenta} / {this.Descripcion} - Saldo $ {this.Saldo.ToString("0.00")}";
        }






    }

}
