using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cuatri2021.Practica.Entidades;
using Cuatri2021.Practica.Servicios;

namespace Cuatri2021.Practica.Winforms
{
    public partial class FrmCuentas : Form
    {
        public List<Cuenta> _listaCuentas;
        public List<Cliente> _listaCliente;
        public List<TipoCuenta> _listaTipoCuentas;

        public FrmCuentas(Form owner)
        {
            _listaCuentas = new List<Cuenta>();
            _listaCuentas.Add(new Cuenta(0001,new TipoCuenta(1,"CA"), "Caja de Ahorro", 9.08, new DateTime(2009, 09, 20), new DateTime(2021, 08, 21), true));
            _listaCuentas.Add(new Cuenta(0002,new TipoCuenta(2,"CC"), "Cuenta Corriente", 40.05, new DateTime(2020, 05, 06), new DateTime(2005, 04, 12), false ));

            _listaTipoCuentas = new List<TipoCuenta>();
            _listaTipoCuentas.Add(new TipoCuenta(0, "--Selecionar--"));
            _listaTipoCuentas.Add(new TipoCuenta(1, "CAJA DE AHORRO"));
            _listaTipoCuentas.Add(new TipoCuenta(2, "CUENTA CORRIENTE"));

            _listaCliente = new List<Cliente>();

            this.Owner = owner;
            InitializeComponent();
        }

        private void _btnVolverCuentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnLimpiarCuentas_Click(object sender, EventArgs e)
        {
            Limpiar();
           
        }
        private void Limpiar()
        {
            this._txtNroCuenta.Text = string.Empty;
            this._CBoxIdCliente.SelectedValue = 0;
            this._dtPickerFechaAperturaCuentas.Value = DateTime.Today;
            this._dtPickerFechaModificacionCuentas.Value = DateTime.Now;
            this._checkActivoCuentas.Checked = false;
            this._txtDescripcionCuentas.Text = string.Empty;
            this._txtSaldoCuentas.Text = string.Empty;
            this._CBoxTipoCuenta.SelectedValue = 0;
        }

        private void _btnGuardarCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                //Validador.Validacion(_CBoxIdCliente);
                Validador.ValidacionInt(_txtNroCuenta);
                Validador.Validacion(_CBoxTipoCuenta);
                Validador.Validacion(_txtDescripcionCuentas);
                Validador.ValidacionDouble(_txtSaldoCuentas);

                Cuenta cuenta = new Cuenta(Convert.ToInt32(_txtNroCuenta.Text),(TipoCuenta)_CBoxTipoCuenta.SelectedItem, _txtDescripcionCuentas.Text, Convert.ToDouble(_txtSaldoCuentas.Text), _dtPickerFechaAperturaCuentas.Value, _dtPickerFechaModificacionCuentas.Value, _checkActivoCuentas.Checked /*, _CBoxIdCliente.SelectedIndex*/);

                GuardarCuenta(cuenta);
                CargarListaCuentas();
                Limpiar();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GuardarCuenta(Cuenta cuenta)
        {
            try
            {
                this._listaCuentas.Add(cuenta);
            }
            catch (Exception ex)
            {

                MessageBox.Show("La Cuenta no pudo ser agregada");
            }
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            try
            {

                _CBoxIdCliente.DataSource = null;
                //_CBoxIdCliente.DataSource = _listaCliente;
                _CBoxIdCliente.DisplayMember = "Descripcion";
                _CBoxIdCliente.ValueMember = "IdCliente";

                _CBoxTipoCuenta.DataSource = null;
                _CBoxTipoCuenta.DataSource = _listaTipoCuentas;
                _CBoxTipoCuenta.DisplayMember = "Tipo";
                _CBoxTipoCuenta.ValueMember = "Id";

                CargarListaCuentas();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");
             
            }

       


        }

        private void _lBoxCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarListaCuentas()
        {
            _lBoxCuentas.DataSource = null;
            _lBoxCuentas.DataSource = this._listaCuentas;
            _lBoxCuentas.DisplayMember = ""; // POR DEFECTO VA AL TOSTRING()
                                             //SI tengo otra propiedad lo llamo con los "" y el nombre, por ejemplo = "Mostrar"
            _lBoxCuentas.ValueMember = "";
        }


    }
}
