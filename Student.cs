using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageSystem
{
    public class Student // This is the class that will be used to create student objects
    {
        public string Name { get; set; } // These are the properties of the student object
        public int Age { get; set; }
        public int Studentid { get; set; }
        public List<int> Grades { get; set; } // This is a list of integers that will be used to store the student's grades
        public List<string> Majors { get; set; } // En lista för att lagra studentens inriktningar

        public Student(string name, int age, int studentid) // This is the constructor for the student object
        {
            // This is the constructor for the student object

            Studentid = studentid;
            Name = name;
            Age = age;
            Grades = new List<int>(); // Initierar listan Grades
            Majors = new List<string>(); // Initierar listan Majors
        }
       
    }

}
   
