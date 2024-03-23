using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1121524Ex0318DiyFormV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form();
            myForm.Size = new System.Drawing.Size(320, 240);
            myForm.Text = "DIY Form V1";
            //
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
            //
            System.Windows.Forms.Application.Run(myForm);
        }

        private static void BtnOK_Click(object sender, EventArgs e)
        {
            Console.WriteLine("OK Click!");
        }
    }
}
