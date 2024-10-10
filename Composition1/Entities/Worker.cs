using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition1.Entities.Enums;
using Composition1.Entities;
using System.Diagnostics.Contracts;

namespace Composition1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        private List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(Department department, string name, WorkerLevel lvl, double salary)
        {
            Name = name;
            level = lvl;
            BaseSalary = salary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double totalIncome = BaseSalary;

            foreach (var contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    totalIncome += contract.TotalValue();
                }
            }

            return totalIncome;
        }
    }

}
