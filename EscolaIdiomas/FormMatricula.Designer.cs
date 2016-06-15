namespace EscolaIdiomas
{
    partial class FormMatricula
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
            this.cmb_codTurma = new System.Windows.Forms.ComboBox();
            this.cmb_aluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_codTurma
            // 
            this.cmb_codTurma.FormattingEnabled = true;
            this.cmb_codTurma.Location = new System.Drawing.Point(12, 34);
            this.cmb_codTurma.Name = "cmb_codTurma";
            this.cmb_codTurma.Size = new System.Drawing.Size(341, 21);
            this.cmb_codTurma.TabIndex = 1;
            this.cmb_codTurma.DropDown += new System.EventHandler(this.cmb_codTurma_DropDown);
            this.cmb_codTurma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_codTurma_KeyPress);
            // 
            // cmb_aluno
            // 
            this.cmb_aluno.FormattingEnabled = true;
            this.cmb_aluno.Location = new System.Drawing.Point(15, 83);
            this.cmb_aluno.Name = "cmb_aluno";
            this.cmb_aluno.Size = new System.Drawing.Size(338, 21);
            this.cmb_aluno.TabIndex = 2;
            this.cmb_aluno.DropDown += new System.EventHandler(this.cmb_aluno_DropDown);
            this.cmb_aluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_aluno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dia para vencimento das parcelas:";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(189, 120);
            this.txt_dia.MaxLength = 2;
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(23, 20);
            this.txt_dia.TabIndex = 4;
            this.txt_dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código da Turma / Nome do Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código / Nome  / CPF do Aluno:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(228, 118);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(125, 23);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // FormMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 164);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_aluno);
            this.Controls.Add(this.cmb_codTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricular ALuno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_codTurma;
        private System.Windows.Forms.ComboBox cmb_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salvar;
    }
}