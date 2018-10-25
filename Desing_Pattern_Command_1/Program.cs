using Desing_Pattern_Command_1.Command;
using Desing_Pattern_Command_1.Command.ConcreteCommands;
using Desing_Pattern_Command_1.Invoker;
using Desing_Pattern_Command_1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Pattern_Command_1
{
	class Program
	{
		static void Main(string[] args)
		{
			//-- Receiver
			IVehicle car = new Car();
			IVehicle motorcycle = new Motorcycle();

			//-- Concrete Commands
			ICommand turnOnCommand = new TurnOnVehicle(car);
			ICommand turnOffCommand = new TurnOffVehicle(car);
			ICommand speedUpCommand = new SpeedUpVehicle(car);
			ICommand brakeCommand = new BrakeVehicle(car);

			ICommand turnOnMotorcycle = new TurnOnVehicle(motorcycle);
			ICommand turnOffMotorcycle = new TurnOffVehicle(motorcycle);
			ICommand speedUpMotorcycle = new SpeedUpVehicle(motorcycle);
			ICommand brakeMotorcycle = new BrakeVehicle(motorcycle);

			//-- Invoker
			VehicleInvoker invoker = new VehicleInvoker(turnOnCommand, turnOffCommand, speedUpCommand, brakeCommand );

			VehicleInvoker motorcycleInvoker = new VehicleInvoker(turnOnMotorcycle, turnOffMotorcycle, speedUpMotorcycle, brakeMotorcycle);

			invoker.TurnOn();
			invoker.SpeedUp();
			invoker.Brake();
			invoker.TurnOff();
			motorcycleInvoker.TurnOn();
			motorcycleInvoker.SpeedUp();
			motorcycleInvoker.Brake();
			motorcycleInvoker.TurnOff();

			Console.ReadLine();
		}
	}
}
