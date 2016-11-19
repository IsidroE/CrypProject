namespace BankAplicationClient.GUI
{
    partial class VentanaMovimientos
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
            this.btnConsultaTodosMovimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaTodosMovimientos
            // 
            this.btnConsultaTodosMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultaTodosMovimientos.Location = new System.Drawing.Point(383, 421);
            this.btnConsultaTodosMovimientos.Name = "btnConsultaTodosMovimientos";
            this.btnConsultaTodosMovimientos.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaTodosMovimientos.TabIndex = 0;
            this.btnConsultaTodosMovimientos.Text = "Consultar";
            this.btnConsultaTodosMovimientos.UseVisualStyleBackColor = true;
            this.btnConsultaTodosMovimientos.Click += new System.EventHandler(this.btnConsultaTodosMovimientos_Click);
            // 
            // VentanaMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 456);
            this.Controls.Add(this.btnConsultaTodosMovimientos);
            this.Name = "VentanaMovimientos";
            this.Text = "VentanaMovimientos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaTodosMovimientos;
    }
}