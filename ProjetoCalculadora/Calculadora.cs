using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class Calculadora
    {
        public string Visor {get; set;}
        public double Aux1 { get; set; }
        public double Aux2 { get; set; }
        private string op;

        public string Op
        {
            get { return op; }
            set {
                Aux1 = Double.Parse(Visor);
                Visor = "0";
                Aux2 = 0; 
                op = value;
            }
        }

        public Calculadora()
        {
            Visor = "0";
            Aux1 = 0;
            Aux2 = 0;
            Op = "";
        }

        public void setDigito(string digito) {
            if (Visor == "0") Visor = digito;
            else Visor += digito;
        }

        public void calcular()
        {
            if (Aux2 == 0) Aux2 = Double.Parse(Visor);
            if (op.Equals("+")) Aux1 += Aux2;
            if (op.Equals("-")) Aux1 -= Aux2;
            if (op.Equals("x")) Aux1 *= Aux2;
            if (op.Equals("/")) Aux1 /= Aux2;
            Visor = Aux1.ToString();
        }

        public void backspace()
        {
            string parte = Visor.Substring(0, Visor.Length - 1);
            if (parte.Equals("")) parte = "0";
            Visor = parte;
        }

        public void inverter()
        {
            double num = Double.Parse(Visor);
            Visor = (num * -1).ToString();
        }
    }
}
