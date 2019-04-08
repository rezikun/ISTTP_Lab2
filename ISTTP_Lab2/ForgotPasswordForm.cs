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
using System.Net;

namespace ISTTP_Lab2
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void emailPassword(string email, string username, string password)
        {
            var fromAddress = new MailAddress("isttplab@gmail.com");
            var fromPassword = "isttppassword";
            var toAddress = new MailAddress(email);

            var subject = "No Reply. Restore Password.";
            var body = String.Format("Here is your username and the new password:\n{0}\n{1}", username, password);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            try
            {
                smtp.Send(message);
                MessageBox.Show("Sent your new password", "Sent");
            }
            catch (Exception ex)
            {
                //Error, could not send the message
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(emailTB.Text))
            {
                emailTB.BackColor = Color.Red;
                return;
            }
            UsefDataEF.UsersDBEntities ctx = new UsefDataEF.UsersDBEntities();
            var query = from c in ctx.LoginInformations where c.UserEmail == emailTB.Text select c;
            if (query.Any())
            {
                string username = query.First().Username;
                string password = CreatePassword(12);
                byte[] salt = new HashGetter().getSalt();
                byte[] hashedPassword = new HashGetter().getHash(password, salt);
                query.First().UserSalt = salt;
                query.First().UserPassword = hashedPassword;
                ctx.SaveChanges();
                emailPassword(query.First().UserEmail, query.First().Username, password);
            }
            else
            {
                MessageBox.Show("No such E-mail address", "Error");
            }
        }
    }
}
