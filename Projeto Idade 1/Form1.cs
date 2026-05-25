using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projeto_Idade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencher o campo vazio", "Erro!!!");
                return;
            }

            int idade;

            if (!int.TryParse(textBox1.Text, out idade))
            {
                MessageBox.Show("Coloque número Gênio com J");
                return;
            }


            if (idade <= 17)
            {
                label2.Text = "Menor de Idade: " + idade;
            }
            else
            {
                label2.Text = "Maior de Idade: " + idade;
            }

            if (radioButton1.Checked)
            {
                label3.Text = "Você mora em São Paulo";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                label3.Text = "Você mora em Rio de Janeiro";
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecione um CheckBox", "Erro");
            }
        }

       
    }
}
