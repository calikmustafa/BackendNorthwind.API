using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
   public class AccessToken
    {
        public string Access { get; set; }
        public DateTime Expiration { get; set; }
    }
}
