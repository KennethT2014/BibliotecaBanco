namespace BibliotecaBanco
{
    partial class frmBancoUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(42, 80);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(51, 15);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta: ";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(42, 128);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(95, 15);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(39, 185);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido Paterno:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(42, 240);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 15);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(163, 80);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(199, 23);
            this.txtCuenta.TabIndex = 4;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(163, 128);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(199, 23);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(163, 185);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(199, 23);
            this.txtApellido.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(163, 237);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(199, 23);
            this.txtSaldo.TabIndex = 7;
            // 
            // frmBancoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 384);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.lblCuenta);
            this.Name = "frmBancoUI";
            this.Text = "Biblioteca de Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCuenta;
        private Label lblPrimerNombre;
        private Label lblApellido;
        private Label lblSaldo;
        private TextBox txtCuenta;
        private TextBox txtPrimerNombre;
        private TextBox txtApellido;
        private TextBox txtSaldo;
    }
}