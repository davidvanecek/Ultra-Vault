using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesla
{
    class PasswordGenerator
    {
        static string GeneratePassword(int length, bool useNumbers, bool useLetters, bool useSymbols)
        {
            string characters = "";
            if (useNumbers)
                characters += "0123456789";
            if (useLetters)
                characters += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (useSymbols)
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
