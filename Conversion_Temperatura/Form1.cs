using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Temperatura
{
    public partial class Form1 : Form
    {
        Temperaturas temperaturas = new Temperaturas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            
            switch (cmbtipogrado.SelectedIndex.ToString()) {

                case "0":
                    temperaturas.setGCelsius(double.Parse(txtGcelsius.Text));
                    lblResultado.Text = temperaturas.Convertir().ToString() + " ° F";
                    lblResultado.Visible = true;

                    break;

                case "1":
                    temperaturas.setGCelsius(double.Parse(txtGcelsius.Text));
                    lblResultado.Text = temperaturas.ConvertirFahrenheit().ToString() + " ° C";
                    lblResultado.Visible = true;

                    break;

                default:

                    MessageBox.Show("Ingrese un valor");

                    break;
            }
        }
    }
}
