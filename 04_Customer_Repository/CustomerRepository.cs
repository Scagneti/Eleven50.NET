using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Customer_Repository
{
	public class CustomerRepository
	{

			List<Customers> customers = new List<Customers>();

			public void AddCustomerToList(Customers model)
			{
				customers.Add(model);
			}

			public List<Customers> GetList()
		{
			return customers;
		}

		public string Message(Customers customers)
		{
			var message = "";
			if(customers.Years > 1)
			{
				message = "you entered a legacy customer";
			}
			else
			{
				message = "New Customer Added";
			}
			return message;
		}
		}
	}

