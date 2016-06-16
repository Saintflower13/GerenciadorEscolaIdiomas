namespace EscolaIdiomas
{
    partial class FormRelatorio
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
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.tab_pagamento = new System.Windows.Forms.TabControl();
            this.tab_alunos = new System.Windows.Forms.TabPage();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_situacao = new System.Windows.Forms.ComboBox();
            this.tab_pagamentos = new System.Windows.Forms.TabPage();
            this.dgv_pagamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.tab_pagamento.SuspendLayout();
            this.tab_alunos.SuspendLayout();
            this.tab_pagamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_alunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_alunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(0, 46);
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_alunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_alunos.Size = new System.Drawing.Size(655, 251);
            this.dgv_alunos.TabIndex = 0;
            // 
            // tab_pagamento
            // 
            this.tab_pagamento.Controls.Add(this.tab_alunos);
            this.tab_pagamento.Controls.Add(this.tab_pagamentos);
            this.tab_pagamento.Location = new System.Drawing.Point(1, 1);
            this.tab_pagamento.Name = "tab_pagamento";
            this.tab_pagamento.SelectedIndex = 0;
            this.tab_pagamento.Size = new System.Drawing.Size(663, 323);
            this.tab_pagamento.TabIndex = 1;
            // 
            // tab_alunos
            // 
            this.tab_alunos.Controls.Add(this.btn_gerar);
            this.tab_alunos.Controls.Add(this.cmb_cursos);
            this.tab_alunos.Controls.Add(this.label2);
            this.tab_alunos.Controls.Add(this.label1);
            this.tab_alunos.Controls.Add(this.cmb_situacao);
            this.tab_alunos.Controls.Add(this.dgv_alunos);
            this.tab_alunos.Location = new System.Drawing.Point(4, 22);
            this.tab_alunos.Name = "tab_alunos";
            this.tab_alunos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_alunos.Size = new System.Drawing.Size(655, 297);
            this.tab_alunos.TabIndex = 0;
            this.tab_alunos.Text = "Alunos";
            this.tab_alunos.UseVisualStyleBackColor = true;
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(531, 11);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(118, 23);
            this.btn_gerar.TabIndex = 5;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Location = new System.Drawing.Point(51, 13);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(298, 21);
            this.cmb_cursos.TabIndex = 4;
            this.cmb_cursos.DropDown += new System.EventHandler(this.cmb_cursos_DropDown);
            this.cmb_cursos.Leave += new System.EventHandler(this.cmb_cursos_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Situação do Aluno: ";
            // 
            // cmb_situacao
            // 
            this.cmb_situacao.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "a",
            "i"});
            this.cmb_situacao.FormattingEnabled = true;
            this.cmb_situacao.Items.AddRange(new object[] {
            "Todos",
            "a",
            "i"});
            this.cmb_situacao.Location = new System.Drawing.Point(461, 13);
            this.cmb_situacao.Name = "cmb_situacao";
            this.cmb_situacao.Size = new System.Drawing.Size(61, 21);
            this.cmb_situacao.TabIndex = 1;
            // 
            // tab_pagamentos
            // 
            this.tab_pagamentos.Controls.Add(this.dgv_pagamentos);
            this.tab_pagamentos.Location = new System.Drawing.Point(4, 22);
            this.tab_pagamentos.Name = "tab_pagamentos";
            this.tab_pagamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pagamentos.Size = new System.Drawing.Size(655, 297);
            this.tab_pagamentos.TabIndex = 1;
            this.tab_pagamentos.Text = "Pagamentos";
            this.tab_pagamentos.UseVisualStyleBackColor = true;
            // 
            // dgv_pagamentos
            // 
            this.dgv_pagamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pagamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_pagamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pagamentos.Location = new System.Drawing.Point(0, 50);
            this.dgv_pagamentos.Name = "dgv_pagamentos";
            this.dgv_pagamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_pagamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pagamentos.Size = new System.Drawing.Size(655, 251);
            this.dgv_pagamentos.TabIndex = 1;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 336);
            this.Controls.Add(this.tab_pagamento);
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.tab_pagamento.ResumeLayout(false);
            this.tab_alunos.ResumeLayout(false);
            this.tab_alunos.PerformLayout();
            this.tab_pagamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.TabControl tab_pagamento;
        private System.Windows.Forms.TabPage tab_alunos;
        private System.Windows.Forms.TabPage tab_pagamentos;
        private System.Windows.Forms.DataGridView dgv_pagamentos;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_situacao;
    }
}