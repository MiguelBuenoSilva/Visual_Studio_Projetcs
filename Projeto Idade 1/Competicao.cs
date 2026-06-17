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
    public partial class Competicao : Form
    {
        public Competicao()
        {
            InitializeComponent();
        }

        private string Amistoso(int opcao)
        {
            string resultado;

            switch (opcao)
            {
                case 1:


                    resultado = "Amistoso:  é uma partida ou competição\n\r esportiva de exibição que não vale pontos.";

                    pictureBox1.Image = Properties.Resources.amistoso;
                    return LblCampeonatos.Text = resultado;
                    break;
                case 2:
                    resultado = "Eliminaórias: são os torneios qualificatórios continentais\n\r que as seleções disputam para garantir vaga na final.";
                  

                    pictureBox1.Image = Properties.Resources.eliminatorias;
                    return LblCampeonatos.Text = resultado;
                    break;
                case 3:
                    resultado = "Copa América: é o principal torneio de seleções organizado pela\n CONMEBOL.";

                    pictureBox1.Image = Properties.Resources.Copa_america;
                    return LblCampeonatos.Text = resultado;
                    break;
                case 4:
                    resultado = "Copa do Mundo: é uma competição de\n futebol realizada pela Federação Internacional de Futebol\n\r (Fifa) a cada quatro anos.";

                    pictureBox1.Image = Properties.Resources.Copadomundo;
                    return LblCampeonatos.Text = resultado;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.polar;
                    return LblCampeonatos.Text = "Meu gato é muito lindo rapaz!!\n O gato Siamês é uma raça originária da antiga Tailândia (antigo Sião),\n\r " +
                        "famosa por sua pelagem com extremidades escuras\n\r (pointed)," +
                        " olhos intensamente azuis e temperamento extremamente\n apegado e vocal.";
                    break;

            }

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            Amistoso((int)NumecCamiseta.Value);
        }

        private void Competicao_Load(object sender, EventArgs e)
        {
            NumecCamiseta.Maximum = 1;
            NumecCamiseta.Maximum = 4;
          
            
        }
    }
}
