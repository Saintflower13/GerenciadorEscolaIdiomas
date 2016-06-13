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
    public partial class FormConsultaTurma : Form
    {
        public FormConsultaTurma()
        {
            InitializeComponent();
        }

        private void btn_consultarTurma_Click(object sender, EventArgs e)
        {
            {
                if (txt_consultaTurma.Text.Trim().Length == 0)
                    dgv_pesquisaTurma.DataSource = GerenciadorBanco.getTurma();
                else
                    dgv_pesquisaTurma.DataSource = GerenciadorBanco.getTurmaPorCurso(txt_consultaTurma.Text.Trim());
            }
        }
    }
}
