using OTUS_PRO_L9_HW.Setting;

namespace OTUS_PRO_L9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var setting = new SettingRandomGame(1, 10, 10);
            var newGame = new RandomGame(setting);
            var game = new Game(newGame);

            while (true)
            {                
                game.StartGame();
                Console.WriteLine("Хотите повторить игру? Введите Y(ДА) / N(Нет)");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.N)
                {
                    return;
                }
                Console.Clear();
            }
        }
    }
}
