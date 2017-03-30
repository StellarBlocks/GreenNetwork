using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GNet1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("确定退出吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               this.Close();
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (UserStuff.CheckAcount(txtUserName.Text, txtUserKey.Text))
            {
                lblAnswer.Text = "欢迎,亲爱的" + txtUserName.Text;
                txtUserName.Text = "";
                txtUserKey.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocClient Form1 = new SocClient();
            Form1.Show();
            SocServer Form2 = new SocServer();
            Form2.Show();
        }
    }
}
