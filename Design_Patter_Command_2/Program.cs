using Design_Patter_Command_2.Command;
using Design_Patter_Command_2.Command.ConcreteCommand;
using Design_Patter_Command_2.Invoker;
using Design_Patter_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patter_Command_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//-- Receiver
			IAccount account = new MyAccount();

			//-- Concrete Commands
			ICommand depositCommand = new AccountDeposit(account);
			ICommand withdrawCommand = new AccountWithdraw(account);
			ICommand getBalanceCommand = new AccountBalance(account);
			bool exitMenuLoop = false;
			while (!exitMenuLoop)
			{


				Console.WriteLine("Please select the type of transaction you would like to make: \n" +
					"1.Withdraw \n" +
					"2.Deposit \n" +
					"3.Account Balance \n" +
					"4.Exit");
				var input = int.Parse(Console.ReadLine());
				//-- Invoker
				AccountInvoker invoker = new AccountInvoker(withdrawCommand, depositCommand, getBalanceCommand);

				switch (input)
				{
					case 1:
						invoker.Withdraw();
						break;
					case 2:
						invoker.Deposit();
						break;
					case 3:
						invoker.GetBalance();
						break;
					case 4:
						exitMenuLoop = true;
						break;
				}

			}
		}
	}
}
