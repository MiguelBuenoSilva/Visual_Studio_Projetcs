namespace Projeto_Idade_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modulo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parImparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulo1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modulo1ToolStripMenuItem
            // 
            this.modulo1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idadeToolStripMenuItem,
            this.parImparToolStripMenuItem,
            this.tabuadaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.telaCadastroToolStripMenuItem});
            this.modulo1ToolStripMenuItem.Name = "modulo1ToolStripMenuItem";
            this.modulo1ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modulo1ToolStripMenuItem.Text = "&Modulo1";
            this.modulo1ToolStripMenuItem.Click += new System.EventHandler(this.modulo1ToolStripMenuItem_Click);
            // 
            // idadeToolStripMenuItem
            // 
            this.idadeToolStripMenuItem.Name = "idadeToolStripMenuItem";
            this.idadeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.idadeToolStripMenuItem.Text = "&Idade";
            this.idadeToolStripMenuItem.Click += new System.EventHandler(this.idadeToolStripMenuItem_Click);
            // 
            // parImparToolStripMenuItem
            // 
            this.parImparToolStripMenuItem.Name = "parImparToolStripMenuItem";
            this.parImparToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.parImparToolStripMenuItem.Text = "&Par/ Impar";
            this.parImparToolStripMenuItem.Click += new System.EventHandler(this.parImparToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.tabuadaToolStripMenuItem.Text = "&Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // telaCadastroToolStripMenuItem
            // 
            this.telaCadastroToolStripMenuItem.Name = "telaCadastroToolStripMenuItem";
            this.telaCadastroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.telaCadastroToolStripMenuItem.Text = "Tela Cadastro";
            this.telaCadastroToolStripMenuItem.Click += new System.EventHandler(this.telaCadastroToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modulo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parImparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaCadastroToolStripMenuItem;
    }
}