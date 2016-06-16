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
            form.MdiParent = this;
            form.Show();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void consultarResponsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarResponsavel form = new FormConsultarResponsavel();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarAluno form = new FormConsultarAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaProfessor form = new FormConsultaProfessor();
            form.MdiParent = this;
            form.Show();
        }

        private void consultaCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaCurso form = new FormConsultaCurso();
            form.MdiParent = this;
            form.Show();
        }

        private void consultaTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaTurma form = new FormConsultaTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaModulo form = new FormConsultaModulo();
            form.MdiParent = this;
            form.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatricula form = new FormMatricula();
            form.MdiParent = this;
            form.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio();
            form.MdiParent = this;
            form.Show();
        }

        private void enviarMensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnviarMensagem form = new FormEnviarMensagem();
            form.Show();
        }
    }
}

