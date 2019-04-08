using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ISTTP_Lab2
{
    public partial class SignUpForm : Form
    {
        private UsefDataEF.UsersDBEntities ctx;
        public SignUpForm()
        {
            InitializeComponent();
            PasswordTB.PasswordChar = '*';
            confirmPasswordTB.PasswordChar = '*';
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool checkData()
        {
            var query = from c in ctx.LoginInformations select c;
            bool correct = true;
            if (String.IsNullOrWhiteSpace(UsernameTB.Text))
            {
                UsernameTB.BackColor = Color.Red;
                correct = false;
            }
            if (!String.IsNullOrWhiteSpace(UsernameTB.Text) 
                && query.Where(c => c.Username == UsernameTB.Text).Count() != 0)
            {
                UsernameTB.BackColor = Color.Red;
                MessageBox.Show("Username is already in use", "Username");
                correct = false;
            }
            if (String.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                PasswordTB.BackColor = Color.Red;
                correct = false;
            }
            if (String.IsNullOrWhiteSpace(confirmPasswordTB.Text) || confirmPasswordTB.Text != PasswordTB.Text)
            {
                confirmPasswordTB.BackColor = Color.Red;
                correct = false;
            }
            if (String.IsNullOrWhiteSpace(emailTB.Text) || !IsValidEmail(emailTB.Text))
            {
                emailTB.BackColor = Color.Red;
                correct = false;
            }
            if (!String.IsNullOrWhiteSpace(emailTB.Text) 
                && IsValidEmail(emailTB.Text) 
                && query.Where(c=> c.UserEmail == emailTB.Text).Count() != 0)
            {
                emailTB.BackColor = Color.Red;
                MessageBox.Show("E-Mail is already in use", "E-Mail");
                correct = false;
            }
            return correct;
        }

        private void revertColor()
        {
            UsernameTB.BackColor = Color.White;
            PasswordTB.BackColor = Color.White;
            confirmPasswordTB.BackColor = Color.White;
            emailTB.BackColor = Color.White;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ctx = new UsefDataEF.UsersDBEntities();
                ctx.LoginInformations.Load();
                if (!checkData())
                {
                    return;
                }
                revertColor();
                byte[] salt = new HashGetter().getSalt();
                UsefDataEF.LoginInformation newUser = new UsefDataEF.LoginInformation();
                newUser.Username = UsernameTB.Text;
                newUser.UserPassword = new HashGetter().getHash(PasswordTB.Text, salt);
                newUser.UserSalt = salt;
                newUser.UserEmail = emailTB.Text;
                ctx.LoginInformations.Add(newUser);
                ctx.SaveChanges();
                MessageBox.Show("Successfully signed up!", "Success");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error signing up", "Error");
            }
        }
    }
}

