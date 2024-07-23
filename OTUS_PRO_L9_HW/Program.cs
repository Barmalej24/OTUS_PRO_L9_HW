using OTUS_PRO_L9_HW.Interface;
using OTUS_PRO_L9_HW.SetGame;

namespace OTUS_PRO_L9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInput input = new ConsoleInput();
            IOutput output = new ConsoleOutput();

            var setting = new SettingRandomGame(1, 10, 10);
            var newGame = new RandomGame(setting);
            var game = new Game(newGame, setting, input, output);
            
            game.Start();

        }
    }
}
