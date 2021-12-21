using System;

namespace lesson
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");
            {
                Console.WriteLine("Введите значение температуры 1");
                double firstTemperature = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение температуры 2");
                double secondTemperature = Convert.ToDouble(Console.ReadLine());

                double averageTemperature = (firstTemperature + secondTemperature) / 2;

                Console.WriteLine($"Среднее значение температуры - {averageTemperature}");


                Console.WriteLine();
                Console.WriteLine("Задание 2");

                Console.WriteLine("Введите номер месяца");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Название месяца - {NameOfMonth(number)}");

                if (number == 12 || number == 1 || number == 2)
                {
                    if (averageTemperature > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание 3");
            {
                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Число является четным");
                }
                else
                {
                    Console.WriteLine("Число является нечетным");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание 4");
            {
                string str1 = "Кассовый чек/приход";
                string str2 = "Полный расчёт";
                string str3 = "Улсуга";
                string str4 = "Арендная плата";
                string str5 = "НДС ";
                int num5 = 20;
                string str6 = "ИТОГ : ";
                int num6 = 6000;
                string str7 = "Сумма НДС : ";
                int num7 = 1000;
                string str8 = "Зачетом аванса : ";
                int num8 = 6000;
                Console.WriteLine(str1 + "\n" +
                    str2 + '\n' +
                    str3 + '\n' +
                    str4 + '\n' +
                    str5 + num5 + '\n' +
                    str6 + num6 + '\n' +
                    str7 + num7 + '\n' +
                    str8 + num8);
            }

            //а вот с битовыми масками я не разобрался =)
        }

        static string NameOfMonth(int number)
        {
            return number switch
            {
                1 => "Январь",
                2 => "Февраль",
                3 => "Март",
                4 => "Апрель",
                5 => "Май",
                6 => "Июнь",
                7 => "Июль",
                8 => "Август",
                9 => "Сентябрь",
                10 => "Октябрь",
                11 => "Ноябрь",
                12 => "Декабрь",
                _ => "Неизвестно",
            };
        }
    }
}