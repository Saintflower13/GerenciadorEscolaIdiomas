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
    public partial class FormConsultaProfessor : Form
    {
        public FormConsultaProfessor()
        {
            InitializeComponent();
        }

        private void btn_consultarProfessor_Click(object sender, EventArgs e)
        {
            {
                if (txt_nomeProfessor.Text.Trim().Length == 0)
                    dgv_pesquisaProfessor.DataSource = GerenciadorBanco.getProfessor();
                else
                    dgv_pesquisaProfessor.DataSource = GerenciadorBanco.getProfessorPorNome(txt_nomeProfessor.Text.Trim());
            }
        }
    }
}
