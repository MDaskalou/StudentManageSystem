using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageSystem
{
    public class Userinput
    {
        private StudentManager manager; //Skapar en instans av klassen StudentManager

        public Userinput(StudentManager studentManager) //Konstruktor för klassen Userinput
        {
            manager = studentManager; //Initierar instansen av klassen StudentManager
        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Välj ett alternativ: ");
                Console.WriteLine("1. Lägg till student");
                Console.WriteLine("2. Ta bort student");
                Console.WriteLine("3. Lista alla studenter och deras betyg");
                Console.WriteLine("4. Räkna ut snittbetyget för alla studenter");
                Console.WriteLine("5. Lägg till betyg för student");
                Console.WriteLine("6. Avsluta programmet");
                int choices = Convert.ToInt32(Console.ReadLine());



                switch (choices)
                {
                    case 1:
                        Console.WriteLine("Skriv in studentens namn: ");
                        string name = Console.ReadLine(); //Läser in studentens namn

                        Console.WriteLine("Skriv in studentens ålder: ");
                        int age = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ålder

                        Console.WriteLine("Skriv in studentens ID: ");
                        int studentid = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ID

                        Student student = new Student(name, age, studentid); //Skapar ett studentobjekt
                        manager.AddStudent(student); //Lägger till studenten i listan

                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine("Skriv in studentens ID:s ");
                        int studentidToRemove = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ID

                        manager.RemoveStudent(studentidToRemove); //Tar bort studenten från listan
                        Console.WriteLine("Studenten är borttagen");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        Console.WriteLine("Studenten och deras betyg: ");
                        manager.ShowAllStudentsMajorsAndGrades(); //Visar alla studenter och deras betyg
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        double avaerageGrade = manager.CalculateAverageGrade(); //Räknar ut snittbetyget för alla studenter
                        Console.WriteLine($"Snittbetyget för alla studenter är: {avaerageGrade}"); //Skriver ut snittbetyget
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 5:
                        Console.WriteLine("Skriv in studentens ID: ");
                        int studentidToAddGrade = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ID
                        while(true)
                        {   

                             if (manager.StudentExist(studentidToAddGrade))
                              {
                                    Console.WriteLine("Skriv in ämnet du vill lägga till betyg för:");
                                    manager.AddMajors(studentidToAddGrade, Console.ReadLine());

                                    Console.WriteLine("Skriv in betyget för studenten (mellan 1-5): ");
                                    int grade = Convert.ToInt32(Console.ReadLine()); //Läser in betyg för studenten
                                    manager.AddGrades(grade, studentidToAddGrade); //Lägger till betyg för studenten


                              }
                              else
                                {
                                    Console.WriteLine("Studenten finns inte");
                                 }
                                    Console.WriteLine("Vill du lägga till fler betyg? Ja eller Nej");
                                    string answer = Console.ReadLine();
                                    if(answer.ToLower() == "nej")
                                    {
                                        break;
                                    }
                            Console.Clear();
                        }

                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 6:
                        Console.WriteLine("Programmet avslutas");
                        Environment.Exit(0);
                        break;


                }

            }
        }
    }
}
