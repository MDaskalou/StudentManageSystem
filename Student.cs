//Todo: none av usings are actuall used. Remove
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageSystem
{
    //todo: remove all comments 
    public class Student // This is the class that will be used to create student objects
    {
        public string Name { get; set; } // These are the properties of the student object
        public int Age { get; set; }
        
        //Todo: with props alwaysCaptial letter on new word --> StudentId
        public int Studentid { get; set; }
        public List<int> Grades { get; set; } // This is a list of integers that will be used to store the student's grades
        public List<string> Majors { get; set; } // En lista för att lagra studentens inriktningar

        //todo: snake case on studentid --> studentId
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
   
