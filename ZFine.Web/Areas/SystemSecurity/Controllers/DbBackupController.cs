/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ZFine.Application.SystemSecurity;
using ZFine.Code;
using ZFine.Domain.Entity.SystemSecurity;

namespace ZFine.Web.Areas.SystemSecurity.Controllers
{
    [Area("SystemSecurity")]
    public class DbBackupController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private DbBackupApp dbBackupApp = new DbBackupApp();
        public DbBackupController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string queryJson)
        {
            var data = dbBackupApp.GetList(queryJson);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(DbBackupEntity dbBackupEntity)
        {
            dbBackupEntity.F_FilePath = _hostingEnvironment.WebRootPath+"/Resource/DbBackup/" + dbBackupEntity.F_FileName + ".bak";
            dbBackupEntity.F_FileName = dbBackupEntity.F_FileName + ".bak";
            dbBackupApp.SubmitForm(dbBackupEntity);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            dbBackupApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        public void DownloadBackup(string keyValue)
        {
            var data = dbBackupApp.GetForm(keyValue);
            string filename = data.F_FileName;//Server.UrlDecode(data.F_FileName);
            string filepath = _hostingEnvironment+data.F_FilePath;
            //if (FileDownHelper.FileExists(filepath))
            //{
            //    FileDownHelper.DownLoadold(filepath, filename);
            //}
        }
    }
}
