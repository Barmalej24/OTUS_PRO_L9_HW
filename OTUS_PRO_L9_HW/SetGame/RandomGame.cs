using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW.SetGame
{
    /// <summary>
    /// Класс игры рандом
    /// </summary>
    internal class RandomGame : IRandomGame
    {
        ISettingRandomGame _settingGame;

        private int _value;

        /// <summary>
        /// Загаданное число
        /// </summary>
        public int Value { get => _value; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RandomGame"/> с помощью заданных настроек.
        /// </summary>
        public RandomGame(ISettingRandomGame settingGame)
        {
            _settingGame = settingGame;
        }

        /// <summary>
        /// Сгенерировать рандомное число в заданом диапазоне
        /// </summary>
        public void CreateRandomNumber()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _value = rand.Next(_settingGame.IntervalStart, _settingGame.IntervalEnd);
        }

    }
}
