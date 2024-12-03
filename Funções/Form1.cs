using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funções
{
    public partial class Form1 : Form
    {
        //declaração variaveis global
        double resultado = 0;
        string expressao = "";


        //função Soma
        void Soma(double num1, double num2)
        {
            resultado = num1 + num2;
            expressao = num1 + " + " + num2;
        }

        //funcao Subtracao
        void Subtracao(double num1, double num2)
        {
            resultado = num1 - num2;
            expressao = num1 + " - " + num2;
        }

        //funcao Multiplicacao
        void Multiplicacao(double num1, double num2)
        {
            resultado = num1 * num2;
            expressao = num1 + " * " + num2;
        }

        //funcao Divisao
        void Divisao(double num1, double num2)
        {
            resultado = num1 / num2;
            expressao = num1 + " / " + num2;
        }

        //funcao Resto
        void Resto(double num1, double num2)
        {
            resultado = num1 % num2;
            expressao = num1 + " % " + num2;
        }


        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtExpressao.Clear();
            txtResultado.Clear();
            txtN1.Focus();
            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;
            rdbResto.Checked = false;
         }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtN1.Text);
            double num2 = double.Parse(txtN2.Text);

            if (rdbSoma.Checked == true)
            {
                Soma(num1, num2);
            }

            else if (rdbSubtracao.Checked == true)
            {
                Subtracao(num1, num2);
            }

            else if (rdbMultiplicacao.Checked == true)
            { 
                Multiplicacao(num1, num2);
            }

            else if (rdbDivisao.Checked == true)
            {
                Divisao(num1, num2);
            }

            else if (rdbResto.Checked == true)
            {
                Resto(num1, num2);
            }

            txtResultado.Text = resultado.ToString();
            txtExpressao.Text = expressao;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
