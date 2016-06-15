namespace EscolaIdiomas
{
    partial class FormPagamento
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
            this.cmb_matriculaAluno = new System.Windows.Forms.ComboBox();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vParcela = new System.Windows.Forms.TextBox();
            this.txt_vAtraso = new System.Windows.Forms.TextBox();
            this.txt_vMulta = new System.Windows.Forms.TextBox();
            this.txt_vTotal = new System.Windows.Forms.TextBox();
            this.txt_vRecebido = new System.Windows.Forms.TextBox();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.ck_incluiAtraso = new System.Windows.Forms.CheckBox();
            this.ck_incluiMulta = new System.Windows.Forms.CheckBox();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.txt_pagamento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_matriculaAluno
            // 
            this.cmb_matriculaAluno.FormattingEnabled = true;
            this.cmb_matriculaAluno.Location = new System.Drawing.Point(13, 13);
            this.cmb_matriculaAluno.Name = "cmb_matriculaAluno";
            this.cmb_matriculaAluno.Size = new System.Drawing.Size(462, 21);
            this.cmb_matriculaAluno.TabIndex = 0;
            this.cmb_matriculaAluno.DropDown += new System.EventHandler(this.cmb_matriculaAluno_DropDown);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(481, 13);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(127, 23);
            this.btn_selecionar.TabIndex = 1;
            this.btn_selecionar.Text = "Selecionar Aluno";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor da Parcela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor em atraso.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multa................:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total................:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor Recebido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Troco...............:";
            // 
            // txt_vParcela
            // 
            this.txt_vParcela.Location = new System.Drawing.Point(135, 85);
            this.txt_vParcela.Name = "txt_vParcela";
            this.txt_vParcela.Size = new System.Drawing.Size(100, 20);
            this.txt_vParcela.TabIndex = 8;
            // 
            // txt_vAtraso
            // 
            this.txt_vAtraso.Location = new System.Drawing.Point(135, 112);
            this.txt_vAtraso.Name = "txt_vAtraso";
            this.txt_vAtraso.Size = new System.Drawing.Size(100, 20);
            this.txt_vAtraso.TabIndex = 9;
            // 
            // txt_vMulta
            // 
            this.txt_vMulta.Location = new System.Drawing.Point(135, 139);
            this.txt_vMulta.Name = "txt_vMulta";
            this.txt_vMulta.Size = new System.Drawing.Size(100, 20);
            this.txt_vMulta.TabIndex = 10;
            // 
            // txt_vTotal
            // 
            this.txt_vTotal.Location = new System.Drawing.Point(135, 183);
            this.txt_vTotal.Name = "txt_vTotal";
            this.txt_vTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_vTotal.TabIndex = 11;
            // 
            // txt_vRecebido
            // 
            this.txt_vRecebido.Location = new System.Drawing.Point(135, 209);
            this.txt_vRecebido.Name = "txt_vRecebido";
            this.txt_vRecebido.Size = new System.Drawing.Size(100, 20);
            this.txt_vRecebido.TabIndex = 12;
            // 
            // txt_troco
            // 
            this.txt_troco.Location = new System.Drawing.Point(135, 236);
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(100, 20);
            this.txt_troco.TabIndex = 13;
            // 
            // ck_incluiAtraso
            // 
            this.ck_incluiAtraso.AutoSize = true;
            this.ck_incluiAtraso.Location = new System.Drawing.Point(242, 115);
            this.ck_incluiAtraso.Name = "ck_incluiAtraso";
            this.ck_incluiAtraso.Size = new System.Drawing.Size(86, 17);
            this.ck_incluiAtraso.TabIndex = 14;
            this.ck_incluiAtraso.Text = "* incluir valor";
            this.ck_incluiAtraso.UseVisualStyleBackColor = true;
            // 
            // ck_incluiMulta
            // 
            this.ck_incluiMulta.AutoSize = true;
            this.ck_incluiMulta.Location = new System.Drawing.Point(242, 142);
            this.ck_incluiMulta.Name = "ck_incluiMulta";
            this.ck_incluiMulta.Size = new System.Drawing.Size(86, 17);
            this.ck_incluiMulta.TabIndex = 15;
            this.ck_incluiMulta.Text = "* incluir valor";
            this.ck_incluiMulta.UseVisualStyleBackColor = true;
            this.ck_incluiMulta.Click += new System.EventHandler(this.ck_incluiMulta_Click);
            // 
            // dgv_historico
            // 
            this.dgv_historico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.Location = new System.Drawing.Point(358, 75);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.Size = new System.Drawing.Size(240, 228);
            this.dgv_historico.TabIndex = 16;
            // 
            // txt_pagamento
            // 
            this.txt_pagamento.Location = new System.Drawing.Point(44, 280);
            this.txt_pagamento.Name = "txt_pagamento";
            this.txt_pagamento.Size = new System.Drawing.Size(129, 23);
            this.txt_pagamento.TabIndex = 17;
            this.txt_pagamento.Text = "Ok";
            this.txt_pagamento.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Histórico de Pagamento:";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 325);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pagamento);
            this.Controls.Add(this.dgv_historico);
            this.Controls.Add(this.ck_incluiMulta);
            this.Controls.Add(this.ck_incluiAtraso);
            this.Controls.Add(this.txt_troco);
            this.Controls.Add(this.txt_vRecebido);
            this.Controls.Add(this.txt_vTotal);
            this.Controls.Add(this.txt_vMulta);
            this.Controls.Add(this.txt_vAtraso);
            this.Controls.Add(this.txt_vParcela);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.cmb_matriculaAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_matriculaAluno;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vParcela;
        private System.Windows.Forms.TextBox txt_vAtraso;
        private System.Windows.Forms.TextBox txt_vMulta;
        private System.Windows.Forms.TextBox txt_vTotal;
        private System.Windows.Forms.TextBox txt_vRecebido;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.CheckBox ck_incluiAtraso;
        private System.Windows.Forms.CheckBox ck_incluiMulta;
        private System.Windows.Forms.DataGridView dgv_historico;
        private System.Windows.Forms.Button txt_pagamento;
        private System.Windows.Forms.Label label7;
    }
}