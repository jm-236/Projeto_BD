using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace patrimonioDB.Shared.Utils
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashByte = SHA256.HashData(passwordBytes);
            string hash = Convert.ToHexString(hashByte);
            return hash.ToLower();
        }
    }
}
