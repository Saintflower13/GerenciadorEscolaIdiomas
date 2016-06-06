namespace EscolaIdiomas
{
    partial class FormInicial
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMensagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMensagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.enviarMensagensToolStripMenuItem,
            this.alterarAlunoToolStripMenuItem,
            this.enviarMensagemToolStripMenuItem,
            this.cadastrarProfessorToolStripMenuItem,
            this.cadastrarCursoToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(1208, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(136, 721);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno...";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // enviarMensagensToolStripMenuItem
            // 
            this.enviarMensagensToolStripMenuItem.Name = "enviarMensagensToolStripMenuItem";
            this.enviarMensagensToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.enviarMensagensToolStripMenuItem.Text = "Enviar Mensagens...";
            this.enviarMensagensToolStripMenuItem.Click += new System.EventHandler(this.enviarMensagensToolStripMenuItem_Click);
            // 
            // alterarAlunoToolStripMenuItem
            // 
            this.alterarAlunoToolStripMenuItem.Name = "alterarAlunoToolStripMenuItem";
            this.alterarAlunoToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.alterarAlunoToolStripMenuItem.Text = "Alterar Aluno";
            // 
            // enviarMensagemToolStripMenuItem
            // 
            this.enviarMensagemToolStripMenuItem.Name = "enviarMensagemToolStripMenuItem";
            this.enviarMensagemToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.enviarMensagemToolStripMenuItem.Text = "Enviar Mensagem...";
            // 
            // cadastrarProfessorToolStripMenuItem
            // 
            this.cadastrarProfessorToolStripMenuItem.Name = "cadastrarProfessorToolStripMenuItem";
            this.cadastrarProfessorToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.cadastrarProfessorToolStripMenuItem.Text = "Cadastrar Professor...";
            this.cadastrarProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfessorToolStripMenuItem_Click);
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            this.cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            this.cadastrarCursoToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.cadastrarCursoToolStripMenuItem.Text = "Cadastrar Curso";
            this.cadastrarCursoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCursoToolStripMenuItem_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento Escolar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMensagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMensagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCursoToolStripMenuItem;
    }
}

