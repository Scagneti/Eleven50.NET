using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DefiningClasses_04
{
    public class Claim
    {
		public int Amount { get; set; }
		public DateTime ClaimDate { get; set; }

		public Claim(int amount, DateTime claimDate)
		{
			amount = Amount;
			claimDate = ClaimDate;
		}
	}
}
