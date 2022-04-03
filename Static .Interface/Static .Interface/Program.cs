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
            Console.WriteLine("Zehmet omasa Fullname daxil edin");
          string  Fullname = Console.ReadLine();

            Console.WriteLine("Zehmet omasa Email daxil edin");

            string Email = Console.ReadLine();
            Console.WriteLine("Zehmet omasa Password daxil edin");

             string Password = Console.ReadLine();
            User user = new User(Email,Password);
            user.Fullname = Fullname;
         
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


                    /* Bir Menu gəlməlidi və menu-da aşağıdakı əməliyyatlar olmalıdı:
        1. Show all students
        2. Get student by id
        3. Add student
        0. Quit*/
                    Console.WriteLine("zehmet olmasa grup no daxil edin");
                    string groupno = Console.ReadLine();
                    Console.WriteLine("Zehmet olmasa limiti daaxil edin");
                    int Stuentlimit = Convert.ToInt32(Console.ReadLine());
                    Group group = new Group(groupno, Stuentlimit);
                    Console.WriteLine("1.Show all students\n" +
                           "2.Get student by id\n" +
                           "3.Add Student\n" +
                           "0.Quit");
                    int s=Convert.ToInt32(Console.ReadLine());  
                    do
                    {
                        if (s==1)
                        {
                          Student student=new Student();
                            student.StudentIfo();

                        }
                        if (s==2)

                        {  /*2 göndərilsə console-dan bir id istənməlidir və həmin id-li Student obyekti tapılıb onun
                            * bütün məlumatları console-a yazdırılmalıdır*/
                            Console.WriteLine("zehmet olmasa Id daxil edin");
                            int idd=Convert.ToInt32(Console.ReadLine());
                            group.GetStudent(idd);

                        }
                        if (s==3)
                        {/* 3 göndərilsə console-dan Student-in bütün məlumatları istənib 
                    * yeni bir Student yaranmalıdır, 0 göndərilərsə program sonlanmalıdır*/
                            Student student = new Student();
                            student.Fullname = Console.ReadLine();
                            student.Point=Convert.ToInt32(Console.ReadLine());

                            Group[] groups = new Group[0];
                           groups[0].AddStudent(student);


                        }
                        if (s==0)
                        {
                            return;
                        }



                    } while (s> 3&& s<0);  



                }





            } while (secim!=1&& secim!=2);  
             
           
            

            

            

        }
    }
}
