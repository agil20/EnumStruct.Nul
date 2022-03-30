using System;

namespace Static_.Interface.Models
{
    internal class Group : Student
    { /* 
Group class
- GroupNo
- StudentLimit - qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.
- Students - Student tipindən bir array-dir özündə student obyektləri saxlayacaq və private olacaq.
- CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə true/false dəyərləri qaytarır. 
       */
        public string GroupNo { get; set; }


        public Group(string fullname, int point, string email, string password) : base(fullname, point, email, password)
        {
        }
        private int _studentLimit;
        public int StudentLimit
        {
            get
            {

                return _studentLimit;
            }
            set
            {
                if (value > 5 && value <= 18)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.");
                }
            }
        }
        private Student[] Students = new Student[0];
        /*- CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə
         * true/false dəyərləri qaytarır. */
        public bool CheckGroupNo(string groupNo)
        { /*2 böyük hərf əvvəldə və 3 rəqəmdən ibarət olmalıdır*/
            bool result = false;
            int a = 0;
            bool resul1 = Char.IsUpper(groupNo[0]);
            bool resul2 = Char.IsUpper(groupNo[1]);
            for (int i = 0; i < groupNo.Length; i++)
            {
                result = char.IsNumber(groupNo[i]);
                if (result && resul1 && resul2)
                {
                    if (a >= 3)
                    {
                        result = true;
                    }
                }


            }
            return result;


        }
        /*
         - AddStudent() - parametr olaraq Student obyekti qəbul edir və gələn student obyektini Group class-ında olan 
        Students arrayinə əlavə edir əgər arrayin uzuluğu StudentLimit-i keçirsə əlavə etməməlidi.*/
        public Student[] AddStudent(string fullname,int id,int point)
        { Fullname= fullname;
            Point= point;

              for (int i = 0; i < StudentLimit; i++)
            {
                Students[i] = new Student(Fullname, Point, Id);
              
            } 
              return Students;


        }
        //public Nullable GetStudent(int id)
        //{
        //     id=Students[id].Id;
        //    return 

        //}
        ///*- GetStudent() - parametr olaraq nullable int tipindən bir id dəyəri alacaq və 
         //* həmin id-li Student obyektini tapıb geriyə qaytaracaq.*/
    }

}

