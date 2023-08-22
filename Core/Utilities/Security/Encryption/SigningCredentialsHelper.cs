using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey secretKey)
        {
            return new SigningCredentials(secretKey, algorithm: SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
