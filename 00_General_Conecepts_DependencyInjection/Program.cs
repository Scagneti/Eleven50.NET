using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Conecepts_DependencyInjection
{
	class Program
	{
		static void Main(string[] args)
		{
			ProgramUI program = new ProgramUI(new GoodConsole());
			program.Run();

			ProgramUI badProgram = new ProgramUI(new BadConsole());
			badProgram.RunBad();

			ProgramUI uglyProgram = new ProgramUI(new UglyConsole());
			uglyProgram.RunUgly();
		}
	}
}
