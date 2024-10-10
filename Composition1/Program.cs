using System;
using Composition1.Entities;
using Composition1.Entities.Enums;


Console.WriteLine("Enter department's name: ");
string nameD = Console.ReadLine()!;

Console.WriteLine("Enter worker data");
Console.WriteLine("Name: ");
string name = Console.ReadLine()!;

Console.WriteLine("Level: ");
string lvl = Console.ReadLine()!;
WorkerLevel wkrl = Enum.Parse<WorkerLevel>(lvl);

Console.WriteLine("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine()!);

Department department = new Department(nameD);

Worker worker = new Worker(department, name, wkrl, baseSalary);

Console.WriteLine("How many contracts to this worker?: ");
int many = int.Parse(Console.ReadLine()!);

for (int i = 0; i < many; i++)
{
    Console.WriteLine($"Enter #{i + 1} contract data: \nDate (DD:MM:YY):");
    DateTime date = DateTime.Parse(Console.ReadLine()!);
    
    Console.WriteLine("Value per hour: ");
    double value = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Duration (hours): ");
    int duration = int.Parse(Console.ReadLine()!);

    HourContract hourContract = new HourContract(date, value, duration);

    worker.AddContract(hourContract);

}


Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
string[] input = Console.ReadLine()!.Split('/'); 

int month = int.Parse(input[0]);
int year = int.Parse(input[1]);

double income = worker.Income(year, month);

Console.WriteLine("Name: " + worker.Name);

Console.WriteLine("Department: " + worker.Department.Name);

Console.WriteLine($"Income for {month}/{year}: {income}");
