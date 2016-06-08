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
    public partial class FormCurso : Form
    {
        public FormCurso()
        {
            InitializeComponent();
            txt_codCurso.Text = (GerenciadorBanco.GetCodCurso() + 1).ToString();
        }

        private void btn_salvarCurso_Click(object sender, EventArgs e)
        {
            string nome = txt_nomeCurso.Text.Trim(),
                   matricula = txt_vMatricula.Text.Trim(),
                   total = txt_vTotal.Text.Trim(),
                   multa = txt_vMulta.Text.Trim(),
                   rescisao = txt_vRescisao.Text.Trim(),
                   meses = txt_meses.Text.Trim(),
                   horas = msk_horas.Text.Trim(),
                   aulaSem = (cmb_dias.SelectedIndex + 1).ToString();
            int modulos = int.Parse(txt_modulos.Text.Trim());

            if (!(nome.Length != 0 && Verifica.Moeda(matricula) && Verifica.Moeda(total) &&
                  multa.ToString().Length != 0 && Verifica.Moeda(rescisao) && meses.Length != 0 &&
                  modulos.ToString().Length != 0 && horas.Length != 0 && aulaSem.Length != 0))
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente " +
                                "e se nenhum campo obrigatório foi deixado em branco",
                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int codCurso = GerenciadorBanco.GetCodCurso() + 1;

            if (!(GerenciadorBanco.CadastrarCurso(codCurso, nome, meses, horas, modulos, aulaSem, matricula,
                                            float.Parse(total), float.Parse(multa), float.Parse(rescisao))))
                return;
            
            FormModulo form = new FormModulo(modulos, codCurso);
            form.ShowDialog();
        }

        private void txt_vMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_vTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_vRescisao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_vMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_meses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_modulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_nomeCurso_TextChanged(object sender, EventArgs e)
        {
            txt_codCurso.Text = (GerenciadorBanco.GetCodCurso() + 1).ToString();
        }
    }
}
