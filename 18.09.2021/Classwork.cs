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
            Console.WriteLine("Min and Max");
            string sbyt = "sbyte", byt = "byte", shor = "short", ushor = "ushort", it = "int", uin = "uint", lon = "long", ulon = "ulong", floa = "float", doubl = "double", decima = "decimal";
            Console.WriteLine(sbyt + $"[{sbyte.MinValue}, {sbyte.MaxValue}]");
            Console.WriteLine(byt + $"[{byte.MinValue}, {byte.MaxValue}]");
            Console.WriteLine(shor + $"[{short.MinValue}, {short.MaxValue}]");
            Console.WriteLine(ushor + $"[{ushort.MinValue}, {ushort.MaxValue}]");
            Console.WriteLine(it + $"[{int.MinValue}, {int.MaxValue}]");
            Console.WriteLine(uin + $"[{uint.MinValue}, {uint.MaxValue}]");
            Console.WriteLine(lon + $"[{long.MinValue}, {long.MaxValue}]");
            Console.WriteLine(ulon + $"[{ulong.MinValue}, {ulong.MaxValue}]");
            Console.WriteLine(floa + $"[{float.MinValue}, {float.MaxValue}]");
            Console.WriteLine(doubl + $"[{double.MinValue}, {double.MaxValue}]");
            Console.WriteLine(decima + $"[{decimal.MinValue}, {decimal.MaxValue}]");
           



            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Большой брат следит за тобой");
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите PIN-код");
            string pinkod = Console.ReadLine();
            Console.WriteLine("\nОтвет:");
            Console.WriteLine($"{name}, город: {city}, возраст: {age} лет, PIN-код: {pinkod}");






            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Строчные буквы – в заглавные, заглавные – в строчные");
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine(), result = "";
            foreach (var c in stroka) { 
                if (char.IsUpper(c)) { 
                    result += char.ToLower(c);
                }
                else { 
                    result += char.ToUpper(c);
                }
            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(result);




            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Совпадение - падение сов)");
            Console.WriteLine("Введите первую строку");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string s2 = Console.ReadLine();
            int i = 0, x = -1, count = -1;  
            while (i != -1)
            {
                i = s1.IndexOf(s2, x + 1); 
                x = i;
                count++; 
            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(count);



            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Таракан или обычный день математиков в ДУ");
            Console.WriteLine("Введите скорость в км/ч");
            double km = Convert.ToDouble(Console.ReadLine());
            int tenthousands = 100000, treethousandsixhundred = 3600;
            double cm = km * tenthousands / treethousandsixhundred;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((int)(cm) + " - скорость в см/сек");


            
            
            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Отцы и дети");
            Console.WriteLine("Введите возраст отца");
            int father = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Введите возраст сына");
            int sun = Convert.ToInt32(Console.ReadLine());
            int ageplus = 0, agemin = 0, father1 = father, father2 = father, sun1 = sun, sun2 = sun;
            Console.WriteLine("\nОтвет:");
            while (father1 != (sun1 * 2) )
            {
                father1++;
                sun1++;
                ageplus++;
                if (sun2 +10 <= ageplus)
                {
                    ageplus = tenthousands;
                    break;
                }
            }
            while (father2 != (sun2 * 2) )
            {
                father2--;
                sun2--;
                agemin++;
                if (sun2 <= 0) {
                    agemin = tenthousands;
                    break;
                }
            }
            if (agemin <= ageplus) {

                if (agemin == 1) {
                    Console.WriteLine("Год назад ");
                }
                if (1 < agemin && agemin < 5)
                {
                    Console.WriteLine($"{agemin} года назад ");
                }
                if ( agemin >= 5)
                {
                    Console.WriteLine($"{agemin} лет назад ");
                }
            }
            if (agemin > ageplus)
            {
                if (ageplus == 1)
                {
                    Console.WriteLine("Через год "); 
                }
                if (1 < ageplus && ageplus < 5)
                {
                    Console.WriteLine($"Через {ageplus} года ");
                }
                if (ageplus >= 5)
                {
                    Console.WriteLine($"Через {ageplus} лет ");
                }
            }
            
            

            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("Э-экономия");
            Console.WriteLine("Введите стандартную цену");
            double normPrice  = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Введите скидкy");
            double sale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            if (sale != 0)
            {
                double number = holidayPrice / ((sale / 100) * normPrice);
                Console.WriteLine((int)(number) + " - бутылок");
            }
            else {

                Console.WriteLine("Смысла нет. Не окупится. Просто наслаждайтесь отдыхом.");
            }



            Console.ReadKey();
        }
    }
}

