using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_GeneralConcepts_Delegates
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<string, string, string> name = GetName;
			name("Zach", "Nelson");

		}
		private static string GetName(string first, string last)
		{
			var fullname = first + " " + last;
			return fullname;
		}
	}
}
