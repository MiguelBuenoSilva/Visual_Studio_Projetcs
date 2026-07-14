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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto para número de forma segura
            if (int.TryParse(txtParImpar.Text, out int numero))
            {
                if (numero % 2 == 0)
                {
                    lblResultado.Text = "Esse número é par: " + numero;
                }
                else
                {
                    lblResultado.Text = "Esse número é ímpar: " + numero;
                }
            }
            else
            {
                // Caso o campo esteja vazio
                MessageBox.Show( "Por favor, digite um número válido.");
                txtParImpar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtParImpar.Text = "";
            lblResultado.Text = "";
            txtParImpar.Focus();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtParImpar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloqueia tudo o que não for número e não for tecla de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
