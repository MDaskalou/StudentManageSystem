namespace StudentManageSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager Manager = new StudentManager(); //Skapar en instans av klassen StudentManager

            Userinput userinput = new Userinput(Manager); //Skapar en instans av klassen Userinput

            userinput.ShowMenu(); //Anropar metoden ShowMenu

           


        }
    }
}
    