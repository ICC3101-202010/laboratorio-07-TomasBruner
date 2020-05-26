using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        double primerNumero;
        double segundoNumero;
        double result;
        string operacion;
        List<string> operaciones = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ",";
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "+";
                primerNumero = double.Parse(pantalla.Text);
                pantalla.Clear();

            }
            catch (System.FormatException)
            {
                pantalla.Text = "Syntax ERROR";
            }

        }

        private void restar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "-";
                primerNumero = double.Parse(pantalla.Text);
                pantalla.Clear();

            }
            catch (System.FormatException)
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "x";
                primerNumero = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch (System.FormatException)
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "/";
                primerNumero = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch (System.FormatException)
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            try
            {
                segundoNumero = double.Parse(pantalla.Text);

                switch (operacion)
                {
                    case "+":
                        result = primerNumero + segundoNumero;
                        pantalla.Text = result.ToString();
                        operaciones.Add(primerNumero.ToString() + "+" + segundoNumero.ToString() + "=" + result.ToString());
                        break;
                    case "-":
                        result = primerNumero - segundoNumero;
                        pantalla.Text = result.ToString();
                        operaciones.Add(primerNumero.ToString() + "-" + segundoNumero.ToString() + "=" + result.ToString());
                        break;
                    case "x":
                        result = primerNumero * segundoNumero;
                        pantalla.Text = result.ToString();
                        operaciones.Add(primerNumero.ToString() + "x" + segundoNumero.ToString() + "=" + result.ToString());
                        break;
                    case "/":
                        if (segundoNumero != 0)
                        {
                            result = primerNumero / segundoNumero;
                            pantalla.Text = result.ToString();
                            operaciones.Add(primerNumero.ToString() + "/" + segundoNumero.ToString() + "=" + result.ToString());
                            break;
                        }
                        else
                        {
                            pantalla.Text = "Math error";
                            break;
                        }
                }
            }
            catch (System.FormatException)
            {
                pantalla.Text = "Syntax ERROR";
            }

        }

        private void AC_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void borrar_Click(object sender, EventArgs e)
        {

            try
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                pantalla.Text = "Syntax error";
            }
            
         }

        private void ans_Click(object sender, EventArgs e)
        {
            pantalla.Text = result.ToString();
        }

        private void historial_Click(object sender, EventArgs e)
        {
            Form2 historial = new Form2();
            historial.Show();
            
        }
       

    }
}
