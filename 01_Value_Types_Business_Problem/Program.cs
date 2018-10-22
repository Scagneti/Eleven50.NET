using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Business_Problem
{
	class Program
	{
		public enum VehicleType
		{
			Car = 0,
			Motorcycle,
			Boat,
			Plane
		}
		static void Main(string[] args)
		{



			Console.WriteLine("Welcome to Komodo! What is your name?");
			string name = Console.ReadLine();

			Console.WriteLine("Hi " + name + ". How old are you?");
			string agestring = Console.ReadLine();
			int age = int.Parse(agestring);

			Console.WriteLine($"What kind of vehicle do you have {name}?:\n" +
				$"1. Car \n" +
				$"2. Motorcycle \n" +
				$"3. Boat \n" +
				$"4. Plane \n");
			string vehicleChoice = Console.ReadLine();
			int choice = int.Parse(vehicleChoice);

			VehicleType vehicleType = (VehicleType)choice;

			decimal insuranceCost = 0m;

			switch (vehicleType) {
				case VehicleType.Car:
					if (age >= 18 && age <= 27) insuranceCost = 150m;
					else if (age > 27 && age <= 65) insuranceCost = 50.00m;
					else if (age > 65) insuranceCost = 100.00m;
					break;
				case VehicleType.Motorcycle:
					if (age > 18 && age <= 27) insuranceCost = 200m;
					else if (age > 27 && age <= 65) insuranceCost = 100.00m;
					else if (age > 65) insuranceCost = 150.00m;
					break;
				case VehicleType.Boat:
					if (age > 18 && age <= 27) insuranceCost = 200m;
					else if (age > 27 && age <= 65) insuranceCost = 100.00m;
					else if (age > 65) insuranceCost = 150.00m;
					break;
				case VehicleType.Plane:
					if (age > 18 && age <= 27) insuranceCost = 1000m;
					else if (age > 27 && age <= 65) insuranceCost = 500.00m;
					else if (age > 65) insuranceCost = 1000.00m;
					break;
			}
			Console.WriteLine($"Your {vehicleType} will cost {insuranceCost} per month to insure.");
			Console.ReadLine();
		}
	}
}
