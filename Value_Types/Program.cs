using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
	class Program
	{
		public enum GenderType
		{
			Male = 0,
			Female = 1,
			Unknown =2
		}
		static void Main(string[] args)
		{
			//--Declaration
			int myAge;

			//--Initialization
			myAge = 42;

			//--Integers
			int i = 100;

			//--Other Integer Types
			byte by = 255;
			short sh = 32767;
			int iToo = 0;
			float PI = 3.14f;
			Console.WriteLine(PI);
			double d = 780.01;
			decimal p = 1.2m;
			int? noValue = null;
			long youtubeMinutesWatched = 12345678912345;
			Console.WriteLine(youtubeMinutesWatched);

			//--Booleans
			bool isEarly = true;

			//--Boolean Logic/Conditionals
			if (isEarly)
			{
				Console.WriteLine("Need more coffee.");
				Console.WriteLine("Yes indeed");
			}

			//--Declare Enum
			GenderType myGender = GenderType.Male;
			var jenna = GenderType.Female;

			switch (myGender)
			{
				case GenderType.Male:
					Console.WriteLine("Welcome Sir");
					break;
				case GenderType.Female:
					Console.WriteLine("Welcome Mam");
					break;
				case GenderType.Unknown:
					Console.WriteLine("Howdy!");
					break;
			}
		}
	}
}
