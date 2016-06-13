namespace EscolaIdiomas
{
    partial class FormConsultarResponsavel
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
            this.dgv_pesquisaResponsavel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeResponsavel = new System.Windows.Forms.TextBox();
            this.btn_consultarResponsavel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisaResponsavel
            // 
            this.dgv_pesquisaResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaResponsavel.Location = new System.Drawing.Point(1, 38);
            this.dgv_pesquisaResponsavel.Name = "dgv_pesquisaResponsavel";
            this.dgv_pesquisaResponsavel.Size = new System.Drawing.Size(474, 243);
            this.dgv_pesquisaResponsavel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Responsavel:";
            // 
            // txt_nomeResponsavel
            // 
            this.txt_nomeResponsavel.Location = new System.Drawing.Point(131, 10);
            this.txt_nomeResponsavel.Name = "txt_nomeResponsavel";
            this.txt_nomeResponsavel.Size = new System.Drawing.Size(263, 20);
            this.txt_nomeResponsavel.TabIndex = 2;
            // 
            // btn_consultarResponsavel
            // 
            this.btn_consultarResponsavel.Location = new System.Drawing.Point(400, 7);
            this.btn_consultarResponsavel.Name = "btn_consultarResponsavel";
            this.btn_consultarResponsavel.Size = new System.Drawing.Size(63, 23);
            this.btn_consultarResponsavel.TabIndex = 3;
            this.btn_consultarResponsavel.Text = "Consultar";
            this.btn_consultarResponsavel.UseVisualStyleBackColor = true;
            this.btn_consultarResponsavel.Click += new System.EventHandler(this.btn_consultarResponsavel_Click);
            // 
            // FormConsultarResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.btn_consultarResponsavel);
            this.Controls.Add(this.txt_nomeResponsavel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pesquisaResponsavel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultarResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultarResponsavel";
            this.Load += new System.EventHandler(this.FormConsultarResponsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaResponsavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisaResponsavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomeResponsavel;
        private System.Windows.Forms.Button btn_consultarResponsavel;
    }
}