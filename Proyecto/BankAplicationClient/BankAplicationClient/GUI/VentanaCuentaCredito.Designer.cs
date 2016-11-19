namespace BankAplicationClient.GUI
{
    partial class VentanaCuentaCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoCredito = new System.Windows.Forms.TextBox();
            this.btnConsultaCredito = new System.Windows.Forms.Button();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTransparencia = new System.Windows.Forms.TabPage();
            this.txtMontoTransferir = new System.Windows.Forms.TextBox();
            this.btntransferir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaternoTransferir = new System.Windows.Forms.TextBox();
            this.txtMaternoTransferir = new System.Windows.Forms.TextBox();
            this.txtNombresTransferir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoCuentaTransferir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTransferir = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.btnConsultaMovimientosCredito = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabTransparencia.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabTransparencia);
            this.tabControl.Controls.Add(this.tabMovimientos);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(506, 364);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.textBox1);
            this.tabGeneral.Controls.Add(this.label6);
            this.tabGeneral.Controls.Add(this.label5);
            this.tabGeneral.Controls.Add(this.txtSaldoCredito);
            this.tabGeneral.Controls.Add(this.btnConsultaCredito);
            this.tabGeneral.Controls.Add(this.txtApellidoPaterno);
            this.tabGeneral.Controls.Add(this.txtApellidoMaterno);
            this.tabGeneral.Controls.Add(this.txtNoCuenta);
            this.tabGeneral.Controls.Add(this.txtNombres);
            this.tabGeneral.Controls.Add(this.label4);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(498, 338);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(127, 117);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(363, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "No. Tarjeta de credito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo Credito:";
            // 
            // txtSaldoCredito
            // 
            this.txtSaldoCredito.Enabled = false;
            this.txtSaldoCredito.Location = new System.Drawing.Point(114, 192);
            this.txtSaldoCredito.MaxLength = 100;
            this.txtSaldoCredito.Name = "txtSaldoCredito";
            this.txtSaldoCredito.ReadOnly = true;
            this.txtSaldoCredito.Size = new System.Drawing.Size(250, 20);
            this.txtSaldoCredito.TabIndex = 9;
            // 
            // btnConsultaCredito
            // 
            this.btnConsultaCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaCredito.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultaCredito.Location = new System.Drawing.Point(370, 192);
            this.btnConsultaCredito.Name = "btnConsultaCredito";
            this.btnConsultaCredito.Size = new System.Drawing.Size(120, 23);
            this.btnConsultaCredito.TabIndex = 8;
            this.btnConsultaCredito.Text = "Consulta Credito";
            this.btnConsultaCredito.UseVisualStyleBackColor = true;
            this.btnConsultaCredito.Click += new System.EventHandler(this.btnConsultaCredito_Click);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Enabled = false;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(127, 37);
            this.txtApellidoPaterno.MaxLength = 100;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(363, 20);
            this.txtApellidoPaterno.TabIndex = 7;
            this.txtApellidoPaterno.TabStop = false;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Enabled = false;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(127, 64);
            this.txtApellidoMaterno.MaxLength = 100;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(363, 20);
            this.txtApellidoMaterno.TabIndex = 6;
            this.txtApellidoMaterno.TabStop = false;
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Enabled = false;
            this.txtNoCuenta.Location = new System.Drawing.Point(127, 91);
            this.txtNoCuenta.MaxLength = 100;
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.ReadOnly = true;
            this.txtNoCuenta.Size = new System.Drawing.Size(363, 20);
            this.txtNoCuenta.TabIndex = 5;
            this.txtNoCuenta.TabStop = false;
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(127, 10);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(363, 20);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Cuenta:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // tabTransparencia
            // 
            this.tabTransparencia.Controls.Add(this.txtMontoTransferir);
            this.tabTransparencia.Controls.Add(this.btntransferir);
            this.tabTransparencia.Controls.Add(this.label11);
            this.tabTransparencia.Controls.Add(this.txtPaternoTransferir);
            this.tabTransparencia.Controls.Add(this.txtMaternoTransferir);
            this.tabTransparencia.Controls.Add(this.txtNombresTransferir);
            this.tabTransparencia.Controls.Add(this.label8);
            this.tabTransparencia.Controls.Add(this.label9);
            this.tabTransparencia.Controls.Add(this.label10);
            this.tabTransparencia.Controls.Add(this.txtNoCuentaTransferir);
            this.tabTransparencia.Controls.Add(this.label7);
            this.tabTransparencia.Controls.Add(this.cbTransferir);
            this.tabTransparencia.Controls.Add(this.label12);
            this.tabTransparencia.Location = new System.Drawing.Point(4, 22);
            this.tabTransparencia.Name = "tabTransparencia";
            this.tabTransparencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransparencia.Size = new System.Drawing.Size(498, 338);
            this.tabTransparencia.TabIndex = 1;
            this.tabTransparencia.Text = "Transferencia";
            this.tabTransparencia.UseVisualStyleBackColor = true;
            // 
            // txtMontoTransferir
            // 
            this.txtMontoTransferir.Location = new System.Drawing.Point(114, 157);
            this.txtMontoTransferir.Name = "txtMontoTransferir";
            this.txtMontoTransferir.Size = new System.Drawing.Size(295, 20);
            this.txtMontoTransferir.TabIndex = 29;
            // 
            // btntransferir
            // 
            this.btntransferir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntransferir.Location = new System.Drawing.Point(415, 155);
            this.btntransferir.Name = "btntransferir";
            this.btntransferir.Size = new System.Drawing.Size(75, 23);
            this.btntransferir.TabIndex = 28;
            this.btntransferir.Text = "Transferir";
            this.btntransferir.UseVisualStyleBackColor = true;
            this.btntransferir.Click += new System.EventHandler(this.btntransferir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Monto a transferir:";
            // 
            // txtPaternoTransferir
            // 
            this.txtPaternoTransferir.Location = new System.Drawing.Point(114, 85);
            this.txtPaternoTransferir.MaxLength = 100;
            this.txtPaternoTransferir.Name = "txtPaternoTransferir";
            this.txtPaternoTransferir.Size = new System.Drawing.Size(376, 20);
            this.txtPaternoTransferir.TabIndex = 26;
            this.txtPaternoTransferir.TabStop = false;
            // 
            // txtMaternoTransferir
            // 
            this.txtMaternoTransferir.Location = new System.Drawing.Point(114, 112);
            this.txtMaternoTransferir.MaxLength = 100;
            this.txtMaternoTransferir.Name = "txtMaternoTransferir";
            this.txtMaternoTransferir.Size = new System.Drawing.Size(376, 20);
            this.txtMaternoTransferir.TabIndex = 25;
            this.txtMaternoTransferir.TabStop = false;
            // 
            // txtNombresTransferir
            // 
            this.txtNombresTransferir.Location = new System.Drawing.Point(114, 58);
            this.txtNombresTransferir.MaxLength = 100;
            this.txtNombresTransferir.Name = "txtNombresTransferir";
            this.txtNombresTransferir.Size = new System.Drawing.Size(376, 20);
            this.txtNombresTransferir.TabIndex = 24;
            this.txtNombresTransferir.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Apellido Paterno:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Apellido Materno:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nombre(s):";
            // 
            // txtNoCuentaTransferir
            // 
            this.txtNoCuentaTransferir.Location = new System.Drawing.Point(168, 28);
            this.txtNoCuentaTransferir.MaxLength = 8;
            this.txtNoCuentaTransferir.Name = "txtNoCuentaTransferir";
            this.txtNoCuentaTransferir.Size = new System.Drawing.Size(322, 20);
            this.txtNoCuentaTransferir.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "No:";
            // 
            // cbTransferir
            // 
            this.cbTransferir.FormattingEnabled = true;
            this.cbTransferir.Items.AddRange(new object[] {
            "No. Cuenta",
            "No. Tajeta de debito "});
            this.cbTransferir.Location = new System.Drawing.Point(11, 28);
            this.cbTransferir.Name = "cbTransferir";
            this.cbTransferir.Size = new System.Drawing.Size(121, 21);
            this.cbTransferir.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ingresa el numero de cuenta o tarjeta de debito";
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.btnConsultaMovimientosCredito);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Size = new System.Drawing.Size(498, 338);
            this.tabMovimientos.TabIndex = 2;
            this.tabMovimientos.Text = "Movimientos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnConsultaMovimientosCredito
            // 
            this.btnConsultaMovimientosCredito.Location = new System.Drawing.Point(415, 307);
            this.btnConsultaMovimientosCredito.Name = "btnConsultaMovimientosCredito";
            this.btnConsultaMovimientosCredito.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaMovimientosCredito.TabIndex = 0;
            this.btnConsultaMovimientosCredito.Text = "Consultar";
            this.btnConsultaMovimientosCredito.UseVisualStyleBackColor = true;
            this.btnConsultaMovimientosCredito.Click += new System.EventHandler(this.btnConsultaMovimientosCredito_Click);
            // 
            // VentanaCuentaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 364);
            this.Controls.Add(this.tabControl);
            this.Name = "VentanaCuentaCredito";
            this.Text = "VentanaCuentaCredito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaCuentaCredito_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabTransparencia.ResumeLayout(false);
            this.tabTransparencia.PerformLayout();
            this.tabMovimientos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoCredito;
        private System.Windows.Forms.Button btnConsultaCredito;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTransparencia;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoTransferir;
        private System.Windows.Forms.Button btntransferir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPaternoTransferir;
        private System.Windows.Forms.TextBox txtMaternoTransferir;
        private System.Windows.Forms.TextBox txtNombresTransferir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoCuentaTransferir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTransferir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConsultaMovimientosCredito;
    }
}