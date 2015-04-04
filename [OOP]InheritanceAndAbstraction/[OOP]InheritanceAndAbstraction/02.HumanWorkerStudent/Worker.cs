using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HumanWorkerStudent
{
    public class Worker : Human
    {
        public Worker( string first, string last, decimal weekSalary, int workHoursPerDay):base(first,last)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }

    }
}
