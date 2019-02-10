using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Filter
    {
        public string Id { get; set; }
        public string Phrase { get; set; }
        public FilterContext[] Context { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public bool Irreversible { get; set; }
        public bool WholeWord { get; set; }
    }
}
