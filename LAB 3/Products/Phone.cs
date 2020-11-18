namespace LAB_3
{
    public class Phone : Product
    {
        /// <summary>
        /// Центральный процессор
        /// </summary>
        public string CPU{ get; set;}
        /// <summary>
        /// Графический процессор
        /// </summary>
        public string GPU{ get; set;}
        /// <summary>
        /// Объём перативной памяти
        /// </summary>
        public int RAM{ get; set;}
        /// <summary>
        /// Размер основной памяти
        /// </summary>
        public int Storage{ get; set;}
        //public int xyjablic;
        /// <summary>
        /// Тип дисплея
        /// </summary>
        public string DisplayType{ get; set;}
        /// <summary>
        /// Размер дисплея
        /// </summary>
        public double DisplaySize { get; set; }
        /// <summary>
        /// Наличие NFC
        /// </summary>
        public bool NFC{ get; set;}
    }
}