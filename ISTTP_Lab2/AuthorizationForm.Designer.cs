namespace ISTTP_Lab2
{
    partial class AuthorizationForm
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
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.singUpBtn = new System.Windows.Forms.Button();
            this.forgotPasswordBtn = new System.Windows.Forms.Button();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(61, 87);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(337, 31);
            this.LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(61, 191);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(337, 31);
            this.PasswordTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(61, 251);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(161, 66);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // singUpBtn
            // 
            this.singUpBtn.Location = new System.Drawing.Point(237, 251);
            this.singUpBtn.Name = "singUpBtn";
            this.singUpBtn.Size = new System.Drawing.Size(161, 66);
            this.singUpBtn.TabIndex = 5;
            this.singUpBtn.Text = "Sign Up";
            this.singUpBtn.UseVisualStyleBackColor = true;
            this.singUpBtn.Click += new System.EventHandler(this.singUpBtn_Click);
            // 
            // forgotPasswordBtn
            // 
            this.forgotPasswordBtn.Location = new System.Drawing.Point(61, 338);
            this.forgotPasswordBtn.Name = "forgotPasswordBtn";
            this.forgotPasswordBtn.Size = new System.Drawing.Size(337, 57);
            this.forgotPasswordBtn.TabIndex = 6;
            this.forgotPasswordBtn.Text = "Forgot Password";
            this.forgotPasswordBtn.UseVisualStyleBackColor = true;
            this.forgotPasswordBtn.Click += new System.EventHandler(this.forgotPasswordBtn_Click);
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(61, 419);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(337, 57);
            this.changePassBtn.TabIndex = 7;
            this.changePassBtn.Text = "Change Password";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 513);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.forgotPasswordBtn);
            this.Controls.Add(this.singUpBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button singUpBtn;
        private System.Windows.Forms.Button forgotPasswordBtn;
        private System.Windows.Forms.Button changePassBtn;
    }
}