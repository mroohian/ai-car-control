using System;
using System.Security.Cryptography;

namespace AICore.Utilities
{
    public class CryptoRandom
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public double RandomValue { get; set; }

        public CryptoRandom()
        {
            var randomNumber = new byte[8];
            rngCsp.GetBytes(randomNumber);
            //  bit-shift 11 and 53 based on double's mantissa bits
            var ul = BitConverter.ToUInt64(randomNumber, 0) / (1 << 11);
            var random = ul / (Double)(1UL << 53);

            RandomValue = random * 2.0 - 1.0;
        }

    }
}