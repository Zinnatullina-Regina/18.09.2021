using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Lab2
    {
        enum bank
        { 
          TekSchet = 1000,
          SberSchet = 2000
        }

      public  struct Schet 
        {
          public int Number;
          public string Tip;
          public int Balance;

           public void information() {
                Console.WriteLine($"Номер = {Number} Тип = {Tip}  Баланс = {Balance}");
            
            }

        }
       public enum Vyz
        {
            КГУ = 1,
            КАИ,
            КХТИ

        }
        public struct Rabotnik
        {
            public string Name;
            public Vyz vyz;
  

            public void infoRabotnic()
            {
                Console.WriteLine($" Имя {Name} ВУЗ {vyz}");

            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");
            Console.WriteLine("\nСчета");
            bank TekSchet = bank.TekSchet ;
            bank SberSchet = bank.SberSchet;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((int)TekSchet + " Текущий счет");
            Console.WriteLine((int)SberSchet + " Сберегательный счет");


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nСчет");
            Schet znach;
            znach.Number = 123456;
            znach.Tip = "Текущий";
            znach.Balance = 2200;
            Console.WriteLine("\nОтвет:");
            znach.information();



            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\nСчет \nВведите имя");
            Rabotnik info;
            info.Name = Console.ReadLine();
            Console.WriteLine("Введите ВУЗ: КГУ (1), КАИ (2), КХТИ(3)");
            int choce = int.Parse(Console.ReadLine());
            info.vyz = (Vyz)(choce);
            Console.WriteLine("\nОтвет:");
            info.infoRabotnic();



            Console.ReadKey();

        }
    }
}
