namespace Projeto_Idade_1
{
    partial class Selecao_Brasileira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selecao_Brasileira));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.cmbPosicao = new System.Windows.Forms.ComboBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.btnConvocar = new System.Windows.Forms.Button();
            this.btnEspera = new System.Windows.Forms.Button();
            this.lstConvocar = new System.Windows.Forms.ListBox();
            this.lstEspera = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(122, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(7, 132);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(109, 15);
            this.lblNomeJogador.TabIndex = 1;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(104, 205);
            this.numIdade.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(61, 20);
            this.numIdade.TabIndex = 2;
            this.numIdade.ValueChanged += new System.EventHandler(this.numIdade_ValueChanged);
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(122, 259);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicao.TabIndex = 3;
            this.cmbPosicao.SelectedIndexChanged += new System.EventHandler(this.cmbPosicao_SelectedIndexChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(22, 205);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(41, 15);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade:";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao.Location = new System.Drawing.Point(16, 267);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(54, 15);
            this.lblPosicao.TabIndex = 5;
            this.lblPosicao.Text = "Posição:";
            // 
            // btnConvocar
            // 
            this.btnConvocar.Location = new System.Drawing.Point(54, 347);
            this.btnConvocar.Name = "btnConvocar";
            this.btnConvocar.Size = new System.Drawing.Size(189, 23);
            this.btnConvocar.TabIndex = 6;
            this.btnConvocar.Text = "Convocar";
            this.btnConvocar.UseVisualStyleBackColor = true;
            this.btnConvocar.Click += new System.EventHandler(this.btnConvocar_Click);
            // 
            // btnEspera
            // 
            this.btnEspera.Location = new System.Drawing.Point(366, 347);
            this.btnEspera.Name = "btnEspera";
            this.btnEspera.Size = new System.Drawing.Size(218, 23);
            this.btnEspera.TabIndex = 7;
            this.btnEspera.Text = "&Espera";
            this.btnEspera.UseVisualStyleBackColor = true;
            this.btnEspera.Click += new System.EventHandler(this.btnEspera_Click);
            // 
            // lstConvocar
            // 
            this.lstConvocar.FormattingEnabled = true;
            this.lstConvocar.Location = new System.Drawing.Point(25, 395);
            this.lstConvocar.Name = "lstConvocar";
            this.lstConvocar.Size = new System.Drawing.Size(289, 160);
            this.lstConvocar.TabIndex = 8;
            // 
            // lstEspera
            // 
            this.lstEspera.FormattingEnabled = true;
            this.lstEspera.Location = new System.Drawing.Point(366, 395);
            this.lstEspera.Name = "lstEspera";
            this.lstEspera.Size = new System.Drawing.Size(306, 160);
            this.lstEspera.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Selecao_Brasileira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstEspera);
            this.Controls.Add(this.lstConvocar);
            this.Controls.Add(this.btnEspera);
            this.Controls.Add(this.btnConvocar);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.cmbPosicao);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtNome);
            this.Name = "Selecao_Brasileira";
            this.Text = "Selecao_Brasileira";
            this.Load += new System.EventHandler(this.Selecao_Brasileira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Button btnConvocar;
        private System.Windows.Forms.Button btnEspera;
        private System.Windows.Forms.ListBox lstConvocar;
        private System.Windows.Forms.ListBox lstEspera;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}