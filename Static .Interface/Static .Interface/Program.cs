using Static_.Interface.Models;
using System;
using System.Text.RegularExpressions;

namespace Static_.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Zehmet omasa Fullname daxil edin");
          string  Fullname = Console.ReadLine();

            Console.WriteLine("Zehmet omasa Email daxil edin");

            string Email = Console.ReadLine();
            Console.WriteLine("Zehmet omasa Password daxil edin");

             string Password = Console.ReadLine();
            User user = new User(Email,Password);
            user.Fullname = Fullname;
         
            
            int secim;
                        
            
            do
            {
                Console.WriteLine("1.Show Info\n" +
                   "2.Create new group\n" +
                   "secin");
                secim=Convert.ToInt32(Console.ReadLine());
                if (secim==1)
                {
                    user.ShowIfo();
                }
                else if(secim==2)
                 {

                    Console.WriteLine("zehmet olmasa grup no daxil edin");
                    string groupno = Console.ReadLine();
                    Console.WriteLine("Zehmet olmasa limiti daaxil edin");
                    int Stuentlimit = Convert.ToInt32(Console.ReadLine());
                    Group group = new Group(groupno, Stuentlimit);
                    
                    int s;
                    do
                    {
                        Console.WriteLine("1.Show all students\n" +
                          "2.Get student by id\n" +
                          "3.Add Student\n" +
                          "0.Quit");
                        s = Convert.ToInt32(Console.ReadLine());
                        if (s==1)
                        {   
                            Console.WriteLine("Zehmet olmassa adi daxil edin");
                            student.Fullname=Console.ReadLine();
                            Console.WriteLine("zehmet olmasa pointi daxil edin");
                            student.Point=Convert.ToInt32(Console.ReadLine());
                       





                        }
                        if (s==2)

                        {  /*2 göndərilsə console-dan bir id istənməlidir və həmin id-li Student obyekti tapılıb onun
                            * bütün məlumatları console-a yazdırılmalıdır*/
                            Console.WriteLine("Zehmet olmasa Id daxxil edin");
                            int id=Convert.ToInt32(Console.ReadLine());
                          
                            if (id==student.Id)
                            {
                                student.StudentIfo();
                            }
                            else
                            {
                                Console.WriteLine("bele bir idli student yoxdur");
                            }

                        }
                        if (s==3)
                        {/* 3 göndərilsə console-dan Student-in bütün məlumatları istənib 
                    * yeni bir Student yaranmalıdır, 0 göndərilərsə program sonlanmalıdır*/
                          
                            student.Fullname = Console.ReadLine();
                            student.Point=Convert.ToInt32(Console.ReadLine());

                          


                        }
                        if (s==0)
                        {
                            return;
                        }



                    } while (true);  



                }





            } while (true);  
             
           
            

            

            

        }
    }
}
