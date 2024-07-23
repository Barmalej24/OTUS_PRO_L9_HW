using OTUS_PRO_L9_HW.Comparison;
using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW.Base
{
    public class BaseGame : IBaseGame
    {
        private readonly IRandomGame _numberGenerator;
        private readonly ISettingRandomGame _settingGame;
        private int _secretNumber;
        private int _attempts;

        public BaseGame(IRandomGame numberGenerator, ISettingRandomGame gameRules)
        {
            _numberGenerator = numberGenerator;
            _settingGame = gameRules;
            _attempts = 0;
            _numberGenerator.CreateRandomNumber();
            _secretNumber = _numberGenerator.Value;
        }

        public string Guess(int userNumber)
        {
            var result = string.Empty;

            if (_attempts >= _settingGame.NumberAttempt)
            {
                result = $"Игра завершена! Вы исчерпали допустимое количество попыток.";
            }

            _attempts++;

            switch (CheckingValue(userNumber))
            {
                case ComparisonResult.Equals:
                    result = $"Поздравляю! Вы угадали то самое загаданное число. Вы победили компьютер.";
                    break;
                case ComparisonResult.Bigger:
                    result = $"К сожелению число {userNumber} больше загаданного числа.";
                    break;
                case ComparisonResult.Smaller:
                    result = $"К сожелению число {userNumber} меньше загаданного числа.";
                    break;
            }

            return result;
        }

        public ComparisonResult CheckingValue(int number)
        {
            if (number == _secretNumber)
            {
                return ComparisonResult.Equals;
            }

            return number < _secretNumber ? ComparisonResult.Smaller : ComparisonResult.Bigger;
        }
    }
}
