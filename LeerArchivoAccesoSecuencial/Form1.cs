using System;
using System.Windows.Forms;
using System.IO;
using BibliotecaBanco;

namespace LeerArchivoAccesoSecuencial
{
    public partial class frmLeerArchivoAccesoSecuencial : frmBancoUI
    {
        private FileStream entrada;
        private StreamReader archivoReader;

        public frmLeerArchivoAccesoSecuencial()
        {
            InitializeComponent();
        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();

            string nombreArchivo;
            if (resultado == DialogResult.Cancel)
            return;

            nombreArchivo = selectorArchivo.FileName;
            BorrarControlesTextBox();
            if (nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre de archivo inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                entrada = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);

                archivoReader = new StreamReader(entrada);

                abrirButton.Enabled = false;
                siguienteButton.Enabled = true;
            }
        }

        private void siguienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string registroEntrada = archivoReader.ReadLine();
                string[] camposEntrada;

                if (registroEntrada != null)
                {
                    camposEntrada = registroEntrada.Split(',');

                    Registro regisstro = new Registro(
                        Convert.ToInt32(camposEntrada[0]), camposEntrada[1],
                        camposEntrada[2], Convert.ToDecimal(camposEntrada[3]));

                    EstablecerValoresControlesTextBox(camposEntrada);
                }
                else
                {
                    archivoReader.Close();
                    entrada.Close();
                    abrirButton.Enabled = true;
                    siguienteButton.Enabled=false;
                    BorrarControlesTextBox();

                    MessageBox.Show("No hay más registros en el archivo","",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error al leer del archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}