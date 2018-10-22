using _05_Inheritence_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Bird bird = new Bird();
			Bear bear = new Bear();


			bear.GetMad();
			bird.GetMad();
			bear.Talk();
			bird.Talk();
			
		}
	}
}
