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
    public partial class Posicao_Camisa : Form
    {
        public Posicao_Camisa()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            ValidarCamiseta();
            
        }

        private void ValidarCamiseta()
        {
            int camisa = (int)NumCamisetas.Value;
            switch (camisa)
            {
                case 1:
                    LblGoleiro.Text = "Goleiro";
                    LblGoleiro.Visible = true;
                    LblMeioCampo.Visible = false;
                    LblZagueiro.Visible = false;
                    LblAtacante.Visible = false;


                    break;

                case 3:

                    LblZagueiro.Text = "Zagueiro";
                    LblGoleiro.Visible = false;
                    LblMeioCampo.Visible = false;
                    LblZagueiro.Visible = true;
                    LblAtacante.Visible = false;

                    break;
                case 8:
                    LblMeioCampo.Text = "Meio-Campo";
                    LblGoleiro.Visible = false;
                    LblMeioCampo.Visible = true;
                    LblZagueiro.Visible = false;
                    LblAtacante.Visible = false;

                    break;

                case 9:
                    LblAtacante.Text = "Atacante";
                    LblGoleiro.Visible = false;
                    LblMeioCampo.Visible = false;
                    LblZagueiro.Visible = false;
                    LblAtacante.Visible = true;
                    break;
                default:
                    LblCamisaInvalida.Text = "Camisa Inválida";
                    LblCamisaInvalida.Visible = true;
                    break;
            }
        }

        private void Posicao_Camisa_Load(object sender, EventArgs e)
        {
            LblGoleiro.Visible = false;
            LblMeioCampo.Visible = false;
            LblZagueiro.Visible = false;
            LblAtacante.Visible = false;
            LblCamisaInvalida.Visible = false;

        }
       
    }

}

