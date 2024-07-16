using OTUS_PRO_L9_HW.Comparison;
using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW
{
    /// <summary>
    /// Игра рандом для консоли
    /// </summary>
    internal class Game : IGame
    {
        private readonly IRandomGame game;
        
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Game"/> с помощью заданной игры.
        /// </summary>
        public Game(IRandomGame game)
        {
            this.game = game;
        }
        
        /// <summary>
        /// Запускает основной цикл программы для игры через консоль
        /// </summary>
        public void StartGame()
        {            
            ComparisonResult result;
            var number = 0;
            var setting = game.GetSetting();
            game.CreateRandomNumber();

            Console.WriteLine($"Компьютер загодал число от {setting.IntervalStart} до {setting.IntervalEnd}. У вас осталось попыткок - {game.CheckAttempt()} .");
            
            while (game.CheckAttempt() != 0)
            {
                Console.WriteLine();
                Console.WriteLine($"У вас осталось попыткок - {game.CheckAttempt()} .");
                Console.Write($"Введите предпологаемое число:");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    result = game.CheckingValue(number);
                    switch (result)
                    {
                        case ComparisonResult.Equals:
                            Console.WriteLine($"Поздравляю число {number} это то самое загаданное число. Вы победили компьютер.");
                            Console.WriteLine();
                            return;
                        case ComparisonResult.Bigger:
                            Console.WriteLine($"К сожелению число {number} больше загаданного числа");
                            break;
                        case ComparisonResult.Smaller:
                            Console.WriteLine($"К сожелению число {number} меньше загаданного числа");
                            break;
                        case ComparisonResult.Exp:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат данных повторите ввод.");
                }
            }
            Console.WriteLine("К сожелению Вы проиграли компьютеру");
        }
    }
}
