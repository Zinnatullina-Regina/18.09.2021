using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("\nСчастливые часов не наблюдают");
            Console.WriteLine("Введите кол-во секунд");
            int sec = Convert.ToInt32( Console.ReadLine());
            int sixty = 60;
            int Hours = (sec) / (sixty * sixty);
            int Min = (sec - (Hours * sixty * sixty)) / sixty;
            int OstatokSec = sec - ((Hours * sixty * sixty) + (Min * sixty));
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(Hours + " - полных часов прошло с начала суток");
            Console.WriteLine(Min +" - полных минут прошло с начала очередного часа");
            Console.WriteLine(OstatokSec + " - полных секунд прошло с начала очередной минуты");



            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nКвадраты");
            Console.WriteLine("Введите 1 сторонy прямоугольника в мм");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 сторонy прямоугольника в мм");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторонy квадрата в мм");
            int squareside = Convert.ToInt32(Console.ReadLine());
            while (squareside == 0) {
                Console.WriteLine("Сторона квадрата не может быть равна 0. Введите другое число");
                squareside = Convert.ToInt32(Console.ReadLine());
            }
            int squares = (side1/squareside) * (side2/squareside);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(squares + " - столько квадратов можно вырезать");

            
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\n12 месяцев");
            Console.WriteLine("Введите сколько месяцев прошло");
            int mounthlast = Convert.ToInt32(Console.ReadLine());
            int mounth = mounthlast + 1;
            while (mounthlast > 12 && mounthlast < 1) {
                Console.WriteLine("Невозможное значение. Введите другое число");
                mounthlast = Convert.ToInt32(Console.ReadLine());
            }
            if (mounthlast == 12) {
                mounth = 1;
            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(mounth);


            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("\nДвузначное число");
            Console.WriteLine("Введите двузначное число");
            int ab  = Convert.ToInt32 (Console.ReadLine());
            int a = ab / 10;
            int b = ab % 10;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(a + " - десятков");
            Console.WriteLine(b + " - единиц");
            Console.WriteLine((a + b)+ " - сумма");
            Console.WriteLine((a * b) +" - произведение");


            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("\nТрехзначное число 1");
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int newnumber = (number % 100) * 10 + number / 100;
            Console.WriteLine("Полученное трехзначное число:" + newnumber);




            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("\n237");
            int number237 = 237;
            int numberx = ((number237 % 100) * 10 + number237 / 100);
            Console.WriteLine("Полученное трехзначное число:" + numberx);



            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("\nДвузначные числа");
            Console.WriteLine("Введите 1 двузначное число");
            int a1a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 двузначное число");
            int b1b2 = Convert.ToInt32(Console.ReadLine());
            int a1b1 = ( a1a2 / 10) + (b1b2 / 10); 
            int a2b2 = (a1a2 % 10) + (b1b2 % 10);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(a1b1 + " - десятков");
            Console.WriteLine(a2b2 + " - единиц");


            

            Console.WriteLine("\nЗадание 8");
            Console.WriteLine("\nЗадание k или почему тут такое дурацкое условие");
            int k = Convert.ToInt32 (Console.ReadLine());
            double dop1 = k / 3 % 10;
            double dop2 = 1;
            double dop3 = (k+1)/30 ;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(dop1);
            Console.WriteLine(dop2);
            Console.WriteLine(dop3);
           


            Console.WriteLine("\nЗадание 9");
            Console.WriteLine("\nПравда или ложь");
            bool A, B, C, D, E, F;
            A = true;
            B = false;
            C = false;
            D = A || B;
            E = A && B;
            F = B || C;
            Console.WriteLine($"{D}, {E}, {F}");

            Console.WriteLine("\nЗадание 10");
            Console.WriteLine("\n True или false)");
            Console.WriteLine("Логическое значение X: ");
            bool X = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Логическое значение Y: ");
            bool Y = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Логическое значение Z: ");
            bool Z = Convert.ToBoolean(Console.ReadLine());

            bool a1 = !(X || Y) && (!X || !Z);
            bool b1 = !(!X && Y) || (X && !Z);
            bool c1 = X || !Y && !(X || !Z);

            Console.WriteLine($"A: { a1}");
            Console.WriteLine($"Б: { b1}"); 
            Console.WriteLine($"В: { c1}"); 





            Console.ReadKey();
        }
    }
}


