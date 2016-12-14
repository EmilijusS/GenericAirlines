using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericAirlines
{
    public static class ExtensionMethods
    {
        public static string Encrypt(this String str)
        {
            HashAlgorithm sha = SHA256.Create();
            return Convert.ToBase64String(sha.ComputeHash(Encoding.Default.GetBytes(str)));
        }
    }
}
