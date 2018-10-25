using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patter_Command_2.Receiver
{
	class MyAccount : IAccount
	{
		public void Deposit()
		{
			Console.WriteLine("How much do you want to deposit?");
			var amount = decimal.Parse(Console.ReadLine());
			Console.WriteLine($"You deposited ${amount}");
		}

		public void GetBalance()
		{
			Console.WriteLine("Sure just let me pull up your balance real quick aaaaaaaaand it's gone.");
		}

		public void Withdraw()
		{
			Console.WriteLine("How much do you want to withdraw?");
			var amount = decimal.Parse(Console.ReadLine());
			Console.WriteLine($"You withdrew ${amount}");
		}
	}
}
