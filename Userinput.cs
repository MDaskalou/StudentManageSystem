//todo: snake case on studentid --> studentId
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//todo: remove all comments
namespace StudentManageSystem
{
    public class Userinput
    {
        //todo: Captial case on prop --> Manager
        private StudentManager manager; //Skapar en instans av klassen StudentManager

        //Todo: two words, allways captial letter on both -- UserInput
        public Userinput(StudentManager studentManager) //Konstruktor för klassen Userinput
        {
            manager = studentManager; //Initierar instansen av klassen StudentManager
        }
        public void ShowMenu()
        {
            //todo: while loop never ends. fix. 
            while (true)
            {
                //todo: Could be one Console.writeline with line breaks
                Console.WriteLine("Välj ett alternativ: ");
                Console.WriteLine("1. Lägg till student");
                Console.WriteLine("2. Ta bort student");
                Console.WriteLine("3. Lista alla studenter och deras betyg");
                Console.WriteLine("4. Räkna ut snittbetyget för alla studenter");
                Console.WriteLine("5. Lägg till betyg för student");
                Console.WriteLine("6. Avsluta programmet");
                //todo: use var instead of int
                int choices = Convert.ToInt32(Console.ReadLine());
//todo: remove space 


                switch (choices)
                {
                    case 1:
                        Console.WriteLine("Skriv in studentens namn: ");
                     //todo: use var instead of type string
                        string name = Console.ReadLine(); //Läser in studentens namn

                        Console.WriteLine("Skriv in studentens ålder: ");
                        //Todo: use var instead of type int
                        int age = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ålder

                        Console.WriteLine("Skriv in studentens ID: ");
                        //Todo: use var instead of type int
                        int studentid = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ID

                        //Todo: use var instead of type Student & check name for null
                        Student student = new Student(name, age, studentid); //Skapar ett studentobjekt
                        manager.AddStudent(student); //Lägger till studenten i listan

                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine("Skriv in studentens ID:s ");
                        //Todo: use var instead of type int & studentIdToRemove
                        int studentidToRemove = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ID

                        //Todo: fix error Remove student expects 2 arguments, you just pass one
                        manager.RemoveStudent(studentidToRemove); //Tar bort studenten från listan
                        
                        //todo: consolidate console.writeline to one with linebreak
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
                        //Todo: use var instead of type double
                        double avaerageGrade = manager.CalculateAverageGrade(); //Räknar ut snittbetyget för alla studenter
                        //todo: variable averageGrade is misspelled & consoldiate console.writelines to one with linebreaks
                        Console.WriteLine($"Snittbetyget för alla studenter är: {avaerageGrade}"); //Skriver ut snittbetyget
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 5:
                        Console.WriteLine("Skriv in studentens ID: ");
                        //todo: use var isntead of int, and snakeCase on variable name
                        int studentidToAddGrade = Convert.ToInt32(Console.ReadLine()); //Läser in studentens ID
                        while(true)
                        {   
                            //todo: indentation is poor. Fix
                             if (manager.StudentExist(studentidToAddGrade))
                              {
                                    Console.WriteLine("Skriv in ämnet du vill lägga till betyg för:");
                                    //todo: extract COnsole.readline to a varibale and send it to manager.AddMajor. Not directly as a parameter
                                    manager.AddMajors(studentidToAddGrade, Console.ReadLine());

                                    Console.WriteLine("Skriv in betyget för studenten (mellan 1-5): ");
                                    //todo: use var instead of int
                                    int grade = Convert.ToInt32(Console.ReadLine()); //Läser in betyg för studenten
                                    manager.AddGrades(grade, studentidToAddGrade); //Lägger till betyg för studenten
//todo: remove space

                              }
                              else
                             //todo: indentation is wierd. fix
                                {
                                    Console.WriteLine("Studenten finns inte");
                                 }
                                    Console.WriteLine("Vill du lägga till fler betyg? Ja eller Nej");
                                    //todo: use var instead of string and nullcheck before answer.ToLower
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
//todo:remove space

                }

            }
        }
    }
}
