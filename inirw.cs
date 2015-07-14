using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SendMail
{
    class iniOP
    {
        
        #region api
        [DllImport("kernel32")]//返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key,
            string val, string filePath);

        [DllImport("kernel32")]//返回取得字符串缓冲区的长度
        private static extern int GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);
        
        #endregion



        public static int ReadIni(string section, string key, string defValue, string filepath)
        {
            StringBuilder retValue = new StringBuilder();
            return GetPrivateProfileString(section, key, defValue, retValue, 256, filepath);

        }

        public static long WriteIni(string section, string key, string value, string filepath)
        {
            return WritePrivateProfileString(section, key, value, filepath);
        }

        public static long DeleteSection(string section, string filepath)
        {
            return WritePrivateProfileString(section, null, null, filepath);
        }

        public static long DeleteKey(string section, string key, string filepath)
        {
            return WritePrivateProfileString(section, key, null, filepath);
        }
    }
}
