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
        public async Task<Status[]> GetPublicTimelineAsync(bool? local = null, bool? onlyMedia = null, string maxId = null, string sinceId = null, string minId = null, int limit = 20)
        {
            var query = new QueryItemCollection();
            query.Add("local", local);
            query.Add("onlyMedia", onlyMedia);
            query.Add("max_id", maxId);
            query.Add("since_id", sinceId);
            query.Add("min_id", minId);
            query.Add("limit", limit);

            return await GetHttpAsync<Status[]>("/api/v1/timelines/public", query);
        }
    }
}
