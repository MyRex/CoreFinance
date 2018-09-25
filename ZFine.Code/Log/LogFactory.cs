/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using log4net;
using log4net.Repository;
using System;
using System.IO;
using System.Web;

namespace ZFine.Code
{
    public class LogFactory
    {
        static LogFactory()
        {
            FileInfo configFile = new FileInfo(FileHelper.MapPath()+"/Configs/log4net.config");
            string repositoryName = "";
            log4net.Config.XmlConfigurator.Configure(LogManager.GetRepository(repositoryName),configFile);
        }
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
        public static Log GetLogger(string str)
        {
            return new Log(LogManager.GetLogger("s:",str));
        }
    }
}
