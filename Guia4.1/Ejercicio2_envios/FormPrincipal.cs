using Ejercicio2.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Logistica empresa = new Logistica();
        Envio env;
        public FormPrincipal()
        {
            InitializeComponent();

            cbCostos.Items.Add(new Fijo("Peaje puente Zárate", 300));
            cbCostos.Items.Add(new Variable("Combustible", 1500.5, 500));
            cbCostos.Items.Add(new Fijo("Peaje túnel", 300));
            cbCostos.Items.Add(new Variable("Horas de conducción", 500, 10));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigoAduanero = Convert.ToInt32(tbCodigoAduanero.Text);
            env= empresa.VerEnvio(codigoAduanero);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int codigoAduanero = Convert.ToInt32(tbCodigoAduanero.Text);

            env = new Envio(codigoAduanero);
            
        }
        private void btnGuardarEnvio_Click(object sender, EventArgs e)
        {
            empresa.AgregarEnvio(env);
            env = null;
        }

        private void btnAgregarCosto_Click(object sender, EventArgs e)
        {
            Costo costo = cbCostos.SelectedItem as Costo;
            env.AgregarCosto(costo);
            
            tbDetalleCosto.Clear();
            cbCostos.SelectedIndex = -1;
        }

        private void btnListasEnvios_Click(object sender, EventArgs e)
        {
            for(int idx = 0; idx < empresa.CantidadEnvios; idx++)
            {
                Envio env = empresa.VerEnvio(idx);

                tbEnvios.Text += env.VerDetalle();
                tbEnvios.Text += $"Total:$ {env.ValorTotal,10:f2}\r\n\r\n";
            }
        }

        private void cbCostos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Costo costo = cbCostos.SelectedItem as Costo;
            tbDetalleCosto.Text = costo.VerDetalle();
        }
    }
}