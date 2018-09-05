using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;

namespace BasicAuthenticationAPI
{
    public class UserSecurity
    {

        //Login method return true or false based on username and password matching cases
        public static bool Login(string username, string password)
        {
            using (mmb_dbEntities entities = new mmb_dbEntities())
            {
                return entities.Users.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    user.Password == password);
            }
        }

    }
}