namespace Ejercicio2
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
            this.tbEnvios = new System.Windows.Forms.TextBox();
            this.tbCodigoAduanero = new System.Windows.Forms.TextBox();
            this.btnVerAltaEnvio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbEdicionCostos = new System.Windows.Forms.GroupBox();
            this.lbxVerCostos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarEnvio = new System.Windows.Forms.Button();
            this.btnAgregarCosto = new System.Windows.Forms.Button();
            this.cbCostos = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListasEnvios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbEdicionCostos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEnvios
            // 
            this.tbEnvios.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnvios.Location = new System.Drawing.Point(10, 33);
            this.tbEnvios.Multiline = true;
            this.tbEnvios.Name = "tbEnvios";
            this.tbEnvios.Size = new System.Drawing.Size(333, 140);
            this.tbEnvios.TabIndex = 2;
            // 
            // tbCodigoAduanero
            // 
            this.tbCodigoAduanero.Location = new System.Drawing.Point(12, 60);
            this.tbCodigoAduanero.Name = "tbCodigoAduanero";
            this.tbCodigoAduanero.Size = new System.Drawing.Size(331, 26);
            this.tbCodigoAduanero.TabIndex = 3;
            // 
            // btnVerAltaEnvio
            // 
            this.btnVerAltaEnvio.Location = new System.Drawing.Point(353, 51);
            this.btnVerAltaEnvio.Name = "btnVerAltaEnvio";
            this.btnVerAltaEnvio.Size = new System.Drawing.Size(153, 45);
            this.btnVerAltaEnvio.TabIndex = 5;
            this.btnVerAltaEnvio.Text = "Ver/Alta Envío";
            this.btnVerAltaEnvio.UseVisualStyleBackColor = true;
            this.btnVerAltaEnvio.Click += new System.EventHandler(this.btnVerAltaEnvio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCodigoAduanero);
            this.groupBox1.Controls.Add(this.btnVerAltaEnvio);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver/Alta de Envío";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(130, 126);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(0, 20);
            this.lbEmpresa.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Empresa de transporte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código Aduanero";
            // 
            // gbEdicionCostos
            // 
            this.gbEdicionCostos.Controls.Add(this.lbxVerCostos);
            this.gbEdicionCostos.Controls.Add(this.label4);
            this.gbEdicionCostos.Controls.Add(this.label3);
            this.gbEdicionCostos.Controls.Add(this.label1);
            this.gbEdicionCostos.Controls.Add(this.btnGuardarEnvio);
            this.gbEdicionCostos.Controls.Add(this.btnAgregarCosto);
            this.gbEdicionCostos.Controls.Add(this.cbCostos);
            this.gbEdicionCostos.Enabled = false;
            this.gbEdicionCostos.Location = new System.Drawing.Point(14, 175);
            this.gbEdicionCostos.Name = "gbEdicionCostos";
            this.gbEdicionCostos.Size = new System.Drawing.Size(512, 232);
            this.gbEdicionCostos.TabIndex = 7;
            this.gbEdicionCostos.TabStop = false;
            this.gbEdicionCostos.Text = "Edición de costos";
            // 
            // lbxVerCostos
            // 
            this.lbxVerCostos.FormattingEnabled = true;
            this.lbxVerCostos.ItemHeight = 20;
            this.lbxVerCostos.Location = new System.Drawing.Point(12, 121);
            this.lbxVerCostos.Name = "lbxVerCostos";
            this.lbxVerCostos.Size = new System.Drawing.Size(331, 84);
            this.lbxVerCostos.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Costos";
            // 
            // btnGuardarEnvio
            // 
            this.btnGuardarEnvio.Location = new System.Drawing.Point(353, 160);
            this.btnGuardarEnvio.Name = "btnGuardarEnvio";
            this.btnGuardarEnvio.Size = new System.Drawing.Size(149, 45);
            this.btnGuardarEnvio.TabIndex = 7;
            this.btnGuardarEnvio.Text = "Guardar Envio";
            this.btnGuardarEnvio.UseVisualStyleBackColor = true;
            this.btnGuardarEnvio.Click += new System.EventHandler(this.btnGuardarEnvio_Click);
            // 
            // btnAgregarCosto
            // 
            this.btnAgregarCosto.Location = new System.Drawing.Point(353, 34);
            this.btnAgregarCosto.Name = "btnAgregarCosto";
            this.btnAgregarCosto.Size = new System.Drawing.Size(153, 65);
            this.btnAgregarCosto.TabIndex = 6;
            this.btnAgregarCosto.Text = "Seleccionar y Agregar Costo";
            this.btnAgregarCosto.UseVisualStyleBackColor = true;
            this.btnAgregarCosto.Click += new System.EventHandler(this.btnAgregarCosto_Click);
            // 
            // cbCostos
            // 
            this.cbCostos.FormattingEnabled = true;
            this.cbCostos.Location = new System.Drawing.Point(10, 57);
            this.cbCostos.Name = "cbCostos";
            this.cbCostos.Size = new System.Drawing.Size(333, 28);
            this.cbCostos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListasEnvios);
            this.groupBox3.Controls.Add(this.tbEnvios);
            this.groupBox3.Location = new System.Drawing.Point(14, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 179);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Envíos cargados";
            // 
            // btnListasEnvios
            // 
            this.btnListasEnvios.Location = new System.Drawing.Point(353, 33);
            this.btnListasEnvios.Name = "btnListasEnvios";
            this.btnListasEnvios.Size = new System.Drawing.Size(149, 73);
            this.btnListasEnvios.TabIndex = 9;
            this.btnListasEnvios.Text = "Listar Envios existentes";
            this.btnListasEnvios.UseVisualStyleBackColor = true;
            this.btnListasEnvios.Click += new System.EventHandler(this.btnListasEnvios_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbEdicionCostos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEdicionCostos.ResumeLayout(false);
            this.gbEdicionCostos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbEnvios;
        private System.Windows.Forms.TextBox tbCodigoAduanero;
        private System.Windows.Forms.Button btnVerAltaEnvio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbEdicionCostos;
        private System.Windows.Forms.Button btnGuardarEnvio;
        private System.Windows.Forms.Button btnAgregarCosto;
        private System.Windows.Forms.ComboBox cbCostos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnListasEnvios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxVerCostos;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Label label2;
    }
}

