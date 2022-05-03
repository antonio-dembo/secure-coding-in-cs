using Hashing.DataInMemory;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string massage = "Hello, World";
            byte[] digest = new MemoryHash().HashDataInMemory(massage);

            foreach (byte b in digest)
            {
                Console.Write("{0:x}", b);
            }

            //Console.WriteLine(digest.Length);

        }
    }
}
