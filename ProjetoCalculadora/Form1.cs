using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        Calculadora calculadora;
        public string[] operacoes = { "/", "x", "-", "+", "=" };
        public Form1()
        {
            InitializeComponent();
        }
        public void setDigito(string digito)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            calculadora = new Calculadora();
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculadora.Op = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calculadora.Op = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calculadora.Op = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculadora.Op = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calculadora.calcular();
            lbVisor.Text = calculadora.Visor;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            calculadora.Visor = "0";
            calculadora.Op = "";
            lbVisor.Text = "0";
            lbVisor.Text = calculadora.Visor;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("1");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("2");
            lbVisor.Text = calculadora.Visor;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            calculadora.backspace();
            lbVisor.Text = calculadora.Visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("3");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("4");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("5");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("6");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("7");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("8");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("9");
            lbVisor.Text = calculadora.Visor;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calculadora.setDigito("0");
            lbVisor.Text = calculadora.Visor;
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            calculadora.inverter();
            lbVisor.Text = calculadora.Visor;
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            calculadora.fracao();
            lbVisor.Text = calculadora.Visor;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            calculadora.raiz();
            lbVisor.Text = calculadora.Visor;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {

        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            calculadora.potencia();
            lbVisor.Text = calculadora.Visor;
        }
    }
}
