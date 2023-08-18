using System;
using System.Windows.Forms;
namespace BibliotecaBanco
{
    public partial class frmBancoUI : Form
    {
        protected int CuentaTextBox = 4;

        public enum IndiceTextBox
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO
        }
        public frmBancoUI()
        {
            InitializeComponent();
        }
        public void BorrarControlesTextBox()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i];

                if (miControl is TextBox)
                {
                    miControl.Text = "";
                }
            }
        }

        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            if (valores.Length != CuentaTextBox)
            {
                throw (new ArgumentException("Debe Haber " +
                    (CuentaTextBox + 1) + "objetos string en el arreglo"));
            }
            else
            {
                txtCuenta.Text = valores[(int) IndiceTextBox.CUENTA];
                txtPrimerNombre.Text = valores[(int) IndiceTextBox.NOMBRE];
                txtApellido.Text = valores[(int) IndiceTextBox.APELLIDO];
                txtSaldo.Text = valores[(int) IndiceTextBox.SALDO];
            }
           
        }
        public string[] ObtenerValoresControlesTextBox()
        {
            string[] valores = new string[CuentaTextBox];

            valores[(int) IndiceTextBox.CUENTA] = txtCuenta.Text;
            valores[(int) IndiceTextBox.NOMBRE] = txtPrimerNombre.Text;
            valores[(int) IndiceTextBox.APELLIDO] = txtApellido.Text;
            valores[(int) IndiceTextBox.SALDO] = txtSaldo.Text;

            return valores;
        }

    }
}