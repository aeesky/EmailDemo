using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EmailDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SmtpClient smtp = new SmtpClient("smtp.ecidi.com",25);
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            MailSettingsSectionGroup settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");
            smtp.Host = settings.Smtp.Network.Host;
            smtp.Port = settings.Smtp.Network.Port;
            smtp.Credentials = new System.Net.NetworkCredential(settings.Smtp.Network.UserName,
                                                                settings.Smtp.Network.Password);
            smtp.EnableSsl = settings.Smtp.Network.EnableSsl;
            smtp.UseDefaultCredentials = settings.Smtp.Network.DefaultCredentials;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            textBox_Body.Text =settings.Smtp.Network.UserName +settings.Smtp.Network.Password+settings.Smtp.Network.Host;

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            WhcEmail mail = new WhcEmail();
            mail.MailTest();
            //EmailHelper email = new EmailHelper();
            //email.OnSendCompelte += new EmailHelper.SendCompleteDelegate(email_OnSendCompelte);
            //email.SendEmail(textBox_from.Text, textBox_To.Text, textBox_Title.Text,
            //                textBox_Body.Text + "\n" + DateTime.Now.ToLongTimeString());
        }

        void email_OnSendCompelte(object sender, AsyncCompletedEventArgs args)
        {
            if(args.Cancelled || args.Error!=null)
                MessageBox.Show("发送失败！");
            else
            {
                MessageBox.Show("发送成功！");
            }
            //throw new NotImplementedException();
        }
    }
}
