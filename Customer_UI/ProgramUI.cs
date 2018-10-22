using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Customer_Repository;

namespace Customer_UI
{
	public class ProgramUI
	{
		public void Run()
		{
			CustomerRepository customerRepository = new CustomerRepository();

			Console.WriteLine("Please enter a customer id: ");
			int id = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter a last name: ");
			string lastname = (Console.ReadLine());

			Console.WriteLine("Please enter the customers age: ");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the number of years the customers has been with Komodo: ");
			int years = int.Parse(Console.ReadLine());

			var customer = new Customers()
			{
				Id = id,
				LastName = lastname,
				Age = age,
				Years = years
			};

			customerRepository.AddCustomerToList(customer);
			Console.WriteLine(customerRepository.Message(customer));

			Console.ReadKey();
		}
	}
}
