namespace LAB_4.Products
{
    public class Camera
    {
        /// <summary>
        /// Наличие экрана
        /// </summary>
        public bool Screen { get; set; }
        /// <summary>
        /// Наличие оптической стабилизации
        /// </summary>
        public bool OpticalStabilization { get; set; }
        /// <summary>
        /// Минимальный ISO
        /// </summary>
        public int minISO { get; set; }
        /// <summary>
        /// Максимальный ISO
        /// </summary>
        public int maxISO { get; set; }
        /// <summary>
        /// Разрешение
        /// </summary>
        public double Resolution { get; set; }
        /// <summary>
        /// Скорость съёмки
        /// </summary>
        public double ShootingSpeed { get; set; }
    }
}