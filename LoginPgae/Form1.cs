
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
            
            LoginBtn.BackColor = Color.FromArgb(125, Color.White);







        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
