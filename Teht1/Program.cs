using System;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kernel", "Teacher", 1200);
            Boss jussi = new Boss("Jussi Jurkka", "Head of Institute", 9000, "Audi", 5000);

            Console.WriteLine(kirsi);
            Console.WriteLine(jussi);
            kirsi.Salary += 1000;
            Console.WriteLine(kirsi);
        }
    }
}
