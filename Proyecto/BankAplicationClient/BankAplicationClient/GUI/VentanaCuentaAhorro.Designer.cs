namespace BankAplicationClient.GUI
{
    partial class VentanaCuentaAhorro
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnConsultaSaldo = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaternoTransferir = new System.Windows.Forms.TextBox();
            this.txtMaternoTransferir = new System.Windows.Forms.TextBox();
            this.txtNombreTransferir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoCuentaTransferir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTranferir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.btnConsultaMovimientosAhorro = new System.Windows.Forms.Button();
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
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.label5);
            this.tabGeneral.Controls.Add(this.txtSaldo);
            this.tabGeneral.Controls.Add(this.btnConsultaSaldo);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo Ahorro:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(114, 163);
            this.txtSaldo.MaxLength = 100;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(250, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // btnConsultaSaldo
            // 
            this.btnConsultaSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaSaldo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultaSaldo.Location = new System.Drawing.Point(370, 163);
            this.btnConsultaSaldo.Name = "btnConsultaSaldo";
            this.btnConsultaSaldo.Size = new System.Drawing.Size(120, 23);
            this.btnConsultaSaldo.TabIndex = 8;
            this.btnConsultaSaldo.Text = "Consulta Saldo";
            this.btnConsultaSaldo.UseVisualStyleBackColor = true;
            this.btnConsultaSaldo.Click += new System.EventHandler(this.btnConsultaSaldo_Click);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Enabled = false;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(114, 37);
            this.txtApellidoPaterno.MaxLength = 100;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(376, 20);
            this.txtApellidoPaterno.TabIndex = 7;
            this.txtApellidoPaterno.TabStop = false;
            this.txtApellidoPaterno.TextChanged += new System.EventHandler(this.txtApellidoPaterno_TextChanged);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Enabled = false;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(114, 64);
            this.txtApellidoMaterno.MaxLength = 100;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(376, 20);
            this.txtApellidoMaterno.TabIndex = 6;
            this.txtApellidoMaterno.TabStop = false;
            this.txtApellidoMaterno.TextChanged += new System.EventHandler(this.txtApellidoMaterno_TextChanged);
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Enabled = false;
            this.txtNoCuenta.Location = new System.Drawing.Point(114, 91);
            this.txtNoCuenta.MaxLength = 100;
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.ReadOnly = true;
            this.txtNoCuenta.Size = new System.Drawing.Size(376, 20);
            this.txtNoCuenta.TabIndex = 5;
            this.txtNoCuenta.TabStop = false;
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(114, 10);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(376, 20);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TabStop = false;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabTransparencia
            // 
            this.tabTransparencia.Controls.Add(this.txtMontoTransferir);
            this.tabTransparencia.Controls.Add(this.button1);
            this.tabTransparencia.Controls.Add(this.label11);
            this.tabTransparencia.Controls.Add(this.txtPaternoTransferir);
            this.tabTransparencia.Controls.Add(this.txtMaternoTransferir);
            this.tabTransparencia.Controls.Add(this.txtNombreTransferir);
            this.tabTransparencia.Controls.Add(this.label8);
            this.tabTransparencia.Controls.Add(this.label9);
            this.tabTransparencia.Controls.Add(this.label10);
            this.tabTransparencia.Controls.Add(this.txtNoCuentaTransferir);
            this.tabTransparencia.Controls.Add(this.label7);
            this.tabTransparencia.Controls.Add(this.cbTranferir);
            this.tabTransparencia.Controls.Add(this.label6);
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
            this.txtMontoTransferir.Location = new System.Drawing.Point(114, 158);
            this.txtMontoTransferir.Name = "txtMontoTransferir";
            this.txtMontoTransferir.Size = new System.Drawing.Size(295, 20);
            this.txtMontoTransferir.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(415, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Transferir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Monto a transferir:";
            // 
            // txtPaternoTransferir
            // 
            this.txtPaternoTransferir.Location = new System.Drawing.Point(114, 86);
            this.txtPaternoTransferir.MaxLength = 100;
            this.txtPaternoTransferir.Name = "txtPaternoTransferir";
            this.txtPaternoTransferir.Size = new System.Drawing.Size(376, 20);
            this.txtPaternoTransferir.TabIndex = 13;
            this.txtPaternoTransferir.TabStop = false;
            // 
            // txtMaternoTransferir
            // 
            this.txtMaternoTransferir.Location = new System.Drawing.Point(114, 113);
            this.txtMaternoTransferir.MaxLength = 100;
            this.txtMaternoTransferir.Name = "txtMaternoTransferir";
            this.txtMaternoTransferir.Size = new System.Drawing.Size(376, 20);
            this.txtMaternoTransferir.TabIndex = 12;
            this.txtMaternoTransferir.TabStop = false;
            // 
            // txtNombreTransferir
            // 
            this.txtNombreTransferir.Location = new System.Drawing.Point(114, 59);
            this.txtNombreTransferir.MaxLength = 100;
            this.txtNombreTransferir.Name = "txtNombreTransferir";
            this.txtNombreTransferir.Size = new System.Drawing.Size(376, 20);
            this.txtNombreTransferir.TabIndex = 11;
            this.txtNombreTransferir.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Apellido Paterno:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Apellido Materno:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nombre(s):";
            // 
            // txtNoCuentaTransferir
            // 
            this.txtNoCuentaTransferir.Location = new System.Drawing.Point(168, 29);
            this.txtNoCuentaTransferir.MaxLength = 8;
            this.txtNoCuentaTransferir.Name = "txtNoCuentaTransferir";
            this.txtNoCuentaTransferir.Size = new System.Drawing.Size(322, 20);
            this.txtNoCuentaTransferir.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "No:";
            // 
            // cbTranferir
            // 
            this.cbTranferir.FormattingEnabled = true;
            this.cbTranferir.Items.AddRange(new object[] {
            "No. Cuenta",
            "No. Tajeta de debito "});
            this.cbTranferir.Location = new System.Drawing.Point(11, 29);
            this.cbTranferir.Name = "cbTranferir";
            this.cbTranferir.Size = new System.Drawing.Size(121, 21);
            this.cbTranferir.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresa el numero de cuenta o tarjeta de debito";
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.btnConsultaMovimientosAhorro);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Size = new System.Drawing.Size(498, 338);
            this.tabMovimientos.TabIndex = 2;
            this.tabMovimientos.Text = "Movimientos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnConsultaMovimientosAhorro
            // 
            this.btnConsultaMovimientosAhorro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultaMovimientosAhorro.Location = new System.Drawing.Point(415, 307);
            this.btnConsultaMovimientosAhorro.Name = "btnConsultaMovimientosAhorro";
            this.btnConsultaMovimientosAhorro.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaMovimientosAhorro.TabIndex = 0;
            this.btnConsultaMovimientosAhorro.Text = "Consultar";
            this.btnConsultaMovimientosAhorro.UseVisualStyleBackColor = true;
            this.btnConsultaMovimientosAhorro.Click += new System.EventHandler(this.btnConsultaMovimientosAhorro_Click);
            // 
            // VentanaCuentaAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 364);
            this.Controls.Add(this.tabControl);
            this.Name = "VentanaCuentaAhorro";
            this.Text = "VentanaCuentaAhorro";
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
        private System.Windows.Forms.TabPage tabTransparencia;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnConsultaSaldo;
        private System.Windows.Forms.ComboBox cbTranferir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoCuentaTransferir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontoTransferir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPaternoTransferir;
        private System.Windows.Forms.TextBox txtMaternoTransferir;
        private System.Windows.Forms.TextBox txtNombreTransferir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConsultaMovimientosAhorro;
    }
}