using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string IrdNum { get; set; }
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public int Age { get; set; }
        public long BankNum { get; set; }
        public int EmployeeID { get; set; }
        public double TaxDeducted { get; set; }

        public Employee()
        {

        }
        public Employee(string fname, string lname, string ird, double hrRate, double hrsWorked, int age, long bnkNum)
        {

        }
        public double CalcWeeklyPay()
        {
            return 0;
        }

    }
}
