using System;
using System.Collections.Generic;
using Curse.Entities.Enum;

namespace Curse.Entities
{
    class Work
    {
        public string Name { get; set; }

        public WorkLevel level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }



        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();


        public Work()
        {

        }

        public Work(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            this.BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {

            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {

            double sum = BaseSalary;

            foreach(HourContract  contracts in Contracts)
            {
                if(contracts.Date.Year == year && contracts.Date.Month == month)
                {
                    sum += contracts.totalValue();

                }

            }
            return sum;
        }
    }
}
