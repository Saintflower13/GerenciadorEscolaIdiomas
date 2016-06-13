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
    public partial class FormConsultaModulo : Form
    {
        public FormConsultaModulo()
        {
            InitializeComponent();
        }

        private void btn_consultaModulo_Click(object sender, EventArgs e)
        {
            {
                if (txt_consultaModulo.Text.Trim().Length == 0)
                    dgv_pesquisaModulo.DataSource = GerenciadorBanco.getModulo();
                else
                    dgv_pesquisaModulo.DataSource = GerenciadorBanco.getModuloPorCurso(txt_consultaModulo.Text.Trim());
            }
        }
    }
}
