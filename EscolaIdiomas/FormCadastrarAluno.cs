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
            /*if (Aluno.VerificaRG(msk_rgALuno.Text.Trim()))
                MessageBox.Show("OK rg");
            else
                MessageBox.Show("Erro rg");

            if (Aluno.VerificaCPF(msk_cpfAluno.Text.Trim()))
                MessageBox.Show("OK cpf");
            else
                MessageBox.Show("Erro cpf");

            if (Aluno.VerificaEmail(txt_emailAluno.Text.Trim()))
                MessageBox.Show("OK email");
            else
                MessageBox.Show("Erro email");

            if (Aluno.VerificaLetras(txt_nomeAluno.Text.Trim()))
                MessageBox.Show("Ok");
            else
                MessageBox.Show("Erro");*/

            string ANO = msk_nascAluno.Text;
            ANO = ANO[4].ToString() + ANO[5].ToString() + ANO[6].ToString() +
                  ANO[7].ToString();
            if (!Pessoa.VerificaIdade(int.Parse(ANO)))
                MessageBox.Show("menor");
            else
                MessageBox.Show("maior");
        }

        private void btn_fotoAluno_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                pic_fotoAluno.Image = Image.FromFile(d.FileName);
            }
        }
    }
}
