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
    public partial class FormEnviarMensagem : Form
    {
        public FormEnviarMensagem()
        {
            InitializeComponent();
        }

        private void cmb_enviarPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_enviarPara.SelectedItem.ToString() == "Alunos")
            {
                FormEnviarParaAlunos form = new FormEnviarParaAlunos();
                form.Show();
            }

            if (cmb_enviarPara.SelectedItem.ToString() == "Professores")
            {
                FormEnviarParaProfessores form = new FormEnviarParaProfessores();
                form.Show();
            }

            if (cmb_enviarPara.SelectedItem.ToString() == "Todos")
            {
                FormEnviarParaTodos form = new FormEnviarParaTodos();
                form.Show();
            }
        }
    }
}
