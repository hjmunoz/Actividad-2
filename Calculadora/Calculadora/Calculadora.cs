using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double valorA, valorB;
        string simbolo;


        //crear un objeto de la clase csoperaciones
        csoperaciones operaciones = new csoperaciones(); //instanciar la clase ---> crear un objeto

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "3";

        }

        private void btn4_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "4";

        }

        private void btn5_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "5";

        }

        private void btn6_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "6";

        }

        private void btn7_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "7";

        }

        private void btn8_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "8";

        }

        private void btn9_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "9";

        }

        private void btn0_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + "0";

        }

        private void btnpunto_click(object sender, EventArgs e)
        {
            txtoperacion.Text = txtoperacion.Text + ".";
        }


        private void btnsuma_Click(object sender, EventArgs e)
        {
            simbolo = "+";
            valorA = Convert.ToDouble(txtoperacion.Text);
            txtoperacion.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            simbolo = "-";
            valorA = Convert.ToDouble(txtoperacion.Text);
            txtoperacion.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            simbolo = "*";
            valorA = Convert.ToDouble(txtoperacion.Text);
            txtoperacion.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            simbolo = "/";
            valorA = Convert.ToDouble(txtoperacion.Text);
            txtoperacion.Clear();
        }
       
        private void btnfactorial_Click(object sender, EventArgs e)
        {
            /*double factorial;
            factorial = operaciones.factorial((valorA));
            txtoperacion.Text = factorial.ToString();
            /*double n;
            double fac = 1;
            n = Convert.ToDouble(txtoperacion.Text);

            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
                txtoperacion.Text = fac.ToString();

            }*/

        }


        private void btnigual_Click(object sender, EventArgs e)
        {
            valorB = Convert.ToDouble(txtoperacion.Text);

            double suma, resta, multiplicacion, division, factorial;

            switch (simbolo)
            {
                case "+":

                    suma = operaciones.sumar((valorA), (valorB));
                    txtoperacion.Text = suma.ToString();

                    break;

                case "-":

                    resta = operaciones.restar((valorA), (valorB));
                    txtoperacion.Text = resta.ToString();

                    break;

                case "*":

                    multiplicacion = operaciones.multiplicar((valorA), (valorB));
                    txtoperacion.Text = multiplicacion.ToString();

                    break;

                case "/":

                    division = operaciones.dividir((valorA), (valorB));
                    txtoperacion.Text = division.ToString();

                    break;
             
            }
        }
    }
}
