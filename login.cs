using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SendMail
{
    public partial class login : Form
    {
        public login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /// <summary>
        /// Check the User and PW format.
        /// </summary>
        /// <returns></returns>
        protected bool CheckUserPW()
        {
            try
            {
	            if (text_user.Text == "" | text_pw.Text == "")
	            {
                    throw new Exception("Incorrect Username or Password!");
	            }
	            string struser = text_user.Text;
	            int i = struser.IndexOf('@');
	            if (i < 0)
	            {
	                text_user.Text = struser + "@chinadaily.com.cn";
	            }
	            else if (i == 0)
	            {
	                throw new Exception();
	            }
                else
                {
                    string sub = struser.Substring(i);
                    if (sub != "@chinadaily.com.cn")
                    {
                        struser = struser.Remove(i);
                        struser = struser + "@chinadaily.com.cn";
                        text_user.Text = struser;
                        return false;
                    }
                    return true;
                }

                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Incorrect Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 测试用户名密码是否正确
        /// </summary>
        /// <returns>1正确 0错误</returns>
        protected bool CheckConnect()
        {
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckUserPW())
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void text_server_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Do you want to change the mail server address?", "Change Server", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dR == DialogResult.OK)
            {
                text_server.ReadOnly = false;
                text_port.ReadOnly = false;
            }
            return;
        }

        private void text_port_DoubleClick(object sender, EventArgs e)
        {
            text_server_DoubleClick(sender, e);
        }
    }
}
