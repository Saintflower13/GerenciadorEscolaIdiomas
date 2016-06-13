namespace EscolaIdiomas
{
    partial class FormConsultaTurma
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
            this.dgv_pesquisaTurma = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_consultaTurma = new System.Windows.Forms.TextBox();
            this.btn_consultarTurma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisaTurma
            // 
            this.dgv_pesquisaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaTurma.Location = new System.Drawing.Point(-1, 39);
            this.dgv_pesquisaTurma.Name = "dgv_pesquisaTurma";
            this.dgv_pesquisaTurma.Size = new System.Drawing.Size(474, 243);
            this.dgv_pesquisaTurma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso:";
            // 
            // txt_consultaTurma
            // 
            this.txt_consultaTurma.Location = new System.Drawing.Point(56, 9);
            this.txt_consultaTurma.Name = "txt_consultaTurma";
            this.txt_consultaTurma.Size = new System.Drawing.Size(336, 20);
            this.txt_consultaTurma.TabIndex = 2;
            // 
            // btn_consultarTurma
            // 
            this.btn_consultarTurma.Location = new System.Drawing.Point(398, 7);
            this.btn_consultarTurma.Name = "btn_consultarTurma";
            this.btn_consultarTurma.Size = new System.Drawing.Size(75, 23);
            this.btn_consultarTurma.TabIndex = 3;
            this.btn_consultarTurma.Text = "Consultar";
            this.btn_consultarTurma.UseVisualStyleBackColor = true;
            this.btn_consultarTurma.Click += new System.EventHandler(this.btn_consultarTurma_Click);
            // 
            // FormConsultaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.btn_consultarTurma);
            this.Controls.Add(this.txt_consultaTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pesquisaTurma);
            this.Name = "FormConsultaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaTurma";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisaTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_consultaTurma;
        private System.Windows.Forms.Button btn_consultarTurma;
    }
}