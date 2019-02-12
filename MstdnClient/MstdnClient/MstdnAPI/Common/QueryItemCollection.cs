using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MstdnAPI
{
    class QueryItemCollection
    {
        Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        internal void Add(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key) || value == null) { return; }

            if (Data.ContainsKey(key))
            {
                Data[key] = value.ToString();
                return;
            }
            Data.Add(key, value.ToString());
        }

        internal string ToQuery()
        {
            var queryString = Data.Where(x => x.Value != null).Select(x => $"{x.Key}={x.Value}");
            return @"?" + string.Join(@"&", queryString);
        }
    }
}
