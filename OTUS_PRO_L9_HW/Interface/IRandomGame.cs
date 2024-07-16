﻿namespace OTUS_PRO_L9_HW.Interface
{
    /// <summary>
    /// Интерфейс игры Рандом
    /// </summary>
    public interface IRandomGame : IChecking
    {
        /// <summary>
        /// Сгенерировать рандомное число в заданом диапазоне
        /// </summary>
        void CreateRandomNumber();
        
        /// <summary>
        /// Возвращает настройки заданные при создании класса
        /// </summary>
        /// <returns></returns>
        public ISettingRandomGame GetSetting();
    }
}
