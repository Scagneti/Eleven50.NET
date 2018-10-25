using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patter_Command_2.Receiver
{
	interface IAccount
	{
		void GetBalance();
		void Deposit();
		void Withdraw();
	}
}
