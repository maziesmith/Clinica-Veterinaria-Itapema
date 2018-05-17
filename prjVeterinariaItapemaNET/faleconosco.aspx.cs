using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace prjVeterinariaItapemaNET
{
    public partial class faleconosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            SmtpClient SMTP = new SmtpClient();
            SMTP.Credentials = new NetworkCredential("siteitapema@gmail.com", ""); 
            SMTP.Host = "smtp.gmail.com";
            SMTP.Port = 587;
            SMTP.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.To.Add("itapemavet@hotmail.com");
            mail.From = new MailAddress("itapemavet@hotmail.com", "Veterinária Itapema", System.Text.Encoding.UTF8);
            mail.Subject = "Contato pelo site - " + txtAssunto.SelectedValue.ToString();
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "O cliente " + txtNome.Text + ", de email: " + txtEmail.Text;
            mail.Body += "fez contato com o texto abaixo: <br>";
            mail.Body += txtMsg.Text;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                SMTP.Send(mail);
                lblMsg.Text = "Contato realizado com sucesso!";
            }
            catch 
            {
                lblMsg.Text = "Problemas no envio de sua mensagem<br>Tente novamente!";
            }
        }
    }
}