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
        int a = 0;
        public void AddStudent(Student student)
        {
            Students[a] = student;

            a++;
            


        }


    }
}}

