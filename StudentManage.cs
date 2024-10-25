using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageSystem 
{
    public class StudentManager //Skapar en klass för att hantera studentobjekt 
    {
        private List<Student> students = new List<Student>(); //Skapar en lista för att lagra studentobjekt

        public StudentManager() //Konstruktor för klassen StudentManager
        {
            students = new List<Student>(); //Initierar listan students
        }

        public void AddStudent(Student student) //Metod för att lägga till studentobjekt i listan students
        {
            students.Add(student); //Lägger till studentobjekt i listan students


            Console.WriteLine($"Studenten {student.Name} har lagts till"); //Skriver ut meddelande om studenten är tillagd
        }

        public void RemoveStudent(int studentid, string name) //Metod för att ta bort studentobjekt från listan students
        {
            var studentToRemove = students.FirstOrDefault(s => s.Studentid == studentid); //Hittar studentobjektet som ska tas bort
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove); //Tar bort studentobjekt från listan students
                Console.WriteLine($"Studenten {name} med ID: {studentid} har tagits bort"); //Skriver ut meddelande om studenten är borttagen
            }
            else
            {
                Console.WriteLine("Studenten finns inte"); //Skriver ut meddelande om studenten inte finns
            }
        }

        public bool StudentExist(int studentid) //Metod för att kontrollera om studenten finns
        {
            if (students.Count == 0) //Kontrollerar om studenten finns
            {
                Console.WriteLine("ingen student finns i listan"); //Skriver ut meddelande "ingen student finns i listan
                return false; //Returnerar false om studenten inte finns
            }
            if (students.Any(s => s.Studentid == studentid)) //Returnerar true om studenten finns
            {
                return true;
            }
            else
            {
                Console.WriteLine("Studenten finns inte"); //Skriver ut meddelande om studenten inte finns
                return false; //Returnerar false om studenten inte finns
            }

        }
        public void ShowAllStudentsMajorsAndGrades() //Metod för att visa alla studenter
        {
            foreach (var student in students) //Loopar igenom listan students
            {
                Console.WriteLine($"Namn: {student.Name}, Ålder: {student.Age}, ID: {student.Studentid}"); //Skriver ut studentens namn, ålder och ID

                if (student.Majors.Count > 0 && student.Grades.Count > 0) //Kontrollerar om studenten har betyg
                {
                    Console.WriteLine("Ämne och Betyg ");

                    for (int i = 0; i < student.Majors.Count; i++) //Loopar igenom listan Majors
                    {
                        Console.WriteLine($"Ämne: {student.Majors[i]}, Betyg: {student.Grades[i]}"); //Skriver ut studentens betyg
                    }
                    

                }
                else
                {
                    Console.WriteLine("Inget ämne eller betyg har regristrerat"); //Skriver ut meddelande om studenten inte har betyg
                }
               
                Console.WriteLine("-------------------------------------------------");

            }
        }



        public double CalculateAverageGrade() //Metod för att räkna ut snittbetyget för alla studenter
        {
            int totalGrades = 0; //Variabel för att lagra totala betyget
            int totalSum = 0; //Variabel för att lagra totala summan av betygen

            foreach (var student in students) //Loopar igenom listan students
            {
                totalGrades += student.Grades.Count; //Räknar antalet betyg
                totalSum += student.Grades.Sum(); //Räknar summan av betygen

            }
            return totalSum / totalGrades; //Returnerar snittbetyget


        }

        public List<Student>ListStudentsGrades() //Metod för att lista alla studenter och deras betyg
        {
            return students; //Returnerar listan students
        }

        public void AddGrades(int grade, int studentid) //Metod för att lägga till betyg för studenten
        {
            var student = students.FirstOrDefault(s => s.Studentid == studentid); //Hittar studentobjektet som ska lägga till betyg

         if (student != null) //Kontrollerar om studenten finns
            { 

            if (grade >= 1 && grade <= 5)//Kontrollerar att betyget är mellan 1 och 5
            {
                student.Grades.Add(grade); //Lägger till betyg för studenten
                Console.WriteLine($"Betyget {grade} har lagt till för Studenten: {student.Name}"); //Skriver ut meddelande om betyget är tillagt
            }
            else
            {
                Console.WriteLine("Ogiltigt betyg"); //Skriver ut meddelande om betyget är ogiltigt
            }
        }
           
        }

        public void AddMajors(int studentid, string major)
        {
            var student = students.FirstOrDefault(s => s.Studentid == studentid); //Hittar studentobjektet som ska lägga till inriktning

            if (student != null)
            {
                if (!student.Majors.Contains(major))
                {
                    student.Majors.Add(major);
                    Console.WriteLine($"Inriktningen {major} har lagts till för studenten: {student.Name}");
                }
                else
                {
                    Console.WriteLine("Inriktningen finns redan");
                }
            }
            else
            {
                Console.WriteLine("Studenten finns inte");
            }
        }

     
    }
}






       




