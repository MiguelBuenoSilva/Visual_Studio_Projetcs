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
    public partial class Desempenho_Jogador : Form
    {
        public Desempenho_Jogador()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
			CalcularPontuacao();
            LimparFormulario();
        }
		private void LimparFormulario()
		{
			txtNome.Clear();
			numGols.Value = numGols.Minimum;
			numAssistencia.Value = numAssistencia.Minimum ;

			txtNome.Focus();
			
			cmbPosicao.SelectedIndex = -1;
			btnAvaliacao.Enabled = false;
			
		}

        private void Desempenho_Jogador_Load(object sender, EventArgs e)
        {
			// Adicionar as posições ao ComboBox
			cmbPosicao.Items.Add("Goleiro");
			cmbPosicao.Items.Add("Zagueiro");
			cmbPosicao.Items.Add("Meio-Campista");
			cmbPosicao.Items.Add("Atacante");

			// Desabilitar os botões de convocação e espera inicialmente
			btnAvaliacao.Enabled = false;
		}


		private void VerificarFormulario()
		{
			

			bool nomeOk = !string.IsNullOrWhiteSpace(txtNome.Text);
			bool posicaoOk = (cmbPosicao.SelectedIndex != -1);

			if (nomeOk && posicaoOk)
			{
				btnAvaliacao.Enabled = true;
			}
			else
			{
				btnAvaliacao.Enabled = false;
				
			}

		}

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
			VerificarFormulario();
        }

        private void cmbPosicao_SelectedIndexChanged(object sender, EventArgs e)
        {
			VerificarFormulario();
		}

		private void CalcularPontuacao() 
		{
			int gol = (int)numGols.Value;
			int assistencia = (int)numAssistencia.Value;


			int pontos = gol * 2 + assistencia ;



			lstAvaliados.Items.Add("Teste "+ pontos);

        }

		//private void MediaPontuacao()
		//{

  //          int gols = (int)numGols.Value;
  //          int assistencias = (int)numAssistencia.Value;
  //          int jogos = int.Parse(txtPartidas.Text);

  //          int pontuacao = (gols * 2) + assistencias;
  //          double media = 0;

  //          if (jogos > 0)
  //          {
  //              media = (double)pontuacao / jogos;
  //          }

  //          string resultado = $"Pontuação: {pontuacao} | Média por jogo: {media:F2}";

  //          lstAvaliados.Items.Add(resultado);

  //      }
    }
}
