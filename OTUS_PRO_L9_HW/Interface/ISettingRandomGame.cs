namespace OTUS_PRO_L9_HW.Interface
{
    /// <summary>
    /// Интерфес описывающий настройки для программы
    /// </summary>
    public interface ISettingRandomGame
    {
        /// <summary>
        /// Конец диапазона загадоваемого числа
        /// </summary>
        int IntervalEnd { get; }
        
        /// <summary>
        /// Начало диапазона загадоваемого числа
        /// </summary>
        int IntervalStart { get; }
        
        /// <summary>
        /// Кол-во попыток отгадывания
        /// </summary>
        int NumberAttempt { get; }       

    }
}
