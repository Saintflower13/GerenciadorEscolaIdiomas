using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace EscolaIdiomas
{
    public partial class FormEnviarMensagem : Form
    {
        string emailEscola = "madrelinguaescola@gmail.com",
               caminhoArquivo = "";

        public FormEnviarMensagem()
        {
            InitializeComponent();
        }

        private void txt_msg_Enter(object sender, EventArgs e)
        {
            txt_msg.Text = "";
        }

        private void txt_msg_Leave(object sender, EventArgs e)
        {
            if (txt_msg.Text.Length > 0)
                return;

            if (txt_msg.Text.Length == 0)
                txt_msg.Text = "Escreva aqui sua mensagem...";
        }

        private void ck_anexo_Click(object sender, EventArgs e)
        {
            if (ck_anexo.Checked)
            {
                OpenFileDialog formArquivo = new OpenFileDialog();
                formArquivo.ShowDialog();

                caminhoArquivo = formArquivo.FileName;
                ck_anexo.Text = "Desanexar Arquivo";
                return;
            }

            ck_anexo.Text = "Anexar Arquivo";
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (txt_senha.Text.Length < 1)
            {
                MessageBox.Show("Informe a senha para login!", "Erro!");
                return;
            }

            string senhaEscola = txt_senha.Text;

            try
            {
                MailMessage email = new MailMessage();
                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");

                email.From = new MailAddress(emailEscola);
                email.To.Add(txt_email_para.Text);
                email.Subject = txt_assunto.Text;

                if (txt_msg.Text == "Escreva aqui sua mensagem...")
                    email.Body = "";
                else
                    email.Body = txt_msg.Text;

                if (ck_anexo.Checked)
                {
                    Attachment anexo = new Attachment(caminhoArquivo);
                    email.Attachments.Add(anexo);
                }

                clienteSmtp.UseDefaultCredentials = false;
                clienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                clienteSmtp.EnableSsl = true;
                clienteSmtp.Port = 587;
                clienteSmtp.Credentials = new System.Net.NetworkCredential(emailEscola, senhaEscola);
                clienteSmtp.Timeout = 20000;
                clienteSmtp.Send(email);

                MessageBox.Show("E-mail enviado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
