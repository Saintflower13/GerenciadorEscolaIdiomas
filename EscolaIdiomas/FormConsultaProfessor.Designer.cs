namespace EscolaIdiomas
{
    partial class FormConsultaProfessor
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
            this.dgv_pesquisaProfessor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeProfessor = new System.Windows.Forms.TextBox();
            this.btn_consultarProfessor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisaProfessor
            // 
            this.dgv_pesquisaProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaProfessor.Location = new System.Drawing.Point(-1, 38);
            this.dgv_pesquisaProfessor.Name = "dgv_pesquisaProfessor";
            this.dgv_pesquisaProfessor.Size = new System.Drawing.Size(474, 243);
            this.dgv_pesquisaProfessor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Professor:";
            // 
            // txt_nomeProfessor
            // 
            this.txt_nomeProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nomeProfessor.Location = new System.Drawing.Point(105, 10);
            this.txt_nomeProfessor.Name = "txt_nomeProfessor";
            this.txt_nomeProfessor.Size = new System.Drawing.Size(287, 20);
            this.txt_nomeProfessor.TabIndex = 2;
            // 
            // btn_consultarProfessor
            // 
            this.btn_consultarProfessor.Location = new System.Drawing.Point(398, 8);
            this.btn_consultarProfessor.Name = "btn_consultarProfessor";
            this.btn_consultarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btn_consultarProfessor.TabIndex = 3;
            this.btn_consultarProfessor.Text = "Consultar";
            this.btn_consultarProfessor.UseVisualStyleBackColor = true;
            this.btn_consultarProfessor.Click += new System.EventHandler(this.btn_consultarProfessor_Click);
            // 
            // FormConsultaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.btn_consultarProfessor);
            this.Controls.Add(this.txt_nomeProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pesquisaProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisaProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomeProfessor;
        private System.Windows.Forms.Button btn_consultarProfessor;
    }
}