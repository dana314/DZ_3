//1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году),
// переводит этот число в месяц и день месяца (високосный год не учитывать). 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня в году от 1 до 365: ");
        int dayInYear = Convert.ToInt32(Console.ReadLine());



        int[] daysMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] months = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
        int month = 0;
        int day = dayInYear;
        while (month < 12 && day > daysMonth[month])
        {
            day -= daysMonth[month];
            month++;
        }
        Console.WriteLine($"День {dayInYear} это {day} {months[month]}.");


        //2 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году),
        // переводит этот число в месяц и день месяца (високосный год не учитывать). с проверкой

        Console.WriteLine("Введите номер дня в году от 1 до 365: ");
        int DayInYear = Convert.ToInt32(Console.ReadLine());
        if (DayInYear < 1 || DayInYear > 365)
        {
            Console.WriteLine("введенное число должно быть от 1 до 365");
            return;
        }

        int[] DaysMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] Months = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
        int Month = 0;
        int Day = DayInYear;
        while (Month < 12 && Day > DaysMonth[Month])
        {
            Day -= DaysMonth[Month];
            Month++;
        }
        Console.WriteLine($"День {DayInYear} это {Day} {Months[Month]}.");


        //3 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год(високосный или нет). Год вводится с экрана.
        Console.WriteLine("Введите номер дня в году от 1 до 365: ");
        int DAYInYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год: ");
        int Year = Convert.ToInt32(Console.ReadLine());

        bool leapYear = (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);

        if (DAYInYear < 1 || DAYInYear > 365)
        {
            Console.WriteLine("Введенный номер дня в году должен быть от 1 до 365");
            return;
        }

        int[] DAYsInMonth;
        if (leapYear)
        {
            DAYsInMonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }
        else
        {
            DAYsInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }

        string[] monthS = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };

        int montH = 0;
        int DAY = dayInYear;


        while (montH < 12 && DAY > DAYsInMonth[montH])
        {
            DAY -= DAYsInMonth[month];
            montH++;
        }


        Console.WriteLine($"День {DAYInYear} {Year} года это {DAY} {monthS[montH]}.");
    }
}
