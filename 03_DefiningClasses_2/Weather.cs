using System;

namespace _03_DefiningClasses_2
{

	public enum WindDirection
	{
		North = 1,
		Northeast,
		East,
		Southeast,
		South,
		Southwest,
		West,
		Northwest
	}
    public class Weather
    {
		public int Id { get; set; }
		public float Temperature { get; set; }
		public WindDirection WindDirection { get; set; }
		public int WindSpeed { get; set; }
		public bool IsRaining { get; set; }
	}
}
