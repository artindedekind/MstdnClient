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
        public async Task<Status[]> GetHomeTimelineAsync(string maxId = null, string sinceId = null, string minId = null, int limit = 20)
        {
            var query = new NameValueCollection
            {
                { "max_id", maxId },
                { "since_id", sinceId },
                { "min_id", minId },
                { "limit", limit.ToString() }
            };
            var response = await Client.GetAsync($"api/v1/timelines/home");

            if (!response.IsSuccessStatusCode) { return null; }
            return await response.Content.ReadAsAsync<Status[]>();
        }
    }
}
