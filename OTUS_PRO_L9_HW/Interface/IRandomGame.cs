namespace OTUS_PRO_L9_HW.Interface
{
    /// <summary>
    /// Рандомайзер
    /// </summary>
    public interface IRandomGame
    {
        /// <summary>
        /// Загаданное число
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Сгенерировать рандомное число в заданом диапазоне
        /// </summary>
        public void CreateRandomNumber();

    }
}
