using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Heuristicas
{
    class Operaciones
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            return Math.Round(num1 / num2, 4);
        }

        public double Raiz(double num)
        {
            return Math.Round(Math.Sqrt(num), 4);
        }
    }
}
