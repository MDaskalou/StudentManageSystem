namespace StudentManageSystem
{
    //todo: Remove all comments
    internal class Program
    {
        //todo: args is not used remove 
        static void Main(string[] args)
        {
            //todo: never use explicit types always use var
            //todo: never capital letters on variables --> manager 
            StudentManager Manager = new StudentManager(); //Skapar en instans av klassen StudentManager

            //todo: never use explicit types always use var
            //todo: snake case userinput --> userInput
            Userinput userinput = new Userinput(Manager); //Skapar en instans av klassen Userinput

            userinput.ShowMenu(); //Anropar metoden ShowMenu

            //todo: remove all space below
           


        }
    }
}
    