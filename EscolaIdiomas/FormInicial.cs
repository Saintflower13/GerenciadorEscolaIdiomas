using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaIdiomas
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = "Cadastrar Aluno";
            FormAluno form = new FormAluno(texto);
            form.MdiParent = this;
            form.Show();
        }

        private void enviarMensagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnviarMensagem form = new FormEnviarMensagem();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor form = new FormProfessor();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso form = new FormCurso();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTurma form = new FormTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void pesqMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar form = new FormConsultar();
            form.Show();
        }
    }
}

