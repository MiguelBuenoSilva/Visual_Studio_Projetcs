using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Idade_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool formsValidar = true;

            // NOME
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblNome.Text = "Campo de preenchimento obrigatório";
                lblNome.Visible = true;
                lblAsterisco.Visible = false;
                txtNome.Focus();
                formsValidar = false;
            }
            else
            {
                lblNome.Visible = false;
                lblAsterisco.Visible = true;
            }


            // CPF
            if (!maskedTxtCPF.MaskCompleted)
            {
                lblCPF.Text = "Campo de preenchimento obrigatório";
                lblCPF.Visible = true;
                lblAsteriscoCPF.Visible = false;
                if (formsValidar) maskedTxtCPF.Focus();
                formsValidar = false;
            }
            else
            {
                lblCPF.Visible = false;
                lblAsteriscoCPF.Visible = true;
            }

            // EMAIL
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmail.Text = "Campo de preenchimento obrigatório";
                lblEmail.Visible = true;
                lblAsteriscoEmail.Visible = false;
                if (formsValidar) txtEmail.Focus();
                formsValidar = false;
            }
            else if (!ValidarEmail(txtEmail.Text))
            {
                lblEmail.Text = "E-mail inválido";
                lblEmail.Visible = true;
                lblAsteriscoEmail.Visible = false;
                if (formsValidar) txtEmail.Focus();
                formsValidar = false;
            }

            else
            {
                lblEmail.Visible = false;
                lblAsteriscoEmail.Visible = true;
            }

            // CONFIRMAR EMAIL
            if (string.IsNullOrWhiteSpace(txtConfirmarEmail.Text))
            {
                lblConfirmaEmail.Text = "Campo de preenchimento obrigatório";
                lblConfirmaEmail.Visible = true;
                lblConfEmail.Visible = false;
                if (formsValidar) txtConfirmarEmail.Focus();
                formsValidar = false;
            }
            else if (txtEmail.Text != txtConfirmarEmail.Text)
            {
                lblConfirmaEmail.Text = "Os e-mails informados não coincidem";
                lblConfirmaEmail.Visible = true;
                lblConfEmail.Visible = false;
                if (formsValidar) txtConfirmarEmail.Focus();
                formsValidar = false;
            }
            else
            {
                lblConfirmaEmail.Visible = false;
                lblConfEmail.Visible = true;
            }

            // SENHA
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                lblSenha.Text = "Campo de preenchimento obrigatório";
                lblSenha.Visible = true;
                lblAsteriscoSenha.Visible = false;
                if (formsValidar) txtSenha.Focus();
                formsValidar = false;
            }
            else if (txtSenha.Text.Length < 10)
            {
                lblSenha.Text = "A senha deve ter no mínimo 10 caracteres";
                lblSenha.Visible = true;
                lblAsteriscoSenha.Visible = false;
                if (formsValidar) txtSenha.Focus();
                formsValidar = false;
            }

            else if (!ValidarSenha(txtSenha.Text))
            {
                lblSenha.Text = "A senha deve conter apenas números e símbolos";
                lblSenha.Visible = true;
                lblAsteriscoSenha.Visible = false;
                if (formsValidar) txtSenha.Focus();
                formsValidar = false;
            }

            else
            {
                lblSenha.Visible = false;
                lblAsteriscoSenha.Visible = true;
            }

            // CONFIRMAR SENHA
            if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                lblConfirmaSenha.Text = "Campo de preenchimento obrigatório";
                lblConfirmaSenha.Visible = true;
                lblConfSenha.Visible = false;
                if (formsValidar) txtConfirmarSenha.Focus();
                formsValidar = false;
            }
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblConfirmaSenha.Text = "As senhas informadas não coincidem";
                lblConfirmaSenha.Visible = true;
                lblConfSenha.Visible = false;
                if (formsValidar) txtConfirmarSenha.Focus();
                formsValidar = false;
            }
            else
            {
                lblConfirmaSenha.Visible = false;
                lblConfSenha.Visible = true;
            }

            // TELEFONE
            if (!ValidarTelefone(maskedTxtTelefone.Text))
            {
                MessageBox.Show("Por favor, informe um telefone válido",
                    "Erro de Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

                if (formsValidar) maskedTxtTelefone.Focus();
                formsValidar = false;
            }

            // Validando todos os campos
            if (formsValidar)
            {
                MessageBox.Show("Cadastro realizado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Existem campos inválidos. Verifique o formulário.",
                   "Atenção",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

            }
        }

        // Variável de controle para evitar loop infinito no evento TextChanged
        private bool _isFormato = false;

        private bool ValidarTelefone(string telefone)
        {
            // Expressão regular que aceita formatos de telefone fixo e celular com DDD
            string padrao = @"^\(\d{2}\) \d{4,5}-\d{4}$";
            return Regex.IsMatch(telefone, padrao);
        }

        // Evento disparado quando o usuário clica ou entra no campo
        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            // Remove toda a formatação e deixa apenas os números
            string apenasNumeros = Regex.Replace(maskedTxtTelefone.Text, @"[^\d]", "");
            maskedTxtTelefone.Text = apenasNumeros;

            // Move o cursor para o final do texto
            maskedTxtTelefone.SelectionStart = maskedTxtTelefone.Text.Length;
        }

        // Evento disparado a cada caractere digitado
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            // Ignora a execução se a alteração foi feita pelo próprio código de formatação
            if (_isFormato) return;

            _isFormato = true;

            // Pega apenas os números digitados até o momento
            string txtPuro = Regex.Replace(maskedTxtTelefone.Text, @"[^\d]", "");

            // Limita o tamanho máximo para 11 números (padrão celular com DDD)
            if (txtPuro.Length > 11)
            {
                txtPuro = txtPuro.Substring(0, 11);
            }

            string txtFormatado = "";

            // Se digitou o primeiro número, adiciona o parêntese esquerdo "("
            if (txtPuro.Length >= 1 && txtPuro.Length <= 2)
            {
                txtFormatado = "(" + txtPuro;
            }
            // Se digitou o terceiro número (início do número), fecha o parêntese e põe espaço

            else if (txtPuro.Length >= 3 && txtPuro.Length <= 7)
            {
                txtFormatado = string.Format("({0}) {1}", txtPuro.Substring(0, 2), txtPuro.Substring(2));
            }
            //  Quando completa os números do celular (9 dígitos), insere o traço "-"
            else if (txtPuro.Length >= 8)
            {
                //Celular: (XX) XXXXX-XXXX
                txtFormatado = string.Format("({0}) {1}-{2}",
                    txtPuro.Substring(0, 2),
                    txtPuro.Substring(2, 5),
                    txtPuro.Substring(7));
            }
            else
            {
                txtFormatado = txtPuro;
            }

            // Atualiza o TextBox com o texto formatado
            maskedTxtTelefone.Text = txtFormatado;

            // Garante que o cursor (pointer) fique sempre no final do texto após formatar
            maskedTxtTelefone.SelectionStart = maskedTxtTelefone.Text.Length;

            _isFormato = false;
        }
        private void maskedTxtCPF_Validating(object sender, CancelEventArgs e)
        {
            // Verifica se o usuário digitou os 11 números exigidos pela máscara
            if (!maskedTxtCPF.MaskFull)
            {
                // Impede o usuário de mudar de campo se estiver incompleto
                e.Cancel = true;

                // Exibe o alerta amigável
                MessageBox.Show("Por favor, digite o CPF completo com os 11 dígitos.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            // Limpa campos
            txtNome.Clear();
            maskedTxtTelefone.Clear();
            maskedTxtCPF.Clear();
            txtCEP.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarEmail.Clear();
            txtConfirmarSenha.Clear();

            // Esconde labels de erro
            lblNome.Visible = false;
            lblCPF.Visible = false;
            lblEmail.Visible = false;
            lblConfirmaEmail.Visible = false;
            lblSenha.Visible = false;
            lblConfirmaSenha.Visible = false;

            // Mostra asteriscos
            lblAsterisco.Visible = true;
            lblAsteriscoCPF.Visible = true;
            lblAsteriscoEmail.Visible = true;
            lblAsteriscoSenha.Visible = true;
            lblConfEmail.Visible = true;
            lblConfSenha.Visible = true;

            // Foco inicial
            txtNome.Focus();

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) &&
                   !char.IsWhiteSpace(e.KeyChar) &&
                   e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private bool ValidarEmail(string email)
        {
            string padrao = @"^[^@\s]+@[^@\s]+\.(com|com\.br|br)$";
            return Regex.IsMatch(email, padrao, RegexOptions.IgnoreCase);
        }


        private bool ValidarSenha(string senha)
        {
            // Apenas números e caracteres especiais, mínimo 10
            string padrao = @"^[0-9!@#$%^&*()_+\-=\[\]{};':""\\|,.<>/?]{10}$";
            return Regex.IsMatch(senha, padrao);
        }

        private void txtSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar) && // backspace
               !"!@#$%^&*()_+-=[]{};:'\"\\|,.<>/?".Contains(e.KeyChar))
            {
                e.Handled = true; // bloqueia a letra
            }
        }

        private void txtConfirmarSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !"!@#$%^&*()_+-=[]{};:'\"\\|,.<>/?".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
