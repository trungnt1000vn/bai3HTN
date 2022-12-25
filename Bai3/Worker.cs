using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Worker : Human
    {
        private float weekSalary;
        private float workHoursPerDay;

        public Worker()
        {
        }

        public float WeekSalary { get => weekSalary; set => weekSalary = value; }
        public float WorkHoursPerDay { get => workHoursPerDay; set => workHoursPerDay = value; }
        public int MoneyPerHour()
        {
            int moneyperhours = 0;
            return moneyperhours;
        }

    }
}
