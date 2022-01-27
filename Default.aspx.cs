using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btn_send_Click(object sender, EventArgs e)
    {
        // To avoid situation, when the program crashes because server rejection or
        // invalid data, an exception handling mechanism is created
        try
        {
            // credentials
            var from = "godfreykowidi@gmail.com";
            var to = "godfreykowidi@gmail.com";
            const string Password = "L@x@d0nt@";

            // email subject
            string mail_subject = txt_subject.Text.ToString();

            //email body
            string mail_message = "From: " + txt_name.Text + "\n";
            mail_message += "Email: " + txt_email.Text + "\n";
            mail_message += "Subject: " + txt_subject.Text + "\n";
            mail_message += "Phone: " + txt_phone.Text + "\n";
            mail_message += "Message: \n" + txt_message.Text + "\n";


            // mail smtp 
            var smtp = new SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, Password);
                smtp.Timeout = 20000;
            }

            smtp.Send(from, to, mail_subject, mail_message);

            Confirm();

            confirm.Text = "Thanks for contacting us! We will get back to you shortly";

            txt_subject.Text = "";
            txt_name.Text = "";
            txt_email.Text = "";
            txt_phone.Text = "";
            txt_message.Text = "";


        }

        // error message 
        catch (Exception)
        {
            confirm.Text = "Something went wrong while sending your message. Please contact your system administrator ";
            confirm.ForeColor = Color.Red;
        }
    }

    // send confirmation mail back to client
    private void Confirm()
    {
        // pass text input to variable
        string ToEmail = txt_email.Text.Trim();
        string UserName = txt_name.Text;
        string subject2 = txt_subject.Text;

        MailMessage mailMessage = new MailMessage("godfreykowidi@gmail.com", ToEmail);



        StringBuilder sbEmailBody = new StringBuilder();
        sbEmailBody.Append("<br/><br/>");
        sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
        sbEmailBody.Append("Thank you for reaching us!<br/>");
        sbEmailBody.Append("We received you message regarding: " + subject2 + "<br/>");
        sbEmailBody.Append("We will be back to you within 2 working days. It might take a little longer on evenings and weekends but we want" +
            " you to know that we are doing our best to get back to you as soon as possible");
        sbEmailBody.Append("<br/><br/><br/>");
        sbEmailBody.Append("Sincerely, <br/>");
        sbEmailBody.Append("<b>Godfrey Owidi</b>");


        // convert the html tag
        mailMessage.IsBodyHtml = true;

        mailMessage.Body = sbEmailBody.ToString();
        mailMessage.Subject = "Re: Thank you for your email";
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "godfreykowidigmail.com",
            Password = "L@x@d0nt@"
        };


        smtpClient.EnableSsl = true;
        smtpClient.Send(mailMessage);
    }



}