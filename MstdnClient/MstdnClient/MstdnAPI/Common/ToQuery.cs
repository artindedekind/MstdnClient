using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace MstdnAPI
{
    internal static partial class Common
    {
        /// <summary>
        /// 文字列のコレクションをクエリ文字列に変換
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        internal static string ToQuery(this Dictionary<string, string> query)
        {
            if (query == null) { return ""; }
            var queryString = query.Where(x => x.Value != null).Select(x => $"{x.Key}={x.Value}");
            return @"?" + string.Join(@"&", queryString);
        }
    }
}
