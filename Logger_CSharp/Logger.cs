using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logger_CSharp
{
    public class Logger //Класс записи в LOG-файл
    {
        public Logger() { }

        IniManager obj = new IniManager(@"C:\Users\Admin\source\repos\Logger_CSharp\Logger_CSharp\bin\Debug\net5.0\Logger.ini");

        public void WriteToLog(int a, int b, int result)
        {
            string message = $"The program was completed successfully: {a}/{b}={result}";
            object[] args = { DateTime.Now, "Program completed", Environment.UserName, message };

            for (int i = 1; i < 5; i++)
            {
                string text = obj.GetParametr("Info", i.ToString());
                Writer(text + args[i - 1]);
            }
            Writer("*****************************************");

        }
        public void WriteToLog(Exception ex)
        {      
          
                object[] args = {DateTime.Now, "Еxception", Environment.UserName, ex.Message};

                for (int i = 1; i<5; i++)
                {
                    string text = obj.GetParametr("Info",i.ToString());
                     Writer(text + args[i - 1]);                
                }
            Writer("*****************************************");
            
        }

        public void Writer(string info)
        {
            using (StreamWriter toFile = new StreamWriter(obj.GetParametr("Path", "LogFilePath"), true))
            {
                toFile.WriteLine(info);
            }

        }
    }
}
