namespace EscolaIdiomas
{
    partial class FormConsultaCurso
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
            this.dgv_pesquisaCurso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeCurso = new System.Windows.Forms.TextBox();
            this.txt_consultaCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisaCurso
            // 
            this.dgv_pesquisaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaCurso.Location = new System.Drawing.Point(2, 38);
            this.dgv_pesquisaCurso.Name = "dgv_pesquisaCurso";
            this.dgv_pesquisaCurso.Size = new System.Drawing.Size(474, 243);
            this.dgv_pesquisaCurso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Curso:";
            // 
            // txt_nomeCurso
            // 
            this.txt_nomeCurso.Location = new System.Drawing.Point(91, 10);
            this.txt_nomeCurso.Name = "txt_nomeCurso";
            this.txt_nomeCurso.Size = new System.Drawing.Size(301, 20);
            this.txt_nomeCurso.TabIndex = 2;
            // 
            // txt_consultaCurso
            // 
            this.txt_consultaCurso.Location = new System.Drawing.Point(398, 7);
            this.txt_consultaCurso.Name = "txt_consultaCurso";
            this.txt_consultaCurso.Size = new System.Drawing.Size(75, 23);
            this.txt_consultaCurso.TabIndex = 3;
            this.txt_consultaCurso.Text = "Consultar";
            this.txt_consultaCurso.UseVisualStyleBackColor = true;
            this.txt_consultaCurso.Click += new System.EventHandler(this.txt_consultaCurso_Click);
            // 
            // FormConsultaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.txt_consultaCurso);
            this.Controls.Add(this.txt_nomeCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pesquisaCurso);
            this.Name = "FormConsultaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisaCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomeCurso;
        private System.Windows.Forms.Button txt_consultaCurso;
    }
}