using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class AccountToken
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public string Scope { get; set; }
        public int CreatedAt { get; set; }
    }
}
