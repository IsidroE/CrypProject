using BankAplicationClient.Control;
using BankAplicationClient.POJO;
using System;
using System.Windows.Forms;

namespace BankAplicationClient.GUI
{
    public partial class Login : Form
    {
        Controlador controlador;
        string idCuenta;
        string pasword;
        public Login(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPOJO log = new LoginPOJO();
            if (ValidaCampos())
            {
                log.IdCuenta = idCuenta;
                log.Pasword = pasword;
                if (controlador.login(log))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private bool ValidaCampos()
        {
            bool bandera = false;
            idCuenta = txtIdCuenta.Text.Trim();
            pasword = txtPassword.Text.Trim();

            if (idCuenta.Length != 0 && pasword.Length != 0)
            {
                if (idCuenta.Length == 8)
                {
                    bandera = true;
                }
                else
                {
                    MessageBox.Show("El Id de Cuenta debe ser de 8 digitos", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK);
            }
            return bandera;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desa salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controlador.salir();
                Application.Exit();
            }
        }
    }
}
