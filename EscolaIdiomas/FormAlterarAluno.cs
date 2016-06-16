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
    public partial class FormAlterarAluno : Form
    {
        public FormAlterarAluno(string codAluno)
        {
            //    string[] dado = GerenciadorBanco.getInfoAluno(codAluno);

            InitializeComponent();
            txt_nomeAluno.Enabled = false;
            msk_rgALuno.Enabled = false;
            msk_cpfAluno.Enabled = false;
            msk_nascAluno.Enabled = false;
            rd_I.Enabled = true;
            rd_A.Enabled = true;
            groupoSituacao.Enabled = true;
            GrupoResponsaveisLegais.Enabled = false;
        }

        private void btn_fotoAluno_Click(object sender, EventArgs e)
        {

        }
    }
}
