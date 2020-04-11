using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double total;
        double ultimonumero;
        string operador;

        private void limpar() 
        
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtresult.Text = "0";
        }

        private void calcular() 
        {
            switch (operador)
            {
                case "+": total = total + ultimonumero;
                    break;
                case "-": total = total - ultimonumero;
                    break;
                case "/": total = total / ultimonumero;
                    break;
                case "x": total = total * ultimonumero;
                    break;
            }

            ultimonumero = 0;
            txtresult.Text = total.ToString();

        }

        public Form1()
        {
            InitializeComponent();

            limpar();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtresult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gerarnumero(object sender, EventArgs e)
        {

            if (ultimonumero == 0)
            {
                txtresult.Text = (sender as Button).Text;
            }

            else 
            {
                txtresult.Text = txtresult.Text + (sender as Button).Text;
            }

            
            ultimonumero = Convert.ToDouble(txtresult.Text);
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimonumero = Convert.ToDouble(txtresult.Text);
            calcular();
            operador = (sender as Button).Text;
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            ultimonumero=Convert.ToDouble(txtresult.Text);
            calcular();
            operador = "+";
            total = 0;

        }
    }
}
