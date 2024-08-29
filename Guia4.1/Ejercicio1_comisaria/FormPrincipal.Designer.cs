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
            this.btnListarCostos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaEnvio
            // 
            this.btnAltaEnvio.Location = new System.Drawing.Point(395, 31);
            this.btnAltaEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaEnvio.Name = "btnAltaEnvio";
            this.btnAltaEnvio.Size = new System.Drawing.Size(138, 49);
            this.btnAltaEnvio.TabIndex = 0;
            this.btnAltaEnvio.Text = "Alta Envio(1)";
            this.btnAltaEnvio.UseVisualStyleBackColor = true;
            this.btnAltaEnvio.Click += new System.EventHandler(this.btnAltaEnvio_Click);
            // 
            // btnListarCostos
            // 
            this.btnListarCostos.Location = new System.Drawing.Point(395, 149);
            this.btnListarCostos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarCostos.Name = "btnListarCostos";
            this.btnListarCostos.Size = new System.Drawing.Size(138, 49);
            this.btnListarCostos.TabIndex = 1;
            this.btnListarCostos.Text = "Listar Costos (2)";
            this.btnListarCostos.UseVisualStyleBackColor = true;
            this.btnListarCostos.Click += new System.EventHandler(this.btnListarCostos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 196);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Alta Costo(1)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListarCostos);
            this.Controls.Add(this.btnAltaEnvio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.Button btnListarCostos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

