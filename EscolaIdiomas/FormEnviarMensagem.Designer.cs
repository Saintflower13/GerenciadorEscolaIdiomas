namespace EscolaIdiomas
{
    partial class FormEnviarMensagem
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
            this.cmb_enviarPara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_enviarPara
            // 
            this.cmb_enviarPara.FormattingEnabled = true;
            this.cmb_enviarPara.Items.AddRange(new object[] {
            "Todos",
            "Alunos",
            "Professores"});
            this.cmb_enviarPara.Location = new System.Drawing.Point(88, 12);
            this.cmb_enviarPara.Name = "cmb_enviarPara";
            this.cmb_enviarPara.Size = new System.Drawing.Size(134, 21);
            this.cmb_enviarPara.TabIndex = 0;
            this.cmb_enviarPara.SelectedIndexChanged += new System.EventHandler(this.cmb_enviarPara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enviar para:";
            // 
            // FormEnviarMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 48);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_enviarPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEnviarMensagem";
            this.Text = "Enviar Mensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_enviarPara;
        private System.Windows.Forms.Label label1;
    }
}