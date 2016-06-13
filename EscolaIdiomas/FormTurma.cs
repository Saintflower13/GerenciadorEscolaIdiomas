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
    public partial class FormTurma : Form
    {
        List<string> diasSemana = new List<string>();
        bool modulos = false;

        public FormTurma()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string curso = (string)cmb_cursos.SelectedItem;
            string professor = (string)cmb_professor.SelectedItem;
            string minAluno = txt_minAlunos.Text.Trim(),
                   maxAluno = txt_maxAlunos.Text.Trim(),
                   horarioInicial = msk_horarioInicial.Text.Trim();

            if (!(curso.Length > 0 && professor.Length > 0 && minAluno.Length > 0 &&
                  maxAluno.Length > 0 && horarioInicial.Length > 0 && diasSemana.Count() > 0))
                return;
            
            MessageBox.Show(diasSemana[0] + "\n" + curso + "\n" + professor + "\n" + horarioInicial +
                            "\nMin: " + minAluno + " Max: " + maxAluno);
        }
        
        private void cmb_cursos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || cmb_cursos.Text.Length == 0 || e.KeyData == Keys.Left || e.KeyData == Keys.Right)
                return;

            if (e.KeyValue == 8)
                return;

            string[] nomes = GerenciadorBanco.getListaCursos(cmb_cursos.Text).ToArray();
            cmb_cursos.DroppedDown = nomes.Length > 0 ? true : false;
            cmb_cursos.Items.Clear();
            cmb_cursos.Items.AddRange(nomes);
            cmb_cursos.SelectionStart = cmb_cursos.Text.Length;
        }

        private void cmb_professor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || e.KeyData == Keys.Left || e.KeyData == Keys.Right || cmb_professor.Text.Length == 0)
                return;

            if (e.KeyValue == 8)
                return;

            string[] nomes = GerenciadorBanco.getLista(cmb_professor.Text).ToArray();
            cmb_professor.DroppedDown = nomes.Length > 0 ? true : false;
            cmb_professor.Items.Clear();
            cmb_professor.Items.AddRange(nomes);
            cmb_professor.SelectionStart = cmb_professor.Text.Length;
        }

        private void cmb_professor_DropDown(object sender, EventArgs e)
        {
            if (cmb_professor.Text.Length > 0)
                return;

            string[] prof_total = GerenciadorBanco.getListaTotalProf().ToArray();
            cmb_professor.Items.Clear();
            cmb_professor.Items.AddRange(prof_total);
            return;
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
            if (cmb_cursos.SelectedIndex < 0)
                return;

            if (!(Verifica.CursoExiste(cmb_cursos.SelectedText)))
            {
                MessageBox.Show("Curso não cadastrado!");
                return;
            }

            modulos = true;
        }

        private void cmb_modulos_DropDown(object sender, EventArgs e)
        {
            if (!modulos) return;

            string[] lista = GerenciadorBanco.getQtdModulos(cmb_cursos.SelectedItem.ToString()).ToArray();

            cmb_modulos.Items.Clear();
            cmb_modulos.Items.AddRange(lista);

            modulos = false;
            return;
        }

        private void ck_dmg_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_dmg.Text);
        }

        private void ck_sgn_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_sgn.Text);
        }

        private void ck_ter_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_ter.Text);
        }

        private void ck_qrt_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_qrt.Text);
        }

        private void ck_qnt_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_qnt.Text);
        }

        private void ck_sxt_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_sxt.Text);
        }

        private void ck_sab_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana.Add(ck_sab.Text);
        }

        // 48 a 57, números. 8, backspace. 
        private void txt_maxAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_minAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void cmb_professor_Leave(object sender, EventArgs e)
        {
            if (Verifica.ProfessorExiste(cmb_professor.SelectedText))
            {
                MessageBox.Show("Professor não cadastrado!");
                return;
            }
        }
    }
}
