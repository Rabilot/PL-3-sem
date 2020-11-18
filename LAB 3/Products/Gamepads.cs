namespace LAB_3
{
    public class Gamepads : Product
    {
        /// <summary>
        /// Количество клавиш
        /// </summary>
        public int NumberOfKeys;
        /// <summary>
        /// Беспроводной ли геймпад
        /// </summary>
        public bool IsWireless;
        /// <summary>
        /// Есть ли аналоговые триггеры
        /// </summary>
        public bool AnalogTriggers;
        /// <summary>
        /// Есть ли тачпад
        /// </summary>
        public bool Touchpad;
    }
}