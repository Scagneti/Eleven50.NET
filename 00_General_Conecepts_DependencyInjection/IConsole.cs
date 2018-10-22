﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Conecepts_DependencyInjection
{
	public interface IConsole
	{
		void WriteLine(string s);
		void WriteLine(object o);
		void Write(string s);
		string Readline();
		ConsoleKeyInfo Readkey();
	}
}
