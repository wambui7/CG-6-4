using System;

namespace dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startdate = DateTime.Now;
            DateTime enddate = Convert.ToDateTime("12, 31, 2018");
            TimeSpan date = (enddate - startdate);
            Console.WriteLine(date.TotalDays);
            Console.ReadLine();

        }
    }
}
