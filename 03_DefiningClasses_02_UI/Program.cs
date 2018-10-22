using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_DefiningClasses_2;

namespace _03_DefiningClasses_02_UI
{
	public class Program
	{
		static void Main(string[] args)
		{
			WeatherRepository repo = new WeatherRepository();

			Console.WriteLine("Enter weather Id: ");
			var id = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter temeperature:");
			var temperature = float.Parse(Console.ReadLine());

			Console.WriteLine("Enter Wind Direction: ");
			var direction = int.Parse(Console.ReadLine());
			WindDirection windDirection = (WindDirection)direction;

			Console.WriteLine("Enter wind speed: ");
			var windSpeed = int.Parse(Console.ReadLine());

			Console.WriteLine("Is it raining?: ");
			var isRaining = bool.Parse(Console.ReadLine());

			Weather newWeather = new Weather()
			{
				Id = id,
				Temperature = temperature,
				WindSpeed = windSpeed,
				IsRaining = isRaining
			};

			var newList = repo.GetList();

			repo.AddWeatherItemToList(newWeather);

			foreach(Weather w in newList)
			{
				Console.WriteLine(w.Id + "is the id");
			}
			Console.ReadKey();
		}
	}
}
