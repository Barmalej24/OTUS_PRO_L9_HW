using OTUS_PRO_L9_HW.Comparison;

namespace OTUS_PRO_L9_HW.Interface
{
    /// <summary>
    /// Интерфейс игры
    /// </summary>
    public interface IBaseGame
    {
        /// <summary>
        /// Ход угадывания
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Строка с результатом угадывания</returns>
        string Guess(int number);

        /// <summary>
        /// Проверка введенного числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Результат сравнения</returns>
        ComparisonResult CheckingValue(int number);
    }
}
