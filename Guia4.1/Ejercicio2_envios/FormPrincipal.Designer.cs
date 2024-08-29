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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDetalleCosto = new System.Windows.Forms.TextBox();
            this.btnGuardarEnvio = new System.Windows.Forms.Button();
            this.btnAgregarCosto = new System.Windows.Forms.Button();
            this.cbCostos = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListasEnvios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEnvios
            // 
            this.tbEnvios.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnvios.Location = new System.Drawing.Point(10, 33);
            this.tbEnvios.Multiline = true;
            this.tbEnvios.Name = "tbEnvios";
            this.tbEnvios.Size = new System.Drawing.Size(337, 140);
            this.tbEnvios.TabIndex = 2;
            // 
            // tbCodigoAduanero
            // 
            this.tbCodigoAduanero.Location = new System.Drawing.Point(58, 60);
            this.tbCodigoAduanero.Name = "tbCodigoAduanero";
            this.tbCodigoAduanero.Size = new System.Drawing.Size(285, 26);
            this.tbCodigoAduanero.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(353, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 45);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.tbCodigoAduanero);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver/Alta de Envío";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo de Costo";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(353, 76);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(153, 45);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Envío";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbDetalleCosto);
            this.groupBox2.Controls.Add(this.btnGuardarEnvio);
            this.groupBox2.Controls.Add(this.btnAgregarCosto);
            this.groupBox2.Controls.Add(this.cbCostos);
            this.groupBox2.Location = new System.Drawing.Point(14, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición de costos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 88);
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
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Costos";
            // 
            // tbDetalleCosto
            // 
            this.tbDetalleCosto.Location = new System.Drawing.Point(58, 111);
            this.tbDetalleCosto.Multiline = true;
            this.tbDetalleCosto.Name = "tbDetalleCosto";
            this.tbDetalleCosto.Size = new System.Drawing.Size(285, 64);
            this.tbDetalleCosto.TabIndex = 8;
            // 
            // btnGuardarEnvio
            // 
            this.btnGuardarEnvio.Location = new System.Drawing.Point(353, 181);
            this.btnGuardarEnvio.Name = "btnGuardarEnvio";
            this.btnGuardarEnvio.Size = new System.Drawing.Size(153, 45);
            this.btnGuardarEnvio.TabIndex = 7;
            this.btnGuardarEnvio.Text = "Guardar Enviio";
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
            this.cbCostos.Location = new System.Drawing.Point(58, 53);
            this.cbCostos.Name = "cbCostos";
            this.cbCostos.Size = new System.Drawing.Size(285, 28);
            this.cbCostos.TabIndex = 0;
            this.cbCostos.SelectedIndexChanged += new System.EventHandler(this.cbCostos_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListasEnvios);
            this.groupBox3.Controls.Add(this.tbEnvios);
            this.groupBox3.Location = new System.Drawing.Point(14, 386);
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
            this.btnListasEnvios.Size = new System.Drawing.Size(153, 73);
            this.btnListasEnvios.TabIndex = 9;
            this.btnListasEnvios.Text = "Listar Envios existentes";
            this.btnListasEnvios.UseVisualStyleBackColor = true;
            this.btnListasEnvios.Click += new System.EventHandler(this.btnListasEnvios_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 568);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbEnvios;
        private System.Windows.Forms.TextBox tbCodigoAduanero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDetalleCosto;
        private System.Windows.Forms.Button btnGuardarEnvio;
        private System.Windows.Forms.Button btnAgregarCosto;
        private System.Windows.Forms.ComboBox cbCostos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnListasEnvios;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

