using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritence_Demo
{
	public class Bear : Animal
	{
		public override void GetMad()
		{
			Console.WriteLine("Rawr!");
		}

		public override void StateType()
		{
			throw new NotImplementedException();
		}

		public override void Talk()
		{
			base.Talk();
			Console.WriteLine("I'm also a bear.");
		}
	}
}
