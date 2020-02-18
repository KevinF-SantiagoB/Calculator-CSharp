using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        ClasesOp.ClassSum obj = new ClasesOp.ClassSum();
        ClasesOp.ClassRes obj2 = new ClasesOp.ClassRes();
        ClasesOp.ClassMul obj3 = new ClasesOp.ClassMul();
        ClasesOp.ClassDiv obj4 = new ClasesOp.ClassDiv();

        private void btnN0_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btnNdot_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnNsum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNres_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNmult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNdiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtScreen.Text);

            double Sum;
            double Res;
            double Div;
            double Mul;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    txtScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    txtScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    txtScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    txtScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnNlim_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }

        private void btnNreg_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 1)
                txtScreen.Text = "";
            else if (txtScreen.Text.Length > 0)
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }
    }
}
