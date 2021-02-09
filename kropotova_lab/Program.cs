using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kropotova_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // команда Console.Write выводит текст в консоль
            //Console.Write("Input katet1: ");
            /* Нахождениме площади прямоугольного треугольника
            // команда Console.ReadLine читает СТРОКУ из консоли
            var Katet1 = Console.ReadLine();

            Console.Write("Input katet2: ");
            var Katet2 = Console.ReadLine();

            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            var Gipotenuza = Math.Sqrt(Math.Pow(Convert.ToDouble(Katet1), 2) + Math.Pow(Convert.ToDouble(Katet2), 2));

            // выводим результат
            // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
            // Console.WriteLine($"Gipotenuza = {Gipotenuza}");

            var Perimetr = Gipotenuza + Convert.ToDouble(Katet1) + Convert.ToDouble(Katet2);
            var Square = Convert.ToDouble(Katet1) * Convert.ToDouble(Katet2) / 2;


            
            */

            /**/
            // команда Console.Write выводит текст в консоль
            Console.Write("Input R: ");
            var R = Console.ReadLine();
            
            //Console.Write("Input P: ");
            //var P = Console.ReadLine();

            //Math.PI = 3.14;
            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            // var C = 2 * PI* R
            var Square = Math.PI* Math.Pow(Convert.ToDouble(R), 2);

            Console.WriteLine($"Square = {Square}");

            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}
