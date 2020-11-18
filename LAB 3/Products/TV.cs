namespace LAB_3
{
    public class TV
    {
        /// <summary>
        /// Тип экрана
        /// </summary>
        public string ScreenType { get; set; }
        /// <summary>
        /// Размер экрана
        /// </summary>
        public double ScreenSize { get; set; }
        /// <summary>
        /// Разрешение
        /// </summary>
        public int ScreenResolution { get; set; }
        /// <summary>
        /// Наличие HDR
        /// </summary>
        public bool HDR { get; set; }
        /// <summary>
        /// Наличие голосового управления
        /// </summary>
        public bool VoiceRemote { get; set; }
        /// <summary>
        /// Количество HDMI
        /// </summary>
        public int HDMI { get; set; }
        /// <summary>
        /// Наличие SmartTV
        /// </summary>
        public bool SmartTV { get; set; }
    }
}