using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class AccountField
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("verified_at")]
        public DateTime? VerifiedAt { get; set; }
    }
}
