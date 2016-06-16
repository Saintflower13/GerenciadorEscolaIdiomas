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
    public partial class FormConsultarAluno : Form
    {
        public FormConsultarAluno()
        {
            InitializeComponent();
            
        }

        private void FormConsultarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (txt_nomeAluno.Text.Trim().Length==0)
                dgv_pesquisaAluno.DataSource = GerenciadorBanco.getAluno();
            else
                dgv_pesquisaAluno.DataSource = GerenciadorBanco.getAlunoPorNome(txt_nomeAluno.Text.Trim());
        }

        //private void dgv_pesquisaAluno_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    DialogResult resultado =  MessageBox.Show("Deseja alterar aluno?", "Alterar ", MessageBoxButtons.YesNoCancel);

        //    if (resultado.Equals(DialogResult.Yes))
        //    {
        //        string codAluno = dgv_pesquisaAluno[0, e.RowIndex].Value.ToString());
        //        FormAlterarAluno form = new FormAlterarAluno();
        //        form.Show();
        //    }
        //}

        private void dgv_pesquisaAluno_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja alterar aluno?", "Alterar ", MessageBoxButtons.YesNoCancel);

            //if (resultado.Equals(DialogResult.Yes))
            //{
            //    string codAluno = dgv_pesquisaAluno[0, e.RowIndex].Value.ToString();
            //    FormAlterarAluno form = new FormAlterarAluno();
            //    form.Show();
            //}
        }
    }
}
