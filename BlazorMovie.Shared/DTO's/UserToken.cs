using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovie.Shared.DTO_s
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
