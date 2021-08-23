﻿using LSPLibrary.Domain.Contracts;

namespace LSPLibrary.Domain.Base
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public decimal Salary { get; set;}

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}