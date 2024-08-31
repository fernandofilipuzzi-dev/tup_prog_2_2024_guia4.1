
using Ejercicio2.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Logistica logistica = new Logistica();
        Envio envioSeleccionado;

        public FormPrincipal()
        {
            InitializeComponent();

            #region inicializando algunos costos
            cbCostos.Items.Add(new Fijo("Peaje puente Zárate", 300));
            cbCostos.Items.Add(new Variable("Combustible", 1500.5, 500));
            cbCostos.Items.Add(new Fijo("Peaje túnel", 300));
            cbCostos.Items.Add(new Variable("Horas de conducción", 500, 10));
            #endregion
        }

        private void btnVerAltaEnvio_Click(object sender, EventArgs e)
        {
            int codigoAduanero = Convert.ToInt32(tbCodigoAduanero.Text);
            int idx= logistica.VerEnvioPorCodigo(codigoAduanero);
            envioSeleccionado = null;

            if (idx >= 0)
            {
                envioSeleccionado = logistica.VerEnvio(idx);
            }
            else
            {
                #region alta envio
                FormDatos formDatos = new FormDatos();
                formDatos.tbCodigoAduanero.Text = codigoAduanero.ToString();
                if (formDatos.ShowDialog() == DialogResult.OK)
                {
                    string empresa = formDatos.tbEmpresa.Text;
                    envioSeleccionado = new Envio(codigoAduanero, empresa);
                }
                #endregion
            }

            if (envioSeleccionado != null)
            {
                lbEmpresa.Text = $"{envioSeleccionado.Empresa}";
            }
            else
            {
                lbEmpresa.Text="";
            }

            #region limpiar
            lbxVerCostos.Items.Clear();
            #endregion
        }

        private void btnGuardarEnvio_Click(object sender, EventArgs e)
        {
            if (envioSeleccionado != null)
            {
                logistica.AgregarEnvio(envioSeleccionado);

                #region

                tbCodigoAduanero.Clear();
                lbEmpresa.Text = "";
                lbxVerCostos.Items.Clear();

                #endregion
            }
        }

        private void btnAgregarCosto_Click(object sender, EventArgs e)
        {
            Costo costo = cbCostos.SelectedItem as Costo;

            if (costo != null)
            {
                envioSeleccionado.AgregarCosto(costo);

                #region mostrar el costo 
                lbxVerCostos.Items.Add(costo);                
                cbCostos.SelectedIndex = -1;
                #endregion
            }
            else
            {
                MessageBox.Show("Seleccione o Cree un Envio");
            }
        }

        private void btnListasEnvios_Click(object sender, EventArgs e)
        {
            tbEnvios.Text = "";

            for(int idx = 0; idx < logistica.CantidadEnvios; idx++)
            {
                Envio env = logistica.VerEnvio(idx);
                tbEnvios.Text += env.ToString()+"\r\n";
            }
        }
    }
}