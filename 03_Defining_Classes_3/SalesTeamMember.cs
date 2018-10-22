using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
    public class SalesTeamMember
    {
		public string LastName { get; set; }
		public int TotalSales { get; set; }

		public SalesTeamMember(string lastName, int sales)
		{
			lastName = LastName;
			sales = TotalSales;
		}

		public SalesTeamMember()
		{
		}
	}
}
