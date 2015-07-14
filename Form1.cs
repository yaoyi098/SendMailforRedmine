using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace SendMail
{
    public partial class Form1 : Form
    {

        string strHost;
        string strDes;
        string strUsername;
        string strPassword;
        
        public Form1()
        {
            ReadConfig rcon = new ReadConfig();

            
            //rcon.Read(out strHost, out strDes, out strUsername, out strPassword);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input something!");
                return;
            }



            MailMessage mm = new MailMessage();
            mm.From = new System.Net.Mail.MailAddress("yaoyimeng@chinadaily.com.cn");
            mm.To.Add("project@chinadaily.com.cn");


            mm.Subject = textBox1.Text;
            string mmBody;
            mmBody = textBox2.Text + "\r\n";

            mmBody += "project: everyday-schedule\r\n";
            mmBody += "跟踪: 技术服务\r\n";
            mmBody += "指派给: yaoyimeng\r\n";

            string sdate = DateTime.Now.ToShortDateString();
            sdate = sdate.Replace("/", "-");
            // mmBody += "开始日期: " + sdate + "\r\n";
            // mmBody += "问题类别: 个人计算机一般问题类\r\n";

            mmBody += "%完成: 100\r\n";

            mm.Body = mmBody;

            SmtpClient sc = new SmtpClient("mail.chinadaily.com.cn", 25);
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;

            sc.Credentials = new NetworkCredential("yaoyimeng@chinadaily.com.cn", "*****");
            try
            {
            	sc.Send(mm);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());	
            }

            MessageBox.Show(mmBody + textBox1.Text + "\r\nok");
            textBox1.Clear();
            textBox2.Clear();
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // check config file.

            //show the login dialog
            login form_login = new login();
            if (form_login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            //finish

        }
    }


    #region ReadConfig class

    public class ReadConfig
    {
        protected string strFile;
        protected string strdir;

        /// <summary>
        ///  exam the LocalApplication/SendMail/config.xml exist.
        ///  if not, create it.
        /// </summary>
        /// <returns></returns>

        public void examConfigfile()
        {
            if ( !Directory.Exists(strdir) )
            {
                Directory.CreateDirectory(strdir);
            }

            



        }

        public ReadConfig()
        {
            strdir = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SendMail\";
            strFile = strdir + "config.ini";

           // Console.WriteLine(strFile);
            //strFile = ""
        }

        protected bool Read(out string sHost, out string sDes, out string sUser, out string sPass)
        {
            sHost = "";
            sDes = "";
            sUser = "";
            sPass = "";

            try
            {
	            if (!File.Exists(strFile))
	            {
                    File.Create(strFile);
                    
                    Exception e = new Exception("The config file does not exist!");
                    throw e;
	            }




            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);


                return false;
            }


            return true;
        }
    }

    #endregion ReadConfig class
}
