// 1 Дана последовательность из 10 чисел. Определить, является ли эта последовательность
// упорядоченной по возрастанию. В случае отрицательного ответа определить
// порядковый номер первого числа, которое нарушает данную последовательность.
using System;

namespace Digits
{
    class Program
    {
        
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            //  1: проверка на последовательности
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите число {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool sorted = true;
            int index = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    sorted = false;
                    index = i;
                    break;
                }
            }

            if (sorted)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена, элемент под индексом {index} нарушает последовательность.");
            }

            // 2 Определить достоинства карты
            try
            {
                Console.WriteLine("Введите номер игральной карты (от 6 до 14): ");
                int n = int.Parse(Console.ReadLine());

                if (n < 6 || n > 14)
                {
                    throw new ArgumentOutOfRangeException("номер карты должен быть от 6 до 14");
                }

                string cardName = CardValue(n);
                Console.WriteLine($"Значение карты: {cardName}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Спасибо!");
            }

            // 3 работа с таблицей
            Console.WriteLine("Введите строку: ");
            string j = Console.ReadLine().Trim();
            switch (j.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school consuelor":
                    Console.WriteLine("Anything with alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike bang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Crystal");
                    break;
                default:
                    Console.WriteLine("Anything else");
                    break;
            }

            //  4 Определить день недели по порядковому номеру
            Console.WriteLine("Введите порядковый номер дня недели от 1 до 7: ");
            int dayNumber;
            if (int.TryParse(Console.ReadLine(), out dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                DayOfWeek day = (DayOfWeek)dayNumber;
                Console.WriteLine($"День недели: {day}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректный номер дня недели от 1 до 7.");
            }
        }

        static string CardValue(int n)
        {
            switch (n)
            {
                case 6:
                    return "Шестёрка";
                case 7:
                    return "Семёрка";
                case 8:
                    return "Восьмёрка";
                case 9:
                    return "Девятка";
                case 10:
                    return "Десятка";
                case 11:
                    return "Валет";
                case 12:
                    return "Дама";
                case 13:
                    return "Король";
                case 14:
                    return "Туз";
                default:
                    throw new ArgumentOutOfRangeException("неправильный номер карты");
            }
        }
    }
}


