using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] text = { "128.0.0.1", "256.0.0.1", "0.0.0.0", "255.255.255.255", "255:228:0:0" };

            //string pattern = @"(([01]?\d\d?|2[0-4]\d|25[0-5])\.){3}([01]?\d\d?|2[0-4]\d|25[0-5])";
            //Regex regex = new Regex(pattern);

            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("IP адресс: \"{0}\"", str);
            //    else
            //    {
            //        Console.WriteLine("Не является IP адрессом: \"{0}\"",str);
            //    }
            //}
            //Console.WriteLine();


            //string str = "АОУИЭЯЕЁЮ";
            //if (Regex.IsMatch(str, "[A-Za-z]")) Console.WriteLine("Ошибка! В строке содержиться латинский символ.");
            //else
            //{
            //    int count = Regex.Matches(str, @"[ауоыиэяюёе]", RegexOptions.IgnoreCase).Count;

            //    Console.WriteLine(str);
            //    Console.WriteLine("Кол-во гласных букв: {0}", count);
            //}


            //string[] text = { "https://www.youtube.com", "htps://www.youtube.com" };

            //string pattern = @"^(https?:\/\/|ftps?:\/\/|www\.)((?![.,?!;:()]*(\s|$))[^\s]){2,}";
            //Regex regex = new Regex(pattern);

            //foreach (string str in text)
            //{
            //    
            //    if (regex.IsMatch(str))
            //    {
            //        Console.WriteLine("Является буквенно-цифровым значениям: \"{0}\"", str);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не верный UPL-адресс: \"{0}\"", str);
            //    }
            //}
            //Console.WriteLine();


            //string[] text = { "АZ01" };

            //string pattern = @"^[a-zA-Z0-9]*";
            //Regex regex = new Regex(pattern);

            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //    {
            //        Console.WriteLine("Является буквенно-цифровым значениям: \"{0}\"", str);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не является буквенно-цифровым значениям: \"{0}\"", str);
            //    }
            //}
            //Console.WriteLine();


            
            string[] text = { "00:00","59.25" };

            string pattern = @"^(([01][0-9])|([2][0-3]))(:|\.)[0-5][0-9]((:|\.)[0-5][0-9])?$";
            Regex regex = new Regex(pattern);


            foreach (string str in text)
            {
                if (regex.IsMatch(str))
                {
                    Console.WriteLine("Является временем: \"{0}\"", str);
                }
                else
                {
                    Console.WriteLine("Не является временем: \"{0}\"", str);
                }
            }


        }
    }
}
