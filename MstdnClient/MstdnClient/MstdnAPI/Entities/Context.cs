using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Context
    {
        public Status[] Ancestors { get; set; }
        public Status[] Descendants { get; set; }
    }
}
