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
    public partial class FormModulo : Form
    {
        int qtd_modulos, cod_curso;
        int i = 1;

        public FormModulo(int qtd_mod, int cod_curso)
        {
            InitializeComponent();
            this.qtd_modulos = qtd_mod;
            this.cod_curso = cod_curso;
            txt_codCurso.Text = cod_curso.ToString();
            this.Text = "Cadastrar Módulos | Módulo " + i;
            if (i == qtd_modulos)
                btn_proximo.Text = "Salvar Tudo";
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (txt_descricao.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Preencha a descrição do módulo!");
                return;
            }

            GerenciadorBanco.CadastrarModulo(GerenciadorBanco.GetCodModulo(cod_curso.ToString()) + 1,
                              cod_curso, txt_descricao.Text);

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
