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
        //public List<Cuenta> _listaCuentas;
        public List<Cliente> _listaCliente;
        public List<TipoCuenta> _listaTipoCuentas;
        private CuentaServicio _cuentaServicio; // AGREGO COMO ATRIBUTO LA CLASE SERVICIO



        public FrmCuentas(Form owner)
        {
            _listaTipoCuentas = new List<TipoCuenta>();
            _listaTipoCuentas.Add(new TipoCuenta(0, "--Selecionar--"));
            _listaTipoCuentas.Add(new TipoCuenta(1, "CAJA DE AHORRO"));
            _listaTipoCuentas.Add(new TipoCuenta(2, "CUENTA CORRIENTE"));

            _listaCliente = new List<Cliente>();

            _cuentaServicio = new CuentaServicio(); // LO INICIALIZO EN EL CONSTRUCTOR 

            this.Owner = owner;
            InitializeComponent();
        }

        /// <summary>
        /// -----------------------LOAD DEL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }


        private void InicializarControles()
        {
            try
            {
                CargarListaClientes();
                CargarListaTipoDocumentos();
                CargarListaCuentas();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }

        }

        private void CargarListaClientes()
        {
            _CBoxIdCliente.DataSource = null;
            //_CBoxIdCliente.DataSource = _listaCliente;
            _CBoxIdCliente.DisplayMember = "Descripcion";
            _CBoxIdCliente.ValueMember = "IdCliente";

        }
        private void CargarListaTipoDocumentos()
        {
            _CBoxTipoCuenta.DataSource = null;
            _CBoxTipoCuenta.DataSource = _listaTipoCuentas; // Y LO AGREGO AQUI, YA QUE ES EL RESPONSABLE DE TRAERME LA LISTA DE LOS DATOS
            _CBoxTipoCuenta.DisplayMember = "Tipo";
            _CBoxTipoCuenta.ValueMember = "Id";

        }
        private void CargarListaCuentas()
        {
            _lBoxCuentas.DataSource = null;
            _lBoxCuentas.DataSource = _cuentaServicio.GetListaCuentas();
            _lBoxCuentas.DisplayMember = ""; // POR DEFECTO VA AL TOSTRING()
                                             //SI tengo otra propiedad lo llamo con los "" y el nombre, por ejemplo = "Mostrar"
            _lBoxCuentas.ValueMember = "";
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
                this._cuentaServicio.AddCuenta(cuenta);
            }
            catch (Exception)
            {

                MessageBox.Show("La Cuenta no pudo ser agregada");
            }
        }




        private void _lBoxCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
