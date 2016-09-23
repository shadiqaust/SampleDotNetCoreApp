using System;
using Model;
using Helper;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            user.FirstName="Md";
            user.LastName="Rahman";
            user.Email = "Shadiq@gmail.com";

            Console.WriteLine("Please Enter your FirstName");
            user.FirstName= Console.In.ReadLine();

            Console.WriteLine("Please Enter your LastName");
            user.LastName= Console.In.ReadLine();

            Console.WriteLine("Please Enter your Email");
            user.Email= Console.In.ReadLine();

            UserNameBuilder.GenerateUserName(user);
            Console.WriteLine("Hello "+ user.UserName + "!");           
        }
    }
    
}
