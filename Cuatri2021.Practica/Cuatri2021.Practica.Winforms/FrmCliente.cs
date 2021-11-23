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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void _btnVolverCliente_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.Text = "nuevo Texto";

            MessageBox.Show("Mostrar Cartel");
        }

        private void _btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._txtBoxIdCliente.Text != string.Empty)
                {
                    Cliente c = new Cliente(int.Parse(this._txtBoxIdCliente.Text), int.Parse(this._txtBoxCuitCliente.Text), this._txtBoxEmailCliente.Text, this._dtPickerFechaNacCliente.Value, this._chkBoxActivoCliente.Checked, this._txtBoxNombreCliente.Text, this._txtBoxApellidoCliente.Text, this._txtBoxDireccionCliente.Text, this._txtBoxTelefonoCliente.Text);
                    MessageBox.Show(c.ToString());

                }
                else
                {
                    MessageBox.Show("Todos los datos deben estar completos para guardar");
                }
            }
            catch (Exception ex)
            {

            }


            //this._btnGuardar.Enabled = false;
        }

        private void _btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            this._txtBoxIdCliente.Text = string.Empty;
            this._txtBoxCuitCliente.Text = string.Empty;
            this._txtBoxEmailCliente.Text = string.Empty;
            this._dtPickerFechaNacCliente.Value = DateTime.Now;
            this._chkBoxActivoCliente.Checked = false;
            this._txtBoxNombreCliente.Text = string.Empty;
            this._txtBoxApellidoCliente.Text = string.Empty;
            this._txtBoxDireccionCliente.Text = string.Empty;
            this._txtBoxTelefonoCliente.Text = string.Empty;

        }
    }
}
