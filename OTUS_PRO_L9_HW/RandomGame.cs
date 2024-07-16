using OTUS_PRO_L9_HW.Comparison;
using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW
{
    /// <summary>
    /// Класс игры рандом
    /// </summary>
    internal class RandomGame : IRandomGame
    {
        ISettingRandomGame _settingGame;
        private int _value;
        private int _counter;
        
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
            _counter = 0;
            Random rand = new Random((int)DateTime.Now.Ticks);
            _value = rand.Next(_settingGame.IntervalStart, _settingGame.IntervalEnd);
        }
        
        /// <summary>
        /// Проверить совпадант ли введенное число с сгенерированным значением
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <returns></returns>
        public ComparisonResult CheckingValue(int value)
        {
            if (_counter == _settingGame.NumberAttempt)
                return ComparisonResult.Exp;

            _counter++;

            if (value == _value)
            {
                _counter = _settingGame.NumberAttempt;
                return ComparisonResult.Equals;
            }

            return value < _value ? ComparisonResult.Smaller : ComparisonResult.Bigger;
        }
        
        /// <summary>
        /// Выводится количество оставшихся попыток
        /// </summary>
        /// <returns></returns>
        public int CheckAttempt()
        {
            return _settingGame.NumberAttempt - _counter;
        }
        
        /// <summary>
        /// Возвращает настройки заданные при создании класса
        /// </summary>
        /// <returns></returns>
        public ISettingRandomGame GetSetting()
        {
            return _settingGame;
        }
    }
}
