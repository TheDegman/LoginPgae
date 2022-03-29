
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginPgae
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            LoginPanel.BackColor= Color.FromArgb(125,Color.Black);
            SignUp.BackColor = Color.FromArgb(125, Color.Black);

            LoginBtn.BackColor = Color.FromArgb(125, Color.White);







        }
       





        private void Link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.BringToFront();
            

        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp.BringToFront();
        }
    }
}
