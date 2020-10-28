using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2020_10_28_____Biblioteca_Conversor_Temperatura;

namespace _2020_10_28_____Conversor_Fahrenheit_Celsius
{
    public partial class ConversorFahrenheitCelsius : UserControl
    {
        public ConversorFahrenheitCelsius()
        {
            InitializeComponent();
        }

        ConvertirdorTemperatura conversor = new ConvertirdorTemperatura();

        private void Doer_Click(object sender, EventArgs e)
        {
            float cantidad_convertida = float.NaN;
            string cantidad_final="";
            if (!UserDisplay.Text.Equals("")) {
                if (FaToCe.Checked && CeToFa.Checked == false)
                {
                    cantidad_convertida = conversor.FaCe(conversor.IsValidNumber(UserDisplay.Text));
                    cantidad_final = " °F";
                }
                else if (CeToFa.Checked && FaToCe.Checked == false) {
                    cantidad_convertida = conversor.FaCe(conversor.IsValidNumber(UserDisplay.Text));
                    cantidad_final = " °C";
                }
                if (!float.IsNaN(cantidad_convertida)) {
                    cantidad_final = cantidad_convertida + cantidad_final;
                    UserDisplay.Text = cantidad_final;
                }
            }
        }
    }
}
