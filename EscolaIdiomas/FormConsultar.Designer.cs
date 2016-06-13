namespace EscolaIdiomas
{
    partial class FormConsultar
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
            this.dgv_pesquisa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisa
            // 
            this.dgv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisa.Location = new System.Drawing.Point(1, 1);
            this.dgv_pesquisa.Name = "dgv_pesquisa";
            this.dgv_pesquisa.Size = new System.Drawing.Size(474, 281);
            this.dgv_pesquisa.TabIndex = 4;
            this.dgv_pesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesquisa_CellContentClick);
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.dgv_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultar";
            this.Text = "Consultar Matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_pesquisa;
    }
}