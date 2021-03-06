﻿/*****************************************************************************
*   Project:        经营管理系统
*
*   Developed by:   Jphotonics Technology.
*                   Hangzhou, China
*
*   Developers:     Lin Binbin, Wan Yafei   2011-06-20
*
*
*   Copyright:      (c) 2010 Jphotonics Technology. All rights reserved.
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;
using System.Net.Configuration;
using System.ComponentModel;
using System.Reflection;

namespace EmailDemo
{
    public class EmailHelper
    {
        public  delegate void SendCompleteDelegate(object sender,AsyncCompletedEventArgs args);
        public event SendCompleteDelegate OnSendCompelte;
        public static SmtpClient CreateClient()
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.ecidi.com");
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                MailSettingsSectionGroup settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");
                //smtp.Host = settings.Smtp.Network.Host;
                //smtp.Port = settings.Smtp.Network.Port;
                smtp.UseDefaultCredentials = settings.Smtp.Network.DefaultCredentials;
                smtp.Credentials = new System.Net.NetworkCredential(settings.Smtp.Network.UserName,
                                                                    settings.Smtp.Network.Password);
                smtp.EnableSsl = settings.Smtp.Network.EnableSsl;
               
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                return smtp;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                //throw;
            }
            return null;
        }

        /// <summary>
        /// 单发Email
        /// </summary>
        /// <param name="from">发信人地址</param>
        /// <param name="to">收信人地址</param>
        /// <param name="title">标题</param>
        /// <param name="body">内容</param>
        /// <returns></returns>

        public bool SendEmail(string from, string to, string title, string body)
        {

            try
            {
                //modify by lin.binbin 增加是否开放邮件发送设置
                MailMessage mMessage = new MailMessage();
                mMessage.From = new MailAddress(from);
                mMessage.To.Add(new MailAddress(to));
                mMessage.Subject = title;
                mMessage.Body = body;
                mMessage.IsBodyHtml = true;
                mMessage.BodyEncoding = Encoding.UTF8;
                SmtpClient mSmtpClient = CreateClient();
                {
                    //mSmtpClient.Send(mMessage);
                    mSmtpClient.SendCompleted += new SendCompletedEventHandler(mSmtpClient_SendCompleted);
                    mSmtpClient.SendAsync(mMessage, DateTime.Now);
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        void mSmtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if(OnSendCompelte!=null)
            {
                OnSendCompelte(sender, e);
            }
            //throw new NotImplementedException();
        }
    }
}