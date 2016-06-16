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
    public partial class FormCadastradarAluno : Form
    {
        public string caminhoImagem = @"C:\Projeto\EscolaIdiomas\Fotos\user.png";

        public FormCadastradarAluno(string texto)
        {
            InitializeComponent();
            pic_fotoAluno.ImageLocation = caminhoImagem;
            this.Text = texto;
            txt_codAluno.Text = (GerenciadorBanco.GetCodAluno() + 1).ToString();
            rd_I.Checked = true;
        }

        private void btn_salvarAluno_Click(object sender, EventArgs e)
        {
            // Realiza as verificações obrigatórias
            if (!(txt_nomeAluno.Text.Trim().Length > 0 && msk_rgALuno.Text.Trim().Length > 0 && 
                 txt_emailAluno.Text.Trim().Length > 0 &&
                 Verifica.DDDeTelefone(msk_dddAluno.Text.Trim(), msk_telAluno.Text.Trim()) &&
                 Verifica.DDDeTelefoneALT(msk_dddAltAluno.Text.Trim(), msk_telAltAluno.Text.Trim()) &&
                 (rd_F.Checked || rd_M.Checked)))
            {

                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente " +
                                "e se nenhum campo obrigatório foi deixado em branco",
                                "Erro! Campos com erros!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nomeALuno = txt_nomeAluno.Text.Trim(),
                   rg = msk_rgALuno.Text.Trim(),
                   cpf = msk_cpfAluno.Text.Trim(),
                   nasc = msk_nascAluno.Text.Trim(),
                   email = txt_emailAluno.Text.Trim(),
                   dddAluno = msk_dddAluno.Text.Trim(),
                   telAluno = msk_telAluno.Text.Trim(),
                   dddAltAluno = msk_dddAltAluno.Text.Trim(),
                   telAltAluno = msk_telAltAluno.Text.Trim(),
                   endereco = txt_enderecoAluno.Text.Trim(),
                   bairro = txt_bairroAluno.Text.Trim(),
                   cidade = txt_cidadeAluno.Text.Trim(),
                   nomeMae = txt_nomeMae.Text.Trim(),
                   dddMae = msk_dddMae.Text.Trim(),
                   telMae = msk_telMae.Text.Trim(),
                   nomePai = txt_nomePai.Text.Trim(),
                   dddPai = msk_dddPai.Text.Trim(),
                   telPai = msk_telPai.Text.Trim();

            char sexo = ' ';

            if (rd_F.Checked) sexo = 'f';
            if (rd_M.Checked) sexo = 'm';

            // Verifica se o GroupBox está habilitado. 
            //Se for maior de idade o GrupoResponsáveisLegais estará desabilitado.
            if (GrupoResponsaveisLegais.Enabled)
            {
                // Verifica se dados dos pais estão preenchidos
                if (nomeMae.Length == 0 && nomePai.Length == 0)
                {
                    MessageBox.Show("Informe dados de ao menos um responsável legal.",
                                    "Erro! Aluno menor de idade!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Verifica dados da mãe
                if (nomeMae.Length != 0)
                {
                    if (!(nomeMae.Length > 0 && Verifica.DDDeTelefone(dddMae, telMae)))
                    {
                        MessageBox.Show("Dados da mãe incorretos e/ou incompletos!", 
                                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                // Verifica dados do pai
                if (nomePai.Length != 0)
                {
                    if (!(nomePai.Length > 0 && Verifica.DDDeTelefone(dddPai, telPai)))
                    {
                        MessageBox.Show("Dados do pai incorretos ou incompletos!", 
                                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            // Verifica se o aluno é responsável financeiro
            if (rd_S.Checked)
            {
                if (!Verifica.Maioridade(nasc))
                {
                    MessageBox.Show("Não é permitido responsabilizar financeiramente " + 
                                    "menores de idade", "Erro! Aluno menor de idade!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    string telefoneAlt = dddAltAluno + telAltAluno,
                           telefone = dddAluno + telAluno;

                    if (GerenciadorBanco.CadastrarAluno(0, nomeALuno, rg, cpf, nasc, sexo,
                        email, telefone, telefoneAlt, endereco, bairro, cidade, nomeMae,
                        nomePai, telMae, telPai, caminhoImagem))
                    {
                        MessageBox.Show("Aluno cadastrado com sucesso!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar aluno!", "Erro",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                    
            }

            // Verifica se o aluno não é responsável financeiro
            if (rd_N.Checked)
            {
                DialogResult resultado = 
                MessageBox.Show("Deseja cadastrar um novo responsável financeiro?\n\n" +
                                "Se clicar em Não uma página para pesquisar responsáveis " +
                                "já cadastrados será exibida.", "Cadastrar novo responsável?",
                                 MessageBoxButtons.YesNoCancel);
                   
                if (resultado.Equals(DialogResult.Yes))
                    {
                        FormCadastrarResponsavel form = new FormCadastrarResponsavel();
                        form.ShowDialog();

                        string telefoneAlt = dddAltAluno + telAltAluno;
                        string telefone = dddAluno + telAluno;

                        if (GerenciadorBanco.CadastrarAluno(form.codResp, nomeALuno, rg, cpf, nasc, sexo,
                            email, telefone, telefoneAlt, endereco, bairro, cidade, nomeMae,
                            nomePai, telMae, telPai, caminhoImagem))
                        {
                            MessageBox.Show("Aluno cadastrado com sucesso!");
                            this.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar aluno!", "Erro!",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    if (resultado.Equals(DialogResult.No))
                    {
                        FormConsultarResponsavel form = new FormConsultarResponsavel();
                        form.Show();
                        return;
                    }
                }
        }


        // Carrega foto do aluno
        private void btn_fotoAluno_Click(object sender, EventArgs e)
        {
            OpenFileDialog p = new OpenFileDialog();
            if (p.ShowDialog() == DialogResult.OK)
            {
                pic_fotoAluno.ImageLocation = p.FileName;
                caminhoImagem = p.FileName;
            }

        }



        // Se o aluno for de menor, habilita o grupo de responsáveis
        private void msk_nascAluno_Leave(object sender, EventArgs e)
        {
            if (msk_nascAluno.Text.Trim().Length == 0)
                return;

            string Ano = GerenciadorBanco.GetAno(msk_nascAluno.Text.Trim());

            if (!Verifica.Maioridade(msk_nascAluno.Text.Trim()))
                GrupoResponsaveisLegais.Enabled = true;
            else
                GrupoResponsaveisLegais.Enabled = false;
        }
        


        // 65 a 90, letras caixa alta. 97 a 122, letras caixa baixas. 8, backspace. 32, espaço.
        private void txt_nomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_nomeMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_nomePai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_bairroAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) &&
                (e.KeyChar < 192 || e.KeyChar > 255) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_cidadeAluno_KeyPress(object sender, KeyPressEventArgs e)
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
