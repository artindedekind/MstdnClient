using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Status
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("url")]
        public Uri Url { get; set; }
        [JsonProperty("account")]
        public Account Account { get; set; }
        [JsonProperty("in_reply_to_id")]
        public string InReplyToId { get; set; }
        [JsonProperty("in_reply_to_account_id")]
        public string InReplyToAccountId { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("emojis")]
        public Emoji[] Emojis { get; set; }
        [JsonProperty("replies_count")]
        public int RepliesCount { get; set; }
        [JsonProperty("reblogs_count")]
        public int ReblogsCount { get; set; }
        [JsonProperty("favourites_count")]
        public int FavouritesCount { get; set; }
        [JsonProperty("reblogged")]
        public bool? Reblogged { get; set; }
        [JsonProperty("favourited")]
        public bool? Favourited { get; set; }
        [JsonProperty("muted")]
        public bool? Muted { get; set; }
        [JsonProperty("sensitive")]
        public bool Sensitive { get; set; }
        [JsonProperty("spoiler_text")]
        public string SpoilerText { get; set; }
        [JsonProperty("visibility")]
        public StatusVisibility Visibility { get; set; }
        //[JsonProperty("media_attachments")]
        public Attachment[] MediaAttachments { get; set; }
        public Mention[] Mentions { get; set; }
        public Tag[] Tags { get; set; }
        public Application Application { get; set; }
        public string Language { get; set; }
        public bool? Pinned { get; set; }
    }
}
