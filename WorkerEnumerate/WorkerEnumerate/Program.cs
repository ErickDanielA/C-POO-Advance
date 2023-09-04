using WorkerEnumerate.Entities;
using WorkerEnumerate.Entities.Enums;
using System.Globalization;

namespace WorkerEnumerate
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Department dept = new Department(department);
            Console.Write("How many contracts to this worker? ");
            int qntContracts = int.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary,dept);
            for (int i = 0; i < qntContracts; i++)
                {
                Console.WriteLine("Enter #"+(i+1)+" contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                Double valuePerHour = Double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter mont and year to calculate income (MM/YYYY): ");
            string yemonth = Console.ReadLine();
            int month = int.Parse(yemonth.Substring(0, 2));
            int year = int.Parse(yemonth.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+worker.Department.Name);
            Console.WriteLine("Income for "+yemonth+" : "+worker.Income(year, month));
        }
        }
    }