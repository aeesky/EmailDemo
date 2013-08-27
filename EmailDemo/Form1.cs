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
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            EmailHelper email = new EmailHelper();
            email.OnSendCompelte += new EmailHelper.SendCompleteDelegate(email_OnSendCompelte);
            email.SendEmail(textBox_from.Text, textBox_To.Text, textBox_Title.Text,
                            textBox_Body.Text + "\n" + DateTime.Now.ToLongTimeString());
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
