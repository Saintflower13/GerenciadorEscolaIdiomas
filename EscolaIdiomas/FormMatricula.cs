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
    public partial class FormMatricula : Form
    {
        public FormMatricula()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (cmb_codTurma.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma turma válida da lista!", "Erro");
                return;
            }

            if (cmb_aluno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um aluno válido da lista!", "Erro");
                return;
            }

            if (!(txt_dia.Text.Length == 2 && int.Parse(txt_dia.Text) < 31))
            {
                MessageBox.Show("Preencha corretamente dia para o vencimento da parcela!", "Erro");
                return;
            }

            string dia = txt_dia.Text;
            string[] codTurma = cmb_codTurma.SelectedItem.ToString().Split('|');
            string[] codAluno = cmb_aluno.SelectedItem.ToString().Split('|');

            if (GerenciadorBanco.CadastrarMatricula(dia, int.Parse(codTurma[0]), int.Parse(codAluno[0])))
                MessageBox.Show("Aluno matriculado com sucesso!");
        }


        // Drop Box, lista dados
        private void cmb_aluno_DropDown(object sender, EventArgs e)
        {
            if (cmb_aluno.Text.Length > 0)
                return;

            string[] alunos = GerenciadorBanco.getListaTotalNomeCodAluno().ToArray();
            cmb_aluno.Items.Clear();
            cmb_aluno.Items.AddRange(alunos);
            return;
        }

        private void cmb_codTurma_DropDown(object sender, EventArgs e)
        {
            if (cmb_codTurma.Text.Length > 0)
                return;

            string[] turmas = GerenciadorBanco.getListaTotalTurma().ToArray();
            cmb_codTurma.Items.Clear();
            cmb_codTurma.Items.AddRange(turmas);
            return;
        }


        // Key Press
        // Não permite entrada de dados nos combobox
        private void cmb_aluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Length > 0)
            {
                e.Handled = true;
                return;
            }
        }

        private void cmb_codTurma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Length > 0)
            {
                e.Handled = true;
                return;
            }
        }

        // Permite entrada apenas de números nos textbox dia e mês
        private void txt_dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
