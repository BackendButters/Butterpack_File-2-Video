using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Filevideo.BL
{
    internal class Crypto
    {
        private static Crypto instance;
        private readonly string slt = "Ja, ja, ja";
        private byte[] sltByte;
        private readonly string IV = "3719372950247281";
        private Crypto()
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            sltByte = enc.GetBytes(slt);
        }
        internal byte[] encryptByteArray(byte[] input, string passPhrase)
        {
            List<byte> inputAppended = new List<byte>();
            inputAppended.AddRange(input);
            inputAppended.Add(69);
            input = inputAppended.ToArray();

            byte[] keyBytes = new Rfc2898DeriveBytes(passPhrase, Encoding.ASCII.GetBytes(slt)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(IV));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(input, 0, input.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return cipherTextBytes;
        }

        internal byte[] decryptByteArray(byte[] input, string passPhrase, int payloadLength)
        {
            byte[] keyBytes = new Rfc2898DeriveBytes(passPhrase, Encoding.ASCII.GetBytes(slt)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(IV));
            var memoryStream = new MemoryStream(input);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[input.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

            List<byte> result = new List<byte>();
            result.AddRange(plainTextBytes);
            for (int i = 0; i < result.Count; i++)
            { 
                if (result[result.Count - 1] != 69)
                    result.RemoveAt(result.Count - 1);
                else
                { 
                    result.RemoveAt(result.Count - 1);
                    break;
                }
            }
            return result.ToArray();
        
        }
        internal static Crypto GetInstance()
        {
            if (instance == null)
                instance = new Crypto();
            return instance;
        }
    }
}
