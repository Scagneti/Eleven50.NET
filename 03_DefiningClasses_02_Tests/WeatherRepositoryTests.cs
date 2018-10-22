using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_DefiningClasses_2;

namespace _03_DefiningClasses_02_Tests
{
	[TestClass]
	public class WeatherRepositoryTests
	{
		//Field
		private WeatherRepository weatherRepository;

		[TestInitialize]
		public void Inititalize()
		{
			weatherRepository = new WeatherRepository();
			Weather newWeather = new Weather()
			{
				Id = 1,
				IsRaining = true,
				WindDirection = WindDirection.East,
				WindSpeed = 10,
				Temperature = 10
			};

			weatherRepository.AddWeatherItemToList(newWeather);
		}

		[TestMethod]
		public void WeatherRepo_NumberOfItemsInList_IsCorrectInt()
		{

			//Act
			var expected = 1;
			var actual = weatherRepository.GetList().Count;
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
