using System;
using System.Collections.Generic;
using System.Linq;


namespace homework9
{
    internal class Program
    {
        static void Main()
        {
            Taska();

            Console.WriteLine("Нажмите что угодно для знаете чего...");
            Console.ReadKey();
        }

        /// <summary>
        /// Реализовать "Большие гонки". 
        /// Создать 7 игр по паттерну стратегия, 4 команды (в каждой по 15 игроков) и рандомайзер игр.
        /// </summary>
        static void Taska()
        {
            Boss olivie = new Boss("Оливье Ганьян");

            AddDefaultGames(olivie);
            LogMenu();

            bool flag = true;
            do
            {
                flag = false; // Чтобы меньше раз писать это
                string input = Console.ReadLine().ToLower();

                if (input.StartsWith("ввести стр"))
                {
                    while (olivie.Countries.Count != 4)
                    {
                        Console.WriteLine("Введите название страны");
                        Country country = new Country(Console.ReadLine());

                        if (!olivie.Countries.Keys.Contains(country))
                        {
                            Console.WriteLine("Введите состав (15 человек)");
                            country.AddPlayers();

                            olivie.AddCountry(country);
                            Console.WriteLine("Страна успешно добавлена");
                        }
                        else
                        {
                            Console.WriteLine("!! Такая страна уже есть !!");
                        }
                    }
                }
                else if (String.IsNullOrEmpty(input))
                {
                    olivie.Countries.Clear();

                    AddDefaultCountries(olivie);
                    Console.WriteLine("Добавлены страны Россия, Франция, Китай и Казахстан");
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите действие из списка");
                    flag = true;
                }
            }
            while (flag);


            flag = true;
            do
            {
                Console.WriteLine("Выберите действие:\nВыход\n(новая игра)Всё остальное");
                string input = Console.ReadLine().ToLower();
                if (input == "выход")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Вам понадобится 6 раз ввести места команд\n");

                    Console.WriteLine(">>>Для мощного запила выбраны: ");
                    List<IGame> games = olivie.ChooseGames();

                    foreach (IGame game in games)
                    {
                        Console.WriteLine("\n-->" + game.Name);
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine($"\n{i + 1} раунд: {games[i].Name}");
                        games[i].LogDescription();
                        Console.WriteLine("Введите места ->");

                        foreach (KeyValuePair<Country, List<int>> kv in olivie.Countries)
                        {
                            Console.Write(kv.Key.Name + ": -> ");

                            kv.Value.Add(EnterPlace(olivie.Countries.Count));
                        }
                    }

                    Console.WriteLine("\nРезультаты: (страна | сумма мест)");
                    CalcPlaces(olivie);

                    Console.WriteLine("\n\t!! Ответственность за распределение мест при равенстве баллов лежит на организаторе !!\n");
                }
            }
            while (flag);
        }

        /// <summary>
        /// Метод выводит положение команд вместе с суммой баллов за игру; очищает список мест каждой страны
        /// </summary>
        static void CalcPlaces(Boss boss)
        {
            foreach (var kv in boss.Countries.OrderBy(x => x.Value.Sum()))
            {
                Console.WriteLine(kv.Key.Name + " | " + kv.Value.Sum());
                kv.Value.Clear();
            }
        }

        /// <summary>
        /// Метод ввода места команды (натуральное число, не превышающее количество команд).
        /// Ввод до победного
        /// </summary>
        /// <returns>Натуральное число типа int</returns>
        static int EnterPlace(int maxPlace)
        {
            int ans = 0;
            bool flag = true;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int result) && (0 < result) && (result <= maxPlace))
                {
                    ans = result;
                    flag = false;
                }
                else
                {
                    Console.WriteLine($"Введите целое число от 1 до {maxPlace} включительно");
                }
            }
            while (flag);

            return ans;
        }

        /// <summary>
        /// Метод выводит меню ввода стран
        /// </summary>
        static void LogMenu()
        {
            Console.WriteLine("Ввести страну\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Либо нажмите Enter для использования шаблона стран и их составов по умолчанию");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Метод с добавлением игр
        /// </summary>
        static void AddDefaultGames(Boss boss)
        {
            List<IGame> list = new List<IGame>()
            {
                new Beach(),
                new Sea(),
                new Postman(),
                new Mousetrap(),
                new Fishing(),
                new Slide(),
                new TP(),
            };

            foreach (IGame g in list)
            {
                if (boss.AddGame(g))
                {
                    Console.WriteLine($"Игра '{g.Name}' добавлена");
                }
                else
                {
                    Console.WriteLine("Такая игра уже есть");
                }
            }
        }

        /// <summary>
        /// Метод с добавлением дефолтных стран с составами игроков
        /// </summary>
        static void AddDefaultCountries(Boss boss)
        {
            Country russia = new Country(
                "Россия", new Person[] {
                new Person("Артем"),
                new Person("Полина"),
                new Person("Глеб"),
                new Person("Анастасия"),
                new Person("Матвей"),
                new Person("Мария"),
                new Person("Александр"),
                new Person("Виктория"),
                new Person("Кирилл"),
                new Person("Елизавета"),
                new Person("Никита"),
                new Person("Дарья"),
                new Person("Иван"),
                new Person("Юлия"),
                new Person("Даниил")
                }
                );
            Country france = new Country(
                "Франция", new Person[] {
                new Person("Жюльен"),
                new Person("Софи"),
                new Person("Люк"),
                new Person("Камиль"),
                new Person("Винсент"),
                new Person("Эмма"),
                new Person("Антуан"),
                new Person("Шарлотта"),
                new Person("Пьер"),
                new Person("Элоиза"),
                new Person("Том"),
                new Person("Манон"),
                new Person("Ромен"),
                new Person("Лаура"),
                new Person("Максим")
                }
                );

            Country kazakhstan = new Country(
                "Казахстан", new Person[] {
                new Person("Нурлан"),
                new Person("Айжан"),
                new Person("Ерболат"),
                new Person("Мадина"),
                new Person("Даулет"),
                new Person("Гульмира"),
                new Person("Бауыржан"),
                new Person("Карлыгаш"),
                new Person("Талгат"),
                new Person("Салтанат"),
                new Person("Рахим"),
                new Person("Асель"),
                new Person("Серик"),
                new Person("Зере"),
                new Person("Темирлан")
                }
                );
            Country china = new Country(
            "Китай", new Person[] {
                new Person("Чжоу Вэй"),
                new Person("Ли Фэн"),
                new Person("Чэнь Сяо"),
                new Person("Хуан Мэй"),
                new Person("Цзян Лун"),
                new Person("Янь Цин"),
                new Person("Лю Ян"),
                new Person("Сунь Ли"),
                new Person("Ван Мин"),
                new Person("Чжао Лин"),
                new Person("Шень Чжи"),
                new Person("Фань Юй"),
                new Person("Чжан Хао"),
                new Person("У Цзинь"),
                new Person("Дин Нин")
                }
                );

            boss.AddCountry( russia );
            boss.AddCountry( france );
            boss.AddCountry( kazakhstan );
            boss.AddCountry( china );
        }
    }
}
