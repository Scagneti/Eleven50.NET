using System;

namespace _00_General_Conecepts_DependencyInjection
{
	public class ProgramUI
	{
		private IConsole _console;

		public ProgramUI(IConsole console)
		{
			_console = console;
		}

		internal void Run()
		{
			_console.WriteLine("Hello");
			_console.Readkey();
		}

		internal void RunBad()
		{
			_console.WriteLine("Bad Hello");
			_console.Readkey();
		}

		internal void RunUgly()
		{
			_console.WriteLine("Ugly Hello");
			_console.Readkey();
		}
	}
}