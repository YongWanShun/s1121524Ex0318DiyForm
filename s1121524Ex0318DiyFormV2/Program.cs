using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace s1121524Ex0318DiyFormV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new LoginForm();
            myForm.Size = new System.Drawing.Size(320, 240);
            myForm.Text = "DIY Form V2";
            //
            System.Windows.Forms.Application.Run(myForm);
        }
    }
}
