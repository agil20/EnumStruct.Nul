using System;
using System.Text.RegularExpressions;

namespace Static_.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1) Bir user yaradılmalıdı bunun üçün console-dan user-in bütün dəyərləri götürülüb yeni bir user yaradılır.
2) Bir menu gəlir:
        1. Show info
        2. Create new group
            
*/
            User user = new User(); 
            Console.WriteLine("Zehmet omasa Fullname daxil edin");
            user.Fullname =Console.ReadLine();
            Console.WriteLine("Zehmet omasa Email daxil edin");

            user.Email = Console.ReadLine();
            Console.WriteLine("Zehmet omasa Password daxil edin");

            user.Password = Console.ReadLine();
            Console.WriteLine("1.Show Info\n" +
                "2.Create new group\n" +
                "secin");
            int secim=Convert.ToInt32(Console.ReadLine());
                        
            
            do
            {
                if (secim==1)
                {
                    user.ShowIfo();
                }
                else if(secim==2)
                 {

                    /*2 göndərildiyi halda console-dan group-un bütün məlumatları göndərilməli və yeni bir qrup
                     * obyekti yaradılmalıdır.*/
                




                }





            } while (secim!=1&& secim!=2);  
             
           
            

            

            

        }
    }
}
