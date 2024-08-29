using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        ArrayList envios = new ArrayList();

        private void btnAltaEnvio_Click(object sender, EventArgs e)
        {
            Envio env;
            
            env=new Envio();
            env.AgregarCosto(new Fijo("Peaje puente Zárate", 300));
            env.AgregarCosto(new Comisaria("Combustible", 1500.5, 500));
            envios.Add(env);

            env = new Envio();
            env.AgregarCosto(new Fijo("Peaje túnel", 300));
            env.AgregarCosto(new Comisaria("Horas de conducción", 500, 10));
            envios.Add(env);
        }

        private void btnListarCostos_Click(object sender, EventArgs e)
        {
            foreach (Envio env in envios)
            {
                textBox1.Text += env.VerDetalle();
                textBox1.Text += $"Total:$ {env.ValorTotal,10:f2}\r\n\r\n";
            }
        }
    }
}
