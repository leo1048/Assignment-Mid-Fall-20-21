using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Departments
    {
        public string DepartmentName { get; set; }
        Course[] listOfCourses;
        public int totalCourse { get; set; }
        public Section Section { get; set; }
        Teaching_Hour[] teachingHours;
        public int CreditCount { get; set; }
        public Departments(string name)
        {
            DepartmentName = name;
            listOfCourses = new Course[10];
            teachingHours = new Teaching_Hour[100];


        }
        public void ShowInfo()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("Courses Number: " + totalCourse);
        }
      
        public void ShowAllCredits()
        {

            for (int i = 0; i < CreditCount; i++)
            {
                Console.WriteLine("Department Info");
                teachingHours[i].Departments.ShowInfo();
                Console.WriteLine("Teaching  Hours");
                teachingHours[i].ShowInfo();
                Console.WriteLine("---------------------------------");
            }

        }


    }
}