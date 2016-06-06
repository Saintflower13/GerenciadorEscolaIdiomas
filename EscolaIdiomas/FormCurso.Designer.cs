namespace EscolaIdiomas
{
    partial class FormCurso
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
            this.txt_nomeCurso = new System.Windows.Forms.TextBox();
            this.txt_codCurso = new System.Windows.Forms.TextBox();
            this.msk_horas = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_vMulta = new System.Windows.Forms.TextBox();
            this.txt_vRescisao = new System.Windows.Forms.TextBox();
            this.txt_vTotal = new System.Windows.Forms.TextBox();
            this.txt_vMatricula = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_modulos = new System.Windows.Forms.TextBox();
            this.txt_meses = new System.Windows.Forms.TextBox();
            this.cmb_dias = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_salvarCurso = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nomeCurso
            // 
            this.txt_nomeCurso.Location = new System.Drawing.Point(99, 36);
            this.txt_nomeCurso.Name = "txt_nomeCurso";
            this.txt_nomeCurso.Size = new System.Drawing.Size(228, 22);
            this.txt_nomeCurso.TabIndex = 0;
            // 
            // txt_codCurso
            // 
            this.txt_codCurso.Enabled = false;
            this.txt_codCurso.Location = new System.Drawing.Point(384, 36);
            this.txt_codCurso.Name = "txt_codCurso";
            this.txt_codCurso.Size = new System.Drawing.Size(100, 22);
            this.txt_codCurso.TabIndex = 1;
            // 
            // msk_horas
            // 
            this.msk_horas.Location = new System.Drawing.Point(150, 103);
            this.msk_horas.Mask = "00:00";
            this.msk_horas.Name = "msk_horas";
            this.msk_horas.Size = new System.Drawing.Size(37, 22);
            this.msk_horas.TabIndex = 3;
            this.msk_horas.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duração Total..................:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Duração de cada aula.....:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade de módulos...:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Aulas por semana............:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valor da matrícula............:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "aulas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Valor Total do curso.........:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Valor da multa por atraso..:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(171, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "%  por dia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Valor rescisão do contrato:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_vMulta);
            this.groupBox1.Controls.Add(this.txt_vRescisao);
            this.groupBox1.Controls.Add(this.txt_vTotal);
            this.groupBox1.Controls.Add(this.txt_vMatricula);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 171);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Financeiro";
            // 
            // txt_vMulta
            // 
            this.txt_vMulta.Location = new System.Drawing.Point(144, 100);
            this.txt_vMulta.MaxLength = 3;
            this.txt_vMulta.Name = "txt_vMulta";
            this.txt_vMulta.Size = new System.Drawing.Size(24, 22);
            this.txt_vMulta.TabIndex = 31;
            this.txt_vMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vMulta_KeyPress);
            // 
            // txt_vRescisao
            // 
            this.txt_vRescisao.Location = new System.Drawing.Point(144, 131);
            this.txt_vRescisao.MaxLength = 13;
            this.txt_vRescisao.Name = "txt_vRescisao";
            this.txt_vRescisao.Size = new System.Drawing.Size(86, 22);
            this.txt_vRescisao.TabIndex = 30;
            this.txt_vRescisao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vRescisao_KeyPress);
            // 
            // txt_vTotal
            // 
            this.txt_vTotal.Location = new System.Drawing.Point(144, 72);
            this.txt_vTotal.MaxLength = 13;
            this.txt_vTotal.Name = "txt_vTotal";
            this.txt_vTotal.Size = new System.Drawing.Size(86, 22);
            this.txt_vTotal.TabIndex = 29;
            this.txt_vTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vTotal_KeyPress);
            // 
            // txt_vMatricula
            // 
            this.txt_vMatricula.Location = new System.Drawing.Point(144, 42);
            this.txt_vMatricula.MaxLength = 13;
            this.txt_vMatricula.Name = "txt_vMatricula";
            this.txt_vMatricula.Size = new System.Drawing.Size(86, 22);
            this.txt_vMatricula.TabIndex = 28;
            this.txt_vMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vMatricula_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_modulos);
            this.groupBox2.Controls.Add(this.txt_meses);
            this.groupBox2.Controls.Add(this.cmb_dias);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.msk_horas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(270, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 171);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formato";
            // 
            // txt_modulos
            // 
            this.txt_modulos.Location = new System.Drawing.Point(150, 74);
            this.txt_modulos.MaxLength = 3;
            this.txt_modulos.Name = "txt_modulos";
            this.txt_modulos.Size = new System.Drawing.Size(37, 22);
            this.txt_modulos.TabIndex = 22;
            this.txt_modulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_modulos_KeyPress);
            // 
            // txt_meses
            // 
            this.txt_meses.Location = new System.Drawing.Point(150, 44);
            this.txt_meses.MaxLength = 3;
            this.txt_meses.Name = "txt_meses";
            this.txt_meses.Size = new System.Drawing.Size(37, 22);
            this.txt_meses.TabIndex = 21;
            this.txt_meses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_meses_KeyPress);
            // 
            // cmb_dias
            // 
            this.cmb_dias.FormattingEnabled = true;
            this.cmb_dias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmb_dias.Location = new System.Drawing.Point(150, 133);
            this.cmb_dias.Name = "cmb_dias";
            this.cmb_dias.Size = new System.Drawing.Size(37, 24);
            this.cmb_dias.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_nomeCurso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_codCurso);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 79);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identificadores";
            // 
            // btn_salvarCurso
            // 
            this.btn_salvarCurso.Location = new System.Drawing.Point(401, 274);
            this.btn_salvarCurso.Name = "btn_salvarCurso";
            this.btn_salvarCurso.Size = new System.Drawing.Size(116, 23);
            this.btn_salvarCurso.TabIndex = 29;
            this.btn_salvarCurso.Text = "Cadastrar Módulos";
            this.btn_salvarCurso.UseVisualStyleBackColor = true;
            this.btn_salvarCurso.Click += new System.EventHandler(this.btn_salvarCurso_Click);
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 309);
            this.Controls.Add(this.btn_salvarCurso);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Curso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeCurso;
        private System.Windows.Forms.TextBox txt_codCurso;
        private System.Windows.Forms.MaskedTextBox msk_horas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_dias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_salvarCurso;
        private System.Windows.Forms.TextBox txt_vMulta;
        private System.Windows.Forms.TextBox txt_vRescisao;
        private System.Windows.Forms.TextBox txt_vTotal;
        private System.Windows.Forms.TextBox txt_vMatricula;
        public System.Windows.Forms.TextBox txt_modulos;
        private System.Windows.Forms.TextBox txt_meses;
    }
}