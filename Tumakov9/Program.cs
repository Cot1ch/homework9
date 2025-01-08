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
            bool flag = true;
            do
            {
                Console.WriteLine("Выберите действие: Выход / (не_выход)всё_остальное");
                string input = Console.ReadLine();

                if (input == "выход")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Введите строку. Поддерживаются русский и английский алфавиты. Символ не из них не будет изменен");
                    string str = Console.ReadLine();

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
            Console.WriteLine("\tРаботаем с точкой ========\n");
            Point point = new Point(Colors.Чёрный, EVisibility.Invisible);
            Console.WriteLine(point.ToString());

            point.MoveVert(10);
            point.MoveHor(-5);
            Console.WriteLine(point.ToString());

            point.ChangeColor(Colors.Красный);
            Console.WriteLine(point.ToString());
            Console.WriteLine("Закончили работать с точкой ========\n");


            Console.WriteLine("\tРаботаем с кругом ========\n");
            Circle circle = new Circle(123);
            Console.WriteLine(circle.ToString());

            Console.WriteLine($"Площадь круга: {circle.GetPl():F2}");

            circle.MoveVert(-10);
            circle.MoveHor(12);
            Console.WriteLine(circle.ToString());

            circle.ChangeColor(Colors.Серый);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("Закончили работать с кругом ========\n");


            Console.WriteLine("\tРаботаем с прямоугольником ========\n");
            Rectangle rect = new  Rectangle(12.4, 24);
            Console.WriteLine(rect.ToString());

            Console.WriteLine($"Площадь прямоугольника: {rect.GetPl():F2}");

            rect.MoveEverywhere(-10, 5);
            Console.WriteLine(rect.ToString());

            rect.ChangeColor(Colors.Жёлтый);
            Console.WriteLine(rect.ToString());
            rect.ShowVisibility();
            Console.WriteLine("Закончили работать с прямоугольником ========\n");
        }
    }
}
