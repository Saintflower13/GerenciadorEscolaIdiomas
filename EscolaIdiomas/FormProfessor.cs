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
    public partial class FormProfessor : Form
    {

        string caminhoImagem = @"C:\Projeto\user.png";

        public FormProfessor()
        {
            InitializeComponent();
            msk_admissaoProf.Text = DateTime.Now.ToString();
            pic_fotoProf.ImageLocation = @"C:\Projeto\user.png";
            rd_A.Checked = true;
            txt_codProf.Text = (GerenciadorBanco.GetCodProf() + 1).ToString();
        }

        private void btn_salvarProf_Click(object sender, EventArgs e)
        {
            if (!(txt_nomeProf.Text.Trim().Length > 0 && Verifica.RG(msk_rgProf.Text.Trim())
                && Verifica.Email(txt_emailProf.Text.Trim()) &&
                Verifica.DDDeTelefone(msk_dddProf.Text.Trim(), msk_telProf.Text.Trim()) &&
                Verifica.DDDeTelefoneALT(msk_dddAltProf.Text.Trim(), msk_telAltProf.Text.Trim()) &&
                msk_admissaoProf.Text.Trim().Length == 10 &&
                Verifica.Maioridade(msk_nascProf.Text.Trim()) &&
                (rd_F.Checked || rd_M.Checked)))
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente " +
                                 "e se nenhum campo obrigatório foi deixado em branco",
                                 "Erro! Campos com erros!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nome = txt_nomeProf.Text.Trim(),
                   rg = msk_rgProf.Text.Trim(),
                   cpf = msk_cpfProf.Text.Trim(),
                   nasc = msk_nascProf.Text.Trim(),
                   email = txt_emailProf.Text.Trim(),
                   ddd = msk_dddProf.Text.Trim(),
                   tel = msk_telProf.Text.Trim(),
                   dddAlt = msk_dddAltProf.Text.Trim(),
                   telAlt = msk_telAltProf.Text.Trim(),
                   endereco = txt_enderecoProf.Text.Trim(),
                   bairro = txt_bairroProf.Text.Trim(),
                   cidade = txt_cidadeProf.Text.Trim(),
                   admissao = msk_admissaoProf.Text.Trim();
            char sexo = ' ';
           
            if (rd_F.Checked) sexo = 'f';
            if (rd_M.Checked) sexo = 'm';

            string telefoneAlt = dddAlt + telAlt,
                   telefone = ddd + tel;

            if (GerenciadorBanco.CadastrarProfessor(nome, rg, cpf, nasc, sexo, email, telefone, telefoneAlt, 
                                                    endereco, bairro, cidade, admissao, caminhoImagem))
            {
                MessageBox.Show("Professor cadastrado com sucesso!");
                return;
            }
        }

        

        private void btn_fotoProf_Click(object sender, EventArgs e)
        {

            OpenFileDialog p = new OpenFileDialog();
            if (p.ShowDialog() == DialogResult.OK)
            {
                pic_fotoProf.ImageLocation = p.FileName;
                caminhoImagem = p.FileName;
            }
        }

        private void txt_nomeProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_bairroProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_cidadeProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
