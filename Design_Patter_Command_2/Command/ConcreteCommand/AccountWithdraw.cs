using Design_Patter_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patter_Command_2.Command.ConcreteCommand
{
	class AccountWithdraw : ICommand
	{
		private IAccount _account;

		public AccountWithdraw(IAccount account)
		{
			_account = account;
		}

		public void Execute()
		{
			_account.Withdraw();
		}
	}
}
