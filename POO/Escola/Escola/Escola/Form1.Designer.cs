namespace Escola
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProfessoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDisciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desejaSairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem,
            this.configuracoesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlunosToolStripMenuItem,
            this.cadastroProfessoreToolStripMenuItem,
            this.cadastroColaboradoresToolStripMenuItem,
            this.cadastroCursosToolStripMenuItem,
            this.cadastroDisciplinasToolStripMenuItem,
            this.cadastroEndereçoToolStripMenuItem});
            this.dadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // cadastroAlunosToolStripMenuItem
            // 
            this.cadastroAlunosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastroAlunosToolStripMenuItem.Name = "cadastroAlunosToolStripMenuItem";
            this.cadastroAlunosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cadastroAlunosToolStripMenuItem.Text = "Cadastro Alunos";
            this.cadastroAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlunosToolStripMenuItem_Click);
            // 
            // cadastroProfessoreToolStripMenuItem
            // 
            this.cadastroProfessoreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastroProfessoreToolStripMenuItem.Name = "cadastroProfessoreToolStripMenuItem";
            this.cadastroProfessoreToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cadastroProfessoreToolStripMenuItem.Text = "Cadastro Professores";
            this.cadastroProfessoreToolStripMenuItem.Click += new System.EventHandler(this.cadastroProfessoreToolStripMenuItem_Click);
            // 
            // cadastroColaboradoresToolStripMenuItem
            // 
            this.cadastroColaboradoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastroColaboradoresToolStripMenuItem.Name = "cadastroColaboradoresToolStripMenuItem";
            this.cadastroColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cadastroColaboradoresToolStripMenuItem.Text = "Cadastro Colaboradores";
            this.cadastroColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroColaboradoresToolStripMenuItem_Click);
            // 
            // cadastroCursosToolStripMenuItem
            // 
            this.cadastroCursosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastroCursosToolStripMenuItem.Name = "cadastroCursosToolStripMenuItem";
            this.cadastroCursosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cadastroCursosToolStripMenuItem.Text = "Cadastro Cursos";
            this.cadastroCursosToolStripMenuItem.Click += new System.EventHandler(this.cadastroCursosToolStripMenuItem_Click);
            // 
            // cadastroDisciplinasToolStripMenuItem
            // 
            this.cadastroDisciplinasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastroDisciplinasToolStripMenuItem.Name = "cadastroDisciplinasToolStripMenuItem";
            this.cadastroDisciplinasToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cadastroDisciplinasToolStripMenuItem.Text = "Cadastro Disciplinas";
            // 
            // cadastroEndereçoToolStripMenuItem
            // 
            this.cadastroEndereçoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastroEndereçoToolStripMenuItem.Name = "cadastroEndereçoToolStripMenuItem";
            this.cadastroEndereçoToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cadastroEndereçoToolStripMenuItem.Text = "Cadastro Endereco";
            this.cadastroEndereçoToolStripMenuItem.Click += new System.EventHandler(this.cadastroEndereçoToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.financeiroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recursosHumanosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            // 
            // configuracoesToolStripMenuItem
            // 
            this.configuracoesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.configuracoesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configuracoesToolStripMenuItem.Name = "configuracoesToolStripMenuItem";
            this.configuracoesToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.configuracoesToolStripMenuItem.Text = "Configuracoes";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desejaSairToolStripMenuItem});
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // desejaSairToolStripMenuItem
            // 
            this.desejaSairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.desejaSairToolStripMenuItem.Name = "desejaSairToolStripMenuItem";
            this.desejaSairToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.desejaSairToolStripMenuItem.Text = "Deseja Sair";
            this.desejaSairToolStripMenuItem.Click += new System.EventHandler(this.desejaSairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TelaInicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProfessoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDisciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desejaSairToolStripMenuItem;
    }
}

