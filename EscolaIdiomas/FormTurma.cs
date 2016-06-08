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
        string diasSemana = "";
        bool cmbProfessorLeave = false;

        public FormTurma()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string curso = (string)cmb_cursos.SelectedItem;
            string professor = (string)cmb_professor.SelectedItem;


            MessageBox.Show(diasSemana + "\n" + curso + "\n" + professor);
        }
        
        private void cmb_cursos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || cmb_cursos.Text.Length <= 1 || e.KeyData == Keys.Left || e.KeyData == Keys.Right)
                return;

            string[] nomes = GerenciadorBanco.getListaCursos(cmb_cursos.Text).ToArray();
            cmb_cursos.DroppedDown = nomes.Length > 0 ? true : false;
            cmb_cursos.Items.Clear();
            cmb_cursos.Items.AddRange(nomes);
            cmb_cursos.SelectionStart = cmb_cursos.Text.Length;
        }

        private void cmb_professor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || cmb_professor.Text.Length <= 1 || e.KeyData == Keys.Left || e.KeyData == Keys.Right)
                return;

            string[] nomes = GerenciadorBanco.getLista(cmb_professor.Text).ToArray();
            cmb_professor.DroppedDown = nomes.Length > 0 ? true : false;
            cmb_professor.Items.Clear();
            cmb_professor.Items.AddRange(nomes);
            cmb_professor.SelectionStart = cmb_professor.Text.Length;
        }

        private void ck_dmg_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_dmg.Text + "\n";
        }

        private void ck_sgn_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_sgn.Text + "\n";
        }

        private void ck_ter_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_ter.Text + "\n";
        }

        private void ck_qrt_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_qrt.Text + "\n";
        }

        private void ck_qnt_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_qnt.Text + "\n";
        }

        private void ck_sxt_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_sxt.Text + "\n";
        }

        private void ck_sab_CheckedChanged(object sender, EventArgs e)
        {
            diasSemana += ck_sab.Text + "\n";
        }

        private void cmb_professor_Leave(object sender, EventArgs e)
        {
            string[] codigos = Convert.ToString(GerenciadorBanco.getCodsProfs((string)cmb_professor.SelectedItem).ToArray());
            cmb_codProf.DroppedDown = true;
            cmb_codProf.Items.Clear();
            cmb_codProf.Items.AddRange(codigos);
        }
    }
}
