namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaEnvio = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAltaEnvio
            // 
            this.btnAltaEnvio.Location = new System.Drawing.Point(549, 184);
            this.btnAltaEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaEnvio.Name = "btnAltaEnvio";
            this.btnAltaEnvio.Size = new System.Drawing.Size(106, 49);
            this.btnAltaEnvio.TabIndex = 0;
            this.btnAltaEnvio.Text = "Prueba";
            this.btnAltaEnvio.UseVisualStyleBackColor = true;
            this.btnAltaEnvio.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // tbVer
            // 
            this.tbVer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVer.Location = new System.Drawing.Point(12, 12);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.Size = new System.Drawing.Size(530, 406);
            this.tbVer.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 430);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btnAltaEnvio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio1 procesador de envíos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.TextBox tbVer;
    }
}

