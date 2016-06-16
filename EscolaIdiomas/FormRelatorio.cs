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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            if (cmb_situacao.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma situação válida da lista!");
                return;
            }

            if (cmb_cursos.SelectedIndex > -1 && cmb_situacao.SelectedIndex == 0)
            {
                dgv_alunos.DataSource = GerenciadorBanco.rAlunosAtivosCurso(cmb_cursos.SelectedItem.ToString());
                return;
            }

            if (cmb_situacao.SelectedIndex == 0)
            {
                dgv_alunos.DataSource = GerenciadorBanco.rAlunoTodosCurso();
                return;
            }

            if (cmb_cursos.SelectedIndex < 0)
            {
                dgv_alunos.DataSource = GerenciadorBanco.rAlunoTodosCursoSituacao(cmb_situacao.SelectedItem.ToString());
                return;
            }

        }

        private void cmb_cursos_DropDown(object sender, EventArgs e)
        {
            if (cmb_cursos.Text.Length > 0)
                return;

            string[] nomes_cursos = GerenciadorBanco.getListaTotalCurso().ToArray();
            cmb_cursos.Items.Clear();
            cmb_cursos.Items.AddRange(nomes_cursos);
            return;
        }

        private void cmb_cursos_Leave(object sender, EventArgs e)
        {
            if (cmb_cursos.Text.Length > 0)
            {
                cmb_situacao.Items.Clear();
                cmb_situacao.Items.Add("a");
                return;
            }

            string[] situacao = {"Todos", "a", "i"};
            cmb_situacao.Items.Clear();
            cmb_situacao.Items.AddRange(situacao);
            return;
        }
    }
}
