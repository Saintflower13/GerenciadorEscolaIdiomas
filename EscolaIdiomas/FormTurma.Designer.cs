namespace EscolaIdiomas
{
    partial class FormTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.cmb_modulos = new System.Windows.Forms.ComboBox();
            this.txt_minAlunos = new System.Windows.Forms.TextBox();
            this.txt_maxAlunos = new System.Windows.Forms.TextBox();
            this.GroupoDias = new System.Windows.Forms.GroupBox();
            this.ck_sab = new System.Windows.Forms.CheckBox();
            this.ck_sxt = new System.Windows.Forms.CheckBox();
            this.ck_qnt = new System.Windows.Forms.CheckBox();
            this.ck_qrt = new System.Windows.Forms.CheckBox();
            this.ck_ter = new System.Windows.Forms.CheckBox();
            this.ck_sgn = new System.Windows.Forms.CheckBox();
            this.ck_dmg = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_horarioInicial = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_professor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.GroupoDias.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Location = new System.Drawing.Point(30, 48);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(218, 21);
            this.cmb_cursos.TabIndex = 0;
            this.cmb_cursos.DropDown += new System.EventHandler(this.cmb_cursos_DropDown);
            this.cmb_cursos.Leave += new System.EventHandler(this.cmb_cursos_Leave);
            this.cmb_cursos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_cursos_PreviewKeyDown);
            // 
            // cmb_modulos
            // 
            this.cmb_modulos.FormattingEnabled = true;
            this.cmb_modulos.Location = new System.Drawing.Point(281, 48);
            this.cmb_modulos.Name = "cmb_modulos";
            this.cmb_modulos.Size = new System.Drawing.Size(70, 21);
            this.cmb_modulos.TabIndex = 1;
            this.cmb_modulos.DropDown += new System.EventHandler(this.cmb_modulos_DropDown);
            // 
            // txt_minAlunos
            // 
            this.txt_minAlunos.Location = new System.Drawing.Point(57, 120);
            this.txt_minAlunos.MaxLength = 3;
            this.txt_minAlunos.Name = "txt_minAlunos";
            this.txt_minAlunos.Size = new System.Drawing.Size(35, 20);
            this.txt_minAlunos.TabIndex = 2;
            this.txt_minAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minAlunos_KeyPress);
            // 
            // txt_maxAlunos
            // 
            this.txt_maxAlunos.Location = new System.Drawing.Point(134, 120);
            this.txt_maxAlunos.MaxLength = 3;
            this.txt_maxAlunos.Name = "txt_maxAlunos";
            this.txt_maxAlunos.Size = new System.Drawing.Size(35, 20);
            this.txt_maxAlunos.TabIndex = 3;
            this.txt_maxAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxAlunos_KeyPress);
            // 
            // GroupoDias
            // 
            this.GroupoDias.Controls.Add(this.ck_sab);
            this.GroupoDias.Controls.Add(this.ck_sxt);
            this.GroupoDias.Controls.Add(this.ck_qnt);
            this.GroupoDias.Controls.Add(this.ck_qrt);
            this.GroupoDias.Controls.Add(this.ck_ter);
            this.GroupoDias.Controls.Add(this.ck_sgn);
            this.GroupoDias.Controls.Add(this.ck_dmg);
            this.GroupoDias.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupoDias.Location = new System.Drawing.Point(4, 158);
            this.GroupoDias.Name = "GroupoDias";
            this.GroupoDias.Size = new System.Drawing.Size(395, 58);
            this.GroupoDias.TabIndex = 5;
            this.GroupoDias.TabStop = false;
            this.GroupoDias.Text = "Dias que haverão aulas";
            // 
            // ck_sab
            // 
            this.ck_sab.AutoSize = true;
            this.ck_sab.Location = new System.Drawing.Point(327, 22);
            this.ck_sab.Name = "ck_sab";
            this.ck_sab.Size = new System.Drawing.Size(49, 20);
            this.ck_sab.TabIndex = 6;
            this.ck_sab.Text = "Sab";
            this.ck_sab.UseVisualStyleBackColor = true;
            this.ck_sab.CheckedChanged += new System.EventHandler(this.ck_sab_CheckedChanged);
            // 
            // ck_sxt
            // 
            this.ck_sxt.AutoSize = true;
            this.ck_sxt.Location = new System.Drawing.Point(273, 22);
            this.ck_sxt.Name = "ck_sxt";
            this.ck_sxt.Size = new System.Drawing.Size(48, 20);
            this.ck_sxt.TabIndex = 5;
            this.ck_sxt.Text = "Sex";
            this.ck_sxt.UseVisualStyleBackColor = true;
            this.ck_sxt.CheckedChanged += new System.EventHandler(this.ck_sxt_CheckedChanged);
            // 
            // ck_qnt
            // 
            this.ck_qnt.AutoSize = true;
            this.ck_qnt.Location = new System.Drawing.Point(221, 22);
            this.ck_qnt.Name = "ck_qnt";
            this.ck_qnt.Size = new System.Drawing.Size(46, 20);
            this.ck_qnt.TabIndex = 4;
            this.ck_qnt.Text = "Qui";
            this.ck_qnt.UseVisualStyleBackColor = true;
            this.ck_qnt.CheckedChanged += new System.EventHandler(this.ck_qnt_CheckedChanged);
            // 
            // ck_qrt
            // 
            this.ck_qrt.AutoSize = true;
            this.ck_qrt.Location = new System.Drawing.Point(166, 22);
            this.ck_qrt.Name = "ck_qrt";
            this.ck_qrt.Size = new System.Drawing.Size(50, 20);
            this.ck_qrt.TabIndex = 3;
            this.ck_qrt.Text = "Qua";
            this.ck_qrt.UseVisualStyleBackColor = true;
            this.ck_qrt.CheckedChanged += new System.EventHandler(this.ck_qrt_CheckedChanged);
            // 
            // ck_ter
            // 
            this.ck_ter.AutoSize = true;
            this.ck_ter.Location = new System.Drawing.Point(118, 22);
            this.ck_ter.Name = "ck_ter";
            this.ck_ter.Size = new System.Drawing.Size(47, 20);
            this.ck_ter.TabIndex = 2;
            this.ck_ter.Text = "Ter";
            this.ck_ter.UseVisualStyleBackColor = true;
            this.ck_ter.CheckedChanged += new System.EventHandler(this.ck_ter_CheckedChanged);
            // 
            // ck_sgn
            // 
            this.ck_sgn.AutoSize = true;
            this.ck_sgn.Location = new System.Drawing.Point(63, 22);
            this.ck_sgn.Name = "ck_sgn";
            this.ck_sgn.Size = new System.Drawing.Size(49, 20);
            this.ck_sgn.TabIndex = 1;
            this.ck_sgn.Text = "Seg";
            this.ck_sgn.UseVisualStyleBackColor = true;
            this.ck_sgn.CheckedChanged += new System.EventHandler(this.ck_sgn_CheckedChanged);
            // 
            // ck_dmg
            // 
            this.ck_dmg.AutoSize = true;
            this.ck_dmg.Location = new System.Drawing.Point(8, 22);
            this.ck_dmg.Name = "ck_dmg";
            this.ck_dmg.Size = new System.Drawing.Size(53, 20);
            this.ck_dmg.TabIndex = 0;
            this.ck_dmg.Text = "Dom";
            this.ck_dmg.UseVisualStyleBackColor = true;
            this.ck_dmg.CheckedChanged += new System.EventHandler(this.ck_dmg_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione um curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Módulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade de aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max:";
            // 
            // msk_horarioInicial
            // 
            this.msk_horarioInicial.Location = new System.Drawing.Point(300, 120);
            this.msk_horarioInicial.Mask = "00:00";
            this.msk_horarioInicial.Name = "msk_horarioInicial";
            this.msk_horarioInicial.Size = new System.Drawing.Size(34, 20);
            this.msk_horarioInicial.TabIndex = 11;
            this.msk_horarioInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Horário Inicial:";
            // 
            // cmb_professor
            // 
            this.cmb_professor.FormattingEnabled = true;
            this.cmb_professor.Location = new System.Drawing.Point(30, 243);
            this.cmb_professor.Name = "cmb_professor";
            this.cmb_professor.Size = new System.Drawing.Size(241, 21);
            this.cmb_professor.TabIndex = 13;
            this.cmb_professor.DropDown += new System.EventHandler(this.cmb_professor_DropDown);
            this.cmb_professor.Leave += new System.EventHandler(this.cmb_professor_Leave);
            this.cmb_professor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_professor_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Professor que ministrará a aula:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(293, 243);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // FormTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 316);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_professor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk_horarioInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupoDias);
            this.Controls.Add(this.txt_maxAlunos);
            this.Controls.Add(this.txt_minAlunos);
            this.Controls.Add(this.cmb_modulos);
            this.Controls.Add(this.cmb_cursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Turma";
            this.GroupoDias.ResumeLayout(false);
            this.GroupoDias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.ComboBox cmb_modulos;
        private System.Windows.Forms.TextBox txt_minAlunos;
        private System.Windows.Forms.TextBox txt_maxAlunos;
        private System.Windows.Forms.GroupBox GroupoDias;
        private System.Windows.Forms.CheckBox ck_sab;
        private System.Windows.Forms.CheckBox ck_sxt;
        private System.Windows.Forms.CheckBox ck_qnt;
        private System.Windows.Forms.CheckBox ck_qrt;
        private System.Windows.Forms.CheckBox ck_ter;
        private System.Windows.Forms.CheckBox ck_sgn;
        private System.Windows.Forms.CheckBox ck_dmg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_horarioInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_professor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_salvar;
    }
}