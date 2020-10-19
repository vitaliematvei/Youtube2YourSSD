using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube2YourSSD.Models
{
    public class YouTubeVideoQuality
    {
        public string VideoTitle { get; set; }
        public string Extension { get; set; }
        public string DownloadUrl { get; set; }
        public string VideoUrl { get; set; }
        public Size Dimension { get; set; }

        public override string ToString()
        {
            return Extension + " File " + Dimension.Width +
                                    "x" + Dimension.Height;
        }

        public void SetQuality(string  Extension, Size Dimension)
        {
            this.Extension = Extension;
            this.Dimension = Dimension;
        }
    }
}
