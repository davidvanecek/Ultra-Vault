using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UltraVault
{
    class FileManager
    {
        public static void SaveToFile(string fileName, string data)
        {
            try
            {
                // Create or overwrite the file with the given name
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Write the data to the file
                    writer.Write(data);
                }
                Console.WriteLine("Data saved to " + fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // Function to load data from a text file
        public static string LoadFromFile(string fileName)
        {
            string data = "";
            try
            {
                // Check if the file exists
                if (File.Exists(fileName))
                {
                    // Read the data from the file
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        data = reader.ReadToEnd();
                    }
                    Console.WriteLine("Data loaded from " + fileName);
                }
                else
                {
                    Console.WriteLine("File not found: " + fileName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return data;
        }
    }
}
