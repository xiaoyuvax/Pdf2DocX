using AntdUI;

namespace PDFConverter
{
    public partial class MainForm : Form
    {
        private WatermarkSetting wmSetting;

        public MainForm()
        {
            InitializeComponent();
            DocXMan.UpdateProgress = SpireDocMan.UpdateProgress = i =>
            {
                prgConvert.Value = i;
                Application.DoEvents();
            };

            ITextMan.WaterarkProgress = i =>
            {
                progress1.Value = i;
                Application.DoEvents();
            };
        }

        private void alert1_Click(object sender, EventArgs e)
        {
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;
            Cursor = Cursors.WaitCursor;
            prgConvert.Value = 0.01f;
            if (txtSrc.Text == "" || txtDest.Text == "") Notification.error(this, "错误", "未选择源文件或目标目录！");
            else
            {
                if (Directory.Exists(txtDest.Text))
                {
                    string src = txtSrc.Text;
                    string targetPath = Path.Combine(txtDest.Text, Path.GetFileNameWithoutExtension(src));
                    var ext = Path.GetExtension(src);
                    if (ext == ".pdf")
                    {
                        lblDirection.Text = "PDF转DOCX，开始转换……";
                        Application.DoEvents();
                        if (SpireDocMan.PDF2Word(src, targetPath + ".docx")) Notification.success(this, "输出", lblDirection.Text = "转换完成！");
                    }
                    else if (ext == ".doc" || ext == ".docx")
                    {
                        lblDirection.Text = $"{ext.ToUpper()}转PDF(限3页)，开始转换……";
                        Application.DoEvents();
                        if (SpireDocMan.Word2PDF(src, targetPath + ".pdf")) Notification.success(this, "输出", lblDirection.Text = "转换完成！");
                    }
                    prgConvert.Value = 1;
                }
                else Notification.error(this, "参数错误", "保存目录路径非法！");
            }
            Cursor = Cursors.Default;
            btnConvert.Enabled = true;
        }

        private void btnConvertDst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            fbd.ShowDialog();

            if (fbd.SelectedPath == null) Notification.info(this, "输入", "请选择目录！");
            else
            {
                string src = fbd.SelectedPath;
                txtDest.Text = src;
                prgConvert.Value = 0;
            }
        }

        private void btnConvertSrc_Click(object sender, EventArgs e)
        {
            lblDirection.Text = "...";
            OpenFileDialog openFile = new()
            {
                Filter = "PDF文件|*.pdf|Word文件|*.doc;*.docx",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            };
            openFile.ShowDialog();
            if (File.Exists(openFile.FileName))
            {
                string src = openFile.FileName;
                txtSrc.Text = src;
                txtDest.Text = Path.GetDirectoryName(src);
                prgConvert.Value = 0;
                var ext = Path.GetExtension(src);
                if (ext == ".pdf") lblDirection.Text = "PDF转DOCX";
                else if (ext == ".doc" || ext == ".docx") lblDirection.Text = $"{ext.ToUpper()}转PDF(限3页)";
            }
            else Notification.warn(this, "输入", "请选择有效文件！");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            wmSetting = new WatermarkSetting(ITextMan.WaterMarkSize,
                                             ITextMan.WaterMarkFontSize,
                                             ITextMan.WaterMarkAngle,
                                             ITextMan.WaterMarkAlpha,
                                             ITextMan.WaterMarkColor,
                                             ITextMan.WaterMarkPrintable);

            var st = Drawer.open(this, wmSetting, TAlignMini.Right);
            st.FormClosed += (object sender, FormClosedEventArgs e) =>
            {
                ITextMan.WaterMarkSize = wmSetting.WaterMarkSize;
                ITextMan.WaterMarkFontSize = wmSetting.WaterMarkFontSize;
                ITextMan.WaterMarkAlpha = wmSetting.WaterMarkAlpha;
                ITextMan.WaterMarkAngle = wmSetting.WaterMarkFontAngle;
                ITextMan.WaterMarkColor = wmSetting.WaterMarkColor;
                ITextMan.WaterMarkPrintable = wmSetting.WaterMarkPrintable;
            };
        }

