
namespace SA_03_Thiago
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.exames = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroVeterinario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroSecretaria = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarExames = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoExames = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro,
            this.exames,
            this.consulta,
            this.sair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 33);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cadastro
            // 
            this.cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroVeterinario,
            this.cadastroSecretaria,
            this.cadastroCliente});
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(100, 29);
            this.cadastro.Text = "Cadastro";
            // 
            // exames
            // 
            this.exames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarExames,
            this.resultadoExames});
            this.exames.Name = "exames";
            this.exames.Size = new System.Drawing.Size(89, 29);
            this.exames.Text = "Exames";
            // 
            // consulta
            // 
            this.consulta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(99, 29);
            this.consulta.Text = "Consulta";
            // 
            // cadastroVeterinario
            // 
            this.cadastroVeterinario.Name = "cadastroVeterinario";
            this.cadastroVeterinario.Size = new System.Drawing.Size(180, 30);
            this.cadastroVeterinario.Text = "Veterinario";
            this.cadastroVeterinario.Click += new System.EventHandler(this.cadastroVeterinario_Click);
            // 
            // cadastroSecretaria
            // 
            this.cadastroSecretaria.Name = "cadastroSecretaria";
            this.cadastroSecretaria.Size = new System.Drawing.Size(180, 30);
            this.cadastroSecretaria.Text = "Secretaria";
            // 
            // cadastroCliente
            // 
            this.cadastroCliente.Name = "cadastroCliente";
            this.cadastroCliente.Size = new System.Drawing.Size(180, 30);
            this.cadastroCliente.Text = "Cliente";
            // 
            // marcarExames
            // 
            this.marcarExames.Name = "marcarExames";
            this.marcarExames.Size = new System.Drawing.Size(238, 30);
            this.marcarExames.Text = "Marcar Exames";
            // 
            // resultadoExames
            // 
            this.resultadoExames.Name = "resultadoExames";
            this.resultadoExames.Size = new System.Drawing.Size(238, 30);
            this.resultadoExames.Text = "Resultado Exames";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(56, 29);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastro;
        private System.Windows.Forms.ToolStripMenuItem cadastroVeterinario;
        private System.Windows.Forms.ToolStripMenuItem cadastroSecretaria;
        private System.Windows.Forms.ToolStripMenuItem cadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem exames;
        private System.Windows.Forms.ToolStripMenuItem marcarExames;
        private System.Windows.Forms.ToolStripMenuItem resultadoExames;
        private System.Windows.Forms.ToolStripMenuItem consulta;
        private System.Windows.Forms.ToolStripMenuItem sair;
    }
}

