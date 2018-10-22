using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{
	public class Customer
	{
		//public string FirstName { get; set; }
		private string _firstName;
		private string _lastName;

		//constructors
		//public Customer(string firstName, string lastName, int age, string question)
		//{
		//	FirstName = firstName;
		//	LastName = LastName;
		//	Age = age;
		//	Question = question;
		//}

		public string FirstName
		{
			get => _firstName;
			//{
			//	return _firstName;  Same as the above line
			//}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new Exception("First name cannot be empty");
				else
					_firstName = value.Trim();
			}
		}

		public string LastName
		{
			get => _lastName;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new Exception("Last name cannot be empty");
				else
				_lastName = value;
			}
		}


		//public string LastName { get; set; }
		//public int Age { get; set; }
		private int _age;

		public int Age
		{
			get => _age;
			set
			{
				if (value < 1)
					throw new ArgumentOutOfRangeException("Age cannot be less than 1.");
				else
				_age = value;
			}
		}

		public string Question { get; set; }

	}
}
