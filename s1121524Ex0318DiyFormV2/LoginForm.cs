using System;
using System.Windows.Forms;

namespace s1121524Ex0318DiyFormV2
{
    internal class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeForm(this);
        }
        public void InitializeForm(Form myForm)
        {
            Label lblMessage = new Label();
            lblMessage.Text = "帳號:";
            lblMessage.Location = new System.Drawing.Point(50, 50);
            myForm.Controls.Add(lblMessage);
            //
            TextBox tbUsername = new TextBox();
            tbUsername.Width = 150;
            tbUsername.Location = new System.Drawing.Point(80, 50);
            myForm.Controls.Add(tbUsername);
            //
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Width = 100;
            btnOK.Location = new System.Drawing.Point(50, 100);
            myForm.Controls.Add(btnOK);
            //
            btnOK.Click += BtnOK_Click;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK被按下", "登入系統", MessageBoxButtons.YesNo);
        }
    }
}