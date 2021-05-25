using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Heuristicas
{
    public partial class formCalculadora : Form
    {
        double input1;
        double input2;
        double resultado;
        string signoOperacion;

        Operaciones operacion = new Operaciones();
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void formCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelError.Text = "";

            switch (e.KeyChar)
            {
                case '0':
                    btnNum0.Focus();
                    btnNum0.PerformClick();
                    break;

                case '1':
                    btnNum1.Focus();
                    btnNum1.PerformClick();
                    break;

                case '2':
                    btnNum2.Focus();
                    btnNum2.PerformClick();
                    break;

                case '3':
                    btnNum3.Focus();
                    btnNum3.PerformClick();
                    break;

                case '4':
                    btnNum4.Focus();
                    btnNum4.PerformClick();
                    break;

                case '5':
                    btnNum5.Focus();
                    btnNum5.PerformClick();
                    break;

                case '6':
                    btnNum6.Focus();
                    btnNum6.PerformClick();
                    break;

                case '7':
                    btnNum7.Focus();
                    btnNum7.PerformClick();
                    break;

                case '8':
                    btnNum8.Focus();
                    btnNum8.PerformClick();
                    break;

                case '9':
                    btnNum9.Focus();
                    btnNum9.PerformClick();
                    break;

                case '.':
                    btnSignoPunto.Focus();
                    btnSignoPunto.PerformClick();
                    break;

                case '+':
                    btnSignoSumar.Focus();
                    btnSignoSumar.PerformClick();
                    break;

                case '-':
                    btnSignoMenos.Focus();
                    btnSignoMenos.PerformClick();
                    break;

                case '*':
                    btnSignoPor.Focus();
                    btnSignoPor.PerformClick();
                    break;

                case '/':
                    btnSignoDividir.Focus();
                    btnSignoDividir.PerformClick();
                    break;

                case 'r':
                    btnSignoRaiz.Focus();
                    btnSignoRaiz.PerformClick();
                    break;

                case 'R':
                    btnSignoRaiz.Focus();
                    btnSignoRaiz.PerformClick();
                    break;

                case 'e':
                    btnSignoIgual.Focus();
                    btnSignoIgual.PerformClick();
                    break;

                case 'E':
                    btnSignoIgual.Focus();
                    btnSignoIgual.PerformClick();
                    break;

                case (char)Keys.Back:
                    btnBorrarUnNumero.Focus();
                    btnBorrarUnNumero.PerformClick();
                    break;

                case 'b':
                    btnBorrarNumeros.Focus();
                    btnBorrarNumeros.PerformClick();
                    break;

                case 'B':
                    btnBorrarNumeros.Focus();
                    btnBorrarNumeros.PerformClick();
                    break;

                case 't':
                    btnBorrarTodo.Focus();
                    btnBorrarTodo.PerformClick();
                    break;

                case 'T':
                    btnBorrarTodo.Focus();
                    btnBorrarTodo.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxPantalla.Text += "9";
        }

        private void btnSignoPunto_Click(object sender, EventArgs e)
        {
            if(textBoxPantalla.Text.Contains(".") || textBoxPantalla.Text == "")
            {
                //No hace nada, no puede digitar puntos si aun no tiene un numero
                labelError.Text = "No puede agregar punto en este escenario.";
            }
            else
            {
                labelError.Text = "";
                textBoxPantalla.Text += ".";
            }
        }

        private void btnSignoSumar_Click(object sender, EventArgs e)
        {
            if(textBoxPantalla.Text == "")
            {
                //No hace nada, porque no puede realizar operacion si aun no ha digitado un numero.
                labelError.Text = "Digite un numero antes de operar.";
            }
            else
            {
                labelError.Text = "";
                input1 = double.Parse(textBoxPantalla.Text);
                signoOperacion = "+";
                textBoxPantallaSecundaria.Text = textBoxPantalla.Text + "+"; 
                textBoxPantalla.Clear();
            }
        }

        private void btnSignoMenos_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == "")
            {
                //No hace nada, porque no puede realizar operacion si aun no ha digitado un numero.
                labelError.Text = "Digite un numero antes de operar.";
            }
            else
            {
                labelError.Text = "";
                input1 = double.Parse(textBoxPantalla.Text);
                signoOperacion = "-";
                textBoxPantallaSecundaria.Text = textBoxPantalla.Text + "-";
                textBoxPantalla.Clear();
            }
        }

        private void btnSignoPor_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == "")
            {
                //No hace nada, porque no puede realizar operacion si aun no ha digitado un numero.
                labelError.Text = "Digite un numero antes de operar.";
            }
            else
            {
                labelError.Text = "";
                input1 = double.Parse(textBoxPantalla.Text);
                signoOperacion = "*";
                textBoxPantallaSecundaria.Text = textBoxPantalla.Text + "*";
                textBoxPantalla.Clear();
            }
        }

        private void btnSignoDividir_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == "")
            {
                //No hace nada, porque no puede realizar operacion si aun no ha digitado un numero.
                labelError.Text = "Digite un numero antes de operar.";
            }
            else
            {
                labelError.Text = "";
                input1 = double.Parse(textBoxPantalla.Text);
                signoOperacion = "/";
                textBoxPantallaSecundaria.Text = textBoxPantalla.Text + "/";
                textBoxPantalla.Clear();
            }
        }

        private void btnSignoRaiz_Click_1(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == "")
            {
                //No hace nada, porque no puede realizar operacion si aun no ha digitado un numero.
                labelError.Text = "Digite un numero antes de operar.";
            }
            else
            {
                labelError.Text = "";
                input1 = double.Parse(textBoxPantalla.Text);
                if (input1 >= 0)
                {
                    resultado = operacion.Raiz(input1);
                    textBoxPantallaSecundaria.Text = "raiz(" + textBoxPantalla.Text + ")";
                    textBoxPantalla.Text = resultado.ToString();
                }
            }
        }

        private void btnSignoIgual_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == "")
            {
                //No hace nada, porque no puede realizar operacion si aun no ha digitado un numero.
                labelError.Text = "Digite un numero antes de operar.";
            }
            else
            {
                labelError.Text = "";
                input2 = double.Parse(textBoxPantalla.Text);

                switch (signoOperacion)
                {
                    case "+":
                        resultado = operacion.Sumar(input1, input2);
                        break;

                    case "-":
                        resultado = operacion.Restar(input1, input2);
                        break;

                    case "*":
                        resultado = operacion.Multiplicar(input1, input2);
                        break;

                    case "/":
                        if(input2 != 0)
                        {
                            resultado = operacion.Dividir(input1, input2);
                        }
                        else
                        {
                            labelError.Text = "No se puede dividir entre 0.";
                        }
                        break;
                }

                textBoxPantallaSecundaria.Text += textBoxPantalla.Text;
                textBoxPantalla.Text = resultado.ToString();
            }
        }

        private void btnBorrarUnNumero_Click(object sender, EventArgs e)
        {
            if(textBoxPantalla.Text.Length == 0)
            {
                labelError.Text = "No tiene numeros para borrar.";
            }
            else
            {
                labelError.Text = "";
                textBoxPantalla.Text = textBoxPantalla.Text.Remove(textBoxPantalla.Text.Length - 1);
            }
        }
        private void btnBorrarNumeros_Click(object sender, EventArgs e)
        {
            if(textBoxPantalla.Text.Length == 0)
            {
                labelError.Text = "No tiene numeros para borrar.";
            }
            else
            {
                labelError.Text = "";
                textBoxPantalla.Clear();
            }

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if(textBoxPantallaSecundaria.Text.Length == 0 && textBoxPantalla.Text.Length == 0)
            {
                labelError.Text = "No tiene procesos para borrar.";
            }
            else
            {
                labelError.Text = "";
                textBoxPantalla.Clear();
                textBoxPantallaSecundaria.Clear();
                input1 = 0;
                input2 = 0;
            }
        }
    }
}
