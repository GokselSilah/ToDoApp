using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoApp
{
    public class EmployeeManager
    {
        static List<Employee> employees = new List<Employee>() 
        { 
            new Employee() { EmployeeId = 1, EmployeeName = "Göksel"},
            new Employee() { EmployeeId = 2, EmployeeName = "Cemre"}, 
            new Employee() { EmployeeId = 3, EmployeeName = "Ayşegül"},
            new Employee() { EmployeeId = 4, EmployeeName = "Gözde"},
            new Employee() { EmployeeId = 5, EmployeeName = "Merve"}, 
            new Employee() { EmployeeId = 6, EmployeeName = "Can"}, 
            new Employee() { EmployeeId = 7, EmployeeName = "Umut"}, 
            new Employee() { EmployeeId = 8, EmployeeName = "Özge"}
        };

        public void Add()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();        
            
            var result = employees.FirstOrDefault(e=>e.EmployeeId != id && e.EmployeeName != name);
            
            if (result == null) 
            {
                employees.Add(new Employee() { EmployeeId = id, EmployeeName = name});
            }
        }

        public static string GetById(int id)
        {
            var result = employees.SingleOrDefault(e=>e.EmployeeId == id);
            return result.EmployeeName ;
        }



    }
}
