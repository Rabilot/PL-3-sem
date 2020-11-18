namespace LAB_3
{
    public class Speakers : Product

    {
        /// <summary>
        /// Номинальная мощность
        /// </summary>
        public int RMS { get; set; }
        /// <summary>
        /// Количество динамиков
        /// </summary>
        public int NumberOfSpeakers { get; set; }
        /// <summary>
        /// Минимальная частота динамиков
        /// </summary>
        public int MinFrequency { get; set; }
        /// <summary>
        /// Максимальная частота динамиков
        /// </summary>
        public int MaxFrequency { get; set; }
    }
}