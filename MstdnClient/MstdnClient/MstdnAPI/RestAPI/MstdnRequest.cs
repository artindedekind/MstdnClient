using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MstdnAPI
{
    public partial class MstdnRequest
    {
        private static HttpClient Client { get; set; } = new HttpClient();

        public Uri BaseUrl { get; set; }
    }
}
