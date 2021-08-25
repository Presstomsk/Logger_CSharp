using System;

namespace Logger_CSharp
{
    class Program //Отработка на делении чисел типа int
    {
        static void Main()
        {
           Logger log = new Logger();
            try
            {
                Console.WriteLine("ДЕЛЕНИЕ ДВУХ ЧИСЕЛ");
                Console.Write("Введите число а:");
                string a = Console.ReadLine();
                int c = Convert.ToInt32(a);
                Console.Write("Введите число b:");
                string b = Console.ReadLine();           
                int d = Convert.ToInt32(b);
                int e = c / d;
                Console.WriteLine($"Результат деления равен:{e}");
                log.WriteToLog(c,d,e);
            }
               catch (Exception ex)
                {
                    log.WriteToLog(ex);
                }
            }
        
        }
    }

