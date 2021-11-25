namespace Cuatri2021.Practica.Winforms
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
            this._btnFrmCliente = new System.Windows.Forms.Button();
            this._btnFrmCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnFrmCliente
            // 
            this._btnFrmCliente.Location = new System.Drawing.Point(54, 76);
            this._btnFrmCliente.Name = "_btnFrmCliente";
            this._btnFrmCliente.Size = new System.Drawing.Size(147, 54);
            this._btnFrmCliente.TabIndex = 0;
            this._btnFrmCliente.Text = "Cliente";
            this._btnFrmCliente.UseVisualStyleBackColor = true;
            this._btnFrmCliente.Click += new System.EventHandler(this._btnFrmCliente_Click);
            // 
            // _btnFrmCuentas
            // 
            this._btnFrmCuentas.Location = new System.Drawing.Point(54, 166);
            this._btnFrmCuentas.Name = "_btnFrmCuentas";
            this._btnFrmCuentas.Size = new System.Drawing.Size(147, 54);
            this._btnFrmCuentas.TabIndex = 1;
            this._btnFrmCuentas.Text = "Cuentas";
            this._btnFrmCuentas.UseVisualStyleBackColor = true;
            this._btnFrmCuentas.Click += new System.EventHandler(this._btnFrmCuentas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this._btnFrmCuentas);
            this.Controls.Add(this._btnFrmCliente);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnFrmCliente;
        private System.Windows.Forms.Button _btnFrmCuentas;
    }
}