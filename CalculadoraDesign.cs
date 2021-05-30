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
                    btnActions(btnNum0);
                    break;

                case '1':
                    btnActions(btnNum1);
                    break;

                case '2':
                    btnActions(btnNum2);
                    break;

                case '3':
                    btnActions(btnNum3);
                    break;

                case '4':
                    btnActions(btnNum4);
                    break;

                case '5':
                    btnActions(btnNum5);
                    break;

                case '6':
                    btnActions(btnNum6);
                    break;

                case '7':
                    btnActions(btnNum7);
                    break;

                case '8':
                    btnActions(btnNum8);
                    break;

                case '9':
                    btnActions(btnNum9);
                    break;

                case '.':
                    btnActions(btnSignoPunto);
                    break;

                case '+':
                    btnActions(btnSignoSumar);
                    break;

                case '-':
                    btnActions(btnSignoMenos);
                    break;

                case '*':
                    btnActions(btnSignoPor);
                    break;

                case '/':
                    btnActions(btnSignoDividir);
                    break;

                case 'r':
                case 'R':
                    btnActions(btnSignoRaiz);
                    break;

                case 'e':
                case 'E':
                    btnActions(btnSignoIgual);
                    break;

                case (char)Keys.Back:
                    btnActions(btnBorrarUnNumero);
                    break;

                case 'b':
                case 'B':
                    btnActions(btnBorrarNumeros);
                    break;

                case 't':
                case 'T':
                    btnActions(btnBorrarTodo);
                    break;

                default:
                    break;
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            setTexts("0");
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            setTexts("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            setTexts("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            setTexts("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            setTexts("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            setTexts("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            setTexts("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            setTexts("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            setTexts("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            setTexts("9");
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
                        textBoxPantalla.Text = resultado.ToString();
                        break;

                    case "-":
                        resultado = operacion.Restar(input1, input2);
                        textBoxPantalla.Text = resultado.ToString();
                        break;

                    case "*":
                        resultado = operacion.Multiplicar(input1, input2);
                        textBoxPantalla.Text = resultado.ToString();
                        break;

                    case "/":
                        if(input2 != 0)
                        {
                            resultado = operacion.Dividir(input1, input2);
                        }
                        else
                        {
                            labelError.Text = "No se puede dividir entre 0.";
                            textBoxPantalla.Text = "Error";
                        }
                        break;
                }

                textBoxPantallaSecundaria.Text += textBoxPantalla.Text;
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



        #region Utils Methods

        private void btnActions(Button btn)
        {
            btn.Focus();
            btn.PerformClick();
        }

        private void setTexts(string num)
        {
            labelError.Text = "";
            textBoxPantalla.Text += num;
        }

        #endregion
    }
}
