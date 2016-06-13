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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
            dgv_pesquisa.DataSource = GerenciadorBanco.getMatriculas();
        }

        private void cmb_nomes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void dgv_pesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
