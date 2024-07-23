using OTUS_PRO_L9_HW.Base;
using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW
{
    /// <summary>
    /// Игра рандом для консоли
    /// </summary>
    internal class Game
    {
        private readonly IBaseGame _game;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Game"/> с помощью заданной игры.
        /// </summary>
        public Game(IRandomGame numberGenerator, ISettingRandomGame gameRules)
        {
            _game = new BaseGame(numberGenerator, gameRules);
        }

        /// <summary>
        /// Запускает основной цикл программы для игры через консоль
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Добро пожаловать в игру в угадывание числа!");
            while (true)
            {
                try
                {
                    Console.Write("Введите ваше число (или 0 для выхода): ");
                    int userGuess = int.Parse(Console.ReadLine());

                    if (userGuess == 0)
                    {
                        Console.WriteLine("Спасибо за игру!");
                        break;
                    }

                    string result = _game.Guess(userGuess);
                    Console.WriteLine(result);
                    if (result == "Поздравляю! Вы угадали то самое загаданное число. Вы победили компьютер.")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Пожалуйста, введите целое число.");
                }
            }
        }
    }
}
