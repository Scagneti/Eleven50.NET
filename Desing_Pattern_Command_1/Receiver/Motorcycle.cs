using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Pattern_Command_1.Receiver
{
	class Motorcycle : IVehicle
	{
		public void Brake()
		{
			Console.WriteLine("Slowing down the motorcycle");
		}

		public void SpeedUp()
		{
			Console.WriteLine("Speeding up the motorcycle");
		}

		public void TurnOff()
		{
			Console.WriteLine("Turning off the motorcycle");
		}

		public void TurnOn()
		{
			Console.WriteLine("Turn on the motorcycle");
		}
	}
}
