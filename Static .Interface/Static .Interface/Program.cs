using Static_.Interface.Models;
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
            Group group = new Group();
           
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

                    Student student = new Student();
                    Console.WriteLine("zehmet olmasa adi daxil edin");

                    student.Fullname =Console.ReadLine();
                    Console.WriteLine("zehmet olmasa bali daxil et");
                    student.Point=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("zehmet olmasa grup noresin daxil edin");
                    group.GroupNo =Console.ReadLine();
                    /* Bir Menu gəlməlidi və menu-da aşağıdakı əməliyyatlar olmalıdı:
        1. Show all students
        2. Get student by id
        3. Add student
        0. Quit*/
                    Console.WriteLine("1.Show all students\n" +
                           "2.Get student by id\n" +
                           "3.Add Student\n" +
                           "0.Quit");
                    int s=Convert.ToInt32(Console.ReadLine());  
                    do
                    {
                        if (s==1)
                        {
                            student.StudentIfo();

                        }
                        if (s==2)
                        { int idd= Convert.ToInt32(Console.ReadLine());
                            group.GetStudent(idd);
                        }
                        //if (s==3)
                        //{
                        //    group.AddStudent()

                        //}



                    } while (s> 3&& s<0);  



                }





            } while (secim!=1&& secim!=2);  
             
           
            

            

            

        }
    }
}
