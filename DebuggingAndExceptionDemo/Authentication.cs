using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndExceptionDemo
{
    public class Authentication
    {

        public bool Authenticate(Credentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.Email))
            {
                throw new AuthenticationException("Email cannot be empty.");
            }
            if (credentials.Password.Length < 6)
            {
                throw new AuthenticationException("Password must be at least 6 characters long.");
            }

            return true;
        }
    }
}
