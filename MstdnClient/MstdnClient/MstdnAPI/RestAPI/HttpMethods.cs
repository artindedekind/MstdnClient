using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MstdnAPI
{
    public partial class MstdnRequest
    {
        private async Task<T> GetHttpAsync<T>(Uri requestUri, NameValueCollection query)
        {
            var response = await Client.GetAsync(requestUri);
            if (!response.IsSuccessStatusCode) { return default(T); }
            return await response.Content.ReadAsAsync<T>();
        }
    }
}
