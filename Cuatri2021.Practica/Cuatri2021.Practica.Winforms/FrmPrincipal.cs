using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuatri2021.Practica.Winforms
{
    public partial class FrmPrincipal : Form
    {
        private FrmCliente _formularioClientes;
        private FrmCuentas _formularioCuentas;
        //Agrego el formulario a modo de PROPIEDAD para que siempre lo podamos llamar 




        public FrmPrincipal()
        {
            CompletarControles();
            InitializeComponent();
        }

        private void _btnFrmCliente_Click(object sender, EventArgs e)
        {
            try
            {
                _formularioClientes.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
            
        }
        /// <summary>
        /// Agregamos un METODO De Completar Controles para agregar las inicializaciones
        /// de los fomrularioz por fuera del initialize. 
        /// asi modularizamos todo. 
        /// y al instanciar elcliente de la propiedad aca, nos aseguramos de que haya una sola instancia del formulario. 
        /// PERO OJO, no lo puedo volver a usar, porque la X DISPOSES del objeto. 
        /// necesito cREAR un boton propio. 
        /// </summary>
        private void CompletarControles()
        {
            _formularioClientes = new FrmCliente(this);

            //agrego al frmprincipal como OWNER Del frmClientes.
            _formularioCuentas = new FrmCuentas(this);


        }

        private void _btnFrmCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                _formularioCuentas.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
