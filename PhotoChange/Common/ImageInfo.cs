using PhotoChange.Renderer;
using System.Windows.Forms;

namespace PhotoChange.Common
{
    /// <summary>
    /// Contains image information.
    /// </summary>
    public class ImageInfo
    {
        public string FileName { get; set; } 
        public string Directory { get; set; }
        public string FullPath { get; set; }
        public string ImageSize { get; set; }
        public string FileSize { get; set; }
        public string DateTime { get; set; }

        public ImageInfo()
        {
            FileName = string.Empty;
            Directory = string.Empty;
            FullPath = string.Empty;
            ImageSize = string.Empty;
            FileSize = string.Empty;
            DateTime = string.Empty;
        }

        public ImageInfo(ImageRenderer imageRenderer)
        {
            FileInfo file = new FileInfo(imageRenderer.Path);

            FileName = file.Name;
            Directory = imageRenderer.Path.Substring(0, imageRenderer.Path.LastIndexOf('\\'));
            FullPath = file.FullName;
            ImageSize = imageRenderer.OriginalImage.Width.ToString() + " x " + imageRenderer.OriginalImage.Height.ToString() + " pxl";
            FileSize = file.Length.ToString() + " Bytes";
            DateTime = file.CreationTime.ToString();
        }
    }
}
