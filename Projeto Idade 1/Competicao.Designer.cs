namespace Projeto_Idade_1
{
    partial class Competicao
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
            this.LblCampeonatos = new System.Windows.Forms.Label();
            this.NumecCamiseta = new System.Windows.Forms.NumericUpDown();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LblNumCamisa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumecCamiseta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCampeonatos
            // 
            this.LblCampeonatos.AutoSize = true;
            this.LblCampeonatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampeonatos.Location = new System.Drawing.Point(282, 90);
            this.LblCampeonatos.Name = "LblCampeonatos";
            this.LblCampeonatos.Size = new System.Drawing.Size(11, 16);
            this.LblCampeonatos.TabIndex = 21;
            this.LblCampeonatos.Text = ".";
            // 
            // NumecCamiseta
            // 
            this.NumecCamiseta.Location = new System.Drawing.Point(159, 29);
            this.NumecCamiseta.Name = "NumecCamiseta";
            this.NumecCamiseta.Size = new System.Drawing.Size(75, 20);
            this.NumecCamiseta.TabIndex = 20;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(97, 320);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 14;
            this.BtnVerificar.Text = "&Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LblNumCamisa
            // 
            this.LblNumCamisa.AutoSize = true;
            this.LblNumCamisa.Location = new System.Drawing.Point(12, 29);
            this.LblNumCamisa.Name = "LblNumCamisa";
            this.LblNumCamisa.Size = new System.Drawing.Size(110, 13);
            this.LblNumCamisa.TabIndex = 13;
            this.LblNumCamisa.Text = "Informe n° da Camisa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Competicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblCampeonatos);
            this.Controls.Add(this.NumecCamiseta);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.LblNumCamisa);
            this.Name = "Competicao";
            this.Text = "Competicao";
            this.Load += new System.EventHandler(this.Competicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumecCamiseta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCampeonatos;
        private System.Windows.Forms.NumericUpDown NumecCamiseta;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label LblNumCamisa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}