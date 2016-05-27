using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EscolaIdiomas
{
    public partial class FormCadastrarAluno : Form
    {
        public FormCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btn_salvarAluno_Click(object sender, EventArgs e)
        {
            string Ano = "";
            Ano = msk_nascAluno.Text.Trim();
            Ano = Ano[4].ToString() + Ano[5].ToString() + Ano[6].ToString() +
                  Ano[7].ToString();

            // Realiza as verificações obrigatórias
            if (Pessoa.VerificaSoLetras(txt_nomeAluno.Text.Trim()) &&
                Pessoa.VerificaRG(msk_rgALuno.Text.Trim()) &&
                Pessoa.VerificaCPF(msk_cpfAluno.Text.Trim()) &&
                Pessoa.VerificaEmail(txt_emailAluno.Text.Trim()) &&
                Pessoa.VerificaDDDeTelefone(msk_dddAluno.Text.Trim(), msk_telAluno.Text.Trim()) &&
                Pessoa.VerificaDDDeTelefoneALT(msk_dddAltAluno.Text.Trim(), msk_telAltAluno.Text.Trim()) &&
                Pessoa.VerificaSoLetras(txt_enderecoAluno.Text.Trim()) &&
                Pessoa.VerificaSoLetras(txt_bairroAluno.Text.Trim()) &&
                Pessoa.VerificaSoLetras(txt_cidadeAluno.Text.Trim()) &&
                rd_F.Checked || rd_M.Checked)
            {
                // Verifica se o GroupBox está habilitado. 
                //Se for maior de idade o GrupoResponsáveisLegais estará desabilitado.
                if (GrupoResponsaveisLegais.Enabled)
                {
                    // Verifica inserção dos pais
                    if (txt_nomeMae.Text.Length == 0 && txt_nomePai.Text.Length == 0)
                    {
                        MessageBox.Show("Aluno menor de idade!\n" +
                                        "Informe dados de ao menos um responsável legal.", 
                                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Verifica dados da mãe
                    if (txt_nomeMae.Text.Length != 0)
                    {
                        if (!(Pessoa.VerificaSoLetras(txt_nomeMae.Text.Trim()) && 
                            Pessoa.VerificaDDDeTelefone(msk_dddMae.Text.Trim(), msk_telMae.Text.Trim())))
                        {
                            MessageBox.Show("Dados da mãe incorretos ou incompletos!", 
                                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    // Verifica dados do pai
                    if (txt_nomePai.Text.Length != 0)
                    {
                        if (!(Pessoa.VerificaSoLetras(txt_nomeMae.Text.Trim()) &&
                            Pessoa.VerificaDDDeTelefone(msk_dddMae.Text.Trim(), msk_telMae.Text.Trim())))
                        {
                            MessageBox.Show("Dados da mãe incorretos ou incompletos!", 
                                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }

                // Verifica se o aluno é responsável financeiro
                if (rd_S.Checked)
                {
                    if (!Pessoa.VerificaIdade(int.Parse(Ano)))
                    {
                        MessageBox.Show("Não é permitido responsabilizar financeiramente " + 
                                        "menores de idade", "Erro!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ok");
                        return; 
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
                        FormCadastrarAluno form = new FormCadastrarAluno();
                        form.Show();
                        return;
                    }

                    if (resultado.Equals(DialogResult.No))
                    {
                        FormPesquisarResponsavel form = new FormPesquisarResponsavel();
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
            }

        }

        private void msk_nascAluno_Leave(object sender, EventArgs e)
        {
            string Ano = "";
            Ano = msk_nascAluno.Text.Trim();
            Ano = Ano[4].ToString() + Ano[5].ToString() + Ano[6].ToString() +
                  Ano[7].ToString();

            if (!Pessoa.VerificaIdade(int.Parse(Ano)))
                GrupoResponsaveisLegais.Enabled = true;
            else
                GrupoResponsaveisLegais.Enabled = false;
        }
    }
}
