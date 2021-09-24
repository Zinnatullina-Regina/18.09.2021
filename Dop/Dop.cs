using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Отдай мое сердце");
            Console.WriteLine("Введите кол-во лепестков у Тимми");
            int FirstHeart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во лепестков у Сары");
            double SecondHeart = Convert.ToDouble(Console.ReadLine());
            bool love;
            Console.WriteLine("\nОтвет:");
            if ((FirstHeart % 2 == 1 && SecondHeart % 2 == 0 ) ^ (FirstHeart % 2 == 0 && SecondHeart % 2 == 1))
            {
                love = true;
                Console.WriteLine("Вы влюбленны!!! Цветы не врут");
            }
            else{
                love = false;
                Console.WriteLine("Вы влюбленны!!! Кому есть дело до этих дурацких цветов?");
            }





            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Избегайте обезвоживания");
            Console.WriteLine("Введите время в часах ");
            double Time = Convert.ToDouble(Console.ReadLine());
            double litrov = 0.5 * Time;
            Console.WriteLine("\nОтвет:");
            if ((int)(litrov) == 1)
            {
                Console.WriteLine( "1 литр");
            }
            if (1 < (int)(litrov) && (int)(litrov) < 5)
            {
                Console.WriteLine((int)(litrov) + " литра");
            }
            if ((int)(litrov) >= 5)
            {
                Console.WriteLine((int)(litrov) + " литров");
            }
           





                Console.ReadKey();
        }
    }
}

