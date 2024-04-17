using PhotoChange.Common;
using System.Windows.Forms;

namespace PhotoChange.Controls
{
    public partial class HistogramControl : UserControl
    {
        public Histogram? Histogram
        {
            get => _histogram;
            set
            {
                _histogram = value;
                LoadInterface();
            }
        }

        public Bitmap? RedImage { get; set; }

        public Bitmap? GreenImage { get; set; }

        public Bitmap? BlueImage { get; set; }

        public Bitmap? GrayImage { get; set; }

        public HistogramControl()
        {
            InitializeComponent();
        }

        private Histogram? _histogram;

        private void LoadInterface()
        {
            RedImage = new Bitmap(256, 100);
            GreenImage = new Bitmap(256, 100);
            BlueImage = new Bitmap(256, 100);
            GrayImage = new Bitmap(256, 100);

            for (int i = 0; i < 256; i++)
            {
                Graphics redGraphics = Graphics.FromImage(RedImage);
                Graphics greenGraphics = Graphics.FromImage(GreenImage);
                Graphics blueGraphics = Graphics.FromImage(BlueImage);
                Graphics grayGraphics = Graphics.FromImage(GrayImage);
                int normalizedHeightRed = (int)(((double)Histogram.BrightnessValuesRed[i] / Histogram.MaxBrightnessRed) * 100);
                int normalizedHeightGreen = (int)(((double)Histogram.BrightnessValuesGreen[i] / Histogram.MaxBrightnessGreen) * 100);
                int normalizedHeightBlue = (int)(((double)Histogram.BrightnessValuesBlue[i] / Histogram.MaxBrightnessBlue) * 100);
                int normalizedHeightGray = (int)(((double)Histogram.BrightnessValuesGray[i] / Histogram.MaxBrightnessGray) * 100);
                redGraphics.DrawLine(Pens.Red, i + 20, 100, i + 20, 100 - normalizedHeightRed);
                greenGraphics.DrawLine(Pens.Green, i + 20, 100, i + 20, 100 - normalizedHeightGreen);
                blueGraphics.DrawLine(Pens.Blue, i + 20, 100, i + 20, 100 - normalizedHeightBlue);
                grayGraphics.DrawLine(Pens.Black, i + 20, 100, i + 20, 100 - normalizedHeightGray);

                totalPixelsNumbersLabel.Text = Histogram.MaxPixels.ToString();
                histogramPictureBox.Image = GrayImage;
                grayCheckBox.Checked = true;
            }
        }

        private void RedCheckBox_Click(object sender, EventArgs e)
        {
            if (redCheckBox.Checked)
            {
                histogramPictureBox.Image = RedImage;
                greenCheckBox.Enabled = false;
                blueCheckBox.Enabled = false;
                grayCheckBox.Enabled = false;
            }
            else
            {
                histogramPictureBox.Image = GrayImage;
                greenCheckBox.Enabled = true;
                blueCheckBox.Enabled = true;
                grayCheckBox.Enabled = true;
                grayCheckBox.Checked = true;
            }
        }

        private void GreenCheckBox_Click(object sender, EventArgs e)
        {
            if (greenCheckBox.Checked)
            {
                histogramPictureBox.Image = GreenImage;
                redCheckBox.Enabled = false;
                blueCheckBox.Enabled = false;
                grayCheckBox.Enabled = false;
            }
            else
            {
                histogramPictureBox.Image = GrayImage;
                redCheckBox.Enabled = true;
                blueCheckBox.Enabled = true;
                grayCheckBox.Enabled = true;
                grayCheckBox.Checked = true;
            }
        }

        private void BlueCheckBox_Click(object sender, EventArgs e)
        {
            if (blueCheckBox.Checked)
            {
                histogramPictureBox.Image = BlueImage;
                redCheckBox.Enabled = false;
                greenCheckBox.Enabled = false;
                grayCheckBox.Enabled = false;
            }
            else
            {
                histogramPictureBox.Image = GrayImage;
                redCheckBox.Enabled = true;
                greenCheckBox.Enabled = true;
                grayCheckBox.Enabled = true;
                grayCheckBox.Checked = true;
            }
        }

        private void GrayCheckBox_Click(object sender, EventArgs e)
        {
            if (grayCheckBox.Checked)
            {
                histogramPictureBox.Image = GrayImage;
                redCheckBox.Enabled = true;
                greenCheckBox.Enabled = true;
                blueCheckBox.Enabled = true;
            }
            else
            {
                histogramPictureBox.Image = GrayImage;
                redCheckBox.Enabled = true;
                greenCheckBox.Enabled = true;
                blueCheckBox.Enabled = true;
            }
        }

        private void HistogramPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            indexNumberLabel.Text = e.Location.X.ToString();
            grayNumbersLabel.Text = Histogram.BrightnessValuesGray[e.Location.X].ToString();
            redNumbersLabel.Text = Histogram.BrightnessValuesRed[e.Location.X].ToString();
            greenNumbersLabel.Text = Histogram.BrightnessValuesGreen[e.Location.X].ToString();
            blueNumbersLabel.Text = Histogram.BrightnessValuesBlue[e.Location.X].ToString();
        }
    }
}
