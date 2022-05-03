using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing.DataInMemory
{
    public class MemoryHash
    {
        public byte[] HashDataInMemory(string massage)
        {
            var unicode = new UnicodeEncoding();
            var byteMessage = unicode.GetBytes(massage);

            var shaAlgorithm = new HMACSHA256();
            return shaAlgorithm.ComputeHash(byteMessage);
        }
    }
}
