using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        double primerNumero;
        double segundoNumero;
        double result;
        string operacion;


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
            operacion = "-";
            primerNumero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primerNumero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primerNumero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(pantalla.Text);

            switch (operacion)
            {
                case "+":
                    result = primerNumero + segundoNumero;
                    pantalla.Text = result.ToString();
                    break;
                case "-":
                    result = primerNumero - segundoNumero;
                    pantalla.Text = result.ToString();
                    break;
                case "x":
                    result = primerNumero * segundoNumero;
                    pantalla.Text = result.ToString();
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        result = primerNumero / segundoNumero;
                        pantalla.Text = result.ToString();
                        break;
                    }
                    else
                    {
                        pantalla.Text = "Math error";
                        break;
                    }


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
    }
}
