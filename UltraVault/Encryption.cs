﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto.AES;
namespace UltraVault
{
    class Encryption
    {
        public static string EncryptString(string password)
        {
            using (AES aes = new AES("SHortKEy"))
            {
                return aes.Encrypt(password);
            }
        }
        public static string DecryptString(string password)
        {
            using (AES aes = new AES("SHortKEy"))
            {
                return aes.Decrypt(password);
            }
        }
    }
}
