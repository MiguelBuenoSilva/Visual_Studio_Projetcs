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

    public partial class Selecao_Brasileira : Form
    {
        public Selecao_Brasileira()
        {
            InitializeComponent();
        }

        private void Selecao_Brasileira_Load(object sender, EventArgs e)
        {
            // Adicionar as posições ao ComboBox
            cmbPosicao.Items.Add("Goleiro");
            cmbPosicao.Items.Add("Zagueiro");
            cmbPosicao.Items.Add("Meio-Campista");
            cmbPosicao.Items.Add("Atacante");

            // Desabilitar os botões de convocação e espera inicialmente
            btnConvocar.Enabled = false;
            btnEspera.Enabled = false;

        }
        private void VerificarFormulario()
        {
            int idade;

            bool nomeOk = !string.IsNullOrWhiteSpace(txtNome.Text);
            bool idadeOk = int.TryParse(numIdade.Text, out idade);
            bool posicaoOk = (cmbPosicao.SelectedIndex != -1);

            if (nomeOk && idadeOk && posicaoOk)
            {
                btnConvocar.Enabled = true;
                btnEspera.Enabled = true;
            }
            else
            {
                btnConvocar.Enabled = false;
                btnEspera.Enabled = false;
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void numIdade_ValueChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void cmbPosicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void btnConvocar_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text;
            int idade = int.Parse(numIdade.Text);
            string posicao = cmbPosicao.SelectedItem.ToString();
            bool apto = JogadorApto(idade, posicao);


            if (apto)
            {

                txtNome.Text = "";
                numIdade.Value = 20;
                cmbPosicao.SelectedIndex = -1;
                lstConvocar.Items.Add("Nome: " + nome + " Idade:" + idade + " - " + "Posição: " + posicao);
                MessageBox.Show(nome + "  está na lista de convocados");
                LimparFormulario();

            }
            else
            {
                MessageBox.Show(nome + " não está apto para estar na lista de convocados");
            }
        }

        private void btnEspera_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            int idade = int.Parse(numIdade.Text);
            string posicao = cmbPosicao.SelectedItem.ToString();
            ////Me
            bool apto = JogadorApto(idade, posicao);

            if (apto)
            {

                txtNome.Text = "";
                numIdade.Value = 16;
                cmbPosicao.SelectedIndex = -1;
                lstEspera.Items.Add("Nome: " + nome + " Idade:" + idade + "-" + " Posição: " + posicao);
                MessageBox.Show(nome + " está na lista de espera para de ser convocado");

                LimparFormulario();

            }
            else
            {

                MessageBox.Show(nome + " não apto para estar na lista de espera para ser convocado");
            }


        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtNome.Focus();
            numIdade.Value = numIdade.Minimum;
            cmbPosicao.SelectedIndex = -1;
            btnConvocar.Enabled = false;
            btnEspera.Enabled = false;
        }

        private bool JogadorApto(int idade, string posicao)
        {
            if (posicao == "Goleiro")
            {
                return idade >= 20;
            }
            else
            {
                return idade >= 16;
            }

        }
    }
}



