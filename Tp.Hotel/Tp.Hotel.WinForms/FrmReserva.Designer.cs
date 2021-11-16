
namespace Tp.Hotel.WinForms
{
    partial class lblReserva
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
            this.lblDatosReserva = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtHuespedes = new System.Windows.Forms.TextBox();
            this.txtFechaEgreso = new System.Windows.Forms.TextBox();
            this.lblHuespedes = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.txtNroReserva = new System.Windows.Forms.TextBox();
            this.lblNroReserva = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatosReserva
            // 
            this.lblDatosReserva.AutoSize = true;
            this.lblDatosReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosReserva.Location = new System.Drawing.Point(431, 48);
            this.lblDatosReserva.Name = "lblDatosReserva";
            this.lblDatosReserva.Size = new System.Drawing.Size(137, 20);
            this.lblDatosReserva.TabIndex = 11;
            this.lblDatosReserva.Text = "Datos de Reserva";
            this.lblDatosReserva.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(534, 143);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtFechaIngreso.TabIndex = 2;
            this.txtFechaIngreso.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtHuespedes
            // 
            this.txtHuespedes.Location = new System.Drawing.Point(534, 213);
            this.txtHuespedes.Name = "txtHuespedes";
            this.txtHuespedes.Size = new System.Drawing.Size(100, 20);
            this.txtHuespedes.TabIndex = 4;
            this.txtHuespedes.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtFechaEgreso
            // 
            this.txtFechaEgreso.Location = new System.Drawing.Point(534, 179);
            this.txtFechaEgreso.Name = "txtFechaEgreso";
            this.txtFechaEgreso.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEgreso.TabIndex = 3;
            this.txtFechaEgreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHuespedes
            // 
            this.lblHuespedes.AutoSize = true;
            this.lblHuespedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuespedes.Location = new System.Drawing.Point(353, 217);
            this.lblHuespedes.Name = "lblHuespedes";
            this.lblHuespedes.Size = new System.Drawing.Size(155, 16);
            this.lblHuespedes.TabIndex = 25;
            this.lblHuespedes.Text = "Cantidad de huespedes:";
            this.lblHuespedes.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEgreso.Location = new System.Drawing.Point(355, 183);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(115, 16);
            this.lblFechaEgreso.TabIndex = 24;
            this.lblFechaEgreso.Text = "Fecha de Egreso:";
            this.lblFechaEgreso.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(355, 147);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(116, 16);
            this.lblFechaIngreso.TabIndex = 23;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            this.lblFechaIngreso.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(356, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 50);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(196, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 50);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.BlueViolet;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(543, 274);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 50);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(24, 274);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(87, 50);
            this.btnCargarCliente.TabIndex = 5;
            this.btnCargarCliente.Text = "Cargar Nuevo";
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            // 
            // txtNroReserva
            // 
            this.txtNroReserva.Location = new System.Drawing.Point(534, 106);
            this.txtNroReserva.Name = "txtNroReserva";
            this.txtNroReserva.Size = new System.Drawing.Size(100, 20);
            this.txtNroReserva.TabIndex = 1;
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroReserva.Location = new System.Drawing.Point(353, 110);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(133, 16);
            this.lblNroReserva.TabIndex = 42;
            this.lblNroReserva.Text = "Número de Reserva:";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(24, 87);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(284, 173);
            this.lstClientes.TabIndex = 9;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(103, 48);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(127, 20);
            this.lblDatosCliente.TabIndex = 10;
            this.lblDatosCliente.Text = "Datos de Cliente";
            this.lblDatosCliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.txtNroReserva);
            this.Controls.Add(this.lblNroReserva);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.lblDatosReserva);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtHuespedes);
            this.Controls.Add(this.txtFechaEgreso);
            this.Controls.Add(this.lblHuespedes);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Name = "lblReserva";
            this.Text = "Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatosReserva;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtHuespedes;
        private System.Windows.Forms.TextBox txtFechaEgreso;
        private System.Windows.Forms.Label lblHuespedes;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.TextBox txtNroReserva;
        private System.Windows.Forms.Label lblNroReserva;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblDatosCliente;
    }
}