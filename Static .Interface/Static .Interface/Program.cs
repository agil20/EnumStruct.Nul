using System;

namespace Static_.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("emaili daxil edin");

            string email=Console.ReadLine();
            Console.WriteLine("passwordu daxil edin");
            string password=Console.ReadLine();

            User user = new User(email, password);
            Console.WriteLine("FullName daxil edin");
            user.Fullname =Console.ReadLine();
            user.ShowIfo();
           


        }
    }
}
