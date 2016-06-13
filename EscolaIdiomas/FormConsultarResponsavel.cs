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
    public partial class FormConsultarResponsavel : Form
    {
        public FormConsultarResponsavel()
        {
            InitializeComponent();           

        }

        private void FormConsultarResponsavel_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultarResponsavel_Click(object sender, EventArgs e)
        {

            if (txt_nomeResponsavel.Text.Trim().Length == 0)
                dgv_pesquisaResponsavel.DataSource = GerenciadorBanco.getResponsavel();
            else
                dgv_pesquisaResponsavel.DataSource = GerenciadorBanco.getResponsavelPorNome(txt_nomeResponsavel.Text.Trim());
        }
    }
}
