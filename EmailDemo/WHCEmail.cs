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
           WHC.OrderWater.Commons.EmailHelper email = new WHC.OrderWater.Commons.EmailHelper("smtp.ecidi.com", "ec_hdaq@ecidi.com", "hdaq895623LINBB");
           email.Subject = "普通测试邮件";
           email.Body = string.Format("测试邮件正文内容");
           email.IsHtml = false;
           email.From = "ec_hdaq@ecidi.com";
           email.FromName = "经营生产管理系统邮件提醒";
           email.AddRecipient("lin_bb@ecidi.com");
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
