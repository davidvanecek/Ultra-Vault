using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraVault
{
    class PasswordGenerator
    {
        public static string GeneratePassword(int length, int preference)
        {
            string characters = "";
            if (preference==0)
                characters += "0123456789";
            if (preference==1)
                characters += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (preference==2)
                characters += "!@#$%^&*()-_+=<>?";

            if (string.IsNullOrEmpty(characters))
                return "Please select at least one character type for the password.";

            Random random = new Random();
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = characters[random.Next(characters.Length)];
            }

            return new string(password);
        }
    }
}
