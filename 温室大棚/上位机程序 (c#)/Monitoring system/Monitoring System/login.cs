using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monitoring_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void liang_Click(object sender, EventArgs e)
        {
            if (user.Text == "111111" && password.Text == "aaaaaa")
            {
                MessageBox.Show("欢迎您", "提示");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误，请联系管理员", "提示");
            }
        }
    }
}
