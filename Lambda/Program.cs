using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Joe", "Crabtree", 1));
            employees.Add(new Employee("Joe", "Scott", 2));
            employees.Add(new Employee("Alex", "Apple", 3));
            employees.Add(new Employee("Sam", "Rodriguez", 4));
            employees.Add(new Employee("Peter", "Jones", 5));
            employees.Add(new Employee("Lisa", "Ford", 6));
            employees.Add(new Employee("Ann", "Poultry", 7));
            employees.Add(new Employee("Barry", "Allen", 8));
            employees.Add(new Employee("Zeke", "Shinso", 9));
            employees.Add(new Employee("Red", "Flash", 10));

            Console.WriteLine("Displaying every employee named 'Joe' using foreach");
            foreach (Employee employee in employees.TakeWhile(x => x.firstname.Contains("Joe")))
            {
                Console.WriteLine("First name: " + employee.firstname + " Last name: " + employee.lastname + " ID: " + employee.ID);
                Console.ReadLine();
            }

            Console.WriteLine("Now displaying all employees with id number greater than 5 with lambda");

            List<int> idlargerthanfive = employees.FindAll(x => x.ID >= 5);

            Console.WriteLine("Now displaying every employee named 'Joe' using a lambda expression");

            List<string> joeemployee = employees.FindAll(x => x.firstname == "Joe");

            



























            //Employee employee = new Employee();
            //List<Employee> Employees = new List<Employee>();
            //List<string> firstnames = new List<string>()
            //    {
            //        "Bob", "Jeff", "Dale", "Kate", "Ann", "Joe", "Joe", "Adam", "Alex", "Liz"
            //    };

            //List<string> lastnames = new List<string>()
            //    {
            //        "Jackson", "Smith", "Miller", "Turner", "Johnson", "Rodriguez", "Bush", "Jones", "Alex", "Gillies"
            //    };

            //List<int> IDs = new List<int>()
            //    {
            //        34332, 54754, 43523, 87012, 43158, 1, 2, 3, 4, 5
            //    };

            //List<int> indexes = new List<int>()
            //    {
            //        0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            //    };

            //foreach (int index in indexes)
            //{
            //    Employee Employeeobject = new Employee();
            //    Employeeobject.firstname = firstnames[index];
            //    Employeeobject.lastname = lastnames[index];
            //    Employeeobject.ID = IDs[index];
            //    Employees.Add(Employeeobject);
            //}

            ////foreach (Employee Employee in Employees)
            ////{
            ////    if (Employee.firstname == "Joe")
            ////    {
            ////        Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);

            ////    }

            ////}

            ////List<Employee> newList = employee.firstname.Where(firstnames == "Joe").ToList();
            //int count = Employees.Count(x => x.ID > 5);
            //List<Employee> employeeID = 
            //Console.WriteLine(count);
            //Console.ReadLine();
        }
    }
}