        private void btnWatermark_Click(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;
            Cursor = Cursors.WaitCursor;
            progress1.Value = 0.01f;

            if (File.Exists(inpWatermarkSrc.Text) && Directory.Exists(inpWatermarkDst.Text) && (!string.IsNullOrEmpty(inpWatermarkTxt.Text) || File.Exists(inpWatermarkImg.Text)))
            {
                var outputFile = Path.Combine(inpWatermarkDst.Text, "水印_" + Path.GetFileName(inpWatermarkSrc.Text));
                if (ITextMan.AddWaterMark(inpWatermarkSrc.Text, outputFile, inpWatermarkImg.Text, inpWatermarkTxt.Text))
                    Notification.success(this, "输入", $"操作成功，水印副本已保存到：{outputFile}");
                else Notification.error(this, "输入", "水印添加失败！");
            }
            else Notification.error(this, "输入", "输入参数不正确！");
            Cursor = Cursors.Default;
            btnConvert.Enabled = true;
        }

        private void btnWatermarkDst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            fbd.ShowDialog();

            if (Directory.Exists(fbd.SelectedPath))
            {
                inpWatermarkDst.Text = fbd.SelectedPath;
                progress1.Value = 0;
            }
            else Notification.warn(this, "输入", "请选择有效目录！");
        }

        private void btnWatermarkImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                Filter = "PNG文件|*.png|JPG文件|*.jpg;*.jpeg|其他图形格式|*.bmp;*.gif;*.webp|任何类型|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            };
            openFile.ShowDialog();
            if (File.Exists(openFile.FileName))
            {
                inpWatermarkImg.Text = openFile.FileName;
                progress1.Value = 0;
            }
            else Notification.warn(this, "输入", "请选择有效图形文件！");
        }

        private void btnWatermarkSrc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                Filter = "PDF文件|*.pdf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            };
            openFile.ShowDialog();
            if (File.Exists(openFile.FileName))
            {
                string src = openFile.FileName;
                inpWatermarkSrc.Text = src;
                inpWatermarkDst.Text = Path.GetDirectoryName(src);
                progress1.Value = 0;
            }
            else Notification.warn(this, "输入", "请选择有效文件！");
        }

        private void inp_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Input inp)
            {
                if (inp.Parent == tpConvert) alert1.Show();
                else alert2.Show();
            }
        }

        private void inp_MouseLeave(object sender, EventArgs e)
        {
            alert1.Hide();
            alert2.Hide();
        }

        private void input_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is Input inp)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files?.Length > 0)
                {
                    inp.Text = files[0];
                    if (inp.Name == "txtSrc") txtDest.Text = Path.GetDirectoryName(files[0]);
                    else if (inp.Name == "inpWatermarkSrc") inpWatermarkDst.Text = Path.GetDirectoryName(files[0]);
                }
            }
        }

        private void input_DragEnter(object sender, DragEventArgs e)
        {
            // 如果拖放的数据是文件，则设置为有效
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (sender is Input inp) tooltipComponent1.SetTip(inp, inp.Text);
        }

        private void inpWatermarkTxt_TextChanged(object sender, EventArgs e)
        {
            inpWatermarkImg.Enabled = btnWatermarkImg.Enabled = string.IsNullOrEmpty(inpWatermarkTxt.Text);
            tpWatermark.BackgroundImage = ITextMan.GenerateWaterMarkBitmap(inpWatermarkTxt.Text);
            tooltipComponent1.SetTip(inpWatermarkTxt, inpWatermarkTxt.Text);
            progress1.Value = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 0;
        }

        private void tabs1_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
        }

        private void tpWatermark_Click(object sender, EventArgs e)
        {
        }

        private void txtSrc_DragLeave(object sender, EventArgs e)
        {
        }
    }
}