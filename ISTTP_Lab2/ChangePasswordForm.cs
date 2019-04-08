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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            oldPasswordTB.PasswordChar = '*';
            PasswordTB.PasswordChar = '*';
            confirmPasswordTB.PasswordChar = '*';
        }
        private UsefDataEF.UsersDBEntities ctx = new UsefDataEF.UsersDBEntities();
        private bool checkData()
        {
            bool correct = true;
            if (String.IsNullOrWhiteSpace(UsernameTB.Text))
            {
                UsernameTB.BackColor = Color.Red;
                correct = false;
            }
            if (String.IsNullOrWhiteSpace(oldPasswordTB.Text))
            {
                oldPasswordTB.BackColor = Color.Red;
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
            return correct;
        }

        private void revertColor()
        {
            UsernameTB.BackColor = Color.White;
            PasswordTB.BackColor = Color.White;
            confirmPasswordTB.BackColor = Color.White;
            oldPasswordTB.BackColor = Color.White;
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                return;
            }
            revertColor();
            var query = from c in ctx.LoginInformations select c;
            byte[] salt = query.Where(c => c.Username == UsernameTB.Text).First().UserSalt;
            byte[] hashedPassword = new HashGetter().getHash(oldPasswordTB.Text, salt);
            var user = (from c in query where c.Username == UsernameTB.Text select c into z where z.UserPassword == hashedPassword select z);
            if (user.Any())
            {
                byte[] newSalt = new HashGetter().getSalt();
                byte[] newHashedPassword = new HashGetter().getHash(PasswordTB.Text, newSalt);
                user.First().UserSalt = newSalt;
                user.First().UserPassword = newHashedPassword;
                ctx.SaveChanges();
                MessageBox.Show("Password changed", "Success");
                Close();
            }
        }
    }
}
