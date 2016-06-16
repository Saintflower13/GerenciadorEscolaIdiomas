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
    public partial class FormCadastrarCurso : Form
    {
        public FormCadastrarCurso()
        {
            InitializeComponent();
            txt_codCurso.Text = (GerenciadorBanco.GetCodCurso() + 1).ToString();
        }

        private void btn_salvarCurso_Click(object sender, EventArgs e)
        {
            if (!(txt_nomeCurso.Text.Trim().Length != 0 && Verifica.Moeda(txt_vMatricula.Text.Trim()) && 
                   Verifica.Moeda(txt_vTotal.Text.Trim()) &&
                   txt_vMulta.Text.Trim().ToString().Length != 0 && Verifica.Moeda(txt_vRescisao.Text.Trim()) && 
                   txt_meses.Text.Trim().Length != 0 &&
                   txt_modulos.Text.Trim().Length != 0 && msk_horas.Text.Trim().Length != 0 && 
                   (cmb_dias.SelectedIndex + 1).ToString().Length != 0))
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente " +
                                "e se nenhum campo obrigatório foi deixado em branco",
                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nome = txt_nomeCurso.Text.Trim(),
                   vMatricula = txt_vMatricula.Text.Trim(),
                   total = txt_vTotal.Text.Trim(),
                   multa = txt_vMulta.Text.Trim(),
                   rescisao = txt_vRescisao.Text.Trim(),
                   meses = txt_meses.Text.Trim(),
                   horas = msk_horas.Text.Trim(),
                   aulaSem = (cmb_dias.SelectedIndex + 1).ToString(),
                   descricao = txt_descricaoCurso.Text.Trim(), 
                   modulos = txt_modulos.Text.Trim();
            
            FormCadastrarModulo form = new FormCadastrarModulo(int.Parse(modulos), GerenciadorBanco.GetCodCurso() + 1, nome, descricao, meses, horas, 
                                             aulaSem, vMatricula, float.Parse(total), float.Parse(multa), float.Parse(rescisao));
            form.ShowDialog();
            return;
        }

        // 48 a 57, números. 8, backspace. 46, ponto final. 44, virgula.
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
