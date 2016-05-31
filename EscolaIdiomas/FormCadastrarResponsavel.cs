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
    public partial class FormCadastrarResponsavel : Form
    {
        public int codResp;

        public FormCadastrarResponsavel()
        {
            InitializeComponent();
        }

        private void btn_salvarResp_Click(object sender, EventArgs e)
        {
            string nome = txt_nomeResp.Text.Trim(),
                   rg = msk_rgResp.Text.Trim(),
                   cpf = msk_cpfResp.Text.Trim(),
                   nasc = msk_nascResp.Text.Trim(),
                   dddResp = msk_dddResp.Text.Trim(),
                   telResp = msk_telResp.Text.Trim(),
                   dddAltResp = msk_dddAltResp.Text.Trim(),
                   telAltResp = msk_telAltResp.Text.Trim(),
                   endereco = txt_enderecoResp.Text.Trim(),
                   bairro = txt_bairroResp.Text.Trim(),
                   cidade = txt_cidadeResp.Text.Trim();
            char sexo = ' ';

            if (Pessoa.VerificaSoLetras(nome) && Pessoa.VerificaRG(rg) &&
               Pessoa.VerificaCPF(cpf) && Pessoa.VerificaDDDeTelefone(dddResp, telResp) &&
               Pessoa.VerificaDDDeTelefoneALT(dddAltResp, telAltResp) &&
               Pessoa.VerificaSoLetras(endereco) && Pessoa.VerificaSoLetras(bairro) &&
               Pessoa.VerificaSoLetras(cidade) &&
               rd_F.Checked || rd_M.Checked)
            {
                if (rd_F.Checked) sexo = 'f';
                if (rd_M.Checked) sexo = 'm';

                string telefone = dddResp + telResp,
                       telefoneAlt = dddAltResp + telAltResp;

                if (GerenciadorBanco.CadastrarResponsavel(nome, rg, cpf, nasc, sexo, telefone, 
                                                          telefoneAlt, endereco, bairro, cidade))
                {
                    MessageBox.Show("Responsável cadastrado com sucesso!");
                    codResp = GerenciadorBanco.GetCodResp();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar responsável!", "Erro!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente " +
                                "e se nenhum campo obrigatório foi deixado em branco",
                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
