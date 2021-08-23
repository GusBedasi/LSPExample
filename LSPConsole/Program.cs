using System;
using LSPLibrary.Domain;
using LSPLibrary.Domain.Base;
using LSPLibrary.Domain.Contracts;

namespace LSPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstration of Liskov of Substitution Principle
            // We can switch over employee
            BaseEmployee firstEmp = new Employee();

            firstEmp.FirstName = "Gustavo";
            firstEmp.LastName = "Bedasi";
            firstEmp.CalculatePerHourRate(2);
            
            // CEO,
            BaseEmployee secondEmp = new CEO();

            secondEmp.FirstName = "Gustavo";
            secondEmp.LastName = "Bedasi";
            //secondEmp.GeneratePerformanceReview();
            secondEmp.CalculatePerHourRate(2);
            
            // Manager and the code still wors fine.
            BaseEmployee thirdEmp = new Manager();

            thirdEmp.FirstName = "Gustavo";
            thirdEmp.LastName = "Bedasi";
            //thirdEmp.AssignManager(secondEmp);
            thirdEmp.CalculatePerHourRate(2);

            //All of the entities can be of type BaseEmployee and the interfaces they implements which one you choose will have it`s details
            //The objects of a superclass can be replaced by the objects of its subclasses without breaking the application
            
            Console.WriteLine($"{ firstEmp.FirstName }'s salaryis ${ firstEmp.Salary }/hour");

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
