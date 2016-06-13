namespace EscolaIdiomas
{
    partial class FormConsultaModulo
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
            this.dgv_pesquisaModulo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_consultaModulo = new System.Windows.Forms.TextBox();
            this.btn_consultaModulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisaModulo
            // 
            this.dgv_pesquisaModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaModulo.Location = new System.Drawing.Point(-1, 37);
            this.dgv_pesquisaModulo.Name = "dgv_pesquisaModulo";
            this.dgv_pesquisaModulo.Size = new System.Drawing.Size(474, 243);
            this.dgv_pesquisaModulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do curso:";
            // 
            // txt_consultaModulo
            // 
            this.txt_consultaModulo.Location = new System.Drawing.Point(101, 9);
            this.txt_consultaModulo.Name = "txt_consultaModulo";
            this.txt_consultaModulo.Size = new System.Drawing.Size(282, 20);
            this.txt_consultaModulo.TabIndex = 2;
            // 
            // btn_consultaModulo
            // 
            this.btn_consultaModulo.Location = new System.Drawing.Point(390, 9);
            this.btn_consultaModulo.Name = "btn_consultaModulo";
            this.btn_consultaModulo.Size = new System.Drawing.Size(75, 23);
            this.btn_consultaModulo.TabIndex = 3;
            this.btn_consultaModulo.Text = "Consultar";
            this.btn_consultaModulo.UseVisualStyleBackColor = true;
            this.btn_consultaModulo.Click += new System.EventHandler(this.btn_consultaModulo_Click);
            // 
            // FormConsultaModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.btn_consultaModulo);
            this.Controls.Add(this.txt_consultaModulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pesquisaModulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultaModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaModulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaModulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisaModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_consultaModulo;
        private System.Windows.Forms.Button btn_consultaModulo;
    }
}