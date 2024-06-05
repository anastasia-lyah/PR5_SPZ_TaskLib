using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR5_SPZ_TaskLib;

namespace Abonent_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonent[] arrAbonents;

            Console.Write("Введiть кiлькiсть абонентів: ");
            int cntAbonents = int.Parse(Console.ReadLine());
            arrAbonents = new Abonent[cntAbonents];

            for (int i = 0; i < cntAbonents; i++)
            {
                Console.WriteLine("Введiть номер телефону: "); string sNumber = Console.ReadLine();
                Console.WriteLine("Введiть iм'я абонента: "); string sName = Console.ReadLine();
                Console.WriteLine("Введiть тарифний план: "); string sTariff = Console.ReadLine();
                Console.WriteLine("Введiть баланс рахунку: "); string sBalance = Console.ReadLine();
                Console.Write("Введiть дату активацiї номера (рррр-мм-дд): ");
                string sActivationDate = Console.ReadLine();
                Console.Write("Чи пiдключено iнтернет ? (y - так, n - нi) : ");
                ConsoleKeyInfo keyHasInternet = Console.ReadKey(); Console.WriteLine();
                Console.Write("Чи пiдключено цифрове ТБ ? (y - так, n - нi) : ");
                ConsoleKeyInfo keyHasDigitalTV = Console.ReadKey(); Console.WriteLine();

                Console.WriteLine();

                Abonent abonent = new Abonent();

                Abonent OurAbonent = new Abonent();
                OurAbonent.Number = sNumber;
                OurAbonent.Name = sName;
                OurAbonent.Tariff = sTariff;
                OurAbonent.Balance = double.Parse(sBalance);
                OurAbonent.ActivationDate = DateTime.Parse(sActivationDate);
                OurAbonent.HasInternet = keyHasInternet.Key == ConsoleKey.Y ? true : false;
                OurAbonent.HasDigitalTV = keyHasDigitalTV.Key == ConsoleKey.Y ? true : false;                

                arrAbonents[i] = abonent;
            }

            foreach (Abonent a in arrAbonents)
            {
                Console.WriteLine();
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("\t\tДанi про абонента під номером {0}", a.Number);
                Console.WriteLine("_______________________________________________");                              
                Console.WriteLine("Iм'я: " + a.Name);
                Console.WriteLine("Тарифний план: " + a.Tariff);
                Console.WriteLine("Баланс: " + a.Balance);
                Console.WriteLine("Дата активацiї: " + a.ActivationDate);
                Console.WriteLine(a.HasInternet ? "Пiдключено iнтернет" : "Iнтернет не пiдключено");
                Console.WriteLine(a.HasDigitalTV ? "Пiдключено цифрове ТБ" : "Цифрове ТБ не пiдключено");
                Console.WriteLine($"Час iснування номера: {a.timeExistence.Days} днiв");
                Console.WriteLine();                
            }
            Console.ReadKey();
        }
    }
}
