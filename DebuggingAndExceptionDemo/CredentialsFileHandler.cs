//#define SIMULATE_ERROR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndExceptionDemo
{
    public class CredentialsFileHandler
    {
        public static void SaveCredentialsToFile(Credentials credentials)
        {
            string path = "D:\\Amdaris_Internship\\DebuggingAndExceptionDemo\\DebuggingAndExceptionDemo\\credentials.txt";
            StreamWriter writer = null;
            try
            {
 #if SIMULATE_ERROR

                writer = new StreamWriter(path, false);
 #endif
                writer = new StreamWriter(path);

                writer.WriteLine($"Email: {credentials.Email}");
                writer.WriteLine($"Password: {credentials.Password}");
                writer.WriteLine();
                Console.WriteLine("Credentials saved to file.");
            }
            catch (IOException ex)
            {
               throw;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }
}
