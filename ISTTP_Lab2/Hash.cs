using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISTTP_Lab2
{
    class HashGetter
    {
        public HashGetter()
        {

        }
        public byte[] getHash(string password, byte[] salt)
        {
            int numberOfIterations = 10000;
            byte[] hash = new Rfc2898DeriveBytes(password, salt, numberOfIterations).GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return hashBytes;
        }
        public byte[] getSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }
    }
}
