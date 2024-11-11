namespace PDFConverter
{
    public partial class WatermarkSetting : UserControl
    {
        public WatermarkSetting(int wmSize = 100, int wmFontSize = 22, int wmAngle = 45, float wmAlpha = 0.1f, Color wmColor = default, bool wmPrintAble = true)
        {
            InitializeComponent();

            cpWatermarkColor.Value = wmColor;
            sldWatermarkAlpha.Value = (int)(wmAlpha * 100);
            sldWatermarkAngle.Value = wmAngle;
            sldWatermarkFontSize.Value = wmFontSize;
            sldWatermarkSize.Value = wmSize;
            chkPrintable.Checked = wmPrintAble;
        }

        public Color WaterMarkColor => cpWatermarkColor.Value;
        public float WaterMarkAlpha => (float)sldWatermarkAlpha.Value / 100;
        public int WaterMarkFontAngle => sldWatermarkAngle.Value;
        public int WaterMarkFontSize => sldWatermarkFontSize.Value;
        public int WaterMarkSize => sldWatermarkSize.Value;

        public bool WaterMarkPrintable => chkPrintable.Checked;
    }
}