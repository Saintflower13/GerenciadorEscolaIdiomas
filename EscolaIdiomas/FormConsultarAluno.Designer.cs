namespace EscolaIdiomas
{
    partial class FormConsultarAluno
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
            this.dgv_pesquisaAluno = new System.Windows.Forms.DataGridView();
            this.txt_nomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisaAluno
            // 
            this.dgv_pesquisaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaAluno.Location = new System.Drawing.Point(3, 35);
            this.dgv_pesquisaAluno.Name = "dgv_pesquisaAluno";
            this.dgv_pesquisaAluno.Size = new System.Drawing.Size(474, 243);
            this.dgv_pesquisaAluno.TabIndex = 0;
            // 
            // txt_nomeAluno
            // 
            this.txt_nomeAluno.Location = new System.Drawing.Point(55, 9);
            this.txt_nomeAluno.Name = "txt_nomeAluno";
            this.txt_nomeAluno.Size = new System.Drawing.Size(327, 20);
            this.txt_nomeAluno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aluno:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(388, 7);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // FormConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomeAluno);
            this.Controls.Add(this.dgv_pesquisaAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultarAluno";
            this.Load += new System.EventHandler(this.FormConsultarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisaAluno;
        private System.Windows.Forms.TextBox txt_nomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
    }
}