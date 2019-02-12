using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
        private async Task<T> GetHttpAsync<T>(string requestUri, QueryItemCollection query)
        {
            var uri = new Uri(BaseUrl, requestUri + query.ToQuery());

            var response = await Client.GetAsync(uri);
            if (!response.IsSuccessStatusCode) { return default(T); }
            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonString, new IsoDateTimeConverter());
        }
    }
}
