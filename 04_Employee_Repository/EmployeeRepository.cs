using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Employee_Repository
{
    public class EmployeeRepository
    {
		List<Employee> employees = new List<Employee>();

		public void AddEmployeeToList(Employee model)
		{
			employees.Add(model);
		}

		public List<Employee> GetList()
		{
			return employees;
		}

		public void RemoveEmployeeByName(string name)
		{
			foreach (Employee e in employees)
			{
				if (e.Name == name)
				{
					employees.Remove(e);
					break;
				}
			}
		}
    }
}
