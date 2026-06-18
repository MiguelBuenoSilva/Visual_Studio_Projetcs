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

        }

        private void MostrarEscalacao()
        {
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

            // Histórico de partidas (2023–2026)
            LstHistorico.Items.Add("2023: Brasil 4x1 Guiné");
            LstHistorico.Items.Add("2023: Brasil 2x4 Senegal");
            LstHistorico.Items.Add("2023: Brasil 1x2 Marrocos");
            LstHistorico.Items.Add("2024: Brasil 1x0 Inglaterra");
            LstHistorico.Items.Add("2024: Brasil 3x3 Espanha");
            LstHistorico.Items.Add("2024: Brasil 3x2 México");
            LstHistorico.Items.Add("2024: Brasil 1x1 EUA");
            LstHistorico.Items.Add("2025: Brasil 2x1 Colômbia");
            LstHistorico.Items.Add("2025: Brasil 1x4 Argentina");
            LstHistorico.Items.Add("2025: Brasil 2x0 Senegal");
            LstHistorico.Items.Add("2025: Brasil 1x1 Tunísia");
            LstHistorico.Items.Add("2026: Brasil 3x1 Croácia");
            LstHistorico.Items.Add("2026: Brasil 6x2 Panamá");
            LstHistorico.Items.Add("2026: Brasil 2x1 Egito");

        }

        private void VisualizarSubstituicoes()
        {
            MessageBox.Show("Em desenvolvimento, Prr favor aguardar");
        }

        private void EncerrarTela()
        {
            this.Close();
        }

    }
}
