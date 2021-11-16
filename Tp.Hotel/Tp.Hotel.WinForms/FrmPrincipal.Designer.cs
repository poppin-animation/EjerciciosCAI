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
            this._lblUsuario = new System.Windows.Forms.Label();
            this._lblReportes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._btnReporteHabitaciones = new System.Windows.Forms.Button();
            this._btnReporteReservas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this._btnCliente = new System.Windows.Forms.Button();
            this._btnReserva = new System.Windows.Forms.Button();
            this._btnHoteles = new System.Windows.Forms.Button();
            this._btnHabitaciones = new System.Windows.Forms.Button();
            this._txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblUsuario
            // 
            this._lblUsuario.AutoSize = true;
            this._lblUsuario.Location = new System.Drawing.Point(594, 11);
            this._lblUsuario.Name = "_lblUsuario";
            this._lblUsuario.Size = new System.Drawing.Size(54, 16);
            this._lblUsuario.TabIndex = 8;
            this._lblUsuario.Text = "Usuario";
            this._lblUsuario.Click += new System.EventHandler(this.label1_Click);
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
            this.panel2.Controls.Add(this._btnReserva);
            this.panel2.Location = new System.Drawing.Point(24, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 68);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this._btnHoteles);
            this.panel3.Location = new System.Drawing.Point(24, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 68);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.Controls.Add(this._btnHabitaciones);
            this.panel4.Location = new System.Drawing.Point(24, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 68);
            this.panel4.TabIndex = 21;
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
            // _btnReserva
            // 
            this._btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReserva.Location = new System.Drawing.Point(55, 19);
            this._btnReserva.Name = "_btnReserva";
            this._btnReserva.Size = new System.Drawing.Size(210, 35);
            this._btnReserva.TabIndex = 9;
            this._btnReserva.Text = "Reserva";
            this._btnReserva.UseVisualStyleBackColor = true;
            // 
            // _btnHoteles
            // 
            this._btnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnHoteles.Location = new System.Drawing.Point(55, 18);
            this._btnHoteles.Name = "_btnHoteles";
            this._btnHoteles.Size = new System.Drawing.Size(210, 35);
            this._btnHoteles.TabIndex = 10;
            this._btnHoteles.Text = "Hoteles";
            this._btnHoteles.UseVisualStyleBackColor = true;
            // 
            // _btnHabitaciones
            // 
            this._btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnHabitaciones.Location = new System.Drawing.Point(57, 17);
            this._btnHabitaciones.Name = "_btnHabitaciones";
            this._btnHabitaciones.Size = new System.Drawing.Size(210, 35);
            this._btnHabitaciones.TabIndex = 11;
            this._btnHabitaciones.Text = "Habitaciones";
            this._btnHabitaciones.UseVisualStyleBackColor = true;
            // 
            // _txtUsuario
            // 
            this._txtUsuario.Enabled = false;
            this._txtUsuario.Location = new System.Drawing.Point(657, 8);
            this._txtUsuario.Name = "_txtUsuario";
            this._txtUsuario.Size = new System.Drawing.Size(108, 22);
            this._txtUsuario.TabIndex = 24;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtUsuario);
            this.Controls.Add(this.panel5);
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
        private System.Windows.Forms.Label _lblUsuario;
        private System.Windows.Forms.Label _lblReportes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button _btnReporteHabitaciones;
        private System.Windows.Forms.Button _btnReporteReservas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button _btnCliente;
        private System.Windows.Forms.Button _btnReserva;
        private System.Windows.Forms.Button _btnHoteles;
        private System.Windows.Forms.Button _btnHabitaciones;
        private System.Windows.Forms.TextBox _txtUsuario;
    }
}

