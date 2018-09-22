/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using Microsoft.AspNetCore.Mvc;
using ZFine.Code;

namespace ZFine.Web.Areas.ExampleManage.Controllers
{
    [Area("ExampleManage")]
    public class SendMailController : ControllerBase
    {
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        //[ValidateInput(false)]
        public ActionResult SendMail(string account, string title, string content)
        {
            MailHelper mail = new MailHelper();
            mail.MailServer = Configs.GetValue("MailHost");
            mail.MailUserName = Configs.GetValue("MailUserName");
            mail.MailPassword = Configs.GetValue("MailPassword");
            mail.MailName = "MVC快速开发平台";
            mail.Send(account, title, content);
            return Success("发送成功。");
        }
    }
}
