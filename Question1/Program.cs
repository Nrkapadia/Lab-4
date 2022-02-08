using System;
using BaseEmployee;
namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee  e1 = new Employee("Harsh","Patel",30000);
            Console.WriteLine(e1);
            Console.Write("How much raise you want to give him/her ? ");
            double percentage = Convert.ToDouble(Console.ReadLine());
            e1.Monthly_Sal=e1.giveRaise(percentage);
            Console.WriteLine("\nAfter Promotion of {0}% In Salary",percentage);
            Console.WriteLine(e1);

            //this is for permenent employee with type of object and value of object is derived class
            Console.WriteLine();
            PermenetEmployee e2 = new PermenetEmployee("Nisarg","Kapadia",45000,20,50,12);
            Console.WriteLine(e2);
            Console.Write("How much raise you want to give him/her ? ");
            percentage = Convert.ToDouble(Console.ReadLine());
            e2.Monthly_Sal=e2.giveRaise(percentage);
            Console.WriteLine("\nAfter Promotion of {0}% In Salary",percentage);
            Console.WriteLine(e2);

           
        }
    }
}
