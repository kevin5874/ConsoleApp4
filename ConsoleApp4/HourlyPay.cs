using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class HourlyPay
    {
        private int hoursWorked { get; set; }
        private double hourlyRate { get; set; }

        public HourlyPay(int hoursWorked, double hourlyRate)
            {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
            }

        public double GetTotalPay()
        {
            double result = hourlyRate * hoursWorked;
            return result;
        }
    }
}
