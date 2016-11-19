namespace BankAplicationClient.GUI
{
    partial class VentanaPrincipal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Estado = new System.Windows.Forms.StatusStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnConsultaMovimientos = new System.Windows.Forms.Button();
            this.btnCuentaCredito = new System.Windows.Forms.Button();
            this.btnCuentaAhorro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(0, 539);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(784, 22);
            this.Estado.TabIndex = 1;
            this.Estado.Text = "statusStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnConsultaMovimientos);
            this.splitContainer.Panel1.Controls.Add(this.btnCuentaCredito);
            this.splitContainer.Panel1.Controls.Add(this.btnCuentaAhorro);
            this.splitContainer.Size = new System.Drawing.Size(784, 515);
            this.splitContainer.SplitterDistance = 261;
            this.splitContainer.TabIndex = 2;
            // 
            // btnConsultaMovimientos
            // 
            this.btnConsultaMovimientos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultaMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultaMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultaMovimientos.Location = new System.Drawing.Point(0, 90);
            this.btnConsultaMovimientos.Name = "btnConsultaMovimientos";
            this.btnConsultaMovimientos.Size = new System.Drawing.Size(261, 45);
            this.btnConsultaMovimientos.TabIndex = 2;
            this.btnConsultaMovimientos.Text = "Consulta Movimientos";
            this.btnConsultaMovimientos.UseVisualStyleBackColor = false;
            this.btnConsultaMovimientos.Click += new System.EventHandler(this.btnConsultaMovimientos_Click);
            // 
            // btnCuentaCredito
            // 
            this.btnCuentaCredito.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuentaCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCuentaCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentaCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuentaCredito.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCuentaCredito.Location = new System.Drawing.Point(0, 45);
            this.btnCuentaCredito.Name = "btnCuentaCredito";
            this.btnCuentaCredito.Size = new System.Drawing.Size(261, 45);
            this.btnCuentaCredito.TabIndex = 1;
            this.btnCuentaCredito.Text = "Cuenta de Credito";
            this.btnCuentaCredito.UseVisualStyleBackColor = false;
            this.btnCuentaCredito.Click += new System.EventHandler(this.btnCuentaCredito_Click);
            // 
            // btnCuentaAhorro
            // 
            this.btnCuentaAhorro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuentaAhorro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCuentaAhorro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentaAhorro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuentaAhorro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCuentaAhorro.Location = new System.Drawing.Point(0, 0);
            this.btnCuentaAhorro.Name = "btnCuentaAhorro";
            this.btnCuentaAhorro.Size = new System.Drawing.Size(261, 45);
            this.btnCuentaAhorro.TabIndex = 0;
            this.btnCuentaAhorro.Text = "Cuenta de Ahorro";
            this.btnCuentaAhorro.UseVisualStyleBackColor = false;
            this.btnCuentaAhorro.Click += new System.EventHandler(this.btnCuentaAhorro_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de banco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip Estado;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnConsultaMovimientos;
        private System.Windows.Forms.Button btnCuentaCredito;
        private System.Windows.Forms.Button btnCuentaAhorro;
    }
}