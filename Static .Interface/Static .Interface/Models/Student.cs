using System;

namespace Static_.Interface.Models
{
    public class Student
    {
        public string Fullname { get; set; }

        private static int _id;
        public int Id
        {
            get { return _id; }
            private set { _id = 1; }
        }
              public int Point { get; set; }
        public Student(string fullname, int point)
        {
            Fullname = fullname;
            Point = point;

        }




        public void StudentIfo()
        {
            Console.WriteLine($"Id: {Id}\n" +
                $"Fullname: {Fullname}\n" +
                $"Point: {Point}");
        }


    }

}



