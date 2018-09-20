using System;
using System.Security.Cryptography;

namespace PI.Utilities
{
    public static class KeyGenerator
    {

        /// <summary>
        /// Generates a unique key 
        /// </summary>
        /// <param name="keySize">A key size to build the key from</param>
        /// <returns>The build key</returns>
        public static string Generate(int keySize = 16)
        {
            //set random key
            var bytes = new byte[keySize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}
