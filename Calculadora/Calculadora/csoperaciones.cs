using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    class csoperaciones
    {

        public double sumar (double valorA, double valorB)
        {
            double suma;
            suma = valorA + valorB;
            return suma;
        }

        public double restar(double valorA, double valorB)
        {
            double resta;
            resta = valorA - valorB;
            return resta;
        }

        public double multiplicar(double valorA, double valorB)
        {
            double multi;
            multi = valorA * valorB;
            return multi;
        }

        public double dividir(double valorA, double valorB)
        {
            double divi;
            divi = valorA / valorB;
            return divi;
        }

        /*public double factorial(double valorA)
        {

            double fac = 1;

            for (int i = 1; i < valorA; i++)
            {
                fac = fac * i;
                double resultado = fac;
                return resultado;
            }
            
            
        }*/


    }
}
