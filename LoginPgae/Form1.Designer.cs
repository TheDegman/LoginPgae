
namespace LoginPgae
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Link1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.LoginUsername = new LoginPgae.Controls.TextBox();
            this.LoginPassword = new LoginPgae.Controls.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Panel();
            this.textBox3 = new LoginPgae.Controls.TextBox();
            this.Link2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new LoginPgae.Controls.TextBox();
            this.textBox2 = new LoginPgae.Controls.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.LoginPanel.Controls.Add(this.Link1);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.RememberMe);
            this.LoginPanel.Controls.Add(this.LoginUsername);
            this.LoginPanel.Controls.Add(this.LoginPassword);
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Location = new System.Drawing.Point(332, 126);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(312, 308);
            this.LoginPanel.TabIndex = 0;
            // 
            // Link1
            // 
            this.Link1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.Link1.AutoSize = true;
            this.Link1.ForeColor = System.Drawing.Color.White;
            this.Link1.LinkColor = System.Drawing.Color.White;
            this.Link1.Location = new System.Drawing.Point(126, 260);
            this.Link1.Name = "Link1";
            this.Link1.Size = new System.Drawing.Size(69, 15);
            this.Link1.TabIndex = 10;
            this.Link1.TabStop = true;
            this.Link1.Text = "Register Me";
            this.Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.BackColor = System.Drawing.Color.Transparent;
            this.RememberMe.ForeColor = System.Drawing.Color.White;
            this.RememberMe.Location = new System.Drawing.Point(106, 173);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(104, 19);
            this.RememberMe.TabIndex = 9;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = false;
            // 
            // LoginUsername
            // 
            this.LoginUsername.BackColor = System.Drawing.Color.White;
            this.LoginUsername.BorderColor = System.Drawing.Color.Navy;
            this.LoginUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LoginUsername.BorderSize = 4;
            this.LoginUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginUsername.Location = new System.Drawing.Point(43, 82);
            this.LoginUsername.Margin = new System.Windows.Forms.Padding(4);
            this.LoginUsername.Multiline = false;
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Padding = new System.Windows.Forms.Padding(7);
            this.LoginUsername.PasswordChar = false;
            this.LoginUsername.Size = new System.Drawing.Size(227, 32);
            this.LoginUsername.TabIndex = 1;
            this.LoginUsername.Texts = "Username";
            this.LoginUsername.UnderlinedStyle = true;
            // 
            // LoginPassword
            // 
            this.LoginPassword.BackColor = System.Drawing.Color.White;
            this.LoginPassword.BorderColor = System.Drawing.Color.Navy;
            this.LoginPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LoginPassword.BorderSize = 4;
            this.LoginPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginPassword.Location = new System.Drawing.Point(43, 125);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPassword.Multiline = false;
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Padding = new System.Windows.Forms.Padding(7);
            this.LoginPassword.PasswordChar = false;
            this.LoginPassword.Size = new System.Drawing.Size(227, 32);
            this.LoginPassword.TabIndex = 8;
            this.LoginPassword.Texts = "Password";
            this.LoginPassword.UnderlinedStyle = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(58, 207);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(202, 32);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.SignUp.Controls.Add(this.textBox3);
            this.SignUp.Controls.Add(this.Link2);
            this.SignUp.Controls.Add(this.label2);
            this.SignUp.Controls.Add(this.textBox1);
            this.SignUp.Controls.Add(this.textBox2);
            this.SignUp.Controls.Add(this.button1);
            this.SignUp.Location = new System.Drawing.Point(332, 126);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(312, 308);
            this.SignUp.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderColor = System.Drawing.Color.Navy;
            this.textBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox3.BorderSize = 4;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(43, 165);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.Padding = new System.Windows.Forms.Padding(7);
            this.textBox3.PasswordChar = false;
            this.textBox3.Size = new System.Drawing.Size(227, 32);
            this.textBox3.TabIndex = 11;
            this.textBox3.Texts = "Password";
            this.textBox3.UnderlinedStyle = true;
            // 
            // Link2
            // 
            this.Link2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.Link2.AutoSize = true;
            this.Link2.ForeColor = System.Drawing.Color.White;
            this.Link2.LinkColor = System.Drawing.Color.White;
            this.Link2.Location = new System.Drawing.Point(134, 262);
            this.Link2.Name = "Link2";
            this.Link2.Size = new System.Drawing.Size(43, 15);
            this.Link2.TabIndex = 10;
            this.Link2.TabStop = true;
            this.Link2.Text = "Sign In";
            this.Link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign Up";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.Navy;
            this.textBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox1.BorderSize = 4;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(43, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox1.PasswordChar = false;
            this.textBox1.Size = new System.Drawing.Size(227, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Texts = "Username";
            this.textBox1.UnderlinedStyle = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderColor = System.Drawing.Color.Navy;
            this.textBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox2.BorderSize = 4;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(43, 125);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(7);
            this.textBox2.PasswordChar = false;
            this.textBox2.Size = new System.Drawing.Size(227, 32);
            this.textBox2.TabIndex = 8;
            this.textBox2.Texts = "Password";
            this.textBox2.UnderlinedStyle = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(56, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 556);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.SignUp);
            this.Name = "Login";
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.SignUp.ResumeLayout(false);
            this.SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button LoginBtn;
        private Controls.TextBox LoginUsername;
        private Controls.TextBox LoginPassword;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Link1;
        private System.Windows.Forms.Panel SignUp;
        private System.Windows.Forms.LinkLabel Link2;
        private System.Windows.Forms.Label label2;
        private Controls.TextBox textBox1;
        private Controls.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private Controls.TextBox textBox3;
    }
}

