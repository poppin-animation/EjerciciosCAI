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

        public List<TipoDocumento> _listaDocumentos;
        private List<Cliente> _listaClientes;
        private ClienteServicio _clienteServicio;

        public FrmCliente(Form owner)
        {
            _listaClientes = new List<Cliente>();
            _listaClientes.Add(new Cliente(1, "Rodolfo", "Zabala"));
            _listaClientes.Add(new Cliente(2, "Suyai", "Pecoraro"));
            
            _listaDocumentos = new List<TipoDocumento>(); ;
            _listaDocumentos.Add(new TipoDocumento(0, "--SELECCIONE--"));
            _listaDocumentos.Add(new TipoDocumento(1, "DNI"));
            _listaDocumentos.Add(new TipoDocumento(2, "CUIT"));


            _clienteServicio = new ClienteServicio();   
            this.Owner = owner;
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //CICLO DE CONSTRUCCION, en el LOAD. para cargar formularios, dropdowns, combobox, listbox
            //_lBoxClientes LISTBOX MAneja COLECCIONES de datos. funciona distinto la forma en que se cargan lso elementos 
            //es necesario hacer un BINDING, representar una lista,,,, hacer un matching  de cada row o fila, se va a encargar de un elemento en la lista. enmascara cada elemento de la lista en una fila del objeto listbox. 
            CargarListaClientes();
            CargarTipoDocumento();
        }

        private void CargarTipoDocumento()
        {
            _cBoxTipoDocumentoCliente.DataSource = null;
            _cBoxTipoDocumentoCliente.DataSource = this._listaDocumentos;
            _cBoxTipoDocumentoCliente.DisplayMember = "Tipo";
            _cBoxTipoDocumentoCliente.ValueMember = "Id";
        }

        private void CargarListaClientes()
        {
            
            //BINDING. llamar al objeto. y usar metodo... PRIMERO EN NULL SIEMPRE
            _lBoxClientes.DataSource = null;
            _lBoxClientes.DataSource = this._clienteServicio.GetListaClientes();
            _lBoxClientes.DisplayMember = ""; // POR DEFECTO VA AL TOSTRING()
                                              //SI tengo otra propiedad lo llamo con los "" y el nombre, por ejemplo = "Mostrar"
            _lBoxClientes.ValueMember = "";

        }

        private void _btnVolverCliente_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.Text = "nuevo Texto";

            this.Hide();
            this.Owner.Show();
            //OCULTO el frmCLientes y MUESTRA el frm principal 
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

            Limpiar();
        }
        private void Limpiar()
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
            this._cBoxTipoDocumentoCliente.SelectedIndex = 0;
        }

        private void _btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente seleccionado = null;
                seleccionado = (Cliente)_lBoxClientes.SelectedItem;
                //trae un OBJETO general, es necesario CASTEARLO para guardarlo en la variable del tipo Cliente. 
                //OJO QUE NO SIEMPRE HAY OBJ seleccionados. hacer try catch. 
                MessageBox.Show(seleccionado.Apellido);


                //CUANDO NO QUIERO EL OBJETO ENTERO PERO SOLO UNA PROPIEDAD, le paso la propiedad como VALUEMEMBER
                //EVENTO PRINCIPAL COMBOS ES EL INDEXCHANGE !
            }
            catch (Exception)
            {

                throw new Exception("Debe seleccionar un objeto de la lista");
            }
        }

        private void _lBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EVENTO PRINCIPAL DE LOS LISTBOX ES CUANDO EL INDEX CAMBIA !!!
            try
            {
                if (_lBoxClientes.DataSource != null && _lBoxClientes.SelectedItem != null && !string.IsNullOrEmpty(_lBoxClientes.ValueMember)) ;
                {
                    //para que no salte cuando CARGA el formulario, CARGA el ListBox, CARGA El MOSTRAR datos...... 
                    string cod = this._lBoxClientes.SelectedValue.ToString();
                    MessageBox.Show(cod);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void ModificarCliente()
        {

        }



    }
}
