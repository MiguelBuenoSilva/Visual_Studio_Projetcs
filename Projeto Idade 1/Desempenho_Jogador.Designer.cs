namespace Projeto_Idade_1
{
    partial class Desempenho_Jogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desempenho_Jogador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAvaliados = new System.Windows.Forms.ListBox();
            this.btnAvaliacao = new System.Windows.Forms.Button();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.lblPartidas = new System.Windows.Forms.Label();
            this.cmbPosicao = new System.Windows.Forms.ComboBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpAvaliacao = new System.Windows.Forms.GroupBox();
            this.numGols = new System.Windows.Forms.NumericUpDown();
            this.numAssistencia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartidas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAvaliacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lstAvaliados
            // 
            this.lstAvaliados.FormattingEnabled = true;
            this.lstAvaliados.Location = new System.Drawing.Point(25, 396);
            this.lstAvaliados.Name = "lstAvaliados";
            this.lstAvaliados.Size = new System.Drawing.Size(466, 225);
            this.lstAvaliados.TabIndex = 19;
            // 
            // btnAvaliacao
            // 
            this.btnAvaliacao.Location = new System.Drawing.Point(183, 348);
            this.btnAvaliacao.Name = "btnAvaliacao";
            this.btnAvaliacao.Size = new System.Drawing.Size(189, 23);
            this.btnAvaliacao.TabIndex = 17;
            this.btnAvaliacao.Text = "&Avaliação";
            this.btnAvaliacao.UseVisualStyleBackColor = true;
            this.btnAvaliacao.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao.Location = new System.Drawing.Point(6, 71);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(54, 15);
            this.lblPosicao.TabIndex = 16;
            this.lblPosicao.Text = "Posição:";
            // 
            // lblPartidas
            // 
            this.lblPartidas.AutoSize = true;
            this.lblPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidas.Location = new System.Drawing.Point(6, 118);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(114, 15);
            this.lblPartidas.TabIndex = 15;
            this.lblPartidas.Text = "Numeros de Jogos:";
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(86, 71);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicao.TabIndex = 14;
            this.cmbPosicao.SelectedIndexChanged += new System.EventHandler(this.cmbPosicao_SelectedIndexChanged);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(6, 26);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(109, 15);
            this.lblNomeJogador.TabIndex = 12;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(121, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 24);
            this.txtNome.TabIndex = 11;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // grpAvaliacao
            // 
            this.grpAvaliacao.Controls.Add(this.numGols);
            this.grpAvaliacao.Controls.Add(this.numAssistencia);
            this.grpAvaliacao.Controls.Add(this.label2);
            this.grpAvaliacao.Controls.Add(this.label1);
            this.grpAvaliacao.Controls.Add(this.txtPartidas);
            this.grpAvaliacao.Controls.Add(this.lblNomeJogador);
            this.grpAvaliacao.Controls.Add(this.txtNome);
            this.grpAvaliacao.Controls.Add(this.cmbPosicao);
            this.grpAvaliacao.Controls.Add(this.lblPosicao);
            this.grpAvaliacao.Controls.Add(this.lblPartidas);
            this.grpAvaliacao.Location = new System.Drawing.Point(25, 80);
            this.grpAvaliacao.Name = "grpAvaliacao";
            this.grpAvaliacao.Size = new System.Drawing.Size(555, 246);
            this.grpAvaliacao.TabIndex = 22;
            this.grpAvaliacao.TabStop = false;
            // 
            // numGols
            // 
            this.numGols.Location = new System.Drawing.Point(140, 165);
            this.numGols.Name = "numGols";
            this.numGols.Size = new System.Drawing.Size(120, 20);
            this.numGols.TabIndex = 26;
            this.numGols.ValueChanged += new System.EventHandler(this.numGols_ValueChanged);
            // 
            // numAssistencia
            // 
            this.numAssistencia.Location = new System.Drawing.Point(89, 206);
            this.numAssistencia.Name = "numAssistencia";
            this.numAssistencia.Size = new System.Drawing.Size(120, 20);
            this.numAssistencia.TabIndex = 25;
            this.numAssistencia.ValueChanged += new System.EventHandler(this.numAssistencia_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Assistências:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = " Quantidades de Gols:";
            // 
            // txtPartidas
            // 
            this.txtPartidas.Location = new System.Drawing.Point(126, 118);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(100, 20);
            this.txtPartidas.TabIndex = 20;
            this.txtPartidas.TextChanged += new System.EventHandler(this.txtPartidas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Desempenho de Jogadores";
            // 
            // Desempenho_Jogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpAvaliacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstAvaliados);
            this.Controls.Add(this.btnAvaliacao);
            this.Name = "Desempenho_Jogador";
            this.Text = "Desempenho_Jogador";
            this.Load += new System.EventHandler(this.Desempenho_Jogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAvaliacao.ResumeLayout(false);
            this.grpAvaliacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstAvaliados;
        private System.Windows.Forms.Button btnAvaliacao;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblPartidas;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpAvaliacao;
        private System.Windows.Forms.TextBox txtPartidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGols;
        private System.Windows.Forms.NumericUpDown numAssistencia;
        private System.Windows.Forms.Label label3;
    }
}