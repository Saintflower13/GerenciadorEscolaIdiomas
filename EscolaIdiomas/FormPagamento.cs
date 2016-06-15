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
    public partial class FormPagamento : Form
    {
        string[] codMatricula;
        float vMulta = 0;
        int dias = 0;

        public FormPagamento()
        {
            InitializeComponent();
            ck_incluiMulta.Checked = true;
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (cmb_matriculaAluno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um aluno válido da lista!");
                return;
            }

            codMatricula = cmb_matriculaAluno.SelectedItem.ToString().Split('|');
            txt_vParcela.Text = GerenciadorBanco.getParcela(codMatricula[1].Trim());

            int diaVencimento = int.Parse(GerenciadorBanco.getVencimento(codMatricula[1].Trim()));
            float multa = float.Parse(GerenciadorBanco.getMulta(codMatricula[1]).Trim());
            int hoje = DateTime.Now.Day;

            if (hoje > 10)
            {
                dias = hoje - 10;
                vMulta = multa;

                if (ck_incluiMulta.Checked)
                    txt_vMulta.Text = (vMulta * dias).ToString();
            }
    }





        // Drop Down Aluno, lista todos os alunos, suas matriculas e nome do curso
        private void cmb_matriculaAluno_DropDown(object sender, EventArgs e)
        {
            if (cmb_matriculaAluno.Text.Length > 0)
                return;

            string[] matriculas = GerenciadorBanco.getListaMatriculas().ToArray();
            cmb_matriculaAluno.Items.Clear();
            cmb_matriculaAluno.Items.AddRange(matriculas);
        }

        private void ck_incluiMulta_Click(object sender, EventArgs e)
        {
            if (!ck_incluiMulta.Checked)
            {
                txt_vMulta.Text = "";
                return;
            }

            txt_vMulta.Text = (vMulta * dias).ToString();
        }
    }
}
