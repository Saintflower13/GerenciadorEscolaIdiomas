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
    public partial class FormAluno : Form
    {
        public string caminhoImagem = @"C:\Projeto\user.png";

        public FormAluno(string texto)
        {
            InitializeComponent();
            pic_fotoAluno.ImageLocation = @"C:\Projeto\user.png";
            this.Text = texto;
        }

        private void btn_salvarAluno_Click(object sender, EventArgs e)
        {
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
            
            // Realiza as verificações obrigatórias
            if (Verifica.SoLetras(nomeALuno) && Verifica.RG(rg) &&
                Verifica.CPF(cpf) && Verifica.Email(email) &&
                Verifica.DDDeTelefone(dddAluno, telAluno) &&
                Verifica.DDDeTelefoneALT(dddAltAluno, telAltAluno) &&
                Verifica.SoLetras(endereco) && Verifica.SoLetras(bairro) &&
                Verifica.SoLetras(cidade) &&
                rd_F.Checked || rd_M.Checked)
            {
                if (rd_F.Checked) sexo = 'f';
                if (rd_M.Checked) sexo = 'm';

                // Verifica se o GroupBox está habilitado. 
                //Se for maior de idade o GrupoResponsáveisLegais estará desabilitado.
                if (GrupoResponsaveisLegais.Enabled)
                {
                    // Verifica inserção dos pais
                    if (nomeMae.Length == 0 && nomePai.Length == 0)
                    {
                        MessageBox.Show("Aluno menor de idade!\n\n" +
                                        "Informe dados de ao menos um responsável legal.", 
                                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Verifica dados da mãe
                    if (nomeMae.Length != 0)
                    {
                        if (!(Verifica.SoLetras(nomeMae) &&
                            Verifica.DDDeTelefone(dddMae, telMae)))
                        {
                            MessageBox.Show("Dados da mãe incorretos ou incompletos!", 
                                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    // Verifica dados do pai
                    if (nomePai.Length != 0)
                    {
                        if (!(Verifica.SoLetras(nomeMae) && Verifica.DDDeTelefone(dddMae, telMae)))
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
                    string Ano = "";
                    Ano = msk_nascAluno.Text.Trim();
                    Ano = Ano[6].ToString() + Ano[7].ToString() + Ano[8].ToString() +
                          Ano[9].ToString();

                    if (!Verifica.Maioridade(int.Parse(Ano)))
                    {
                        MessageBox.Show("Não é permitido responsabilizar financeiramente " + 
                                        "menores de idade", "Erro!",
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
                            MessageBox.Show("Erro ao cadastrar aluno!");
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
                        FormResponsavel form = new FormResponsavel();
                        form.ShowDialog();

                        string telefoneAlt = dddAltAluno + telAltAluno;
                        string telefone = dddAluno + telAluno;

                        if (GerenciadorBanco.CadastrarAluno(form.codResp, nomeALuno, rg, cpf, nasc, sexo,
                            email, telefone, telefoneAlt, endereco, bairro, cidade, nomeMae,
                            nomePai, telMae, telPai, caminhoImagem))
                        {
                            MessageBox.Show("Aluno cadastrado com sucesso!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar aluno!");
                            return;
                        }
                    }

                    if (resultado.Equals(DialogResult.No))
                    {
                        FormPesquisar form = new FormPesquisar();
                        form.Show();
                        return;
                    }
                }

            }
            else
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente " +
                                "e se nenhum campo obrigatório foi deixado em branco", 
                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_fotoAluno_Click(object sender, EventArgs e)
        {
            OpenFileDialog p = new OpenFileDialog();
            if (p.ShowDialog() == DialogResult.OK)
            {
                pic_fotoAluno.ImageLocation = p.FileName;
                caminhoImagem = p.FileName;
            }

        }

        private void msk_nascAluno_Leave(object sender, EventArgs e)
        {
            if (msk_nascAluno.Text.Length == 0)
                return;

            string Ano = "";
            Ano = msk_nascAluno.Text.Trim();
            Ano = Ano[6].ToString() + Ano[7].ToString() + Ano[8].ToString() +
                  Ano[9].ToString();

            if (!Verifica.Maioridade(int.Parse(Ano)))
                GrupoResponsaveisLegais.Enabled = true;
            else
                GrupoResponsaveisLegais.Enabled = false;
        }
    }
}
