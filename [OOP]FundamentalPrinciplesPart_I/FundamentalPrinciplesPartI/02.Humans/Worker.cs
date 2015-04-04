namespace Humans
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Worker : AbstractHuman
    {
        public Worker(string name, string lastName)
            :base(name,lastName)
        {
           
        }

        public int WeekSalary { get; set; }
        
        public int WorkHoursPerDay { get; set; }

        public int MoneyPerHour(int weekSalary, int workHoursPerDay)
        {
            int moneyPerHour = new Int32();
            moneyPerHour = (this.WeekSalary / 5) / this.WorkHoursPerDay;
            return moneyPerHour;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + MoneyPerHour(this.WeekSalary,this.WorkHoursPerDay);
        }
    }
}
