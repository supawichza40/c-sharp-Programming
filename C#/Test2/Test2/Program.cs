using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StaticStudent.FirstName = "Supavich";
            StaticStudent.LastName = "Aussawa";
            StaticStudent.Introducing();

            DatabaseConnection ted = DatabaseConnection.getDbConnection();
            //.......
        }
        




        static void MyOtherFunction()
        {

            DatabaseConnection mydb  = DatabaseConnection.getDbConnection();
        }
    }
    public static class StaticStudent
    {

        static StaticStudent()
        {
            FirstName = "";
            LastName = "";
        }

        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public static void Introducing()
        {            
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
    public class DatabaseConnection
    {
        private static DatabaseConnection Instance = null;

        private DatabaseConnection()
        {
                
        }

        public static DatabaseConnection getDbConnection()
        {
            if(Instance==null)
                Instance = new DatabaseConnection();

            return Instance;

        }


        //int addressOfthisObjet 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Introducing()
        {
            Console.WriteLine($"{LastName} {FirstName}" );
        }

    }

}
