namespace Cuatri2021.Practica.Winforms
{
    partial class FrmCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnVolverCuentas = new System.Windows.Forms.Button();
            this._CBoxIdCliente = new System.Windows.Forms.ComboBox();
            this._lblIdCliente = new System.Windows.Forms.Label();
            this._txtNroCuenta = new System.Windows.Forms.TextBox();
            this._lblNroCuenta = new System.Windows.Forms.Label();
            this._btnLimpiarCuentas = new System.Windows.Forms.Button();
            this._btnGuardarCuentas = new System.Windows.Forms.Button();
            this._lblDescripCuentas = new System.Windows.Forms.Label();
            this._txtDescripcionCuentas = new System.Windows.Forms.TextBox();
            this._lblSaldoCuentas = new System.Windows.Forms.Label();
            this._txtSaldoCuentas = new System.Windows.Forms.TextBox();
            this._lblFechaAperturaCuentas = new System.Windows.Forms.Label();
            this._lblFechaModifCuentas = new System.Windows.Forms.Label();
            this._dtPickerFechaAperturaCuentas = new System.Windows.Forms.DateTimePicker();
            this._dtPickerFechaModificacionCuentas = new System.Windows.Forms.DateTimePicker();
            this._checkActivoCuentas = new System.Windows.Forms.CheckBox();
            this._lblTipoCuenta = new System.Windows.Forms.Label();
            this._CBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtIdCuenta = new System.Windows.Forms.TextBox();
            this._lBoxCuentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _btnVolverCuentas
            // 
            this._btnVolverCuentas.Location = new System.Drawing.Point(702, 390);
            this._btnVolverCuentas.Name = "_btnVolverCuentas";
            this._btnVolverCuentas.Size = new System.Drawing.Size(104, 37);
            this._btnVolverCuentas.TabIndex = 0;
            this._btnVolverCuentas.Text = "Volver";
            this._btnVolverCuentas.UseVisualStyleBackColor = true;
            this._btnVolverCuentas.Click += new System.EventHandler(this._btnVolverCuentas_Click);
            // 
            // _CBoxIdCliente
            // 
            this._CBoxIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CBoxIdCliente.FormattingEnabled = true;
            this._CBoxIdCliente.Location = new System.Drawing.Point(179, 32);
            this._CBoxIdCliente.Name = "_CBoxIdCliente";
            this._CBoxIdCliente.Size = new System.Drawing.Size(121, 24);
            this._CBoxIdCliente.TabIndex = 1;
            // 
            // _lblIdCliente
            // 
            this._lblIdCliente.AutoSize = true;
            this._lblIdCliente.Location = new System.Drawing.Point(33, 35);
            this._lblIdCliente.Name = "_lblIdCliente";
            this._lblIdCliente.Size = new System.Drawing.Size(62, 16);
            this._lblIdCliente.TabIndex = 2;
            this._lblIdCliente.Text = "Id Cliente";
            // 
            // _txtNroCuenta
            // 
            this._txtNroCuenta.Location = new System.Drawing.Point(179, 120);
            this._txtNroCuenta.Name = "_txtNroCuenta";
            this._txtNroCuenta.Size = new System.Drawing.Size(123, 22);
            this._txtNroCuenta.TabIndex = 3;
            // 
            // _lblNroCuenta
            // 
            this._lblNroCuenta.AutoSize = true;
            this._lblNroCuenta.Location = new System.Drawing.Point(33, 126);
            this._lblNroCuenta.Name = "_lblNroCuenta";
            this._lblNroCuenta.Size = new System.Drawing.Size(74, 16);
            this._lblNroCuenta.TabIndex = 4;
            this._lblNroCuenta.Text = "Nro Cuenta";
            // 
            // _btnLimpiarCuentas
            // 
            this._btnLimpiarCuentas.Location = new System.Drawing.Point(179, 390);
            this._btnLimpiarCuentas.Name = "_btnLimpiarCuentas";
            this._btnLimpiarCuentas.Size = new System.Drawing.Size(118, 31);
            this._btnLimpiarCuentas.TabIndex = 5;
            this._btnLimpiarCuentas.Text = "Limpiar";
            this._btnLimpiarCuentas.UseVisualStyleBackColor = true;
            this._btnLimpiarCuentas.Click += new System.EventHandler(this._btnLimpiarCuentas_Click);
            // 
            // _btnGuardarCuentas
            // 
            this._btnGuardarCuentas.Location = new System.Drawing.Point(33, 390);
            this._btnGuardarCuentas.Name = "_btnGuardarCuentas";
            this._btnGuardarCuentas.Size = new System.Drawing.Size(118, 31);
            this._btnGuardarCuentas.TabIndex = 6;
            this._btnGuardarCuentas.Text = "Guardar";
            this._btnGuardarCuentas.UseVisualStyleBackColor = true;
            this._btnGuardarCuentas.Click += new System.EventHandler(this._btnGuardarCuentas_Click);
            // 
            // _lblDescripCuentas
            // 
            this._lblDescripCuentas.AutoSize = true;
            this._lblDescripCuentas.Location = new System.Drawing.Point(33, 185);
            this._lblDescripCuentas.Name = "_lblDescripCuentas";
            this._lblDescripCuentas.Size = new System.Drawing.Size(79, 16);
            this._lblDescripCuentas.TabIndex = 8;
            this._lblDescripCuentas.Text = "Descripción";
            // 
            // _txtDescripcionCuentas
            // 
            this._txtDescripcionCuentas.Location = new System.Drawing.Point(179, 185);
            this._txtDescripcionCuentas.Name = "_txtDescripcionCuentas";
            this._txtDescripcionCuentas.Size = new System.Drawing.Size(123, 22);
            this._txtDescripcionCuentas.TabIndex = 7;
            // 
            // _lblSaldoCuentas
            // 
            this._lblSaldoCuentas.AutoSize = true;
            this._lblSaldoCuentas.Location = new System.Drawing.Point(33, 215);
            this._lblSaldoCuentas.Name = "_lblSaldoCuentas";
            this._lblSaldoCuentas.Size = new System.Drawing.Size(43, 16);
            this._lblSaldoCuentas.TabIndex = 10;
            this._lblSaldoCuentas.Text = "Saldo";
            // 
            // _txtSaldoCuentas
            // 
            this._txtSaldoCuentas.Location = new System.Drawing.Point(179, 215);
            this._txtSaldoCuentas.Name = "_txtSaldoCuentas";
            this._txtSaldoCuentas.Size = new System.Drawing.Size(123, 22);
            this._txtSaldoCuentas.TabIndex = 9;
            // 
            // _lblFechaAperturaCuentas
            // 
            this._lblFechaAperturaCuentas.AutoSize = true;
            this._lblFechaAperturaCuentas.Location = new System.Drawing.Point(33, 262);
            this._lblFechaAperturaCuentas.Name = "_lblFechaAperturaCuentas";
            this._lblFechaAperturaCuentas.Size = new System.Drawing.Size(99, 16);
            this._lblFechaAperturaCuentas.TabIndex = 12;
            this._lblFechaAperturaCuentas.Text = "Fecha Apertura";
            // 
            // _lblFechaModifCuentas
            // 
            this._lblFechaModifCuentas.AutoSize = true;
            this._lblFechaModifCuentas.Location = new System.Drawing.Point(33, 302);
            this._lblFechaModifCuentas.Name = "_lblFechaModifCuentas";
            this._lblFechaModifCuentas.Size = new System.Drawing.Size(124, 16);
            this._lblFechaModifCuentas.TabIndex = 13;
            this._lblFechaModifCuentas.Text = "Fecha Modificacion";
            // 
            // _dtPickerFechaAperturaCuentas
            // 
            this._dtPickerFechaAperturaCuentas.Location = new System.Drawing.Point(179, 256);
            this._dtPickerFechaAperturaCuentas.Name = "_dtPickerFechaAperturaCuentas";
            this._dtPickerFechaAperturaCuentas.Size = new System.Drawing.Size(161, 22);
            this._dtPickerFechaAperturaCuentas.TabIndex = 14;
            // 
            // _dtPickerFechaModificacionCuentas
            // 
            this._dtPickerFechaModificacionCuentas.Location = new System.Drawing.Point(179, 296);
            this._dtPickerFechaModificacionCuentas.Name = "_dtPickerFechaModificacionCuentas";
            this._dtPickerFechaModificacionCuentas.Size = new System.Drawing.Size(161, 22);
            this._dtPickerFechaModificacionCuentas.TabIndex = 15;
            // 
            // _checkActivoCuentas
            // 
            this._checkActivoCuentas.AutoSize = true;
            this._checkActivoCuentas.Location = new System.Drawing.Point(179, 337);
            this._checkActivoCuentas.Name = "_checkActivoCuentas";
            this._checkActivoCuentas.Size = new System.Drawing.Size(66, 20);
            this._checkActivoCuentas.TabIndex = 17;
            this._checkActivoCuentas.Text = "Activo";
            this._checkActivoCuentas.UseVisualStyleBackColor = true;
            // 
            // _lblTipoCuenta
            // 
            this._lblTipoCuenta.AutoSize = true;
            this._lblTipoCuenta.Location = new System.Drawing.Point(33, 156);
            this._lblTipoCuenta.Name = "_lblTipoCuenta";
            this._lblTipoCuenta.Size = new System.Drawing.Size(80, 16);
            this._lblTipoCuenta.TabIndex = 19;
            this._lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // _CBoxTipoCuenta
            // 
            this._CBoxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CBoxTipoCuenta.FormattingEnabled = true;
            this._CBoxTipoCuenta.Location = new System.Drawing.Point(179, 153);
            this._CBoxTipoCuenta.Name = "_CBoxTipoCuenta";
            this._CBoxTipoCuenta.Size = new System.Drawing.Size(121, 24);
            this._CBoxTipoCuenta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "IdCuenta";
            // 
            // _txtIdCuenta
            // 
            this._txtIdCuenta.Location = new System.Drawing.Point(179, 78);
            this._txtIdCuenta.Name = "_txtIdCuenta";
            this._txtIdCuenta.ReadOnly = true;
            this._txtIdCuenta.Size = new System.Drawing.Size(123, 22);
            this._txtIdCuenta.TabIndex = 20;
            // 
            // _lBoxCuentas
            // 
            this._lBoxCuentas.FormattingEnabled = true;
            this._lBoxCuentas.ItemHeight = 16;
            this._lBoxCuentas.Location = new System.Drawing.Point(391, 67);
            this._lBoxCuentas.Name = "_lBoxCuentas";
            this._lBoxCuentas.Size = new System.Drawing.Size(414, 308);
            this._lBoxCuentas.TabIndex = 22;
            this._lBoxCuentas.SelectedIndexChanged += new System.EventHandler(this._lBoxCuentas_SelectedIndexChanged);
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this._lBoxCuentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtIdCuenta);
            this.Controls.Add(this._lblTipoCuenta);
            this.Controls.Add(this._CBoxTipoCuenta);
            this.Controls.Add(this._checkActivoCuentas);
            this.Controls.Add(this._dtPickerFechaModificacionCuentas);
            this.Controls.Add(this._dtPickerFechaAperturaCuentas);
            this.Controls.Add(this._lblFechaModifCuentas);
            this.Controls.Add(this._lblFechaAperturaCuentas);
            this.Controls.Add(this._lblSaldoCuentas);
            this.Controls.Add(this._txtSaldoCuentas);
            this.Controls.Add(this._lblDescripCuentas);
            this.Controls.Add(this._txtDescripcionCuentas);
            this.Controls.Add(this._btnGuardarCuentas);
            this.Controls.Add(this._btnLimpiarCuentas);
            this.Controls.Add(this._lblNroCuenta);
            this.Controls.Add(this._txtNroCuenta);
            this.Controls.Add(this._lblIdCliente);
            this.Controls.Add(this._CBoxIdCliente);
            this.Controls.Add(this._btnVolverCuentas);
            this.Name = "FrmCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnVolverCuentas;
        private System.Windows.Forms.ComboBox _CBoxIdCliente;
        private System.Windows.Forms.Label _lblIdCliente;
        private System.Windows.Forms.TextBox _txtNroCuenta;
        private System.Windows.Forms.Label _lblNroCuenta;
        private System.Windows.Forms.Button _btnLimpiarCuentas;
        private System.Windows.Forms.Button _btnGuardarCuentas;
        private System.Windows.Forms.Label _lblDescripCuentas;
        private System.Windows.Forms.TextBox _txtDescripcionCuentas;
        private System.Windows.Forms.Label _lblSaldoCuentas;
        private System.Windows.Forms.TextBox _txtSaldoCuentas;
        private System.Windows.Forms.Label _lblFechaAperturaCuentas;
        private System.Windows.Forms.Label _lblFechaModifCuentas;
        private System.Windows.Forms.DateTimePicker _dtPickerFechaAperturaCuentas;
        private System.Windows.Forms.DateTimePicker _dtPickerFechaModificacionCuentas;
        private System.Windows.Forms.CheckBox _checkActivoCuentas;
        private System.Windows.Forms.Label _lblTipoCuenta;
        private System.Windows.Forms.ComboBox _CBoxTipoCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtIdCuenta;
        private System.Windows.Forms.ListBox _lBoxCuentas;
    }
}