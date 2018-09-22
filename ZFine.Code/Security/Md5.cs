﻿/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
namespace ZFine.Code
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class Md5
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密字符</param>
        /// <param name="code">加密位数16/32</param>
        /// <returns></returns>
        public static string md5(string str, int code)
        {
            string strEncrypt = string.Empty;
            if (code == 16)
            {
                strEncrypt = DESEncrypt.Md5Hash(str).Substring(8, 16);
            }

            if (code == 32)
            {
                strEncrypt = DESEncrypt.Md5Hash(str);
            }

            return strEncrypt;
        }
    }
}
