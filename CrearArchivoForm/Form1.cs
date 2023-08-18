using System;
using System.Windows.Forms;
using System.IO;
using BibliotecaBanco;

namespace CrearArchivoForm
{
    public partial class frmCrearArchivo : frmBancoUI
    {
        private StreamWriter archivoWritter;
        private FileStream salida;
        public frmCrearArchivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();

            string nombreArchivo;

            selectorArchivo.CheckFileExists = false;

            if (resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;

            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de Archivo Invalido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    salida = new FileStream(nombreArchivo,
                        FileMode.OpenOrCreate, FileAccess.Write);

                    archivoWritter = new StreamWriter(salida);

                    btnGuardar.Enabled = false;
                    btnEntrar.Enabled = true;
                }
                catch (IOException)
                {

                    MessageBox.Show("Error al Abrir el Archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresControlesTextBox();

            Registro registro = new Registro();

            if (valores[(int)IndiceTextBox.CUENTA] != "")
            {
                try
                {
                    int numeroCuenta = Int32.Parse(
                        valores[(int)IndiceTextBox.CUENTA]);

                    if (numeroCuenta > 0)
                    {

                        registro.Cuenta = numeroCuenta;
                        registro.PrimerNombre = valores[(int)IndiceTextBox.NOMBRE];
                        registro.ApellidoPaterno = valores[(int)IndiceTextBox.APELLIDO];
                        registro.Saldo = Decimal.Parse(valores[(int)IndiceTextBox.SALDO]);

                        archivoWritter.WriteLine(
                            registro.Cuenta + "," + registro.PrimerNombre + "," +
                            registro.ApellidoPaterno + "," + registro.Saldo);
                    }
                    else
                    {
                        MessageBox.Show("Numero de Cuenta Invalido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (IOException)
                {
                    MessageBox.Show("Error al Escrbir el Archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato Invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BorrarControlesTextBox();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (salida != null)
            {
                try
                {
                    archivoWritter.Close();
                    salida.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("No se Puede Cerrar el Archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Exit();

        }
    }
}