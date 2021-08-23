using System;
using LSPLibrary.Domain.Base;
using LSPLibrary.Domain.Contracts;

namespace LSPLibrary.Domain
{
    public class Manager : Employee, IManager
    {
        public  override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviwing a direct report
            Console.WriteLine("I'm reviewing a direct  report's performance.");
        }
    }
}
