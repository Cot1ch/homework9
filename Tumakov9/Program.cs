using System;

namespace Tumakov9
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();

            Console.WriteLine("пресс самфинг ту закрыть это окно...");
            Console.ReadKey();
        }

        /// <summary>
        /// Создать интерфейс, который определяет методы шифрования строк.
        /// В интерфейсе объявить методы decode и encode, объявить 2 класса:
        /// 1 шифрует строки сдвигом на 1 символ справо по алфавиту, 2 - зеркалит.
        /// Продемонстрировать работу классов
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Упражнение 10.1\n");

            bool flag = true;
            do
            {
                Console.WriteLine("Выберите действие: Выход / начните ввод новой строки");
                string input = Console.ReadLine();

                if (input.ToLower() == "выход")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Поддерживаются русский и английский алфавиты. Символ не из них не будет изменен");
                    string str = input;

                    bool flag2 = true;
                    do
                    {
                        Console.WriteLine("Выбираем действие:\nРаскодировать\nЗакодировать");
                        string operation = Console.ReadLine().ToLower();

                        if (operation.StartsWith("раскод"))
                        {
                            Console.WriteLine($">>> Способ A: {Enigma.Dec(new ACipher(), str)}");
                            Console.WriteLine($">>> Способ B: {Enigma.Dec(new BCipher(), str)}");
                            flag2 = false;
                        }
                        else if (operation.StartsWith("закод"))
                        {
                            Console.WriteLine($">>> Способ A: {Enigma.Enc(new ACipher(), str)}");
                            Console.WriteLine($">>> Способ B: {Enigma.Enc(new BCipher(), str)}");
                            flag2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Такого действия нет");
                        }
                    }
                    while (flag2);                    
                }
            }
            while (flag);
        }

        /// <summary>
        /// Создать класс Figure для работы с геометрическими фигурами. 
        /// Поля: цвет, видимость, координаты на плоскости. 
        /// Реализовать смену цвета, вывод состояния, перемещение, override'нуть ToString(). 
        /// Создать классы Point как наследника Figure, Circle и Rectangle как наследники Point.
        /// Реализовать метод подсчёта площади круга и прямоугольника 
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Домашнее задание 10.1\n");

            Console.WriteLine("\tРаботаем с точкой ========\n");
            Point point = new Point(12, 3, Colors.Чёрный, EVisibility.Невидимый);
            Console.WriteLine(point.ToString());

            point.MoveVert(10);
            point.MoveHor(-5); // Меняем положение
            Console.WriteLine();

            point.ChangeColor(Colors.Красный); // Меняем цвет
            Console.WriteLine(point.ToString());
            Console.WriteLine("\nЗакончили работать с точкой ========\n");


            Console.WriteLine("\tРаботаем с кругом ========\n");
            Circle circle = new Circle(123);
            Console.WriteLine(circle.ToString());

            Console.WriteLine($"\nПлощадь круга: {circle.GetPl():F2}\n");

            circle.MoveVert(-10);
            circle.MoveHor(12);
            circle.ShowVisibility();
            Console.WriteLine();

            circle.ChangeColor(Colors.Серый);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("\nЗакончили работать с кругом ========\n");


            Console.WriteLine("\tРаботаем с прямоугольником ========\n");
            Rectangle rect = new  Rectangle(12.4, 24);
            Console.WriteLine(rect.ToString());

            Console.WriteLine($"\nПлощадь прямоугольника: {rect.GetPl():F2}\n");

            rect.MoveEverywhere(-10, 5);
            rect.ShowVisibility();
            Console.WriteLine();

            rect.ChangeColor(Colors.Жёлтый);
            Console.WriteLine(rect.ToString());
            Console.WriteLine("\nЗакончили работать с прямоугольником ========\n");
        }
    }
}
