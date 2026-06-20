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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void idadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void modulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void parImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void telaCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 tela = new Form5();
            tela.Show();
        }

        private void seleçãoBrasileiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selecao_Brasileira tela = new Selecao_Brasileira();
            tela.Show();
        }

        private void desempenhoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desempenho_Jogador tela = new Desempenho_Jogador();
            tela.Show();
        }

        private void posicaoCamisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posicao_Camisa tela = new Posicao_Camisa();
            tela.Show();
        }

        private void campeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Competicao tela = new Competicao();
            tela.Show();
        }

        private void historicoSelecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoSelecao tela = new HistoricoSelecao();
            tela.Show();
        }
    }
}
