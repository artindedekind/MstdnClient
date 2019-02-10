using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("acct")]
        public string Acct { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("fields")]
        public AccountField[] Fields { get; set; }
    }
}
