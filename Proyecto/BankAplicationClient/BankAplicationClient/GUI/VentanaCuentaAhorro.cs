using BankAplicationClient.Control;
using BankAplicationClient.POJO;
using System;
using System.Windows.Forms;

namespace BankAplicationClient.GUI
{
    public partial class VentanaCuentaAhorro : Form
    {
        Controlador controlador;
        public VentanaCuentaAhorro(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultaSaldo_Click(object sender, EventArgs e)
        {
            if(controlador.ConsultaSaldo(Operacion.CONSULTA_AHORRO))
            {
                MessageBox.Show("operacion exitosa!", "Correcto");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al consultar su saldo", "Error");
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            Cliente c = controlador.getUsuario();
            txtNombres.Text = c.Nombres;
            txtApellidoPaterno.Text = c.ApellidoPaterno;
            txtApellidoMaterno.Text = c.ApellidoMaterno;
            txtNoCuenta.Text = c.NoCuenta.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaTransferencia())
            {
                TransferenciaExterna te = new TransferenciaExterna();
                te.Nombres = (txtNombreTransferir.Text);
                te.ApellidoPaterno = (txtPaternoTransferir.Text);
                te.ApellidoMaterno = (txtMaternoTransferir.Text);
                te.NoCuenta = (Int32.Parse(txtMontoTransferir.Text));
                te.Tipo =(cbTranferir.SelectedIndex);
                if (controlador.transferir(te))
                {
                    MessageBox.Show("La trnasferencia fue exitosa", "Correcto");
                }
                else
                {
                    MessageBox.Show("Transferencia sin exito", "Error");
                }
            }
        }

        private bool ValidaTransferencia()
        {
            bool bandera= false;
            if(cbTranferir.SelectedIndex != (-1) 
                && txtMontoTransferir.TextLength != 0 
                && txtNoCuentaTransferir.TextLength != 0
                && txtNombreTransferir.TextLength != 0
                && txtPaternoTransferir.TextLength != 0 
                && txtMaternoTransferir.TextLength != 0)
            {
                bandera = true;
            }else
            {
                MessageBox.Show("Llene todos los campos", "Error");
            }
            return bandera;
        }

        private void btnConsultaMovimientosAhorro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo sentimos esta operacion aun no funciona (je je aun no se usar tablas)", "Error: XD");
        }
    }
}
