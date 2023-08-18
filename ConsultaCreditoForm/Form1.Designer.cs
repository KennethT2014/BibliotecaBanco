namespace ConsultaCreditoForm
{
    partial class ConsultaCreditoFrm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            abrirButton = new Button();
            obtenerSaldos = new Button();
            debitoButton = new Button();
            ceroButton = new Button();
            terminarButton = new Button();
            mostrarTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // abrirButton
            // 
            abrirButton.Location = new Point(28, 382);
            abrirButton.Margin = new Padding(3, 4, 3, 4);
            abrirButton.Name = "abrirButton";
            abrirButton.Size = new Size(104, 31);
            abrirButton.TabIndex = 1;
            abrirButton.Text = "Abrir Archivo";
            abrirButton.UseVisualStyleBackColor = true;
            abrirButton.Click += abrirButton_Click;
            // 
            // obtenerSaldos
            // 
            obtenerSaldos.Location = new Point(139, 382);
            obtenerSaldos.Margin = new Padding(3, 4, 3, 4);
            obtenerSaldos.Name = "obtenerSaldos";
            obtenerSaldos.Size = new Size(131, 31);
            obtenerSaldos.TabIndex = 2;
            obtenerSaldos.Text = "Saldos con Credito";
            obtenerSaldos.UseVisualStyleBackColor = true;
            obtenerSaldos.Click += obtenerSaldos_Click;
            // 
            // debitoButton
            // 
            debitoButton.Location = new Point(277, 382);
            debitoButton.Margin = new Padding(3, 4, 3, 4);
            debitoButton.Name = "debitoButton";
            debitoButton.Size = new Size(134, 31);
            debitoButton.TabIndex = 3;
            debitoButton.Text = "Saldos con Debito";
            debitoButton.UseVisualStyleBackColor = true;
            // 
            // ceroButton
            // 
            ceroButton.Location = new Point(417, 382);
            ceroButton.Margin = new Padding(3, 4, 3, 4);
            ceroButton.Name = "ceroButton";
            ceroButton.Size = new Size(122, 31);
            ceroButton.TabIndex = 4;
            ceroButton.Text = "Saldos en Cero";
            ceroButton.UseVisualStyleBackColor = true;
            // 
            // terminarButton
            // 
            terminarButton.Location = new Point(547, 382);
            terminarButton.Margin = new Padding(3, 4, 3, 4);
            terminarButton.Name = "terminarButton";
            terminarButton.Size = new Size(86, 31);
            terminarButton.TabIndex = 5;
            terminarButton.Text = "Salir";
            terminarButton.UseVisualStyleBackColor = true;
            terminarButton.Click += terminarButton_Click;
            // 
            // mostrarTextBox
            // 
            mostrarTextBox.Location = new Point(12, 12);
            mostrarTextBox.Name = "mostrarTextBox";
            mostrarTextBox.Size = new Size(634, 363);
            mostrarTextBox.TabIndex = 6;
            mostrarTextBox.Text = "";
            // 
            // ConsultaCreditoFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 428);
            Controls.Add(mostrarTextBox);
            Controls.Add(terminarButton);
            Controls.Add(ceroButton);
            Controls.Add(debitoButton);
            Controls.Add(obtenerSaldos);
            Controls.Add(abrirButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultaCreditoFrm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private Button abrirButton;
        private Button obtenerSaldos;
        private Button debitoButton;
        private Button ceroButton;
        private Button terminarButton;
        private RichTextBox mostrarTextBox;
    }
}