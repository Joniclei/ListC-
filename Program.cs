using System;
namespace Listando
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Employee> test = new List<Employee>();

      int id;
      string name;
      double salary;

      Console.Write("Quantas pessoas quer adicinonar: ");
      int qt = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < qt; i++)
      {
        Console.Write("ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Qual Salario: ");
        salary = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        test.Add(new Employee(id, name, salary));
      }

      Console.Write("Enter the employee id that will have salary increase: ");
      int increase = Convert.ToInt32(Console.ReadLine());

      Employee employeesel = test.Find(em => em.Id == increase);

      if (employeesel != null){
        Console.Write("Enter the percentage: ");
        int percentage = Convert.ToInt32(Console.ReadLine());
        employeesel.IncrementSalary(percentage);
      }else{
        Console.WriteLine("This ID does is not exist");
      }


      Console.WriteLine("");

      Console.WriteLine();

      Console.WriteLine("Update list of employee");

      Console.WriteLine();

      foreach (Employee k in test)
      {
        Console.WriteLine(k);
      }


    }

  }
}
