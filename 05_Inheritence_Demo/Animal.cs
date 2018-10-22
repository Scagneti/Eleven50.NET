using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritence_Demo
{
    public abstract class Animal
    {

		public bool HasLegs { get; set; }
		public int? Legs { get; set; }
		public string Name { get; set; }
		public string Habitat { get; set; }
		public int Weight { get; set; }
		public int AverageNumberOfOffspring { get; set; }

		private string _latinName;

		public string LatinName
		{
			get => _latinName;

			set
			{
				if (String.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Name can't be empty.");
				_latinName = value;
			}
		}
		public abstract void StateType();
		public abstract void GetMad();

		public virtual void Talk()
		{
			Console.WriteLine("I'm an animal.");
		}
	}
}
