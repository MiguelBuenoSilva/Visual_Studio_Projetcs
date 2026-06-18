namespace Projeto_Idade_1
{
    partial class HistoricoSelecao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblSelecionarNumero = new System.Windows.Forms.Label();
            this.NumericNumeros = new System.Windows.Forms.NumericUpDown();
            this.LblOpcoes = new System.Windows.Forms.Label();
            this.LblEscalacao = new System.Windows.Forms.Label();
            this.LblAvaliaJogador = new System.Windows.Forms.Label();
            this.LblHistorico = new System.Windows.Forms.Label();
            this.LblSubstituicao = new System.Windows.Forms.Label();
            this.LblEncerrar = new System.Windows.Forms.Label();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LstHistorico = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSelecionarNumero
            // 
            this.LblSelecionarNumero.AutoSize = true;
            this.LblSelecionarNumero.Location = new System.Drawing.Point(23, 184);
            this.LblSelecionarNumero.Name = "LblSelecionarNumero";
            this.LblSelecionarNumero.Size = new System.Drawing.Size(94, 13);
            this.LblSelecionarNumero.TabIndex = 0;
            this.LblSelecionarNumero.Text = "Digite um Número:";
            // 
            // NumericNumeros
            // 
            this.NumericNumeros.Location = new System.Drawing.Point(138, 177);
            this.NumericNumeros.Name = "NumericNumeros";
            this.NumericNumeros.Size = new System.Drawing.Size(120, 20);
            this.NumericNumeros.TabIndex = 1;
            // 
            // LblOpcoes
            // 
            this.LblOpcoes.AutoSize = true;
            this.LblOpcoes.Location = new System.Drawing.Point(34, 252);
            this.LblOpcoes.Name = "LblOpcoes";
            this.LblOpcoes.Size = new System.Drawing.Size(50, 13);
            this.LblOpcoes.TabIndex = 3;
            this.LblOpcoes.Text = "Opções :";
            // 
            // LblEscalacao
            // 
            this.LblEscalacao.AutoSize = true;
            this.LblEscalacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscalacao.Location = new System.Drawing.Point(37, 294);
            this.LblEscalacao.Name = "LblEscalacao";
            this.LblEscalacao.Size = new System.Drawing.Size(147, 15);
            this.LblEscalacao.TabIndex = 4;
            this.LblEscalacao.Text = "1 - Mostrar Escalação";
            // 
            // LblAvaliaJogador
            // 
            this.LblAvaliaJogador.AutoSize = true;
            this.LblAvaliaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvaliaJogador.Location = new System.Drawing.Point(37, 324);
            this.LblAvaliaJogador.Name = "LblAvaliaJogador";
            this.LblAvaliaJogador.Size = new System.Drawing.Size(127, 15);
            this.LblAvaliaJogador.TabIndex = 5;
            this.LblAvaliaJogador.Text = "2 - Avaliar Jogador";
            // 
            // LblHistorico
            // 
            this.LblHistorico.AutoSize = true;
            this.LblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistorico.Location = new System.Drawing.Point(37, 350);
            this.LblHistorico.Name = "LblHistorico";
            this.LblHistorico.Size = new System.Drawing.Size(162, 15);
            this.LblHistorico.TabIndex = 6;
            this.LblHistorico.Text = "3 - Histórico de Partidas";
            // 
            // LblSubstituicao
            // 
            this.LblSubstituicao.AutoSize = true;
            this.LblSubstituicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubstituicao.Location = new System.Drawing.Point(37, 372);
            this.LblSubstituicao.Name = "LblSubstituicao";
            this.LblSubstituicao.Size = new System.Drawing.Size(107, 15);
            this.LblSubstituicao.TabIndex = 7;
            this.LblSubstituicao.Text = "4 - Substituição";
            // 
            // LblEncerrar
            // 
            this.LblEncerrar.AutoSize = true;
            this.LblEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncerrar.Location = new System.Drawing.Point(37, 396);
            this.LblEncerrar.Name = "LblEncerrar";
            this.LblEncerrar.Size = new System.Drawing.Size(83, 15);
            this.LblEncerrar.TabIndex = 8;
            this.LblEncerrar.Text = "5 - Encerrar";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(26, 481);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(150, 31);
            this.BtnVerificar.TabIndex = 9;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LstHistorico
            // 
            this.LstHistorico.FormattingEnabled = true;
            this.LstHistorico.Location = new System.Drawing.Point(331, 12);
            this.LstHistorico.Name = "LstHistorico";
            this.LstHistorico.Size = new System.Drawing.Size(780, 680);
            this.LstHistorico.TabIndex = 12;
            // 
            // HistoricoSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 693);
            this.Controls.Add(this.LstHistorico);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.LblEncerrar);
            this.Controls.Add(this.LblSubstituicao);
            this.Controls.Add(this.LblHistorico);
            this.Controls.Add(this.LblAvaliaJogador);
            this.Controls.Add(this.LblEscalacao);
            this.Controls.Add(this.LblOpcoes);
            this.Controls.Add(this.NumericNumeros);
            this.Controls.Add(this.LblSelecionarNumero);
            this.Name = "HistoricoSelecao";
            this.Text = "HistoricoSelecao";
            ((System.ComponentModel.ISupportInitialize)(this.NumericNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelecionarNumero;
        private System.Windows.Forms.NumericUpDown NumericNumeros;
        private System.Windows.Forms.Label LblOpcoes;
        private System.Windows.Forms.Label LblEscalacao;
        private System.Windows.Forms.Label LblAvaliaJogador;
        private System.Windows.Forms.Label LblHistorico;
        private System.Windows.Forms.Label LblSubstituicao;
        private System.Windows.Forms.Label LblEncerrar;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.ListBox LstHistorico;
    }
}