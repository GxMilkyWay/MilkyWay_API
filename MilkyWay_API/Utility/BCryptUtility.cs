using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCrypt.Net;

namespace MilkyWay_API.Utility
{
    public static class BCryptUtility
    {
        public static string Encryptpassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(12));
            return hashedPassword;
        }

        public static bool CheckPassword(string enteredPassword, string hashedPassword)
        {
            bool pwdHash = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
            return pwdHash;
        }  
    }
}