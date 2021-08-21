using System;
using LSPLibrary;

namespace LSPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountVP = new Manager();

            accountVP.FirstName = "Emma";
            accountVP.LastName = "Stone";
            accountVP.CalculatePerHourRate(4);

            var emp = new Employee();

            emp.FirstName = "Gustavo";
            emp.LastName = "Bedasi";
            emp.AssignManager(accountVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salaryis ${ emp.Salary }/hour");

            Console.WriteLine("Press enter to exit...")
            Console.ReadLine();
        }
    }
}
