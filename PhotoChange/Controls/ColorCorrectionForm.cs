using PhotoChange.Common;

namespace PhotoChange.Controls
{
    public partial class ColorCorrectionForm : Form
    {
        public ColorCorrectionForm(ColorCorrectionHelper colorCorrectionHelper, Bitmap image)
        {
            InitializeComponent();
            ColorCorrectionHelper = colorCorrectionHelper;
            OldImage = ImageHelper.ResizeImage(image, oldPictureBox.Width, oldPictureBox.Height);
            NewImage = new Bitmap(OldImage);
            oldPictureBox.Image = OldImage;
            newPictureBox.Image = NewImage;
        }

        /// <summary>
        /// Stores modified data for color correction.
        /// </summary>
        public ColorCorrectionHelper ColorCorrectionHelper
        {
            get => _colorCorrectionHelper;
            set => _colorCorrectionHelper = value;
        }

        /// <summary>
        /// Stores the original image color.
        /// </summary>
        public Bitmap OldImage
        {
            get => _oldImage;
            set
            {
                if (_oldImage != null && _oldImage != value)
                    _oldImage.Dispose();
                _oldImage = value;
            }
        }

        /// <summary>
        /// Stores a modified image color.
        /// </summary>
        public Bitmap NewImage
        {
            get => _newImage;
            set
            {
                if (_newImage != null && _newImage != value)
                    _newImage.Dispose();
                _newImage = value;
            }
        }

        private Bitmap _oldImage;
        private Bitmap _newImage;
        private ColorCorrectionHelper _colorCorrectionHelper;

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            brightnessValueTextBox.Text = brightnessTrackBar.Value.ToString();
            ColorCorrectionHelper.Brightness = brightnessTrackBar.Value;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void RBalanceTrackBar_Scroll(object sender, EventArgs e)
        {
            RBalanceValueTextBox.Text = RBalanceTrackBar.Value.ToString();
            ColorCorrectionHelper.R = RBalanceTrackBar.Value;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void GBalanceTrackBar_Scroll(object sender, EventArgs e)
        {
            GBalanceValueTextBox.Text = GBalanceTrackBar.Value.ToString();
            ColorCorrectionHelper.G = GBalanceTrackBar.Value;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void BBalanceTrackBar_Scroll(object sender, EventArgs e)
        {
            BBalanceValueTextBox.Text = BBalanceTrackBar.Value.ToString();
            ColorCorrectionHelper.B = BBalanceTrackBar.Value;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            contrastValueTextBox.Text = contrastTrackBar.Value.ToString();
            ColorCorrectionHelper.Contrast = contrastTrackBar.Value;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void GammaTrackBar_Scroll(object sender, EventArgs e)
        {
            gammaValueTextBox.Text = ((float)gammaTrackBar.Value / 100.0f).ToString();
            ColorCorrectionHelper.Gamma = gammaTrackBar.Value / 100;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void SaturationTrackBar_Scroll(object sender, EventArgs e)
        {
            saturationValueTextBox.Text = saturationTrackBar.Value.ToString();
            ColorCorrectionHelper.Saturation = saturationTrackBar.Value;
            ImageHelper.ColorCorrection(OldImage, NewImage, ColorCorrectionHelper.R, ColorCorrectionHelper.G, ColorCorrectionHelper.B, ColorCorrectionHelper.Brightness, ColorCorrectionHelper.Saturation, ColorCorrectionHelper.Contrast, ColorCorrectionHelper.Gamma);
            newPictureBox.Image = NewImage;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ColorCorrectionHelper.IsChanged = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
