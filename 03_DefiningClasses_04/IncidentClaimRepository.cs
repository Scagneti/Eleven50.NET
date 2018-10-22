using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DefiningClasses_04
{
	public class IncidentClaimRepository
	{
		private Claim claim;
		private Incident incident;


		public bool IsClaimValid(DateTime dayOfClaim, DateTime dayOfIncident)
		{
			bool result;
			if(dayOfClaim > dayOfIncident.AddDays(30))
			{
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
			

		}

		public string ClaimMessage(int claimAmount)
		{
			string message = "";
			if(claimAmount > 10000)
			{
				message = "Please wait while transferring you to a representative.";
			}
			else
			{
				message = "Your claim is being processed.";
			}
			return message;
		}

	}
}
