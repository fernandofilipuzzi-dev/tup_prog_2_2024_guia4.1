
using System;
using System.Windows.Forms;
using System.Collections;
using Ejercicio1.Proveedores;
using Ejercicio1.API;
using Ejercicio1.Cliente;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnPrueba_Click(object sender, EventArgs e)
        {
            #region casos de prueba
            Envio[] envios = new Envio[] //lista de envíos planificados
            {
                new Envio(2423),
                new Envio(2323),
                new Envio(2293),
                new Envio(1423)
            };

            ArrayList agentesCargos = new ArrayList()  //agentes de recargos
            {
                new Transporte(2344,23),
                new Aduana(23244),
            };
            #endregion

            #region proceso envios
            foreach (IProcesadorEnvios agente in agentesCargos)
            {
                agente.ProcesarEnvios( envios );
            }
            #endregion

            #region impresión de la lista de envíos
            Ordenar(envios, envios.Length);//por lo del length, se que el vector esta completo!
            foreach (IProcesable env in envios)
            {
                tbVer.Text += $"{env.ToString()}\r\n";//número aduanero

                for (int idx = 0; idx < env.CantidadCostos; idx++) 
                {
                    tbVer.Text += env.VerCosto(idx).ToString() + "\r\n";//concepto y valor
                }
                tbVer.Text += $"Total:{env.CostoTotal:f2}\r\n\r\n";//total
            }
            #endregion
        }

        private void Ordenar(IComparable[] envios, int cantidad)
        {
            for (int n = 0; n < cantidad -1; n++)
            {
                for (int m = n+1; m < cantidad ; m++)
                {
                    if (envios[n].CompareTo(envios[m]) > 0)
                    {
                        IComparable aux = envios[m];
                        envios[m] = envios[n];
                        envios[n] = aux;
                    }
                }
            }
        }
    }
}
