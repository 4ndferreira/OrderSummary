using System.Globalization;
using PaymentEmployees.Entities;

List<Employee> Employees = [];

Console.Write("Enter the number of employees: ");
int numOfEmployees = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= numOfEmployees; i++)
{
  Console.WriteLine($"Employee #{i} data:");

  Console.Write("Outsourced (y/n)? ");
  char option = char.Parse(Console.ReadLine()!);

  Console.Write("Name: ");
  string name = Console.ReadLine()!;
  Console.Write("Hours: ");
  int hours = int.Parse(Console.ReadLine()!);
  Console.Write("Value per hour: ");
  double valuePerHour = double.Parse(
    Console.ReadLine()!,
    CultureInfo.InvariantCulture);
  if (option == 'y' || option == 'Y')
  {
    Console.Write("Additional charge: ");
    double additionalCharge = double.Parse(
      Console.ReadLine()!,
      CultureInfo.InvariantCulture);

    Employees.Add(
      new OutsourcedEmployee(
        name,
        hours,
        valuePerHour,
        additionalCharge
      ));
  }
  else
  {
    Employees.Add(
      new Employee(
        name,
        hours,
        valuePerHour
      ));
  }
}

Console.WriteLine("\nPAYMENTS:");
foreach (Employee employee in Employees)
{
  Console.WriteLine(employee);
}