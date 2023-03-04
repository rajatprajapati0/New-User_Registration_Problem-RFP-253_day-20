using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class Pattern
    {
        public static string FirstName = @"^[A-Z][a-z]{2,}$";
        public static string LastName = @"^[A-Z][a-z]{2,}$";
        public static string Email = @"^(?=[a-z])[a-z 0-9.+_-]{3,}[@][0-9a-z]{3,8}.(com|com.com|io|com.au|net|org)$";
        public static string MobileNumber = @"^[+]91[ ][6-9]{1}[0-9]{9}$";
        public static string PassWord = @"^((?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[!#@*+&%_-]))[a-z A-Z 0-9 !@#*+%&_-]{8,}$";




    }
    public class RegistrationForm
    {
        public bool Firstname(string userName)
        {
            Regex name = new Regex(Pattern.FirstName);
            return name.IsMatch(userName);
        }

        public bool LastName(string userLastName)
        {
            Regex lastname = new Regex(Pattern.LastName);
            return lastname.IsMatch(userLastName);
        }
        public bool Email(string userEmail)
        {
            Regex email = new Regex(Pattern.Email);
            return email.IsMatch(userEmail);
        }

        public bool MobileNumber(string userMobileNumber)
        {
            Regex number = new Regex(Pattern.MobileNumber);
            return number.IsMatch(userMobileNumber);

        }

        public bool Password(string userpassword)
        {
            Regex password = new Regex(Pattern.PassWord);
            return password.IsMatch(userpassword);

        }

    }
}
