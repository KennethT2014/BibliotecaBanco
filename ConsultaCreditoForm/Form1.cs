using System.Windows.Forms;
using System.IO;
using BibliotecaBanco;

namespace ConsultaCreditoForm
{
    public partial class ConsultaCreditoFrm : Form
    {
        private FileStream entrada;
        private StreamReader archivoReader;

        private String? nombreArchivo;
        public ConsultaCreditoFrm()
        {
            InitializeComponent();
        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult result = selectorArchivo.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            nombreArchivo = selectorArchivo.FileName;

            if (nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre de archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                entrada = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                archivoReader = new StreamReader(entrada);

                abrirButton.Enabled = false;
                obtenerSaldos.Enabled = true;
                debitoButton.Enabled = true;
                ceroButton.Enabled = true;
            }
        }

        private void obtenerSaldos_Click(object sender, System.EventArgs e)
        {
            Button emisorButton = (Button)sender;

            string tipoCuenta = emisorButton.Text;

            try
            {
                entrada.Seek(0, SeekOrigin.Begin);

                mostrarTextBox.Text = "Las cuentas son: \r\n";

                while (true)
                {
                    Registro registro;
                    decimal saldo;
                    //Se agrega el ? porque es valor podría ser nullo, y queremos que la variable permita nullo
                    string? registroEntrada = archivoReader.ReadLine();
                    String[] camposEntrada;

                    if (registroEntrada == null)
                    {
                        return;
                    }

                    camposEntrada = registroEntrada.Split(",");

                    registro = new Registro(
                        Convert.ToInt32(camposEntrada[0]), camposEntrada[1], 
                        camposEntrada[2], Convert.ToDecimal(camposEntrada[3]));

                    saldo = registro.Saldo;

                    if (DebeMostrar(saldo, tipoCuenta))
                    {
                        string salida = registro.Cuenta + "\t" +
                            registro.PrimerNombre + "\t" + registro.ApellidoPaterno + "\t";

                        salida = salida + String.Format("{0:F}", saldo) + "\r\n";

                        mostrarTextBox.Text += salida;
                    }

                    
                }
                
            }
            catch (IOException)
            {
                MessageBox.Show("No se puede leer el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DebeMostrar(decimal saldo, string tipoCuenta)
        {
            if (saldo > 0)
            {
                if (tipoCuenta == "Saldos con Credito")
                {
                    return true;
                }
            }
            else
            {
                if (saldo < 0)
                {
                    if (tipoCuenta == "Saldos con Debito")
                    {
                        return true;
                    }
                }
                else
                {
                    if (tipoCuenta == "Saldos en Cero")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void terminarButton_Click(object sender, EventArgs e)
        {
            if (entrada != null)
            {
                try
                {
                    entrada.Close();
                    archivoReader.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Exit();
        }
    }
}