using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Attachment
    {
        public string Id { get; set; }
        public AttachmentType Type { get; set; }
        public Uri Url { get; set; }
        public Uri RemoteUrl { get; set; }
        public Uri PreviewUrl { get; set; }
        public Uri TextUrl { get; set; }
        public string Description { get; set; }
    }
}
