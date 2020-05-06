using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Digests;

namespace BruteForceAttack
{
    class EncodeUtilities
    {
        public static string base64Encode(string plaintext)
        {
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string base64Decode(string base64EncodedData)
        {
            byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string md5(string plaintext)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] input = System.Text.Encoding.ASCII.GetBytes(plaintext);
                byte[] hash = md5.ComputeHash(input);

                StringBuilder stringBuilder = new StringBuilder();

                foreach (byte b in hash)
                {
                    stringBuilder.Append(b.ToString("X2"));
                }
                return stringBuilder.ToString();
            }
        }

        public static string sha1(string plaintext)
        {
            using (SHA1 sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                StringBuilder stringBuilder = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // X2 = uppercase, x2 = lowercase
                    stringBuilder.Append(b.ToString("X2"));
                }
                return stringBuilder.ToString();
            }
        }

        public static string ripemd160(string plaintext)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (RIPEMD160 ripemd160 = RIPEMD160.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = ripemd160.ComputeHash(enc.GetBytes(plaintext));

                foreach (Byte b in result)
                    stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public static string sha256(string plaintext)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (SHA256 sha256 = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = sha256.ComputeHash(enc.GetBytes(plaintext));

                foreach (Byte b in result)
                    stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public static string sha384(string plaintext)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (SHA384 sha384 = SHA384.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = sha384.ComputeHash(enc.GetBytes(plaintext));

                foreach (Byte b in result)
                    stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public static string sha512(string plaintext)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (SHA512 sha512 = SHA512.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = sha512.ComputeHash(enc.GetBytes(plaintext));

                foreach (Byte b in result)
                    stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }
    }
}
