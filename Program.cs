using System;

class Program
{
    private static void Main(string[] args)
    {
        Laba1 lab = new Laba1();

        while (true)
        {
            Console.Write("Введите номер задачи "
                + "(1-20) или 0 для выхода: ");
            string menuInput = Console.ReadLine();
            int taskNumber;
            if (!int.TryParse(menuInput,
                out taskNumber))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }

            if (taskNumber == 0) break;

            switch (taskNumber)
            {
                case 1:
                    lab.Task1();
                    break;
                case 2:
                    lab.Task2();
                    break;
                case 3:
                    lab.Task3();
                    break;
                case 4:
                    lab.Task4();
                    break;
                case 5:
                    lab.Task5();
                    break;
                case 6:
                    lab.Task6();
                    break;
                case 7:
                    lab.Task7();
                    break;
                case 8:
                    lab.Task8();
                    break;
                case 9:
                    lab.Task9();
                    break;
                case 10:
                    lab.Task10();
                    break;
                case 11:
                    lab.Task11();
                    break;
                case 12:
                    lab.Task12();
                    break;
                case 13:
                    lab.Task13();
                    break;
                case 14:
                    lab.Task14();
                    break;
                case 15:
                    lab.Task15();
                    break;
                case 16:
                    lab.Task16();
                    break;
                case 17:
                    lab.Task17();
                    break;
                case 18:
                    lab.Task18();
                    break;
                case 19:
                    lab.Task19();
                    break;
                case 20:
                    lab.Task20();
                    break;
                default:
                    Console.WriteLine(
                        "Нет такой задачи.");
                    break;
            }
        }
    }
}
