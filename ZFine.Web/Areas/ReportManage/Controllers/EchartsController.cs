/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/

using Microsoft.AspNetCore.Mvc;

namespace ZFine.Web.Areas.ReportManage.Controllers
{
    [Area("ReportManage")]
    public class EchartsController : Controller
    {
        //
        // GET: /ReportManage/Echarts/

        public ActionResult Index()
        {
            return View();
        }

    }
}
