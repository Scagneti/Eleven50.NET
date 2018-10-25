using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Pattern_Command_1.Receiver
{
	public interface IVehicle
	{
		void TurnOn();
		void TurnOff();
		void Brake();
		void SpeedUp();
	}
}
