using System;

namespace Labs
{
    static class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите вариант:");
                var x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 9:
                    {
                        Console.WriteLine("Выбран вариант: 9");
                        Console.Write("Введите номер лабораторной работы:");
                        var q = int.Parse(Console.ReadLine());

                        switch (q)
                        {
                            case 1:
                                Console.WriteLine("Лабораторная работа №1");
                                Task1();
                                break;
                            case 2:
                                Console.WriteLine("Лабораторная работа №2");
                                Task2();
                                break;
                            default:
                                Console.WriteLine("В программе нет такой лабораторной работы");
                                continue;
                        }

                        break;
                    }
                    case 11:
                    {
                        Console.WriteLine("Выбран вариант: 11");
                        Console.Write("Введите номер лабораторной работы:");
                        int w = int.Parse(Console.ReadLine());

                        if (w == 1)
                        {
                            Console.WriteLine("Лабораторная работа №1");
                            task1_1();
                        }
                        else if (w == 2)
                        {
                            Console.WriteLine("Лабораторная работа №2");
                            task2_1();
                        }
                        else
                        {
                            Console.WriteLine("В программе нет такой лабораторной работы");
                            continue;
                        }

                        break;
                    }
                    default:
                        Console.WriteLine("Такого варианта нет в программе");
                        continue;
                }

                break;
            }
        }

        static void Task1()
            //Лабораторная работа №1 Вариант 9
        {
            Console.Write("x=");
            var x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            var y = float.Parse(Console.ReadLine());
            if ((y < 12 && y > x && x >= 0) || (y < 12 && y > -x && x < 0))
            {
                Console.WriteLine("Ответ на лаб. работу №1: " + "внутри");
                Main();
            }
            else if (((y > 12 || y < x) && x >= 0) || ((y > 12 || y < -x) && x < 0))
            {
                Console.WriteLine("Ответ на лаб. работу №1: " + "вне");
                Main();
            }
            else
            {
                Console.WriteLine("Ответ на лаб. работу №1: " + "на границе");
                Main();
            }
        }

        static void Task2()
            //Лабораторная работа №2 Вариант 9
        {
            Console.Write("m=");
            var m = ((byte.Parse(Console.ReadLine())) % 12);
            switch (m)
            {
                case 0:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Февраль");
                    Main();
                    break;
                case 1:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Январь");
                    Main();
                    break;
                case 2:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Декабрь");
                    Main();
                    break;
                case 3:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Ноябрь");
                    Main();
                    break;
                case 4:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Октябрь");
                    Main();
                    break;
                case 5:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Сентябрь");
                    Main();
                    break;
                case 6:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Август");
                    Main();
                    break;
                case 7:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Июль");
                    Main();
                    break;
                case 8:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Июнь");
                    Main();
                    break;
                case 9:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Май");
                    Main();
                    break;
                case 10:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Апрель");
                    Main();
                    break;
                case 11:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "Март");
                    Main();
                    break;
                default:
                    Console.WriteLine("Ответ на лаб. работу №2: " + "ВЫ ОШИБЛИСЬ");
                    Main();
                    break;
            }
        }

        static void task1_1()
            //Лабораторная работа №1 Вариант 11
        {
            Console.Write("x=");
            var x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            var y = float.Parse(Console.ReadLine());
            if (x < 25 && x > -25 && y < 12.5 && y > -12.5)
            {
                Console.WriteLine("Ответ на лаб. работу №1: : " + "внутри");
                Main();
            }
            else if ((x > 25 || x < -25) && (y > 12.5 || y < -12.5))
            {
                Console.WriteLine("Ответ на лаб. работу №1: : " + "вне");
                Main();
            }
            else
            {
                Console.WriteLine("Ответ на лаб. работу №1: : " + "на границе");
                Main();
            }
        }

        static void task2_1()
            //Лабораторная работа №2 Вариант 11
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine((DateTime.Now).ToString("MMMM dd, yyyy"));
            }
            else
            {
                var lastDay = n * 864000000000;
                var thisDay = DateTime.Now.Ticks;
                var mDays = thisDay - lastDay;
                var myDate = new DateTime(mDays);
                var test = myDate.ToString("MMMM dd, yyyy");
                Console.WriteLine("Ответ на лаб. работу №2: " + test);
                Main();
            }
        }
    }
}