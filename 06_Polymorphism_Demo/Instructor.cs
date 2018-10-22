using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo
{
	public class Instructor : Person, ITrainable
	{
		public void GetTraining()
		{
			Console.WriteLine("You are getting trained on training.");
		}

		public override void Greet()
		{
			Console.WriteLine($"Hello I am an instructor.  My name is Mr. {LastName}");
		}
	}
}
