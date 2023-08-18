namespace LeerArchivoAccesoSecuencial
{
    partial class frmLeerArchivoAccesoSecuencial
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
            this.abrirButton = new System.Windows.Forms.Button();
            this.siguienteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abrirButton
            // 
            this.abrirButton.Location = new System.Drawing.Point(39, 300);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(125, 55);
            this.abrirButton.TabIndex = 8;
            this.abrirButton.Text = "Abrir Archivo";
            this.abrirButton.UseVisualStyleBackColor = true;
            this.abrirButton.Click += new System.EventHandler(this.abrirButton_Click);
            // 
            // siguienteButton
            // 
            this.siguienteButton.Location = new System.Drawing.Point(237, 300);
            this.siguienteButton.Name = "siguienteButton";
            this.siguienteButton.Size = new System.Drawing.Size(125, 55);
            this.siguienteButton.TabIndex = 9;
            this.siguienteButton.Text = "Siguiente Registro";
            this.siguienteButton.UseVisualStyleBackColor = true;
            this.siguienteButton.Click += new System.EventHandler(this.siguienteButton_Click);
            // 
            // frmLeerArchivoAccesoSecuencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.siguienteButton);
            this.Controls.Add(this.abrirButton);
            this.Name = "frmLeerArchivoAccesoSecuencial";
            this.Text = "Leer Archivo de Acceso Secuencial";
            this.Controls.SetChildIndex(this.abrirButton, 0);
            this.Controls.SetChildIndex(this.siguienteButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button abrirButton;
        private Button siguienteButton;
    }
}