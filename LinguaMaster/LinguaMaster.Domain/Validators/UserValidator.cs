using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Validators
{
    public static class UserValidator
    {
        public static List<string> Validate(string username, string email)
        {
            var errors = new List<string>();

            if (username == null || username.Trim() == "")
            {
                errors.Add("Username is required!");
            }

            if (email == null || email.Trim() == "")
            {
                errors.Add("Email is required!");
            }
            else
            {
                if (!email.Contains("@"))
                {
                    errors.Add("Email must contain '@'.");
                }
                else
                {
                    if (email.StartsWith("@") || email.EndsWith("@"))
                    {
                        errors.Add("Email cannot start or end with '@'.");
                    }
                }
            }

            return errors;
        }

    }
}
