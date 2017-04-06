using System;
using MySql;
using ServiceStack.OrmLite;
//using ServiceStack.OrmLite.MySql;
using System.Linq;
namespace dapper_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cstr = "server=localhost;user id=root;password=;persistsecurityinfo=True;port=3306;database=dapper";
            var dbFactory = new OrmLiteConnectionFactory(cstr, MySqlDialect.Provider);
            var con = dbFactory.Open();
            // string firstName = Prompt("What is the first name?");
            // string lastName = Prompt("what is the last name?");
            // int age = PromptInt("what is the age?");

            Person newPerson = new Person();
            newPerson.FirstName = "chaim";
            newPerson.LastName = "lastName";
            newPerson.Age = 22;
            newPerson.Id = 11;
            // var ppl = con.Select<Person>(p => p.Age > 15);
            // foreach(var p in ppl) 
            // {
            //     Console.WriteLine(p.FirstName, p.LastName);
            // }
            con.Update(newPerson);
            var latestPerson = con.Select<Person>(p => p.Id == newPerson.Id).First();
            Console.WriteLine(latestPerson.LastName);
            Console.ReadKey(true);
        }

        public static string Prompt(string text) 
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int PromptInt(string text) 
        {
            Console.WriteLine(text);
            return int.Parse(Console.ReadLine());
        }
    }
}
