using System;
using Model;

namespace Helper
{
    public class UserNameBuilder
    {
        public static void GenerateUserName(User user)
        {            
            Random rand = new Random();
            int randomValue = rand.Next(999999);
            var userName = string.Format("{0}{1}{2}{3}",user.FirstName,user.LastName, user.Email.Split('@')[0]??"", randomValue);
            user.UserName = userName;
        }
    }
}