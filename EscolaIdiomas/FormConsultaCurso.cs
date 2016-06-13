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
    public partial class FormConsultaCurso : Form
    {
        public FormConsultaCurso()
        {
            InitializeComponent();
        }

        private void txt_consultaCurso_Click(object sender, EventArgs e)
        {
            {
                if (txt_nomeCurso.Text.Trim().Length == 0)
                    dgv_pesquisaCurso.DataSource = GerenciadorBanco.getCurso();
                else
                    dgv_pesquisaCurso.DataSource = GerenciadorBanco.getCursoPorNome(txt_nomeCurso.Text.Trim());
            }
        }
    }
}
