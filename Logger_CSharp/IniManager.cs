using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Logger_CSharp
{
    class IniManager  //Класс чтения INI-файла
    {
      private string path { get; set; }
        public IniManager(string filePath)
        {
            path = filePath;
        }
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string iniSection, string iniKey, string def, StringBuilder buffer, int size, string path);
        public string GetParametr(string iniSection, string iniKey)
        {
            StringBuilder buffer = new StringBuilder(1000);
            GetPrivateProfileString(iniSection,iniKey,null,buffer,1000,path);
            return buffer.ToString();
        }
     
    }
}
