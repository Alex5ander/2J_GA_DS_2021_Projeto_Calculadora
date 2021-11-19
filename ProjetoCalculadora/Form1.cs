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
        public string[] operacoes = { "/", "x", "-", "+", "=" };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int size = Math.Min(pnCentral.Width, pnCentral.Height) / 3;
            int left = 0;
            int top = 0;
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = (9 - i).ToString();
                button.Name = "btn" + (9 - i).ToString();
                button.Width = size;
                button.Height = size;
                button.BackColor = Color.White;

                if (i % 3 == 0 && i != 0)
                {
                    left = 0;
                    top += size; 
                }

                button.Left = left;
                if(i == 9) {
                    button.Left = size * 1;
                }
                button.Top = top;

                left += size;
                
                pnCentral.Controls.Add(button);
            }
   
            for (int i = 0; i < operacoes.Count(); i++)
            {
                Button button = new Button();
                button.Text = operacoes[i];
                button.Name = "btn" + operacoes[i];
                button.Width = size;
                button.Height = size;
                button.BackColor = Color.White;
                button.Top = size * i;
                pnOperadores.Controls.Add(button);
            }
        }
    }
}
