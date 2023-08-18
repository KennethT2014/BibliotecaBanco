namespace CrearArchivoForm
{
    partial class frmCrearArchivo
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
            btnGuardar = new Button();
            btnEntrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(42, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 43);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar Como";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(152, 324);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(76, 43);
            btnEntrar.TabIndex = 17;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(262, 324);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 43);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmCrearArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 424);
            Controls.Add(btnSalir);
            Controls.Add(btnEntrar);
            Controls.Add(btnGuardar);
            Name = "frmCrearArchivo";
            Text = "Biblioteca Banco";
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(btnEntrar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Button btnEntrar;
        private Button btnSalir;
    }
}