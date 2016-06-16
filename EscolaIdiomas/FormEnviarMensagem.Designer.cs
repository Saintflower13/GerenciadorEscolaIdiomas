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
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_email_para = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_email_para = new System.Windows.Forms.TextBox();
            this.ck_anexo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(195, 389);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(113, 23);
            this.btn_enviar.TabIndex = 13;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_email_para
            // 
            this.lbl_email_para.AutoSize = true;
            this.lbl_email_para.Location = new System.Drawing.Point(15, 98);
            this.lbl_email_para.Name = "lbl_email_para";
            this.lbl_email_para.Size = new System.Drawing.Size(47, 13);
            this.lbl_email_para.TabIndex = 11;
            this.lbl_email_para.Text = "Para.....:";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(16, 149);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(292, 234);
            this.txt_msg.TabIndex = 10;
            this.txt_msg.Text = "Escreva aqui sua mensagem...";
            this.txt_msg.Enter += new System.EventHandler(this.txt_msg_Enter);
            this.txt_msg.Leave += new System.EventHandler(this.txt_msg_Leave);
            // 
            // txt_email_para
            // 
            this.txt_email_para.Location = new System.Drawing.Point(69, 95);
            this.txt_email_para.Name = "txt_email_para";
            this.txt_email_para.Size = new System.Drawing.Size(239, 20);
            this.txt_email_para.TabIndex = 9;
            // 
            // ck_anexo
            // 
            this.ck_anexo.AutoSize = true;
            this.ck_anexo.Location = new System.Drawing.Point(16, 389);
            this.ck_anexo.Name = "ck_anexo";
            this.ck_anexo.Size = new System.Drawing.Size(98, 17);
            this.ck_anexo.TabIndex = 14;
            this.ck_anexo.Text = "Anexar Arquivo";
            this.ck_anexo.UseVisualStyleBackColor = true;
            this.ck_anexo.Click += new System.EventHandler(this.ck_anexo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Assunto:";
            // 
            // txt_assunto
            // 
            this.txt_assunto.Location = new System.Drawing.Point(69, 121);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(239, 20);
            this.txt_assunto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "De: madrelinguaescola@gmail.com";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(57, 38);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(229, 20);
            this.txt_senha.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Senha.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 69);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Login";
            // 
            // FormEnviarMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_assunto);
            this.Controls.Add(this.ck_anexo);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_email_para);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_email_para);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEnviarMensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Email";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_email_para;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_email_para;
        private System.Windows.Forms.CheckBox ck_anexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}