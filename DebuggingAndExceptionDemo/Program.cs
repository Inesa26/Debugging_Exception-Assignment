using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndExceptionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Credentials credentials = new Credentials();

            Console.Write("Enter your email: ");
            credentials.Email = Console.ReadLine();

            Console.Write("Enter your password: ");
            credentials.Password = Console.ReadLine();

            Authentication authentication = new Authentication();
            try
            {
                authentication.Authenticate(credentials);
                CredentialsFileHandler.SaveCredentialsToFile(credentials);
            }
            catch (AuthenticationException ex)
            {
                Console.WriteLine($"Authentication failed: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while saving credentials: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
