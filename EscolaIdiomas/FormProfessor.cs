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
        }

        private void btn_salvarProf_Click(object sender, EventArgs e)
        {
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

            if (Verifica.Vazio(nome) && Verifica.RG(rg) &&
                Verifica.CPF(cpf) && Verifica.Email(email) &&
                Verifica.DDDeTelefone(ddd, tel) &&
                Verifica.DDDeTelefoneALT(dddAlt, telAlt) &&
                Verifica.Vazio(endereco) && Verifica.Vazio(bairro) &&
                Verifica.Vazio(cidade) && admissao.Length == 10 &&
                Verifica.Maioridade(nasc) &&
                rd_F.Checked || rd_M.Checked)
            {
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
                else
                {
                    MessageBox.Show("Erro ao cadastrar professor!");
                    return;
                }
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
    }
}
