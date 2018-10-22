using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Conecepts_DependencyInjection
{
	public class UglyConsole : IConsole
	{
		public ConsoleKeyInfo Readkey()
		{
			return Console.ReadKey();
		}

		public string Readline()
		{
			return Console.ReadLine();
		}

		public void Write(string s)
		{
			Console.Write("This is the Ugly Console.");
			Console.Write(s);
		}

		public void WriteLine(string s)
		{
			Console.WriteLine("This is the Ugly Console.");
			Console.WriteLine(s);
		}

		public void WriteLine(object o)
		{
			Console.WriteLine(o);
		}
	}
}
