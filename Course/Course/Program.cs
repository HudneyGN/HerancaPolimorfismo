using System;
using System.Globalization;
using Course.Entities;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'y' || resp == 'Y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.Write("PAYMENTS:");
            foreach (Employee emp in employees) {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
