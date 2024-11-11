namespace PDFConverter
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            windowBar1 = new AntdUI.WindowBar();
            panel1 = new AntdUI.Panel();
            tabs1 = new AntdUI.Tabs();
            tpConvert = new AntdUI.TabPage();
            alert1 = new AntdUI.Alert();
            btnConvertSrc = new AntdUI.Button();
            lblDirection = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSrc = new AntdUI.Input();
            prgConvert = new AntdUI.Progress();
            txtDest = new AntdUI.Input();
            btnConvert = new AntdUI.Button();
            btnConvertDst = new AntdUI.Button();
            tpWatermark = new AntdUI.TabPage();
            alert2 = new AntdUI.Alert();
            btnSetting = new AntdUI.Button();
            label6 = new Label();
            label5 = new Label();
            inpWatermarkTxt = new AntdUI.Input();
            inpWatermarkImg = new AntdUI.Input();
            btnWatermarkImg = new AntdUI.Button();
            btnWatermarkSrc = new AntdUI.Button();
            label1 = new Label();
            label4 = new Label();
            inpWatermarkSrc = new AntdUI.Input();
            progress1 = new AntdUI.Progress();
            inpWatermarkDst = new AntdUI.Input();
            btnWatermark = new AntdUI.Button();
            btnWatermarkDst = new AntdUI.Button();
            tooltipComponent1 = new AntdUI.TooltipComponent();
            panel1.SuspendLayout();
            tabs1.SuspendLayout();
            tpConvert.SuspendLayout();
            tpWatermark.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Icon = (Image)resources.GetObject("windowBar1.Icon");
            windowBar1.IsMax = false;
            windowBar1.Location = new Point(2, 2);
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(509, 23);
            windowBar1.TabIndex = 14;
            windowBar1.Text = "PDF2DOCX转换/PDF水印工具";
            // 
            // panel1
            // 
            panel1.BorderColor = SystemColors.ActiveBorder;
            panel1.BorderWidth = 2F;
            panel1.Controls.Add(tabs1);
            panel1.Controls.Add(windowBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 304);
            panel1.TabIndex = 18;
            panel1.Text = "panel1";
            // 
            // tabs1
            // 
            tabs1.BackColor = Color.WhiteSmoke;
            tabs1.Dock = DockStyle.Fill;
            tabs1.Location = new Point(2, 25);
            tabs1.Name = "tabs1";
            tabs1.Pages.Add(tpConvert);
            tabs1.Pages.Add(tpWatermark);
            tabs1.Size = new Size(509, 277);
            tabs1.Style = styleLine1;
            tabs1.TabIndex = 17;
            tabs1.Text = "tabs1";
            tabs1.SelectedIndexChanged += tabs1_SelectedIndexChanged;
            // 
            // tpConvert
            // 
            tpConvert.BackColor = Color.WhiteSmoke;
            tpConvert.Controls.Add(alert1);
            tpConvert.Controls.Add(btnConvertSrc);
            tpConvert.Controls.Add(lblDirection);
            tpConvert.Controls.Add(label3);
            tpConvert.Controls.Add(label2);
            tpConvert.Controls.Add(txtSrc);
            tpConvert.Controls.Add(prgConvert);
            tpConvert.Controls.Add(txtDest);
            tpConvert.Controls.Add(btnConvert);
            tpConvert.Controls.Add(btnConvertDst);
            tpConvert.Dock = DockStyle.Fill;
            tpConvert.Location = new Point(3, 28);
            tpConvert.Name = "tpConvert";
            tpConvert.Size = new Size(503, 246);
            tpConvert.TabIndex = 0;
            tpConvert.Text = "转换";
            // 
            // alert1
            // 
            alert1.Icon = AntdUI.TType.Info;
            alert1.Location = new Point(108, 105);
            alert1.Name = "alert1";
            alert1.Size = new Size(152, 23);
            alert1.TabIndex = 26;
            alert1.Text = "可直接拖放文件入框";
            alert1.Visible = false;
            // 
            // btnConvertSrc
            // 
            btnConvertSrc.BorderWidth = 1F;
            btnConvertSrc.Location = new Point(399, 11);
            btnConvertSrc.Name = "btnConvertSrc";
            btnConvertSrc.Size = new Size(75, 42);
            btnConvertSrc.TabIndex = 20;
            btnConvertSrc.Text = "...";
            btnConvertSrc.Click += btnConvertSrc_Click;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.BackColor = Color.Transparent;
            lblDirection.Location = new Point(41, 126);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(17, 17);
            lblDirection.TabIndex = 19;
            lblDirection.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(28, 70);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 18;
            label3.Text = "保存目录";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(41, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 17;
            label2.Text = "源文件";
            // 
            // txtSrc
            // 
            txtSrc.AllowDrop = true;
            txtSrc.Location = new Point(108, 10);
            txtSrc.Name = "txtSrc";
            txtSrc.Size = new Size(285, 43);
            txtSrc.TabIndex = 21;
            txtSrc.TextChanged += input_TextChanged;
            txtSrc.DragDrop += input_DragDrop;
            txtSrc.DragEnter += input_DragEnter;
            txtSrc.DragLeave += txtSrc_DragLeave;
            txtSrc.MouseEnter += inp_MouseEnter;
            txtSrc.MouseLeave += inp_MouseLeave;
            // 
            // prgConvert
            // 
            prgConvert.BackColor = Color.Transparent;
            prgConvert.ContainerControl = this;
            prgConvert.Location = new Point(39, 193);
            prgConvert.Name = "prgConvert";
            prgConvert.Size = new Size(435, 38);
            prgConvert.TabIndex = 25;
            prgConvert.Text = "progress1";
            // 
            // txtDest
            // 
            txtDest.AllowDrop = true;
            txtDest.Location = new Point(108, 56);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(285, 43);
            txtDest.TabIndex = 22;
            txtDest.TextChanged += input_TextChanged;
            txtDest.DragDrop += input_DragDrop;
            txtDest.DragEnter += input_DragEnter;
            // 
            // btnConvert
            // 
            btnConvert.BorderWidth = 1F;
            btnConvert.DefaultBorderColor = SystemColors.ActiveBorder;
            btnConvert.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnConvert.Location = new Point(399, 106);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 71);
            btnConvert.TabIndex = 23;
            btnConvert.Text = "转换";
            btnConvert.Type = AntdUI.TTypeMini.Primary;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnConvertDst
            // 
            btnConvertDst.BorderWidth = 1F;
            btnConvertDst.Location = new Point(399, 59);
            btnConvertDst.Name = "btnConvertDst";
            btnConvertDst.Size = new Size(75, 40);
            btnConvertDst.TabIndex = 24;
            btnConvertDst.Text = "...";
            btnConvertDst.Click += btnConvertDst_Click;
            // 
            // tpWatermark
            // 
            tpWatermark.BackColor = Color.WhiteSmoke;
            tpWatermark.Controls.Add(alert2);
            tpWatermark.Controls.Add(btnSetting);
            tpWatermark.Controls.Add(label6);
            tpWatermark.Controls.Add(label5);
            tpWatermark.Controls.Add(inpWatermarkTxt);
            tpWatermark.Controls.Add(inpWatermarkImg);
            tpWatermark.Controls.Add(btnWatermarkImg);
            tpWatermark.Controls.Add(btnWatermarkSrc);
            tpWatermark.Controls.Add(label1);
            tpWatermark.Controls.Add(label4);
            tpWatermark.Controls.Add(inpWatermarkSrc);
            tpWatermark.Controls.Add(progress1);
            tpWatermark.Controls.Add(inpWatermarkDst);
            tpWatermark.Controls.Add(btnWatermark);
            tpWatermark.Controls.Add(btnWatermarkDst);
            tpWatermark.Dock = DockStyle.Fill;
            tpWatermark.Location = new Point(3, 28);
            tpWatermark.Name = "tpWatermark";
            tpWatermark.Size = new Size(503, 246);
            tpWatermark.TabIndex = 0;
            tpWatermark.Text = "水印";
            tpWatermark.Click += tpWatermark_Click;
            // 
            // alert2
            // 
            alert2.Icon = AntdUI.TType.Info;
            alert2.Location = new Point(105, 194);
            alert2.Name = "alert2";
            alert2.Size = new Size(161, 23);
            alert2.TabIndex = 39;
            alert2.Text = "可直接拖放文件入框";
            // 
            // btnSetting
            // 
            btnSetting.BorderWidth = 1F;
            btnSetting.DefaultBorderColor = SystemColors.ActiveBorder;
            btnSetting.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSetting.IconSvg = "SettingOutlined";
            btnSetting.Location = new Point(348, 148);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(42, 39);
            btnSetting.TabIndex = 37;
            btnSetting.Type = AntdUI.TTypeMini.Success;
            btnSetting.Click += btnSetting_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(37, 157);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 34;
            label6.Text = "水印文字";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(37, 113);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 34;
            label5.Text = "水印文件";
            // 
            // inpWatermarkTxt
            // 
            inpWatermarkTxt.Location = new Point(105, 145);
            inpWatermarkTxt.Name = "inpWatermarkTxt";
            inpWatermarkTxt.Size = new Size(246, 43);
            inpWatermarkTxt.TabIndex = 35;
            inpWatermarkTxt.TextChanged += inpWatermarkTxt_TextChanged;
            // 
            // inpWatermarkImg
            // 
            inpWatermarkImg.AllowDrop = true;
            inpWatermarkImg.Location = new Point(105, 100);
            inpWatermarkImg.Name = "inpWatermarkImg";
            inpWatermarkImg.Size = new Size(285, 43);
            inpWatermarkImg.TabIndex = 35;
            inpWatermarkImg.TextChanged += input_TextChanged;
            inpWatermarkImg.DragDrop += input_DragDrop;
            inpWatermarkImg.DragEnter += input_DragEnter;
            inpWatermarkImg.MouseEnter += inp_MouseEnter;
            inpWatermarkImg.MouseLeave += inp_MouseLeave;
            // 
            // btnWatermarkImg
            // 
            btnWatermarkImg.BorderWidth = 1F;
            btnWatermarkImg.Location = new Point(399, 102);
            btnWatermarkImg.Name = "btnWatermarkImg";
            btnWatermarkImg.Size = new Size(75, 40);
            btnWatermarkImg.TabIndex = 36;
            btnWatermarkImg.Text = "...";
            btnWatermarkImg.Click += btnWatermarkImg_Click;
            // 
            // btnWatermarkSrc
            // 
            btnWatermarkSrc.BorderWidth = 1F;
            btnWatermarkSrc.Location = new Point(399, 11);
            btnWatermarkSrc.Name = "btnWatermarkSrc";
            btnWatermarkSrc.Size = new Size(75, 42);
            btnWatermarkSrc.TabIndex = 28;
            btnWatermarkSrc.Text = "...";
            btnWatermarkSrc.Click += btnWatermarkSrc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(37, 69);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 27;
            label1.Text = "保存目录";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(50, 25);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 26;
            label4.Text = "源文件";
            // 
            // inpWatermarkSrc
            // 
            inpWatermarkSrc.AllowDrop = true;
            inpWatermarkSrc.Location = new Point(105, 10);
            inpWatermarkSrc.Name = "inpWatermarkSrc";
            inpWatermarkSrc.Size = new Size(285, 43);
            inpWatermarkSrc.TabIndex = 29;
            inpWatermarkSrc.TextChanged += input_TextChanged;
            inpWatermarkSrc.DragDrop += input_DragDrop;
            inpWatermarkSrc.DragEnter += input_DragEnter;
            inpWatermarkSrc.MouseEnter += inp_MouseEnter;
            inpWatermarkSrc.MouseLeave += inp_MouseLeave;
            // 
            // progress1
            // 
            progress1.BackColor = Color.Transparent;
            progress1.ContainerControl = this;
            progress1.Location = new Point(39, 195);
            progress1.Name = "progress1";
            progress1.Size = new Size(435, 38);
            progress1.TabIndex = 33;
            progress1.Text = "progress1";
            // 
            // inpWatermarkDst
            // 
            inpWatermarkDst.AllowDrop = true;
            inpWatermarkDst.Location = new Point(105, 55);
            inpWatermarkDst.Name = "inpWatermarkDst";
            inpWatermarkDst.Size = new Size(285, 43);
            inpWatermarkDst.TabIndex = 30;
            inpWatermarkDst.TextChanged += input_TextChanged;
            inpWatermarkDst.DragDrop += input_DragDrop;
            inpWatermarkDst.DragEnter += input_DragEnter;
            inpWatermarkDst.MouseEnter += inp_MouseEnter;
            inpWatermarkDst.MouseLeave += inp_MouseLeave;
            // 
            // btnWatermark
            // 
            btnWatermark.BorderWidth = 1F;
            btnWatermark.DefaultBorderColor = SystemColors.ActiveBorder;
            btnWatermark.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnWatermark.Location = new Point(399, 148);
            btnWatermark.Name = "btnWatermark";
            btnWatermark.Size = new Size(75, 39);
            btnWatermark.TabIndex = 31;
            btnWatermark.Text = "水印";
            btnWatermark.Type = AntdUI.TTypeMini.Primary;
            btnWatermark.Click += btnWatermark_Click;
            // 
            // btnWatermarkDst
            // 
            btnWatermarkDst.BorderWidth = 1F;
            btnWatermarkDst.Location = new Point(399, 57);
            btnWatermarkDst.Name = "btnWatermarkDst";
            btnWatermarkDst.Size = new Size(75, 40);
            btnWatermarkDst.TabIndex = 32;
            btnWatermarkDst.Text = "...";
            btnWatermarkDst.Click += btnWatermarkDst_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(513, 304);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Pdf2Word";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            tabs1.ResumeLayout(false);
            tpConvert.ResumeLayout(false);
            tpConvert.PerformLayout();
            tpWatermark.ResumeLayout(false);
            tpWatermark.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.WindowBar windowBar1;
        private AntdUI.Panel panel1;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tpConvert;
        private AntdUI.TabPage tpWatermark;
        private AntdUI.Button btnConvertSrc;
        private Label lblDirection;
        private Label label3;
        private Label label2;
        private AntdUI.Input txtSrc;
        private AntdUI.Progress prgConvert;
        private AntdUI.Input txtDest;
        private AntdUI.Button btnConvert;
        private AntdUI.Button btnConvertDst;
        private AntdUI.Button btnWatermarkSrc;
        private Label label1;
        private Label label4;
        private AntdUI.Input inpWatermarkSrc;
        private AntdUI.Progress progress1;
        private AntdUI.Input inpWatermarkDst;
        private AntdUI.Button btnWatermark;
        private AntdUI.Button btnWatermarkDst;
        private Label label5;
        private AntdUI.Input inpWatermarkImg;
        private AntdUI.Button btnWatermarkImg;
        private Label label6;
        private AntdUI.Input inpWatermarkTxt;
        private AntdUI.Button btnSetting;
        private AntdUI.TooltipComponent tooltipComponent1;
        private AntdUI.Alert alert1;
        private AntdUI.Alert alert2;
    }
}

