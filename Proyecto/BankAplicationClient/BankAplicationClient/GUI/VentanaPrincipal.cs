using BankAplicationClient.Control;
using System;
using System.Windows.Forms;

namespace BankAplicationClient.GUI
{
    public partial class VentanaPrincipal : Form
    {
        Controlador controlador = new Controlador();

        public VentanaPrincipal()
        {
            login();
            InitializeComponent();
        }

        private void login()
        {
            Login login = new Login(controlador);
            if (login.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Bienvenido", "Aceso exitoso");
            }
        }

        private void btnCuentaAhorro_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new VentanaCuentaAhorro(controlador));
        }

        private void btnCuentaCredito_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new VentanaCuentaCredito(controlador));
        }

        private void btnConsultaMovimientos_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new VentanaMovimientos(controlador));
        }

        private void AddFormInPanel(object formHijo)
        {
            if (this.splitContainer.Panel2.Controls.Count > 0)
                this.splitContainer.Panel2.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(fh);
            this.splitContainer.Panel2.Tag = fh;
            fh.Show();

        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult Mensaje = MessageBox.Show("¿Está seguro que desea cerrar el Formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Mensaje == DialogResult.Yes)
                {
                    controlador.salir();
                    e.Cancel = false;
                } else
                {
                    e.Cancel = true;
                }
                    
            }
        }
    }
}
