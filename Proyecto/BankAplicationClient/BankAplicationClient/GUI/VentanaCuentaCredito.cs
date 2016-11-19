﻿using BankAplicationClient.Control;
using BankAplicationClient.POJO;
using System;
using System.Windows.Forms;

namespace BankAplicationClient.GUI
{
    public partial class VentanaCuentaCredito : Form
    {
        Controlador controlador;
        public VentanaCuentaCredito(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void VentanaCuentaCredito_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You did not enter a server name. Cancel this operation?",
                "Error Detected in Input", 
                MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            Cliente c = controlador.getUsuario();
            txtNombres.Text = c.getNombres();
            txtApellidoPaterno.Text = c.getApellidoPaterno();
            txtApellidoMaterno.Text = c.getApellidoMaterno();
            txtNoCuenta.Text = c.getNoCuenta().ToString();
        }

        private void btnConsultaMovimientosCredito_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Lo sentimos esta operacion aun no funciona (je je aun no se usar tablas)", "Error: XD");
        }

        private void btntransferir_Click(object sender, System.EventArgs e)
        {
            if (ValidaTransferencia())
            {
                TransferenciaExterna te = new TransferenciaExterna();
                te.setNombres(txtNombresTransferir.Text);
                te.setApellidoPaterno(txtPaternoTransferir.Text);
                te.setApellidoMaterno(txtMaternoTransferir.Text);
                te.setNoCuenta(Int32.Parse(txtMontoTransferir.Text));
                te.setTipo(cbTransferir.SelectedIndex);
                if (controlador.transferir(te))
                {
                    MessageBox.Show("La trnasferencia fue exitosa", "Correcto");
                } else
                {
                    MessageBox.Show("Transferencia sin exito", "Error");
                }
            }
        }

        private bool ValidaTransferencia()
        {
            bool bandera = false;
            if (cbTransferir.SelectedIndex != (-1)
                && txtMontoTransferir.TextLength != 0
                && txtNoCuentaTransferir.TextLength != 0
                && txtNombresTransferir.TextLength != 0
                && txtPaternoTransferir.TextLength != 0
                && txtMaternoTransferir.TextLength != 0)
            {
                bandera = true;
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Error");
            }
            return bandera;
        }

        private void btnConsultaCredito_Click(object sender, EventArgs e)
        {
            if (controlador.ConsultaSaldo())
            {
                MessageBox.Show("operacion exitosa!", "Correcto");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al consultar su saldo", "Error");
            }
        }
    }
}
