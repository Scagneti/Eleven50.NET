using System;
using System.Collections.Generic;
using System.Text;

namespace _03_DefiningClasses_2
{
    public class WeatherRepository
    {
		private List<Weather> _weatherList;

		public WeatherRepository()
		{
			_weatherList = new List<Weather>();
		}

		public void AddWeatherItemToList(Weather model)
		{
			_weatherList.Add(model);
		}
		public List<Weather> GetList()
		{
			return _weatherList;
		}
    }
}
