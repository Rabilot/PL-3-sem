namespace LAB_3
{
    public class TV
    {
        public display Display { get; set; }
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