using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Instance
    {
        public string Uri { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Version { get; set; }
        public Uri Thumbnail { get; set; }
        public InstanceURLs Urls { get; set; }
        public InstanceStats Stats { get; set; }
        public string[] Languages { get; set; }
        public Account ContractAccount { get; set; }
    }
}
