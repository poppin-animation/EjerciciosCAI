namespace Cuatri2021.Practica.Winforms
{
    partial class FrmCliente
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
            this._lBoxClientes = new System.Windows.Forms.ListBox();
            this._txtBoxNombreCliente = new System.Windows.Forms.TextBox();
            this._lblNombreCliente = new System.Windows.Forms.Label();
            this._lblApellidoCliente = new System.Windows.Forms.Label();
            this._txtBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this._lblEmailCuit = new System.Windows.Forms.Label();
            this._txtBoxEmailCliente = new System.Windows.Forms.TextBox();
            this._lblCuitCliente = new System.Windows.Forms.Label();
            this._txtBoxCuitCliente = new System.Windows.Forms.TextBox();
            this._lblDireccionCliente = new System.Windows.Forms.Label();
            this._txtBoxDireccionCliente = new System.Windows.Forms.TextBox();
            this._lblFechaNacCliente = new System.Windows.Forms.Label();
            this._lblTelefonoCliente = new System.Windows.Forms.Label();
            this._txtBoxTelefonoCliente = new System.Windows.Forms.TextBox();
            this._lblIdCliente = new System.Windows.Forms.Label();
            this._txtBoxIdCliente = new System.Windows.Forms.TextBox();
            this._btnGuardar = new System.Windows.Forms.Button();
            this._btnLimpiarCliente = new System.Windows.Forms.Button();
            this._btnVolverCliente = new System.Windows.Forms.Button();
            this._btnEditarCliente = new System.Windows.Forms.Button();
            this._dtPickerFechaNacCliente = new System.Windows.Forms.DateTimePicker();
            this._chkBoxActivoCliente = new System.Windows.Forms.CheckBox();
            this._cBoxTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _lBoxClientes
            // 
            this._lBoxClientes.FormattingEnabled = true;
            this._lBoxClientes.ItemHeight = 16;
            this._lBoxClientes.Location = new System.Drawing.Point(31, 70);
            this._lBoxClientes.Name = "_lBoxClientes";
            this._lBoxClientes.Size = new System.Drawing.Size(297, 276);
            this._lBoxClientes.TabIndex = 0;
            this._lBoxClientes.SelectedIndexChanged += new System.EventHandler(this._lBoxClientes_SelectedIndexChanged);
            // 
            // _txtBoxNombreCliente
            // 
            this._txtBoxNombreCliente.Location = new System.Drawing.Point(589, 70);
            this._txtBoxNombreCliente.Name = "_txtBoxNombreCliente";
            this._txtBoxNombreCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxNombreCliente.TabIndex = 1;
            // 
            // _lblNombreCliente
            // 
            this._lblNombreCliente.AutoSize = true;
            this._lblNombreCliente.Location = new System.Drawing.Point(446, 75);
            this._lblNombreCliente.Name = "_lblNombreCliente";
            this._lblNombreCliente.Size = new System.Drawing.Size(56, 16);
            this._lblNombreCliente.TabIndex = 2;
            this._lblNombreCliente.Text = "Nombre";
            // 
            // _lblApellidoCliente
            // 
            this._lblApellidoCliente.AutoSize = true;
            this._lblApellidoCliente.Location = new System.Drawing.Point(446, 109);
            this._lblApellidoCliente.Name = "_lblApellidoCliente";
            this._lblApellidoCliente.Size = new System.Drawing.Size(57, 16);
            this._lblApellidoCliente.TabIndex = 4;
            this._lblApellidoCliente.Text = "Apellido";
            // 
            // _txtBoxApellidoCliente
            // 
            this._txtBoxApellidoCliente.Location = new System.Drawing.Point(589, 104);
            this._txtBoxApellidoCliente.Name = "_txtBoxApellidoCliente";
            this._txtBoxApellidoCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxApellidoCliente.TabIndex = 2;
            // 
            // _lblEmailCuit
            // 
            this._lblEmailCuit.AutoSize = true;
            this._lblEmailCuit.Location = new System.Drawing.Point(447, 189);
            this._lblEmailCuit.Name = "_lblEmailCuit";
            this._lblEmailCuit.Size = new System.Drawing.Size(44, 16);
            this._lblEmailCuit.TabIndex = 8;
            this._lblEmailCuit.Text = "e-Mail";
            // 
            // _txtBoxEmailCliente
            // 
            this._txtBoxEmailCliente.Location = new System.Drawing.Point(590, 184);
            this._txtBoxEmailCliente.Name = "_txtBoxEmailCliente";
            this._txtBoxEmailCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxEmailCliente.TabIndex = 4;
            // 
            // _lblCuitCliente
            // 
            this._lblCuitCliente.AutoSize = true;
            this._lblCuitCliente.Location = new System.Drawing.Point(447, 149);
            this._lblCuitCliente.Name = "_lblCuitCliente";
            this._lblCuitCliente.Size = new System.Drawing.Size(38, 16);
            this._lblCuitCliente.TabIndex = 6;
            this._lblCuitCliente.Text = "CUIT";
            // 
            // _txtBoxCuitCliente
            // 
            this._txtBoxCuitCliente.Location = new System.Drawing.Point(590, 144);
            this._txtBoxCuitCliente.Name = "_txtBoxCuitCliente";
            this._txtBoxCuitCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxCuitCliente.TabIndex = 3;
            // 
            // _lblDireccionCliente
            // 
            this._lblDireccionCliente.AutoSize = true;
            this._lblDireccionCliente.Location = new System.Drawing.Point(449, 306);
            this._lblDireccionCliente.Name = "_lblDireccionCliente";
            this._lblDireccionCliente.Size = new System.Drawing.Size(64, 16);
            this._lblDireccionCliente.TabIndex = 14;
            this._lblDireccionCliente.Text = "Dirección";
            // 
            // _txtBoxDireccionCliente
            // 
            this._txtBoxDireccionCliente.Location = new System.Drawing.Point(592, 301);
            this._txtBoxDireccionCliente.Name = "_txtBoxDireccionCliente";
            this._txtBoxDireccionCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxDireccionCliente.TabIndex = 7;
            // 
            // _lblFechaNacCliente
            // 
            this._lblFechaNacCliente.AutoSize = true;
            this._lblFechaNacCliente.Location = new System.Drawing.Point(448, 267);
            this._lblFechaNacCliente.Name = "_lblFechaNacCliente";
            this._lblFechaNacCliente.Size = new System.Drawing.Size(116, 16);
            this._lblFechaNacCliente.TabIndex = 12;
            this._lblFechaNacCliente.Text = "Fecha Nacimiento";
            // 
            // _lblTelefonoCliente
            // 
            this._lblTelefonoCliente.AutoSize = true;
            this._lblTelefonoCliente.Location = new System.Drawing.Point(448, 224);
            this._lblTelefonoCliente.Name = "_lblTelefonoCliente";
            this._lblTelefonoCliente.Size = new System.Drawing.Size(61, 16);
            this._lblTelefonoCliente.TabIndex = 10;
            this._lblTelefonoCliente.Text = "Telefono";
            // 
            // _txtBoxTelefonoCliente
            // 
            this._txtBoxTelefonoCliente.Location = new System.Drawing.Point(591, 219);
            this._txtBoxTelefonoCliente.Name = "_txtBoxTelefonoCliente";
            this._txtBoxTelefonoCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxTelefonoCliente.TabIndex = 5;
            // 
            // _lblIdCliente
            // 
            this._lblIdCliente.AutoSize = true;
            this._lblIdCliente.Location = new System.Drawing.Point(446, 38);
            this._lblIdCliente.Name = "_lblIdCliente";
            this._lblIdCliente.Size = new System.Drawing.Size(62, 16);
            this._lblIdCliente.TabIndex = 18;
            this._lblIdCliente.Text = "Id Cliente";
            // 
            // _txtBoxIdCliente
            // 
            this._txtBoxIdCliente.Location = new System.Drawing.Point(589, 33);
            this._txtBoxIdCliente.Name = "_txtBoxIdCliente";
            this._txtBoxIdCliente.ReadOnly = true;
            this._txtBoxIdCliente.Size = new System.Drawing.Size(100, 22);
            this._txtBoxIdCliente.TabIndex = 17;
            // 
            // _btnGuardar
            // 
            this._btnGuardar.Location = new System.Drawing.Point(713, 390);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(75, 23);
            this._btnGuardar.TabIndex = 9;
            this._btnGuardar.Text = "Guardar";
            this._btnGuardar.UseVisualStyleBackColor = true;
            this._btnGuardar.Click += new System.EventHandler(this._btnGuardar_Click);
            // 
            // _btnLimpiarCliente
            // 
            this._btnLimpiarCliente.Location = new System.Drawing.Point(452, 390);
            this._btnLimpiarCliente.Name = "_btnLimpiarCliente";
            this._btnLimpiarCliente.Size = new System.Drawing.Size(75, 23);
            this._btnLimpiarCliente.TabIndex = 10;
            this._btnLimpiarCliente.Text = "Limpiar";
            this._btnLimpiarCliente.UseVisualStyleBackColor = true;
            this._btnLimpiarCliente.Click += new System.EventHandler(this._btnLimpiarCliente_Click);
            // 
            // _btnVolverCliente
            // 
            this._btnVolverCliente.Location = new System.Drawing.Point(31, 390);
            this._btnVolverCliente.Name = "_btnVolverCliente";
            this._btnVolverCliente.Size = new System.Drawing.Size(75, 23);
            this._btnVolverCliente.TabIndex = 12;
            this._btnVolverCliente.Text = "Volver";
            this._btnVolverCliente.UseVisualStyleBackColor = true;
            this._btnVolverCliente.Click += new System.EventHandler(this._btnVolverCliente_Click);
            // 
            // _btnEditarCliente
            // 
            this._btnEditarCliente.Location = new System.Drawing.Point(253, 33);
            this._btnEditarCliente.Name = "_btnEditarCliente";
            this._btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this._btnEditarCliente.TabIndex = 11;
            this._btnEditarCliente.Text = "Editar";
            this._btnEditarCliente.UseVisualStyleBackColor = true;
            this._btnEditarCliente.Click += new System.EventHandler(this._btnEditarCliente_Click);
            // 
            // _dtPickerFechaNacCliente
            // 
            this._dtPickerFechaNacCliente.Location = new System.Drawing.Point(588, 261);
            this._dtPickerFechaNacCliente.Name = "_dtPickerFechaNacCliente";
            this._dtPickerFechaNacCliente.Size = new System.Drawing.Size(200, 22);
            this._dtPickerFechaNacCliente.TabIndex = 6;
            // 
            // _chkBoxActivoCliente
            // 
            this._chkBoxActivoCliente.AutoSize = true;
            this._chkBoxActivoCliente.Location = new System.Drawing.Point(590, 342);
            this._chkBoxActivoCliente.Name = "_chkBoxActivoCliente";
            this._chkBoxActivoCliente.Size = new System.Drawing.Size(66, 20);
            this._chkBoxActivoCliente.TabIndex = 8;
            this._chkBoxActivoCliente.Text = "Activo";
            this._chkBoxActivoCliente.UseVisualStyleBackColor = true;
            // 
            // _cBoxTipoDocumentoCliente
            // 
            this._cBoxTipoDocumentoCliente.FormattingEnabled = true;
            this._cBoxTipoDocumentoCliente.Location = new System.Drawing.Point(249, 380);
            this._cBoxTipoDocumentoCliente.Name = "_cBoxTipoDocumentoCliente";
            this._cBoxTipoDocumentoCliente.Size = new System.Drawing.Size(129, 24);
            this._cBoxTipoDocumentoCliente.TabIndex = 19;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._cBoxTipoDocumentoCliente);
            this.Controls.Add(this._chkBoxActivoCliente);
            this.Controls.Add(this._dtPickerFechaNacCliente);
            this.Controls.Add(this._btnEditarCliente);
            this.Controls.Add(this._btnVolverCliente);
            this.Controls.Add(this._btnLimpiarCliente);
            this.Controls.Add(this._btnGuardar);
            this.Controls.Add(this._lblIdCliente);
            this.Controls.Add(this._txtBoxIdCliente);
            this.Controls.Add(this._lblDireccionCliente);
            this.Controls.Add(this._txtBoxDireccionCliente);
            this.Controls.Add(this._lblFechaNacCliente);
            this.Controls.Add(this._lblTelefonoCliente);
            this.Controls.Add(this._txtBoxTelefonoCliente);
            this.Controls.Add(this._lblEmailCuit);
            this.Controls.Add(this._txtBoxEmailCliente);
            this.Controls.Add(this._lblCuitCliente);
            this.Controls.Add(this._txtBoxCuitCliente);
            this.Controls.Add(this._lblApellidoCliente);
            this.Controls.Add(this._txtBoxApellidoCliente);
            this.Controls.Add(this._lblNombreCliente);
            this.Controls.Add(this._txtBoxNombreCliente);
            this.Controls.Add(this._lBoxClientes);
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lBoxClientes;
        private System.Windows.Forms.TextBox _txtBoxNombreCliente;
        private System.Windows.Forms.Label _lblNombreCliente;
        private System.Windows.Forms.Label _lblApellidoCliente;
        private System.Windows.Forms.TextBox _txtBoxApellidoCliente;
        private System.Windows.Forms.Label _lblEmailCuit;
        private System.Windows.Forms.TextBox _txtBoxEmailCliente;
        private System.Windows.Forms.Label _lblCuitCliente;
        private System.Windows.Forms.TextBox _txtBoxCuitCliente;
        private System.Windows.Forms.Label _lblDireccionCliente;
        private System.Windows.Forms.TextBox _txtBoxDireccionCliente;
        private System.Windows.Forms.Label _lblFechaNacCliente;
        private System.Windows.Forms.Label _lblTelefonoCliente;
        private System.Windows.Forms.TextBox _txtBoxTelefonoCliente;
        private System.Windows.Forms.Label _lblIdCliente;
        private System.Windows.Forms.TextBox _txtBoxIdCliente;
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.Button _btnLimpiarCliente;
        private System.Windows.Forms.Button _btnVolverCliente;
        private System.Windows.Forms.Button _btnEditarCliente;
        private System.Windows.Forms.DateTimePicker _dtPickerFechaNacCliente;
        private System.Windows.Forms.CheckBox _chkBoxActivoCliente;
        private System.Windows.Forms.ComboBox _cBoxTipoDocumentoCliente;
    }
}

