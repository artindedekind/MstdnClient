using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Emoji
    {
        public string Shortcode { get; set; }
        public Uri StaticUrl { get; set; }
        public Uri Url { get; set; }
        public bool VisibleInPicker { get; set; }
    }
}
