using System;

namespace Static_.Interface.Models
{
    public class Student : User
    {    //eyni propertiler lazim olduguna gore miras aliram..
        public Student(string fullname,int point,int Id)
        {Fullname = fullname;
            Point = point;

        }

        public int Point { get; set; }
      

        public void StudentIfo()
        {
            Console.WriteLine($"Id: {Id}\n" +
                $"Fullname: {Fullname}\n" +
                $"Point: {Point}");
        }
        //public Student()
        //{

        //}
   
    }

}



