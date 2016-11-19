using BankAplicationClient.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAplicationClient.GUI
{
    public partial class VentanaMovimientos : Form
    {
        Controlador controlador;
        public VentanaMovimientos(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void btnConsultaTodosMovimientos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo sentimos esta operacion aun no funciona (je je aun no se usar tablas)", "Error: XD");
        }
    }
}
