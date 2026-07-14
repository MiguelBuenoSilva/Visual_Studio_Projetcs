using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            // 1. Validação de campo vazio
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencher o campo vazio", "Erro");
                textBox1.Focus();
                return;
            }

            int idade;

            // 2. Validação se é um número válido
            if (!int.TryParse(textBox1.Text, out idade))
            {
                MessageBox.Show("Digite apenas números", "Erro");
                textBox1.Focus();
                textBox1.Clear();
                return;
            }

            // 3. Validação dos RadioButtons (Cidades)
            if (radioButton1.Checked)
            {
                label3.Text = "Você mora em São Paulo";
                pictureBox1.Image = Properties.Resources.Sao_Paulo;

            }
            else if (radioButton2.Checked)
            {
                label3.Text = "Você mora no Rio de Janeiro";
                pictureBox1.Image = Properties.Resources.polar;
            }
            else
            {
                // Se nenhum foi selecionado, exibe o erro e para o código aqui!
                MessageBox.Show("Selecione um CheckBox", "Erro");
                return;
            }

            // 4. Exibição da idade (Só executa se passar por todas as validações acima)
            if (idade >= 18)
            {
                label2.Text = "Maior de Idade: " + idade;
            }
            else
            {
                label2.Text = "Menor de Idade: " + idade;
            }

            // 5. Limpeza dos campos após o sucesso
            textBox1.Focus();
            textBox1.Clear();
        }

       
    }
}
