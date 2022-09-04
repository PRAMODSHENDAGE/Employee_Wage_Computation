
using EmployeeWageComputation;

EmployeeWage dmart = new EmployeeWage("Dmart", 20, 2, 10);
EmployeeWage reliance = new EmployeeWage("Reliance", 10, 4, 20);
dmart.computeEmpWage();
Console.WriteLine(dmart.ToString());
reliance.computeEmpWage();
Console.WriteLine(reliance.ToString());
