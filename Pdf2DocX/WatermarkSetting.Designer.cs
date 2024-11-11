namespace PDFConverter
{
    partial class WatermarkSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            cpWatermarkColor = new AntdUI.ColorPicker();
            label9 = new AntdUI.Label();
            sldWatermarkAlpha = new AntdUI.Slider();
            label10 = new AntdUI.Label();
            sldWatermarkFontSize = new AntdUI.Slider();
            label8 = new AntdUI.Label();
            sldWatermarkSize = new AntdUI.Slider();
            label7 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            sldWatermarkAngle = new AntdUI.Slider();
            chkPrintable = new AntdUI.Checkbox();
            label2 = new AntdUI.Label();
            SuspendLayout();
            // 
            // cpWatermarkColor
            // 
            cpWatermarkColor.Location = new Point(69, 180);
            cpWatermarkColor.Name = "cpWatermarkColor";
            cpWatermarkColor.Size = new Size(33, 24);
            cpWatermarkColor.TabIndex = 2;
            cpWatermarkColor.Text = "colorPicker1";
            cpWatermarkColor.Value = Color.FromArgb(22, 119, 255);
            // 
            // label9
            // 
            label9.Location = new Point(2, 173);
            label9.Name = "label9";
            label9.Size = new Size(52, 36);
            label9.TabIndex = 1;
            label9.Text = "颜色";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sldWatermarkAlpha
            // 
            sldWatermarkAlpha.Location = new Point(69, 87);
            sldWatermarkAlpha.MinValue = 1;
            sldWatermarkAlpha.Name = "sldWatermarkAlpha";
            sldWatermarkAlpha.ShowValue = true;
            sldWatermarkAlpha.Size = new Size(185, 47);
            sldWatermarkAlpha.TabIndex = 0;
            sldWatermarkAlpha.Text = "slider3";
            sldWatermarkAlpha.Value = 20;
            // 
            // label10
            // 
            label10.Location = new Point(2, 91);
            label10.Name = "label10";
            label10.Size = new Size(52, 36);
            label10.TabIndex = 1;
            label10.Text = "透明度";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sldWatermarkFontSize
            // 
            sldWatermarkFontSize.Location = new Point(69, 49);
            sldWatermarkFontSize.MaxValue = 32;
            sldWatermarkFontSize.MinValue = 18;
            sldWatermarkFontSize.Name = "sldWatermarkFontSize";
            sldWatermarkFontSize.ShowValue = true;
            sldWatermarkFontSize.Size = new Size(185, 32);
            sldWatermarkFontSize.TabIndex = 0;
            sldWatermarkFontSize.Text = "slider2";
            sldWatermarkFontSize.Value = 22;
            // 
            // label8
            // 
            label8.Location = new Point(2, 49);
            label8.Name = "label8";
            label8.Size = new Size(52, 36);
            label8.TabIndex = 1;
            label8.Text = "字号";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sldWatermarkSize
            // 
            sldWatermarkSize.Location = new Point(69, 7);
            sldWatermarkSize.MaxValue = 400;
            sldWatermarkSize.MinValue = 100;
            sldWatermarkSize.Name = "sldWatermarkSize";
            sldWatermarkSize.ShowValue = true;
            sldWatermarkSize.Size = new Size(185, 36);
            sldWatermarkSize.TabIndex = 0;
            sldWatermarkSize.Text = "slider1";
            sldWatermarkSize.Value = 100;
            // 
            // label7
            // 
            label7.Location = new Point(2, 7);
            label7.Name = "label7";
            label7.Size = new Size(52, 36);
            label7.TabIndex = 1;
            label7.Text = "尺寸";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(2, 130);
            label1.Name = "label1";
            label1.Size = new Size(52, 36);
            label1.TabIndex = 4;
            label1.Text = "角度";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sldWatermarkAngle
            // 
            sldWatermarkAngle.Location = new Point(69, 126);
            sldWatermarkAngle.MaxValue = 180;
            sldWatermarkAngle.MinValue = -180;
            sldWatermarkAngle.Name = "sldWatermarkAngle";
            sldWatermarkAngle.ShowValue = true;
            sldWatermarkAngle.Size = new Size(185, 47);
            sldWatermarkAngle.TabIndex = 3;
            sldWatermarkAngle.Text = "slider3";
            sldWatermarkAngle.Value = 45;
            // 
            // chkPrintable
            // 
            chkPrintable.AutoCheck = true;
            chkPrintable.Location = new Point(67, 218);
            chkPrintable.Name = "chkPrintable";
            chkPrintable.Size = new Size(75, 23);
            chkPrintable.TabIndex = 6;
            chkPrintable.Text = "可打印";
            // 
            // label2
            // 
            label2.Location = new Point(3, 212);
            label2.Name = "label2";
            label2.Size = new Size(52, 36);
            label2.TabIndex = 5;
            label2.Text = "权限";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // WaterMarkSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(chkPrintable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sldWatermarkAngle);
            Controls.Add(cpWatermarkColor);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(sldWatermarkAlpha);
            Controls.Add(sldWatermarkFontSize);
            Controls.Add(label8);
            Controls.Add(sldWatermarkSize);
            Controls.Add(label7);
            Name = "WaterMarkSetting";
            Size = new Size(268, 251);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.ColorPicker cpWatermarkColor;
        private AntdUI.Label label9;
        private AntdUI.Slider sldWatermarkAlpha;
        private AntdUI.Label label10;
        private AntdUI.Slider sldWatermarkFontSize;
        private AntdUI.Label label8;
        private AntdUI.Slider sldWatermarkSize;
        private AntdUI.Label label7;
        private AntdUI.Label label1;
        private AntdUI.Slider sldWatermarkAngle;
        private AntdUI.Checkbox chkPrintable;
        private AntdUI.Label label2;
    }
}
