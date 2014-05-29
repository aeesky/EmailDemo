using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHC.OrderWater.Commons;
using System.Web;
namespace EmailDemo
{
    public class WhcEmail
    {
       public WhcEmail()
       {
       }
        public void MailTest()
       {
           WHC.OrderWater.Commons.EmailHelper email = new WHC.OrderWater.Commons.EmailHelper("smtp.domain.com", "user@user.com", "passowrd");
           email.Subject = "普通测试邮件";
           email.Body = string.Format("测试邮件正文内容");
           email.IsHtml = false;
           email.From = "from@domain.com";
           email.FromName = "邮件提醒";
           email.AddRecipient("user2@domain.com");
           try
           {
               bool success = email.SendEmail();
               MessageUtil.ShowTips(success ? "发送成功" : "发送失败");
           }
           catch (Exception ex)
           {
               MessageUtil.ShowError(ex.Message);
           } 
        }

    }
}
