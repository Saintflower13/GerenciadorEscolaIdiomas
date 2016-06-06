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
    public partial class FormModulo : Form
    {
        TabControl tab_modulos;
        TextBox txt_codCurso;
        TextBox txt_descricao;
        Label lbl_codCurso, lbl_descricao;
        Button btn_salvar;
        int podeCadastrar = 0;

        public FormModulo(int modulos, string nome, string matricula, string total, string rescisao,
                          string meses, string horas, string aulaSem, string multa)
        {
            InitializeComponent();

            if (tab_modulos != null)
                this.Controls.Remove(tab_modulos);

            tab_modulos = new TabControl();
            
            tab_modulos.Location = new Point(0, 0);
            tab_modulos.Dock = DockStyle.Fill;
            for (int i = 0; i < modulos; i++)
            {
                string titulo = "Módulo " + (tab_modulos.TabCount + 1).ToString(),
                       name = "tab_modulo" + (tab_modulos.TabCount + 1).ToString();

                TabPage tab = new TabPage(titulo);
                tab.Name = name;
                tab_modulos.TabPages.Add(tab);

                txt_codCurso = new TextBox();
                lbl_codCurso = new Label();
                txt_descricao = new TextBox();
                lbl_descricao = new Label();

                // Definindo propriedades do label CodCurso
                lbl_codCurso.Text = "Código do Curso:";
                lbl_codCurso.Location = new Point(205, 10);


                // Definindo propriedades do texbox CodCurso
                txt_codCurso.Location = new Point(192, 29);
                txt_codCurso.Enabled = false;


                // Definindo propriedades do label Descricao
                lbl_descricao.Text = "Descrição:";
                lbl_descricao.Location = new Point(21, 30);

                // Definindo propriedades do texbox Descricao
                txt_descricao.Name = "txt_modulo" + (i + 1);
                txt_descricao.Location = new Point(19, 55);
                txt_descricao.Multiline = true;
                txt_descricao.MaxLength = 500;
                txt_descricao.AutoSize = false;
                txt_descricao.Size = new Size(273, 167);
                txt_descricao.Tag = i;

                if (i == modulos - 1)
                {
                    btn_salvar = new Button();
                    btn_salvar.Click += new EventHandler(((s, e) => button_Click(s, e, modulos, nome, matricula, 
                                                                total, rescisao, meses, horas, aulaSem, multa)));
                    btn_salvar.Name = "btn_salvar";
                    btn_salvar.Text = "Salvar Todos";
                    btn_salvar.Location = new Point(195, 230);
                    btn_salvar.Size = new Size(99, 23);
                    tab.Controls.Add(btn_salvar);
                }

                tab.Controls.Add(lbl_codCurso);
                tab.Controls.Add(lbl_codCurso);
                tab.Controls.Add(lbl_descricao);
                tab.Controls.Add(txt_descricao);
            }
            

            this.Controls.Add(tab_modulos);

        }

        void button_Click(object sender, System.EventArgs e, int modulos, string nome, string matricula, 
                          string total, string rescisao, string meses, string horas, string aulaSem, string multa)
        {
            podeCadastrar = 0;

            foreach (TabPage txt in tab_modulos.TabPages)
            {
                if (txt_descricao.Text.Length > 0)
                    podeCadastrar++;
            }

            if (podeCadastrar == modulos)
            {
                if (GerenciadorBanco.CadastrarCurso(nome, meses, horas, modulos, aulaSem, matricula, 
                                                    float.Parse(total), float.Parse(multa), float.Parse(rescisao)))
                {
                    foreach (TabPage txt in tab_modulos.TabPages)
                    {
                        if (!(GerenciadorBanco.CadastrarModulo(GerenciadorBanco.GetCodModulo(GerenciadorBanco.GetCodCurso().ToString()) + 1,
                              GerenciadorBanco.GetCodCurso(), txt_descricao.Text)))
                        {
                            MessageBox.Show("Erro ao cadastrar curso e módulos!");
                            return;
                        }
                    }

                    MessageBox.Show("Curso e módulos cadastrados com sucesso!");
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar curso!");
                    return;
                }
            }
            else
                MessageBox.Show("Preencha a descrição de todos os modulos!");
        }
    }
}
