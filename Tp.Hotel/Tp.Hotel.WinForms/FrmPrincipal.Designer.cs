using System;

namespace Tp.Hotel.WinForms
{
    partial class FrmPrincipal
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
            this._btnConsultarHotel = new System.Windows.Forms.Button();
            this._btnConsultarHabitacion = new System.Windows.Forms.Button();
            this._lblUsuario = new System.Windows.Forms.Label();
            this._lblReservas = new System.Windows.Forms.Label();
            this._lblHoteles = new System.Windows.Forms.Label();
            this._lblHabitaciones = new System.Windows.Forms.Label();
            this._lblReportes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._btnIngresarHabitacion = new System.Windows.Forms.Button();
            this._btnIngresarHotel = new System.Windows.Forms.Button();
            this._btnConsultarReservas = new System.Windows.Forms.Button();
            this._btnIngresarReserva = new System.Windows.Forms.Button();
            this._btnReporteHabitaciones = new System.Windows.Forms.Button();
            this._btnReporteReservas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this._btnCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnConsultarHotel
            // 
            this._btnConsultarHotel.Location = new System.Drawing.Point(186, 33);
            this._btnConsultarHotel.Name = "_btnConsultarHotel";
            this._btnConsultarHotel.Size = new System.Drawing.Size(110, 25);
            this._btnConsultarHotel.TabIndex = 5;
            this._btnConsultarHotel.Text = "Consultar";
            this._btnConsultarHotel.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarHabitacion
            // 
            this._btnConsultarHabitacion.Location = new System.Drawing.Point(186, 35);
            this._btnConsultarHabitacion.Name = "_btnConsultarHabitacion";
            this._btnConsultarHabitacion.Size = new System.Drawing.Size(110, 25);
            this._btnConsultarHabitacion.TabIndex = 7;
            this._btnConsultarHabitacion.Text = "Consultar";
            this._btnConsultarHabitacion.UseVisualStyleBackColor = true;
            this._btnConsultarHabitacion.Click += new System.EventHandler(this._btnConsultarHabitacion_Click);
            // 
            // _lblUsuario
            // 
            this._lblUsuario.AutoSize = true;
            this._lblUsuario.Location = new System.Drawing.Point(638, 13);
            this._lblUsuario.Name = "_lblUsuario";
            this._lblUsuario.Size = new System.Drawing.Size(54, 16);
            this._lblUsuario.TabIndex = 8;
            this._lblUsuario.Text = "Usuario";
            this._lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // _lblReservas
            // 
            this._lblReservas.AutoSize = true;
            this._lblReservas.BackColor = System.Drawing.Color.MediumPurple;
            this._lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReservas.Location = new System.Drawing.Point(33, 165);
            this._lblReservas.Name = "_lblReservas";
            this._lblReservas.Size = new System.Drawing.Size(74, 16);
            this._lblReservas.TabIndex = 10;
            this._lblReservas.Text = "Reservas";
            this._lblReservas.Click += new System.EventHandler(this.label2_Click);
            // 
            // _lblHoteles
            // 
            this._lblHoteles.AutoSize = true;
            this._lblHoteles.BackColor = System.Drawing.Color.PowderBlue;
            this._lblHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHoteles.Location = new System.Drawing.Point(33, 250);
            this._lblHoteles.Name = "_lblHoteles";
            this._lblHoteles.Size = new System.Drawing.Size(61, 16);
            this._lblHoteles.TabIndex = 11;
            this._lblHoteles.Text = "Hoteles";
            // 
            // _lblHabitaciones
            // 
            this._lblHabitaciones.AutoSize = true;
            this._lblHabitaciones.BackColor = System.Drawing.Color.LightCoral;
            this._lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHabitaciones.Location = new System.Drawing.Point(33, 340);
            this._lblHabitaciones.Name = "_lblHabitaciones";
            this._lblHabitaciones.Size = new System.Drawing.Size(99, 16);
            this._lblHabitaciones.TabIndex = 12;
            this._lblHabitaciones.Text = "Habitaciones";
            // 
            // _lblReportes
            // 
            this._lblReportes.AutoSize = true;
            this._lblReportes.BackColor = System.Drawing.Color.Turquoise;
            this._lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblReportes.Location = new System.Drawing.Point(15, 12);
            this._lblReportes.Name = "_lblReportes";
            this._lblReportes.Size = new System.Drawing.Size(71, 16);
            this._lblReportes.TabIndex = 13;
            this._lblReportes.Text = "Reportes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this._btnCliente);
            this.panel1.Location = new System.Drawing.Point(24, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 68);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this._btnIngresarReserva);
            this.panel2.Controls.Add(this._btnConsultarReservas);
            this.panel2.Location = new System.Drawing.Point(24, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 68);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this._btnIngresarHotel);
            this.panel3.Controls.Add(this._btnConsultarHotel);
            this.panel3.Location = new System.Drawing.Point(24, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 68);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.Controls.Add(this._btnIngresarHabitacion);
            this.panel4.Controls.Add(this._btnConsultarHabitacion);
            this.panel4.Location = new System.Drawing.Point(24, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 68);
            this.panel4.TabIndex = 21;
            // 
            // _btnIngresarHabitacion
            // 
            this._btnIngresarHabitacion.Location = new System.Drawing.Point(38, 35);
            this._btnIngresarHabitacion.Name = "_btnIngresarHabitacion";
            this._btnIngresarHabitacion.Size = new System.Drawing.Size(110, 25);
            this._btnIngresarHabitacion.TabIndex = 8;
            this._btnIngresarHabitacion.Text = "Ingresar";
            this._btnIngresarHabitacion.UseVisualStyleBackColor = true;
            this._btnIngresarHabitacion.Click += new System.EventHandler(this._btnIngresarHabitacion_Click);
            // 
            // _btnIngresarHotel
            // 
            this._btnIngresarHotel.Location = new System.Drawing.Point(38, 33);
            this._btnIngresarHotel.Name = "_btnIngresarHotel";
            this._btnIngresarHotel.Size = new System.Drawing.Size(110, 25);
            this._btnIngresarHotel.TabIndex = 6;
            this._btnIngresarHotel.Text = "Ingresar";
            this._btnIngresarHotel.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarReservas
            // 
            this._btnConsultarReservas.Location = new System.Drawing.Point(186, 32);
            this._btnConsultarReservas.Name = "_btnConsultarReservas";
            this._btnConsultarReservas.Size = new System.Drawing.Size(110, 25);
            this._btnConsultarReservas.TabIndex = 7;
            this._btnConsultarReservas.Text = "Consultar";
            this._btnConsultarReservas.UseVisualStyleBackColor = true;
            // 
            // _btnIngresarReserva
            // 
            this._btnIngresarReserva.Location = new System.Drawing.Point(38, 32);
            this._btnIngresarReserva.Name = "_btnIngresarReserva";
            this._btnIngresarReserva.Size = new System.Drawing.Size(110, 25);
            this._btnIngresarReserva.TabIndex = 8;
            this._btnIngresarReserva.Text = "Ingresar";
            this._btnIngresarReserva.UseVisualStyleBackColor = true;
            // 
            // _btnReporteHabitaciones
            // 
            this._btnReporteHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReporteHabitaciones.Location = new System.Drawing.Point(47, 101);
            this._btnReporteHabitaciones.Name = "_btnReporteHabitaciones";
            this._btnReporteHabitaciones.Size = new System.Drawing.Size(300, 35);
            this._btnReporteHabitaciones.TabIndex = 15;
            this._btnReporteHabitaciones.Text = "Habitaciones por Hotel";
            this._btnReporteHabitaciones.UseVisualStyleBackColor = true;
            // 
            // _btnReporteReservas
            // 
            this._btnReporteReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReporteReservas.Location = new System.Drawing.Point(47, 44);
            this._btnReporteReservas.Name = "_btnReporteReservas";
            this._btnReporteReservas.Size = new System.Drawing.Size(300, 35);
            this._btnReporteReservas.TabIndex = 14;
            this._btnReporteReservas.Text = "Reservas por Cliente";
            this._btnReporteReservas.UseVisualStyleBackColor = true;
            this._btnReporteReservas.Click += new System.EventHandler(this._btnReporteReservas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Controls.Add(this._btnReporteHabitaciones);
            this.panel5.Controls.Add(this._btnReporteReservas);
            this.panel5.Controls.Add(this._lblReportes);
            this.panel5.Location = new System.Drawing.Point(381, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 334);
            this.panel5.TabIndex = 23;
            // 
            // _btnCliente
            // 
            this._btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCliente.Location = new System.Drawing.Point(55, 17);
            this._btnCliente.Name = "_btnCliente";
            this._btnCliente.Size = new System.Drawing.Size(210, 35);
            this._btnCliente.TabIndex = 3;
            this._btnCliente.Text = "Cliente";
            this._btnCliente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this._lblHabitaciones);
            this.Controls.Add(this._lblHoteles);
            this.Controls.Add(this._lblReservas);
            this.Controls.Add(this._lblUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "FrmPrincipal";
            this.Text = "Rich Texan Hotel ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button _btnConsultarHotel;
        private System.Windows.Forms.Button _btnConsultarHabitacion;
        private System.Windows.Forms.Label _lblUsuario;
        private System.Windows.Forms.Label _lblReservas;
        private System.Windows.Forms.Label _lblHoteles;
        private System.Windows.Forms.Label _lblHabitaciones;
        private System.Windows.Forms.Label _lblReportes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button _btnIngresarHabitacion;
        private System.Windows.Forms.Button _btnIngresarReserva;
        private System.Windows.Forms.Button _btnConsultarReservas;
        private System.Windows.Forms.Button _btnIngresarHotel;
        private System.Windows.Forms.Button _btnReporteHabitaciones;
        private System.Windows.Forms.Button _btnReporteReservas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button _btnCliente;
        private System.Windows.Forms.Button button1;
    }
}

