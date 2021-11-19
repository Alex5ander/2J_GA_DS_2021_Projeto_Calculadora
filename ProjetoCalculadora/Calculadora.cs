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
        public double aux1 { get; set; }
        public double aux2 { get; set; }
        private string op;

        public string Op
        {
            get { return op; }
            set { op = value; }
        }

        public Calculadora()
        {
            Visor = "0";
            aux1 = 0;
            aux2 = 0;
            Op = "";
        }

        public void setDigito(string digito) {
            if (Visor == "0") Visor = digito;
            else Visor += digito;
        }
    }
}
