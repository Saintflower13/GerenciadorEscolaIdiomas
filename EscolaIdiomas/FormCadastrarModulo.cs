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
    public partial class FormCadastrarModulo : Form
    {
        int qtd_modulos, cod_curso;
        int i = 1;

        string nomeCurso, descricaoCurso, mesesCurso, horasCurso, aulaSemCurso, vMatriculaCurso;
        float totalCurso, multaCurso, rescisaoCurso;
        int modulosCurso;

        public FormCadastrarModulo(int qtdMod, int codCurso, string cursoNome, string cursoDescricao, string cursoMeses, string cursoHoras, 
                          string cursoAulaSem, string cursoVMatricula, float cursoTotal, float cursoMulta, float cursoRescisao)
        {
            InitializeComponent();
            this.qtd_modulos = qtdMod;
            this.cod_curso = codCurso;
            txt_codCurso.Text = cod_curso.ToString();
            this.Text = "Cadastrar Módulos | Módulo " + i;
            if (i == qtd_modulos)
                btn_proximo.Text = "Salvar Tudo";

            nomeCurso = cursoNome;
            descricaoCurso = cursoDescricao;
            mesesCurso = cursoMeses;
            horasCurso = cursoHoras;
            modulosCurso = qtdMod;
            vMatriculaCurso = cursoVMatricula;
            totalCurso = cursoTotal;
            multaCurso = cursoMulta;
            rescisaoCurso = cursoRescisao;
            aulaSemCurso = cursoAulaSem;
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (txt_descricao.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Preencha a descrição do módulo!");
                return;
            }

            if (i == 1)
            {
                if (!(GerenciadorBanco.CadastrarCurso(nomeCurso, descricaoCurso, mesesCurso, horasCurso, modulosCurso, aulaSemCurso,
                                                      vMatriculaCurso, totalCurso, multaCurso, rescisaoCurso)))
                {
                    MessageBox.Show("Erro ao cadastrar curso.",
                                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (!(GerenciadorBanco.CadastrarModulo(GerenciadorBanco.GetCodModulo(cod_curso.ToString()) + 1,
                              cod_curso, txt_descricao.Text)))
            {
                MessageBox.Show("Erro ao cadastrar módulos!",
                               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ++i;

            if (i > qtd_modulos)
            {
                MessageBox.Show("Pronto.");
                this.Close();
                return;
            }

            txt_descricao.Text = "";
            this.Text = "Cadastrar Módulos | Módulo " + i;

            if (i == qtd_modulos)
                btn_proximo.Text = "Salvar Tudo";
        }
    }
}
