using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace kropotova_lab
{
    class Program
    {

        static void Main(string[] args)

        {
            //ExceptionTest();
            //ExceptionTest2();
            //ExceptionTest3();
        }

        static void ExceptionTest()
        {
            Console.WriteLine("Введите строку для поиска времени: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"([0][1-9]|[1][0-9]|[2][0-3]):([0-5][0-9])");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректное время");
            }


            Console.ReadKey();
        }
        static void ExceptionTest2()
        {
            Console.WriteLine("Введите строку для поиска цвета: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"#([0-9]|[A-F]){6}");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректный цвет");
            }
            Console.ReadKey();
        }
        static void ExceptionTest3()
        {
            Console.WriteLine("Введите строку для поиска операций: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"([-+]?(?:\d+(?:\.\d*)?|\.\d+)(?:[eE][-+]?\d+)?)([+]|[-]|[*][\/]?)([-+]?(?:\d+(?:\.\d*)?|\.\d+)(?:[eE][-+]?\d+)?)");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректная строка");
            }
            Console.ReadKey();
        }         
    }
}

