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
        public string diasSemana = "";
        public int diasClicados = 0;
        public int diasCadastrados;
        public bool modulos = false;
        

        public FormTurma()
        {
            InitializeComponent();
            rd_I.Checked = true;
        }

        // Btn Salvar
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (cmb_cursos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um curso válido da lista!");
                return;
            }

            if (cmb_modulos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um módulo válido da lista!");
                return;
            }

            if (cmb_professor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um professor válido da lista!");
                return;
            }


            if (!(txt_maxAlunos.Text.Length > 0 && msk_horarioInicial.Text.Length == 5 && diasSemana.Count() > 0 && msk_inicio.Text.Length == 10))
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente e/ou se nenhum campo foi deixado em branco.", "Erro!");
                return;
            }

            string curso = (string)cmb_cursos.SelectedItem;
            string[] professor = cmb_professor.SelectedItem.ToString().Split('(');
            string horarioInicial = msk_horarioInicial.Text.Trim();
            string inicioAulas = msk_inicio.Text.Trim();
            int maxAluno = int.Parse(txt_maxAlunos.Text.Trim());
            string modulo = GerenciadorBanco.GetCodModuloReal(cmb_modulos.SelectedItem.ToString(), curso);
            

            if (diasClicados < diasCadastrados)
            {
                int dias = diasCadastrados - diasClicados;
                MessageBox.Show("Falta(m) " + dias.ToString() + " dia(s) para ser(em) selecionado(s)!");
                return;
            }

            if (GerenciadorBanco.CadastrarTurma(int.Parse(modulo), maxAluno, diasSemana, horarioInicial, GerenciadorBanco.GetCodProfPorNome(professor[0]), inicioAulas))
                MessageBox.Show("Turma cadastrada com sucesso!");
            else
                MessageBox.Show("Erro ao cadastrar turma!");
        }
        


        // Preview Key Down
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

            string[] nomes = GerenciadorBanco.getListaProf(cmb_professor.Text).ToArray();
            cmb_professor.DroppedDown = nomes.Length > 0 ? true : false;
            cmb_professor.Items.Clear();
            cmb_professor.Items.AddRange(nomes);
            cmb_professor.SelectionStart = cmb_professor.Text.Length;
        }



        // Drop Down
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

            diasCadastrados = GerenciadorBanco.GetDiasPorSemana((string)cmb_cursos.SelectedItem);

            modulos = true;
        }

        private void cmb_modulos_DropDown(object sender, EventArgs e)
        {
           //if (cmb_cursos. > 0)
           //    if (Verifica.CursoExiste(cmb_cursos.SelectedText))
           //    {
           //        MessageBox.Show("Curso não existe");
           //        return;
           //    }

            if (!modulos) return;
            
            string[] lista = GerenciadorBanco.getQtdModulos(cmb_cursos.SelectedItem.ToString()).ToArray();

            cmb_modulos.Items.Clear();
            cmb_modulos.Items.AddRange(lista);

            modulos = false;
            return;
        }
        

        // Key Press
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

        private void ck_dmg_CheckStateChanged(object sender, EventArgs e)
        {

        }



        // Check Box
        private void ck_dmg_Click(object sender, EventArgs e)
        {
            if (!ck_dmg.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_dmg.Checked = false;
                return;
            }

            diasSemana += ck_dmg.Text + "|";
            diasClicados++;
        }

        private void ck_sgn_Click(object sender, EventArgs e)
        {
            if (!ck_sgn.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_sgn.Checked = false;
                return;
            }

            diasSemana += ck_sgn.Text + "|";
            diasClicados++;
        }

        private void ck_ter_Click(object sender, EventArgs e)
        {
            if (!ck_ter.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_ter.Checked = false;
                return;
            }

            diasSemana += ck_ter.Text + "|";
            diasClicados++;
        }

        private void ck_qrt_Click(object sender, EventArgs e)
        {
            if (!ck_qrt.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_qrt.Checked = false;
                return;
            }

            diasSemana += ck_qrt.Text + "|";
            diasClicados++;
        }

        private void ck_qnt_Click(object sender, EventArgs e)
        {
            if (!ck_qnt.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_qnt.Checked = false;
                return;
            }

            diasSemana += ck_qnt.Text + "|";
            diasClicados++;
        }

        private void ck_sxt_Click(object sender, EventArgs e)
        {
            if (!ck_sxt.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_sxt.Checked = false;
                return;
            }

            diasSemana += ck_sxt.Text + "|";
            diasClicados++;
        }

        private void ck_sab_Click(object sender, EventArgs e)
        {
            if (!ck_sab.Checked)
            {
                diasClicados--;
                return;
            }

            if (diasClicados >= diasCadastrados)
            {
                MessageBox.Show("Impossível cadastrar mais dias", "Limite de dias atingido!");
                ck_sab.Checked = false;
                return;
            }

            diasSemana += ck_sab.Text + "|";
            diasClicados++;
        }
    }
}
