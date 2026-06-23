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
    public partial class HistoricoSelecao : Form
    {
        public HistoricoSelecao()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            int opcao = (int)NumericNumeros.Value;
            switch (opcao)
            {
                case 1:
                    LblVisualizar.Text = "Escalação da Seleção Brasileira";
                    MostrarEscalacao();
                    break;
                case 2:
                    LblVisualizar.Text = "Desempenho dos Jogadores";
                    AvaliarJogador();
                    break;
                case 3:
                    LblVisualizar.Text = "Histórico de Partidas";
                    VisualizarHistoricoDePartidas();
                    break;
                case 4:
                    LblVisualizar.Text = "Subtituições";
                    VisualizarSubstituicoes();
                    break;
                case 5:
                    EncerrarTela();
                    break;
                default:

                    MessageBox.Show("Digite um número válido");
                    break;
            }
        }

        private void MostrarEscalacao()
        {
            Limpar();


            // Escalação (26 jogadores com posição)
            LstHistorico.Items.Add("Marcos – Goleiro");
            LstHistorico.Items.Add("Dida – Goleiro");
            LstHistorico.Items.Add("Rogério Ceni – Goleiro");

            LstHistorico.Items.Add("Lúcio – Zagueiro");
            LstHistorico.Items.Add("Roque Júnior – Zagueiro");
            LstHistorico.Items.Add("Edmílson – Zagueiro/Volante");
            LstHistorico.Items.Add("Juan – Zagueiro");

            LstHistorico.Items.Add("Cafu – Lateral Direito");
            LstHistorico.Items.Add("Roberto Carlos – Lateral Esquerdo");
            LstHistorico.Items.Add("Belletti – Lateral Direito");
            LstHistorico.Items.Add("Júnior – Lateral Esquerdo");

            LstHistorico.Items.Add("Gilberto Silva – Volante");
            LstHistorico.Items.Add("Kleberson – Volante");
            LstHistorico.Items.Add("Emerson – Volante");
            LstHistorico.Items.Add("Juninho Pernambucano – Meio-campo");

            LstHistorico.Items.Add("Rivaldo – Meia/Atacante");
            LstHistorico.Items.Add("Ronaldinho Gaúcho – Meia/Atacante");
            LstHistorico.Items.Add("Kaká – Meia");
            LstHistorico.Items.Add("Zé Roberto – Meio-campo");

            LstHistorico.Items.Add("Ronaldo – Atacante");
            LstHistorico.Items.Add("Romário – Atacante");
            LstHistorico.Items.Add("Adriano – Atacante");
            LstHistorico.Items.Add("Denílson – Atacante");
            LstHistorico.Items.Add("Luís Fabiano – Atacante");
            LstHistorico.Items.Add("Bebeto – Atacante");
            LstHistorico.Items.Add("Amoroso – Atacante");
        }

        private void AvaliarJogador()
        {
            Limpar();

            // Escalação com idade + status

            LstHistorico.Items.Add("Marcos – 52 anos – Bom");
            LstHistorico.Items.Add("Dida – 52 anos – Craque");
            LstHistorico.Items.Add("Rogério Ceni – 53 anos – Craque");
            LstHistorico.Items.Add("Lúcio – 48 anos – Craque");

            LstHistorico.Items.Add("Roque Júnior – 49 anos – Ruim");
            LstHistorico.Items.Add("Edmílson – 49 anos – Bom");
            LstHistorico.Items.Add("Juan – 47 anos – Bom");
            LstHistorico.Items.Add("Cafu – 56 anos – Craque");

            LstHistorico.Items.Add("Roberto Carlos – 53 anos – Craque");
            LstHistorico.Items.Add("Belletti – 50 anos – Bom");
            LstHistorico.Items.Add("Júnior – 52 anos – Bom");
            LstHistorico.Items.Add("Gilberto Silva – 49 anos – Craque");
            LstHistorico.Items.Add("Kleberson – 47 anos – Bom");

            LstHistorico.Items.Add("Emerson – 50 anos – Craque");
            LstHistorico.Items.Add("Juninho Pernambucano – 51 anos – Craque");
            LstHistorico.Items.Add("Rivaldo – 54 anos – Craque");
            LstHistorico.Items.Add("Ronaldinho Gaúcho – 46 anos – Craque");
            LstHistorico.Items.Add("Kaká – 44 anos – Craque");

            LstHistorico.Items.Add("Zé Roberto – 51 anos – Craque");
            LstHistorico.Items.Add("Ronaldo – 49 anos – Craque");
            LstHistorico.Items.Add("Romário – 60 anos – Craque");
            LstHistorico.Items.Add("Adriano – 44 anos – Craque");
            LstHistorico.Items.Add("Denílson – 48 anos – Bom");

            LstHistorico.Items.Add("Luís Fabiano – 45 anos – Bom");
            LstHistorico.Items.Add("Bebeto – 62 anos – Craque");
            LstHistorico.Items.Add("Amoroso – 51 anos – Bom");
        }

        private void VisualizarHistoricoDePartidas()
        {
            Limpar();

            // Histórico de partidas (2023–2026)

            LstHistorico.Items.Add("Total de Jogos(2023–2026):\n Partidas: 38 |" +
                " Vitórias: 17 | Empates: 11 | Derrotas: 10 | Aproveitamento: 59%");

         
            LstHistorico.Items.Add("2023: Marrocos 2x1 Brasil");
            LstHistorico.Items.Add("2023: Brasil 4x1 Guiné");
            LstHistorico.Items.Add("2023: Brasil 2x4 Senegal");

            LstHistorico.Items.Add("2023: Brasil 5x1 Bolívia");
            LstHistorico.Items.Add("2023: Peru 0x1 Brasil");
            LstHistorico.Items.Add("2023: Brasil 1x1 Venezuela");
            LstHistorico.Items.Add("2023: Uruguai 2x0 Brasil");
            LstHistorico.Items.Add("2023: Colômbia 2x1 Brasil");
            LstHistorico.Items.Add("2023: Brasil 0x1 Argentina");

            LstHistorico.Items.Add("2024: Inglaterra 0x1 Brasil");
            LstHistorico.Items.Add("2024: Espanha 3x3 Brasil");
            LstHistorico.Items.Add("2024: México 2x3 Brasil");
            LstHistorico.Items.Add("2024: EUA 1x1 Brasil");

            LstHistorico.Items.Add("2024: Brasil 0x0 Costa Rica");
            LstHistorico.Items.Add("2024: Paraguai 1x4 Brasil");
            LstHistorico.Items.Add("2024: Brasil 1x1 Colômbia");
            LstHistorico.Items.Add("2024: Uruguai 0x0 Brasil (Uruguai venceu nos pênaltis)");

            LstHistorico.Items.Add("2024: Brasil 1x0 Equador");
            LstHistorico.Items.Add("2024: Paraguai 1x0 Brasil");
            LstHistorico.Items.Add("2024: Chile 1x2 Brasil");
            LstHistorico.Items.Add("2024: Brasil 4x0 Peru");
            LstHistorico.Items.Add("2024: Venezuela 1x1 Brasil");
            LstHistorico.Items.Add("2024: Brasil 1x1 Uruguai");

            LstHistorico.Items.Add("2025: Brasil 2x1 Colômbia");
            LstHistorico.Items.Add("2025: Argentina 4x1 Brasil");
            LstHistorico.Items.Add("2025: Equador 0x0 Brasil");
            LstHistorico.Items.Add("2025: Brasil 1x0 Paraguai");
            LstHistorico.Items.Add("2025: Brasil 3x0 Chile");
            LstHistorico.Items.Add("2025: Bolívia 1x0 Brasil");
          

            LstHistorico.Items.Add("2025: Coreia do Sul 0x5 Brasil");
            LstHistorico.Items.Add("2025: Japão 3x2 Brasil");
            LstHistorico.Items.Add("2025: Brasil 2x0 Senegal");
            LstHistorico.Items.Add("2025: Brasil 1x1 Tunísia");

            LstHistorico.Items.Add("2026: Brasil 1x2 França");
            LstHistorico.Items.Add("2026: Brasil 3x1 Croácia");
            LstHistorico.Items.Add("2026: Brasil 6x2 Panamá");
            LstHistorico.Items.Add("2026: Brasil 2x1 Egito");
            LstHistorico.Items.Add("2026: Brasil 1x1 Marrocos");
          



        }

        private void VisualizarSubstituicoes()
        {
            //Limpar();
            MessageBox.Show("Em desenvolvimento, Por favor aguardar");
        }

        private void EncerrarTela()
        {

            DialogResult resposta = MessageBox.Show(
                   "Tem certeza que deseja encerrar?",
                   "Confirmação",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Limpar()
        {
            LstHistorico.Items.Clear();

        }

        private void HistoricoSelecao_Load(object sender, EventArgs e)
        {
            NumericNumeros.Minimum = 1;
            NumericNumeros.Maximum = 5;
        }
    }
}
