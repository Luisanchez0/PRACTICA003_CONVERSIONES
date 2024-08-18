using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA003_CONVERSIONES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_Celcius_Click(object sender, EventArgs e)
        {

        }

        private void tbCelcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFarenheit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Farenheit_Click(object sender, EventArgs e)
        {

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbFarenheit.Text = "0.0";
            tbCelcius.Text = "0.0";
            MessageBox.Show("Se restablecieron los valores");
        }

        private void btCelFar_Click(object sender, EventArgs e)
        {
            float celcius = float.Parse(tbCelcius.Text);
            float Farenheit = (celcius * 9f / 5f) + 32;
            tbFarenheit.Text = Farenheit.ToString();
        }

        private void btFarCel_Click(object sender, EventArgs e)
        {
            float Farenheit = float.Parse(tbFarenheit.Text);
            float celcius = (Farenheit -32) * 5f/9f;
            tbCelcius.Text = celcius.ToString();


        }
    }
}
