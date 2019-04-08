namespace ISTTP_Lab2
{
    partial class ChangePasswordForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.oldPasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Confirm Password";
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.Location = new System.Drawing.Point(85, 428);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.Size = new System.Drawing.Size(337, 31);
            this.confirmPasswordTB.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(85, 314);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(337, 31);
            this.PasswordTB.TabIndex = 20;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(76, 81);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(337, 31);
            this.UsernameTB.TabIndex = 19;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Location = new System.Drawing.Point(136, 478);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(222, 69);
            this.changePasswordBtn.TabIndex = 25;
            this.changePasswordBtn.Text = "Change";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Old Password";
            // 
            // oldPasswordTB
            // 
            this.oldPasswordTB.Location = new System.Drawing.Point(85, 201);
            this.oldPasswordTB.Name = "oldPasswordTB";
            this.oldPasswordTB.Size = new System.Drawing.Size(337, 31);
            this.oldPasswordTB.TabIndex = 26;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldPasswordTB);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPasswordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldPasswordTB;
    }
}