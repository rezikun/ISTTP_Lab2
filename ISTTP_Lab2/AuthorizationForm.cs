using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTTP_Lab2
{
    
    public partial class AuthorizationForm : Form
    {
        public bool success = false;
        public AuthorizationForm()
        {
            InitializeComponent();
            PasswordTB.PasswordChar = '*';
        }

        private void singUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LoginTB.Text) || String.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                MessageBox.Show("Username and password are mandatory", "Invalid Data");
                return;
            }
            UsefDataEF.UsersDBEntities ctx = new UsefDataEF.UsersDBEntities();
            var query = from c in ctx.LoginInformations where c.Username == LoginTB.Text select c;
            if (query.Count() == 0)
            {
                MessageBox.Show("No such user", "No user");
                return;
            }
            byte[] salt = query.First().UserSalt;
            byte[] hashedPass = new HashGetter().getHash(PasswordTB.Text, salt);
            if (query.Where(c=>c.UserPassword == hashedPass).Count() > 0)
            {
                success = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error");
            }
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            forgotPassword.ShowDialog();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.ShowDialog();
        }
    }
}
