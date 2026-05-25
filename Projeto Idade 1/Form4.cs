using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Idade_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(textBox1.Text, out numero))
            {
                
            }
            for (int tabuada = 1; tabuada <= 10; tabuada++)
            {
                int valor;
                valor = numero * tabuada;
                textBox2.Text += ($"{numero} X {tabuada} = {valor}\r\n");

            }


        }
    }
}
