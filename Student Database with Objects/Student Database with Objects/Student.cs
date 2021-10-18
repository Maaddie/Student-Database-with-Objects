using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Database_with_Objects
{
    class Student
    {
        public string Names { get; set; }

        public string HomeTown { get; set; }

        public string FavoriteFood { get; set; }

        public Student (string Names, string HomeTown, string FavoriteFood)
        {
            this.Names = Names;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;
            
        }

        //THIS method prints student details
        public void studentInfo()
        {
            Console.WriteLine("\tName : " + Names);
            Console.WriteLine("\tHomeTown : " + HomeTown);
            Console.WriteLine("\tFavoriteFood : " + FavoriteFood);
        }
    }
}
