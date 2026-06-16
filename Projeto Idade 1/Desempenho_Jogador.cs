using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
            int gols = (int)numGols.Value;
            int assistencia = (int)numAssistencia.Value;
			int jogos = int.Parse(txtPartidas.Text);

            int pontosTotal = CalcularPontuacao(gols ,assistencia);

			double media = CalcularMedia( pontosTotal, jogos);

		    string classificacao =	CalcularClassificacao(media);

           



            lstAvaliados.Items.Add( media  +" Classificação| " + classificacao );

            LimparFormulario();
        }
		private void LimparFormulario()
		{
			txtNome.Clear();
			cmbPosicao.SelectedIndex = -1;
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
			int gols;
			int assistencias;


			bool nomeOk = !string.IsNullOrWhiteSpace(txtNome.Text);
			bool golsOk = int.TryParse(numGols.Text, out gols);
			bool jogosOK = !string.IsNullOrWhiteSpace(txtPartidas.Text);
			bool assistenciasOk = int.TryParse(numAssistencia.Text, out assistencias);
			bool posicaoOk = (cmbPosicao.SelectedIndex != -1);

			if (nomeOk && posicaoOk && jogosOK && golsOk && assistenciasOk)
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

		private int CalcularPontuacao( int gols, int assistencia) 
		{
			//int totalGols = gols * 2;
			//int totalAssistencia = assistencia * 1 ;

			return (gols * 2) + (assistencia * 1);
            


        }

		private double CalcularMedia(int pontos, int jogos)
		{

			return (double )pontos / jogos;
           


        }

        private void txtPartidas_TextChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void numGols_ValueChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void numAssistencia_ValueChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

		private string CalcularClassificacao( double media) 
		{
			if(media <= 1)
			{
				return "Ruim";

			}else if (media <= 2)
			{
				return "Regular";

			}else if (media <= 3)
			{
				return "Bom";
			} else 
			{
				return "Profissional";
			}

			
		}
    }
}
