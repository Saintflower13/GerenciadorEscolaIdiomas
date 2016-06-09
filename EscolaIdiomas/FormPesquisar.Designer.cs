namespace EscolaIdiomas
{
    partial class FormPesquisar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.dgv_pesquisa = new System.Windows.Forms.DataGridView();
            this.cmb_nome = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(364, 16);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(83, 20);
            this.msk_cpf.TabIndex = 3;
            // 
            // dgv_pesquisa
            // 
            this.dgv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisa.Location = new System.Drawing.Point(15, 59);
            this.dgv_pesquisa.Name = "dgv_pesquisa";
            this.dgv_pesquisa.Size = new System.Drawing.Size(453, 210);
            this.dgv_pesquisa.TabIndex = 4;
            // 
            // cmb_nome
            // 
            this.cmb_nome.FormattingEnabled = true;
            this.cmb_nome.Location = new System.Drawing.Point(57, 16);
            this.cmb_nome.Name = "cmb_nome";
            this.cmb_nome.Size = new System.Drawing.Size(254, 21);
            this.cmb_nome.TabIndex = 5;
            this.cmb_nome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_nomes_PreviewKeyDown);
            // 
            // FormPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 281);
            this.Controls.Add(this.cmb_nome);
            this.Controls.Add(this.dgv_pesquisa);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPesquisar";
            this.Text = "Pesquisar Responsavel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.DataGridView dgv_pesquisa;
        private System.Windows.Forms.ComboBox cmb_nome;
    }
}