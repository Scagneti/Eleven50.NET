using Design_Patter_Command_2.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patter_Command_2.Invoker
{
	class AccountInvoker
	{
		private ICommand _withdraw, _deposit, _getBalnace;

		public AccountInvoker(ICommand withdraw, ICommand deposit, ICommand getBalance)
		{
			_withdraw = withdraw;
			_deposit = deposit;
			_getBalnace = getBalance;
		}

		public void Withdraw()
		{
			_withdraw.Execute();
		}
		public void Deposit()
		{
			_deposit.Execute();
		}
		public void GetBalance()
		{
			_getBalnace.Execute();
		}
	}
}
