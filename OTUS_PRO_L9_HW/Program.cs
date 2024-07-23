using OTUS_PRO_L9_HW.SetGame;

namespace OTUS_PRO_L9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var setting = new SettingRandomGame(1, 10, 10);
            var newGame = new RandomGame(setting);
            var game = new Game(newGame, setting);
            
            game.Start();

        }
    }
}
