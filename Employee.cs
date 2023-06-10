using System;
namespace Listando
{
  class Employee
  {
    public int Id{get;set;}
    public string Name{get;set;}
    public double Salary{get;set;}

    public Employee(int id, string name, double salary){
      Id = id;
      Name = name;
      Salary = salary;
    }

    public void IncrementSalary(double percentage){

      Salary = percentage >0 ? Salary + (Salary * (percentage/100)): Salary;
    }

    public override string ToString()
    {
      return $"{Id}, {Name}, {Salary}";
    }


  }
}
