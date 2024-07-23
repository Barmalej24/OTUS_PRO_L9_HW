using OTUS_PRO_L9_HW.Base;
using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW
{
    /// <summary>
    /// Игра рандом для консоли
    /// </summary>
    internal class Game
    {
        private readonly IInput _input;
        private readonly IOutput _output;
        private readonly IBaseGame _game;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Game"/> с помощью заданной игры.
        /// </summary>
        public Game(IRandomGame numberGenerator, ISettingRandomGame gameRules, IInput input, IOutput output)
        {
            _input = input;
            _output = output;
            _game = new BaseGame(numberGenerator, gameRules);
        }

        /// <summary>
        /// Запускает основной цикл программы для игры через консоль
        /// </summary>
        public void Start()
        {
            _output.WriteOutput($"Добро пожаловать в игру в угадывание числа!");
            while (true)
            {
                try
                {
                    _output.WriteOutput($"Введите ваше число (или 0 для выхода): ");
                    int userGuess = int.Parse(_input.ReadInput());

                    if (userGuess == 0)
                    {
                        _output.WriteOutput($"Спасибо за игру!");
                        break;
                    }

                    string result = _game.Guess(userGuess);
                    _output.WriteOutput(result);
                    if (result == "Поздравляю! Вы угадали то самое загаданное число. Вы победили компьютер.")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    _output.WriteOutput($"Пожалуйста, введите целое число.");
                }
            }
        }
    }
}
